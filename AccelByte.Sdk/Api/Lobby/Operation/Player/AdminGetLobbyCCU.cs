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
    /// adminGetLobbyCCU
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:LOBBY:CCU [READ]` with scope `social`
    /// 
    /// Get the number of players connected to the Lobby in the given namespace.
    /// </summary>
    public class AdminGetLobbyCCU : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetLobbyCCUBuilder Builder = new AdminGetLobbyCCUBuilder();

        public class AdminGetLobbyCCUBuilder
            : OperationBuilder<AdminGetLobbyCCUBuilder>
        {
            
            internal AdminGetLobbyCCUBuilder() { }





            public AdminGetLobbyCCU Build(
                string namespace_
            )
            {
                AdminGetLobbyCCU op = new AdminGetLobbyCCU(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetLobbyCCU(AdminGetLobbyCCUBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetLobbyCCU(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/ccu";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetLobbyCcuResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLobbyCcuResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetLobbyCcuResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}