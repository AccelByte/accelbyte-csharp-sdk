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
    /// publicGetUnpaidPaymentOrder
    ///
    /// Get payment order info.
    /// Other detail info:
    /// 
    ///   * Returns : Payment order details
    /// </summary>
    public class PublicGetUnpaidPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUnpaidPaymentOrderBuilder Builder = new PublicGetUnpaidPaymentOrderBuilder();

        public class PublicGetUnpaidPaymentOrderBuilder
            : OperationBuilder<PublicGetUnpaidPaymentOrderBuilder>
        {
            
            
            internal PublicGetUnpaidPaymentOrderBuilder() { }






            public PublicGetUnpaidPaymentOrder Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicGetUnpaidPaymentOrder op = new PublicGetUnpaidPaymentOrder(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUnpaidPaymentOrder(PublicGetUnpaidPaymentOrderBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

        }
        #endregion

        public PublicGetUnpaidPaymentOrder(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/info";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentOrderDetails? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderDetails>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderDetails>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}