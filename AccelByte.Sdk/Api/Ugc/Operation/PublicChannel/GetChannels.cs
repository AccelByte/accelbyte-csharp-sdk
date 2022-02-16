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
    /// GetChannels
    ///
    /// Required permission NAMESPACE:{namespace}:USER:{userId}:CHANNEL [READ]
    /// </summary>
    public class GetChannels : AccelByte.Sdk.Core.Operation
    {
        public GetChannels(
            string namespace_,            
            string userId,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedGetChannelResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetChannelResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedGetChannelResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}