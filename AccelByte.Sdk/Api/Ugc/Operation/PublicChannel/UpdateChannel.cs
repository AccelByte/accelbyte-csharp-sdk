// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// UpdateChannel
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CHANNEL [UPDATE]
    /// </summary>
    public class UpdateChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateChannelBuilder Builder = new UpdateChannelBuilder();

        public class UpdateChannelBuilder
        {
            
            
            
            
            internal UpdateChannelBuilder() { }





            public UpdateChannel Build(
                ModelsChannelRequest body,
                string channelId,
                string namespace_,
                string userId
            )
            {
                return new UpdateChannel(this,
                    body,                    
                    channelId,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private UpdateChannel(UpdateChannelBuilder builder,
            ModelsChannelRequest body,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateChannel(
            string channelId,            
            string namespace_,            
            string userId,            
            Model.ModelsChannelRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsChannelResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}