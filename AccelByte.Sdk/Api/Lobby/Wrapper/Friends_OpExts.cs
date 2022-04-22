// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LobbyFriends_OpExts
    {
        public static List<Lobby.Model.ModelGetUserFriendsResponse>? Execute(
            this GetUserFriendsUpdated.GetUserFriendsUpdatedBuilder builder,
            string namespace_
        )
        {
            GetUserFriendsUpdated op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Friends)builder.WrapperObject!).GetUserFriendsUpdated(op);
        }

        public static List<Lobby.Model.ModelGetUserIncomingFriendsResponse>? Execute(
            this GetUserIncomingFriends.GetUserIncomingFriendsBuilder builder,
            string namespace_
        )
        {
            GetUserIncomingFriends op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Friends)builder.WrapperObject!).GetUserIncomingFriends(op);
        }

        public static List<Lobby.Model.ModelGetUserOutgoingFriendsResponse>? Execute(
            this GetUserOutgoingFriends.GetUserOutgoingFriendsBuilder builder,
            string namespace_
        )
        {
            GetUserOutgoingFriends op = builder.Build(
                namespace_
            );

            return ((Lobby.Wrapper.Friends)builder.WrapperObject!).GetUserOutgoingFriends(op);
        }

        public static void Execute(
            this UserRequestFriend.UserRequestFriendBuilder builder,
            ModelRequestFriendsRequest body,
            string namespace_
        )
        {
            UserRequestFriend op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserRequestFriend(op);
        }

        public static void Execute(
            this UserAcceptFriendRequest.UserAcceptFriendRequestBuilder builder,
            ModelUserAcceptFriendRequest body,
            string namespace_
        )
        {
            UserAcceptFriendRequest op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserAcceptFriendRequest(op);
        }

        public static void Execute(
            this UserCancelFriendRequest.UserCancelFriendRequestBuilder builder,
            ModelUserCancelFriendRequest body,
            string namespace_
        )
        {
            UserCancelFriendRequest op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserCancelFriendRequest(op);
        }

        public static void Execute(
            this UserRejectFriendRequest.UserRejectFriendRequestBuilder builder,
            ModelUserRejectFriendRequest body,
            string namespace_
        )
        {
            UserRejectFriendRequest op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserRejectFriendRequest(op);
        }

        public static Lobby.Model.ModelUserGetFriendshipStatusResponse? Execute(
            this UserGetFriendshipStatus.UserGetFriendshipStatusBuilder builder,
            string friendId,
            string namespace_
        )
        {
            UserGetFriendshipStatus op = builder.Build(
                friendId,
                namespace_
            );

            return ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserGetFriendshipStatus(op);
        }

        public static void Execute(
            this UserUnfriendRequest.UserUnfriendRequestBuilder builder,
            ModelUserUnfriendRequest body,
            string namespace_
        )
        {
            UserUnfriendRequest op = builder.Build(
                body,
                namespace_
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).UserUnfriendRequest(op);
        }

        public static void Execute(
            this AddFriendsWithoutConfirmation.AddFriendsWithoutConfirmationBuilder builder,
            ModelBulkAddFriendsRequest body,
            string namespace_,
            string userId
        )
        {
            AddFriendsWithoutConfirmation op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Lobby.Wrapper.Friends)builder.WrapperObject!).AddFriendsWithoutConfirmation(op);
        }

        public static Lobby.Model.ModelGetFriendsResponse? Execute(
            this GetListOfFriends.GetListOfFriendsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetListOfFriends op = builder.Build(
                namespace_,
                userId
            );

            return ((Lobby.Wrapper.Friends)builder.WrapperObject!).GetListOfFriends(op);
        }

    }
}