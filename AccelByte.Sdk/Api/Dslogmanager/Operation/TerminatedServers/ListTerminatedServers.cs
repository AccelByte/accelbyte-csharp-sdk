using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    public class ListTerminatedServers : AccelByte.Sdk.Core.Operation
    {
        public ListTerminatedServers(
            string namespace_,            
            string? deployment,            
            string? endDate,            
            string? gameMode,            
            long? limit,            
            string? next,            
            string? partyId,            
            string? podName,            
            string? previous,            
            string? provider,            
            string? region,            
            string? sessionId,            
            string? startDate,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (deployment != null) QueryParams["deployment"] = deployment;
            if (endDate != null) QueryParams["end_date"] = endDate;
            if (gameMode != null) QueryParams["game_mode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (next != null) QueryParams["next"] = next;
            if (partyId != null) QueryParams["party_id"] = partyId;
            if (podName != null) QueryParams["pod_name"] = podName;
            if (previous != null) QueryParams["previous"] = previous;
            if (provider != null) QueryParams["provider"] = provider;
            if (region != null) QueryParams["region"] = region;
            if (sessionId != null) QueryParams["session_id"] = sessionId;
            if (startDate != null) QueryParams["start_date"] = startDate;
            if (userId != null) QueryParams["user_id"] = userId;
            
            
            
            
        }

        public override string Path => "/dslogmanager/namespaces/{namespace}/servers/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json","text/x-log" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListTerminatedServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}