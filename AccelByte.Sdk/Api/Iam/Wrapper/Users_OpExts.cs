// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamUsers_OpExts
    {
        public static Iam.Model.ModelUserCreateResponse? Execute(
            this CreateUser.CreateUserBuilder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            CreateUser op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).CreateUser(op);
        }

        public static Iam.Model.ModelGetAdminUsersResponse? Execute(
            this GetAdminUsersByRoleID.GetAdminUsersByRoleIDBuilder builder,
            string namespace_
        )
        {
            GetAdminUsersByRoleID op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetAdminUsersByRoleID(op);
        }

        public static Iam.Model.ModelPublicUserResponse? Execute(
            this GetUserByLoginID.GetUserByLoginIDBuilder builder,
            string namespace_
        )
        {
            GetUserByLoginID op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserByLoginID(op);
        }

        public static Iam.Model.ModelPublicUserResponse? Execute(
            this GetUserByPlatformUserID.GetUserByPlatformUserIDBuilder builder,
            string namespace_,
            string platformID,
            string platformUserID
        )
        {
            GetUserByPlatformUserID op = builder.Build(
                namespace_,
                platformID,
                platformUserID
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserByPlatformUserID(op);
        }

        public static void Execute(
            this ForgotPassword.ForgotPasswordBuilder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            ForgotPassword op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).ForgotPassword(op);
        }

        public static Iam.Model.ModelPublicUsersResponse? Execute(
            this GetUsersByLoginIds.GetUsersByLoginIdsBuilder builder,
            string namespace_
        )
        {
            GetUsersByLoginIds op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUsersByLoginIds(op);
        }

        public static void Execute(
            this ResetPassword.ResetPasswordBuilder builder,
            ModelResetPasswordRequest body,
            string namespace_
        )
        {
            ResetPassword op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).ResetPassword(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Iam.Model.ModelSearchUsersResponse? Execute(
            this SearchUser.SearchUserBuilder builder,
            string namespace_
        )
        {
            SearchUser op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).SearchUser(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this GetUserByUserID.GetUserByUserIDBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserByUserID op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserByUserID(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this UpdateUser.UpdateUserBuilder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            UpdateUser op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).UpdateUser(op);
        }

        public static void Execute(
            this DeleteUser.DeleteUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUser op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).DeleteUser(op);
        }

        public static Iam.Model.ModelUserBanResponse? Execute(
            this BanUser.BanUserBuilder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            BanUser op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).BanUser(op);
        }

        public static List<Iam.Model.ModelUserBanResponse>? Execute(
            this GetUserBanHistory.GetUserBanHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserBanHistory op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserBanHistory(op);
        }

        public static Iam.Model.ModelUserBanResponse? Execute(
            this DisableUserBan.DisableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            DisableUserBan op = builder.Build(
                banId,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).DisableUserBan(op);
        }

        public static Iam.Model.ModelUserBanResponse? Execute(
            this EnableUserBan.EnableUserBanBuilder builder,
            string banId,
            string namespace_,
            string userId
        )
        {
            EnableUserBan op = builder.Build(
                banId,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).EnableUserBan(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this ListCrossNamespaceAccountLink.ListCrossNamespaceAccountLinkBuilder builder,
            string linkingToken,
            string namespace_,
            string userId
        )
        {
            ListCrossNamespaceAccountLink op = builder.Build(
                linkingToken,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).ListCrossNamespaceAccountLink(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this DisableUser.DisableUserBuilder builder,
            ModelDisableUserRequest body,
            string namespace_,
            string userId
        )
        {
            DisableUser op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).DisableUser(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this EnableUser.EnableUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            EnableUser op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).EnableUser(op);
        }

        public static Iam.Model.ModelUserInformation? Execute(
            this GetUserInformation.GetUserInformationBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserInformation op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserInformation(op);
        }

        public static void Execute(
            this DeleteUserInformation.DeleteUserInformationBuilder builder,
            string namespace_,
            string userId
        )
        {
            DeleteUserInformation op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).DeleteUserInformation(op);
        }

        public static Iam.Model.ModelLoginHistoriesResponse? Execute(
            this GetUserLoginHistories.GetUserLoginHistoriesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserLoginHistories op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserLoginHistories(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static void Execute(
            this UpdatePassword.UpdatePasswordBuilder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            UpdatePassword op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).UpdatePassword(op);
        }

        public static void Execute(
            this SaveUserPermission.SaveUserPermissionBuilder builder,
            AccountcommonPermissions body,
            string namespace_,
            string userId
        )
        {
            SaveUserPermission op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).SaveUserPermission(op);
        }

        public static void Execute(
            this AddUserPermission.AddUserPermissionBuilder builder,
            ModelUpdatePermissionScheduleRequest body,
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            AddUserPermission op = builder.Build(
                body,
                action,
                namespace_,
                resource,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AddUserPermission(op);
        }

        public static void Execute(
            this DeleteUserPermission.DeleteUserPermissionBuilder builder,
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            DeleteUserPermission op = builder.Build(
                action,
                namespace_,
                resource,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).DeleteUserPermission(op);
        }

        public static List<Iam.Model.AccountcommonUserLinkedPlatform>? Execute(
            this GetUserPlatformAccounts.GetUserPlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserPlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserPlatformAccounts(op);
        }

        public static Iam.Model.ModelGetUserMapping? Execute(
            this GetUserMapping.GetUserMappingBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            GetUserMapping op = builder.Build(
                namespace_,
                targetNamespace,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserMapping(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Iam.Model.ModelGetUserJusticePlatformAccountResponse? Execute(
            this GetUserJusticePlatformAccount.GetUserJusticePlatformAccountBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            GetUserJusticePlatformAccount op = builder.Build(
                namespace_,
                targetNamespace,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserJusticePlatformAccount(op);
        }

        public static void Execute(
            this PlatformLink.PlatformLinkBuilder builder,
            string ticket,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PlatformLink op = builder.Build(
                ticket,
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PlatformLink(op);
        }

        public static void Execute(
            this PlatformUnlink.PlatformUnlinkBuilder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PlatformUnlink op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PlatformUnlink(op);
        }

        public static Iam.Model.ModelGetPublisherUserResponse? Execute(
            this GetPublisherUser.GetPublisherUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPublisherUser op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetPublisherUser(op);
        }

        public static void Execute(
            this SaveUserRoles.SaveUserRolesBuilder builder,
            List<string> body,
            string namespace_,
            string userId
        )
        {
            SaveUserRoles op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).SaveUserRoles(op);
        }

        public static void Execute(
            this AddUserRole.AddUserRoleBuilder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            AddUserRole op = builder.Build(
                namespace_,
                roleId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AddUserRole(op);
        }

        public static void Execute(
            this DeleteUserRole.DeleteUserRoleBuilder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            DeleteUserRole op = builder.Build(
                namespace_,
                roleId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).DeleteUserRole(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this UpgradeHeadlessAccount.UpgradeHeadlessAccountBuilder builder,
            ModelUpgradeHeadlessAccountRequest body,
            string namespace_,
            string userId
        )
        {
            UpgradeHeadlessAccount op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).UpgradeHeadlessAccount(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this UpgradeHeadlessAccountWithVerificationCode.UpgradeHeadlessAccountWithVerificationCodeBuilder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequest body,
            string namespace_,
            string userId
        )
        {
            UpgradeHeadlessAccountWithVerificationCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).UpgradeHeadlessAccountWithVerificationCode(op);
        }

        public static void Execute(
            this UserVerification.UserVerificationBuilder builder,
            ModelUserVerificationRequest body,
            string namespace_,
            string userId
        )
        {
            UserVerification op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).UserVerification(op);
        }

        public static void Execute(
            this SendVerificationCode.SendVerificationCodeBuilder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_,
            string userId
        )
        {
            SendVerificationCode op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).SendVerificationCode(op);
        }

        public static Iam.Model.ModelAgeRestrictionResponse? Execute(
            this AdminGetAgeRestrictionStatusV2.AdminGetAgeRestrictionStatusV2Builder builder,
            string namespace_
        )
        {
            AdminGetAgeRestrictionStatusV2 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetAgeRestrictionStatusV2(op);
        }

        public static Iam.Model.ModelAgeRestrictionResponse? Execute(
            this AdminUpdateAgeRestrictionConfigV2.AdminUpdateAgeRestrictionConfigV2Builder builder,
            ModelAgeRestrictionRequest body,
            string namespace_
        )
        {
            AdminUpdateAgeRestrictionConfigV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateAgeRestrictionConfigV2(op);
        }

        public static List<Iam.Model.AccountcommonCountryAgeRestriction>? Execute(
            this GetListCountryAgeRestriction.GetListCountryAgeRestrictionBuilder builder,
            string namespace_
        )
        {
            GetListCountryAgeRestriction op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetListCountryAgeRestriction(op);
        }

        public static Iam.Model.ModelCountry? Execute(
            this UpdateCountryAgeRestriction.UpdateCountryAgeRestrictionBuilder builder,
            ModelCountryAgeRestrictionRequest body,
            string countryCode,
            string namespace_
        )
        {
            UpdateCountryAgeRestriction op = builder.Build(
                body,
                countryCode,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).UpdateCountryAgeRestriction(op);
        }

        public static Iam.Model.ModelSearchUsersByPlatformIDResponse? Execute(
            this AdminSearchUsersV2.AdminSearchUsersV2Builder builder,
            string namespace_,
            string platformId
        )
        {
            AdminSearchUsersV2 op = builder.Build(
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminSearchUsersV2(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this AdminGetUserByUserIdV2.AdminGetUserByUserIdV2Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserByUserIdV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserByUserIdV2(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this AdminUpdateUserV2.AdminUpdateUserV2Builder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserV2(op);
        }

        public static Iam.Model.ModelUserBanResponse? Execute(
            this AdminBanUserV2.AdminBanUserV2Builder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            AdminBanUserV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminBanUserV2(op);
        }

        public static List<Iam.Model.ModelUserBanResponse>? Execute(
            this AdminGetUserBanV2.AdminGetUserBanV2Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserBanV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserBanV2(op);
        }

        public static void Execute(
            this AdminDisableUserV2.AdminDisableUserV2Builder builder,
            ModelDisableUserRequest body,
            string namespace_,
            string userId
        )
        {
            AdminDisableUserV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDisableUserV2(op);
        }

        public static void Execute(
            this AdminEnableUserV2.AdminEnableUserV2Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminEnableUserV2 op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminEnableUserV2(op);
        }

        public static void Execute(
            this AdminResetPasswordV2.AdminResetPasswordV2Builder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            AdminResetPasswordV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminResetPasswordV2(op);
        }

        public static void Execute(
            this AdminDeletePlatformLinkV2.AdminDeletePlatformLinkV2Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            AdminDeletePlatformLinkV2 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeletePlatformLinkV2(op);
        }

        public static void Execute(
            this AdminPutUserRolesV2.AdminPutUserRolesV2Builder builder,
            List<string> body,
            string namespace_,
            string userId
        )
        {
            AdminPutUserRolesV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminPutUserRolesV2(op);
        }

        public static void Execute(
            this AdminCreateUserRolesV2.AdminCreateUserRolesV2Builder builder,
            List<string> body,
            string namespace_,
            string userId
        )
        {
            AdminCreateUserRolesV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminCreateUserRolesV2(op);
        }

        public static List<Iam.Model.AccountcommonCountryAgeRestriction>? Execute(
            this PublicGetCountryAgeRestriction.PublicGetCountryAgeRestrictionBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            PublicGetCountryAgeRestriction op = builder.Build(
                countryCode,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetCountryAgeRestriction(op);
        }

        public static Iam.Model.ModelUserCreateResponse? Execute(
            this PublicCreateUserV2.PublicCreateUserV2Builder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            PublicCreateUserV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicCreateUserV2(op);
        }

        public static void Execute(
            this PublicForgotPasswordV2.PublicForgotPasswordV2Builder builder,
            ModelSendVerificationCodeRequest body,
            string namespace_
        )
        {
            PublicForgotPasswordV2 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicForgotPasswordV2(op);
        }

        public static void Execute(
            this PublicResetPasswordV2.PublicResetPasswordV2Builder builder,
            ModelResetPasswordRequest body,
            string namespace_
        )
        {
            PublicResetPasswordV2 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicResetPasswordV2(op);
        }

        public static Iam.Model.ModelUserResponse? Execute(
            this PublicGetUserByUserIDV2.PublicGetUserByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserByUserIDV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserByUserIDV2(op);
        }

        public static List<Iam.Model.ModelUserResponse>? Execute(
            this PublicUpdateUserV2.PublicUpdateUserV2Builder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PublicUpdateUserV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUpdateUserV2(op);
        }

        public static List<Iam.Model.ModelUserBanResponse>? Execute(
            this PublicGetUserBan.PublicGetUserBanBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserBan op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserBan(op);
        }

        public static void Execute(
            this PublicUpdatePasswordV2.PublicUpdatePasswordV2Builder builder,
            ModelUserPasswordUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PublicUpdatePasswordV2 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUpdatePasswordV2(op);
        }

        public static List<Iam.Model.ModelGetUserMapping>? Execute(
            this GetListJusticePlatformAccounts.GetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetListJusticePlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetListJusticePlatformAccounts(op);
        }

        public static void Execute(
            this PublicPlatformLinkV2.PublicPlatformLinkV2Builder builder,
            string ticket,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PublicPlatformLinkV2 op = builder.Build(
                ticket,
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicPlatformLinkV2(op);
        }

        public static void Execute(
            this PublicDeletePlatformLinkV2.PublicDeletePlatformLinkV2Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PublicDeletePlatformLinkV2 op = builder.Build(
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicDeletePlatformLinkV2(op);
        }

        public static Iam.Model.ModelGetUsersResponseWithPaginationV3? Execute(
            this ListAdminsV3.ListAdminsV3Builder builder,
            string namespace_
        )
        {
            ListAdminsV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).ListAdminsV3(op);
        }

        public static Iam.Model.ModelAgeRestrictionResponseV3? Execute(
            this AdminGetAgeRestrictionStatusV3.AdminGetAgeRestrictionStatusV3Builder builder,
            string namespace_
        )
        {
            AdminGetAgeRestrictionStatusV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetAgeRestrictionStatusV3(op);
        }

        public static Iam.Model.ModelAgeRestrictionResponseV3? Execute(
            this AdminUpdateAgeRestrictionConfigV3.AdminUpdateAgeRestrictionConfigV3Builder builder,
            ModelAgeRestrictionRequestV3 body,
            string namespace_
        )
        {
            AdminUpdateAgeRestrictionConfigV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateAgeRestrictionConfigV3(op);
        }

        public static List<Iam.Model.ModelCountryV3Response>? Execute(
            this AdminGetListCountryAgeRestrictionV3.AdminGetListCountryAgeRestrictionV3Builder builder,
            string namespace_
        )
        {
            AdminGetListCountryAgeRestrictionV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetListCountryAgeRestrictionV3(op);
        }

        public static Iam.Model.ModelCountryV3Response? Execute(
            this AdminUpdateCountryAgeRestrictionV3.AdminUpdateCountryAgeRestrictionV3Builder builder,
            ModelCountryAgeRestrictionV3Request body,
            string countryCode,
            string namespace_
        )
        {
            AdminUpdateCountryAgeRestrictionV3 op = builder.Build(
                body,
                countryCode,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateCountryAgeRestrictionV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminGetUserByPlatformUserIDV3.AdminGetUserByPlatformUserIDV3Builder builder,
            string namespace_,
            string platformId,
            string platformUserId
        )
        {
            AdminGetUserByPlatformUserIDV3 op = builder.Build(
                namespace_,
                platformId,
                platformUserId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserByPlatformUserIDV3(op);
        }

        public static Iam.Model.ModelGetUsersResponseWithPaginationV3? Execute(
            this GetAdminUsersByRoleIdV3.GetAdminUsersByRoleIdV3Builder builder,
            string namespace_,
            string roleId
        )
        {
            GetAdminUsersByRoleIdV3 op = builder.Build(
                namespace_,
                roleId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetAdminUsersByRoleIdV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminGetUserByEmailAddressV3.AdminGetUserByEmailAddressV3Builder builder,
            string namespace_
        )
        {
            AdminGetUserByEmailAddressV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserByEmailAddressV3(op);
        }

        public static Iam.Model.ModelListUserInformationResult? Execute(
            this AdminListUserIDByUserIDsV3.AdminListUserIDByUserIDsV3Builder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            AdminListUserIDByUserIDsV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminListUserIDByUserIDsV3(op);
        }

        public static Iam.Model.ModelInviteUserResponseV3? Execute(
            this AdminInviteUserV3.AdminInviteUserV3Builder builder,
            ModelInviteUserRequestV3 body,
            string namespace_
        )
        {
            AdminInviteUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminInviteUserV3(op);
        }

        public static Iam.Model.AccountcommonListUsersWithPlatformAccountsResponse? Execute(
            this AdminListUsersV3.AdminListUsersV3Builder builder,
            string namespace_
        )
        {
            AdminListUsersV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminListUsersV3(op);
        }

        public static Iam.Model.ModelSearchUsersResponseWithPaginationV3? Execute(
            this AdminSearchUserV3.AdminSearchUserV3Builder builder,
            string namespace_
        )
        {
            AdminSearchUserV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminSearchUserV3(op);
        }

        public static Iam.Model.ModelListUserResponseV3? Execute(
            this AdminGetBulkUserByEmailAddressV3.AdminGetBulkUserByEmailAddressV3Builder builder,
            ModelListEmailAddressRequest body,
            string namespace_
        )
        {
            AdminGetBulkUserByEmailAddressV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetBulkUserByEmailAddressV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminGetUserByUserIdV3.AdminGetUserByUserIdV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserByUserIdV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserByUserIdV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminUpdateUserV3.AdminUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserV3(op);
        }

        public static Iam.Model.ModelGetUserBanV3Response? Execute(
            this AdminGetUserBanV3.AdminGetUserBanV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserBanV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserBanV3(op);
        }

        public static Iam.Model.ModelUserBanResponseV3? Execute(
            this AdminBanUserV3.AdminBanUserV3Builder builder,
            ModelBanCreateRequest body,
            string namespace_,
            string userId
        )
        {
            AdminBanUserV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminBanUserV3(op);
        }

        public static Iam.Model.ModelUserBanResponseV3? Execute(
            this AdminUpdateUserBanV3.AdminUpdateUserBanV3Builder builder,
            ModelBanUpdateRequest body,
            string banId,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserBanV3 op = builder.Build(
                body,
                banId,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserBanV3(op);
        }

        public static void Execute(
            this AdminSendVerificationCodeV3.AdminSendVerificationCodeV3Builder builder,
            ModelSendVerificationCodeRequestV3 body,
            string namespace_,
            string userId
        )
        {
            AdminSendVerificationCodeV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminSendVerificationCodeV3(op);
        }

        public static void Execute(
            this AdminVerifyAccountV3.AdminVerifyAccountV3Builder builder,
            ModelUserVerificationRequest body,
            string namespace_,
            string userId
        )
        {
            AdminVerifyAccountV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminVerifyAccountV3(op);
        }

        public static Iam.Model.ModelVerificationCodeResponse? Execute(
            this GetUserVerificationCode.GetUserVerificationCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserVerificationCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetUserVerificationCode(op);
        }

        public static Iam.Model.ModelUserDeletionStatusResponse? Execute(
            this AdminGetUserDeletionStatusV3.AdminGetUserDeletionStatusV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserDeletionStatusV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserDeletionStatusV3(op);
        }

        public static void Execute(
            this AdminUpdateUserDeletionStatusV3.AdminUpdateUserDeletionStatusV3Builder builder,
            ModelUpdateUserDeletionStatusRequest body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserDeletionStatusV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserDeletionStatusV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminUpgradeHeadlessAccountV3.AdminUpgradeHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
            string namespace_,
            string userId
        )
        {
            AdminUpgradeHeadlessAccountV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpgradeHeadlessAccountV3(op);
        }

        public static void Execute(
            this AdminDeleteUserInformationV3.AdminDeleteUserInformationV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminDeleteUserInformationV3 op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeleteUserInformationV3(op);
        }

        public static Iam.Model.ModelLoginHistoriesResponse? Execute(
            this AdminGetUserLoginHistoriesV3.AdminGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserLoginHistoriesV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserLoginHistoriesV3(op);
        }

        public static void Execute(
            this AdminUpdateUserPermissionV3.AdminUpdateUserPermissionV3Builder builder,
            AccountcommonPermissions body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserPermissionV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserPermissionV3(op);
        }

        public static void Execute(
            this AdminAddUserPermissionsV3.AdminAddUserPermissionsV3Builder builder,
            AccountcommonPermissions body,
            string namespace_,
            string userId
        )
        {
            AdminAddUserPermissionsV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminAddUserPermissionsV3(op);
        }

        public static void Execute(
            this AdminDeleteUserPermissionBulkV3.AdminDeleteUserPermissionBulkV3Builder builder,
            List<ModelPermissionDeleteRequest> body,
            string namespace_,
            string userId
        )
        {
            AdminDeleteUserPermissionBulkV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeleteUserPermissionBulkV3(op);
        }

        public static void Execute(
            this AdminDeleteUserPermissionV3.AdminDeleteUserPermissionV3Builder builder,
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            AdminDeleteUserPermissionV3 op = builder.Build(
                action,
                namespace_,
                resource,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeleteUserPermissionV3(op);
        }

        public static Iam.Model.AccountcommonUserLinkedPlatformsResponseV3? Execute(
            this AdminGetUserPlatformAccountsV3.AdminGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserPlatformAccountsV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetUserPlatformAccountsV3(op);
        }

        public static List<Iam.Model.ModelGetUserMapping>? Execute(
            this AdminGetListJusticePlatformAccounts.AdminGetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetListJusticePlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetListJusticePlatformAccounts(op);
        }

        public static Iam.Model.ModelCreateJusticeUserResponse? Execute(
            this AdminCreateJusticeUser.AdminCreateJusticeUserBuilder builder,
            string namespace_,
            string targetNamespace,
            string userId
        )
        {
            AdminCreateJusticeUser op = builder.Build(
                namespace_,
                targetNamespace,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminCreateJusticeUser(op);
        }

        public static void Execute(
            this AdminLinkPlatformAccount.AdminLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
            string namespace_,
            string userId
        )
        {
            AdminLinkPlatformAccount op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminLinkPlatformAccount(op);
        }

        public static void Execute(
            this AdminPlatformUnlinkV3.AdminPlatformUnlinkV3Builder builder,
            ModelUnlinkUserPlatformRequest body,
            string namespace_,
            string platformId,
            string userId
        )
        {
            AdminPlatformUnlinkV3 op = builder.Build(
                body,
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminPlatformUnlinkV3(op);
        }

        public static void Execute(
            this AdminPlatformLinkV3.AdminPlatformLinkV3Builder builder,
            string ticket,
            string namespace_,
            string platformId,
            string userId
        )
        {
            AdminPlatformLinkV3 op = builder.Build(
                ticket,
                namespace_,
                platformId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminPlatformLinkV3(op);
        }

        public static void Execute(
            this AdminDeleteUserRolesV3.AdminDeleteUserRolesV3Builder builder,
            List<string> body,
            string namespace_,
            string userId
        )
        {
            AdminDeleteUserRolesV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeleteUserRolesV3(op);
        }

        public static void Execute(
            this AdminSaveUserRoleV3.AdminSaveUserRoleV3Builder builder,
            List<ModelNamespaceRoleRequest> body,
            string namespace_,
            string userId
        )
        {
            AdminSaveUserRoleV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminSaveUserRoleV3(op);
        }

        public static void Execute(
            this AdminAddUserRoleV3.AdminAddUserRoleV3Builder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            AdminAddUserRoleV3 op = builder.Build(
                namespace_,
                roleId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminAddUserRoleV3(op);
        }

        public static void Execute(
            this AdminDeleteUserRoleV3.AdminDeleteUserRoleV3Builder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            AdminDeleteUserRoleV3 op = builder.Build(
                namespace_,
                roleId,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminDeleteUserRoleV3(op);
        }

        public static void Execute(
            this AdminUpdateUserStatusV3.AdminUpdateUserStatusV3Builder builder,
            ModelUpdateUserStatusRequest body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserStatusV3 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminUpdateUserStatusV3(op);
        }

        public static void Execute(
            this AdminVerifyUserWithoutVerificationCodeV3.AdminVerifyUserWithoutVerificationCodeV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminVerifyUserWithoutVerificationCodeV3 op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).AdminVerifyUserWithoutVerificationCodeV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminGetMyUserV3.AdminGetMyUserV3Builder builder
        )
        {
            AdminGetMyUserV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).AdminGetMyUserV3(op);
        }

        public static Iam.Model.AccountcommonUserPlatforms? Execute(
            this PublicListUserIDByPlatformUserIDsV3.PublicListUserIDByPlatformUserIDsV3Builder builder,
            ModelPlatformUserIDRequest body,
            string namespace_,
            string platformId
        )
        {
            PublicListUserIDByPlatformUserIDsV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicListUserIDByPlatformUserIDsV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this PublicGetUserByPlatformUserIDV3.PublicGetUserByPlatformUserIDV3Builder builder,
            string namespace_,
            string platformId,
            string platformUserId
        )
        {
            PublicGetUserByPlatformUserIDV3 op = builder.Build(
                namespace_,
                platformId,
                platformUserId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserByPlatformUserIDV3(op);
        }

        public static Iam.Model.ModelLinkRequest? Execute(
            this PublicGetAsyncStatus.PublicGetAsyncStatusBuilder builder,
            string namespace_,
            string requestId
        )
        {
            PublicGetAsyncStatus op = builder.Build(
                namespace_,
                requestId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetAsyncStatus(op);
        }

        public static Iam.Model.ModelPublicUserInformationResponseV3? Execute(
            this PublicSearchUserV3.PublicSearchUserV3Builder builder,
            string namespace_
        )
        {
            PublicSearchUserV3 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicSearchUserV3(op);
        }

        public static Iam.Model.ModelUserCreateResponseV3? Execute(
            this PublicCreateUserV3.PublicCreateUserV3Builder builder,
            ModelUserCreateRequestV3 body,
            string namespace_
        )
        {
            PublicCreateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicCreateUserV3(op);
        }

        public static void Execute(
            this CheckUserAvailability.CheckUserAvailabilityBuilder builder,
            string namespace_,
            string field,
            string query
        )
        {
            CheckUserAvailability op = builder.Build(
                namespace_,
                field,
                query
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).CheckUserAvailability(op);
        }

        public static Iam.Model.ModelListBulkUserResponse? Execute(
            this PublicBulkGetUsers.PublicBulkGetUsersBuilder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            PublicBulkGetUsers op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicBulkGetUsers(op);
        }

        public static void Execute(
            this PublicSendRegistrationCode.PublicSendRegistrationCodeBuilder builder,
            ModelSendRegisterVerificationCodeRequest body,
            string namespace_
        )
        {
            PublicSendRegistrationCode op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicSendRegistrationCode(op);
        }

        public static void Execute(
            this PublicVerifyRegistrationCode.PublicVerifyRegistrationCodeBuilder builder,
            ModelVerifyRegistrationCode body,
            string namespace_
        )
        {
            PublicVerifyRegistrationCode op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicVerifyRegistrationCode(op);
        }

        public static void Execute(
            this PublicForgotPasswordV3.PublicForgotPasswordV3Builder builder,
            ModelForgotPasswordRequestV3 body,
            string namespace_
        )
        {
            PublicForgotPasswordV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicForgotPasswordV3(op);
        }

        public static Iam.Model.ModelUserInvitationV3? Execute(
            this GetAdminInvitationV3.GetAdminInvitationV3Builder builder,
            string invitationId,
            string namespace_
        )
        {
            GetAdminInvitationV3 op = builder.Build(
                invitationId,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).GetAdminInvitationV3(op);
        }

        public static Iam.Model.ModelUserCreateResponseV3? Execute(
            this CreateUserFromInvitationV3.CreateUserFromInvitationV3Builder builder,
            ModelUserCreateFromInvitationRequestV3 body,
            string invitationId,
            string namespace_
        )
        {
            CreateUserFromInvitationV3 op = builder.Build(
                body,
                invitationId,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).CreateUserFromInvitationV3(op);
        }

        public static List<Iam.Model.ModelUserResponseV3>? Execute(
            this UpdateUserV3.UpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            UpdateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).UpdateUserV3(op);
        }

        public static List<Iam.Model.ModelUserResponseV3>? Execute(
            this PublicUpdateUserV3.PublicUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PublicUpdateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUpdateUserV3(op);
        }

        public static void Execute(
            this PublicSendVerificationCodeV3.PublicSendVerificationCodeV3Builder builder,
            ModelSendVerificationCodeRequestV3 body,
            string namespace_
        )
        {
            PublicSendVerificationCodeV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicSendVerificationCodeV3(op);
        }

        public static void Execute(
            this PublicUserVerificationV3.PublicUserVerificationV3Builder builder,
            ModelUserVerificationRequestV3 body,
            string namespace_
        )
        {
            PublicUserVerificationV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUserVerificationV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this PublicUpgradeHeadlessAccountV3.PublicUpgradeHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUpgradeHeadlessAccountV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this PublicVerifyHeadlessAccountV3.PublicVerifyHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountV3Request body,
            string namespace_
        )
        {
            PublicVerifyHeadlessAccountV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicVerifyHeadlessAccountV3(op);
        }

        public static void Execute(
            this PublicUpdatePasswordV3.PublicUpdatePasswordV3Builder builder,
            ModelUserPasswordUpdateV3Request body,
            string namespace_
        )
        {
            PublicUpdatePasswordV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicUpdatePasswordV3(op);
        }

        public static Iam.Model.ModelCreateJusticeUserResponse? Execute(
            this PublicCreateJusticeUser.PublicCreateJusticeUserBuilder builder,
            string namespace_,
            string targetNamespace
        )
        {
            PublicCreateJusticeUser op = builder.Build(
                namespace_,
                targetNamespace
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicCreateJusticeUser(op);
        }

        public static void Execute(
            this PublicPlatformLinkV3.PublicPlatformLinkV3Builder builder,
            string ticket,
            string namespace_,
            string platformId
        )
        {
            PublicPlatformLinkV3 op = builder.Build(
                ticket,
                namespace_,
                platformId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicPlatformLinkV3(op);
        }

        public static void Execute(
            this PublicPlatformUnlinkV3.PublicPlatformUnlinkV3Builder builder,
            ModelUnlinkUserPlatformRequest body,
            string namespace_,
            string platformId
        )
        {
            PublicPlatformUnlinkV3 op = builder.Build(
                body,
                namespace_,
                platformId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicPlatformUnlinkV3(op);
        }

        public static Iam.Model.ModelWebLinkingResponse? Execute(
            this PublicWebLinkPlatform.PublicWebLinkPlatformBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PublicWebLinkPlatform op = builder.Build(
                namespace_,
                platformId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicWebLinkPlatform(op);
        }

        public static string Execute(
            this PublicWebLinkPlatformEstablish.PublicWebLinkPlatformEstablishBuilder builder,
            string namespace_,
            string platformId,
            string state
        )
        {
            PublicWebLinkPlatformEstablish op = builder.Build(
                namespace_,
                platformId,
                state
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicWebLinkPlatformEstablish(op);
        }

        public static void Execute(
            this ResetPasswordV3.ResetPasswordV3Builder builder,
            ModelResetPasswordRequestV3 body,
            string namespace_
        )
        {
            ResetPasswordV3 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).ResetPasswordV3(op);
        }

        public static Iam.Model.ModelPublicUserResponseV3? Execute(
            this PublicGetUserByUserIdV3.PublicGetUserByUserIdV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserByUserIdV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserByUserIdV3(op);
        }

        public static Iam.Model.ModelGetUserBanV3Response? Execute(
            this PublicGetUserBanHistoryV3.PublicGetUserBanHistoryV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserBanHistoryV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserBanHistoryV3(op);
        }

        public static Iam.Model.ModelLoginHistoriesResponse? Execute(
            this PublicGetUserLoginHistoriesV3.PublicGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserLoginHistoriesV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserLoginHistoriesV3(op);
        }

        public static Iam.Model.AccountcommonUserLinkedPlatformsResponseV3? Execute(
            this PublicGetUserPlatformAccountsV3.PublicGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserPlatformAccountsV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetUserPlatformAccountsV3(op);
        }

        public static void Execute(
            this PublicLinkPlatformAccount.PublicLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
            string namespace_,
            string userId
        )
        {
            PublicLinkPlatformAccount op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicLinkPlatformAccount(op);
        }

        public static void Execute(
            this PublicValidateUserByUserIDAndPasswordV3.PublicValidateUserByUserIDAndPasswordV3Builder builder,
            string password,
            string namespace_,
            string userId
        )
        {
            PublicValidateUserByUserIDAndPasswordV3 op = builder.Build(
                password,
                namespace_,
                userId
            );

            ((Iam.Wrapper.Users)builder.WrapperObject!).PublicValidateUserByUserIDAndPasswordV3(op);
        }

        public static Iam.Model.ModelUserResponseV3? Execute(
            this PublicGetMyUserV3.PublicGetMyUserV3Builder builder
        )
        {
            PublicGetMyUserV3 op = builder.Build(
            );

            return ((Iam.Wrapper.Users)builder.WrapperObject!).PublicGetMyUserV3(op);
        }

    }
}