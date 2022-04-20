// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        
        public Model.ModelsGetHiddenUserResponse? GetHiddenUsersV2(GetHiddenUsersV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? GetUserVisibilityStatusV2(GetUserVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserLeaderboardVisibilityStatusV2(SetUserLeaderboardVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsGetUserVisibilityResponse? SetUserVisibilityStatusV2(SetUserVisibilityStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class UserVisibility_OperationExtensions
    {
        public static Model.ModelsGetHiddenUserResponse? Execute(
            this GetHiddenUsersV2.GetHiddenUsersV2Builder builder,
            string leaderboardCode,
            string namespace_
        )
        {
            GetHiddenUsersV2 op = builder.Build(
                leaderboardCode,
                namespace_
            );

            return ((UserVisibility)builder.WrapperObject!).GetHiddenUsersV2(op);
        }

        public static Model.ModelsGetUserVisibilityResponse? Execute(
            this GetUserVisibilityStatusV2.GetUserVisibilityStatusV2Builder builder,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            GetUserVisibilityStatusV2 op = builder.Build(
                leaderboardCode,
                namespace_,
                userId
            );

            return ((UserVisibility)builder.WrapperObject!).GetUserVisibilityStatusV2(op);
        }

        public static Model.ModelsGetUserVisibilityResponse? Execute(
            this SetUserLeaderboardVisibilityStatusV2.SetUserLeaderboardVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string leaderboardCode,
            string namespace_,
            string userId
        )
        {
            SetUserLeaderboardVisibilityStatusV2 op = builder.Build(
                body,
                leaderboardCode,
                namespace_,
                userId
            );

            return ((UserVisibility)builder.WrapperObject!).SetUserLeaderboardVisibilityStatusV2(op);
        }

        public static Model.ModelsGetUserVisibilityResponse? Execute(
            this SetUserVisibilityStatusV2.SetUserVisibilityStatusV2Builder builder,
            ModelsSetUserVisibilityRequest body,
            string namespace_,
            string userId
        )
        {
            SetUserVisibilityStatusV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((UserVisibility)builder.WrapperObject!).SetUserVisibilityStatusV2(op);
        }

    }
}