using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class PublicWebLinkPlatform : AccelByte.Sdk.Core.Operation
    {
        public PublicWebLinkPlatform(
            string namespace_,            
            string platformId,            
            string? clientId,            
            string? redirectUri            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            
            if (clientId != null) QueryParams["clientId"] = clientId;
            if (redirectUri != null) QueryParams["redirectUri"] = redirectUri;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelWebLinkingResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelWebLinkingResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}