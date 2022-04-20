// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class SocialGameProfile_OpExts
    {
        public static List<Social.Model.GameProfileHeader>? Execute(
            this GetUserProfiles.GetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserProfiles op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).GetUserProfiles(op);
        }

        public static Social.Model.GameProfileInfo? Execute(
            this GetProfile.GetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            GetProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).GetProfile(op);
        }

        public static List<Social.Model.UserGameProfiles>? Execute(
            this PublicGetUserGameProfiles.PublicGetUserGameProfilesBuilder builder,
            string namespace_,
            List<string> userIds
        )
        {
            PublicGetUserGameProfiles op = builder.Build(
                namespace_,
                userIds
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicGetUserGameProfiles(op);
        }

        public static List<Social.Model.GameProfileHeader>? Execute(
            this PublicGetUserProfiles.PublicGetUserProfilesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfiles op = builder.Build(
                namespace_,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicGetUserProfiles(op);
        }

        public static void Execute(
            this PublicCreateProfile.PublicCreateProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateProfile op = builder.Build(
                namespace_,
                userId
            );

            ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicCreateProfile(op);
        }

        public static Social.Model.GameProfileInfo? Execute(
            this PublicGetProfile.PublicGetProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicGetProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicGetProfile(op);
        }

        public static Social.Model.GameProfileInfo? Execute(
            this PublicUpdateProfile.PublicUpdateProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicUpdateProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicUpdateProfile(op);
        }

        public static void Execute(
            this PublicDeleteProfile.PublicDeleteProfileBuilder builder,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicDeleteProfile op = builder.Build(
                namespace_,
                profileId,
                userId
            );

            ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicDeleteProfile(op);
        }

        public static Social.Model.Attribute? Execute(
            this PublicGetProfileAttribute.PublicGetProfileAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicGetProfileAttribute op = builder.Build(
                attributeName,
                namespace_,
                profileId,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicGetProfileAttribute(op);
        }

        public static Social.Model.GameProfileInfo? Execute(
            this PublicUpdateAttribute.PublicUpdateAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PublicUpdateAttribute op = builder.Build(
                attributeName,
                namespace_,
                profileId,
                userId
            );

            return ((Social.Wrapper.GameProfile)builder.WrapperObject!).PublicUpdateAttribute(op);
        }

    }
}