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
    /// getPaymentPublicConfig
    ///
    /// Get payment provider public config, at current only Strip provide public config.
    /// Other detail info:
    /// 
    ///   * Returns : Public config
    /// </summary>
    public class GetPaymentPublicConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentPublicConfigBuilder Builder = new GetPaymentPublicConfigBuilder();

        public class GetPaymentPublicConfigBuilder
            : OperationBuilder<GetPaymentPublicConfigBuilder>
        {

            public bool? Sandbox { get; set; }





            internal GetPaymentPublicConfigBuilder() { }


            public GetPaymentPublicConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public GetPaymentPublicConfig Build(
                string namespace_,
                GetPaymentPublicConfigPaymentProvider paymentProvider,
                string region
            )
            {
                GetPaymentPublicConfig op = new GetPaymentPublicConfig(this,
                    namespace_,                    
                    paymentProvider,                    
                    region                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetPaymentPublicConfig(GetPaymentPublicConfigBuilder builder,
            string namespace_,
            GetPaymentPublicConfigPaymentProvider paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;
            

            
            
            

        }
        #endregion

        public GetPaymentPublicConfig(
            string namespace_,            
            bool? sandbox,            
            GetPaymentPublicConfigPaymentProvider paymentProvider,            
            string region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/publicconfig";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetPaymentPublicConfigPaymentProvider : StringEnum<GetPaymentPublicConfigPaymentProvider>
    {
        public static readonly GetPaymentPublicConfigPaymentProvider Adyen
            = new GetPaymentPublicConfigPaymentProvider("ADYEN");

        public static readonly GetPaymentPublicConfigPaymentProvider Alipay
            = new GetPaymentPublicConfigPaymentProvider("ALIPAY");

        public static readonly GetPaymentPublicConfigPaymentProvider Checkout
            = new GetPaymentPublicConfigPaymentProvider("CHECKOUT");

        public static readonly GetPaymentPublicConfigPaymentProvider Paypal
            = new GetPaymentPublicConfigPaymentProvider("PAYPAL");

        public static readonly GetPaymentPublicConfigPaymentProvider Stripe
            = new GetPaymentPublicConfigPaymentProvider("STRIPE");

        public static readonly GetPaymentPublicConfigPaymentProvider Wallet
            = new GetPaymentPublicConfigPaymentProvider("WALLET");

        public static readonly GetPaymentPublicConfigPaymentProvider Wxpay
            = new GetPaymentPublicConfigPaymentProvider("WXPAY");

        public static readonly GetPaymentPublicConfigPaymentProvider Xsolla
            = new GetPaymentPublicConfigPaymentProvider("XSOLLA");


        public static implicit operator GetPaymentPublicConfigPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public GetPaymentPublicConfigPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}