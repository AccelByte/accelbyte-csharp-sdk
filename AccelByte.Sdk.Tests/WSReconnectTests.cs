// Copyright (c) 2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using NUnit.Framework;

using AccelByte.Sdk.Api.Lobby;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Tests.MockServer;
using AccelByte.Sdk.Core.Client;
using System.Net.Http;

namespace AccelByte.Sdk.Tests
{
    [TestFixture(Category = "WebSocketMockTest")]
    [Explicit]
    public class WSReconnectTests
    {
        private MockServerConfigRepository _MSConfigRepo = new MockServerConfigRepository();

        private MockServerTokenRepository _MSTokenRepo = new MockServerTokenRepository();

        protected void MockForceClose(int errorCode)
        {
            string url = _MSConfigRepo.BaseUrl + "/ws/lobby/force-close";
            if (errorCode > 0)
                url += "?errorCode=" + errorCode.ToString();

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);
            DefaultHttpClient.Http.Send(req);
        }

        protected void MockSendDisconnectNotif()
        {
            string url = _MSConfigRepo.BaseUrl + "/ws/lobby/force-close";

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);

            string msg = "{\"disconnectNotif\":\"type: disconnectNotif\\ncode:4000\"}";
            req.Content = new StringContent(msg, Encoding.UTF8, "application/json");

            DefaultHttpClient.Http.Send(req);
        }

        [Test]
        public async Task ReconnectTestCase1()
        {
            MockTestLogger logger = new MockTestLogger();
            using var sdk = AccelByteSDK.Builder
                .SetConfigRepository(_MSConfigRepo)
                .SetTokenRepository(_MSTokenRepo)
                .UseDefaultHttpClient()
                .SetLogger(logger)
                .EnableLog()
                .Build();

            sdk.LoginUser("admin", "admin");

            var lobbyWs = new LobbyService(sdk.Configuration);
            lobbyWs.RedirectAllReceivedMessagesToMessageReceivedEvent = true;

            Timer forceCloseTimer = new Timer((pObj) =>
            {
                MockForceClose(2000);

            }, null, Timeout.Infinite, Timeout.Infinite);

            Timer finishTimer = new Timer(async (pObj) =>
            {
                await lobbyWs.Disconnect();

            }, null, Timeout.Infinite, Timeout.Infinite);


            int connectCount = 0;
            int disconnectCount = 0;
            List<string> sessionIds = new();

            lobbyWs.OnConnected = () =>
            {
                connectCount++;
            };

            lobbyWs.OnClosed = (code, isError) =>
            {
                disconnectCount++;
            };

            lobbyWs.OnMessagePrehandled = () =>
            {
                if (lobbyWs.AdditionalHeaders.ContainsKey("X-Ab-LobbySessionID"))
                    sessionIds.Add(lobbyWs.AdditionalHeaders["X-Ab-LobbySessionID"]);
            };

            //start connect
            await lobbyWs.Connect(false);

            //tell mock server to close connection in 2s
            forceCloseTimer.Change(2000, Timeout.Infinite);

            //close lobby ws after 4s
            finishTimer.Change(4000, Timeout.Infinite);

            //start listen
            await lobbyWs.Listen();

            //connect count must be greater or equal than 2, why?
            //first from normal connect
            //second from reconnect after force close
            //if less than 2, then something is not working
            Assert.GreaterOrEqual(connectCount, 2, "Connect count is under 2, reconnect didn't happen");

            //disconnect count must be greater or equal than 2, why?
            //first from forced close
            //second from normal closure
            //if less than 2, then something is not working
            Assert.GreaterOrEqual(disconnectCount, 2, "Disconnect count is under 2, reconnect didn't happen");

            //every connect/reconnect will store session id in above logic
            //this assertion is to make sure that all stored ids are same.
            var isSameId = sessionIds.All(x => x == sessionIds.First());
            Assert.IsTrue(isSameId, "Session id is different between connect session(s).");            
        }

        [Test]
        public async Task ReconnectTestCase2()
        {
            MockTestLogger logger = new MockTestLogger();
            using var sdk = AccelByteSDK.Builder
                .SetConfigRepository(_MSConfigRepo)
                .SetTokenRepository(_MSTokenRepo)
                .UseDefaultHttpClient()
                .SetLogger(logger)
                .EnableLog()
                .Build();

            sdk.LoginUser("admin", "admin");

            var lobbyWs = new LobbyService(sdk.Configuration);
            lobbyWs.RedirectAllReceivedMessagesToMessageReceivedEvent = true;

            Timer forceCloseTimer = new Timer((pObj) =>
            {
                MockSendDisconnectNotif();

            }, null, Timeout.Infinite, Timeout.Infinite);

            Timer finishTimer = new Timer(async (pObj) =>
            {
                await lobbyWs.Disconnect();

            }, null, Timeout.Infinite, Timeout.Infinite);


            int connectCount = 0;
            int disconnectCount = 0;
            List<string> sessionIds = new();

            lobbyWs.OnConnected = () =>
            {
                connectCount++;
            };

            lobbyWs.OnClosed = (code, isError) =>
            {
                disconnectCount++;
            };

            lobbyWs.OnMessagePrehandled = () =>
            {
                if (lobbyWs.AdditionalHeaders.ContainsKey("X-Ab-LobbySessionID"))
                    sessionIds.Add(lobbyWs.AdditionalHeaders["X-Ab-LobbySessionID"]);
            };

            //start connect
            await lobbyWs.Connect(false);

            //tell mock server to send disconnect notif
            forceCloseTimer.Change(2000, Timeout.Infinite);

            //start listen
            await lobbyWs.Listen();

            //should be normally closed, assert connect and disconnect count
            Assert.AreEqual(1, connectCount,"Unexpected connect count. WS issue?");
            Assert.AreEqual(1, disconnectCount, "Unexpected disconnect count. WS issue?");

            //reset
            connectCount = 0;
            disconnectCount = 0;

            //start connect (again)
            await lobbyWs.Connect(false);

            //tell mock server to send disconnect notif
            forceCloseTimer.Change(2000, Timeout.Infinite);

            //start listen
            await lobbyWs.Listen();

            //should be normally closed, assert connect and disconnect count
            //But now we'll be only check session ids.

            var isSameId = sessionIds.All(x => x == sessionIds.First());
            Assert.IsFalse(isSameId, "Session id is not different between connect session(s).");
        }
    }
}
