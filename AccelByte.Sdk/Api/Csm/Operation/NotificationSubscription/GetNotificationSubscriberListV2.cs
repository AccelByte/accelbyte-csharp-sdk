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
    /// GetNotificationSubscriberListV2
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:EXTEND:APP:ALERT:SUBSCRIPTION [READ]`
    /// 
    /// Request param:
    /// - notificationType : type of the subscribed app notification
    /// - values:
    /// - all
    /// - app-down
    /// - critical-vulnerability
    /// 
    /// Get a list of the app notification subscriber
    /// </summary>
    public class GetNotificationSubscriberListV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetNotificationSubscriberListV2Builder Builder { get => new GetNotificationSubscriberListV2Builder(); }

        public class GetNotificationSubscriberListV2Builder
            : OperationBuilder<GetNotificationSubscriberListV2Builder>
        {





            internal GetNotificationSubscriberListV2Builder() { }






            public GetNotificationSubscriberListV2 Build(
                string app,
                string namespace_,
                string notificationType
            )
            {
                GetNotificationSubscriberListV2 op = new GetNotificationSubscriberListV2(this,
                    app,
                    namespace_,
                    notificationType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetNotificationSubscriberListV2(GetNotificationSubscriberListV2Builder builder,
            string app,
            string namespace_,
            string notificationType
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (notificationType is not null) QueryParams["notificationType"] = notificationType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetNotificationSubscriberListV2(
            string app,
            string namespace_,
            string notificationType
        )
        {
            PathParams["app"] = app;
            PathParams["namespace"] = namespace_;

            if (notificationType is not null) QueryParams["notificationType"] = notificationType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions";

        public override HttpMethod Method => HttpMethod.Get;

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