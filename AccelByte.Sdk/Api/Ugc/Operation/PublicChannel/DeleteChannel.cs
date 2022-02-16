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
    /// DeleteChannel
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CHANNEL [DELETE]
    /// </summary>
    public class DeleteChannel : AccelByte.Sdk.Core.Operation
    {
        public DeleteChannel(
            string channelId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

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