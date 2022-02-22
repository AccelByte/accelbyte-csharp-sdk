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
    /// updateXsollaConfig
    ///
    /// Update xsolla configuration. Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated payment merchant config
    /// </summary>
    public class UpdateXsollaConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateXsollaConfigBuilder Builder = new UpdateXsollaConfigBuilder();

        public class UpdateXsollaConfigBuilder
        {
            
            public bool? Validate { get; set; }
            
            public Model.XsollaConfig? Body { get; set; }
            
            internal UpdateXsollaConfigBuilder() { }


            public UpdateXsollaConfigBuilder SetValidate(bool _validate)
            {
                Validate = _validate;
                return this;
            }


            public UpdateXsollaConfigBuilder SetBody(Model.XsollaConfig _body)
            {
                Body = _body;
                return this;
            }



            public UpdateXsollaConfig Build(
                string id
            )
            {
                return new UpdateXsollaConfig(this,
                    id                    
                );
            }
        }

        private UpdateXsollaConfig(UpdateXsollaConfigBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            if (builder.Validate != null) QueryParams["validate"] = Convert.ToString(builder.Validate)!;
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateXsollaConfig(
            string id,            
            bool? validate,            
            Model.XsollaConfig body            
        )
        {
            PathParams["id"] = id;
            
            if (validate != null) QueryParams["validate"] = Convert.ToString(validate)!;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollaconfig";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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