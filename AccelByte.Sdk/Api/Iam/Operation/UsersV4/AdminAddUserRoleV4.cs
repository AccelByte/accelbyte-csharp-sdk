using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminAddUserRoleV4
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:ROLE:USER:* [UPDATE]
    /// permission. New role will be appended to user's current roles. Request body
    /// need to specify allowed namespace for given role to support new role
    /// restriction. Skipped the check whether the user performing the request is a
    /// role manager / assigner since there is a plan to discard the role manager /
    /// assigner.
    /// </summary>
    public class AdminAddUserRoleV4 : AccelByte.Sdk.Core.Operation
    {
        public AdminAddUserRoleV4(
            string namespace_,            
            string userId,            
            Model.ModelAddUserRoleV4Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelListUserRolesV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRolesV4Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}