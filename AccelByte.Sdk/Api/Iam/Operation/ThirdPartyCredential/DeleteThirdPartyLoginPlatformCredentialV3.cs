using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class DeleteThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        public DeleteThirdPartyLoginPlatformCredentialV3(
            string namespace_,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}