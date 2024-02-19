// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Dsartifact.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "ArmadaIntegration")]
    [Explicit]
    public class DSArtifactTests : BaseServiceTests
    {
        public DSArtifactTests() : base(true) { }

        [Test]
        public void ListAllQueueTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ModelsListAllQueueResponse? response = _Sdk.Dsartifact.ArtifactUploadProcessQueue.ListAllQueueOp
                .SetLimit(20)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(response);
        }

        [Test]
        public void ListTerminatedServerTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ModelsListTerminatedServersResponse? response = _Sdk.Dsartifact.AllTerminatedServers.ListTerminatedServersOp
                .SetLimit(20)
                .Execute();
            Assert.IsNotNull(response);
        }
    }
}
