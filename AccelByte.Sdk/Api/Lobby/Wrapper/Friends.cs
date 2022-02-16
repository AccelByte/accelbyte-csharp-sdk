// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Friends {
        private readonly AccelByteSDK _sdk;

        public Friends(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
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
}