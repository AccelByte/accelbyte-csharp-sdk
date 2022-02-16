// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// QuerySession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// Query available game session
    /// </summary>
    public class QuerySession : AccelByte.Sdk.Core.Operation
    {
        public QuerySession(
            string namespace_,            
            string? gameMode,            
            string? gameVersion,            
            string? joinable,            
            string? limit,            
            string? matchExist,            
            string? matchId,            
            string? offset,            
            string? serverStatus,            
            string? userId,            
            string sessionType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (gameMode != null) QueryParams["game_mode"] = gameMode;
            if (gameVersion != null) QueryParams["game_version"] = gameVersion;
            if (joinable != null) QueryParams["joinable"] = joinable;
            if (limit != null) QueryParams["limit"] = limit;
            if (matchExist != null) QueryParams["match_exist"] = matchExist;
            if (matchId != null) QueryParams["match_id"] = matchId;
            if (offset != null) QueryParams["offset"] = offset;
            if (serverStatus != null) QueryParams["server_status"] = serverStatus;
            if (userId != null) QueryParams["user_id"] = userId;
            if (sessionType != null) QueryParams["session_type"] = sessionType;
            
            
            
            
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsSessionQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionQueryResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}