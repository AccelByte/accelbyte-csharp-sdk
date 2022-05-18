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

            public QueryPaymentOrdersChannel? Channel { get; set; }

            public string? ExtTxId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public QueryPaymentOrdersStatus? Status { get; set; }





            internal QueryPaymentOrdersBuilder() { }


            public QueryPaymentOrdersBuilder SetChannel(QueryPaymentOrdersChannel _channel)
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

            public QueryPaymentOrdersBuilder SetStatus(QueryPaymentOrdersStatus _status)
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
            
            if (builder.Channel is not null) QueryParams["channel"] = builder.Channel.Value;
            if (builder.ExtTxId is not null) QueryParams["extTxId"] = builder.ExtTxId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryPaymentOrders(
            string namespace_,            
            QueryPaymentOrdersChannel? channel,            
            string? extTxId,            
            int? limit,            
            int? offset,            
            QueryPaymentOrdersStatus? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (channel is not null) QueryParams["channel"] = channel.Value;
            if (extTxId is not null) QueryParams["extTxId"] = extTxId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            

            
            
            

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

    public class QueryPaymentOrdersChannel : StringEnum<QueryPaymentOrdersChannel>
    {
        public static readonly QueryPaymentOrdersChannel External
            = new QueryPaymentOrdersChannel("EXTERNAL");

        public static readonly QueryPaymentOrdersChannel Internal
            = new QueryPaymentOrdersChannel("INTERNAL");


        public static implicit operator QueryPaymentOrdersChannel(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentOrdersChannel(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class QueryPaymentOrdersStatus : StringEnum<QueryPaymentOrdersStatus>
    {
        public static readonly QueryPaymentOrdersStatus Authorised
            = new QueryPaymentOrdersStatus("AUTHORISED");

        public static readonly QueryPaymentOrdersStatus AuthoriseFailed
            = new QueryPaymentOrdersStatus("AUTHORISE_FAILED");

        public static readonly QueryPaymentOrdersStatus Chargeback
            = new QueryPaymentOrdersStatus("CHARGEBACK");

        public static readonly QueryPaymentOrdersStatus ChargebackReversed
            = new QueryPaymentOrdersStatus("CHARGEBACK_REVERSED");

        public static readonly QueryPaymentOrdersStatus Charged
            = new QueryPaymentOrdersStatus("CHARGED");

        public static readonly QueryPaymentOrdersStatus ChargeFailed
            = new QueryPaymentOrdersStatus("CHARGE_FAILED");

        public static readonly QueryPaymentOrdersStatus Deleted
            = new QueryPaymentOrdersStatus("DELETED");

        public static readonly QueryPaymentOrdersStatus Init
            = new QueryPaymentOrdersStatus("INIT");

        public static readonly QueryPaymentOrdersStatus NotificationOfChargeback
            = new QueryPaymentOrdersStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly QueryPaymentOrdersStatus Refunded
            = new QueryPaymentOrdersStatus("REFUNDED");

        public static readonly QueryPaymentOrdersStatus Refunding
            = new QueryPaymentOrdersStatus("REFUNDING");

        public static readonly QueryPaymentOrdersStatus RefundFailed
            = new QueryPaymentOrdersStatus("REFUND_FAILED");

        public static readonly QueryPaymentOrdersStatus RequestForInformation
            = new QueryPaymentOrdersStatus("REQUEST_FOR_INFORMATION");


        public static implicit operator QueryPaymentOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public QueryPaymentOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}