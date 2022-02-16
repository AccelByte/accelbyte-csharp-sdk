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
    /// SearchChannelSpecificContent
    ///
    /// Requires valid user token
    /// </summary>
    public class SearchChannelSpecificContent : AccelByte.Sdk.Core.Operation
    {
        public SearchChannelSpecificContent(
            string channelId,            
            string namespace_,            
            string? creator,            
            string? isofficial,            
            string? limit,            
            string? name,            
            string? offset,            
            string? orderby,            
            string? sortby,            
            string? subtype,            
            string? tags,            
            string? type,            
            string? userId            
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            
            if (creator != null) QueryParams["creator"] = creator;
            if (isofficial != null) QueryParams["isofficial"] = isofficial;
            if (limit != null) QueryParams["limit"] = limit;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = offset;
            if (orderby != null) QueryParams["orderby"] = orderby;
            if (sortby != null) QueryParams["sortby"] = sortby;
            if (subtype != null) QueryParams["subtype"] = subtype;
            if (tags != null) QueryParams["tags"] = tags;
            if (type != null) QueryParams["type"] = type;
            if (userId != null) QueryParams["userId"] = userId;
            
            
            
            
        }

        public override string Path => "/ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json","application/octet-stream" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsPaginatedContentDownloadResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsPaginatedContentDownloadResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}