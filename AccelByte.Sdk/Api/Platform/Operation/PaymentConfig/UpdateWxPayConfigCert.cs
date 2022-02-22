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
    /// updateWxPayConfigCert
    ///
    /// Upload wxpay cert file.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated payment merchant config
    /// </summary>
    public class UpdateWxPayConfigCert : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateWxPayConfigCertBuilder Builder = new UpdateWxPayConfigCertBuilder();

        public class UpdateWxPayConfigCertBuilder
        {
            
            public Stream? File { get; set; }
            
            internal UpdateWxPayConfigCertBuilder() { }




            public UpdateWxPayConfigCertBuilder SetFile(Stream _file)
            {
                File = _file;
                return this;
            }


            public UpdateWxPayConfigCert Build(
                string id
            )
            {
                return new UpdateWxPayConfigCert(this,
                    id                    
                );
            }
        }

        private UpdateWxPayConfigCert(UpdateWxPayConfigCertBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            
            if (builder.File != null) FormParams["file"] = builder.File;
            
            
            
        }
        #endregion

        public UpdateWxPayConfigCert(
            string id,            
            Stream? file            
        )
        {
            PathParams["id"] = id;
            
            
            if (file != null) FormParams["file"] = file;
            
            
            
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/wxpayconfig/cert";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

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