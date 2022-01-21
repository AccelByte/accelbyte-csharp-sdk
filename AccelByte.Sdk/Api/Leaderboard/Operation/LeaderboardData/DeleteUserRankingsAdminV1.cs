using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    public class DeleteUserRankingsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public DeleteUserRankingsAdminV1(
            string namespace_,            
            string userId,            
            List<string> leaderboardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (leaderboardCode != null) QueryParams["leaderboardCode"] = leaderboardCode;
            
            
            CollectionFormatMap["leaderboardCode"] = "multi";
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}