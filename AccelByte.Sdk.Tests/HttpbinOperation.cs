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
        private readonly string _consumes;

        public HttpbinOperation(HttpMethod method, 
                string path = "/anything",
                Dictionary<string, string> pathParams = null!,
                Dictionary<string, string> queryParams = null!,
                object? bodyParams = null!,
                string consumes = "application/json")
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

            BodyParams = bodyParams;

            _consumes = consumes;
        }

        public override string Path { get; }

        public override HttpMethod Method { get; }

        public override string[] Consumes =>  new[] { _consumes };

        public override string[] Produces => new[] { "application/json" };

        public override string? Security {get; set;}

        public HttpbinAnythingResponse? ParseResponse(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var jsonString = Helper.ConvertInputStreamToString(payload);

                throw new HttpResponseException(code, jsonString);
            }

            return JsonSerializer.Deserialize<HttpbinAnythingResponse>(payload);
        }
    }
}