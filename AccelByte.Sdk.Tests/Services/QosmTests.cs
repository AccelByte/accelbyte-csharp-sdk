// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Qosm.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class QosmTests : BaseServiceTests
    {
        public QosmTests() : base(true) { }

        [Test]
        public void ListServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region List servers
            ModelsListServerResponse? aggrs = _Sdk.Qosm.Public.ListServerOp.Execute();
            #endregion
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

            #region Execute heartbeat test against a server
            ModelsHeartbeatRequest createHeartbeat = new ModelsHeartbeatRequest()
            {
                Ip = respIp,
                Region = respRegion,
                Port = respPort,
            };

            _Sdk.Qosm.Server.HeartbeatOp.Execute(createHeartbeat);
            #endregion
        }
    }
}
