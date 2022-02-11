using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateAdminRoleStatusV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// Admin roles has its members listed in the role.
    /// 
    /// Role can be set as admin role only when it has at least 1 manager.
    /// 
    /// 
    /// action code: 10412
    /// </summary>
    public class AdminUpdateAdminRoleStatusV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateAdminRoleStatusV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/admin";

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