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
    /// adminGetChallenges
    ///
    /// - Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class AdminGetChallenges : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetChallengesBuilder Builder { get => new AdminGetChallengesBuilder(); }

        public class AdminGetChallengesBuilder
            : OperationBuilder<AdminGetChallengesBuilder>
        {

            public string? Keyword { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public AdminGetChallengesSortBy? SortBy { get; set; }

            public AdminGetChallengesStatus? Status { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminGetChallengesBuilder() { }


            public AdminGetChallengesBuilder SetKeyword(string _keyword)
            {
                Keyword = _keyword;
                return this;
            }

            public AdminGetChallengesBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetChallengesBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetChallengesBuilder SetSortBy(AdminGetChallengesSortBy _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public AdminGetChallengesBuilder SetStatus(AdminGetChallengesStatus _status)
            {
                Status = _status;
                return this;
            }

            public AdminGetChallengesBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminGetChallenges Build(
                string namespace_
            )
            {
                AdminGetChallenges op = new AdminGetChallenges(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetChallenges(AdminGetChallengesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Keyword is not null) QueryParams["keyword"] = builder.Keyword;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy.Value;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetChallenges(
            string namespace_,
            string? keyword,
            long? limit,
            long? offset,
            AdminGetChallengesSortBy? sortBy,
            AdminGetChallengesStatus? status,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (keyword is not null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy.Value;
            if (status is not null) QueryParams["status"] = status.Value;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListChallengeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListChallengeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class AdminGetChallengesSortBy : StringEnum<AdminGetChallengesSortBy>
    {
        public static readonly AdminGetChallengesSortBy CreatedAt
            = new AdminGetChallengesSortBy("createdAt");

        public static readonly AdminGetChallengesSortBy CreatedAtasc
            = new AdminGetChallengesSortBy("createdAt:asc");

        public static readonly AdminGetChallengesSortBy CreatedAtdesc
            = new AdminGetChallengesSortBy("createdAt:desc");

        public static readonly AdminGetChallengesSortBy UpdatedAt
            = new AdminGetChallengesSortBy("updatedAt");

        public static readonly AdminGetChallengesSortBy UpdatedAtasc
            = new AdminGetChallengesSortBy("updatedAt:asc");

        public static readonly AdminGetChallengesSortBy UpdatedAtdesc
            = new AdminGetChallengesSortBy("updatedAt:desc");


        public static implicit operator AdminGetChallengesSortBy(string value)
        {
            return NewValue(value);
        }

        public AdminGetChallengesSortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class AdminGetChallengesStatus : StringEnum<AdminGetChallengesStatus>
    {
        public static readonly AdminGetChallengesStatus INIT
            = new AdminGetChallengesStatus("INIT");

        public static readonly AdminGetChallengesStatus RETIRED
            = new AdminGetChallengesStatus("RETIRED");

        public static readonly AdminGetChallengesStatus TIED
            = new AdminGetChallengesStatus("TIED");


        public static implicit operator AdminGetChallengesStatus(string value)
        {
            return NewValue(value);
        }

        public AdminGetChallengesStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}