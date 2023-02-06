// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// queryUserExpGrantHistory
    ///
    /// This API is used to get user exp acquisition history, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * default will query from current active season
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=2 (READ)
    ///   *  Returns : paginated grant history
    /// </summary>
    public class QueryUserExpGrantHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserExpGrantHistoryBuilder Builder { get => new QueryUserExpGrantHistoryBuilder(); }

        public class QueryUserExpGrantHistoryBuilder
            : OperationBuilder<QueryUserExpGrantHistoryBuilder>
        {

            public string? From { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public string? SeasonId { get; set; }

            public QueryUserExpGrantHistorySource? Source { get; set; }

            public List<string>? Tags { get; set; }

            public string? To { get; set; }





            internal QueryUserExpGrantHistoryBuilder() { }


            public QueryUserExpGrantHistoryBuilder SetFrom(string _from)
            {
                From = _from;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetSeasonId(string _seasonId)
            {
                SeasonId = _seasonId;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetSource(QueryUserExpGrantHistorySource _source)
            {
                Source = _source;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }

            public QueryUserExpGrantHistoryBuilder SetTo(string _to)
            {
                To = _to;
                return this;
            }





            public QueryUserExpGrantHistory Build(
                string namespace_,
                string userId
            )
            {
                QueryUserExpGrantHistory op = new QueryUserExpGrantHistory(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryUserExpGrantHistory(QueryUserExpGrantHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.From is not null) QueryParams["from"] = builder.From;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SeasonId is not null) QueryParams["seasonId"] = builder.SeasonId;
            if (builder.Source is not null) QueryParams["source"] = builder.Source.Value;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;
            if (builder.To is not null) QueryParams["to"] = builder.To;
            

            
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserExpGrantHistory(
            string namespace_,            
            string userId,            
            string? from,            
            int? limit,            
            int? offset,            
            string? seasonId,            
            QueryUserExpGrantHistorySource? source,            
            List<string>? tags,            
            string? to            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (from is not null) QueryParams["from"] = from;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (seasonId is not null) QueryParams["seasonId"] = seasonId;
            if (source is not null) QueryParams["source"] = source.Value;
            if (tags is not null) QueryParams["tags"] = tags;
            if (to is not null) QueryParams["to"] = to;
            

            
            CollectionFormatMap["tags"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ExpGrantHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ExpGrantHistoryPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ExpGrantHistoryPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class QueryUserExpGrantHistorySource : StringEnum<QueryUserExpGrantHistorySource>
    {
        public static readonly QueryUserExpGrantHistorySource PAIDFOR
            = new QueryUserExpGrantHistorySource("PAID_FOR");

        public static readonly QueryUserExpGrantHistorySource SWEAT
            = new QueryUserExpGrantHistorySource("SWEAT");


        public static implicit operator QueryUserExpGrantHistorySource(string value)
        {
            return NewValue(value);
        }

        public QueryUserExpGrantHistorySource(string enumValue)
            : base(enumValue)
        {

        }
    }

}