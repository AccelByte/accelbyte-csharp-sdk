// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminQueryParties
    ///
    /// Query parties.
    /// </summary>
    public class AdminQueryParties : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryPartiesBuilder Builder { get => new AdminQueryPartiesBuilder(); }

        public class AdminQueryPartiesBuilder
            : OperationBuilder<AdminQueryPartiesBuilder>
        {

            public string? Joinability { get; set; }

            public string? Key { get; set; }

            public string? LeaderID { get; set; }

            public long? Limit { get; set; }

            public string? MemberID { get; set; }

            public string? MemberStatus { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? PartyID { get; set; }

            public string? Value { get; set; }





            internal AdminQueryPartiesBuilder() { }


            public AdminQueryPartiesBuilder SetJoinability(string _joinability)
            {
                Joinability = _joinability;
                return this;
            }

            public AdminQueryPartiesBuilder SetKey(string _key)
            {
                Key = _key;
                return this;
            }

            public AdminQueryPartiesBuilder SetLeaderID(string _leaderID)
            {
                LeaderID = _leaderID;
                return this;
            }

            public AdminQueryPartiesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminQueryPartiesBuilder SetMemberID(string _memberID)
            {
                MemberID = _memberID;
                return this;
            }

            public AdminQueryPartiesBuilder SetMemberStatus(string _memberStatus)
            {
                MemberStatus = _memberStatus;
                return this;
            }

            public AdminQueryPartiesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminQueryPartiesBuilder SetOrder(string _order)
            {
                Order = _order;
                return this;
            }

            public AdminQueryPartiesBuilder SetOrderBy(string _orderBy)
            {
                OrderBy = _orderBy;
                return this;
            }

            public AdminQueryPartiesBuilder SetPartyID(string _partyID)
            {
                PartyID = _partyID;
                return this;
            }

            public AdminQueryPartiesBuilder SetValue(string _value)
            {
                Value = _value;
                return this;
            }





            public AdminQueryParties Build(
                string namespace_
            )
            {
                AdminQueryParties op = new AdminQueryParties(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryParties(AdminQueryPartiesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Joinability is not null) QueryParams["joinability"] = builder.Joinability;
            if (builder.Key is not null) QueryParams["key"] = builder.Key;
            if (builder.LeaderID is not null) QueryParams["leaderID"] = builder.LeaderID;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MemberID is not null) QueryParams["memberID"] = builder.MemberID;
            if (builder.MemberStatus is not null) QueryParams["memberStatus"] = builder.MemberStatus;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.Value is not null) QueryParams["value"] = builder.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryParties(
            string namespace_,
            string? joinability,
            string? key,
            string? leaderID,
            long? limit,
            string? memberID,
            string? memberStatus,
            long? offset,
            string? order,
            string? orderBy,
            string? partyID,
            string? value
        )
        {
            PathParams["namespace"] = namespace_;

            if (joinability is not null) QueryParams["joinability"] = joinability;
            if (key is not null) QueryParams["key"] = key;
            if (leaderID is not null) QueryParams["leaderID"] = leaderID;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (memberID is not null) QueryParams["memberID"] = memberID;
            if (memberStatus is not null) QueryParams["memberStatus"] = memberStatus;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (value is not null) QueryParams["value"] = value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/parties";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsPartyQueryResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsPartyQueryResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsPartyQueryResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartyQueryResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}