using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    public class GetBannedUsers : AccelByte.Sdk.Core.Operation
    {
        public GetBannedUsers(
            string namespace_,            
            List<string> userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            QueryParams["userIds"] = Convert.ToString(userIds)!;
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/banned";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ADTOObjectForEqu8UserBanStatus>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForEqu8UserBanStatus>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}