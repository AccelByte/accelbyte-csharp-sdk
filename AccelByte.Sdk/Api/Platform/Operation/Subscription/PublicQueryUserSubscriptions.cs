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
    /// publicQueryUserSubscriptions
    ///
    /// Query user subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscription
    /// </summary>
    public class PublicQueryUserSubscriptions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicQueryUserSubscriptionsBuilder Builder = new PublicQueryUserSubscriptionsBuilder();

        public class PublicQueryUserSubscriptionsBuilder
            : OperationBuilder<PublicQueryUserSubscriptionsBuilder>
        {
            
            
            public string? ChargeStatus { get; set; }
            
            public string? ItemId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Sku { get; set; }
            
            public string? Status { get; set; }
            
            public string? SubscribedBy { get; set; }
            
            internal PublicQueryUserSubscriptionsBuilder() { }


            public PublicQueryUserSubscriptionsBuilder SetChargeStatus(string _chargeStatus)
            {
                ChargeStatus = _chargeStatus;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetSku(string _sku)
            {
                Sku = _sku;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public PublicQueryUserSubscriptionsBuilder SetSubscribedBy(string _subscribedBy)
            {
                SubscribedBy = _subscribedBy;
                return this;
            }





            public PublicQueryUserSubscriptions Build(
                string namespace_,
                string userId
            )
            {
                PublicQueryUserSubscriptions op = new PublicQueryUserSubscriptions(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicQueryUserSubscriptions(PublicQueryUserSubscriptionsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ChargeStatus != null) QueryParams["chargeStatus"] = builder.ChargeStatus;
            if (builder.ItemId != null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Sku != null) QueryParams["sku"] = builder.Sku;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.SubscribedBy != null) QueryParams["subscribedBy"] = builder.SubscribedBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicQueryUserSubscriptions(
            string namespace_,            
            string userId,            
            string? chargeStatus,            
            string? itemId,            
            int? limit,            
            int? offset,            
            string? sku,            
            string? status,            
            string? subscribedBy            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (chargeStatus != null) QueryParams["chargeStatus"] = chargeStatus;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sku != null) QueryParams["sku"] = sku;
            if (status != null) QueryParams["status"] = status;
            if (subscribedBy != null) QueryParams["subscribedBy"] = subscribedBy;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.SubscriptionPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}