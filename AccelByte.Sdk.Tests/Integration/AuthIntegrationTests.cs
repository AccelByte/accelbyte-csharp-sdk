// Copyright (c) 2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Client;

using AccelByte.Sdk.Tests.Model;
using AccelByte.Sdk.Api.Legal.Model;
using System.Threading;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class AuthIntegrationTests
    {
        [Test]
        public void OnDemandRefreshTokenTestForUser()
        {
            int loginCounter = 0;
            int refreshCounter = 0;

            DefaultTokenRepository tokenRepo = new DefaultTokenRepository();
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .SetTokenRepository(tokenRepo)
                .UseDefaultCredentialRepository()
                .UseRefreshIfPossible()
                .SetOnAfterLoginAction((loginType, authAction, token, sdk) =>
                {
                    tokenRepo.SetTokenExpiry(1); //set to 1s expiry for fast test execution
                    if (authAction == AuthActionType.Login)
                        loginCounter++;
                    else if (authAction == AuthActionType.TokenRefresh)
                        refreshCounter++;
                })
                .Build();

            int loopCounter = 0;
            int maxLoop = 10;
            while (loopCounter < maxLoop)
            {
                if (!sdk.LoginUser())
                    throw new Exception("Login failed");

                List<RetrieveAcceptedAgreementResponse>? response = sdk.Legal.Agreement.RetrieveAgreementsPublicOp.Execute();
                Assert.IsNotNull(response);

                loopCounter++;

                //sleep for 200ms to make sure the token is expired
                Thread.Sleep(200);
            }

            sdk.Logout();

            //Make sure that actual login executed only once.
            Assert.AreEqual(loginCounter, 1);

            //Make sure at least one refresh token is executed. More is not an issue.
            Assert.GreaterOrEqual(refreshCounter, 1);
        }

        [Test]
        public void OnDemandLoginClientTest()
        {
            int loginCounter = 0;

            DefaultTokenRepository tokenRepo = new DefaultTokenRepository();
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .SetTokenRepository(tokenRepo)
                .UseDefaultCredentialRepository()
                .UseRefreshIfPossible()
                .SetOnAfterLoginAction((loginType, authAction, token, sdk) =>
                {
                    tokenRepo.SetTokenExpiry(2); //set to 1s expiry for fast test execution
                    loginCounter++;
                })
                .Build();

            int loopCounter = 0;
            int maxLoop = 10;
            while (loopCounter < maxLoop)
            {
                if (!sdk.LoginClient())
                    throw new Exception("Login failed");

                var response = sdk.Achievement.GlobalAchievements.PublicListGlobalAchievementsOp.Execute(sdk.Namespace);
                Assert.IsNotNull(response);

                loopCounter++;

                //sleep for 200ms to make sure the token is expired
                Thread.Sleep(200);
            }

            sdk.Logout();

            //Make sure that number of login execution is less than login method call.
            Assert.Less(loginCounter, maxLoop);
        }
    }
}
