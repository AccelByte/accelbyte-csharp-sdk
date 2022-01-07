using System.Net;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AuthorizeV3 : AccelByte.Sdk.Core.Operation
    {
        public override string Path => "/iam/v3/oauth/authorize";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = SECURITY_BEARER;

        public AuthorizeV3(
            string codeChallenge,
            string codeChallengeMethod,
            string redirectUri,
            string scope,
            string state,
            string targetAuthPage,
            string clientId,
            string responseType
        )
        {
            QueryParams["code_challenge"] = codeChallenge;
            QueryParams["code_challenge_method"] = codeChallengeMethod;
            QueryParams["redirect_uri"] = redirectUri;
            QueryParams["scope"] = scope;
            QueryParams["state"] = state;
            QueryParams["target_auth_page"] = targetAuthPage;
            QueryParams["client_id"] = clientId;
            QueryParams["response_type"] = responseType;

            LocationQuery = "request_id";
        }

        public override object? ParseResponse(HttpStatusCode code, string contentTpe, Stream payload)
        {
            var json = Helper.ConvertInputStreamToString(payload);

            if (code != (HttpStatusCode)302)
            {
                throw new HttpResponseException(code, json);
            }

            return json;
        }
    }
}