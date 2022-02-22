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
    /// platformSubscribeSubscription
    ///
    /// Free subscribe by platform, can used by other justice service to redeem/reward the subscription.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=1 (CREATE)
    ///   *  Returns : result subscription
    /// </summary>
    public class PlatformSubscribeSubscription : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformSubscribeSubscriptionBuilder Builder = new PlatformSubscribeSubscriptionBuilder();

        public class PlatformSubscribeSubscriptionBuilder
        {
            
            
            public Model.PlatformSubscribeRequest? Body { get; set; }
            
            internal PlatformSubscribeSubscriptionBuilder() { }



            public PlatformSubscribeSubscriptionBuilder SetBody(Model.PlatformSubscribeRequest _body)
            {
                Body = _body;
                return this;
            }



            public PlatformSubscribeSubscription Build(
                string namespace_,
                string userId
            )
            {
                return new PlatformSubscribeSubscription(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PlatformSubscribeSubscription(PlatformSubscribeSubscriptionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PlatformSubscribeSubscription(
            string namespace_,            
            string userId,            
            Model.PlatformSubscribeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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