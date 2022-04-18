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
    /// updatePayPalConfig
    ///
    /// Update PayPal config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated payment merchant config
    /// </summary>
    public class UpdatePayPalConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePayPalConfigBuilder Builder = new UpdatePayPalConfigBuilder();

        public class UpdatePayPalConfigBuilder
            : OperationBuilder<UpdatePayPalConfigBuilder>
        {
            
            public bool? Sandbox { get; set; }
            
            public bool? Validate { get; set; }
            
            public Model.PayPalConfig? Body { get; set; }
            
            internal UpdatePayPalConfigBuilder() { }


            public UpdatePayPalConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }

            public UpdatePayPalConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }


            public UpdatePayPalConfigBuilder SetBody(Model.PayPalConfig _body)
            {
                Body = _body;
                return this;
            }



            public UpdatePayPalConfig Build(
                string id
            )
            {
                UpdatePayPalConfig op = new UpdatePayPalConfig(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdatePayPalConfig(UpdatePayPalConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePayPalConfig(
            string id,            
            bool? sandbox,            
            bool? validate,            
            Model.PayPalConfig body            
        )
        {
            PathParams["id"] = id;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/paypalconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

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