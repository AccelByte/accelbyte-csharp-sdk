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
    /// AdminDeleteChannel
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:{userId}:CHANNEL [DELETE]
    /// </summary>
    public class AdminDeleteChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteChannelBuilder Builder = new AdminDeleteChannelBuilder();

        public class AdminDeleteChannelBuilder
        {
            
            
            
            internal AdminDeleteChannelBuilder() { }





            public AdminDeleteChannel Build(
                string channelId,
                string namespace_,
                string userId
            )
            {
                return new AdminDeleteChannel(this,
                    channelId,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminDeleteChannel(AdminDeleteChannelBuilder builder,
            string channelId,
            string namespace_,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminDeleteChannel(
            string channelId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}";

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