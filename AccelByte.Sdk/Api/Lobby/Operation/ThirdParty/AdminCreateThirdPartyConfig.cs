// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminCreateThirdPartyConfig
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:THIRDPARTY:CONFIG [CREATE]` with scope `social`
    /// 
    /// create third party config in a namespace.
    /// </summary>
    public class AdminCreateThirdPartyConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateThirdPartyConfigBuilder Builder = new AdminCreateThirdPartyConfigBuilder();

        public class AdminCreateThirdPartyConfigBuilder
            : OperationBuilder<AdminCreateThirdPartyConfigBuilder>
        {





            internal AdminCreateThirdPartyConfigBuilder() { }






            public AdminCreateThirdPartyConfig Build(
                ModelsCreateConfigRequest body,
                string namespace_
            )
            {
                AdminCreateThirdPartyConfig op = new AdminCreateThirdPartyConfig(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateThirdPartyConfig(AdminCreateThirdPartyConfigBuilder builder,
            ModelsCreateConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateThirdPartyConfig(
            string namespace_,            
            Model.ModelsCreateConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsCreateConfigResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateConfigResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsCreateConfigResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}