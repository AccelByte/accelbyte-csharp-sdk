using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// deleteGroupPublicV1
    ///
    /// 
    /// 
    /// Required valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP [DELETE]"
    /// 
    /// Delete existing group. This endpoint will check the group ID of the user based
    /// on the access token and compare it with the group ID in path parameter. It
    /// will also check the member role of the user based on the access token
    /// 
    /// Action Code: 73305
    /// </summary>
    public class DeleteGroupPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public DeleteGroupPublicV1(
            string groupId,            
            string namespace_            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}";

        public override HttpMethod Method => HttpMethod.Delete;

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