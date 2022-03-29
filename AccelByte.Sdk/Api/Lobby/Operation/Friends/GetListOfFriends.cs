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
    /// get list of friends
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:FRIENDS [READ]` with scope `social`
    /// 
    /// get list of friends in a namespace.
    /// </summary>
    public class GetListOfFriends : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetListOfFriendsBuilder Builder = new GetListOfFriendsBuilder();

        public class GetListOfFriendsBuilder
        {
            
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetListOfFriendsBuilder() { }


            public GetListOfFriendsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetListOfFriendsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public GetListOfFriends Build(
                string namespace_,
                string userId
            )
            {
                return new GetListOfFriends(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GetListOfFriends(GetListOfFriendsBuilder builder,
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

        public GetListOfFriends(
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

        public override string Path => "/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetFriendsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetFriendsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetFriendsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}