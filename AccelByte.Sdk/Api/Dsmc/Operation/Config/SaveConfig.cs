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
    /// SaveConfig
    ///
    /// ```
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:CONFIG [CREATE]
    /// Required scope: social
    /// 
    /// This endpoint adds/modifies config. When there are ready servers and
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
    /// "image_version_mapping": {
    /// "1.4.0": "accelbyte/sample-ds-go:1.4.0"
    /// },
    /// "default_version": "1.4.0",
    /// "cpu_limit": "100",
    /// "mem_limit": "64",
    /// "params": "",
    /// "min_count": 0,
    /// "max_count": 0,
    /// "buffer_count": 0,
    /// "configurations": {
    /// "1player": {
    /// "cpu_limit": "100",
    /// "mem_limit": "64",
    /// "params": "-gamemode 1p",
    /// },
    /// "50players": {
    /// "cpu_limit": "200",
    /// "mem_limit": "512",
    /// "params": "-gamemode 50p",
    /// }
    /// },
    /// "deployments": {
    /// "global-1p": {
    /// "game_version": "1.4.0"",
    /// "regions": ["us-west", "ap-southeast"],
    /// "configuration": "1player",
    /// "min_count": 0,
    /// "max_count": 0,
    /// "buffer_count": 2
    /// },
    /// "us-50p": {
    /// "game_version": "1.4.0"",
    /// "regions": ["us-west"],
    /// "configuration": "50players",
    /// "min_count": 0,
    /// "max_count": 0,
    /// "buffer_count": 5
    /// },
    /// },
    /// }
    /// ```
    /// </summary>
    [Obsolete(DiagnosticId ="ab_deprecated_operation")]
    public class SaveConfig : AccelByte.Sdk.Core.Operation
    {
        public SaveConfig(
            Model.ModelsDSMConfigRecord body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/admin/configs";

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