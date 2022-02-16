// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// getTopicByTopicName
    ///
    /// Required permission : `NAMESPACE:{namespace}:TOPIC [READ]` with scope `social`
    /// 
    /// get topic information by topic name.
    /// </summary>
    public class GetTopicByTopicName : AccelByte.Sdk.Core.Operation
    {
        public GetTopicByTopicName(
            string namespace_,            
            string topic            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["topic"] = topic;
            
            
            
            
            
        }

        public override string Path => "/notification/namespaces/{namespace}/topics/{topic}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelNotificationTopicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelNotificationTopicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelNotificationTopicResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}