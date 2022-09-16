// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Gametelemetry.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class GameTelemetryTests : BaseServiceTests
    {
        [Test]
        public void GametelemetryServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string steamId = "76561199259217491";
            string playTime = "4";

            #region Save game telemetry event
            _Sdk.Gametelemetry.GametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
                .Execute(new List<TelemetryBody>
                {
                    new TelemetryBody
                    {
                        EventId = "csharpsdk",
                        EventName = "CsharpEvent",
                        EventNamespace = "test",
                        EventTimestamp = DateTime.Now,
                        Payload = new Dictionary<string, object>
                        {
                            {"foo", "bar"}
                        }
                    }
                });
            #endregion

            DisableRetry();
            #region Update steam's playtime
            try
            {
                _Sdk.Gametelemetry.GametelemetryOperations.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutOp
                    .Execute(playTime, steamId);
            }
            catch (HttpResponseException e)
            {
                if (e.Message.ToLower().Contains("user not found"))
                {
                    Assert.Ignore("User not found.");
                }
            }
            #endregion

            #region Get steam's playtime
            Dictionary<string, object>? resGet = _Sdk.Gametelemetry.GametelemetryOperations
                .ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetOp
                .Execute(steamId);
            #endregion
            Assert.IsNotNull(resGet);
            Assert.Contains("total_playtime", resGet);
            Assert.Equals(playTime, resGet!["total_playtime"]);
        }
    }
}
