// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Session.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SessionTests : BaseServiceTests
    {
        [Test]
        public void QueryGameSessions()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            var response = _Sdk.Session.GameSession.PublicQueryGameSessionsOp
                .Execute(new Dictionary<string, object>() { }, _Sdk.Namespace);
            Assert.IsNotNull(response);
        }
    }
}