// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Friends
    {
        private readonly AccelByteSDK _sdk;

        public Friends(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserFriendsUpdated.GetUserFriendsUpdatedBuilder GetUserFriendsUpdatedOp
        {
            get { return Operation.GetUserFriendsUpdated.Builder.SetWrapperObject(this); }
        }
        public GetUserIncomingFriends.GetUserIncomingFriendsBuilder GetUserIncomingFriendsOp
        {
            get { return Operation.GetUserIncomingFriends.Builder.SetWrapperObject(this); }
        }
        public GetUserOutgoingFriends.GetUserOutgoingFriendsBuilder GetUserOutgoingFriendsOp
        {
            get { return Operation.GetUserOutgoingFriends.Builder.SetWrapperObject(this); }
        }
        public UserRequestFriend.UserRequestFriendBuilder UserRequestFriendOp
        {
            get { return Operation.UserRequestFriend.Builder.SetWrapperObject(this); }
        }
        public UserAcceptFriendRequest.UserAcceptFriendRequestBuilder UserAcceptFriendRequestOp
        {
            get { return Operation.UserAcceptFriendRequest.Builder.SetWrapperObject(this); }
        }
        public UserCancelFriendRequest.UserCancelFriendRequestBuilder UserCancelFriendRequestOp
        {
            get { return Operation.UserCancelFriendRequest.Builder.SetWrapperObject(this); }
        }
        public UserRejectFriendRequest.UserRejectFriendRequestBuilder UserRejectFriendRequestOp
        {
            get { return Operation.UserRejectFriendRequest.Builder.SetWrapperObject(this); }
        }
        public UserGetFriendshipStatus.UserGetFriendshipStatusBuilder UserGetFriendshipStatusOp
        {
            get { return Operation.UserGetFriendshipStatus.Builder.SetWrapperObject(this); }
        }
        public UserUnfriendRequest.UserUnfriendRequestBuilder UserUnfriendRequestOp
        {
            get { return Operation.UserUnfriendRequest.Builder.SetWrapperObject(this); }
        }
        public AddFriendsWithoutConfirmation.AddFriendsWithoutConfirmationBuilder AddFriendsWithoutConfirmationOp
        {
            get { return Operation.AddFriendsWithoutConfirmation.Builder.SetWrapperObject(this); }
        }
        public GetListOfFriends.GetListOfFriendsBuilder GetListOfFriendsOp
        {
            get { return Operation.GetListOfFriends.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.ModelGetUserFriendsResponse>? GetUserFriendsUpdated(GetUserFriendsUpdated input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserIncomingFriendsResponse>? GetUserIncomingFriends(GetUserIncomingFriends input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserOutgoingFriendsResponse>? GetUserOutgoingFriends(GetUserOutgoingFriends input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserRequestFriend(UserRequestFriend input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserAcceptFriendRequest(UserAcceptFriendRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserCancelFriendRequest(UserCancelFriendRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserRejectFriendRequest(UserRejectFriendRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserGetFriendshipStatusResponse? UserGetFriendshipStatus(UserGetFriendshipStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserUnfriendRequest(UserUnfriendRequest input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddFriendsWithoutConfirmation(AddFriendsWithoutConfirmation input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetFriendsResponse? GetListOfFriends(GetListOfFriends input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class Friends_OperationExtensions
    {
        public static List<Model.ModelGetUserFriendsResponse>? Execute(
            this GetUserFriendsUpdated.GetUserFriendsUpdatedBuilder builder,
            string namespace_
        )
        {
            GetUserFriendsUpdated op = builder.Build(
                namespace_
            );

            return ((Friends)builder.WrapperObject!).GetUserFriendsUpdated(op);
        }

        public static List<Model.ModelGetUserIncomingFriendsResponse>? Execute(
            this GetUserIncomingFriends.GetUserIncomingFriendsBuilder builder,
            string namespace_
        )
        {
            GetUserIncomingFriends op = builder.Build(
                namespace_
            );

            return ((Friends)builder.WrapperObject!).GetUserIncomingFriends(op);
        }

        public static List<Model.ModelGetUserOutgoingFriendsResponse>? Execute(
            this GetUserOutgoingFriends.GetUserOutgoingFriendsBuilder builder,
            string namespace_
        )
        {
            GetUserOutgoingFriends op = builder.Build(
                namespace_
            );

            return ((Friends)builder.WrapperObject!).GetUserOutgoingFriends(op);
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

            ((Friends)builder.WrapperObject!).UserRequestFriend(op);
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

            ((Friends)builder.WrapperObject!).UserAcceptFriendRequest(op);
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

            ((Friends)builder.WrapperObject!).UserCancelFriendRequest(op);
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

            ((Friends)builder.WrapperObject!).UserRejectFriendRequest(op);
        }

        public static Model.ModelUserGetFriendshipStatusResponse? Execute(
            this UserGetFriendshipStatus.UserGetFriendshipStatusBuilder builder,
            string friendId,
            string namespace_
        )
        {
            UserGetFriendshipStatus op = builder.Build(
                friendId,
                namespace_
            );

            return ((Friends)builder.WrapperObject!).UserGetFriendshipStatus(op);
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

            ((Friends)builder.WrapperObject!).UserUnfriendRequest(op);
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

            ((Friends)builder.WrapperObject!).AddFriendsWithoutConfirmation(op);
        }

        public static Model.ModelGetFriendsResponse? Execute(
            this GetListOfFriends.GetListOfFriendsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetListOfFriends op = builder.Build(
                namespace_,
                userId
            );

            return ((Friends)builder.WrapperObject!).GetListOfFriends(op);
        }

    }
}