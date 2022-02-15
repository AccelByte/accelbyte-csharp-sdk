using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// DisableUser
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated. Please use this instead:
    /// iam/v2/admin/namespaces/{namespace}/users/{userId}/disable
    /// 
    /// +
    /// 
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:USERSTATUS:USER:{userId}
    /// [UPDATE]'
    /// 
    /// For Deletion Account purpose fill the reason with:
    /// 
    ///     * DeactivateAccount : if your deletion request comes from user
    ///     * AdminDeactivateAccount : if your deletion request comes from admin
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class DisableUser : AccelByte.Sdk.Core.Operation
    {
        public DisableUser(
            string namespace_,            
            string userId,            
            Model.ModelDisableUserRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/disable";

        public override HttpMethod Method => HttpMethod.Put;

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