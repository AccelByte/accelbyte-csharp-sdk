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
    /// updatePaymentTaxConfig
    ///
    /// Update payment tax config.
    /// 
    /// 
    /// 
    ///      Request Body Parameters:
    /// 
    /// 
    ///      Parameter                | Type    | Required | Description
    ///     --------------------------|---------|----------|---------------------------------------------------------------------
    ///     taxJarEnabled             | Boolean | false
    ///     taxJarApiToken            | String  | false    | required, when taxJarEnabled is true and there is no existing token
    ///     sandboxTaxJarApiToken     | String  | false    | optional
    ///     taxJarProductCodesMapping | Map     | No       | key is item type(APP                                                |COINS |INGAMEITEM |BUNDLE |CODE |SUBSCRIPTION) and value is product tax code: https://developers.taxjar.com/api/reference/?ruby#get-list-tax-categories
    /// 
    /// 
    /// 
    /// Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : payment global tax config
    /// </summary>
    public class UpdatePaymentTaxConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePaymentTaxConfigBuilder Builder = new UpdatePaymentTaxConfigBuilder();

        public class UpdatePaymentTaxConfigBuilder
            : OperationBuilder<UpdatePaymentTaxConfigBuilder>
        {
            public Model.PaymentTaxConfigEdit? Body { get; set; }
            
            internal UpdatePaymentTaxConfigBuilder() { }



            public UpdatePaymentTaxConfigBuilder SetBody(Model.PaymentTaxConfigEdit _body)
            {
                Body = _body;
                return this;
            }



            public UpdatePaymentTaxConfig Build(
            )
            {
                UpdatePaymentTaxConfig op = new UpdatePaymentTaxConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdatePaymentTaxConfig(UpdatePaymentTaxConfigBuilder builder
        )
        {
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdatePaymentTaxConfig(
            Model.PaymentTaxConfigEdit body            
        )
        {
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/tax";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentTaxConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentTaxConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}