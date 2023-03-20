// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Feature.AutoTokenRefresh;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "RefreshTokenIntegration")]
    [Explicit]
    public class RefreshTokenIntegrationTests : BaseIntegrationTest
    {
        [Test]
        public void UserLoginWithAutoRefreshToken()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginUser(true);

            Agreement wLegalAgreement = new Agreement(sdk);

            //First request, valid token
            List<RetrieveAcceptedAgreementResponse>? aggrs1 = wLegalAgreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs1);

            //Force token expire
            if (sdk.Configuration.TokenRepository is RefreshableTokenRepository)
            {
                RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)sdk.Configuration.TokenRepository;
                tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds

                //wait for 5 seconds
                Thread.Sleep(5000);
            }

            //Second request, expired token, try to do refresh
            List<RetrieveAcceptedAgreementResponse>? aggrs2 = wLegalAgreement.RetrieveAgreementsPublic(
                RetrieveAgreementsPublic
                .Builder.Build());
            Assert.IsNotNull(aggrs2);

            sdk.Logout();
        }

        [Test]
        public void ClientLoginWithAutoRefreshToken()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseAutoTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginClient(true);

            //First request, valid token
            ModelsPublicAchievementsResponse? achResp1 = sdk.Achievement.Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp1);

            //Force token expire
            if (sdk.Configuration.TokenRepository is RefreshableTokenRepository)
            {
                RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)sdk.Configuration.TokenRepository;
                tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds

                //wait for 5 seconds
                Thread.Sleep(5000);
            }

            //Second request, expired token, try to do refresh
            ModelsPublicAchievementsResponse? achResp2 = sdk.Achievement.Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp2);

            sdk.Logout();
        }
    }
}