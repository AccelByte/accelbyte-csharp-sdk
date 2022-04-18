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
                string paymentProvider,
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
            string paymentProvider,
            string region
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (region != null) QueryParams["region"] = region;
            
            
            
            

        }
        #endregion

        public GetPaymentPublicConfig(
            string namespace_,            
            bool? sandbox,            
            string paymentProvider,            
            string region            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (region != null) QueryParams["region"] = region;
            
            
            
            

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
}