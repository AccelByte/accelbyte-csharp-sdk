using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminInviteUserV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER:INVITE [CREATE] Use this
    /// endpoint to invite admin or non-admin user and assign role to them. The role
    /// must be scoped to namespace. Substitute the namespace in path parameter to
    /// desired role's namespace'. An admin user can only assign role to namespaces
    /// that the admin user has the required permission. Role is optional, if not
    /// specified then it will only assign User role The invited admin will also
    /// assigned with "User" role by default.
    /// </summary>
    public class AdminInviteUserV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminInviteUserV3(
            string namespace_,            
            Model.ModelInviteUserRequestV3 body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}