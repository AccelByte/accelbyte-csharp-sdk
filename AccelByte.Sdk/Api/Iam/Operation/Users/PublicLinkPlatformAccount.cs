using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicLinkPlatformAccount
    ///
    /// Update Platform Account relation to current User Account. Note: Game
    /// progression data (statistics, reward, etc) associated with previous User
    /// Account will not be transferred. If the data is tight to game user ID, the
    /// user will have the game progression data.
    /// </summary>
    public class PublicLinkPlatformAccount : AccelByte.Sdk.Core.Operation
    {
        public PublicLinkPlatformAccount(
            string namespace_,            
            string userId,            
            Model.ModelLinkPlatformAccountRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/link";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}