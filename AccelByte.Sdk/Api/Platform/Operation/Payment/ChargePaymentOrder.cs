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
    /// chargePaymentOrder
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Charge payment order without payment flow for unpaid payment order, usually for test usage to simulate real currency payment process.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=4 (UPDATE)
    ///   *  Returns : payment order instance
    /// </summary>
    public class ChargePaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ChargePaymentOrderBuilder Builder = new ChargePaymentOrderBuilder();

        public class ChargePaymentOrderBuilder
        {
            
            
            public Model.PaymentOrderChargeRequest? Body { get; set; }
            
            internal ChargePaymentOrderBuilder() { }



            public ChargePaymentOrderBuilder SetBody(Model.PaymentOrderChargeRequest _body)
            {
                Body = _body;
                return this;
            }



            public ChargePaymentOrder Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                return new ChargePaymentOrder(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
            }
        }

        private ChargePaymentOrder(ChargePaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public ChargePaymentOrder(
            string namespace_,            
            string paymentOrderNo,            
            Model.PaymentOrderChargeRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}