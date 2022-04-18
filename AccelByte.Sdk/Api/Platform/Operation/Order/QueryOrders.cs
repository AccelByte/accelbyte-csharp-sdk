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
    /// queryOrders
    ///
    /// Query orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ORDER", action=2 (READ)
    ///   *  Returns : query orders
    /// </summary>
    public class QueryOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryOrdersBuilder Builder = new QueryOrdersBuilder();

        public class QueryOrdersBuilder
            : OperationBuilder<QueryOrdersBuilder>
        {
            
            public string? EndTime { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public List<string>? OrderNos { get; set; }
            
            public string? SortBy { get; set; }
            
            public string? StartTime { get; set; }
            
            public string? Status { get; set; }
            
            public bool? WithTotal { get; set; }
            
            internal QueryOrdersBuilder() { }


            public QueryOrdersBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public QueryOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryOrdersBuilder SetOrderNos(List<string> _orderNos)
            {
                OrderNos = _orderNos;
                return this;
            }

            public QueryOrdersBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public QueryOrdersBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public QueryOrdersBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public QueryOrdersBuilder SetWithTotal(bool _withTotal)
            {
                WithTotal = _withTotal;
                return this;
            }




            public QueryOrders Build(
                string namespace_
            )
            {
                QueryOrders op = new QueryOrders(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryOrders(QueryOrdersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.EndTime != null) QueryParams["endTime"] = builder.EndTime;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.OrderNos != null) QueryParams["orderNos"] = builder.OrderNos;
            if (builder.SortBy != null) QueryParams["sortBy"] = builder.SortBy;
            if (builder.StartTime != null) QueryParams["startTime"] = builder.StartTime;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.WithTotal != null) QueryParams["withTotal"] = Convert.ToString(builder.WithTotal)!;
            
            
            CollectionFormatMap["orderNos"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryOrders(
            string namespace_,            
            string? endTime,            
            int? limit,            
            int? offset,            
            List<string>? orderNos,            
            string? sortBy,            
            string? startTime,            
            string? status,            
            bool? withTotal            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (endTime != null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (orderNos != null) QueryParams["orderNos"] = orderNos;
            if (sortBy != null) QueryParams["sortBy"] = sortBy;
            if (startTime != null) QueryParams["startTime"] = startTime;
            if (status != null) QueryParams["status"] = status;
            if (withTotal != null) QueryParams["withTotal"] = Convert.ToString(withTotal)!;
            
            
            CollectionFormatMap["orderNos"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OrderPagingResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}