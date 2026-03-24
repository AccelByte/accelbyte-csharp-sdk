// Copyright (c) 2023-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Feature.LocalTokenValidation;
using System.Web;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class TokenValidationTests
    {
        [Test]
        public void TokenValidationTestUsingDefaultValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            bool b = sdk.ValidateToken(accessToken);
            Assert.IsTrue(b);

            sdk.Iam.OAuth20.TokenRevocationV3Op.Execute(accessToken);
            Thread.Sleep(3000);

            b = sdk.ValidateToken(accessToken);
            Assert.IsFalse(b);
        }

        [Test]
        public void PermissionValidationTestUsingDefaultValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Basic)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }


        [Test]
        public void TokenValidationTestUsingLocalValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList(2000) //refresh revocation every 2s
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            bool b = sdk.ValidateToken(accessToken);
            Assert.IsTrue(b);

            sdk.Iam.OAuth20.TokenRevocationV3Op.Execute(accessToken);
            Thread.Sleep(3000);

            b = sdk.ValidateToken(accessToken);
            Assert.IsFalse(b);
        }

        [Test]
        public void PermissionValidationTestUsingLocalValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Basic)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserPermissionValidationTestUsingDefaultValidator()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();
            sdk.LoginClient();

            //we will access user using different sdk object wrapped inside `ExistingTestPlayer` object.
            var user = new ExistingTestPlayer("AB", true);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void UserPermissionValidationTestUsingLocalValidator()
        {
            //line's comment follows `UserPermissionValidationTestUsingDefaultValidator` test.

            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .UseLocalTokenValidator()
                .UseAutoRefreshForTokenRevocationList(2000) //refresh revocation every 2s
                .EnableLog()
                .Build();
            sdk.LoginClient();

            var user = new ExistingTestPlayer("AB", true);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void ParseAccessTokenNoValidationTest()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            AccessTokenPayload? payload = sdk.ParseAccessToken(accessToken, false);
            Assert.IsNotNull(payload);
            if (payload != null)
            {
                Assert.AreEqual(sdk.Namespace, payload.Namespace);
                Assert.AreEqual(sdk.Configuration.ConfigRepository.ClientId, payload.ClientId);
            }
        }

        /// <summary>
        /// WARNING: Please use LoginClient() function with confidential OAuth client.
        /// Using LoginClient() function with public OAuth client is not supported.
        /// This test is kept here for historical reason only.
        /// </summary>
        [Test]
        public void PublicClientTokenValidationTestUsingDefaultValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.PublicClient)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            bool b = sdk.ValidateToken(accessToken);
            Assert.IsTrue(b);

            sdk.Iam.OAuth20.TokenRevocationV3Op.Execute(accessToken);
            Thread.Sleep(3000);

            b = sdk.ValidateToken(accessToken);
            Assert.IsFalse(b);
        }

        [Test]
        public void CustomPermissionValidationTestUsingDefaultValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.CustomPermission)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            string accessToken = "";
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            string tPermission = $"CUSTOM:ADMIN:NAMESPACE:{sdk.Namespace}:GUILD";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserCustomPermissionValidationTestUsingDefaultValidator()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();
            sdk.LoginClient();

            //we will access user using different sdk object wrapped inside `ExistingTestPlayer` object.
            var user = new ExistingTestPlayer("AB_PLAYER1", true);

            string tPermission = $"CUSTOM:NAMESPACE:{sdk.Namespace}:GUILD";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        [Test]
        public void UserTokenValidationFromParentNamespaceUsingDefaultValidator()
        {
            //first sdk object is for oauth client which has ADMIN:ROLE [READ] permission, since we will assume that default user doesn't have this permission.
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();
            sdk.LoginClient();

            var user = _SimulateAdminPortalLogin(IntegrationTestCredentialRepository.StudioAdmin);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 2;

            //validate user's token against expected permission.
            bool b = sdk.ValidateToken(user.AccessToken, tPermission, tAction);
            Assert.IsTrue(b);

            user.Logout();
        }

        private ITestPlayer _SimulateAdminPortalLogin(ICredentialRepository credRepo)
        {
            var user = new RepoTestPlayer(IntegrationTestConfigRepository.AdminPortalLogin, credRepo, false);
            user.Run((sdk,player) =>
            {
                string codeVerifier = Helper.GenerateCodeVerifier();
                string codeChallenge = Helper.GenerateCodeChallenge(codeVerifier);
                string clientId = sdk.Configuration.ConfigRepository.ClientId;
                string csrf = Guid.NewGuid().ToString().Replace("-", "");
                string redirectUri = $"{sdk.Configuration.ConfigRepository.BaseUrl}/admin";

                var authorizeResponse = sdk.Iam.OAuth20.AuthorizeV3Op
                    .SetRedirectUri(redirectUri)
                    .SetState(csrf)
                    .SetCodeChallenge(codeChallenge)
                    .SetCodeChallengeMethod("S256")
                    .Execute(clientId, "code");

                var authorizeV3Query = HttpUtility.ParseQueryString(new Uri(authorizeResponse).Query);
                var requestId = authorizeV3Query["request_id"] ??
                    throw new Exception("AuthorizeV3: Not getting the expected value from backend (key: request_id)");

                var loginResponse = sdk.Iam.OAuth20Extension.UserAuthenticationV3Op
                    .SetRedirectUri(redirectUri)
                    .SetClientId(clientId)
                    .Execute(credRepo.Password, requestId, credRepo.Username);

                var loginV3Query = HttpUtility.ParseQueryString(new Uri(loginResponse).Query);
                var code = loginV3Query["code"] ??
                    throw new Exception("UserAuthenticationV3: Not getting the expected value from backend (key: code)");
                var state = loginV3Query["state"] ??
                    throw new Exception("UserAuthenticationV3: Not getting the expected value from backend (key: state)");
                if (state != csrf)
                    throw new Exception("State is different from initial CSRF value.");

                var tokenResponse = sdk.Iam.OAuth20.TokenGrantV3Op
                    .SetRedirectUri(redirectUri)
                    .SetClientId(clientId)
                    .SetCode(code)
                    .SetCodeVerifier(codeVerifier)
                    .Execute("authorization_code");
                if (tokenResponse == null)
                    throw new Exception($"TokenGrantV3 returned null");

                //login succeed
                sdk.Configuration.TokenRepository.StoreToken(LoginType.User, tokenResponse);
            });
            return user;
        }
    }
}
