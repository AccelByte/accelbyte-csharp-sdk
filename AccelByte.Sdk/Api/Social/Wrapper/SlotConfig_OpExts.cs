// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialSlotConfig_OpExts
    {
        public static Social.Model.NamespaceSlotConfigInfo? Execute(
            this GetNamespaceSlotConfig.GetNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            GetNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.SlotConfig)builder.WrapperObject!).GetNamespaceSlotConfig(op);
        }

        public static Social.Model.NamespaceSlotConfigInfo? Execute(
            this UpdateNamespaceSlotConfig.UpdateNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            UpdateNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            return ((Social.Wrapper.SlotConfig)builder.WrapperObject!).UpdateNamespaceSlotConfig(op);
        }

        public static void Execute(
            this DeleteNamespaceSlotConfig.DeleteNamespaceSlotConfigBuilder builder,
            string namespace_
        )
        {
            DeleteNamespaceSlotConfig op = builder.Build(
                namespace_
            );

            ((Social.Wrapper.SlotConfig)builder.WrapperObject!).DeleteNamespaceSlotConfig(op);
        }

        public static Social.Model.UserSlotConfigInfo? Execute(
            this GetUserSlotConfig.GetUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.SlotConfig)builder.WrapperObject!).GetUserSlotConfig(op);
        }

        public static Social.Model.UserSlotConfigInfo? Execute(
            this UpdateUserSlotConfig.UpdateUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.SlotConfig)builder.WrapperObject!).UpdateUserSlotConfig(op);
        }

        public static void Execute(
            this DeleteUserSlotConfig.DeleteUserSlotConfigBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserSlotConfig op = builder.Build(
                namespace_,
                userId
            );

            ((Social.Wrapper.SlotConfig)builder.WrapperObject!).DeleteUserSlotConfig(op);
        }

    }
}