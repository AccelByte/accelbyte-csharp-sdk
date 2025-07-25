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

            public string? ConfigurationName { get; set; }

            public string? FromTime { get; set; }

            public string? IsSoftDeleted { get; set; }

            public AdminQueryPartiesJoinability? Joinability { get; set; }

            public string? Key { get; set; }

            public string? LeaderID { get; set; }

            public long? Limit { get; set; }

            public string? MemberID { get; set; }

            public AdminQueryPartiesMemberStatus? MemberStatus { get; set; }

            public long? Offset { get; set; }

            public string? Order { get; set; }

            public string? OrderBy { get; set; }

            public string? PartyID { get; set; }

            public string? ToTime { get; set; }

            public string? Value { get; set; }





            internal AdminQueryPartiesBuilder() { }


            public AdminQueryPartiesBuilder SetConfigurationName(string _configurationName)
            {
                ConfigurationName = _configurationName;
                return this;
            }

            public AdminQueryPartiesBuilder SetFromTime(string _fromTime)
            {
                FromTime = _fromTime;
                return this;
            }

            public AdminQueryPartiesBuilder SetIsSoftDeleted(string _isSoftDeleted)
            {
                IsSoftDeleted = _isSoftDeleted;
                return this;
            }

            public AdminQueryPartiesBuilder SetJoinability(AdminQueryPartiesJoinability _joinability)
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

            public AdminQueryPartiesBuilder SetMemberStatus(AdminQueryPartiesMemberStatus _memberStatus)
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

            public AdminQueryPartiesBuilder SetToTime(string _toTime)
            {
                ToTime = _toTime;
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

            if (builder.ConfigurationName is not null) QueryParams["configurationName"] = builder.ConfigurationName;
            if (builder.FromTime is not null) QueryParams["fromTime"] = builder.FromTime;
            if (builder.IsSoftDeleted is not null) QueryParams["isSoftDeleted"] = builder.IsSoftDeleted;
            if (builder.Joinability is not null) QueryParams["joinability"] = builder.Joinability.Value;
            if (builder.Key is not null) QueryParams["key"] = builder.Key;
            if (builder.LeaderID is not null) QueryParams["leaderID"] = builder.LeaderID;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.MemberID is not null) QueryParams["memberID"] = builder.MemberID;
            if (builder.MemberStatus is not null) QueryParams["memberStatus"] = builder.MemberStatus.Value;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Order is not null) QueryParams["order"] = builder.Order;
            if (builder.OrderBy is not null) QueryParams["orderBy"] = builder.OrderBy;
            if (builder.PartyID is not null) QueryParams["partyID"] = builder.PartyID;
            if (builder.ToTime is not null) QueryParams["toTime"] = builder.ToTime;
            if (builder.Value is not null) QueryParams["value"] = builder.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryParties(
            string namespace_,
            string? configurationName,
            string? fromTime,
            string? isSoftDeleted,
            AdminQueryPartiesJoinability? joinability,
            string? key,
            string? leaderID,
            long? limit,
            string? memberID,
            AdminQueryPartiesMemberStatus? memberStatus,
            long? offset,
            string? order,
            string? orderBy,
            string? partyID,
            string? toTime,
            string? value
        )
        {
            PathParams["namespace"] = namespace_;

            if (configurationName is not null) QueryParams["configurationName"] = configurationName;
            if (fromTime is not null) QueryParams["fromTime"] = fromTime;
            if (isSoftDeleted is not null) QueryParams["isSoftDeleted"] = isSoftDeleted;
            if (joinability is not null) QueryParams["joinability"] = joinability.Value;
            if (key is not null) QueryParams["key"] = key;
            if (leaderID is not null) QueryParams["leaderID"] = leaderID;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (memberID is not null) QueryParams["memberID"] = memberID;
            if (memberStatus is not null) QueryParams["memberStatus"] = memberStatus.Value;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (order is not null) QueryParams["order"] = order;
            if (orderBy is not null) QueryParams["orderBy"] = orderBy;
            if (partyID is not null) QueryParams["partyID"] = partyID;
            if (toTime is not null) QueryParams["toTime"] = toTime;
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

    public class AdminQueryPartiesJoinability : StringEnum<AdminQueryPartiesJoinability>
    {
        public static readonly AdminQueryPartiesJoinability CLOSED
            = new AdminQueryPartiesJoinability("CLOSED");

        public static readonly AdminQueryPartiesJoinability FRIENDSOFFRIENDS
            = new AdminQueryPartiesJoinability("FRIENDS_OF_FRIENDS");

        public static readonly AdminQueryPartiesJoinability FRIENDSOFLEADER
            = new AdminQueryPartiesJoinability("FRIENDS_OF_LEADER");

        public static readonly AdminQueryPartiesJoinability FRIENDSOFMEMBERS
            = new AdminQueryPartiesJoinability("FRIENDS_OF_MEMBERS");

        public static readonly AdminQueryPartiesJoinability INVITEONLY
            = new AdminQueryPartiesJoinability("INVITE_ONLY");

        public static readonly AdminQueryPartiesJoinability OPEN
            = new AdminQueryPartiesJoinability("OPEN");


        public static implicit operator AdminQueryPartiesJoinability(string value)
        {
            return NewValue(value);
        }

        public AdminQueryPartiesJoinability(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminQueryPartiesMemberStatus : StringEnum<AdminQueryPartiesMemberStatus>
    {
        public static readonly AdminQueryPartiesMemberStatus CANCELLED
            = new AdminQueryPartiesMemberStatus("CANCELLED");

        public static readonly AdminQueryPartiesMemberStatus CONNECTED
            = new AdminQueryPartiesMemberStatus("CONNECTED");

        public static readonly AdminQueryPartiesMemberStatus DISCONNECTED
            = new AdminQueryPartiesMemberStatus("DISCONNECTED");

        public static readonly AdminQueryPartiesMemberStatus DROPPED
            = new AdminQueryPartiesMemberStatus("DROPPED");

        public static readonly AdminQueryPartiesMemberStatus INVITED
            = new AdminQueryPartiesMemberStatus("INVITED");

        public static readonly AdminQueryPartiesMemberStatus JOINED
            = new AdminQueryPartiesMemberStatus("JOINED");

        public static readonly AdminQueryPartiesMemberStatus KICKED
            = new AdminQueryPartiesMemberStatus("KICKED");

        public static readonly AdminQueryPartiesMemberStatus LEFT
            = new AdminQueryPartiesMemberStatus("LEFT");

        public static readonly AdminQueryPartiesMemberStatus REJECTED
            = new AdminQueryPartiesMemberStatus("REJECTED");

        public static readonly AdminQueryPartiesMemberStatus TIMEOUT
            = new AdminQueryPartiesMemberStatus("TIMEOUT");


        public static implicit operator AdminQueryPartiesMemberStatus(string value)
        {
            return NewValue(value);
        }

        public AdminQueryPartiesMemberStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}