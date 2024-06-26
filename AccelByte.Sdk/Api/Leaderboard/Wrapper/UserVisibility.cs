// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class UserVisibility
    {
        private readonly AccelByteSDK _sdk;

        public UserVisibility(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetHiddenUsersV2.GetHiddenUsersV2Builder GetHiddenUsersV2Op
        {
            get { return Operation.GetHiddenUsersV2.Builder.SetWrapperObject(this); }
        }
        public GetUserVisibilityStatusV2.GetUserVisibilityStatusV2Builder GetUserVisibilityStatusV2Op
        {
            get { return Operation.GetUserVisibilityStatusV2.Builder.SetWrapperObject(this); }
        }
        public SetUserLeaderboardVisibilityStatusV2.SetUserLeaderboardVisibilityStatusV2Builder SetUserLeaderboardVisibilityStatusV2Op
        {
            get { return Operation.SetUserLeaderboardVisibilityStatusV2.Builder.SetWrapperObject(this); }
        }
        public SetUserVisibilityStatusV2.SetUserVisibilityStatusV2Builder SetUserVisibilityStatusV2Op
        {
            get { return Operation.SetUserVisibilityStatusV2.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsGetHiddenUserResponse? GetHiddenUsersV2(GetHiddenUsersV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetHiddenUserResponse?> GetHiddenUsersV2Async(GetHiddenUsersV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? GetUserVisibilityStatusV2(GetUserVisibilityStatusV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> GetUserVisibilityStatusV2Async(GetUserVisibilityStatusV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserLeaderboardVisibilityStatusV2(SetUserLeaderboardVisibilityStatusV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> SetUserLeaderboardVisibilityStatusV2Async(SetUserLeaderboardVisibilityStatusV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserVisibilityStatusV2(SetUserVisibilityStatusV2 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetUserVisibilityResponse?> SetUserVisibilityStatusV2Async(SetUserVisibilityStatusV2 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}