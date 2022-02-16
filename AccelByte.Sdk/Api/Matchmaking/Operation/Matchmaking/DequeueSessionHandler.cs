// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// DequeueSessionHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:SESSION [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Dequeues joinable session so that it will not be matched with player's match request tickets.
    /// 
    /// This endpoint is intended to be called by game server to let matchmaker know that
    /// the game server does not want more players to its session, even though it is not full.
    /// </summary>
    public class DequeueSessionHandler : AccelByte.Sdk.Core.Operation
    {
        public DequeueSessionHandler(
            string namespace_,            
            Model.ModelsDequeueRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions/dequeue";

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