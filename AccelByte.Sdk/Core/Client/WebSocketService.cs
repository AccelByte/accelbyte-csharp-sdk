// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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

namespace AccelByte.Sdk.Core
{
    public abstract class WebSocketService
    {
        private ClientWebSocket _Socket;

        private AccelByteConfig? _Config = null;

        private string _BaseUrl;

        private CancellationTokenSource _ListenCts = new CancellationTokenSource();

        protected Dictionary<string, PropertyInfo> _EventActions = new Dictionary<string, PropertyInfo>();

        public abstract string ServiceEndpoint { get; }

        public Action<Message>? OnMessageReceived { get; set; } = null;

        public Action<string>? OnReceiveError { get; set; } = null;

        public bool RedirectAllReceivedMessagesToMessageReceivedEvent { get; set; } = false;

        public WebSocketService(AccelByteConfig abConfig)
        {
            _Config = abConfig;
            _BaseUrl = abConfig.ConfigRepository.BaseUrl.Replace("http://", "ws://").Replace("https://", "wss://");
            _Socket = new ClientWebSocket();
            _MapEventActions();
        }

        public WebSocketService(string baseUrl)
        {
            _BaseUrl = baseUrl;
            _Socket = new ClientWebSocket();
            _MapEventActions();
        }

        private void _MapEventActions()
        {
            _EventActions.Clear();
            foreach(PropertyInfo pInfo in this.GetType().GetProperties())
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
                WebSocketReceiveResult result;
                using (MemoryStream ms = new MemoryStream())
                {
                    do
                    {
                        result = await _Socket.ReceiveAsync(buffer, cancelToken);
                        ms.Write(buffer.Array!, buffer.Offset, result.Count);
                    }
                    while (!result.EndOfMessage);

                    if (result.MessageType == WebSocketMessageType.Close)
                        break;

                    ms.Seek(0, SeekOrigin.Begin);
                    using (StreamReader reader = new StreamReader(ms, Encoding.UTF8))
                    {
                        string rawMessage = reader.ReadToEnd();
                        //Console.WriteLine("RECEIVED MESSAGE: {0}", rawMessage);
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
                            OnReceiveError?.Invoke(ex.Message);
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
    }
}