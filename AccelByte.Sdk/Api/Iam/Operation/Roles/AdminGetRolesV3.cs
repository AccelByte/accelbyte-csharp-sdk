using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetRolesV3
    ///
    /// Required permission 'ADMIN:ROLE [READ]'
    /// 
    /// action code: 10414
    /// </summary>
    public class AdminGetRolesV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminGetRolesV3(
            string? after,            
            string? before,            
            bool? isWildcard,            
            long? limit            
        )
        {
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelRoleResponseWithManagersAndPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleResponseWithManagersAndPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}