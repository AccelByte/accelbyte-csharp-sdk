using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// getSingleMemberRoleAdminV1
    ///
    /// 
    /// 
    /// Required permission ADMIN:NAMESPACE:{namespace}:GROUP:ROLE [READ]
    /// 
    /// This endpoint is used to get member role based on the role ID
    /// 
    /// Action Code: 73203
    /// </summary>
    public class GetSingleMemberRoleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public GetSingleMemberRoleAdminV1(
            string memberRoleId,            
            string namespace_            
        )
        {
            PathParams["memberRoleId"] = memberRoleId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/roles/{memberRoleId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetMemberRoleResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRoleResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetMemberRoleResponseV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}