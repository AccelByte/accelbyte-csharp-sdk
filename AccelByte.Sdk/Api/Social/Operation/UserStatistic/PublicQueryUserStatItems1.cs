// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicQueryUserStatItems_1
    ///
    /// Public list all statItems by pagination.
    /// Other detail info:
    ///           *  Returns : stat items
    /// </summary>
    public class PublicQueryUserStatItems1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserStatItems1Builder Builder { get => new PublicQueryUserStatItems1Builder(); }

        public class PublicQueryUserStatItems1Builder
            : OperationBuilder<PublicQueryUserStatItems1Builder>
        {

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SortBy { get; set; }

            public string? StatCodes { get; set; }

            public string? Tags { get; set; }





            internal PublicQueryUserStatItems1Builder() { }


            public PublicQueryUserStatItems1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserStatItems1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserStatItems1Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public PublicQueryUserStatItems1Builder SetStatCodes(string _statCodes)
            {
                StatCodes = _statCodes;
                return this;
            }

            public PublicQueryUserStatItems1Builder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicQueryUserStatItems1 Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserStatItems1 op = new PublicQueryUserStatItems1(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicQueryUserStatItems1(PublicQueryUserStatItems1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StatCodes is not null) QueryParams["statCodes"] = builder.StatCodes;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserStatItems1(
            string namespace_,
            string userId,
            int? limit,
            int? offset,
            string? sortBy,
            string? statCodes,
            string? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;
            if (statCodes is not null) QueryParams["statCodes"] = statCodes;
            if (tags is not null) QueryParams["tags"] = tags;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/statitems";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.UserStatItemPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserStatItemPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}