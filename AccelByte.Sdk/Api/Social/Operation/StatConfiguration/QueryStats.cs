// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    /// Query stats stats by keyword.
    /// Other detail info:
    ///           *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=2 (READ)
    ///           *  Returns : stats
    /// </summary>
    public class QueryStats : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryStatsBuilder Builder = new QueryStatsBuilder();

        public class QueryStatsBuilder
        {
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            
            internal QueryStatsBuilder() { }


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
                return new QueryStats(this,
                    namespace_,                    
                    keyword                    
                );
            }
        }

        private QueryStats(QueryStatsBuilder builder,
            string namespace_,
            string keyword
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (keyword != null) QueryParams["keyword"] = keyword;
            
            
            
            
        }
        #endregion

        public QueryStats(
            string namespace_,            
            int? limit,            
            int? offset,            
            string keyword            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (keyword != null) QueryParams["keyword"] = keyword;
            
            
            
            
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/stats/search";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StatPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}