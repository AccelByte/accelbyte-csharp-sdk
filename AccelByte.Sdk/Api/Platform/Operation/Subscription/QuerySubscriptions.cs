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
    /// querySubscriptions
    ///
    /// Query subscriptions.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscriptions
    /// </summary>
    public class QuerySubscriptions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySubscriptionsBuilder Builder = new QuerySubscriptionsBuilder();

        public class QuerySubscriptionsBuilder
        {
            
            public string? ChargeStatus { get; set; }
            
            public string? ItemId { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Sku { get; set; }
            
            public string? Status { get; set; }
            
            public string? SubscribedBy { get; set; }
            
            public string? UserId { get; set; }
            
            internal QuerySubscriptionsBuilder() { }


            public QuerySubscriptionsBuilder SetChargeStatus(string _chargeStatus)
            {
                ChargeStatus = _chargeStatus;
                return this;
            }

            public QuerySubscriptionsBuilder SetItemId(string _itemId)
            {
                ItemId = _itemId;
                return this;
            }

            public QuerySubscriptionsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySubscriptionsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySubscriptionsBuilder SetSku(string _sku)
            {
                Sku = _sku;
                return this;
            }

            public QuerySubscriptionsBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public QuerySubscriptionsBuilder SetSubscribedBy(string _subscribedBy)
            {
                SubscribedBy = _subscribedBy;
                return this;
            }

            public QuerySubscriptionsBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }




            public QuerySubscriptions Build(
                string namespace_
            )
            {
                return new QuerySubscriptions(this,
                    namespace_                    
                );
            }
        }

        private QuerySubscriptions(QuerySubscriptionsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ChargeStatus != null) QueryParams["chargeStatus"] = builder.ChargeStatus;
            if (builder.ItemId != null) QueryParams["itemId"] = builder.ItemId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Sku != null) QueryParams["sku"] = builder.Sku;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.SubscribedBy != null) QueryParams["subscribedBy"] = builder.SubscribedBy;
            if (builder.UserId != null) QueryParams["userId"] = builder.UserId;
            
            
            
            
        }
        #endregion

        public QuerySubscriptions(
            string namespace_,            
            string? chargeStatus,            
            string? itemId,            
            int? limit,            
            int? offset,            
            string? sku,            
            string? status,            
            string? subscribedBy,            
            string? userId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (chargeStatus != null) QueryParams["chargeStatus"] = chargeStatus;
            if (itemId != null) QueryParams["itemId"] = itemId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (sku != null) QueryParams["sku"] = sku;
            if (status != null) QueryParams["status"] = status;
            if (subscribedBy != null) QueryParams["subscribedBy"] = subscribedBy;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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