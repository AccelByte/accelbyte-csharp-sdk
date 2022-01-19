using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AdminAssignUserToRoleV4 : AccelByte.Sdk.Core.Operation
    {
        public AdminAssignUserToRoleV4(
            string roleId,            
            Model.ModelAssignUserV4Request body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/roles/{roleId}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelAssignedUserV4Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAssignedUserV4Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}