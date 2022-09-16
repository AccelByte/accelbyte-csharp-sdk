﻿// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Tests.Integration;

namespace AccelByte.Sdk.Tests.Services
{
    public abstract class BaseServiceTests : BaseIntegrationTest
    {
        HttpClientPolicy? _RetryPolicy = null;

        [OneTimeSetUp]
        public void Startup()
        {
            _RetryPolicy = HttpClientPolicy.Default;
            _RetryPolicy.MaxRetryCount = 1000;
            _RetryPolicy.RetryInterval = 1000;
            _RetryPolicy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");

            _Sdk = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(_RetryPolicy)
                    .Build())
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

        [SetUp]
        public void ResetPolicy()
        {
            if (_RetryPolicy != null)
                _RetryPolicy.RetryOnException = true;
        }

        public void DisableRetry()
        {
            if (_RetryPolicy != null)
                _RetryPolicy.RetryOnException = false;
        }
    }
}