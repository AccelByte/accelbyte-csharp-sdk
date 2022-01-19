using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    public class UserRejectFriendRequest : AccelByte.Sdk.Core.Operation
    {
        public UserRejectFriendRequest(
            string namespace_,            
            Model.ModelUserRejectFriendRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/reject";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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