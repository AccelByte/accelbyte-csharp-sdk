using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AuthorizeV3 : AccelByte.Sdk.Core.Operation
    {
        public AuthorizeV3(
            string? codeChallenge,            
            string? codeChallengeMethod,            
            string? redirectUri,            
            string? scope,            
            string? state,            
            string? targetAuthPage,            
            string clientId,            
            string responseType            
        )
        {
            
            if (codeChallenge != null) QueryParams["code_challenge"] = codeChallenge;
            if (codeChallengeMethod != null) QueryParams["code_challenge_method"] = codeChallengeMethod;
            if (redirectUri != null) QueryParams["redirect_uri"] = redirectUri;
            if (scope != null) QueryParams["scope"] = scope;
            if (state != null) QueryParams["state"] = state;
            if (targetAuthPage != null) QueryParams["target_auth_page"] = targetAuthPage;
            if (clientId != null) QueryParams["client_id"] = clientId;
            if (responseType != null) QueryParams["response_type"] = responseType;
            
            
            
            
            LocationQuery = "request_id";
        }

        public override string Path => "/iam/v3/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

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