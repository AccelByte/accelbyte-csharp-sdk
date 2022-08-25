// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Awesome;

using AccelByte.Sdk.Api.Lobby;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    public class WebSocketCommand
    {
        private Dictionary<string, Type> _ServiceTypes = new Dictionary<string, Type>()
        {
            { "lobby", typeof(LobbyService) }
        };

        private AccelByteConfig _Config;

        private volatile Message? _ReceivedMessage = null;

        private volatile bool _IsError = false;

        public WebSocketCommand(AccelByteConfig abConfig)
        {
            _Config = abConfig;
        }

        public WebSocketService InitializeService(AccelByteConfig abConfig, string serviceName)
        {
            if (!_ServiceTypes.ContainsKey(serviceName))
                throw new Exception("WebSocket '" + serviceName + "' does not exists.");

            Type wsType = _ServiceTypes[serviceName];

            WebSocketService? newObj = (WebSocketService?)Activator.CreateInstance(wsType, abConfig);
            if (newObj == null)
                throw new Exception("Could not create new WebSocketService instance.");
            return newObj;
        }

        public List<Type> GetModelTypes(string serviceName,bool isRequestTypeOnly)
        {
            if (!_ServiceTypes.ContainsKey(serviceName))
                throw new Exception("WebSocket '" + serviceName + "' does not exists.");
            Type wsType = _ServiceTypes[serviceName];
            Type wsmBaseType = typeof(AccelByte.Sdk.Core.WSModel);

            string wsModelNs = (wsType.Namespace + ".WSModel");
            int nspCount = wsModelNs.Length;

            List<Type> modelTypes = new List<Type>();
            foreach (Type t in wsType.Assembly.GetTypes())
            {
                if (t.Namespace == null)
                    continue;
                if (t.Namespace == wsModelNs)
                {
                    if (isRequestTypeOnly)
                    {
                        if (t.Name.ToLower()[^7..] == "request")
                            modelTypes.Add(t);
                    }
                    else
                        modelTypes.Add(t);
                }                    
            }

            return modelTypes;
        }

        public string Execute(string serviceName, string payload)
        {
            WebSocketService wsObj = InitializeService(_Config, serviceName);
            wsObj.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
            wsObj.OnMessageReceived = (aMsg) =>
            {
                _ReceivedMessage = aMsg;
            };
            wsObj.OnReceiveError = (eMsg) =>
            {
                _IsError = true;
                Console.WriteLine("Error: {0}", eMsg);
            };

            Task connectTak = wsObj.Connect(false);
            connectTak.Wait();

            Task listenTask = Task.Run(() => wsObj.Listen());

            Task sendTask = wsObj.Send(payload);
            sendTask.Wait();

            //Now wait for the response message...
            while (true)
            {
                if (_IsError == true)
                    break;

                if (_ReceivedMessage == null)
                    Thread.Sleep(100);
                else
                    break;
            }

            Task disconnectTask = wsObj.Disconnect();
            disconnectTask.Wait();

            if (_IsError || (_ReceivedMessage == null))
                return String.Empty;
            else
                return _ReceivedMessage.ToString();
        }

        public string Execute(string serviceName, object payload)
        {
            WebSocketService wsObj = InitializeService(_Config, serviceName);
            wsObj.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
            wsObj.OnMessageReceived = (aMsg) =>
            {
                _ReceivedMessage = aMsg;
            };
            wsObj.OnReceiveError = (eMsg) =>
            {
                _IsError = true;
                Console.WriteLine("Error: {0}", eMsg);
            };

            Task connectTak = wsObj.Connect(false);
            connectTak.Wait();

            Task listenTask = Task.Run(() => wsObj.Listen());

            Task sendTask = wsObj.Send(payload);
            sendTask.Wait();

            //Now wait for the response message...
            while (true)
            {
                if (_IsError == true)
                    break;

                if (_ReceivedMessage == null)
                    Thread.Sleep(100);
                else
                    break;
            }

            Task disconnectTask = wsObj.Disconnect();
            disconnectTask.Wait();

            if (_IsError || (_ReceivedMessage == null))
                return String.Empty;
            else
                return _ReceivedMessage.ToString();
        }

        public void Listen(string serviceName)
        {
            WebSocketService wsObj = InitializeService(_Config, serviceName);
            wsObj.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
            wsObj.OnMessageReceived = (aMsg) =>
            {
                _ReceivedMessage = aMsg;
            };

            Task connectTak = wsObj.Connect(false);
            connectTak.Wait();

            Console.WriteLine("WebSocket service listen started. Press [ENTER] to stop listening.");
            Task listenTask = Task.Run(() => wsObj.Listen());

            Console.ReadLine();

            Task disconnectTask = wsObj.Disconnect();
            disconnectTask.Wait();
        }
    }
}