// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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
        private HttpClientPolicy _RetryPolicy;

        private bool _UseUserLogin;

        protected virtual void OnStartup(AccelByteSDK sdk) { }

        protected virtual void OnBeforeEnd() { }

        public BaseServiceTests(bool useUserLogin)
        {
            _UseUserLogin = useUserLogin;

            _RetryPolicy = HttpClientPolicy.Default;
            _RetryPolicy.MaxRetryCount = 3;
            _RetryPolicy.RetryInterval = 500;
            _RetryPolicy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");
        }

        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(_RetryPolicy)
                    .Build())
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            if (_UseUserLogin)
                _Sdk.LoginUser();
            else
                _Sdk.LoginClient();

            OnStartup(_Sdk);
        }

        [OneTimeTearDown]
        public void End()
        {
            OnBeforeEnd();
            _Sdk?.Logout();
        }

        [SetUp]
        public void ResetPolicy()
        {
            _RetryPolicy.RetryOnException = true;
        }

        public void DisableRetry()
        {
            _RetryPolicy.RetryOnException = false;
        }
    }
}