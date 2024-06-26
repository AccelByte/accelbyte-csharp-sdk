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
    /// queryStats
    ///
    /// Query stats by keyword.
    /// Other detail info:
    ///         *  Returns : stats
    /// </summary>
    public class QueryStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryStatsBuilder Builder { get => new QueryStatsBuilder(); }

        public class QueryStatsBuilder
            : OperationBuilder<QueryStatsBuilder>
        {

            public bool? IsGlobal { get; set; }

            public bool? IsPublic { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }





            internal QueryStatsBuilder() { }


            public QueryStatsBuilder SetIsGlobal(bool _isGlobal)
            {
                IsGlobal = _isGlobal;
                return this;
            }

            public QueryStatsBuilder SetIsPublic(bool _isPublic)
            {
                IsPublic = _isPublic;
                return this;
            }

            public QueryStatsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryStatsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public QueryStats Build(
                string namespace_,
                string keyword
            )
            {
                QueryStats op = new QueryStats(this,
                    namespace_,
                    keyword
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryStats(QueryStatsBuilder builder,
            string namespace_,
            string keyword
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.IsGlobal != null) QueryParams["isGlobal"] = Convert.ToString(builder.IsGlobal)!;
            if (builder.IsPublic != null) QueryParams["isPublic"] = Convert.ToString(builder.IsPublic)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (keyword is not null) QueryParams["keyword"] = keyword;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryStats(
            string namespace_,
            bool? isGlobal,
            bool? isPublic,
            int? limit,
            int? offset,
            string keyword
        )
        {
            PathParams["namespace"] = namespace_;

            if (isGlobal != null) QueryParams["isGlobal"] = Convert.ToString(isGlobal)!;
            if (isPublic != null) QueryParams["isPublic"] = Convert.ToString(isPublic)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (keyword is not null) QueryParams["keyword"] = keyword;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}