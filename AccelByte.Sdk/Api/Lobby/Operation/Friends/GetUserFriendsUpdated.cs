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
    /// getUserFriendsUpdated
    /// </summary>
    public class GetUserFriendsUpdated : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserFriendsUpdatedBuilder Builder = new GetUserFriendsUpdatedBuilder();

        public class GetUserFriendsUpdatedBuilder
        {
            
            public string? Limit { get; set; }
            
            public string? Offset { get; set; }
            
            internal GetUserFriendsUpdatedBuilder() { }


            public GetUserFriendsUpdatedBuilder SetLimit(string _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserFriendsUpdatedBuilder SetOffset(string _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetUserFriendsUpdated Build(
                string namespace_
            )
            {
                return new GetUserFriendsUpdated(this,
                    namespace_                    
                );
            }
        }

        private GetUserFriendsUpdated(GetUserFriendsUpdatedBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = builder.Limit;
            if (builder.Offset != null) QueryParams["offset"] = builder.Offset;
            
            
            
            
        }
        #endregion

        public GetUserFriendsUpdated(
            string namespace_,            
            string? limit,            
            string? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = limit;
            if (offset != null) QueryParams["offset"] = offset;
            
            
            
            
        }

        public override string Path => "/friends/namespaces/{namespace}/me";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelGetUserFriendsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserFriendsResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelGetUserFriendsResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}