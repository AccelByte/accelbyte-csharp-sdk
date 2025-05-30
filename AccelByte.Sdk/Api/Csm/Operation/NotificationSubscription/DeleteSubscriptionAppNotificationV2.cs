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
    /// DeleteSubscriptionAppNotificationV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [DELETE]`
    /// 
    /// Remove a user from the notification subscription.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class DeleteSubscriptionAppNotificationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSubscriptionAppNotificationV2Builder Builder { get => new DeleteSubscriptionAppNotificationV2Builder(); }

        public class DeleteSubscriptionAppNotificationV2Builder
            : OperationBuilder<DeleteSubscriptionAppNotificationV2Builder>
        {





            internal DeleteSubscriptionAppNotificationV2Builder() { }






            public DeleteSubscriptionAppNotificationV2 Build(
                string app,
                string namespace_,
                string subscriptionId
            )
            {
                DeleteSubscriptionAppNotificationV2 op = new DeleteSubscriptionAppNotificationV2(this,
                    app,
                    namespace_,
                    subscriptionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteSubscriptionAppNotificationV2(DeleteSubscriptionAppNotificationV2Builder builder,
            string app,
            string namespace_,
            string subscriptionId
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSubscriptionAppNotificationV2(
            string app,
            string namespace_,
            string subscriptionId
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;
            PathParams["subscriptionId"] = subscriptionId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/{subscriptionId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}