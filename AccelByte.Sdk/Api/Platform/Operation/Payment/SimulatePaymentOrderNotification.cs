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
    /// simulatePaymentOrderNotification
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Simulate payment notification on sandbox payment order, usually for test usage to simulate real currency payment notification.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=4 (UPDATE)
    ///   *  Returns : notification process result
    /// </summary>
    public class SimulatePaymentOrderNotification : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SimulatePaymentOrderNotificationBuilder Builder = new SimulatePaymentOrderNotificationBuilder();

        public class SimulatePaymentOrderNotificationBuilder
            : OperationBuilder<SimulatePaymentOrderNotificationBuilder>
        {
            
            
            public Model.PaymentOrderNotifySimulation? Body { get; set; }
            
            internal SimulatePaymentOrderNotificationBuilder() { }



            public SimulatePaymentOrderNotificationBuilder SetBody(Model.PaymentOrderNotifySimulation _body)
            {
                Body = _body;
                return this;
            }




            public SimulatePaymentOrderNotification Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                SimulatePaymentOrderNotification op = new SimulatePaymentOrderNotification(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SimulatePaymentOrderNotification(SimulatePaymentOrderNotificationBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            BodyParams = builder.Body;
            

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

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.NotificationProcessResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NotificationProcessResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}