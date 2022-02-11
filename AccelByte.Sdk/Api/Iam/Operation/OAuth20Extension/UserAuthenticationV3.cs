using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// UserAuthenticationV3
    ///
    /// 
    /// 
    /// This endpoint is being used to authenticate a user account. It validates
    /// user's email / username and password. Deactivated or login-banned users are
    /// unable to login Redirect URI and Client ID must be specified as a pair and
    /// only used to redirect to the specified redirect URI in case the requestId is
    /// no longer valid.
    /// 
    /// 
    /// action code: 10801
    /// </summary>
    public class UserAuthenticationV3 : AccelByte.Sdk.Core.Operation
    {
        public UserAuthenticationV3(
            string? clientId,            
            bool? extendExp,            
            string? redirectUri,            
            string password,            
            string requestId,            
            string userName            
        )
        {
            
            
            if (clientId != null) FormParams["client_id"] = clientId;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (password != null) FormParams["password"] = password;
            if (requestId != null) FormParams["request_id"] = requestId;
            if (userName != null) FormParams["user_name"] = userName;
            
            
            
            LocationQuery = "code";
        }

        public override string Path => "/iam/v3/authenticate";

        public override HttpMethod Method => HttpMethod.Post;

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