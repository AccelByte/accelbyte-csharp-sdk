// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// PublicListContentLikeV2
    ///
    /// This endpoint will only display the list of users who performed like from v2 endpoint.
    /// </summary>
    public class PublicListContentLikeV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListContentLikeV2Builder Builder { get => new PublicListContentLikeV2Builder(); }

        public class PublicListContentLikeV2Builder
            : OperationBuilder<PublicListContentLikeV2Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }





            internal PublicListContentLikeV2Builder() { }


            public PublicListContentLikeV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListContentLikeV2Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicListContentLikeV2Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public PublicListContentLikeV2 Build(
                string contentId,
                string namespace_
            )
            {
                PublicListContentLikeV2 op = new PublicListContentLikeV2(this,
                    contentId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicListContentLikeV2(PublicListContentLikeV2Builder builder,
            string contentId,
            string namespace_
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListContentLikeV2(
            string contentId,
            string namespace_,
            long? limit,
            long? offset,
            string? sortBy
        )
        {
            PathParams["contentId"] = contentId;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/like";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json", "application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsPaginatedContentLikersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedContentLikersResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsPaginatedContentLikersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentLikersResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}