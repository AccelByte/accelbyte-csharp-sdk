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
    /// updateTwitchIAPConfig
    ///
    /// Update twitch iap config. Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:IAP:CONFIG", action=4 (UPDATE)
    ///   *  Returns : updated twitch iap config
    /// </summary>
    public class UpdateTwitchIAPConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTwitchIAPConfigBuilder Builder = new UpdateTwitchIAPConfigBuilder();

        public class UpdateTwitchIAPConfigBuilder
            : OperationBuilder<UpdateTwitchIAPConfigBuilder>
        {
            
            public Model.TwitchIAPConfigRequest? Body { get; set; }
            
            internal UpdateTwitchIAPConfigBuilder() { }



            public UpdateTwitchIAPConfigBuilder SetBody(Model.TwitchIAPConfigRequest _body)
            {
                Body = _body;
                return this;
            }



            public UpdateTwitchIAPConfig Build(
                string namespace_
            )
            {
                UpdateTwitchIAPConfig op = new UpdateTwitchIAPConfig(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateTwitchIAPConfig(UpdateTwitchIAPConfigBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateTwitchIAPConfig(
            string namespace_,            
            Model.TwitchIAPConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/iap/config/twitch";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.TwitchIAPConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TwitchIAPConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TwitchIAPConfigInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}