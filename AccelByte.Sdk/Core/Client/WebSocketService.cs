// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;

using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Awesome;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Api.Lobby.WSModel;

namespace AccelByte.Sdk.Core
{
    public abstract class WebSocketService : ITokenRepositoryObserver
    {
        public const int ERROR_PROCESS_MESSAGE = 1;

        public const int ERROR_WEB_SOCKET_RECEIVE = 2;

        public const int ERROR_INVALID_CONTROL_MESSAGE = 11;

        public const int ERROR_COMPRESSED_FRAME_RECEIVED = 12;

        private ClientWebSocket _Socket;

        private AccelByteConfig? _Config = null;

        private string _BaseUrl;

        private CancellationTokenSource _ListenCts = new CancellationTokenSource();

        private int _ReconnectAttemps = 0;

        protected Dictionary<string, PropertyInfo> _EventActions = new Dictionary<string, PropertyInfo>();

        public abstract string ServiceEndpoint { get; }

        public Action? OnConnected { get; set; } = null;

        public Action<int, bool>? OnClosed { get; set; } = null;            

        public Action<string>? OnRawMessageReceived { get; set; } = null;

        public Action<Message>? OnMessageReceived { get; set; } = null;

        public Action<Message>? OnUnlistedMessageReceived { get; set; } = null;

        public Action? OnMessagePrehandled { get; set; } = null;

        public Action<string, int>? OnReceiveError { get; set; } = null;

        public bool RedirectAllReceivedMessagesToMessageReceivedEvent { get; set; } = false;

        public bool ProcessRawMessage { get; set; } = true;

        public Dictionary<string, string> AdditionalHeaders { get; } = new();

        /// <summary>
        /// Allow reconnect when upstream is abruptly disconnected. Default to true. 
        /// </summary>
        public bool AllowReconnect { get; set; } = true;

        /// <summary>
        /// Maximum number of reconnect attempts. Positive value integer. Set 0 for unlimited attempts. Default is 0.
        /// </summary>
        public int MaxReconnectAttempts { get; set; } = 0;

        public WebSocketService(AccelByteConfig abConfig)
        {
            _Config = abConfig;
            _BaseUrl = abConfig.ConfigRepository.BaseUrl.Replace("http://", "ws://").Replace("https://", "wss://");
            _Socket = _CreateSocket();
            _MapEventActions();

            if (abConfig.TokenRepository is IObservableTokenRepository)
                ((IObservableTokenRepository)abConfig.TokenRepository).RegisterObserver(this);
        }

        [Obsolete("Use the one with AccelByteConfig parameter to automatically register OnAccessTokenChanged event.")]
        public WebSocketService(string baseUrl)
        {
            _BaseUrl = baseUrl;
            _Socket = _CreateSocket();
            _MapEventActions();
        }

        private ClientWebSocket _CreateSocket()
        {
            var wsClient = new ClientWebSocket();
            wsClient.Options.DangerousDeflateOptions = new WebSocketDeflateOptions()
            {
                ServerContextTakeover = false,
                ClientMaxWindowBits = 15                
            };

            return wsClient;
        }

        private void _MapEventActions()
        {
            _EventActions.Clear();
            foreach (PropertyInfo pInfo in this.GetType().GetProperties())
            {
                WebSocketEventAttribute? attr = pInfo.GetCustomAttribute<WebSocketEventAttribute>();
                if (attr != null)
                {
                    if (_EventActions.ContainsKey(attr.Name))
                        _EventActions[attr.Name] = pInfo;
                    else
                        _EventActions.Add(attr.Name, pInfo);
                }
            }
        }

        protected bool ShouldReconnect(int code, int noOfAttemps)
        {
            if (!AllowReconnect)
                return false;

            if ((MaxReconnectAttempts > 0) && (noOfAttemps > MaxReconnectAttempts))
                return false;

            return code switch
            {
                // Undefined
                < 0 => false,

                // Status codes in the range 0-999 are not used.
                >= 0 and <= 999 => false,

                // 1000 indicates a normal closure, meaning that the purpose for
                // which the connection was established has been fulfilled.
                1000 => false,

                // Only reconnect if codes in range 1001-2999
                >= 1001 and <= 2999 => true,

                // Status codes in the range 3000-3999 are reserved for use by
                // libraries, frameworks, and applications.  These status codes are
                // registered directly with IANA.  The interpretation of these codes
                // is undefined by this protocol.
                >= 3000 and <= 3999 => false,

                // Status codes in the range 4000-4999 are reserved for private use
                // and thus can't be registered.  Such codes can be used by prior
                // agreements between WebSocket applications.  The interpretation of
                // these codes is undefined by this protocol.
                >= 4000 and <= 4999 => false,

                // Undefined
                >= 5000 => false
            };
        }

        protected int ReconnectDelay(int noOfAttempts)
        {
            const double _INTERVAL = 100.0;
            const double _BACKOFF_RATE = 2.0;

            return (int)Math.Round(_INTERVAL * Math.Pow(_BACKOFF_RATE, noOfAttempts));
        }

        protected virtual void PreHandleMessage(Message message) { }

        protected virtual void Cleanup() { }

        protected virtual async Task InternalConnect(bool createNewSocket)
        {
            if (createNewSocket)
                _Socket = _CreateSocket();

            string url = (_BaseUrl + ServiceEndpoint);
            if (_Config != null)
            {
                if (!string.IsNullOrEmpty(_Config.TokenRepository.Token))
                {
                    string token = _Config.TokenRepository.Token;
                    _Socket.Options.SetRequestHeader("Authorization", String.Format("{0} {1}", Operation.SECURITY_BEARER, token));
                    foreach (var aHeader in AdditionalHeaders)
                        _Socket.Options.SetRequestHeader(aHeader.Key, aHeader.Value);
                }
            }

            await _Socket.ConnectAsync(new Uri(url), CancellationToken.None);
            OnConnected?.Invoke();
        }

