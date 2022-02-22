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
    /// SearchSessions
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Search sessions.
    /// </summary>
    public class SearchSessions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchSessionsBuilder Builder = new SearchSessionsBuilder();

        public class SearchSessionsBuilder
        {
            
            public string? Channel { get; set; }
            
            public bool? Deleted { get; set; }
            
            public string? MatchID { get; set; }
            
            public string? PartyID { get; set; }
            
            public string? UserID { get; set; }
            
            
            
            internal SearchSessionsBuilder() { }


            public SearchSessionsBuilder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public SearchSessionsBuilder SetDeleted(bool _deleted)
            {
                Deleted = _deleted;
                return this;
            }

            public SearchSessionsBuilder SetMatchID(string _matchID)
            {
                MatchID = _matchID;
                return this;
            }

            public SearchSessionsBuilder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public SearchSessionsBuilder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }




            public SearchSessions Build(
                string namespace_,
                double limit,
                double offset
            )
            {
                return new SearchSessions(this,
                    namespace_,                    
                    limit,                    
                    offset                    
                );
            }
        }

        private SearchSessions(SearchSessionsBuilder builder,
            string namespace_,
            double limit,
            double offset
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Channel != null) QueryParams["channel"] = builder.Channel;
            if (builder.Deleted != null) QueryParams["deleted"] = Convert.ToString(builder.Deleted)!;
            if (builder.MatchID != null) QueryParams["matchID"] = builder.MatchID;
            if (builder.PartyID != null) QueryParams["partyID"] = builder.PartyID;
            if (builder.UserID != null) QueryParams["userID"] = builder.UserID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }
        #endregion

        public SearchSessions(
            string namespace_,            
            string? channel,            
            bool? deleted,            
            string? matchID,            
            string? partyID,            
            string? userID,            
            double limit,            
            double offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (channel != null) QueryParams["channel"] = channel;
            if (deleted != null) QueryParams["deleted"] = Convert.ToString(deleted)!;
            if (matchID != null) QueryParams["matchID"] = matchID;
            if (partyID != null) QueryParams["partyID"] = partyID;
            if (userID != null) QueryParams["userID"] = userID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/sessions/history/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ServiceGetSessionHistorySearchResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}