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
    /// publicGetUserSubscriptionBillingHistories
    ///
    /// Get user subscription billing histories.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscription history
    /// </summary>
    public class PublicGetUserSubscriptionBillingHistories : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserSubscriptionBillingHistoriesBuilder Builder = new PublicGetUserSubscriptionBillingHistoriesBuilder();

        public class PublicGetUserSubscriptionBillingHistoriesBuilder
        {
            
            
            
            public bool? ExcludeFree { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            internal PublicGetUserSubscriptionBillingHistoriesBuilder() { }


            public PublicGetUserSubscriptionBillingHistoriesBuilder SetExcludeFree(bool _excludeFree)
            {
                ExcludeFree = _excludeFree;
                return this;
            }

            public PublicGetUserSubscriptionBillingHistoriesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetUserSubscriptionBillingHistoriesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public PublicGetUserSubscriptionBillingHistories Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                return new PublicGetUserSubscriptionBillingHistories(this,
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );
            }
        }

        private PublicGetUserSubscriptionBillingHistories(PublicGetUserSubscriptionBillingHistoriesBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            if (builder.ExcludeFree != null) QueryParams["excludeFree"] = Convert.ToString(builder.ExcludeFree)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public PublicGetUserSubscriptionBillingHistories(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            bool? excludeFree,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            if (excludeFree != null) QueryParams["excludeFree"] = Convert.ToString(excludeFree)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.BillingHistoryPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BillingHistoryPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BillingHistoryPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}