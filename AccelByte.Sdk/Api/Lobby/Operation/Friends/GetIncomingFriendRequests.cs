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
    /// get incoming friend requests
    ///
    /// Get list of incoming friend requests.
    /// </summary>
    public class GetIncomingFriendRequests : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetIncomingFriendRequestsBuilder Builder { get => new GetIncomingFriendRequestsBuilder(); }

        public class GetIncomingFriendRequestsBuilder
            : OperationBuilder<GetIncomingFriendRequestsBuilder>
        {

            public string? FriendId { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetIncomingFriendRequestsBuilder() { }


            public GetIncomingFriendRequestsBuilder SetFriendId(string _friendId)
            {
                FriendId = _friendId;
                return this;
            }

            public GetIncomingFriendRequestsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetIncomingFriendRequestsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetIncomingFriendRequests Build(
                string namespace_,
                string userId
            )
            {
                GetIncomingFriendRequests op = new GetIncomingFriendRequests(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetIncomingFriendRequests(GetIncomingFriendRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.FriendId is not null) QueryParams["friendId"] = builder.FriendId;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetIncomingFriendRequests(
            string namespace_,
            string userId,
            string? friendId,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (friendId is not null) QueryParams["friendId"] = friendId;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/incoming";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelLoadIncomingFriendsWithTimeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelLoadIncomingFriendsWithTimeResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelLoadIncomingFriendsWithTimeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLoadIncomingFriendsWithTimeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}