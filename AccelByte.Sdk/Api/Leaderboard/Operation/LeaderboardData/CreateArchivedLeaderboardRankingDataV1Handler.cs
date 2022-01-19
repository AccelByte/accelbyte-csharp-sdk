using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    public class CreateArchivedLeaderboardRankingDataV1Handler : AccelByte.Sdk.Core.Operation
    {
        public CreateArchivedLeaderboardRankingDataV1Handler(
            string namespace_,            
            Model.ModelsArchiveLeaderboardReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}