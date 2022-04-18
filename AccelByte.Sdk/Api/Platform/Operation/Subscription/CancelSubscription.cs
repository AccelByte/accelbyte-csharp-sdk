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
    /// cancelSubscription
    ///
    /// Cancel a subscription, only ACTIVE subscription can be cancelled. Ensure successfully cancel, recommend at least 1 day before current period ends, otherwise it may be charging or charged.
    /// Set immediate true, the subscription will be terminated immediately, otherwise till the end of current billing cycle.
    /// Set force true, will ignore the error if subscription is during recurring charging.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=4 (UPDATE)
    ///   *  Returns : cancelled subscription
    /// </summary>
    public class CancelSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CancelSubscriptionBuilder Builder = new CancelSubscriptionBuilder();

        public class CancelSubscriptionBuilder
            : OperationBuilder<CancelSubscriptionBuilder>
        {
            
            
            
            public bool? Force { get; set; }
            
            public Model.CancelRequest? Body { get; set; }
            
            internal CancelSubscriptionBuilder() { }


            public CancelSubscriptionBuilder SetForce(bool _force)
            {
                Force = _force;
                return this;
            }


            public CancelSubscriptionBuilder SetBody(Model.CancelRequest _body)
            {
                Body = _body;
                return this;
            }



            public CancelSubscription Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                CancelSubscription op = new CancelSubscription(this,
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private CancelSubscription(CancelSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            if (builder.Force != null) QueryParams["force"] = Convert.ToString(builder.Force)!;
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CancelSubscription(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            bool? force,            
            Model.CancelRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            if (force != null) QueryParams["force"] = Convert.ToString(force)!;
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.SubscriptionInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}