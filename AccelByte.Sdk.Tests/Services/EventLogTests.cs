// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Eventlog.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class EventLogTests : BaseServiceTests
    {
        public EventLogTests() : base(true) { }

        [Test]
        [Ignore("Eventlog service is planned for deprecation")]
        public void EventLogServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            #region Query event stream
            ModelsGenericQueryPayload eQueryPayload = new ModelsGenericQueryPayload()
            {
                ClientId = _Sdk.Configuration.ConfigRepository.ClientId
            };

            ModelsEventResponseV2? eResp = _Sdk.Eventlog.EventV2.QueryEventStreamHandlerOp
                .SetOffset(0)
                .SetPageSize(10)
                .Execute(eQueryPayload, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(eResp);

            try
            {
                DisableRetry();
                #region Get specific user's event
                ModelsEventResponseV2? cResp = _Sdk.Eventlog.EventV2.GetEventSpecificUserV2HandlerOp
                    .SetOffset(0)
                    .SetPageSize(10)
                    .Execute(_Sdk.Namespace, _Sdk.Configuration.Credential!.UserId);
                #endregion
                Assert.IsNotNull(cResp);
            }
            catch (Exception x)
            {
                ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                if (mer == null)
                    throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");
                if (mer.ErrorMessage != "data not found")
                    throw new Exception(mer.ErrorMessage, x);
            }
        }
    }
}
