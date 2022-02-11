using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// getLeaderboardConfigurationAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// This endpoint returns a leaderboard configuration
    /// </summary>
    public class GetLeaderboardConfigurationAdminV1 : AccelByte.Sdk.Core.Operation
    {
        public GetLeaderboardConfigurationAdminV1(
            string leaderboardCode,            
            string namespace_            
        )
        {
            PathParams["leaderboardCode"] = leaderboardCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsGetLeaderboardConfigResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLeaderboardConfigResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}