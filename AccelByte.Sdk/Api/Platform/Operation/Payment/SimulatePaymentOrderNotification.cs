// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// simulatePaymentOrderNotification
    ///
    ///  [Not supported yet in AGS Shared Cloud] [TEST FACILITY ONLY] Forbidden in live environment. Simulate payment notification on sandbox payment order, usually for test usage to simulate real currency payment notification.
    /// Other detail info:
    /// 
    ///   * Returns : notification process result
    /// </summary>
    public class SimulatePaymentOrderNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SimulatePaymentOrderNotificationBuilder Builder { get => new SimulatePaymentOrderNotificationBuilder(); }

        public class SimulatePaymentOrderNotificationBuilder
            : OperationBuilder<SimulatePaymentOrderNotificationBuilder>
        {





            internal SimulatePaymentOrderNotificationBuilder() { }






            public SimulatePaymentOrderNotification Build(
                PaymentOrderNotifySimulation body,
                string namespace_,
                string paymentOrderNo
            )
            {
                SimulatePaymentOrderNotification op = new SimulatePaymentOrderNotification(this,
                    body,
                    namespace_,
                    paymentOrderNo
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private SimulatePaymentOrderNotification(SimulatePaymentOrderNotificationBuilder builder,
            PaymentOrderNotifySimulation body,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SimulatePaymentOrderNotification(
            string namespace_,
            string paymentOrderNo,
            Model.PaymentOrderNotifySimulation body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/simulate-notification";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.NotificationProcessResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.NotificationProcessResult<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}