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
    /// publicSubscribeSubscription
    ///
    /// Subscribe a subscription. Support both real and virtual payment. Need go through payment flow using the paymentOrderNo if paymentFlowRequired true.
    ///  ACTIVE USER subscription can't do subscribe again.
    ///  The next billing date will be X(default 4) hours before the current period ends if correctly subscribed.
    /// User with permission SANDBOX will create sandbox subscription that not real paid.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=1 (CREATE)
    ///   *  Optional permission(user with this permission will create sandbox subscription) : resource="SANDBOX", action=1 (CREATE)
    ///   * It will be forbidden while the user is banned: ORDER_INITIATE or ORDER_AND_PAYMENT
    ///   *  Returns : created subscription
    /// </summary>
    public class PublicSubscribeSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSubscribeSubscriptionBuilder Builder = new PublicSubscribeSubscriptionBuilder();

        public class PublicSubscribeSubscriptionBuilder
        {
            
            
            public Model.SubscribeRequest? Body { get; set; }
            
            internal PublicSubscribeSubscriptionBuilder() { }



            public PublicSubscribeSubscriptionBuilder SetBody(Model.SubscribeRequest _body)
            {
                Body = _body;
                return this;
            }



            public PublicSubscribeSubscription Build(
                string namespace_,
                string userId
            )
            {
                return new PublicSubscribeSubscription(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicSubscribeSubscription(PublicSubscribeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicSubscribeSubscription(
            string namespace_,            
            string userId,            
            Model.SubscribeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}