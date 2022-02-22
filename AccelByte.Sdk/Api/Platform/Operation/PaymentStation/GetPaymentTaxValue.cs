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
    /// getPaymentTaxValue
    ///
    /// Check and get a payment order's should pay tax.
    /// Other detail info:
    /// 
    ///   * Returns : tax result
    /// </summary>
    public class GetPaymentTaxValue : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentTaxValueBuilder Builder = new GetPaymentTaxValueBuilder();

        public class GetPaymentTaxValueBuilder
        {
            
            public string? ZipCode { get; set; }
            
            
            
            internal GetPaymentTaxValueBuilder() { }


            public GetPaymentTaxValueBuilder SetZipCode(string _zipCode)
            {
                ZipCode = _zipCode;
                return this;
            }




            public GetPaymentTaxValue Build(
                string namespace_,
                string paymentOrderNo,
                string paymentProvider
            )
            {
                return new GetPaymentTaxValue(this,
                    namespace_,                    
                    paymentOrderNo,                    
                    paymentProvider                    
                );
            }
        }

        private GetPaymentTaxValue(GetPaymentTaxValueBuilder builder,
            string namespace_,
            string paymentOrderNo,
            string paymentProvider
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ZipCode != null) QueryParams["zipCode"] = builder.ZipCode;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            
            
            
            
        }
        #endregion

        public GetPaymentTaxValue(
            string namespace_,            
            string? zipCode,            
            string paymentOrderNo,            
            string paymentProvider            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (zipCode != null) QueryParams["zipCode"] = zipCode;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.TaxResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TaxResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TaxResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}