// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Tests
{
    public class HttpbinAnythingOperation : Operation
    {
        public static readonly HttpbinAnythingOperationBuilder Builder = new HttpbinAnythingOperationBuilder();

        public class HttpbinAnythingOperationBuilder
            : OperationBuilder<HttpbinAnythingOperationBuilder>
        {
            public object? BodyParam { get; private set; } = null;

            public string? LocationQuery { get; private set; } = null;

            public HttpbinAnythingOperationBuilder SetBodyParam(object bodyParam)
            {
                BodyParam = bodyParam;
                return this;
            }

            public HttpbinAnythingOperationBuilder SetLocationQuery(string locationQuery)
            {
                LocationQuery = locationQuery;
                return this;
            }

            public HttpbinAnythingOperation Create(HttpMethod method)
            {
                return new HttpbinAnythingOperation(this, method);
            }

            public HttpbinAnythingOperation Create(string method)
            {
                return new HttpbinAnythingOperation(this, new HttpMethod(method));
            }
        }

        private HttpMethod _Method;

        private HttpbinAnythingOperation(HttpbinAnythingOperationBuilder builder, HttpMethod method)
        {
            _Method = method;
            BodyParams = builder.BodyParam;
            LocationQuery = builder.LocationQuery;
        }

        public override string Path => "/anything/{test_path}";

        public override HttpMethod Method => _Method;

        private string[] _Consumes = new string[] { "application/json" };
        public override string[] Consumes => _Consumes;

        private string[] _Produces = new string[] { "application/json" };
        public override string[] Produces => _Produces;

        [Obsolete]
        public override string? Security { get; set; } = Operation.SECURITY_BASIC;

        public HttpbinAnythingOperation AddPathParam(string key, string value)
        {
            PathParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddQueryParam(string key, string value)
        {
            QueryParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddHeaderParam(string key, string value)
        {
            HeaderParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddFormParam(string key, dynamic value)
        {
            FormParams.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddCookie(string key, string value)
        {
            Cookies.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddCollectionFormat(string key, string value)
        {
            CollectionFormatMap.Add(key, value);
            return this;
        }

        public HttpbinAnythingOperation AddSecurity(string value)
        {
            Securities.Add(value);
            return this;
        }

        public HttpbinAnythingOperation SetConsume(string contentType)
        {
            _Consumes = new string[] { contentType };
            return this;
        }

        public HttpbinAnythingOperation SetProduce(string contentType)
        {
            _Produces = new string[] { contentType };
            return this;
        }

        public HttpbinAnythingResponse<TArgs>? ParseResponse<TArgs>(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code == HttpStatusCode.OK)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else if (code == HttpStatusCode.Created)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else if (code == HttpStatusCode.NoContent)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs>>(sPayload);
            }
            else
            {
                string jsonString = Helper.ConvertInputStreamToString(payload);
                throw new HttpResponseException(code, jsonString);
            }
        }

        public HttpbinAnythingResponse<TArgs, TData>? ParseResponse<TArgs, TData>(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code == HttpStatusCode.OK)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else if (code == HttpStatusCode.Created)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else if (code == HttpStatusCode.NoContent)
            {
                string sPayload = Helper.ConvertInputStreamToString(payload);
                return JsonSerializer.Deserialize<HttpbinAnythingResponse<TArgs, TData>>(sPayload);
            }
            else
            {
                string jsonString = Helper.ConvertInputStreamToString(payload);
                throw new HttpResponseException(code, jsonString);
            }
        }

        public HttpbinAnythingResponse<TArgs>? Execute<TArgs>(AccelByteSDK sdk)
        {
            HttpResponse response = sdk.RunRequest(this);
            return ParseResponse<TArgs>(response.Code, response.ContentType, response.Payload);
        }

        public HttpbinAnythingResponse<TArgs, TData>? Execute<TArgs, TData>(AccelByteSDK sdk)
        {
            HttpResponse response = sdk.RunRequest(this);
            return ParseResponse<TArgs, TData>(response.Code, response.ContentType, response.Payload);
        }

        public HttpbinAnythingResponse<Dictionary<string, string>>? Execute(AccelByteSDK sdk)
        {
            HttpResponse response = sdk.RunRequest(this);
            return ParseResponse<Dictionary<string, string>>(response.Code, response.ContentType, response.Payload);
        }
    }
}