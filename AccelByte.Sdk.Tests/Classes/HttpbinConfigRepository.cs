// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinConfigRepository : IConfigRepository
    {
        public HttpbinConfigRepository(string type)
        {
            string? temp = Environment.GetEnvironmentVariable("AB_HTTPBIN_URL");
            if (temp != null)
                BaseUrl = temp;
            else
                throw new Exception($"Environment variable not found (variable: AB_HTTPBIN_URL)");

            ClientId = type;
            ClientSecret = type;
            AppName = "CSharpSDKUnitTests";
            Namespace = "demo";
            TraceIdVersion = "1";
        }

        public string BaseUrl { get; init; }

        public string ClientId { get; init; }

        public string ClientSecret { get; init; }

        public string AppName { get; init; }

        public string Namespace { get; init; }

        public string TraceIdVersion { get; init; }

        public bool EnableTraceId { get; } = true;

        public bool EnableUserAgentInfo { get; } = true;

        public IHttpLogger? Logger { get; set; } = null;
    }
}