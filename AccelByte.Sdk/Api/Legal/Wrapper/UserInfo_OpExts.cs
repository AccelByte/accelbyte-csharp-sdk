// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;
using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class LegalUserInfo_OpExts
    {
        public static List<Legal.Model.RetrieveUserInfoCacheStatusResponse>? Execute(
            this GetUserInfoStatus.GetUserInfoStatusBuilder builder
        )
        {
            GetUserInfoStatus op = builder.Build(
            );

            return ((Legal.Wrapper.UserInfo)builder.WrapperObject!).GetUserInfoStatus(op);
        }

        public static void Execute(
            this SyncUserInfo.SyncUserInfoBuilder builder,
            string namespace_
        )
        {
            SyncUserInfo op = builder.Build(
                namespace_
            );

            ((Legal.Wrapper.UserInfo)builder.WrapperObject!).SyncUserInfo(op);
        }

        public static void Execute(
            this InvalidateUserInfoCache.InvalidateUserInfoCacheBuilder builder
        )
        {
            InvalidateUserInfoCache op = builder.Build(
            );

            ((Legal.Wrapper.UserInfo)builder.WrapperObject!).InvalidateUserInfoCache(op);
        }

    }
}