// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// listAllTerminatedServers
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSLM:SERVER [READ]
    /// 
    /// This endpoint used to retrieve terminated servers in all namespace
    /// ```
    /// </summary>
    public class ListAllTerminatedServers : AccelByte.Sdk.Core.Operation
    {
        public ListAllTerminatedServers(
            string? deployment,            
            string? endDate,            
            string? gameMode,            
            long? limit,            
            string? namespace_,            
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
            
            if (deployment != null) QueryParams["deployment"] = deployment;
            if (endDate != null) QueryParams["end_date"] = endDate;
            if (gameMode != null) QueryParams["game_mode"] = gameMode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
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

        public override string Path => "/dslogmanager/servers/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListTerminatedServersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListTerminatedServersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}