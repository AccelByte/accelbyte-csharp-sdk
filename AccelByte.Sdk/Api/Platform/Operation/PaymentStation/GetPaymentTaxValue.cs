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
            : OperationBuilder<GetPaymentTaxValueBuilder>
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
                GetPaymentTaxValuePaymentProvider paymentProvider
            )
            {
                GetPaymentTaxValue op = new GetPaymentTaxValue(this,
                    namespace_,                    
                    paymentOrderNo,                    
                    paymentProvider                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetPaymentTaxValue(GetPaymentTaxValueBuilder builder,
            string namespace_,
            string paymentOrderNo,
            GetPaymentTaxValuePaymentProvider paymentProvider
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ZipCode is not null) QueryParams["zipCode"] = builder.ZipCode;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            

            
            
            

        }
        #endregion

        public GetPaymentTaxValue(
            string namespace_,            
            string? zipCode,            
            string paymentOrderNo,            
            GetPaymentTaxValuePaymentProvider paymentProvider            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (zipCode is not null) QueryParams["zipCode"] = zipCode;
            if (paymentOrderNo is not null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/tax";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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

    public class GetPaymentTaxValuePaymentProvider : StringEnum<GetPaymentTaxValuePaymentProvider>
    {
        public static readonly GetPaymentTaxValuePaymentProvider ADYEN
            = new GetPaymentTaxValuePaymentProvider("ADYEN");

        public static readonly GetPaymentTaxValuePaymentProvider ALIPAY
            = new GetPaymentTaxValuePaymentProvider("ALIPAY");

        public static readonly GetPaymentTaxValuePaymentProvider CHECKOUT
            = new GetPaymentTaxValuePaymentProvider("CHECKOUT");

        public static readonly GetPaymentTaxValuePaymentProvider PAYPAL
            = new GetPaymentTaxValuePaymentProvider("PAYPAL");

        public static readonly GetPaymentTaxValuePaymentProvider STRIPE
            = new GetPaymentTaxValuePaymentProvider("STRIPE");

        public static readonly GetPaymentTaxValuePaymentProvider WALLET
            = new GetPaymentTaxValuePaymentProvider("WALLET");

        public static readonly GetPaymentTaxValuePaymentProvider WXPAY
            = new GetPaymentTaxValuePaymentProvider("WXPAY");

        public static readonly GetPaymentTaxValuePaymentProvider XSOLLA
            = new GetPaymentTaxValuePaymentProvider("XSOLLA");


        public static implicit operator GetPaymentTaxValuePaymentProvider(string value)
        {
            return NewValue(value);
        }

        public GetPaymentTaxValuePaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}