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
    /// queryPaymentOrders
    ///
    /// Query payment orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=2 (READ)
    ///   *  Returns : query payment orders
    /// </summary>
    public class QueryPaymentOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryPaymentOrdersBuilder Builder = new QueryPaymentOrdersBuilder();

        public class QueryPaymentOrdersBuilder
            : OperationBuilder<QueryPaymentOrdersBuilder>
        {
            
            public string? Channel { get; set; }
            
            public string? ExtTxId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Status { get; set; }
            
            internal QueryPaymentOrdersBuilder() { }


            public QueryPaymentOrdersBuilder SetChannel(string _channel)
            {
                Channel = _channel;
                return this;
            }

            public QueryPaymentOrdersBuilder SetExtTxId(string _extTxId)
            {
                ExtTxId = _extTxId;
                return this;
            }

            public QueryPaymentOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryPaymentOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryPaymentOrdersBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }




            public QueryPaymentOrders Build(
                string namespace_
            )
            {
                QueryPaymentOrders op = new QueryPaymentOrders(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QueryPaymentOrders(QueryPaymentOrdersBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Channel != null) QueryParams["channel"] = builder.Channel;
            if (builder.ExtTxId != null) QueryParams["extTxId"] = builder.ExtTxId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryPaymentOrders(
            string namespace_,            
            string? channel,            
            string? extTxId,            
            int? limit,            
            int? offset,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (channel != null) QueryParams["channel"] = channel;
            if (extTxId != null) QueryParams["extTxId"] = extTxId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status != null) QueryParams["status"] = status;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentOrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}