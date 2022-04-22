// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;
using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class UgcPublicFollow_OpExts
    {
        public static Ugc.Model.ModelsPaginatedContentDownloadResponse? Execute(
            this GetFollowedContent.GetFollowedContentBuilder builder,
            string namespace_
        )
        {
            GetFollowedContent op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicFollow)builder.WrapperObject!).GetFollowedContent(op);
        }

        public static Ugc.Model.ModelsPaginatedCreatorOverviewResponse? Execute(
            this GetFollowedUsers.GetFollowedUsersBuilder builder,
            string namespace_
        )
        {
            GetFollowedUsers op = builder.Build(
                namespace_
            );

            return ((Ugc.Wrapper.PublicFollow)builder.WrapperObject!).GetFollowedUsers(op);
        }

        public static Ugc.Model.ModelsUserFollowResponse? Execute(
            this UpdateUserFollowStatus.UpdateUserFollowStatusBuilder builder,
            ModelsUserFollowRequest body,
            string namespace_,
            string userId
        )
        {
            UpdateUserFollowStatus op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicFollow)builder.WrapperObject!).UpdateUserFollowStatus(op);
        }

        public static Ugc.Model.ModelsPaginatedCreatorOverviewResponse? Execute(
            this GetPublicFollowers.GetPublicFollowersBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPublicFollowers op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicFollow)builder.WrapperObject!).GetPublicFollowers(op);
        }

        public static Ugc.Model.ModelsPaginatedCreatorOverviewResponse? Execute(
            this GetPublicFollowing.GetPublicFollowingBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPublicFollowing op = builder.Build(
                namespace_,
                userId
            );

            return ((Ugc.Wrapper.PublicFollow)builder.WrapperObject!).GetPublicFollowing(op);
        }

    }
}