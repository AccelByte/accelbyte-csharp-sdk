using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getUserStatus
    ///
    /// Get user status.
    /// If actionId does not exist, then the user is not banned.If actionId and
    /// expires exist, then the user is temporarily banned, if expires does not exist,
    /// then the user is permanently banned.Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=2 (READ)
    /// </summary>
    public class GetUserStatus : AccelByte.Sdk.Core.Operation
    {
        public GetUserStatus(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ADTOObjectForEqu8UserStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ADTOObjectForEqu8UserStatus>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ADTOObjectForEqu8UserStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}