        protected virtual async Task ReceiveWebSocket(CancellationToken cancelToken)
        {
            var buffer = new ArraySegment<byte>(new byte[2048]);
            do
            {
                WebSocketReceiveResult? result = null;
                bool isReceiveError = false;
                using (MemoryStream ms = new MemoryStream())
                {
                    do
                    {
                        try
                        {
                            result = await _Socket.ReceiveAsync(buffer, cancelToken);
                            ms.Write(buffer.Array!, buffer.Offset, result.Count);
                        }
                        catch (Exception x)
                        {
                            if (x.Message == "The WebSocket received an invalid control message.")
                                OnReceiveError?.Invoke(x.Message, ERROR_INVALID_CONTROL_MESSAGE);
                            else if (x.Message == "The WebSocket received compressed frame when compression is not enabled.")
                                OnReceiveError?.Invoke(x.Message, ERROR_COMPRESSED_FRAME_RECEIVED);
                            else
                                OnReceiveError?.Invoke(x.Message, ERROR_WEB_SOCKET_RECEIVE);
                            isReceiveError = true;

                            break;
                        }
                    }
                    while ((result != null) && (!result.EndOfMessage) && (!isReceiveError));

                    if (result != null)
                    {
                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            int statusCode = 0;
                            if (result.CloseStatus != null)
                                statusCode = (int)result.CloseStatus;

                            OnClosed?.Invoke(statusCode, isReceiveError);
                            bool shouldReconnect = ShouldReconnect(statusCode, _ReconnectAttemps);
                            if (shouldReconnect)
                            {
                                _ReconnectAttemps += 1;
                                int delay = ReconnectDelay(_ReconnectAttemps);
                                await InternalConnect(true);
                            }
                            else
                                break;
                        }
                    }
                    else
                    {
                        if (_Socket.State == WebSocketState.Closed && isReceiveError)
                        {
                            int statusCode = 2900;
                            if (_Socket.CloseStatus != null)
                                statusCode = (int)_Socket.CloseStatus;

                            OnClosed?.Invoke(statusCode, isReceiveError);
                            bool shouldReconnect = ShouldReconnect(statusCode, _ReconnectAttemps);
                            if (shouldReconnect)
                            {
                                _ReconnectAttemps += 1;
                                int delay = ReconnectDelay(_ReconnectAttemps);
                                Thread.Sleep(delay);

                                await InternalConnect(true);
                            }
                            else
                                break;
                        }
                        else if (ms.Length == 0)
                            break;
                    }

                    OnWebSocketMessageReceived(ms);
                }
            }
            while (true);

            Cleanup();
        }

        protected virtual void OnWebSocketMessageReceived(MemoryStream ms)
        {
            ms.Seek(0, SeekOrigin.Begin);
            using (StreamReader reader = new StreamReader(ms, Encoding.UTF8))
            {
                string rawMessage = reader.ReadToEnd();
                OnRawMessageReceived?.Invoke(rawMessage);

                if (ProcessRawMessage)
                {
                    try
                    {
                        Message message = new Message(rawMessage);
                        PreHandleMessage(message);
                        OnMessagePrehandled?.Invoke();

                        if (RedirectAllReceivedMessagesToMessageReceivedEvent)
                            OnMessageReceived?.Invoke(message);
                        else
                        {
                            if (!_EventActions.ContainsKey(message.MessageType))
                            {
                                if (OnUnlistedMessageReceived != null)
                                    OnUnlistedMessageReceived(message);
                                else
                                    throw new Exception("Unknown message type.");
                            }

                            PropertyInfo pInfo = _EventActions[message.MessageType];
                            Type modelType = pInfo.PropertyType.GetGenericArguments().First();

                            var aEvent = pInfo.GetValue(this);
                            if (aEvent != null)
                            {
                                object respModelObj = message.To(modelType);
                                aEvent!.GetType().GetMethod("Invoke")!.Invoke(aEvent, new object[] { respModelObj });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        OnReceiveError?.Invoke(ex.Message, ERROR_PROCESS_MESSAGE);
                    }
                }
            }
        }

        public async Task Connect(bool startListen)
        {
            _ReconnectAttemps = 0;
            await InternalConnect(true);
            if (startListen)
                await ReceiveWebSocket(_ListenCts.Token);
        }

        public async Task Listen()
        {
            await ReceiveWebSocket(_ListenCts.Token);
        }

        public async Task Listen(CancellationToken cancelToken)
        {
            await ReceiveWebSocket(cancelToken);
        }

        public void StopListen()
        {
            _ListenCts.Cancel();
        }

        public async Task Disconnect()
        {
            if (_Socket.State == WebSocketState.Open)
                await _Socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
        }

        public async Task Send(object modelObject, int errorCode)
        {
            Message msg = new Message(modelObject);
            msg.Code = errorCode;
            await _Socket.SendAsync(msg.ToByteArray(), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task Send(object modelObject)
        {
            Message msg = new Message(modelObject);
            await _Socket.SendAsync(msg.ToByteArray(), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task Send(string data)
        {
            ArraySegment<byte> dataSegment = Encoding.UTF8.GetBytes(data);
            await _Socket.SendAsync(dataSegment, WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task OnAccessTokenChanged(string accessToken)
        {
            if (_Socket.State == WebSocketState.Open)
            {
                RefreshTokenRequest request = new RefreshTokenRequest()
                {
                    Id = Helper.GenerateRandomId(16),
                    Token = accessToken
                };

                await Send(request);
            }
            else
                await Task.CompletedTask;
        }
    }
}