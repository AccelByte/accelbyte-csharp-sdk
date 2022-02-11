using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// GetAdminUsersByRoleID
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// 
    /// This endpoint search admin users which have the roleId
    /// 
    /// Notes : this endpoint only accept admin role. Admin Role is role which have
    /// admin status and members. Use endpoint [GET] /roles/{roleId}/admin to check
    /// the role status
    /// </summary>
    public class GetAdminUsersByRoleID : AccelByte.Sdk.Core.Operation
    {
        public GetAdminUsersByRoleID(
            string namespace_,            
            long? after,            
            long? before,            
            long? limit,            
            string? roleId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = Convert.ToString(after)!;
            if (before != null) QueryParams["before"] = Convert.ToString(before)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (roleId != null) QueryParams["roleId"] = roleId;
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/admin";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetAdminUsersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAdminUsersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}