// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
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
using AccelByte.Sdk.Api.Lobby;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "RefreshTokenIntegration")]
    [Explicit]
    public class RefreshTokenIntegrationTests : BaseIntegrationTest
    {
        [Test]
        public void UserLoginWithOnDemandTokenRefresh()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginUser();

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
        public void ClientLoginWithOnDemandTokenRefresh()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .Build();

            sdk.LoginClient();

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

        [Test]
        public void AutoRefreshTokenForWebSocket()
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultCredentialRepository()
                .UseOnDemandTokenRefresh()
                .EnableLog()
                .SetOnAfterLoginAction((loginType, authType, tokenData, fSdk) =>
                {
                    if (fSdk.Configuration.TokenRepository is RefreshableTokenRepository)
                    {
                        RefreshableTokenRepository tokenRepo = (RefreshableTokenRepository)fSdk.Configuration.TokenRepository;
                        tokenRepo.SetTokenExpiry(5); // expiry in 5 seconds
                    }
                })
                .Build();

            sdk.LoginUser();

            bool isRefreshTokenResponseReceived = false;

            CancellationTokenSource lobbyListenCt = new CancellationTokenSource();
            Thread wsThread = new Thread(new ThreadStart(() =>
            {
                LobbyService lobby = new LobbyService(sdk.Configuration);
                lobby.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
                lobby.OnMessageReceived = (aMsg) =>
                {
                    if (aMsg.MessageType == "refreshTokenResponse")
                        isRefreshTokenResponseReceived = true;
                };

                Task connectTask = lobby.Connect(false);
                connectTask.Wait();

                Task listenTask = lobby.Listen(lobbyListenCt.Token);
                listenTask.Wait();

                Task disconnectTask = lobby.Disconnect();
                disconnectTask.Wait();
            }));

            //start lobby ws thread
            wsThread.Start();

            //sleep for 5s to make sure the token is expired
            Thread.Sleep(5000);

            //force token to be refreshed by calling any op
            ModelsPublicAchievementsResponse? achResp = sdk.Achievement.Achievements.PublicListAchievementsOp
                .Execute(sdk.Namespace, "en");
            Assert.IsNotNull(achResp);

            //wait for any ws response
            Thread.Sleep(2000);

            Assert.IsTrue(isRefreshTokenResponseReceived);

            //cancel ws listen
            lobbyListenCt.Cancel();

            //wait until lobby ws thread is stopped
            while (wsThread.IsAlive)
                Thread.Sleep(100);

            sdk.Logout();
        }
    }
}