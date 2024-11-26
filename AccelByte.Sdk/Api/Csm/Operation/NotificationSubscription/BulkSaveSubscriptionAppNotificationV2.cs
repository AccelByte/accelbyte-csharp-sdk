// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Csm.Operation
{
    /// <summary>
    /// BulkSaveSubscriptionAppNotificationV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [UPDATE]`
    /// 
    /// Update the subscription the user(s) is an app notification.
    /// 
    /// Request body:
    /// - notificationType : type of the app notification to be subscribed - Required.
    /// - values:
    /// - "all"
    /// - "app-down"
    /// - "critical-vulnerability"
    /// - subscribers : user(s) notification subscription to be updated - Required.
    /// </summary>
    public class BulkSaveSubscriptionAppNotificationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkSaveSubscriptionAppNotificationV2Builder Builder { get => new BulkSaveSubscriptionAppNotificationV2Builder(); }

        public class BulkSaveSubscriptionAppNotificationV2Builder
            : OperationBuilder<BulkSaveSubscriptionAppNotificationV2Builder>
        {





            internal BulkSaveSubscriptionAppNotificationV2Builder() { }






            public BulkSaveSubscriptionAppNotificationV2 Build(
                ApimodelBulkSubscribeRequest body,
                string app,
                string namespace_
            )
            {
                BulkSaveSubscriptionAppNotificationV2 op = new BulkSaveSubscriptionAppNotificationV2(this,
                    body,                    
                    app,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private BulkSaveSubscriptionAppNotificationV2(BulkSaveSubscriptionAppNotificationV2Builder builder,
            ApimodelBulkSubscribeRequest body,
            string app,
            string namespace_
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkSaveSubscriptionAppNotificationV2(
            string app,            
            string namespace_,            
            Model.ApimodelBulkSubscribeRequest body            
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApimodelGetNotificationSubscriberListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelGetNotificationSubscriberListResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelGetNotificationSubscriberListResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelGetNotificationSubscriberListResponse>(payload, ResponseJsonOptions);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}