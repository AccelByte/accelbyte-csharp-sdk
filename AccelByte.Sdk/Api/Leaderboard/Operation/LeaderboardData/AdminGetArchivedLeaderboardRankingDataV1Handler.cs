using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    public class AdminGetArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        public AdminGetArchivedLeaderboardRankingDataV1Handler(
            string namespace_,            
            string? slug,            
            string leaderboardCodes            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (slug != null) QueryParams["slug"] = slug;
            if (leaderboardCodes != null) QueryParams["leaderboardCodes"] = leaderboardCodes;
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelsArchiveLeaderboardSignedURLResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsArchiveLeaderboardSignedURLResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}