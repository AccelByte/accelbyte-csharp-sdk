// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// Heartbeat
    ///
    /// ```
    /// Required permission: QOS:SERVER [CREATE][UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by QoS service
    /// to register and periodically let QoS Manager know that it is still alive.
    /// ```
    /// </summary>
    public class Heartbeat : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static HeartbeatBuilder Builder = new HeartbeatBuilder();

        public class HeartbeatBuilder
            : OperationBuilder<HeartbeatBuilder>
        {
            
            internal HeartbeatBuilder() { }






            public Heartbeat Build(
                ModelsHeartbeatRequest body
            )
            {
                Heartbeat op = new Heartbeat(this,
                    body                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private Heartbeat(HeartbeatBuilder builder,
            ModelsHeartbeatRequest body
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Heartbeat(
            Model.ModelsHeartbeatRequest body            
        )
        {
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/servers/heartbeat";

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