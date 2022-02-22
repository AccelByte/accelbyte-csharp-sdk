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
    /// userGetFriendshipStatus
    /// </summary>
    public class UserGetFriendshipStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserGetFriendshipStatusBuilder Builder = new UserGetFriendshipStatusBuilder();

        public class UserGetFriendshipStatusBuilder
        {
            
            
            internal UserGetFriendshipStatusBuilder() { }





            public UserGetFriendshipStatus Build(
                string friendId,
                string namespace_
            )
            {
                return new UserGetFriendshipStatus(this,
                    friendId,                    
                    namespace_                    
                );
            }
        }

        private UserGetFriendshipStatus(UserGetFriendshipStatusBuilder builder,
            string friendId,
            string namespace_
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public UserGetFriendshipStatus(
            string friendId,            
            string namespace_            
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/friends/namespaces/{namespace}/me/status/{friendId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserGetFriendshipStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserGetFriendshipStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserGetFriendshipStatusResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}