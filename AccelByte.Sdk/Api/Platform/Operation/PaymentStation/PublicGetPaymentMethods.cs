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
    /// publicGetPaymentMethods
    ///
    /// Get payment methods.
    /// Other detail info:
    /// 
    ///   * Returns : Payment method list
    /// </summary>
    public class PublicGetPaymentMethods : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetPaymentMethodsBuilder Builder = new PublicGetPaymentMethodsBuilder();

        public class PublicGetPaymentMethodsBuilder
            : OperationBuilder<PublicGetPaymentMethodsBuilder>
        {
            
            
            internal PublicGetPaymentMethodsBuilder() { }






            public PublicGetPaymentMethods Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                PublicGetPaymentMethods op = new PublicGetPaymentMethods(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetPaymentMethods(PublicGetPaymentMethodsBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            

            
            
            

        }
        #endregion

        public PublicGetPaymentMethods(
            string namespace_,            
            string paymentOrderNo            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/methods";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.PaymentMethod>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentMethod>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PaymentMethod>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}