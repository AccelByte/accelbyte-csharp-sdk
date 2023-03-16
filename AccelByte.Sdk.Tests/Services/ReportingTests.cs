// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Reporting.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class ReportingTests : BaseServiceTests
    {
        public ReportingTests() : base(true) { }

        [Test]
        public void ReportingServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string title = Helper.GenerateRandomId(32);
            string reasonId = String.Empty;

            Api.Reporting.Wrapper.AdminReasons wAdminReasons = new Api.Reporting.Wrapper.AdminReasons(_Sdk);

            #region Create a Reason
            Api.Reporting.Model.RestapiCreateReasonRequest createReason = new Api.Reporting.Model.RestapiCreateReasonRequest()
            {
                Description = title,
                GroupIds = new List<string>(),
                Title = title,
            };

            Api.Reporting.Model.RestapiAdminReasonResponse? cReason = wAdminReasons.CreateReason(
                Api.Reporting.Operation.CreateReason.Builder
                .Build(
                    createReason,
                    _Sdk.Namespace
                ));
            Assert.IsNotNull(cReason);
            if (cReason != null)
            {
                Assert.IsNotNull(cReason.Id);                
                if (cReason.Id != null)
                    reasonId = cReason.Id;

                Assert.AreEqual(title, cReason.Title);
            }
            #endregion

            Assert.True(reasonId != String.Empty);

            #region Get single Reason
            Api.Reporting.Model.RestapiAdminReasonResponse? cReason2 = wAdminReasons.AdminGetReason(
                Api.Reporting.Operation.AdminGetReason.Builder
                .Build(_Sdk.Namespace, reasonId));
            Assert.IsNotNull(cReason2);
            if (cReason2 != null)
            {
                Assert.IsNotNull(cReason2.Id);
                Assert.AreEqual(title, cReason2.Title);
            }
            #endregion

            #region Delete a Reporting
            wAdminReasons.DeleteReason(
                Api.Reporting.Operation.DeleteReason.Builder
                .Build(_Sdk.Namespace, reasonId));
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                Api.Reporting.Model.RestapiAdminReasonResponse? cReason3 = wAdminReasons.AdminGetReason(
                    Api.Reporting.Operation.AdminGetReason.Builder
                    .Build(_Sdk.Namespace, reasonId));
            });
        }
    }
}
