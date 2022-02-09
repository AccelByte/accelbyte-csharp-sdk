using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
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