// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby;


namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class LobbyTests : BaseServiceTests
    {
        public LobbyTests() : base(true) { }

        [Test]
        public void LobbyAPIServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Send free form notification
            ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
            {
                Topic = "csharp_sdk_test",
                Message = "This is integration test for CSharp Server SDK."
            };

            _Sdk.Lobby.Admin.FreeFormNotificationOp
                .Execute(notifBody, _Sdk.Namespace);
            #endregion
        }

        [Test]
        public void LobbyConnectAndCheckPresenceTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            if (_Sdk.Configuration.Credential == null)
                throw new Exception("Credential object is null. Please use User Login for this test.");

            string currentUserId = _Sdk.Configuration.Credential.UserId;

            LobbyService lobby = new LobbyService(_Sdk.Configuration);
            lobby.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
            lobby.OnMessageReceived = (aMsg) =>
            {
                //dump
            };

            Task connectTak = lobby.Connect(false);
            connectTak.Wait();

            HandlersGetUsersPresenceResponse? userPresence = _Sdk.Lobby.Presence.UsersPresenceHandlerV1Op
                .Execute(_Sdk.Namespace, currentUserId);
            Assert.IsNotNull(userPresence);
            if (userPresence != null)
            {
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                {
                    HandlersUserPresence upItem = userPresence.Data[0];
                    Assert.AreEqual("online", upItem.Availability);
                }
                else
                    Assert.Fail("No user presence data");
            }

            Task disconnectTask = lobby.Disconnect();
            disconnectTask.Wait();

            userPresence = _Sdk.Lobby.Presence.UsersPresenceHandlerV1Op
                .Execute(_Sdk.Namespace, currentUserId);
            Assert.IsNotNull(userPresence);
            if (userPresence != null)
            {
                if ((userPresence.Data != null) && (userPresence.Data.Count > 0))
                {
                    HandlersUserPresence upItem = userPresence.Data[0];
                    Assert.AreEqual("offline", upItem.Availability);
                }
                else
                    Assert.Fail("No user presence data");
            }

            ResetPolicy();
        }
    }
}
