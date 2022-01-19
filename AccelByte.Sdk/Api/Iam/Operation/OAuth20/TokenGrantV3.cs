using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class TokenGrantV3 : AccelByte.Sdk.Core.Operation
    {
        public TokenGrantV3(
            string? clientId,            
            string? code,            
            string? codeVerifier,            
            string? redirectUri,            
            string? refreshToken,            
            string grantType            
        )
        {
            
            
            if (clientId != null) FormParams["client_id"] = clientId;
            if (code != null) FormParams["code"] = code;
            if (codeVerifier != null) FormParams["code_verifier"] = codeVerifier;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (refreshToken != null) FormParams["refresh_token"] = refreshToken;
            if (grantType != null) FormParams["grant_type"] = grantType;
            
            
        }

        public override string Path => "/iam/v3/oauth/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Basic";
        
        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}