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
    /// AdminListUserContributions
    ///
    /// 
    /// 
    /// Required permission
    /// `ADMIN:NAMESPACE:{namespace}:USER:{userId}:ACHIEVEMENT [READ]` and scope `social`
    /// </summary>
    public class AdminListUserContributions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUserContributionsBuilder Builder { get => new AdminListUserContributionsBuilder(); }

        public class AdminListUserContributionsBuilder
            : OperationBuilder<AdminListUserContributionsBuilder>
        {

            public string? AchievementCodes { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListUserContributionsBuilder() { }


            public AdminListUserContributionsBuilder SetAchievementCodes(string _achievementCodes)
            {
                AchievementCodes = _achievementCodes;
                return this;
            }

            public AdminListUserContributionsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUserContributionsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListUserContributionsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminListUserContributionsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListUserContributions Build(
                string namespace_,
                string userId
            )
            {
                AdminListUserContributions op = new AdminListUserContributions(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminListUserContributions(AdminListUserContributionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.AchievementCodes is not null) QueryParams["achievementCodes"] = builder.AchievementCodes;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUserContributions(
            string namespace_,
            string userId,
            string? achievementCodes,
            long? limit,
            long? offset,
            string? sortBy,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (achievementCodes is not null) QueryParams["achievementCodes"] = achievementCodes;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/admin/namespaces/{namespace}/users/{userId}/global/achievements";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPaginatedUserContributionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedUserContributionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedUserContributionResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}