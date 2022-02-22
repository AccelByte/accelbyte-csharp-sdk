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
    /// SingleAdminDeleteChannel
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CHANNEL [DELETE]
    /// </summary>
    public class SingleAdminDeleteChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SingleAdminDeleteChannelBuilder Builder = new SingleAdminDeleteChannelBuilder();

        public class SingleAdminDeleteChannelBuilder
        {
            
            
            internal SingleAdminDeleteChannelBuilder() { }





            public SingleAdminDeleteChannel Build(
                string channelId,
                string namespace_
            )
            {
                return new SingleAdminDeleteChannel(this,
                    channelId,                    
                    namespace_                    
                );
            }
        }

        private SingleAdminDeleteChannel(SingleAdminDeleteChannelBuilder builder,
            string channelId,
            string namespace_
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public SingleAdminDeleteChannel(
            string channelId,            
            string namespace_            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Delete;

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