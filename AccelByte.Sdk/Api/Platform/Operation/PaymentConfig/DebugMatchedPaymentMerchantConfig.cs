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
    /// debugMatchedPaymentMerchantConfig
    ///
    /// Debug matched payment merchant config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment merchant config info
    /// </summary>
    public class DebugMatchedPaymentMerchantConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebugMatchedPaymentMerchantConfigBuilder Builder = new DebugMatchedPaymentMerchantConfigBuilder();

        public class DebugMatchedPaymentMerchantConfigBuilder
            : OperationBuilder<DebugMatchedPaymentMerchantConfigBuilder>
        {
            public string? Namespace { get; set; }
            
            public string? Region { get; set; }
            
            internal DebugMatchedPaymentMerchantConfigBuilder() { }


            public DebugMatchedPaymentMerchantConfigBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public DebugMatchedPaymentMerchantConfigBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }




            public DebugMatchedPaymentMerchantConfig Build(
            )
            {
                DebugMatchedPaymentMerchantConfig op = new DebugMatchedPaymentMerchantConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DebugMatchedPaymentMerchantConfig(DebugMatchedPaymentMerchantConfigBuilder builder
        )
        {
            
            if (builder.Namespace != null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DebugMatchedPaymentMerchantConfig(
            string? namespace_,            
            string? region            
        )
        {
            
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            if (region != null) QueryParams["region"] = region;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/matched";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentMerchantConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentMerchantConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}