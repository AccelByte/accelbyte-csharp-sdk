using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    public class PublicGetUserAccountDeletionStatus : AccelByte.Sdk.Core.Operation
    {
        public PublicGetUserAccountDeletionStatus(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/deletions/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsDeletionStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeletionStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}