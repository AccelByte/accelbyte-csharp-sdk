using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AdminRetrieveUserThirdPartyPlatformTokenV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminRetrieveUserThirdPartyPlatformTokenV3(
            string namespace_,            
            string platformId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelTokenThirdPartyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}