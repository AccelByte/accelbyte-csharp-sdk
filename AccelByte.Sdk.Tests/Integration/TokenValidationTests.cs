// Copyright (c) 2023-2025 AccelByte Inc. All Rights Reserved.
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

using AccelByte.Sdk.Feature.LocalTokenValidation;
using System.Threading;

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

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 15;

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
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
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

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 15;

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
    }
}
