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
    /// queryRewards
    ///
    /// This API is used to query rewards by criteria.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : the list of rewards
    /// </summary>
    public class QueryRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRewardsBuilder Builder = new QueryRewardsBuilder();

        public class QueryRewardsBuilder
            : OperationBuilder<QueryRewardsBuilder>
        {
            
            public string? EventTopic { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? SortBy { get; set; }
            
            internal QueryRewardsBuilder() { }


            public QueryRewardsBuilder SetEventTopic(string _eventTopic)
            {
                EventTopic = _eventTopic;
                return this;
            }

            public QueryRewardsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryRewardsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryRewardsBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }





            public QueryRewards Build(
                string namespace_
            )
            {
                QueryRewards op = new QueryRewards(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryRewards(QueryRewardsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EventTopic != null) QueryParams["eventTopic"] = builder.EventTopic;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryRewards(
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
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/byCriteria";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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