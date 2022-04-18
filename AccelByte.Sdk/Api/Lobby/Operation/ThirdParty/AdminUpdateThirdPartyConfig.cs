// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminUpdateThirdPartyConfig
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:THIRDPARTY:CONFIG [UPDATE]` with scope `social`
    /// 
    /// Update third party config in a namespace.
    /// </summary>
    public class AdminUpdateThirdPartyConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateThirdPartyConfigBuilder Builder = new AdminUpdateThirdPartyConfigBuilder();

        public class AdminUpdateThirdPartyConfigBuilder
            : OperationBuilder<AdminUpdateThirdPartyConfigBuilder>
        {
            
            
            internal AdminUpdateThirdPartyConfigBuilder() { }





            public AdminUpdateThirdPartyConfig Build(
                ModelsUpdateConfigRequest body,
                string namespace_
            )
            {
                AdminUpdateThirdPartyConfig op = new AdminUpdateThirdPartyConfig(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateThirdPartyConfig(AdminUpdateThirdPartyConfigBuilder builder,
            ModelsUpdateConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateThirdPartyConfig(
            string namespace_,            
            Model.ModelsUpdateConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsUpdateConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}