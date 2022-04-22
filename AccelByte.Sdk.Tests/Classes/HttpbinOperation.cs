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
    public class HttpbinOperation : Operation
    {
        private string[] _Consumes;

        public HttpbinOperation(HttpMethod method, 
                string path = "/anything",
                Dictionary<string, string> pathParams = null!,
                Dictionary<string, dynamic> queryParams = null!,
                object? bodyParams = null!,
                string consumes = "application/json",
                Dictionary<string, string> collectionFormatMap = null!)
        {
            Method = method;

            Path = path;

            if (pathParams != null)
            {
                foreach (var p in pathParams)
                {
                    PathParams.Add(p.Key, p.Value);
                }
            }

            if (queryParams != null)
            {
                foreach (var p in queryParams)
                {
                    QueryParams.Add(p.Key, p.Value);
                }
            }

            if (collectionFormatMap != null)
            {
                foreach (var p in collectionFormatMap)
                {
                    CollectionFormatMap.Add(p.Key, p.Value);
                }
            }
            

            BodyParams = bodyParams;

            if (consumes.Trim() != string.Empty)
                _Consumes = new string[] { consumes };
            else
                _Consumes = new string[] { };
        }

        public override string Path { get; }

        public override HttpMethod Method { get; }

        public override string[] Consumes => _Consumes;

        public override string[] Produces => new[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; }

        public HttpbinAnythingResponse<TArgs>? ParseResponse<TArgs>(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var jsonString = Helper.ConvertInputStreamToString(payload);

                throw new HttpResponseException(code, jsonString);
            }

            return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(payload);
        }
    }
}