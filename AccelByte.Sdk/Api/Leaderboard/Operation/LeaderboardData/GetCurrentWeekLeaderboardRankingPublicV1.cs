using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    public class GetCurrentWeekLeaderboardRankingPublicV1 : AccelByte.Sdk.Core.Operation
    {
        public GetCurrentWeekLeaderboardRankingPublicV1(
            string leaderboardCode,            
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
        }

        public override string Path => "/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/week";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetLeaderboardRankingResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardRankingResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}