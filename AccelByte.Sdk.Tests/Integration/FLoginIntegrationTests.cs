// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
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

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FLoginIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseDefaultTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        protected string GetPhantauthToken(string username, string tokenType)
        {
            string url = String.Format(@"https://phantauth.net/user/{0}/token/{1}", username.Trim(), tokenType.Trim().ToLower());

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Get, url);
            if (DefaultHttpClient.Http == null)
                return String.Empty;

            HttpResponseMessage response = DefaultHttpClient.Http.Send(req);
            return Helper.ConvertInputStreamToString(response.Content.ReadAsStream());
        }

        protected PhantauthTokens GetPhantauthAuthorizedToken(string clientId, string clientSecret, string authorizationToken)
        {
            string url = "https://phantauth.net/auth/token";

            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);
            req.Content = new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"grant_type", "authorization_code" },
                {"client_id", clientId },
                {"client_secret", clientSecret },
                {"redirect_uri", "http://localhost" },
                {"code", authorizationToken }
            });

            HttpResponseMessage response = DefaultHttpClient.Http.Send(req);
            string jsonString = Helper.ConvertInputStreamToString(response.Content.ReadAsStream());

            return JsonSerializer.Deserialize<PhantauthTokens>(jsonString)!;
        }

        [Test]
        public void PhantauthOIDCPlatformLoginTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string platformId = "phantauth";
            string clientId = "test.client";
            string clientSecret = "UTBcWwt5";

            string authzToken = GetPhantauthToken("test.serversdk1", "authorization");
            PhantauthTokens pTokens = GetPhantauthAuthorizedToken(clientId, clientSecret, authzToken);

            bool isSuccess = _Sdk.LoginPlatform(platformId, pTokens.ID);
            Assert.IsTrue(isSuccess);
        }
    }
}