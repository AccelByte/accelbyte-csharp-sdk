using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// updateGroupCustomAttributesPublicV1
    ///
    /// 
    /// 
    /// Requires valid user authentication
    /// 
    /// Required Member Role Permission: "GROUP [UPDATE]"
    /// 
    /// This endpoint replaces current group custom attributes entirely. This endpoint
    /// will check the group ID of the user based on the access token and compare it
    /// with the group ID in path parameter. It will also check the member role of the
    /// user based on the access token
    /// 
    /// Action Code: 73311
    /// </summary>
    public class UpdateGroupCustomAttributesPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public UpdateGroupCustomAttributesPublicV1(
            string groupId,            
            string namespace_,            
            Model.ModelsUpdateGroupCustomAttributesRequestV1 body            
        )
        {
            PathParams["groupId"] = groupId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/group/v1/public/namespaces/{namespace}/groups/{groupId}/attributes/custom";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGroupResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGroupResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}