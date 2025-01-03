// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// publicGetUserRewards
    ///
    /// - Required permission: NAMESPACE:{namespace}:CHALLENGE:REWARD [READ]
    /// </summary>
    public class PublicGetUserRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserRewardsBuilder Builder { get => new PublicGetUserRewardsBuilder(); }

        public class PublicGetUserRewardsBuilder
            : OperationBuilder<PublicGetUserRewardsBuilder>
        {

            public string? ChallengeCode { get; set; }

            public string? GoalProgressionId { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public PublicGetUserRewardsSortBy? SortBy { get; set; }

            public PublicGetUserRewardsStatus? Status { get; set; }





            internal PublicGetUserRewardsBuilder() { }


            public PublicGetUserRewardsBuilder SetChallengeCode(string _challengeCode)
            {
                ChallengeCode = _challengeCode;
                return this;
            }

            public PublicGetUserRewardsBuilder SetGoalProgressionId(string _goalProgressionId)
            {
                GoalProgressionId = _goalProgressionId;
                return this;
            }

            public PublicGetUserRewardsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetUserRewardsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicGetUserRewardsBuilder SetSortBy(PublicGetUserRewardsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicGetUserRewardsBuilder SetStatus(PublicGetUserRewardsStatus _status)
            {
                Status = _status;
                return this;
            }





            public PublicGetUserRewards Build(
                string namespace_
            )
            {
                PublicGetUserRewards op = new PublicGetUserRewards(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetUserRewards(PublicGetUserRewardsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.ChallengeCode is not null) QueryParams["challengeCode"] = builder.ChallengeCode;
            if (builder.GoalProgressionId is not null) QueryParams["goalProgressionId"] = builder.GoalProgressionId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserRewards(
            string namespace_,
            string? challengeCode,
            string? goalProgressionId,
            long? limit,
            long? offset,
            PublicGetUserRewardsSortBy? sortBy,
            PublicGetUserRewardsStatus? status
        )
        {
            PathParams["namespace"] = namespace_;

            if (challengeCode is not null) QueryParams["challengeCode"] = challengeCode;
            if (goalProgressionId is not null) QueryParams["goalProgressionId"] = goalProgressionId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (status is not null) QueryParams["status"] = status.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/users/me/rewards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListUserRewardsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListUserRewardsResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListUserRewardsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListUserRewardsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicGetUserRewardsSortBy : StringEnum<PublicGetUserRewardsSortBy>
    {
        public static readonly PublicGetUserRewardsSortBy CreatedAt
            = new PublicGetUserRewardsSortBy("createdAt");

        public static readonly PublicGetUserRewardsSortBy CreatedAtasc
            = new PublicGetUserRewardsSortBy("createdAt:asc");

        public static readonly PublicGetUserRewardsSortBy CreatedAtdesc
            = new PublicGetUserRewardsSortBy("createdAt:desc");

        public static readonly PublicGetUserRewardsSortBy UpdatedAt
            = new PublicGetUserRewardsSortBy("updatedAt");

        public static readonly PublicGetUserRewardsSortBy UpdatedAtasc
            = new PublicGetUserRewardsSortBy("updatedAt:asc");

        public static readonly PublicGetUserRewardsSortBy UpdatedAtdesc
            = new PublicGetUserRewardsSortBy("updatedAt:desc");


        public static implicit operator PublicGetUserRewardsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserRewardsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PublicGetUserRewardsStatus : StringEnum<PublicGetUserRewardsStatus>
    {
        public static readonly PublicGetUserRewardsStatus CLAIMED
            = new PublicGetUserRewardsStatus("CLAIMED");

        public static readonly PublicGetUserRewardsStatus UNCLAIMED
            = new PublicGetUserRewardsStatus("UNCLAIMED");


        public static implicit operator PublicGetUserRewardsStatus(string value)
        {
            return NewValue(value);
        }

        public PublicGetUserRewardsStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}