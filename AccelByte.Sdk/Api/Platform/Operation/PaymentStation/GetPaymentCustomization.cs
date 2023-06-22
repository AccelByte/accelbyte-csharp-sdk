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
    /// getPaymentCustomization
    ///
    /// Get payment provider customization, at current only Adyen provide customization. This api has been deprecated, pls use /public/namespaces/{namespace}/payment/publicconfig to get adyen config
    /// Other detail info:
    /// 
    ///   * Returns : customization
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetPaymentCustomization : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPaymentCustomizationBuilder Builder { get => new GetPaymentCustomizationBuilder(); }

        public class GetPaymentCustomizationBuilder
            : OperationBuilder<GetPaymentCustomizationBuilder>
        {

            public bool? Sandbox { get; set; }





            internal GetPaymentCustomizationBuilder() { }


            public GetPaymentCustomizationBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public GetPaymentCustomization Build(
                string namespace_,
                GetPaymentCustomizationPaymentProvider paymentProvider,
                string region
            )
            {
                GetPaymentCustomization op = new GetPaymentCustomization(this,
                    namespace_,
                    paymentProvider,
                    region
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetPaymentCustomization(GetPaymentCustomizationBuilder builder,
            string namespace_,
            GetPaymentCustomizationPaymentProvider paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;






        }
        #endregion

        public GetPaymentCustomization(
            string namespace_,
            bool? sandbox,
            GetPaymentCustomizationPaymentProvider paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (paymentProvider is not null) QueryParams["paymentProvider"] = paymentProvider.Value;
            if (region is not null) QueryParams["region"] = region;






        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/customization";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.Customization? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.Customization>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.Customization>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Customization>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetPaymentCustomizationPaymentProvider : StringEnum<GetPaymentCustomizationPaymentProvider>
    {
        public static readonly GetPaymentCustomizationPaymentProvider ADYEN
            = new GetPaymentCustomizationPaymentProvider("ADYEN");

        public static readonly GetPaymentCustomizationPaymentProvider ALIPAY
            = new GetPaymentCustomizationPaymentProvider("ALIPAY");

        public static readonly GetPaymentCustomizationPaymentProvider CHECKOUT
            = new GetPaymentCustomizationPaymentProvider("CHECKOUT");

        public static readonly GetPaymentCustomizationPaymentProvider PAYPAL
            = new GetPaymentCustomizationPaymentProvider("PAYPAL");

        public static readonly GetPaymentCustomizationPaymentProvider STRIPE
            = new GetPaymentCustomizationPaymentProvider("STRIPE");

        public static readonly GetPaymentCustomizationPaymentProvider WALLET
            = new GetPaymentCustomizationPaymentProvider("WALLET");

        public static readonly GetPaymentCustomizationPaymentProvider WXPAY
            = new GetPaymentCustomizationPaymentProvider("WXPAY");

        public static readonly GetPaymentCustomizationPaymentProvider XSOLLA
            = new GetPaymentCustomizationPaymentProvider("XSOLLA");


        public static implicit operator GetPaymentCustomizationPaymentProvider(string value)
        {
            return NewValue(value);
        }

        public GetPaymentCustomizationPaymentProvider(string enumValue)
            : base(enumValue)
        {

        }
    }

}