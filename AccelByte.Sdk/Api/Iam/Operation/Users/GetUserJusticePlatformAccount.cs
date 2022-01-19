using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class GetUserJusticePlatformAccount : AccelByte.Sdk.Core.Operation
    {
        public GetUserJusticePlatformAccount(
            string namespace_,            
            string targetNamespace,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUserJusticePlatformAccountResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserJusticePlatformAccountResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}