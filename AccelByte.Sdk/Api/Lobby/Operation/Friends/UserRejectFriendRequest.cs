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
    /// userRejectFriendRequest
    ///
    /// User reject a friend request.
    /// </summary>
    public class UserRejectFriendRequest : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UserRejectFriendRequestBuilder Builder { get => new UserRejectFriendRequestBuilder(); }

        public class UserRejectFriendRequestBuilder
            : OperationBuilder<UserRejectFriendRequestBuilder>
        {





            internal UserRejectFriendRequestBuilder() { }






            public UserRejectFriendRequest Build(
                ModelUserRejectFriendRequest body,
                string namespace_
            )
            {
                UserRejectFriendRequest op = new UserRejectFriendRequest(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UserRejectFriendRequest(UserRejectFriendRequestBuilder builder,
            ModelUserRejectFriendRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UserRejectFriendRequest(
            string namespace_,
            Model.ModelUserRejectFriendRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/friends/namespaces/{namespace}/me/request/reject";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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