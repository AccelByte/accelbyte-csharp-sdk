using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminSaveUserRoleV3
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [UPDATE]
    /// permission. User's roles will be updated with given roles (replacing current
    /// user's role). Request body need to specify allowed namespace for given role to
    /// support new role restriction. Skipped the check whether the user performing
    /// the request is a role manager / assigner since there is a plan to discard the
    /// role manager / assigner.
    /// </summary>
    public class AdminSaveUserRoleV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminSaveUserRoleV3(
            string namespace_,            
            string userId,            
            List<Model.ModelNamespaceRoleRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/roles";

        public override HttpMethod Method => HttpMethod.Patch;

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