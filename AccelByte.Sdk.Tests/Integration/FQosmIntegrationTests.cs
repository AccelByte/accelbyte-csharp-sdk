// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Qosm.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FQosmIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        [Test]
        public void ListServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;
            
            ModelsListServerResponse? aggrs = _Sdk.Qosm.Public.ListServerOp.Execute();
            Assert.IsNotNull(aggrs);
        }

        [Test]
        public void HeartbeatTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;
            
            ModelsListServerResponse? listServers = _Sdk.Qosm.Public.ListServerOp.Execute();

            var servers = listServers?.Servers!;
            string? respIp = string.Empty;
            string? respRegion = string.Empty;
            int? respPort = 0;

            if (listServers != null)
            {
                var resp = servers[0];
                respIp = resp.Ip;
                respRegion = resp.Region;
                respPort = resp.Port;
            }
            else
            {
                Assert.Ignore("response 'Servers' is empty");
            }
            
            ModelsHeartbeatRequest createHeartbeat = new ModelsHeartbeatRequest()
            {
                Ip = respIp,
                Region = respRegion,
                Port = respPort,
            };

            _Sdk.Qosm.Server.HeartbeatOp.Execute(createHeartbeat);
        }
    }
}