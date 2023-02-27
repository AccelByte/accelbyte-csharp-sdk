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
    /// userRequestFriend
    ///
    /// Client should provide either friendID or friendPublicID. If both are provided, friendID will be chosen to be used.
    /// </summary>
    public class UserRequestFriend : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserRequestFriendBuilder Builder { get => new UserRequestFriendBuilder(); }

        public class UserRequestFriendBuilder
            : OperationBuilder<UserRequestFriendBuilder>
        {





            internal UserRequestFriendBuilder() { }






            public UserRequestFriend Build(
                ModelUserRequestFriendRequest body,
                string namespace_
            )
            {
                UserRequestFriend op = new UserRequestFriend(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UserRequestFriend(UserRequestFriendBuilder builder,
            ModelUserRequestFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserRequestFriend(
            string namespace_,
            Model.ModelUserRequestFriendRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}