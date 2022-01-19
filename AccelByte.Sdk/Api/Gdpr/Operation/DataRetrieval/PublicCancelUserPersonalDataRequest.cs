using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Gdpr.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Gdpr.Operation
{
    public class PublicCancelUserPersonalDataRequest : AccelByte.Sdk.Core.Operation
    {
        public PublicCancelUserPersonalDataRequest(
            string namespace_,            
            string requestDate,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["requestDate"] = requestDate;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListPersonalDataResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPersonalDataResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}