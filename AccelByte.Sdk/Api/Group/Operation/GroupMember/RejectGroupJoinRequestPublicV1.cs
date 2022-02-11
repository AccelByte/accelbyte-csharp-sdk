using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// rejectGroupJoinRequestPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP:JOIN [CREATE]"
    /// 
    /// This endpoint is used to reject group join request.
    /// 
    /// Reject group join request. If specific user is not asked to join the specific
    /// group ID, it will show the the error to show if the user is not asked to join
    /// yet.
    /// 
    /// This endpoint will also check if the specific user is already joined to
    /// specific group
    /// 
    /// Action Code: 73408
    /// </summary>
    public class RejectGroupJoinRequestPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public RejectGroupJoinRequestPublicV1(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/users/{userId}/join/reject";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsMemberRequestGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberRequestGroupResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}