using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    public class AddRolePermission : AccelByte.Sdk.Core.Operation
    {
        public AddRolePermission(
            long action,            
            string resource,            
            string roleId,            
            Model.ModelUpdatePermissionScheduleRequest body            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/roles/{roleId}/permissions/{resource}/{action}";

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