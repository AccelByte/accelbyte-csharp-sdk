// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Ugc.Wrapper
{
    public class PublicFollow
    {
        private readonly AccelByteSDK _sdk;

        public PublicFollow(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetFollowedContent.GetFollowedContentBuilder GetFollowedContentOp
        {
            get { return Operation.GetFollowedContent.Builder.SetWrapperObject(this); }
        }
        public GetFollowedUsers.GetFollowedUsersBuilder GetFollowedUsersOp
        {
            get { return Operation.GetFollowedUsers.Builder.SetWrapperObject(this); }
        }
        public UpdateUserFollowStatus.UpdateUserFollowStatusBuilder UpdateUserFollowStatusOp
        {
            get { return Operation.UpdateUserFollowStatus.Builder.SetWrapperObject(this); }
        }
        public GetPublicFollowers.GetPublicFollowersBuilder GetPublicFollowersOp
        {
            get { return Operation.GetPublicFollowers.Builder.SetWrapperObject(this); }
        }
        public GetPublicFollowing.GetPublicFollowingBuilder GetPublicFollowingOp
        {
            get { return Operation.GetPublicFollowing.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelsPaginatedContentDownloadResponse? GetFollowedContent(GetFollowedContent input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetFollowedUsers(GetFollowedUsers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserFollowResponse? UpdateUserFollowStatus(UpdateUserFollowStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetPublicFollowers(GetPublicFollowers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsPaginatedCreatorOverviewResponse? GetPublicFollowing(GetPublicFollowing input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}