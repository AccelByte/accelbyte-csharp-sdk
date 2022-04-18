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
    /// SearchSessionsV2
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Search sessions. Optimize the query by differentiating query with filter namespace only and filter with namespace & other filter (partyID, userID, matchID).
    /// Query with filter namespace only will not group whole session data while query with filter namespace & other filter will include session data.
    /// </summary>
    public class SearchSessionsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SearchSessionsV2Builder Builder = new SearchSessionsV2Builder();

        public class SearchSessionsV2Builder
            : OperationBuilder<SearchSessionsV2Builder>
        {
            
            public string? Channel { get; set; }
            
            public bool? Deleted { get; set; }
            
            public string? MatchID { get; set; }
            
            public string? PartyID { get; set; }
            
            public string? UserID { get; set; }
            
            
            
            internal SearchSessionsV2Builder() { }


            public SearchSessionsV2Builder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public SearchSessionsV2Builder SetDeleted(bool _deleted)
            {
                Deleted = _deleted;
                return this;
            }

            public SearchSessionsV2Builder SetMatchID(string _matchID)
            {
                MatchID = _matchID;
                return this;
            }

            public SearchSessionsV2Builder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public SearchSessionsV2Builder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }




            public SearchSessionsV2 Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                SearchSessionsV2 op = new SearchSessionsV2(this,
                    namespace_,                    
                    limit,                    
                    offset                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SearchSessionsV2(SearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
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
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SearchSessionsV2(
            string namespace_,            
            string? channel,            
            bool? deleted,            
            string? matchID,            
            string? partyID,            
            string? userID,            
            long limit,            
            long offset            
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
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v2/admin/namespaces/{namespace}/sessions/history/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ServiceGetSessionHistorySearchResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ServiceGetSessionHistorySearchResponseV2>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}