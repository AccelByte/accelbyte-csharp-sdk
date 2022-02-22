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
    /// SingleAdminUpdateChannel
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CHANNEL [UPDATE]
    /// </summary>
    public class SingleAdminUpdateChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminUpdateChannelBuilder Builder = new SingleAdminUpdateChannelBuilder();

        public class SingleAdminUpdateChannelBuilder
        {
            
            
            
            internal SingleAdminUpdateChannelBuilder() { }





            public SingleAdminUpdateChannel Build(
                ModelsChannelRequest body,
                string channelId,
                string namespace_
            )
            {
                return new SingleAdminUpdateChannel(this,
                    body,                    
                    channelId,                    
                    namespace_                    
                );
            }
        }

        private SingleAdminUpdateChannel(SingleAdminUpdateChannelBuilder builder,
            ModelsChannelRequest body,
            string channelId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public SingleAdminUpdateChannel(
            string channelId,            
            string namespace_,            
            Model.ModelsChannelRequest body            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

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