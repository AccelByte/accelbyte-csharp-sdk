using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class RetrieveLatestPoliciesPublic : AccelByte.Sdk.Core.Operation
    {
        public RetrieveLatestPoliciesPublic(
            string namespace_,            
            bool? alwaysIncludeDefault,            
            bool? defaultOnEmpty,            
            string? policyType,            
            string? tags            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (alwaysIncludeDefault != null) QueryParams["alwaysIncludeDefault"] = Convert.ToString(alwaysIncludeDefault)!;
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType != null) QueryParams["policyType"] = policyType;
            if (tags != null) QueryParams["tags"] = tags;
            
            
            
            
        }

        public override string Path => "/agreement/public/policies/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrievePolicyPublicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}