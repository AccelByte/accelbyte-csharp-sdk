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
    /// get outgoing friend requests
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:FRIENDS [READ]` with scope `social`
    /// 
    /// get list of outgoing friend requests in a namespace.
    /// </summary>
    public class GetOutgoingFriendRequests : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetOutgoingFriendRequestsBuilder Builder { get => new GetOutgoingFriendRequestsBuilder(); }

        public class GetOutgoingFriendRequestsBuilder
            : OperationBuilder<GetOutgoingFriendRequestsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal GetOutgoingFriendRequestsBuilder() { }


            public GetOutgoingFriendRequestsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetOutgoingFriendRequestsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetOutgoingFriendRequests Build(
                string namespace_,
                string userId
            )
            {
                GetOutgoingFriendRequests op = new GetOutgoingFriendRequests(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetOutgoingFriendRequests(GetOutgoingFriendRequestsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetOutgoingFriendRequests(
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






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/outgoing";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelLoadOutgoingFriendsWithTimeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLoadOutgoingFriendsWithTimeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLoadOutgoingFriendsWithTimeResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}