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
    /// updateIAPItemConfig
    ///
    /// Update iap item config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated iap item config
    /// </summary>
    public class UpdateIAPItemConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateIAPItemConfigBuilder Builder = new UpdateIAPItemConfigBuilder();

        public class UpdateIAPItemConfigBuilder
        {
            
            public Model.IAPItemConfigUpdate? Body { get; set; }
            
            internal UpdateIAPItemConfigBuilder() { }



            public UpdateIAPItemConfigBuilder SetBody(Model.IAPItemConfigUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateIAPItemConfig Build(
                string namespace_
            )
            {
                return new UpdateIAPItemConfig(this,
                    namespace_                    
                );
            }
        }

        private UpdateIAPItemConfig(UpdateIAPItemConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateIAPItemConfig(
            string namespace_,            
            Model.IAPItemConfigUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/item";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.IAPItemConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.IAPItemConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPItemConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}