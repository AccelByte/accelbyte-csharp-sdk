// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    ///   * Required permission : resource="NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : the list of rewards
    /// </summary>
    public class QueryRewards1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRewards1Builder Builder = new QueryRewards1Builder();

        public class QueryRewards1Builder
        {
            
            public string? EventTopic { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? SortBy { get; set; }
            
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

            public QueryRewards1Builder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }




            public QueryRewards1 Build(
                string namespace_
            )
            {
                return new QueryRewards1(this,
                    namespace_                    
                );
            }
        }

        private QueryRewards1(QueryRewards1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EventTopic != null) QueryParams["eventTopic"] = builder.EventTopic;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            
            
            
            
        }
        #endregion

        public QueryRewards1(
            string namespace_,            
            string? eventTopic,            
            int? limit,            
            int? offset,            
            string? sortBy            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (eventTopic != null) QueryParams["eventTopic"] = eventTopic;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RewardPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}