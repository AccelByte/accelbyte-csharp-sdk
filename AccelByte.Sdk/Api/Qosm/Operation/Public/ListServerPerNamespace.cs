// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Qosm.Operation
{
    /// <summary>
    /// ListServerPerNamespace
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
    public class ListServerPerNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListServerPerNamespaceBuilder Builder = new ListServerPerNamespaceBuilder();

        public class ListServerPerNamespaceBuilder
            : OperationBuilder<ListServerPerNamespaceBuilder>
        {

            public string? Status { get; set; }





            internal ListServerPerNamespaceBuilder() { }


            public ListServerPerNamespaceBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }





            public ListServerPerNamespace Build(
                string namespace_
            )
            {
                ListServerPerNamespace op = new ListServerPerNamespace(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private ListServerPerNamespace(ListServerPerNamespaceBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Status is not null) QueryParams["status"] = builder.Status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListServerPerNamespace(
            string namespace_,            
            string? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (status is not null) QueryParams["status"] = status;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/qosm/public/namespaces/{namespace}/qos";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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