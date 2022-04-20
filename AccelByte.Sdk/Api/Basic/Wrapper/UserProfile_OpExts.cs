// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class BasicUserProfile_OpExts
    {
        public static List<Basic.Model.UserProfilePublicInfo>? Execute(
            this AdminGetUserProfilePublicInfoByIds.AdminGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_
        )
        {
            AdminGetUserProfilePublicInfoByIds op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).AdminGetUserProfilePublicInfoByIds(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this GetUserProfileInfo.GetUserProfileInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserProfileInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).GetUserProfileInfo(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this UpdateUserProfile.UpdateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdateUserProfile(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this DeleteUserProfile.DeleteUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).DeleteUserProfile(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetCustomAttributesInfo.GetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).GetCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this UpdateCustomAttributesPartially.UpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdateCustomAttributesPartially(op);
        }

        public static Dictionary<string, object>? Execute(
            this GetPrivateCustomAttributesInfo.GetPrivateCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPrivateCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).GetPrivateCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this UpdatePrivateCustomAttributesPartially.UpdatePrivateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdatePrivateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdatePrivateCustomAttributesPartially(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this UpdateUserProfileStatus.UpdateUserProfileStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            UpdateUserProfileStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdateUserProfileStatus(op);
        }

        public static List<Basic.Model.UserProfilePublicInfo>? Execute(
            this PublicGetUserProfilePublicInfoByIds.PublicGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            PublicGetUserProfilePublicInfoByIds op = builder.Build(
                namespace_,
                userIds
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicGetUserProfilePublicInfoByIds(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this GetMyProfileInfo.GetMyProfileInfoBuilder builder,
            string namespace_
        )
        {
            GetMyProfileInfo op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).GetMyProfileInfo(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this UpdateMyProfile.UpdateMyProfileBuilder builder,
            string namespace_
        )
        {
            UpdateMyProfile op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdateMyProfile(op);
        }

        public static Basic.Model.UserProfilePrivateInfo? Execute(
            this CreateMyProfile.CreateMyProfileBuilder builder,
            string namespace_
        )
        {
            CreateMyProfile op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).CreateMyProfile(op);
        }

        public static Basic.Model.UserZipCode? Execute(
            this GetMyZipCode.GetMyZipCodeBuilder builder,
            string namespace_
        )
        {
            GetMyZipCode op = builder.Build(
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).GetMyZipCode(op);
        }

        public static Basic.Model.UserZipCode? Execute(
            this UpdateMyZipCode.UpdateMyZipCodeBuilder builder,
            UserZipCodeUpdate userZipCodeUpdate,
            string namespace_
        )
        {
            UpdateMyZipCode op = builder.Build(
                userZipCodeUpdate,
                namespace_
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).UpdateMyZipCode(op);
        }

        public static Basic.Model.UserProfileInfo? Execute(
            this PublicGetUserProfileInfo.PublicGetUserProfileInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfileInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicGetUserProfileInfo(op);
        }

        public static Basic.Model.UserProfileInfo? Execute(
            this PublicUpdateUserProfile.PublicUpdateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicUpdateUserProfile(op);
        }

        public static Basic.Model.UserProfileInfo? Execute(
            this PublicCreateUserProfile.PublicCreateUserProfileBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicCreateUserProfile op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicCreateUserProfile(op);
        }

        public static Dictionary<string, object>? Execute(
            this PublicGetCustomAttributesInfo.PublicGetCustomAttributesInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetCustomAttributesInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicGetCustomAttributesInfo(op);
        }

        public static Dictionary<string, object>? Execute(
            this PublicUpdateCustomAttributesPartially.PublicUpdateCustomAttributesPartiallyBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateCustomAttributesPartially op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicUpdateCustomAttributesPartially(op);
        }

        public static Basic.Model.UserProfilePublicInfo? Execute(
            this PublicGetUserProfilePublicInfo.PublicGetUserProfilePublicInfoBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserProfilePublicInfo op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicGetUserProfilePublicInfo(op);
        }

        public static Basic.Model.UserProfileInfo? Execute(
            this PublicUpdateUserProfileStatus.PublicUpdateUserProfileStatusBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicUpdateUserProfileStatus op = builder.Build(
                namespace_,
                userId
            );

            return ((Basic.Wrapper.UserProfile)builder.WrapperObject!).PublicUpdateUserProfileStatus(op);
        }

    }
}