using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    public class GetRewardByCode : AccelByte.Sdk.Core.Operation
    {
        public GetRewardByCode(
            string namespace_,            
            string rewardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (rewardCode != null) QueryParams["rewardCode"] = rewardCode;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

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