// Copyright (c) 2025 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Loginqueue.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class LoginQueueTests : BaseServiceTests
    {
        public LoginQueueTests() : base(false) { }

        [Test]
        public void ConfigurationTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            if (IsUsingAGSStarter())
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            int updateMaxLoginRate = 100;

            #region Get configuration
            var config = _Sdk.Loginqueue.AdminV1.AdminGetConfigurationOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(config);

            #region Update configuration
            var configUpdate = _Sdk.Loginqueue.AdminV1.AdminUpdateConfigurationOp
                .Execute(new ApimodelsConfigurationRequest()
                {
                    MaxLoginRate = updateMaxLoginRate
                }, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(configUpdate);
            if (configUpdate != null)
                Assert.AreEqual(updateMaxLoginRate, configUpdate.MaxLoginRate);
        }
    }
}