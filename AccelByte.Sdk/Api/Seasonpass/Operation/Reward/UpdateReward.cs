using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    public class UpdateReward : AccelByte.Sdk.Core.Operation
    {
        public UpdateReward(
            string code,            
            string namespace_,            
            string seasonId,            
            Model.RewardUpdate body            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RewardInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}