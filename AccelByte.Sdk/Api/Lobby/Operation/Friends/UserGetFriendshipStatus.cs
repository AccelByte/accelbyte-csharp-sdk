// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

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
            : OperationBuilder<UserGetFriendshipStatusBuilder>
        {





            internal UserGetFriendshipStatusBuilder() { }






            public UserGetFriendshipStatus Build(
                string friendId,
                string namespace_
            )
            {
                UserGetFriendshipStatus op = new UserGetFriendshipStatus(this,
                    friendId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UserGetFriendshipStatus(UserGetFriendshipStatusBuilder builder,
            string friendId,
            string namespace_
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserGetFriendshipStatus(
            string friendId,            
            string namespace_            
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/status/{friendId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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