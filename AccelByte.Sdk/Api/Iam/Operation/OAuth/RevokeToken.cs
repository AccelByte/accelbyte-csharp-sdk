using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RevokeToken
    ///
    /// 
    /// 
    /// # Deprecated at August 30, 2019. Please use the /v3/oauth/revoke endpoint
    /// instead
    /// 
    /// Revokes a token.
    /// 
    /// This endpoint requires all requests to have Authorization header set with
    /// Basic access authentication constructed from client id and client secret or
    /// Bearer access authentication with valid access token.
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class RevokeToken : AccelByte.Sdk.Core.Operation
    {
        public RevokeToken(
            string token            
        )
        {
            
            
            if (token != null) FormParams["token"] = token;
            
            
            
        }

        public override string Path => "/iam/oauth/revoke/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}