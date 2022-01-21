using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class ListCrossNamespaceAccountLink : AccelByte.Sdk.Core.Operation
    {
        public ListCrossNamespaceAccountLink(
            string namespace_,            
            string userId,            
            string? platformId,            
            string linkingToken            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            if (platformId != null) FormParams["platformId"] = platformId;
            if (linkingToken != null) FormParams["linkingToken"] = linkingToken;
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/crosslink";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}