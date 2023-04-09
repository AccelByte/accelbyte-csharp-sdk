// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class UsersV4
    {
        private readonly AccelByteSDK _sdk;

        public UsersV4(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public AdminCreateTestUsersV4.AdminCreateTestUsersV4Builder AdminCreateTestUsersV4Op
        {
            get { return Operation.AdminCreateTestUsersV4.Builder.SetWrapperObject(this); }
        }
        public AdminBulkCheckValidUserIDV4.AdminBulkCheckValidUserIDV4Builder AdminBulkCheckValidUserIDV4Op
        {
            get { return Operation.AdminBulkCheckValidUserIDV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserV4.AdminUpdateUserV4Builder AdminUpdateUserV4Op
        {
            get { return Operation.AdminUpdateUserV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserEmailAddressV4.AdminUpdateUserEmailAddressV4Builder AdminUpdateUserEmailAddressV4Op
        {
            get { return Operation.AdminUpdateUserEmailAddressV4.Builder.SetWrapperObject(this); }
        }
        public AdminDisableUserMFAV4.AdminDisableUserMFAV4Builder AdminDisableUserMFAV4Op
        {
            get { return Operation.AdminDisableUserMFAV4.Builder.SetWrapperObject(this); }
        }
        public AdminListUserRolesV4.AdminListUserRolesV4Builder AdminListUserRolesV4Op
        {
            get { return Operation.AdminListUserRolesV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserRoleV4.AdminUpdateUserRoleV4Builder AdminUpdateUserRoleV4Op
        {
            get { return Operation.AdminUpdateUserRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminAddUserRoleV4.AdminAddUserRoleV4Builder AdminAddUserRoleV4Op
        {
            get { return Operation.AdminAddUserRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminRemoveUserRoleV4.AdminRemoveUserRoleV4Builder AdminRemoveUserRoleV4Op
        {
            get { return Operation.AdminRemoveUserRoleV4.Builder.SetWrapperObject(this); }
        }
        public AdminInviteUserNewV4.AdminInviteUserNewV4Builder AdminInviteUserNewV4Op
        {
            get { return Operation.AdminInviteUserNewV4.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateMyUserV4.AdminUpdateMyUserV4Builder AdminUpdateMyUserV4Op
        {
            get { return Operation.AdminUpdateMyUserV4.Builder.SetWrapperObject(this); }
        }
        public AdminDisableMyAuthenticatorV4.AdminDisableMyAuthenticatorV4Builder AdminDisableMyAuthenticatorV4Op
        {
            get { return Operation.AdminDisableMyAuthenticatorV4.Builder.SetWrapperObject(this); }
        }
        public AdminEnableMyAuthenticatorV4.AdminEnableMyAuthenticatorV4Builder AdminEnableMyAuthenticatorV4Op
        {
            get { return Operation.AdminEnableMyAuthenticatorV4.Builder.SetWrapperObject(this); }
        }
        public AdminGenerateMyAuthenticatorKeyV4.AdminGenerateMyAuthenticatorKeyV4Builder AdminGenerateMyAuthenticatorKeyV4Op
        {
            get { return Operation.AdminGenerateMyAuthenticatorKeyV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetMyBackupCodesV4.AdminGetMyBackupCodesV4Builder AdminGetMyBackupCodesV4Op
        {
            get { return Operation.AdminGetMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public AdminGenerateMyBackupCodesV4.AdminGenerateMyBackupCodesV4Builder AdminGenerateMyBackupCodesV4Op
        {
            get { return Operation.AdminGenerateMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public AdminDisableMyBackupCodesV4.AdminDisableMyBackupCodesV4Builder AdminDisableMyBackupCodesV4Op
        {
            get { return Operation.AdminDisableMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public AdminDownloadMyBackupCodesV4.AdminDownloadMyBackupCodesV4Builder AdminDownloadMyBackupCodesV4Op
        {
            get { return Operation.AdminDownloadMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public AdminEnableMyBackupCodesV4.AdminEnableMyBackupCodesV4Builder AdminEnableMyBackupCodesV4Op
        {
            get { return Operation.AdminEnableMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public AdminSendMyMFAEmailCodeV4.AdminSendMyMFAEmailCodeV4Builder AdminSendMyMFAEmailCodeV4Op
        {
            get { return Operation.AdminSendMyMFAEmailCodeV4.Builder.SetWrapperObject(this); }
        }
        public AdminDisableMyEmailV4.AdminDisableMyEmailV4Builder AdminDisableMyEmailV4Op
        {
            get { return Operation.AdminDisableMyEmailV4.Builder.SetWrapperObject(this); }
        }
        public AdminEnableMyEmailV4.AdminEnableMyEmailV4Builder AdminEnableMyEmailV4Op
        {
            get { return Operation.AdminEnableMyEmailV4.Builder.SetWrapperObject(this); }
        }
        public AdminGetMyEnabledFactorsV4.AdminGetMyEnabledFactorsV4Builder AdminGetMyEnabledFactorsV4Op
        {
            get { return Operation.AdminGetMyEnabledFactorsV4.Builder.SetWrapperObject(this); }
        }
        public AdminMakeFactorMyDefaultV4.AdminMakeFactorMyDefaultV4Builder AdminMakeFactorMyDefaultV4Op
        {
            get { return Operation.AdminMakeFactorMyDefaultV4.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public AdminInviteUserV4.AdminInviteUserV4Builder AdminInviteUserV4Op
        {
            get { return Operation.AdminInviteUserV4.Builder.SetWrapperObject(this); }
        }
        public PublicCreateTestUserV4.PublicCreateTestUserV4Builder PublicCreateTestUserV4Op
        {
            get { return Operation.PublicCreateTestUserV4.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserV4.PublicCreateUserV4Builder PublicCreateUserV4Op
        {
            get { return Operation.PublicCreateUserV4.Builder.SetWrapperObject(this); }
        }
        public CreateUserFromInvitationV4.CreateUserFromInvitationV4Builder CreateUserFromInvitationV4Op
        {
            get { return Operation.CreateUserFromInvitationV4.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserV4.PublicUpdateUserV4Builder PublicUpdateUserV4Op
        {
            get { return Operation.PublicUpdateUserV4.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserEmailAddressV4.PublicUpdateUserEmailAddressV4Builder PublicUpdateUserEmailAddressV4Op
        {
            get { return Operation.PublicUpdateUserEmailAddressV4.Builder.SetWrapperObject(this); }
        }
        public PublicUpgradeHeadlessAccountWithVerificationCodeV4.PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder PublicUpgradeHeadlessAccountWithVerificationCodeV4Op
        {
            get { return Operation.PublicUpgradeHeadlessAccountWithVerificationCodeV4.Builder.SetWrapperObject(this); }
        }
        public PublicUpgradeHeadlessAccountV4.PublicUpgradeHeadlessAccountV4Builder PublicUpgradeHeadlessAccountV4Op
        {
            get { return Operation.PublicUpgradeHeadlessAccountV4.Builder.SetWrapperObject(this); }
        }
        public PublicDisableMyAuthenticatorV4.PublicDisableMyAuthenticatorV4Builder PublicDisableMyAuthenticatorV4Op
        {
            get { return Operation.PublicDisableMyAuthenticatorV4.Builder.SetWrapperObject(this); }
        }
        public PublicEnableMyAuthenticatorV4.PublicEnableMyAuthenticatorV4Builder PublicEnableMyAuthenticatorV4Op
        {
            get { return Operation.PublicEnableMyAuthenticatorV4.Builder.SetWrapperObject(this); }
        }
        public PublicGenerateMyAuthenticatorKeyV4.PublicGenerateMyAuthenticatorKeyV4Builder PublicGenerateMyAuthenticatorKeyV4Op
        {
            get { return Operation.PublicGenerateMyAuthenticatorKeyV4.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyBackupCodesV4.PublicGetMyBackupCodesV4Builder PublicGetMyBackupCodesV4Op
        {
            get { return Operation.PublicGetMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public PublicGenerateMyBackupCodesV4.PublicGenerateMyBackupCodesV4Builder PublicGenerateMyBackupCodesV4Op
        {
            get { return Operation.PublicGenerateMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public PublicDisableMyBackupCodesV4.PublicDisableMyBackupCodesV4Builder PublicDisableMyBackupCodesV4Op
        {
            get { return Operation.PublicDisableMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public PublicDownloadMyBackupCodesV4.PublicDownloadMyBackupCodesV4Builder PublicDownloadMyBackupCodesV4Op
        {
            get { return Operation.PublicDownloadMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public PublicEnableMyBackupCodesV4.PublicEnableMyBackupCodesV4Builder PublicEnableMyBackupCodesV4Op
        {
            get { return Operation.PublicEnableMyBackupCodesV4.Builder.SetWrapperObject(this); }
        }
        public PublicRemoveTrustedDeviceV4.PublicRemoveTrustedDeviceV4Builder PublicRemoveTrustedDeviceV4Op
        {
            get { return Operation.PublicRemoveTrustedDeviceV4.Builder.SetWrapperObject(this); }
        }
        public PublicSendMyMFAEmailCodeV4.PublicSendMyMFAEmailCodeV4Builder PublicSendMyMFAEmailCodeV4Op
        {
            get { return Operation.PublicSendMyMFAEmailCodeV4.Builder.SetWrapperObject(this); }
        }
        public PublicDisableMyEmailV4.PublicDisableMyEmailV4Builder PublicDisableMyEmailV4Op
        {
            get { return Operation.PublicDisableMyEmailV4.Builder.SetWrapperObject(this); }
        }
        public PublicEnableMyEmailV4.PublicEnableMyEmailV4Builder PublicEnableMyEmailV4Op
        {
            get { return Operation.PublicEnableMyEmailV4.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyEnabledFactorsV4.PublicGetMyEnabledFactorsV4Builder PublicGetMyEnabledFactorsV4Op
        {
            get { return Operation.PublicGetMyEnabledFactorsV4.Builder.SetWrapperObject(this); }
        }
        public PublicMakeFactorMyDefaultV4.PublicMakeFactorMyDefaultV4Builder PublicMakeFactorMyDefaultV4Op
        {
            get { return Operation.PublicMakeFactorMyDefaultV4.Builder.SetWrapperObject(this); }
        }
        public PublicInviteUserV4.PublicInviteUserV4Builder PublicInviteUserV4Op
        {
            get { return Operation.PublicInviteUserV4.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Model.AccountCreateTestUsersResponseV4? AdminCreateTestUsersV4(AdminCreateTestUsersV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListValidUserIDResponseV4? AdminBulkCheckValidUserIDV4(AdminBulkCheckValidUserIDV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpdateUserV4(AdminUpdateUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateUserEmailAddressV4(AdminUpdateUserEmailAddressV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableUserMFAV4(AdminDisableUserMFAV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminListUserRolesV4(AdminListUserRolesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminUpdateUserRoleV4(AdminUpdateUserRoleV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminAddUserRoleV4(AdminAddUserRoleV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRemoveUserRoleV4(AdminRemoveUserRoleV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInviteUserResponseV3? AdminInviteUserNewV4(AdminInviteUserNewV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpdateMyUserV4(AdminUpdateMyUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableMyAuthenticatorV4(AdminDisableMyAuthenticatorV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminEnableMyAuthenticatorV4(AdminEnableMyAuthenticatorV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAuthenticatorKeyResponseV4? AdminGenerateMyAuthenticatorKeyV4(AdminGenerateMyAuthenticatorKeyV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminGetMyBackupCodesV4(AdminGetMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminGenerateMyBackupCodesV4(AdminGenerateMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableMyBackupCodesV4(AdminDisableMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Stream? AdminDownloadMyBackupCodesV4(AdminDownloadMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminEnableMyBackupCodesV4(AdminEnableMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSendMyMFAEmailCodeV4(AdminSendMyMFAEmailCodeV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableMyEmailV4(AdminDisableMyEmailV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminEnableMyEmailV4(AdminEnableMyEmailV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelEnabledFactorsResponseV4? AdminGetMyEnabledFactorsV4(AdminGetMyEnabledFactorsV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void AdminMakeFactorMyDefaultV4(AdminMakeFactorMyDefaultV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId = "ab_deprecated_operation_wrapper")]
        public Model.ModelInviteUserResponseV3? AdminInviteUserV4(AdminInviteUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
#pragma warning restore ab_deprecated_operation
        public Model.AccountCreateUserResponseV4? PublicCreateTestUserV4(PublicCreateTestUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountCreateUserResponseV4? PublicCreateUserV4(PublicCreateUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountCreateUserResponseV4? CreateUserFromInvitationV4(CreateUserFromInvitationV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicUpdateUserV4(PublicUpdateUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUpdateUserEmailAddressV4(PublicUpdateUserEmailAddressV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountUserResponseV4? PublicUpgradeHeadlessAccountWithVerificationCodeV4(PublicUpgradeHeadlessAccountWithVerificationCodeV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountUserResponseV4? PublicUpgradeHeadlessAccountV4(PublicUpgradeHeadlessAccountV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDisableMyAuthenticatorV4(PublicDisableMyAuthenticatorV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicEnableMyAuthenticatorV4(PublicEnableMyAuthenticatorV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAuthenticatorKeyResponseV4? PublicGenerateMyAuthenticatorKeyV4(PublicGenerateMyAuthenticatorKeyV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicGetMyBackupCodesV4(PublicGetMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicGenerateMyBackupCodesV4(PublicGenerateMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDisableMyBackupCodesV4(PublicDisableMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Stream? PublicDownloadMyBackupCodesV4(PublicDownloadMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicEnableMyBackupCodesV4(PublicEnableMyBackupCodesV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicRemoveTrustedDeviceV4(PublicRemoveTrustedDeviceV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSendMyMFAEmailCodeV4(PublicSendMyMFAEmailCodeV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDisableMyEmailV4(PublicDisableMyEmailV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicEnableMyEmailV4(PublicEnableMyEmailV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelEnabledFactorsResponseV4? PublicGetMyEnabledFactorsV4(PublicGetMyEnabledFactorsV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public void PublicMakeFactorMyDefaultV4(PublicMakeFactorMyDefaultV4 input)
        {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInviteUserResponseV3? PublicInviteUserV4(PublicInviteUserV4 input)
        {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}