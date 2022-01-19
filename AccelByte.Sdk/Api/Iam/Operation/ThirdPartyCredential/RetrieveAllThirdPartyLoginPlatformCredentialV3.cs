using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class RetrieveAllThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        public RetrieveAllThirdPartyLoginPlatformCredentialV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/all/clients";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}