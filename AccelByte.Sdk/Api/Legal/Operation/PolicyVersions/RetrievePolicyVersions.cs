using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    public class RetrievePolicyVersions : AccelByte.Sdk.Core.Operation
    {
        public RetrievePolicyVersions(
            string? basePolicyId,            
            string? localeId,            
            string? namespace_            
        )
        {
            
            if (basePolicyId != null) QueryParams["basePolicyId"] = basePolicyId;
            if (localeId != null) QueryParams["localeId"] = localeId;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/agreement/public/policies";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrievePolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}