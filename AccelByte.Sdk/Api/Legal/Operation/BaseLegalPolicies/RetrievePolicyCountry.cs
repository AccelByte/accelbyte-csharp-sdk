using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class RetrievePolicyCountry : AccelByte.Sdk.Core.Operation
    {
        public RetrievePolicyCountry(
            string basePolicyId,            
            string countryCode            
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["countryCode"] = countryCode;
            
            
            
            
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RetrievePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrievePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}