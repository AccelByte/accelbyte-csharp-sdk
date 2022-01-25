using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    public class GetSingleMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        public GetSingleMatchmakingChannel(
            string channelName,            
            string namespace_            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsChannelV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelV1>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}