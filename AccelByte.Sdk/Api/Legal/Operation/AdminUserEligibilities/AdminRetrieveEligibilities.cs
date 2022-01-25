using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class AdminRetrieveEligibilities : AccelByte.Sdk.Core.Operation
    {
        public AdminRetrieveEligibilities(
            string namespace_,            
            string userId,            
            string? publisherUserId,            
            string clientId,            
            string countryCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (publisherUserId != null) QueryParams["publisherUserId"] = publisherUserId;
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (countryCode != null) QueryParams["countryCode"] = countryCode;
            
            
            
            
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/users/{userId}/eligibilities";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RetrieveUserEligibilitiesIndirectResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveUserEligibilitiesIndirectResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}