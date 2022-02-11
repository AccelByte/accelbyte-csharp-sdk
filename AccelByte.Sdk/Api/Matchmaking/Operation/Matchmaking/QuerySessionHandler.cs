using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// QuerySessionHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:SESSION [READ] Required Scope:
    /// social Queries the specified session's status. Game servers are expected to
    /// call this periodically as long as it has a session in queue to see if there
    /// are new players being matched to the session. Possible session statuses are
    /// "sessionInQueue", "sessionFull", and "sessionTimeout".
    /// </summary>
    public class QuerySessionHandler : AccelByte.Sdk.Core.Operation
    {
        public QuerySessionHandler(
            string matchID,            
            string namespace_            
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions/{matchID}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsMatchmakingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMatchmakingResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}