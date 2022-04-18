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
    /// updateGoogleIAPConfig
    ///
    /// Update google iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated google iap config
    /// </summary>
    public class UpdateGoogleIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGoogleIAPConfigBuilder Builder = new UpdateGoogleIAPConfigBuilder();

        public class UpdateGoogleIAPConfigBuilder
            : OperationBuilder<UpdateGoogleIAPConfigBuilder>
        {
            
            public Model.GoogleIAPConfigRequest? Body { get; set; }
            
            internal UpdateGoogleIAPConfigBuilder() { }



            public UpdateGoogleIAPConfigBuilder SetBody(Model.GoogleIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }



            public UpdateGoogleIAPConfig Build(
                string namespace_
            )
            {
                UpdateGoogleIAPConfig op = new UpdateGoogleIAPConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateGoogleIAPConfig(UpdateGoogleIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGoogleIAPConfig(
            string namespace_,            
            Model.GoogleIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/google";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.GoogleIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.GoogleIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GoogleIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}