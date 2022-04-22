// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinCookieOperation : Operation
    {
        public HttpbinCookieOperation()
        {
            
        }

        public override string Path => "/cookies";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new[] { "application/json" };

        public override string[] Produces => new[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; }

        public HttpbinCookieResponse? ParseResponse(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var jsonString = Helper.ConvertInputStreamToString(payload);
                throw new HttpResponseException(code, jsonString);
            }

            return JsonSerializer.Deserialize<HttpbinCookieResponse>(payload);
        }
    }
}