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
        #region Builder Part
        public static QuerySessionBuilder Builder = new QuerySessionBuilder();

        public class QuerySessionBuilder
            : OperationBuilder<QuerySessionBuilder>
        {
            
            public string? GameMode { get; set; }
            
            public string? GameVersion { get; set; }
            
            public string? Joinable { get; set; }
            
            public long? Limit { get; set; }
            
            public string? MatchExist { get; set; }
            
            public string? MatchId { get; set; }
            
            public long? Offset { get; set; }
            
            public string? ServerStatus { get; set; }
            
            public string? UserId { get; set; }
            
            
            internal QuerySessionBuilder() { }


            public QuerySessionBuilder SetGameMode(string _gameMode)
            {
                GameMode = _gameMode;
                return this;
            }

            public QuerySessionBuilder SetGameVersion(string _gameVersion)
            {
                GameVersion = _gameVersion;
                return this;
            }

            public QuerySessionBuilder SetJoinable(string _joinable)
            {
                Joinable = _joinable;
                return this;
            }

            public QuerySessionBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySessionBuilder SetMatchExist(string _matchExist)
            {
                MatchExist = _matchExist;
                return this;
            }

            public QuerySessionBuilder SetMatchId(string _matchId)
            {
                MatchId = _matchId;
                return this;
            }

            public QuerySessionBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySessionBuilder SetServerStatus(string _serverStatus)
            {
                ServerStatus = _serverStatus;
                return this;
            }

            public QuerySessionBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public QuerySession Build(
                string namespace_,
                string sessionType
            )
            {
                QuerySession op = new QuerySession(this,
                    namespace_,                    
                    sessionType                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QuerySession(QuerySessionBuilder builder,
            string namespace_,
            string sessionType
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.GameMode != null) QueryParams["game_mode"] = builder.GameMode;
            if (builder.GameVersion != null) QueryParams["game_version"] = builder.GameVersion;
            if (builder.Joinable != null) QueryParams["joinable"] = builder.Joinable;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MatchExist != null) QueryParams["match_exist"] = builder.MatchExist;
            if (builder.MatchId != null) QueryParams["match_id"] = builder.MatchId;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ServerStatus != null) QueryParams["server_status"] = builder.ServerStatus;
            if (builder.UserId != null) QueryParams["user_id"] = builder.UserId;
            if (sessionType != null) QueryParams["session_type"] = sessionType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySession(
            string namespace_,            
            string? gameMode,            
            string? gameVersion,            
            string? joinable,            
            long? limit,            
            string? matchExist,            
            string? matchId,            
            long? offset,            
            string? serverStatus,            
            string? userId,            
            string sessionType            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (gameMode != null) QueryParams["game_mode"] = gameMode;
            if (gameVersion != null) QueryParams["game_version"] = gameVersion;
            if (joinable != null) QueryParams["joinable"] = joinable;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (matchExist != null) QueryParams["match_exist"] = matchExist;
            if (matchId != null) QueryParams["match_id"] = matchId;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (serverStatus != null) QueryParams["server_status"] = serverStatus;
            if (userId != null) QueryParams["user_id"] = userId;
            if (sessionType != null) QueryParams["session_type"] = sessionType;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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