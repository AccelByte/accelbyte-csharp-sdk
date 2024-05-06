// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryRewards_1
    ///
    /// This API is used to query rewards by criteria.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : the list of rewards
    /// </summary>
    public class QueryRewards1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRewards1Builder Builder { get => new QueryRewards1Builder(); }

        public class QueryRewards1Builder
            : OperationBuilder<QueryRewards1Builder>
        {

            public string? EventTopic { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public List<QueryRewards1SortBy>? SortBy { get; set; }





            internal QueryRewards1Builder() { }


            public QueryRewards1Builder SetEventTopic(string _eventTopic)
            {
                EventTopic = _eventTopic;
                return this;
            }

            public QueryRewards1Builder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRewards1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRewards1Builder SetSortBy(List<QueryRewards1SortBy> _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public QueryRewards1 Build(
                string namespace_
            )
            {
                QueryRewards1 op = new QueryRewards1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private QueryRewards1(QueryRewards1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EventTopic is not null) QueryParams["eventTopic"] = builder.EventTopic;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy is not null) QueryParams["sortBy"] = builder.SortBy;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRewards1(
            string namespace_,
            string? eventTopic,
            int? limit,
            int? offset,
            List<QueryRewards1SortBy>? sortBy
        )
        {
            PathParams["namespace"] = namespace_;

            if (eventTopic is not null) QueryParams["eventTopic"] = eventTopic;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy is not null) QueryParams["sortBy"] = sortBy;



            CollectionFormatMap["sortBy"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RewardPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryRewards1SortBy : StringEnum<QueryRewards1SortBy>
    {
        public static readonly QueryRewards1SortBy Namespace
            = new QueryRewards1SortBy("namespace");

        public static readonly QueryRewards1SortBy Namespaceasc
            = new QueryRewards1SortBy("namespace:asc");

        public static readonly QueryRewards1SortBy Namespacedesc
            = new QueryRewards1SortBy("namespace:desc");

        public static readonly QueryRewards1SortBy RewardCode
            = new QueryRewards1SortBy("rewardCode");

        public static readonly QueryRewards1SortBy RewardCodeasc
            = new QueryRewards1SortBy("rewardCode:asc");

        public static readonly QueryRewards1SortBy RewardCodedesc
            = new QueryRewards1SortBy("rewardCode:desc");


        public static implicit operator QueryRewards1SortBy(string value)
        {
            return NewValue(value);
        }

        public QueryRewards1SortBy(string enumValue)
            : base(enumValue)
        {

        }
    }

}