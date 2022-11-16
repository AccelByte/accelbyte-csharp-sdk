// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Match2.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class MatchV2Tests : BaseServiceTests
    {
        [Test]
        public void HealthCheckTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Assert.DoesNotThrow(() =>
            {
                _Sdk.Match2.Operations.GetHealthcheckInfoV1Op
                    .Execute();
            });
        }

        [Test]
        public void ListTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var response = _Sdk.Match2.MatchFunctions.MatchFunctionListOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(response);
        }
    }
}