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
    /// GetActiveMatchmakingGameSessions
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// </summary>
    public class GetActiveMatchmakingGameSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetActiveMatchmakingGameSessionsBuilder Builder = new GetActiveMatchmakingGameSessionsBuilder();

        public class GetActiveMatchmakingGameSessionsBuilder
        {
            
            public string? MatchId { get; set; }
            
            public string? ServerRegion { get; set; }
            
            public string? SessionId { get; set; }
            
            internal GetActiveMatchmakingGameSessionsBuilder() { }


            public GetActiveMatchmakingGameSessionsBuilder SetMatchId(string _matchId)
            {
                MatchId = _matchId;
                return this;
            }

            public GetActiveMatchmakingGameSessionsBuilder SetServerRegion(string _serverRegion)
            {
                ServerRegion = _serverRegion;
                return this;
            }

            public GetActiveMatchmakingGameSessionsBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }




            public GetActiveMatchmakingGameSessions Build(
                string namespace_
            )
            {
                return new GetActiveMatchmakingGameSessions(this,
                    namespace_                    
                );
            }
        }

        private GetActiveMatchmakingGameSessions(GetActiveMatchmakingGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.MatchId != null) QueryParams["match_id"] = builder.MatchId;
            if (builder.ServerRegion != null) QueryParams["server_region"] = builder.ServerRegion;
            if (builder.SessionId != null) QueryParams["session_id"] = builder.SessionId;
            
            
            
            
        }
        #endregion

        public GetActiveMatchmakingGameSessions(
            string namespace_,            
            string? matchId,            
            string? serverRegion,            
            string? sessionId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (matchId != null) QueryParams["match_id"] = matchId;
            if (serverRegion != null) QueryParams["server_region"] = serverRegion;
            if (sessionId != null) QueryParams["session_id"] = sessionId;
            
            
            
            
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsActiveMatchmakingGameResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsActiveMatchmakingGameResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsActiveMatchmakingGameResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}