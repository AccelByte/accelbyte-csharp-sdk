// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Legal.Wrapper
{
    public class UserInfo
    {
        private readonly AccelByteSDK _sdk;

        public UserInfo(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public GetUserInfoStatus.GetUserInfoStatusBuilder GetUserInfoStatusOp
        {
            get { return Operation.GetUserInfoStatus.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public SyncUserInfo.SyncUserInfoBuilder SyncUserInfoOp
        {
            get { return Operation.SyncUserInfo.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder InvalidateUserInfoCacheOp
        {
            get { return Operation.InvalidateUserInfoCache.Builder.SetWrapperObject(this); }
        }
        #endregion

        public List<Model.RetrieveUserInfoCacheStatusResponse>? GetUserInfoStatus(GetUserInfoStatus input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<List<Model.RetrieveUserInfoCacheStatusResponse>?> GetUserInfoStatusAsync(GetUserInfoStatus input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void SyncUserInfo(SyncUserInfo input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task SyncUserInfoAsync(SyncUserInfo input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public void InvalidateUserInfoCache(InvalidateUserInfoCache input)
        {
            var response = _sdk.RunRequest(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task InvalidateUserInfoCacheAsync(InvalidateUserInfoCache input)
        {
            var response = await _sdk.RunRequestAsync(input);
            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
    }
}