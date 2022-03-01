// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Tests
{
    public class TestConfigRepository : IConfigRepository
    {
        public TestConfigRepository(string baseUrl, string clientId, string clientSecret, string appName)
        {
            BaseUrl = baseUrl;
            ClientId = clientId;
            ClientSecret = clientSecret;
            AppName = appName;
        }

        public string BaseUrl { get; init; }
        
        public string ClientId { get; init; }

        public string ClientSecret { get; init; }

        public string AppName { get; init; }

        public string TraceIdVersion{ get; } = "1";

        public bool EnableTraceId { get; } = true;

        public bool EnableUserAgentInfo { get; } = true;

        public IHttpLogger? Logger { get; set; } = null;
    }
}