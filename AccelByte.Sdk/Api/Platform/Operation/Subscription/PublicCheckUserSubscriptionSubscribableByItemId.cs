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
    /// publicCheckUserSubscriptionSubscribableByItemId
    ///
    /// Check user subscription subscribable by itemId, ACTIVE USER subscription can't do subscribe again.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : subscribable info
    /// </summary>
    public class PublicCheckUserSubscriptionSubscribableByItemId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCheckUserSubscriptionSubscribableByItemIdBuilder Builder = new PublicCheckUserSubscriptionSubscribableByItemIdBuilder();

        public class PublicCheckUserSubscriptionSubscribableByItemIdBuilder
            : OperationBuilder<PublicCheckUserSubscriptionSubscribableByItemIdBuilder>
        {
            
            
            
            internal PublicCheckUserSubscriptionSubscribableByItemIdBuilder() { }






            public PublicCheckUserSubscriptionSubscribableByItemId Build(
                string namespace_,
                string userId,
                string itemId
            )
            {
                PublicCheckUserSubscriptionSubscribableByItemId op = new PublicCheckUserSubscriptionSubscribableByItemId(this,
                    namespace_,                    
                    userId,                    
                    itemId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCheckUserSubscriptionSubscribableByItemId(PublicCheckUserSubscriptionSubscribableByItemIdBuilder builder,
            string namespace_,
            string userId,
            string itemId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId != null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCheckUserSubscriptionSubscribableByItemId(
            string namespace_,            
            string userId,            
            string itemId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (itemId != null) QueryParams["itemId"] = itemId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.Subscribable? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.Subscribable>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Subscribable>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}