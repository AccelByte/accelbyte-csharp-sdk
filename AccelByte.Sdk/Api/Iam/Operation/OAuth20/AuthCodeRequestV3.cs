using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AuthCodeRequestV3 : AccelByte.Sdk.Core.Operation
    {
        public AuthCodeRequestV3(
            string platformId,            
            string? clientId,            
            string? redirectUri,            
            string requestId            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (clientId != null) QueryParams["client_id"] = clientId;
            if (redirectUri != null) QueryParams["redirect_uri"] = redirectUri;
            if (requestId != null) QueryParams["request_id"] = requestId;
            
            
            
            LocationQuery = "code";
        }

        public override string Path => "/iam/v3/oauth/platforms/{platformId}/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            if (code == (HttpStatusCode)302)
            {
              return payloadString;
            }
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}