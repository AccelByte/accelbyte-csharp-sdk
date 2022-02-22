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
    /// updatePaymentCallbackConfig
    ///
    /// Update payment callback configuration.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : Payment callback config
    /// </summary>
    public class UpdatePaymentCallbackConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdatePaymentCallbackConfigBuilder Builder = new UpdatePaymentCallbackConfigBuilder();

        public class UpdatePaymentCallbackConfigBuilder
        {
            
            public Model.PaymentCallbackConfigUpdate? Body { get; set; }
            
            internal UpdatePaymentCallbackConfigBuilder() { }



            public UpdatePaymentCallbackConfigBuilder SetBody(Model.PaymentCallbackConfigUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdatePaymentCallbackConfig Build(
                string namespace_
            )
            {
                return new UpdatePaymentCallbackConfig(this,
                    namespace_                    
                );
            }
        }

        private UpdatePaymentCallbackConfig(UpdatePaymentCallbackConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdatePaymentCallbackConfig(
            string namespace_,            
            Model.PaymentCallbackConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/config/callback";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentCallbackConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentCallbackConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentCallbackConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}