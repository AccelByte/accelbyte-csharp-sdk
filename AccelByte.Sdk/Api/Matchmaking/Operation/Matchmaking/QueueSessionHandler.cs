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
    /// QueueSessionHandler
    ///
    /// Required Permission: NAMESPACE:{namespace}:SESSION [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Queues joinable session so that it will be matched with player's match request tickets.
    /// The session queued must be in a channel/game mode that is set to have joinable flag.
    /// The session will be in queue until it is full or expired.
    /// Both the number of players and session queue timeout can be set in the channel's config.
    /// 
    /// This endpoint is intended to be called by game server to let matchmaker know that
    /// the game server is ready for receiving more players through matchmaking tickets to its session.
    /// 
    /// If a session is already queued, and game server wants to modify the data or
    /// renew the queue timeout (e.g. some player left and more empty slot opened up),
    /// simply call this endpoint with the updated session data.
    /// </summary>
    public class QueueSessionHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueueSessionHandlerBuilder Builder = new QueueSessionHandlerBuilder();

        public class QueueSessionHandlerBuilder
        {
            
            
            internal QueueSessionHandlerBuilder() { }





            public QueueSessionHandler Build(
                ModelsMatchmakingResult body,
                string namespace_
            )
            {
                return new QueueSessionHandler(this,
                    body,                    
                    namespace_                    
                );
            }
        }

        private QueueSessionHandler(QueueSessionHandlerBuilder builder,
            ModelsMatchmakingResult body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public QueueSessionHandler(
            string namespace_,            
            Model.ModelsMatchmakingResult body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/matchmaking/namespaces/{namespace}/sessions";

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