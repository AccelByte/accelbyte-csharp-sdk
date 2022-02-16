// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// GetSessionHistoryDetailed
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Get session history detailed.
    /// </summary>
    public class GetSessionHistoryDetailed : AccelByte.Sdk.Core.Operation
    {
        public GetSessionHistoryDetailed(
            string matchID,            
            string namespace_            
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ServiceGetSessionHistoryDetailedResponseItem>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ServiceGetSessionHistoryDetailedResponseItem>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ServiceGetSessionHistoryDetailedResponseItem>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}