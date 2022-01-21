using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PlatformTokenGrantV3 : AccelByte.Sdk.Core.Operation
    {
        public PlatformTokenGrantV3(
            string platformId,            
            string? clientId,            
            string? deviceId,            
            string? platformToken            
        )
        {
            PathParams["platformId"] = platformId;
            
            
            if (clientId != null) FormParams["client_id"] = clientId;
            if (deviceId != null) FormParams["device_id"] = deviceId;
            if (platformToken != null) FormParams["platform_token"] = platformToken;
            
            
            
        }

        public override string Path => "/iam/v3/oauth/platforms/{platformId}/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}