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
    /// publicCheckPaymentOrderPaidStatus
    ///
    /// Check payment order paid status.
    /// Other detail info:
    /// 
    ///   * Returns : Payment order paid result
    /// </summary>
    public class PublicCheckPaymentOrderPaidStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCheckPaymentOrderPaidStatusBuilder Builder = new PublicCheckPaymentOrderPaidStatusBuilder();

        public class PublicCheckPaymentOrderPaidStatusBuilder
        {
            
            
            internal PublicCheckPaymentOrderPaidStatusBuilder() { }





            public PublicCheckPaymentOrderPaidStatus Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                return new PublicCheckPaymentOrderPaidStatus(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
            }
        }

        private PublicCheckPaymentOrderPaidStatus(PublicCheckPaymentOrderPaidStatusBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            
            
            
            
        }
        #endregion

        public PublicCheckPaymentOrderPaidStatus(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderPaidResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPaidResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderPaidResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}