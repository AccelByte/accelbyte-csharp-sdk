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
    /// ShutdownServer
    ///
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server to let DSM know that it is shutting down. Calling this will remove the server and session records from DB.Set 'kill_me' in request to 'true' if the DS cannot shut itself down.
    /// </summary>
    public class ShutdownServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ShutdownServerBuilder Builder = new ShutdownServerBuilder();

        public class ShutdownServerBuilder
        {
            
            
            internal ShutdownServerBuilder() { }





            public ShutdownServer Build(
                ModelsShutdownServerRequest body,
                string namespace_
            )
            {
                return new ShutdownServer(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private ShutdownServer(ShutdownServerBuilder builder,
            ModelsShutdownServerRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public ShutdownServer(
            string namespace_,            
            Model.ModelsShutdownServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/shutdown";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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