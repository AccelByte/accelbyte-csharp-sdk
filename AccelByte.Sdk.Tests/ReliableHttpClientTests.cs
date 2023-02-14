// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text.Json;

using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Tests.MockServer;

namespace AccelByte.Sdk.Tests
{
    [TestFixture(Category = "ReliableHttpClient")]
    [Explicit]
    public class ReliableHttpClientTests : HttpBinRequestTests
    {
        private MockServerConfigRepository _MSConfigRepo = new MockServerConfigRepository();

        protected override IHttpClient GetHttpClientObject()
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.RetryOnException = false;

            return ReliableHttpClient.Builder
                .SetDefaultPolicy(policy)
                .Build();
        }

        protected void ConfigureMockServer(OverwritingConfiguration oConfig)
        {
            string url = _MSConfigRepo.BaseUrl + "/configure-overwrite-response";
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);

            var jsonString = JsonSerializer.Serialize(oConfig);
            req.Content = new StringContent(jsonString, Encoding.UTF8, "application/json");

            if (ReliableHttpClient.Http != null)
                ReliableHttpClient.Http.Send(req);
        }

        protected void ResetMockServer()
        {
            string url = _MSConfigRepo.BaseUrl + "/reset-overwrite-response";
            HttpRequestMessage req = new HttpRequestMessage(HttpMethod.Post, url);

            if (ReliableHttpClient.Http != null)
                ReliableHttpClient.Http.Send(req);
        }

        [Test]
        [TestCase(new int[] { 401, 401, 200 }, TestName = "Retry - MockServer - Twice Unauthorized")]
        public void ResponseScenarioTests(params int[] scenarioCodes)
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.AddRetryCountToHeaders = true;
            policy.RetryLogicHandler = new ResponseCodeCheckLogicHandler("401");

            MockTestLogger logger = new MockTestLogger();

            using AccelByteSDK sdk = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(policy)
                    .SetBeforeSendAction((reqm, retryNo) =>
                    {
                        int scenarioCode = scenarioCodes[retryNo];
                        ConfigureMockServer(new OverwritingConfiguration()
                        {
                            IsEnabled = true,
                            IsOverwrite = true,
                            StatusCode = scenarioCode
                        });
                    })
                    .Build())
                .SetConfigRepository(new MockServerConfigRepository())
                .SetTokenRepository(new MockServerTokenRepository())
                .SetLogger(logger)
                .EnableLog()
                .Build();

            sdk.Lobby.Friends.GetUserFriendsUpdatedOp.Execute(_MSConfigRepo.Namespace);

            //The number of requests sent was twice the number of the actual operation request
            //due to configuring mock server use one request per actual operation request.
            //So the number of requests that we want to check is actually only half of the overall request count.
            int actualCount = (logger.ResponseCodes.Count / 2);
            Assert.AreEqual(scenarioCodes.Count(), actualCount);
            ResetMockServer();
        }

        [Test]
        [TestCase(new int[] { 11, 11, 2 }, TestName = "Retry - MockServer - Twice TimeOut")]
        public void TimoutScenarioTests(params int[] scenarioSleeps)
        {
            HttpClientPolicy policy = HttpClientPolicy.Default;
            policy.AddRetryCountToHeaders = true;
            policy.RequestTimeOut = 10; //Makes each request to timed out after 10 seconds.

            MockTestLogger logger = new MockTestLogger();
            int latestRetryNo = 0;

            using AccelByteSDK sdk = AccelByteSDK.Builder
                .SetHttpClient(ReliableHttpClient.Builder
                    .SetDefaultPolicy(policy)
                    .SetBeforeSendAction((reqm, retryNo) =>
                    {
                        latestRetryNo = retryNo;
                        ConfigureMockServer(new OverwritingConfiguration()
                        {
                            IsEnabled = true,
                            Delay = scenarioSleeps[retryNo]
                        });
                    })
                    .Build())
                .SetConfigRepository(new MockServerConfigRepository())
                .SetTokenRepository(new MockServerTokenRepository())
                .SetLogger(logger)
                .EnableLog()
                .Build();

            sdk.Lobby.Friends.GetUserFriendsUpdatedOp.Execute(_MSConfigRepo.Namespace);
            Assert.AreEqual(scenarioSleeps.Count(), latestRetryNo + 1);
            ResetMockServer();
        }
    }
}