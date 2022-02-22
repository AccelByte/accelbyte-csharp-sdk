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
    /// ListServer
    ///
    /// ```
    /// This endpoint lists all QoS services available in all regions.
    /// 
    /// This endpoint is intended to be called by game client to find out all available regions.
    /// After getting a list of QoS on each region, game client is expected to ping each one with UDP
    /// connection as described below:
    /// 
    /// 1. Make UDP connection to each QoS's IP:Port
    /// 2. Send string "PING" after connection established
    /// 3. Wait for string "PONG" response
    /// 4. Note the request-response latency for each QoS in each region
    /// 
    /// The game then can use ping latency information to either:
    /// 1. Inform the player on these latencies and let player choose preferred region
    /// 2. Send the latency list to Matchmaking Service so that player can be matched with other players
    /// in nearby regions
    /// ```
    /// </summary>
    public class ListServer : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerBuilder Builder = new ListServerBuilder();

        public class ListServerBuilder
        {
            internal ListServerBuilder() { }





            public ListServer Build(
            )
            {
                return new ListServer(this
                );
            }
        }

        private ListServer(ListServerBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public ListServer(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/qosm/public/qos";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsListServerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListServerResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}