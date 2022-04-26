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
    /// grantDaysToSubscription
    ///
    /// Grant days to a subscription, if grantDays is positive, it will add free days and push the next billing date by the amount of day.
    /// if the grantDays is negative or zero, it only apply to active/cancelled subscription, remove days will decrease current period end, and move the next billing date closer.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=4 (UPDATE)
    ///   *  Returns : updated subscription
    /// </summary>
    public class GrantDaysToSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantDaysToSubscriptionBuilder Builder = new GrantDaysToSubscriptionBuilder();

        public class GrantDaysToSubscriptionBuilder
            : OperationBuilder<GrantDaysToSubscriptionBuilder>
        {
            
            
            
            public Model.GrantSubscriptionDaysRequest? Body { get; set; }
            
            internal GrantDaysToSubscriptionBuilder() { }



            public GrantDaysToSubscriptionBuilder SetBody(Model.GrantSubscriptionDaysRequest _body)
            {
                Body = _body;
                return this;
            }




            public GrantDaysToSubscription Build(
                string namespace_,
                string subscriptionId,
                string userId
            )
            {
                GrantDaysToSubscription op = new GrantDaysToSubscription(this,
                    namespace_,                    
                    subscriptionId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GrantDaysToSubscription(GrantDaysToSubscriptionBuilder builder,
            string namespace_,
            string subscriptionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GrantDaysToSubscription(
            string namespace_,            
            string subscriptionId,            
            string userId,            
            Model.GrantSubscriptionDaysRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant";

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