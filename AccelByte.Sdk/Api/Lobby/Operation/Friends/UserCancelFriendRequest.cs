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
    /// userCancelFriendRequest
    /// </summary>
    public class UserCancelFriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserCancelFriendRequestBuilder Builder = new UserCancelFriendRequestBuilder();

        public class UserCancelFriendRequestBuilder
            : OperationBuilder<UserCancelFriendRequestBuilder>
        {
            
            
            internal UserCancelFriendRequestBuilder() { }





            public UserCancelFriendRequest Build(
                ModelUserCancelFriendRequest body,
                string namespace_
            )
            {
                UserCancelFriendRequest op = new UserCancelFriendRequest(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UserCancelFriendRequest(UserCancelFriendRequestBuilder builder,
            ModelUserCancelFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserCancelFriendRequest(
            string namespace_,            
            Model.ModelUserCancelFriendRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/cancel";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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