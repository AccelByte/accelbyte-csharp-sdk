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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
            sdk.LoginClient((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            string tPermission = $"NAMESPACE:{sdk.Namespace}:PROFILE";
            int tAction = 15;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserPermissionValidationTestUsingDefaultValidator()
        {
            using AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
            sdk.LoginUser((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:USER";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
        }

        [Test]
        public void UserPermissionValidationTestUsingLocalValidator()
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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
            sdk.LoginUser((tokenResp) =>
            {
                accessToken = tokenResp.AccessToken!;
            });

            Thread.Sleep(2000);

            string tPermission = $"ADMIN:NAMESPACE:{sdk.Namespace}:USER";
            int tAction = 2;

            bool b = sdk.ValidateToken(accessToken, tPermission, tAction);
            Assert.IsTrue(b);
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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
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

            if (sdk.Configuration.ConfigRepository.BaseUrl.Contains("gamingservices.accelbyte.io"))
            {
                Assert.Inconclusive("Test does not apply to AGS Starter environment.");
                return;
            }

            string accessToken = String.Empty;
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
