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
    /// publicQueryUserOrders
    ///
    /// Query user orders.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : get order
    /// </summary>
    public class PublicQueryUserOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserOrdersBuilder Builder = new PublicQueryUserOrdersBuilder();

        public class PublicQueryUserOrdersBuilder
            : OperationBuilder<PublicQueryUserOrdersBuilder>
        {

            public string? ItemId { get; set; }

            public int? Limit { get; set; }

            public int? Offset { get; set; }

            public PublicQueryUserOrdersStatus? Status { get; set; }





            internal PublicQueryUserOrdersBuilder() { }


            public PublicQueryUserOrdersBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserOrdersBuilder SetStatus(PublicQueryUserOrdersStatus _status)
            {
                Status = _status;
                return this;
            }





            public PublicQueryUserOrders Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserOrders op = new PublicQueryUserOrders(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryUserOrders(PublicQueryUserOrdersBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ItemId is not null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status is not null) QueryParams["status"] = builder.Status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserOrders(
            string namespace_,            
            string userId,            
            string? itemId,            
            int? limit,            
            int? offset,            
            PublicQueryUserOrdersStatus? status            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId is not null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status is not null) QueryParams["status"] = status.Value;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OrderPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class PublicQueryUserOrdersStatus : StringEnum<PublicQueryUserOrdersStatus>
    {
        public static readonly PublicQueryUserOrdersStatus Chargeback
            = new PublicQueryUserOrdersStatus("CHARGEBACK");

        public static readonly PublicQueryUserOrdersStatus ChargebackReversed
            = new PublicQueryUserOrdersStatus("CHARGEBACK_REVERSED");

        public static readonly PublicQueryUserOrdersStatus Charged
            = new PublicQueryUserOrdersStatus("CHARGED");

        public static readonly PublicQueryUserOrdersStatus Closed
            = new PublicQueryUserOrdersStatus("CLOSED");

        public static readonly PublicQueryUserOrdersStatus Deleted
            = new PublicQueryUserOrdersStatus("DELETED");

        public static readonly PublicQueryUserOrdersStatus Fulfilled
            = new PublicQueryUserOrdersStatus("FULFILLED");

        public static readonly PublicQueryUserOrdersStatus FulfillFailed
            = new PublicQueryUserOrdersStatus("FULFILL_FAILED");

        public static readonly PublicQueryUserOrdersStatus Init
            = new PublicQueryUserOrdersStatus("INIT");

        public static readonly PublicQueryUserOrdersStatus Refunded
            = new PublicQueryUserOrdersStatus("REFUNDED");

        public static readonly PublicQueryUserOrdersStatus Refunding
            = new PublicQueryUserOrdersStatus("REFUNDING");

        public static readonly PublicQueryUserOrdersStatus RefundFailed
            = new PublicQueryUserOrdersStatus("REFUND_FAILED");


        public static implicit operator PublicQueryUserOrdersStatus(string value)
        {
            return NewValue(value);
        }

        public PublicQueryUserOrdersStatus(string enumValue)
            : base(enumValue)
        {

        }
    }

}