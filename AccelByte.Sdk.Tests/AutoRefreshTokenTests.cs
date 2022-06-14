// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Threading;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Tests.MockServer;

using AccelByte.Sdk.Feature.AutoTokenRefresh;

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;

namespace AccelByte.Sdk.Tests
{
    [TestFixture(Category = "AutoRefreshToken")]
    [Explicit]
    public class AutoRefreshTokenTests
    {
        [Test]
        public void SendToMockServerWithRefreshToken()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(new MockServerConfigRepository())
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
    }
}