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
    /// debugMatchedPaymentProviderConfig
    ///
    /// Debug matched payment provider config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider config
    /// </summary>
    public class DebugMatchedPaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DebugMatchedPaymentProviderConfigBuilder Builder = new DebugMatchedPaymentProviderConfigBuilder();

        public class DebugMatchedPaymentProviderConfigBuilder
        {
            public string? Namespace { get; set; }
            
            public string? Region { get; set; }
            
            internal DebugMatchedPaymentProviderConfigBuilder() { }


            public DebugMatchedPaymentProviderConfigBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public DebugMatchedPaymentProviderConfigBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }




            public DebugMatchedPaymentProviderConfig Build(
            )
            {
                return new DebugMatchedPaymentProviderConfig(this
                );
            }
        }

        private DebugMatchedPaymentProviderConfig(DebugMatchedPaymentProviderConfigBuilder builder
        )
        {
            
            if (builder.Namespace != null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            
            
            
            
        }
        #endregion

        public DebugMatchedPaymentProviderConfig(
            string? namespace_,            
            string? region            
        )
        {
            
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/platform/admin/payment/config/provider/matched";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentProviderConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}