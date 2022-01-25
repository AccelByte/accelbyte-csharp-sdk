using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class PartialUpdatePolicy : AccelByte.Sdk.Core.Operation
    {
        public PartialUpdatePolicy(
            string basePolicyId,            
            Model.UpdateBasePolicyRequest body            
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UpdateBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UpdateBasePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}