// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;

using AccelByte.Sdk.Feature.AutoTokenRefresh;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "RefreshTokenIntegration")]
    [Explicit]
    public class RefreshTokenIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)                
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .Build();

            _Sdk.LoginUser(true);
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }
        
        [Test]
        public void GetLegalAgreementTestWithAutoRefreshToken()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Agreement wLegalAgreement = new Agreement(_Sdk);

            //First request, valid token
            List<RetrieveAcceptedAgreementResponse>? aggrs1 = wLegalAgreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs1);

            //Force token expire
            if (_Sdk.Configuration.TokenRepository is RefreshableTokenRepository)
            {
                RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)_Sdk.Configuration.TokenRepository;
                tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds

                //wait for 5 seconds
                Thread.Sleep(5000);
            }

            //Second request, expired token, try to do refresh
            List<RetrieveAcceptedAgreementResponse>? aggrs2 = wLegalAgreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs2);
        }
    }
}