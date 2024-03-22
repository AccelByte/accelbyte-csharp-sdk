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

        protected Dictionary<string, PropertyInfo> _EventActions = new Dictionary<string, PropertyInfo>();

        public abstract string ServiceEndpoint { get; }

        public Action<string>? OnRawMessageReceived { get; set; } = null;

        public Action<Message>? OnMessageReceived { get; set; } = null;

        public Action<string, int>? OnReceiveError { get; set; } = null;

        public bool RedirectAllReceivedMessagesToMessageReceivedEvent { get; set; } = false;

        public bool ProcessRawMessage { get; set; } = true;

        public WebSocketService(AccelByteConfig abConfig)
        {
            _Config = abConfig;
            _BaseUrl = abConfig.ConfigRepository.BaseUrl.Replace("http://", "ws://").Replace("https://", "wss://");
            _Socket = new ClientWebSocket();
            _MapEventActions();

            if (abConfig.TokenRepository is IObservableTokenRepository)
                ((IObservableTokenRepository)abConfig.TokenRepository).RegisterObserver(this);
        }

        [Obsolete("Use the one with AccelByteConfig parameter to automatically register OnAccessTokenChanged event.")]
        public WebSocketService(string baseUrl)
        {
            _BaseUrl = baseUrl;
            _Socket = new ClientWebSocket();
            _MapEventActions();
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

        private async Task _ReceiveWebSocket(CancellationToken cancelToken)
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
                            break;
                    }
                    else
                    {
                        if (ms.Length == 0)
                            break;
                    }

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
                                if (RedirectAllReceivedMessagesToMessageReceivedEvent)
                                    OnMessageReceived?.Invoke(message);
                                else
                                {
                                    if (!_EventActions.ContainsKey(message.MessageType))
                                        throw new Exception("Unknown message type.");

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
            }
            while (true);
        }

        public async Task Connect(bool startListen)
        {
            string url = (_BaseUrl + ServiceEndpoint);
            if (_Config != null)
            {
                if (!string.IsNullOrEmpty(_Config.TokenRepository.Token))
                {
                    string token = _Config.TokenRepository.Token;
                    _Socket.Options.SetRequestHeader("Authorization", String.Format("{0} {1}", Operation.SECURITY_BEARER, token));
                }
            }

            await _Socket.ConnectAsync(new Uri(url), CancellationToken.None);
            if (startListen)
                await _ReceiveWebSocket(_ListenCts.Token);
        }

        public async Task Listen()
        {
            await _ReceiveWebSocket(_ListenCts.Token);
        }

        public async Task Listen(CancellationToken cancelToken)
        {
            await _ReceiveWebSocket(cancelToken);
        }

        public void StopListen()
        {
            _ListenCts.Cancel();
        }

        public async Task Disconnect()
        {
            _ListenCts.Cancel();
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