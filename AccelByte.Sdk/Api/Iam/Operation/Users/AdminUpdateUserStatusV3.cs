using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateUserStatusV3
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:USERSTATUS:USER:{userId}
    /// [UPDATE]'
    /// 
    /// This endpoint disable or enable user account. Set the enable status on the
    /// request body to true to enable user account or set to false to disable it.
    /// 
    /// Disable user for Account Disable purpose fill the reason with:
    /// 
    ///                 * AdminDeactivateAccount : if your disable account request comes from admin
    /// 
    /// Enable user ignore field 'reason' in the request body.
    /// 
    /// 
    /// action code : 10143
    /// </summary>
    public class AdminUpdateUserStatusV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateUserStatusV3(
            string namespace_,            
            string userId,            
            Model.ModelUpdateUserStatusRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/status";

        public override HttpMethod Method => HttpMethod.Patch;

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