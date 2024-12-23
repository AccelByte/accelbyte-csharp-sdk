// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Achievement.Operation
{
    /// <summary>
    /// PublicListGlobalAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `NAMESPACE:{namespace}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// Global achievement status value mean: `status = 1 (in progress)` and `status = 2 (unlocked)`
    /// </summary>
    public class PublicListGlobalAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListGlobalAchievementsBuilder Builder { get => new PublicListGlobalAchievementsBuilder(); }

        public class PublicListGlobalAchievementsBuilder
            : OperationBuilder<PublicListGlobalAchievementsBuilder>
        {

            public string? AchievementCodes { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public PublicListGlobalAchievementsSortBy? SortBy { get; set; }

            public string? Status { get; set; }

            public List<string>? Tags { get; set; }





            internal PublicListGlobalAchievementsBuilder() { }


            public PublicListGlobalAchievementsBuilder SetAchievementCodes(string _achievementCodes)
            {
                AchievementCodes = _achievementCodes;
                return this;
            }

            public PublicListGlobalAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListGlobalAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListGlobalAchievementsBuilder SetSortBy(PublicListGlobalAchievementsSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicListGlobalAchievementsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public PublicListGlobalAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicListGlobalAchievements Build(
                string namespace_
            )
            {
                PublicListGlobalAchievements op = new PublicListGlobalAchievements(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicListGlobalAchievements(PublicListGlobalAchievementsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.AchievementCodes is not null) QueryParams["achievementCodes"] = builder.AchievementCodes;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListGlobalAchievements(
            string namespace_,
            string? achievementCodes,
            long? limit,
            long? offset,
            PublicListGlobalAchievementsSortBy? sortBy,
            string? status,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (achievementCodes is not null) QueryParams["achievementCodes"] = achievementCodes;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (status is not null) QueryParams["status"] = status;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/global/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPaginatedGlobalAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGlobalAchievementResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicListGlobalAchievementsSortBy : StringEnum<PublicListGlobalAchievementsSortBy>
    {
        public static readonly PublicListGlobalAchievementsSortBy AchievedAt
            = new PublicListGlobalAchievementsSortBy("achievedAt");

        public static readonly PublicListGlobalAchievementsSortBy AchievedAtasc
            = new PublicListGlobalAchievementsSortBy("achievedAt:asc");

        public static readonly PublicListGlobalAchievementsSortBy AchievedAtdesc
            = new PublicListGlobalAchievementsSortBy("achievedAt:desc");

        public static readonly PublicListGlobalAchievementsSortBy CreatedAt
            = new PublicListGlobalAchievementsSortBy("createdAt");

        public static readonly PublicListGlobalAchievementsSortBy CreatedAtasc
            = new PublicListGlobalAchievementsSortBy("createdAt:asc");

        public static readonly PublicListGlobalAchievementsSortBy CreatedAtdesc
            = new PublicListGlobalAchievementsSortBy("createdAt:desc");


        public static implicit operator PublicListGlobalAchievementsSortBy(string value)
        {
            return NewValue(value);
        }

        public PublicListGlobalAchievementsSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}