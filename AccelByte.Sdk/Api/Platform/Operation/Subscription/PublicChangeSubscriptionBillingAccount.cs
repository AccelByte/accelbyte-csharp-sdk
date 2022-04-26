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
    /// publicChangeSubscriptionBillingAccount
    ///
    /// Request to change a subscription billing account, this will guide user to payment station. The actual change will happen at the 0 payment notification successfully handled.
    /// Only ACTIVE USER subscription with real currency billing account can be changed.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=4 (UPDATE)
    ///   *  Returns : updated subscription
    /// </summary>
    public class PublicChangeSubscriptionBillingAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicChangeSubscriptionBillingAccountBuilder Builder = new PublicChangeSubscriptionBillingAccountBuilder();

        public class PublicChangeSubscriptionBillingAccountBuilder
            : OperationBuilder<PublicChangeSubscriptionBillingAccountBuilder>
        {
            
            
            
            internal PublicChangeSubscriptionBillingAccountBuilder() { }






            public PublicChangeSubscriptionBillingAccount Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                PublicChangeSubscriptionBillingAccount op = new PublicChangeSubscriptionBillingAccount(this,
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicChangeSubscriptionBillingAccount(PublicChangeSubscriptionBillingAccountBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicChangeSubscriptionBillingAccount(
            string namespace_,            
            string subscriptionId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount";

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