using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// platformAuthenticateSAMLV3Handler
    ///
    /// This endpoint authenticates user platform for SAML protocol. It validates user
    /// to its respective platforms. Deactivated or login-banned users are unable to
    /// login.
    /// 
    /// ## Supported platforms:
    /// 
    ///                           * azure
    /// Microsoft login page will redirects to this endpoint after login success as
    /// previously defined on authentication request SAML
    /// </summary>
    public class PlatformAuthenticateSAMLV3Handler : AccelByte.Sdk.Core.Operation
    {
        public PlatformAuthenticateSAMLV3Handler(
            string platformId,            
            string? code,            
            string? error,            
            string state            
        )
        {
            PathParams["platformId"] = platformId;
            
            if (code != null) QueryParams["code"] = code;
            if (error != null) QueryParams["error"] = error;
            if (state != null) QueryParams["state"] = state;
            
            
            
            
            LocationQuery = "PLACEHOLDER";
        }

        public override string Path => "/iam/v3/sso/saml/platforms/{platformId}/authenticate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] {  };

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