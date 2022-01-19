using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
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
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ADTOObjectForEqu8UserStatus>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}