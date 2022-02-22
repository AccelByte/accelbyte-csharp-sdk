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
    /// UpdateMatchmakingChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Update]
    /// 
    /// Required Scope: social
    /// 
    /// Update channel based on namespace and channel name
    /// 
    /// Action Code: 510111
    /// </summary>
    public class UpdateMatchmakingChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateMatchmakingChannelBuilder Builder = new UpdateMatchmakingChannelBuilder();

        public class UpdateMatchmakingChannelBuilder
        {
            
            
            
            internal UpdateMatchmakingChannelBuilder() { }





            public UpdateMatchmakingChannel Build(
                ModelsUpdateChannelRequest body,
                string channelName,
                string namespace_
            )
            {
                return new UpdateMatchmakingChannel(this,
                    body,                    
                    channelName,                    
                    namespace_                    
                );
            }
        }

        private UpdateMatchmakingChannel(UpdateMatchmakingChannelBuilder builder,
            ModelsUpdateChannelRequest body,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateMatchmakingChannel(
            string channelName,            
            string namespace_,            
            Model.ModelsUpdateChannelRequest body            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}";

        public override HttpMethod Method => HttpMethod.Patch;

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