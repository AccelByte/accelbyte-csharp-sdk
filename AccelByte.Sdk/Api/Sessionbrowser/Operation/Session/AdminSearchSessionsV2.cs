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
    /// AdminSearchSessionsV2
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:SESSION [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Search sessions. Optimize the query by differentiating query with filter namespace only and filter with namespace & other filter (partyID, userID, matchID).
    /// Query with filter namespace only will not group whole session data while query with filter namespace & other filter will include session data.
    /// </summary>
    public class AdminSearchSessionsV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchSessionsV2Builder Builder = new AdminSearchSessionsV2Builder();

        public class AdminSearchSessionsV2Builder
            : OperationBuilder<AdminSearchSessionsV2Builder>
        {

            public string? Channel { get; set; }

            public bool? Deleted { get; set; }

            public string? MatchID { get; set; }

            public string? PartyID { get; set; }

            public string? UserID { get; set; }





            internal AdminSearchSessionsV2Builder() { }


            public AdminSearchSessionsV2Builder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public AdminSearchSessionsV2Builder SetDeleted(bool _deleted)
            {
                Deleted = _deleted;
                return this;
            }

            public AdminSearchSessionsV2Builder SetMatchID(string _matchID)
            {
                MatchID = _matchID;
                return this;
            }

            public AdminSearchSessionsV2Builder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public AdminSearchSessionsV2Builder SetUserID(string _userID)
            {
                UserID = _userID;
                return this;
            }





            public AdminSearchSessionsV2 Build(
                string namespace_,
                long limit,
                long offset
            )
            {
                AdminSearchSessionsV2 op = new AdminSearchSessionsV2(this,
                    namespace_,
                    limit,
                    offset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminSearchSessionsV2(AdminSearchSessionsV2Builder builder,
            string namespace_,
            long limit,
            long offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Channel is not null) QueryParams["channel"] = builder.Channel;
            if (builder.Deleted != null) QueryParams["deleted"] = Convert.ToString(builder.Deleted)!;
            if (builder.MatchID is not null) QueryParams["matchID"] = builder.MatchID;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.UserID is not null) QueryParams["userID"] = builder.UserID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSearchSessionsV2(
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

            if (channel is not null) QueryParams["channel"] = channel;
            if (deleted != null) QueryParams["deleted"] = Convert.ToString(deleted)!;
            if (matchID is not null) QueryParams["matchID"] = matchID;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (userID is not null) QueryParams["userID"] = userID;
            QueryParams["limit"] = Convert.ToString(limit)!;
            QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/sessions/history/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsGetSessionHistorySearchResponseV2? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetSessionHistorySearchResponseV2>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetSessionHistorySearchResponseV2>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}