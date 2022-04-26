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
    /// userAcceptFriendRequest
    /// </summary>
    public class UserAcceptFriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserAcceptFriendRequestBuilder Builder = new UserAcceptFriendRequestBuilder();

        public class UserAcceptFriendRequestBuilder
            : OperationBuilder<UserAcceptFriendRequestBuilder>
        {
            
            
            internal UserAcceptFriendRequestBuilder() { }






            public UserAcceptFriendRequest Build(
                ModelUserAcceptFriendRequest body,
                string namespace_
            )
            {
                UserAcceptFriendRequest op = new UserAcceptFriendRequest(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UserAcceptFriendRequest(UserAcceptFriendRequestBuilder builder,
            ModelUserAcceptFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserAcceptFriendRequest(
            string namespace_,            
            Model.ModelUserAcceptFriendRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/accept";

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