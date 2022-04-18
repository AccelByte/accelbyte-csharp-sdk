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
    /// DeregisterLocalServer
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by local dedicated server
    /// to let DSM know that it is shutting down.
    /// 
    /// Calling this will remove the server records from DB.```
    /// </summary>
    public class DeregisterLocalServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeregisterLocalServerBuilder Builder = new DeregisterLocalServerBuilder();

        public class DeregisterLocalServerBuilder
            : OperationBuilder<DeregisterLocalServerBuilder>
        {
            
            
            internal DeregisterLocalServerBuilder() { }





            public DeregisterLocalServer Build(
                ModelsDeregisterLocalServerRequest body,
                string namespace_
            )
            {
                DeregisterLocalServer op = new DeregisterLocalServer(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeregisterLocalServer(DeregisterLocalServerBuilder builder,
            ModelsDeregisterLocalServerRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeregisterLocalServer(
            string namespace_,            
            Model.ModelsDeregisterLocalServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/local/deregister";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}