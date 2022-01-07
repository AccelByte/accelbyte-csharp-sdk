using System.Net;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class UserAuthenticationV3 : AccelByte.Sdk.Core.Operation
    {
        public override string Path => "/iam/v3/authenticate";

         public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = SECURITY_BEARER;

        public UserAuthenticationV3(
            string clientId,
            bool? extendExp,
            string redirectUri,
            string password,
            string requestId,
            string userName
        )
        {
            FormParams["client_id"] = clientId;
            FormParams["extend_exp"] = extendExp != null ? "true" : "false";
            FormParams["redirect_uri"] = redirectUri;
            FormParams["password"] = password;
            FormParams["request_id"] = requestId;
            FormParams["user_name"] = userName;
            
            LocationQuery = "code";
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