using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
    ///
    /// This is the API to Get All Active 3rd Platform Credential. It needs
    /// ADMIN:NAMESPACE:{namespace}:PLATFORM:*:CLIENT [READ] resource
    /// </summary>
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 : AccelByte.Sdk.Core.Operation
    {
        public RetrieveAllActiveThirdPartyLoginPlatformCredentialV3(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/platforms/all/clients/active";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelThirdPartyLoginPlatformCredentialResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelThirdPartyLoginPlatformCredentialResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}