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
    public class HttpbinHtmlOperation: Operation
    {
        public HttpbinHtmlOperation()
        {

        }

        public override string Path => "/html";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new[] { "application/json" };

        public override string[] Produces => new[] { "text/html" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; }

        public string? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var sPayload = Helper.ConvertInputStreamToString(payload);
                throw new HttpResponseException(code, sPayload);
            }

            return Helper.ConvertInputStreamToString(payload);
        }
    }
}