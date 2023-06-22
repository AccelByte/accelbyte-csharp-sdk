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
    /// AdminListUserAchievements
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// 
    /// 
    /// 
    /// 
    /// Note:
    /// 
    /// 
    /// 
    /// 
    /// User Achievement status value mean: `status = 1 (in progress)` and `status = 2 (unlocked)`
    /// 
    /// 
    /// 
    /// 
    /// `achievedAt` value will return default value: `0001-01-01T00:00:00Z` for user achievement that locked or in progress
    /// </summary>
    public class AdminListUserAchievements : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserAchievementsBuilder Builder { get => new AdminListUserAchievementsBuilder(); }

        public class AdminListUserAchievementsBuilder
            : OperationBuilder<AdminListUserAchievementsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public bool? PreferUnlocked { get; set; }

            public string? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListUserAchievementsBuilder() { }


            public AdminListUserAchievementsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUserAchievementsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListUserAchievementsBuilder SetPreferUnlocked(bool _preferUnlocked)
            {
                PreferUnlocked = _preferUnlocked;
                return this;
            }

            public AdminListUserAchievementsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListUserAchievementsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListUserAchievements Build(
                string namespace_,
                string userId
            )
            {
                AdminListUserAchievements op = new AdminListUserAchievements(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminListUserAchievements(AdminListUserAchievementsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.PreferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(builder.PreferUnlocked)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUserAchievements(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            bool? preferUnlocked,
            string? sortBy,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (preferUnlocked != null) QueryParams["preferUnlocked"] = Convert.ToString(preferUnlocked)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPaginatedUserAchievementResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedUserAchievementResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}