using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class RetrieveEligibilitiesPublicIndirect : AccelByte.Sdk.Core.Operation
    {
        public RetrieveEligibilitiesPublicIndirect(
            string clientId,            
            string countryCode,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/agreement/public/eligibilities/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}";

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