using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// RevokeAUser
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated at 21 August, 2018. Please use this
    /// instead: oauth/namespaces/{namespace}/users/{userId}/revoke
    /// 
    /// This endpoint revokes a user.
    /// 
    /// This endpoint requires all requests to have Authorization header set with
    /// Bearer access authentication with valid access token.
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userID}:ADMIN [UPDATE]'
    /// 
    /// When other clients know that the userID has been revoked and the token is
    /// issued before the revocation, forcing a new token will contain banned
    /// permissions.
    /// </summary>
    public class RevokeAUser : AccelByte.Sdk.Core.Operation
    {
        public RevokeAUser(
            string userID            
        )
        {
            
            
            if (userID != null) FormParams["userID"] = userID;
            
            
            
        }

        public override string Path => "/iam/oauth/revoke/user";

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