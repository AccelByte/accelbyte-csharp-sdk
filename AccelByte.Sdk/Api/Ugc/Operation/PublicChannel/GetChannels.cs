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
        #region Builder Part
        public static GetChannelsBuilder Builder = new GetChannelsBuilder();

        public class GetChannelsBuilder
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetChannelsBuilder() { }


            public GetChannelsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetChannelsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetChannels Build(
                string namespace_,
                string userId
            )
            {
                return new GetChannels(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetChannels(GetChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            
        }
        #endregion

        public GetChannels(
            string namespace_,            
            string userId,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
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