// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Gdpr.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class GdprTests : BaseServiceTests
    {
        public GdprTests() : base(true) { }

        [Test]
        public void GdprServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string firstEmailToTest = "dummy@example.com";
            string anotherEmailToTest = "anotheremail@dummy.com";

            #region Save e-mail configuration
            _Sdk.Gdpr.DataRetrieval.SaveAdminEmailConfigurationOp
                .Execute(new List<string>
                {
                    firstEmailToTest
                }, _Sdk.Namespace);
            #endregion

            #region Get e-mail configuration
            List<string>? emails = _Sdk.Gdpr.DataRetrieval.GetAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(emails);

            #region Update e-mail configuration
            _Sdk.Gdpr.DataRetrieval.UpdateAdminEmailConfigurationOp
                .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace);
            #endregion

            #region Delete e-mail configuration
            _Sdk.Gdpr.DataRetrieval.DeleteAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest });
            #endregion
        }
    }
}
