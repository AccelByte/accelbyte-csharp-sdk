// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Tests.Integration;
using AccelByte.Sdk.Core.Repository;

namespace AccelByte.Sdk.Tests.Services
{
    public abstract class BaseServiceTests : BaseIntegrationTest
    {
        private HttpClientPolicy _RetryPolicy;

        private bool _UseUserLogin;

        private int _WaitTimeValue = 500; //in milisecs

        private IConfigRepository _ConfigRepository;

        protected virtual void OnStartup(AccelByteSDK sdk) { }

        protected virtual void OnBeforeEnd() { }

        protected void Wait()
        {
            Thread.Sleep(_WaitTimeValue);
        }

        public BaseServiceTests(bool useUserLogin)
        {
            _ConfigRepository = IntegrationTestConfigRepository.Admin;
            _UseUserLogin = useUserLogin;

            _RetryPolicy = HttpClientPolicy.Default;
            _RetryPolicy.MaxRetryCount = 3;
            _RetryPolicy.RetryInterval = 500;
            _RetryPolicy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("425");
        }

        public BaseServiceTests(bool useUserLogin, IConfigRepository sharedCloudConfig)
        {
            if (IsUsingAGSStarter(sharedCloudConfig))
                _ConfigRepository = sharedCloudConfig;
            else
                _ConfigRepository = IntegrationTestConfigRepository.Admin;

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
                .SetConfigRepository(_ConfigRepository)
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