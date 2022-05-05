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
    public class HttpbinCodeOperation : Operation
    {
        private int _StatusCode = 200;

        public HttpbinCodeOperation(int statusCode)
        {
            _StatusCode = statusCode;
        }

        public override string Path => ("/status/" + _StatusCode.ToString());

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new[] { "application/json" };

        public override string[] Produces => new[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; }

        public int ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == HttpStatusCode.OK)
            {
                return 200;
            }
            else if (code == HttpStatusCode.Created)
            {
                return 201;
            }
            else if (code == HttpStatusCode.NoContent)
            {
                return 204;
            }
            else if (code == HttpStatusCode.Forbidden)
            {
                return 403;
            }
            else if (code == HttpStatusCode.NotFound)
            {
                return 404;
            }
            else if (code == HttpStatusCode.ServiceUnavailable)
            {
                return 503;
            }
            else
            {
                var jsonString = Helper.ConvertInputStreamToString(payload);
                throw new HttpResponseException(code, jsonString);
            }
        }
    }
}