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
    /// SubscribeAppNotificationV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [CREATE]`
    /// 
    /// Subscribe the user(s) an app notification.
    /// 
    /// Request body:
    /// - notificationType : type of the app notification to be subscribed - Required.
    /// - values:
    /// -"all"
    /// - "app-down"
    /// - "critical-vulnerability"
    /// - subscribers : user(s) to subscribe the app notification - Required.
    /// </summary>
    public class SubscribeAppNotificationV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SubscribeAppNotificationV2Builder Builder { get => new SubscribeAppNotificationV2Builder(); }

        public class SubscribeAppNotificationV2Builder
            : OperationBuilder<SubscribeAppNotificationV2Builder>
        {





            internal SubscribeAppNotificationV2Builder() { }






            public SubscribeAppNotificationV2 Build(
                ApimodelSubscribeNotificationRequest body,
                string app,
                string namespace_
            )
            {
                SubscribeAppNotificationV2 op = new SubscribeAppNotificationV2(this,
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

        private SubscribeAppNotificationV2(SubscribeAppNotificationV2Builder builder,
            ApimodelSubscribeNotificationRequest body,
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

        public SubscribeAppNotificationV2(
            string app,
            string namespace_,
            Model.ApimodelSubscribeNotificationRequest body
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelSubscribeNotificationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelSubscribeNotificationResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelSubscribeNotificationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelSubscribeNotificationResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}