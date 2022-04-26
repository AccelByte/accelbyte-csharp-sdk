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
    /// queryUserIAPOrders
    ///
    /// Query IAP orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:IAP", action=2 (READ)
    ///   *  Returns : paginated iap orders
    /// </summary>
    public class QueryUserIAPOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryUserIAPOrdersBuilder Builder = new QueryUserIAPOrdersBuilder();

        public class QueryUserIAPOrdersBuilder
            : OperationBuilder<QueryUserIAPOrdersBuilder>
        {
            
            
            public string? EndTime { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? ProductId { get; set; }
            
            public string? StartTime { get; set; }
            
            public string? Status { get; set; }
            
            public string? Type { get; set; }
            
            internal QueryUserIAPOrdersBuilder() { }


            public QueryUserIAPOrdersBuilder SetEndTime(string _endTime)
            {
                EndTime = _endTime;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetProductId(string _productId)
            {
                ProductId = _productId;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetStartTime(string _startTime)
            {
                StartTime = _startTime;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public QueryUserIAPOrdersBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }





            public QueryUserIAPOrders Build(
                string namespace_,
                string userId
            )
            {
                QueryUserIAPOrders op = new QueryUserIAPOrders(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryUserIAPOrders(QueryUserIAPOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.EndTime != null) QueryParams["endTime"] = builder.EndTime;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.ProductId != null) QueryParams["productId"] = builder.ProductId;
            if (builder.StartTime != null) QueryParams["startTime"] = builder.StartTime;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryUserIAPOrders(
            string namespace_,            
            string userId,            
            string? endTime,            
            int? limit,            
            int? offset,            
            string? productId,            
            string? startTime,            
            string? status,            
            string? type            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (endTime != null) QueryParams["endTime"] = endTime;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (productId != null) QueryParams["productId"] = productId;
            if (startTime != null) QueryParams["startTime"] = startTime;
            if (status != null) QueryParams["status"] = status;
            if (type != null) QueryParams["type"] = type;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.IAPOrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}