using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class TokenGrant : AccelByte.Sdk.Core.Operation
    {
        public TokenGrant(
            string? code,            
            bool? extendExp,            
            string? namespace_,            
            string? password,            
            string? redirectUri,            
            string? refreshToken,            
            string? username,            
            string grantType            
        )
        {
            
            
            if (code != null) FormParams["code"] = code;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (namespace_ != null) FormParams["namespace"] = namespace_;
            if (password != null) FormParams["password"] = password;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (refreshToken != null) FormParams["refresh_token"] = refreshToken;
            if (username != null) FormParams["username"] = username;
            if (grantType != null) FormParams["grant_type"] = grantType;
            
            
            
        }

        public override string Path => "/iam/oauth/token";

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