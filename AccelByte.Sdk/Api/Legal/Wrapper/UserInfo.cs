// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public SyncUserInfo.SyncUserInfoBuilder SyncUserInfoOp
        {
            get { return Operation.SyncUserInfo.Builder.SetWrapperObject(this); }
        }
        public InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder InvalidateUserInfoCacheOp
        {
            get { return Operation.InvalidateUserInfoCache.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public List<Model.RetrieveUserInfoCacheStatusResponse>? GetUserInfoStatus(GetUserInfoStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SyncUserInfo(SyncUserInfo input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void InvalidateUserInfoCache(InvalidateUserInfoCache input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class UserInfo_OperationExtensions
    {
        public static List<Model.RetrieveUserInfoCacheStatusResponse>? Execute(
            this GetUserInfoStatus.GetUserInfoStatusBuilder builder
        )
        {
            GetUserInfoStatus op = builder.Build(
            );

            return ((UserInfo)builder.WrapperObject!).GetUserInfoStatus(op);
        }

        public static void Execute(
            this SyncUserInfo.SyncUserInfoBuilder builder,
            string namespace_
        )
        {
            SyncUserInfo op = builder.Build(
                namespace_
            );

            ((UserInfo)builder.WrapperObject!).SyncUserInfo(op);
        }

        public static void Execute(
            this InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder builder
        )
        {
            InvalidateUserInfoCache op = builder.Build(
            );

            ((UserInfo)builder.WrapperObject!).InvalidateUserInfoCache(op);
        }

    }
}