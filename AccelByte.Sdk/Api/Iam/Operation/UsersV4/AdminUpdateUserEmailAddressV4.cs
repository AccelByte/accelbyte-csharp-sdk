using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminUpdateUserEmailAddressV4
    ///
    /// 
    /// 
    /// Required permission
    /// 
    /// 
    ///                                                                                                 'ADMIN:NAMESPACE:{namespace}:USER:{userId} [UPDATE]'
    /// 
    /// 
    /// 
    /// This is the endpoint for an admin to update a user email address. This
    /// endpoint need a valid user token from an admin to verify its identity (email)
    /// before updating a user.
    /// </summary>
    public class AdminUpdateUserEmailAddressV4 : AccelByte.Sdk.Core.Operation
    {
        public AdminUpdateUserEmailAddressV4(
            string namespace_,            
            string userId,            
            Model.ModelEmailUpdateRequestV4 body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/email";

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