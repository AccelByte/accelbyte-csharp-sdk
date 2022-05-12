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

namespace AccelByte.Sdk.Tests.MockServer
{
    public class MockServerConfigRepository : IConfigRepository
    {
        public MockServerConfigRepository()
        {
            BaseUrl = "http://127.0.0.1:8080";
            ClientId = "admin";
            ClientSecret = "admin";
            AppName = "CSharpSDKMockTests";
            Namespace = "test";
            TraceIdVersion = "1";
        }

        public string BaseUrl { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string AppName { get; init; }

        public string Namespace { get; init; }

        public string TraceIdVersion { get; init; }

        public bool EnableTraceId { get; } = true;

        public bool EnableUserAgentInfo { get; } = true;

        public IHttpLogger? Logger { get; set; } = null;
    }
}