using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class Authorization : AccelByte.Sdk.Core.Operation
    {
        public Authorization(
            string? login,            
            string? password,            
            string? scope,            
            string? state,            
            string clientId,            
            string redirectUri,            
            string responseType            
        )
        {
            
            
            if (login != null) FormParams["login"] = login;
            if (password != null) FormParams["password"] = password;
            if (scope != null) FormParams["scope"] = scope;
            if (state != null) FormParams["state"] = state;
            if (clientId != null) FormParams["client_id"] = clientId;
            if (redirectUri != null) FormParams["redirect_uri"] = redirectUri;
            if (responseType != null) FormParams["response_type"] = responseType;
            
            
            
            LocationQuery = "PLACEHOLDER";
        }

        public override string Path => "/iam/oauth/authorize";

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