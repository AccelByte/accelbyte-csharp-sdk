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
    /// adminUpdateConfigV1
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:LOBBY:CONFIG [UPDATE]` with scope `social`
    /// 
    /// update lobby config of a namespace.
    /// </summary>
    public class AdminUpdateConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateConfigV1Builder Builder = new AdminUpdateConfigV1Builder();

        public class AdminUpdateConfigV1Builder
            : OperationBuilder<AdminUpdateConfigV1Builder>
        {
            
            
            internal AdminUpdateConfigV1Builder() { }






            public AdminUpdateConfigV1 Build(
                ModelsConfigReq body,
                string namespace_
            )
            {
                AdminUpdateConfigV1 op = new AdminUpdateConfigV1(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateConfigV1(AdminUpdateConfigV1Builder builder,
            ModelsConfigReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateConfigV1(
            string namespace_,            
            Model.ModelsConfigReq body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config/namespaces/{namespace}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsConfigReq? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigReq>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigReq>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}