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
    /// RegisterLocalServer
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// Use the alternative GET of the same endpoint to upgrade DS connection to DSM via websocket.
    /// 
    /// This endpoint is intended to be called by local dedicated server to let DSM know that it is ready for use.
    /// Use local DS only for development purposes since DSM wouldn't be able to properly manage local DS in production.
    /// This MUST be called by DS after it is ready to accept match data and incoming client connections.
    /// 
    /// Upon successfully calling this endpoint, the dedicated
    /// server is listed under READY local servers.```
    /// </summary>
    public class RegisterLocalServer : AccelByte.Sdk.Core.Operation
    {
        public RegisterLocalServer(
            string namespace_,            
            Model.ModelsRegisterLocalServerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/local/register";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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