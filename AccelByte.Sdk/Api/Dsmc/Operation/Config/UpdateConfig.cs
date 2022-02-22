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
    /// UpdateConfig
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint modifies config. When there are ready servers and
    /// the server version is updated, those servers will be replaced with newer version.
    /// 
    /// Port is where your game listens for incoming UDP connection, if empty it'll be set to 15000
    /// 
    /// CPU and Memory limit / request are formatted with Kubernetes format,
    /// e.g. CPU of 1000m is 1 core, and Memory of 512Mi is 512 MB.
    /// 
    /// The creation/claim/session/unreachable/heartbeat timeouts are all in seconds.
    /// Creation timeout is time limit for DS to startup until registers itself.
    /// Claim timeout is time limit for game session manager to claim its ready DS.
    /// Session timeout is time limit for match session before deleted.
    /// Unreachable timeout is time limit for DS in UNREACHABLE state before deleted.
    /// Heartbeat timeout is time limit for DS to give heartbeat before marked as UNREACHABLE.
    /// 
    /// Sample config:
    /// {
    /// "namespace": "accelbyte",
    /// "providers": [
    /// "aws"
    /// ],
    /// "port": 7777,
    /// "protocol": "udp",
    /// "creation_timeout": 120,
    /// "claim_timeout": 60,
    /// "session_timeout": 1800,
    /// "heartbeat_timeout": 30,
    /// "unreachable_timeout": 30,
    /// }
    /// ```
    /// </summary>
    public class UpdateConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateConfigBuilder Builder = new UpdateConfigBuilder();

        public class UpdateConfigBuilder
        {
            
            
            internal UpdateConfigBuilder() { }





            public UpdateConfig Build(
                ModelsUpdateDSMConfigRequest body,
                string namespace_
            )
            {
                return new UpdateConfig(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private UpdateConfig(UpdateConfigBuilder builder,
            ModelsUpdateDSMConfigRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateConfig(
            string namespace_,            
            Model.ModelsUpdateDSMConfigRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/admin/namespaces/{namespace}/configs";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsDSMConfigRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsDSMConfigRecord>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDSMConfigRecord>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}