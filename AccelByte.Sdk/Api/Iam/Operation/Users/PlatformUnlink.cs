using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PlatformUnlink : AccelByte.Sdk.Core.Operation
    {
        public PlatformUnlink(
            string namespace_,            
            string platformId,            
            string userId,            
            string? platformNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            if (platformNamespace != null) FormParams["platform_namespace"] = platformNamespace;
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms/{platformId}/unlink";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded","text/plain" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}