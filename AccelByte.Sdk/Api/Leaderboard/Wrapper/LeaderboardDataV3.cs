// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Leaderboard.Wrapper
{
    public class LeaderboardDataV3
    {
        private readonly AccelByteSDK _sdk;

        public LeaderboardDataV3(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetAllTimeLeaderboardRankingAdminV3.GetAllTimeLeaderboardRankingAdminV3Builder GetAllTimeLeaderboardRankingAdminV3Op
        {
            get { return Operation.GetAllTimeLeaderboardRankingAdminV3.Builder.SetWrapperObject(this); }
        }
        public GetCurrentCycleLeaderboardRankingAdminV3.GetCurrentCycleLeaderboardRankingAdminV3Builder GetCurrentCycleLeaderboardRankingAdminV3Op
        {
            get { return Operation.GetCurrentCycleLeaderboardRankingAdminV3.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingByLeaderboardCodeAdminV3.DeleteUserRankingByLeaderboardCodeAdminV3Builder DeleteUserRankingByLeaderboardCodeAdminV3Op
        {
            get { return Operation.DeleteUserRankingByLeaderboardCodeAdminV3.Builder.SetWrapperObject(this); }
        }
        public GetUserRankingAdminV3.GetUserRankingAdminV3Builder GetUserRankingAdminV3Op
        {
            get { return Operation.GetUserRankingAdminV3.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingAdminV3.DeleteUserRankingAdminV3Builder DeleteUserRankingAdminV3Op
        {
            get { return Operation.DeleteUserRankingAdminV3.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRankingsAdminV3.DeleteUserRankingsAdminV3Builder DeleteUserRankingsAdminV3Op
        {
            get { return Operation.DeleteUserRankingsAdminV3.Builder.SetWrapperObject(this); }
        }
        public GetAllTimeLeaderboardRankingPublicV3.GetAllTimeLeaderboardRankingPublicV3Builder GetAllTimeLeaderboardRankingPublicV3Op
        {
            get { return Operation.GetAllTimeLeaderboardRankingPublicV3.Builder.SetWrapperObject(this); }
        }
        public GetCurrentCycleLeaderboardRankingPublicV3.GetCurrentCycleLeaderboardRankingPublicV3Builder GetCurrentCycleLeaderboardRankingPublicV3Op
        {
            get { return Operation.GetCurrentCycleLeaderboardRankingPublicV3.Builder.SetWrapperObject(this); }
        }
        public BulkGetUsersRankingPublicV3.BulkGetUsersRankingPublicV3Builder BulkGetUsersRankingPublicV3Op
        {
            get { return Operation.BulkGetUsersRankingPublicV3.Builder.SetWrapperObject(this); }
        }
        public GetUserRankingPublicV3.GetUserRankingPublicV3Builder GetUserRankingPublicV3Op
        {
            get { return Operation.GetUserRankingPublicV3.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingAdminV3(GetAllTimeLeaderboardRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetAllTimeLeaderboardRankingAdminV3Async(GetAllTimeLeaderboardRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentCycleLeaderboardRankingAdminV3(GetCurrentCycleLeaderboardRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetCurrentCycleLeaderboardRankingAdminV3Async(GetCurrentCycleLeaderboardRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingByLeaderboardCodeAdminV3(DeleteUserRankingByLeaderboardCodeAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingByLeaderboardCodeAdminV3Async(DeleteUserRankingByLeaderboardCodeAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponseV3? GetUserRankingAdminV3(GetUserRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUserRankingResponseV3?> GetUserRankingAdminV3Async(GetUserRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingAdminV3(DeleteUserRankingAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingAdminV3Async(DeleteUserRankingAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRankingsAdminV3(DeleteUserRankingsAdminV3 input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task DeleteUserRankingsAdminV3Async(DeleteUserRankingsAdminV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetAllTimeLeaderboardRankingPublicV3(GetAllTimeLeaderboardRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetAllTimeLeaderboardRankingPublicV3Async(GetAllTimeLeaderboardRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetLeaderboardRankingResp? GetCurrentCycleLeaderboardRankingPublicV3(GetCurrentCycleLeaderboardRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsGetLeaderboardRankingResp?> GetCurrentCycleLeaderboardRankingPublicV3Async(GetCurrentCycleLeaderboardRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsBulkUserRankingResponseV3? BulkGetUsersRankingPublicV3(BulkGetUsersRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsBulkUserRankingResponseV3?> BulkGetUsersRankingPublicV3Async(BulkGetUsersRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsUserRankingResponseV3? GetUserRankingPublicV3(GetUserRankingPublicV3 input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.ModelsUserRankingResponseV3?> GetUserRankingPublicV3Async(GetUserRankingPublicV3 input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}