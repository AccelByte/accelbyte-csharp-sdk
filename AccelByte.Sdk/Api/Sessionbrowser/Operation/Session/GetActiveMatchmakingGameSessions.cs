// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

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
            : OperationBuilder<GetActiveMatchmakingGameSessionsBuilder>
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
                GetActiveMatchmakingGameSessions op = new GetActiveMatchmakingGameSessions(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetActiveMatchmakingGameSessions(GetActiveMatchmakingGameSessionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.MatchId is not null) QueryParams["match_id"] = builder.MatchId;
            if (builder.ServerRegion is not null) QueryParams["server_region"] = builder.ServerRegion;
            if (builder.SessionId is not null) QueryParams["session_id"] = builder.SessionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
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
            
            if (matchId is not null) QueryParams["match_id"] = matchId;
            if (serverRegion is not null) QueryParams["server_region"] = serverRegion;
            if (sessionId is not null) QueryParams["session_id"] = sessionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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