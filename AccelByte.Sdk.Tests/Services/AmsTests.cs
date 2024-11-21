// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Ams.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class AmsTests : BaseServiceTests
    {
        public AmsTests() : base(false) { }

        [Test]
        public void InfoTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            DisableRetry();

            ApiAMSRegionsResponse? regions = _Sdk.Ams.AMSInfo.InfoRegionsOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(regions);
            Assert.GreaterOrEqual(regions!.Regions!.Count, 1);

            var instances = _Sdk.Ams.AMSInfo.InfoSupportedInstancesOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(instances);
            Assert.GreaterOrEqual(instances!.AvailableInstanceTypes!.Count, 1);

            ResetPolicy();
        }
    }
}
