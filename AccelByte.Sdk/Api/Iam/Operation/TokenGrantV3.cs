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
                string clientId,
                string code,
                string codeVerifier,
                string redirectUri,
                string refreshToken,
                string grantType
        )
        {
            FormParams["client_id"] = clientId;
            FormParams["code"] = code;
            FormParams["code_verifier"] = codeVerifier;
            FormParams["redirect_uri"] = redirectUri;
            FormParams["refresh_token"] = refreshToken;
            FormParams["grant_type"] = grantType;
        }

        public override string Path => "/iam/v3/oauth/token";

         public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = SECURITY_BASIC;

        public override object? ParseResponse(HttpStatusCode code, string contentTpe, Stream payload)
        {
            if (code != (HttpStatusCode)200)
            {
                var jsonString = Helper.ConvertInputStreamToString(payload);

                throw new HttpResponseException(code, jsonString);
            }

            return JsonSerializer.Deserialize<OauthmodelTokenResponseV3>(payload);
        }
    }
}