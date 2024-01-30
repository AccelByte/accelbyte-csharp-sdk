// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class IamUsersV4_OpExts
    {
        public static Iam.Model.AccountCreateTestUsersResponseV4? Execute(
            this AdminCreateTestUsersV4.AdminCreateTestUsersV4Builder builder,
            AccountCreateTestUsersRequestV4 body,
            string namespace_
        )
        {
            AdminCreateTestUsersV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminCreateTestUsersV4(op);
        }
        public static Iam.Model.AccountCreateUserResponseV4? Execute(
            this AdminCreateUserV4.AdminCreateUserV4Builder builder,
            AccountCreateUserRequestV4 body,
            string namespace_
        )
        {
            AdminCreateUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminCreateUserV4(op);
        }
        public static void Execute(
            this AdminBulkUpdateUserAccountTypeV4.AdminBulkUpdateUserAccountTypeV4Builder builder,
            ModelBulkAccountTypeUpdateRequestV4 body,
            string namespace_
        )
        {
            AdminBulkUpdateUserAccountTypeV4 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminBulkUpdateUserAccountTypeV4(op);
        }
        public static Iam.Model.ModelListValidUserIDResponseV4? Execute(
            this AdminBulkCheckValidUserIDV4.AdminBulkCheckValidUserIDV4Builder builder,
            ModelCheckValidUserIDRequestV4 body,
            string namespace_
        )
        {
            AdminBulkCheckValidUserIDV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminBulkCheckValidUserIDV4(op);
        }
        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminUpdateUserV4.AdminUpdateUserV4Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserV4 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminUpdateUserV4(op);
        }
        public static void Execute(
            this AdminUpdateUserEmailAddressV4.AdminUpdateUserEmailAddressV4Builder builder,
            ModelEmailUpdateRequestV4 body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserEmailAddressV4 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminUpdateUserEmailAddressV4(op);
        }
        public static void Execute(
            this AdminDisableUserMFAV4.AdminDisableUserMFAV4Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminDisableUserMFAV4 op = builder.Build(
                namespace_,
                userId
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminDisableUserMFAV4(op);
        }
        public static Iam.Model.ModelListUserRolesV4Response? Execute(
            this AdminListUserRolesV4.AdminListUserRolesV4Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminListUserRolesV4 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminListUserRolesV4(op);
        }
        public static Iam.Model.ModelListUserRolesV4Response? Execute(
            this AdminUpdateUserRoleV4.AdminUpdateUserRoleV4Builder builder,
            ModelAddUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            AdminUpdateUserRoleV4 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminUpdateUserRoleV4(op);
        }
        public static Iam.Model.ModelListUserRolesV4Response? Execute(
            this AdminAddUserRoleV4.AdminAddUserRoleV4Builder builder,
            ModelAddUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            AdminAddUserRoleV4 op = builder.Build(
                body,
                namespace_,
                userId
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminAddUserRoleV4(op);
        }
        public static void Execute(
            this AdminRemoveUserRoleV4.AdminRemoveUserRoleV4Builder builder,
            ModelRemoveUserRoleV4Request body,
            string namespace_,
            string userId
        )
        {
            AdminRemoveUserRoleV4 op = builder.Build(
                body,
                namespace_,
                userId
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminRemoveUserRoleV4(op);
        }
        public static Iam.Model.ModelInviteUserResponseV3? Execute(
            this AdminInviteUserNewV4.AdminInviteUserNewV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {
            AdminInviteUserNewV4 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminInviteUserNewV4(op);
        }
        public static Iam.Model.ModelUserResponseV3? Execute(
            this AdminUpdateMyUserV4.AdminUpdateMyUserV4Builder builder,
            ModelUserUpdateRequestV3 body
        )
        {
            AdminUpdateMyUserV4 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminUpdateMyUserV4(op);
        }
        public static void Execute(
            this AdminDisableMyAuthenticatorV4.AdminDisableMyAuthenticatorV4Builder builder
        )
        {
            AdminDisableMyAuthenticatorV4 op = builder.Build(
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminDisableMyAuthenticatorV4(op);
        }
        public static void Execute(
            this AdminEnableMyAuthenticatorV4.AdminEnableMyAuthenticatorV4Builder builder
        )
        {
            AdminEnableMyAuthenticatorV4 op = builder.Build(
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminEnableMyAuthenticatorV4(op);
        }
        public static Iam.Model.ModelAuthenticatorKeyResponseV4? Execute(
            this AdminGenerateMyAuthenticatorKeyV4.AdminGenerateMyAuthenticatorKeyV4Builder builder
        )
        {
            AdminGenerateMyAuthenticatorKeyV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminGenerateMyAuthenticatorKeyV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this AdminGetMyBackupCodesV4.AdminGetMyBackupCodesV4Builder builder
        )
        {
            AdminGetMyBackupCodesV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminGetMyBackupCodesV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this AdminGenerateMyBackupCodesV4.AdminGenerateMyBackupCodesV4Builder builder
        )
        {
            AdminGenerateMyBackupCodesV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminGenerateMyBackupCodesV4(op);
        }
        public static void Execute(
            this AdminDisableMyBackupCodesV4.AdminDisableMyBackupCodesV4Builder builder
        )
        {
            AdminDisableMyBackupCodesV4 op = builder.Build(
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminDisableMyBackupCodesV4(op);
        }
        public static Stream? Execute(
            this AdminDownloadMyBackupCodesV4.AdminDownloadMyBackupCodesV4Builder builder
        )
        {
            AdminDownloadMyBackupCodesV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminDownloadMyBackupCodesV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this AdminEnableMyBackupCodesV4.AdminEnableMyBackupCodesV4Builder builder
        )
        {
            AdminEnableMyBackupCodesV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminEnableMyBackupCodesV4(op);
        }
        public static void Execute(
            this AdminSendMyMFAEmailCodeV4.AdminSendMyMFAEmailCodeV4Builder builder
        )
        {
            AdminSendMyMFAEmailCodeV4 op = builder.Build(
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminSendMyMFAEmailCodeV4(op);
        }
        public static void Execute(
            this AdminDisableMyEmailV4.AdminDisableMyEmailV4Builder builder
        )
        {
            AdminDisableMyEmailV4 op = builder.Build(
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminDisableMyEmailV4(op);
        }
        public static void Execute(
            this AdminEnableMyEmailV4.AdminEnableMyEmailV4Builder builder,
            string code
        )
        {
            AdminEnableMyEmailV4 op = builder.Build(
                code
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminEnableMyEmailV4(op);
        }
        public static Iam.Model.ModelEnabledFactorsResponseV4? Execute(
            this AdminGetMyEnabledFactorsV4.AdminGetMyEnabledFactorsV4Builder builder
        )
        {
            AdminGetMyEnabledFactorsV4 op = builder.Build(
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminGetMyEnabledFactorsV4(op);
        }
        public static void Execute(
            this AdminMakeFactorMyDefaultV4.AdminMakeFactorMyDefaultV4Builder builder,
            string factor
        )
        {
            AdminMakeFactorMyDefaultV4 op = builder.Build(
                factor
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminMakeFactorMyDefaultV4(op);
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public static Iam.Model.ModelInviteUserResponseV3? Execute(
            this AdminInviteUserV4.AdminInviteUserV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {
            AdminInviteUserV4 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).AdminInviteUserV4(op);
        }
        public static Iam.Model.AccountCreateUserResponseV4? Execute(
            this PublicCreateTestUserV4.PublicCreateTestUserV4Builder builder,
            AccountCreateTestUserRequestV4 body,
            string namespace_
        )
        {
            PublicCreateTestUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicCreateTestUserV4(op);
        }
        public static Iam.Model.AccountCreateUserResponseV4? Execute(
            this PublicCreateUserV4.PublicCreateUserV4Builder builder,
            AccountCreateUserRequestV4 body,
            string namespace_
        )
        {
            PublicCreateUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicCreateUserV4(op);
        }
        public static Iam.Model.AccountCreateUserResponseV4? Execute(
            this CreateUserFromInvitationV4.CreateUserFromInvitationV4Builder builder,
            ModelUserCreateFromInvitationRequestV4 body,
            string invitationId,
            string namespace_
        )
        {
            CreateUserFromInvitationV4 op = builder.Build(
                body,
                invitationId,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).CreateUserFromInvitationV4(op);
        }
        public static Iam.Model.ModelUserResponseV3? Execute(
            this PublicUpdateUserV4.PublicUpdateUserV4Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PublicUpdateUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicUpdateUserV4(op);
        }
        public static void Execute(
            this PublicUpdateUserEmailAddressV4.PublicUpdateUserEmailAddressV4Builder builder,
            ModelEmailUpdateRequestV4 body,
            string namespace_
        )
        {
            PublicUpdateUserEmailAddressV4 op = builder.Build(
                body,
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicUpdateUserEmailAddressV4(op);
        }
        public static Iam.Model.AccountUserResponseV4? Execute(
            this PublicUpgradeHeadlessAccountWithVerificationCodeV4.PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder builder,
            AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountWithVerificationCodeV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicUpgradeHeadlessAccountWithVerificationCodeV4(op);
        }
        public static Iam.Model.AccountUserResponseV4? Execute(
            this PublicUpgradeHeadlessAccountV4.PublicUpgradeHeadlessAccountV4Builder builder,
            AccountUpgradeHeadlessAccountRequestV4 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountV4 op = builder.Build(
                body,
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicUpgradeHeadlessAccountV4(op);
        }
        public static void Execute(
            this PublicDisableMyAuthenticatorV4.PublicDisableMyAuthenticatorV4Builder builder,
            string namespace_
        )
        {
            PublicDisableMyAuthenticatorV4 op = builder.Build(
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicDisableMyAuthenticatorV4(op);
        }
        public static void Execute(
            this PublicEnableMyAuthenticatorV4.PublicEnableMyAuthenticatorV4Builder builder,
            string namespace_
        )
        {
            PublicEnableMyAuthenticatorV4 op = builder.Build(
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicEnableMyAuthenticatorV4(op);
        }
        public static Iam.Model.ModelAuthenticatorKeyResponseV4? Execute(
            this PublicGenerateMyAuthenticatorKeyV4.PublicGenerateMyAuthenticatorKeyV4Builder builder,
            string namespace_
        )
        {
            PublicGenerateMyAuthenticatorKeyV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicGenerateMyAuthenticatorKeyV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this PublicGetMyBackupCodesV4.PublicGetMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicGetMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicGetMyBackupCodesV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this PublicGenerateMyBackupCodesV4.PublicGenerateMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicGenerateMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicGenerateMyBackupCodesV4(op);
        }
        public static void Execute(
            this PublicDisableMyBackupCodesV4.PublicDisableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicDisableMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicDisableMyBackupCodesV4(op);
        }
        public static Stream? Execute(
            this PublicDownloadMyBackupCodesV4.PublicDownloadMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicDownloadMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicDownloadMyBackupCodesV4(op);
        }
        public static Iam.Model.ModelBackupCodesResponseV4? Execute(
            this PublicEnableMyBackupCodesV4.PublicEnableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicEnableMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicEnableMyBackupCodesV4(op);
        }
        public static void Execute(
            this PublicRemoveTrustedDeviceV4.PublicRemoveTrustedDeviceV4Builder builder,
            string namespace_,
            string deviceToken
        )
        {
            PublicRemoveTrustedDeviceV4 op = builder.Build(
                namespace_,
                deviceToken
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicRemoveTrustedDeviceV4(op);
        }
        public static void Execute(
            this PublicSendMyMFAEmailCodeV4.PublicSendMyMFAEmailCodeV4Builder builder,
            string namespace_
        )
        {
            PublicSendMyMFAEmailCodeV4 op = builder.Build(
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicSendMyMFAEmailCodeV4(op);
        }
        public static void Execute(
            this PublicDisableMyEmailV4.PublicDisableMyEmailV4Builder builder,
            string namespace_
        )
        {
            PublicDisableMyEmailV4 op = builder.Build(
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicDisableMyEmailV4(op);
        }
        public static void Execute(
            this PublicEnableMyEmailV4.PublicEnableMyEmailV4Builder builder,
            string code,
            string namespace_
        )
        {
            PublicEnableMyEmailV4 op = builder.Build(
                code,
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicEnableMyEmailV4(op);
        }
        public static Iam.Model.ModelEnabledFactorsResponseV4? Execute(
            this PublicGetMyEnabledFactorsV4.PublicGetMyEnabledFactorsV4Builder builder,
            string namespace_
        )
        {
            PublicGetMyEnabledFactorsV4 op = builder.Build(
                namespace_
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicGetMyEnabledFactorsV4(op);
        }
        public static void Execute(
            this PublicMakeFactorMyDefaultV4.PublicMakeFactorMyDefaultV4Builder builder,
            string factor,
            string namespace_
        )
        {
            PublicMakeFactorMyDefaultV4 op = builder.Build(
                factor,
                namespace_
            );

            ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicMakeFactorMyDefaultV4(op);
        }
        public static Iam.Model.ModelUserPublicInfoResponseV4? Execute(
            this PublicGetUserPublicInfoByUserIdV4.PublicGetUserPublicInfoByUserIdV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserPublicInfoByUserIdV4 op = builder.Build(
                namespace_,
                userId
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicGetUserPublicInfoByUserIdV4(op);
        }
        public static Iam.Model.ModelInviteUserResponseV3? Execute(
            this PublicInviteUserV4.PublicInviteUserV4Builder builder,
            ModelPublicInviteUserRequestV4 body
        )
        {
            PublicInviteUserV4 op = builder.Build(
                body
            );

            return ((Iam.Wrapper.UsersV4)builder.WrapperObject!).PublicInviteUserV4(op);
        }
    }
}