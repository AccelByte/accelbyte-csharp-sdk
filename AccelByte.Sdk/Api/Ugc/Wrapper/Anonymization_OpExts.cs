// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcAnonymization_OpExts
    {
        public static void Execute(
            this AdminDeleteAllUserChannels.AdminDeleteAllUserChannelsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserChannels op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).AdminDeleteAllUserChannels(op);
        }

        public static void Execute(
            this AdminDeleteAllUserContents.AdminDeleteAllUserContentsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserContents op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).AdminDeleteAllUserContents(op);
        }

        public static void Execute(
            this AdminDeleteAllUserGroup.AdminDeleteAllUserGroupBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserGroup op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).AdminDeleteAllUserGroup(op);
        }

        public static void Execute(
            this AdminDeleteAllUserStates.AdminDeleteAllUserStatesBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteAllUserStates op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).AdminDeleteAllUserStates(op);
        }

        public static void Execute(
            this DeleteAllUserChannel.DeleteAllUserChannelBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserChannel op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).DeleteAllUserChannel(op);
        }

        public static void Execute(
            this DeleteAllUserContents.DeleteAllUserContentsBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserContents op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).DeleteAllUserContents(op);
        }

        public static void Execute(
            this DeleteAllUserGroup.DeleteAllUserGroupBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserGroup op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).DeleteAllUserGroup(op);
        }

        public static void Execute(
            this DeleteAllUserStates.DeleteAllUserStatesBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteAllUserStates op = builder.Build(
                namespace_,
                userId
            );

            ((Ugc.Wrapper.Anonymization)builder.WrapperObject!).DeleteAllUserStates(op);
        }

    }
}