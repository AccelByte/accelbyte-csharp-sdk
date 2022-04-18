// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// RegisterServer
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server to let DSM know that it is ready for use.
    /// This MUST be called by DS after it is ready to accept match data and incoming client connections.
    /// 
    /// Upon successfully calling this endpoint, the dedicated
    /// server is listed under READY servers.```
    /// </summary>
    public class RegisterServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RegisterServerBuilder Builder = new RegisterServerBuilder();

        public class RegisterServerBuilder
            : OperationBuilder<RegisterServerBuilder>
        {
            
            
            internal RegisterServerBuilder() { }





            public RegisterServer Build(
                ModelsRegisterServerRequest body,
                string namespace_
            )
            {
                RegisterServer op = new RegisterServer(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RegisterServer(RegisterServerBuilder builder,
            ModelsRegisterServerRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RegisterServer(
            string namespace_,            
            Model.ModelsRegisterServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/register";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsServer? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsServer>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsServer>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}