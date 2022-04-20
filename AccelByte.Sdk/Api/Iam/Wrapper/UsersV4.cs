// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public AdminGetMyEnabledFactorsV4.AdminGetMyEnabledFactorsV4Builder AdminGetMyEnabledFactorsV4Op
        {
            get { return Operation.AdminGetMyEnabledFactorsV4.Builder.SetWrapperObject(this); }
        }
        public AdminMakeFactorMyDefaultV4.AdminMakeFactorMyDefaultV4Builder AdminMakeFactorMyDefaultV4Op
        {
            get { return Operation.AdminMakeFactorMyDefaultV4.Builder.SetWrapperObject(this); }
        }
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
        public PublicGetMyEnabledFactorsV4.PublicGetMyEnabledFactorsV4Builder PublicGetMyEnabledFactorsV4Op
        {
            get { return Operation.PublicGetMyEnabledFactorsV4.Builder.SetWrapperObject(this); }
        }
        public PublicMakeFactorMyDefaultV4.PublicMakeFactorMyDefaultV4Builder PublicMakeFactorMyDefaultV4Op
        {
            get { return Operation.PublicMakeFactorMyDefaultV4.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelListValidUserIDResponseV4? AdminBulkCheckValidUserIDV4(AdminBulkCheckValidUserIDV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpdateUserV4(AdminUpdateUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateUserEmailAddressV4(AdminUpdateUserEmailAddressV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableUserMFAV4(AdminDisableUserMFAV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminListUserRolesV4(AdminListUserRolesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminUpdateUserRoleV4(AdminUpdateUserRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserRolesV4Response? AdminAddUserRoleV4(AdminAddUserRoleV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminRemoveUserRoleV4(AdminRemoveUserRoleV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpdateMyUserV4(AdminUpdateMyUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableMyAuthenticatorV4(AdminDisableMyAuthenticatorV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminEnableMyAuthenticatorV4(AdminEnableMyAuthenticatorV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAuthenticatorKeyResponseV4? AdminGenerateMyAuthenticatorKeyV4(AdminGenerateMyAuthenticatorKeyV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminGetMyBackupCodesV4(AdminGetMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminGenerateMyBackupCodesV4(AdminGenerateMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableMyBackupCodesV4(AdminDisableMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDownloadMyBackupCodesV4(AdminDownloadMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? AdminEnableMyBackupCodesV4(AdminEnableMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelEnabledFactorsResponseV4? AdminGetMyEnabledFactorsV4(AdminGetMyEnabledFactorsV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminMakeFactorMyDefaultV4(AdminMakeFactorMyDefaultV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInviteUserResponseV3? AdminInviteUserV4(AdminInviteUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountCreateUserResponseV4? PublicCreateTestUserV4(PublicCreateTestUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountCreateUserResponseV4? PublicCreateUserV4(PublicCreateUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountCreateUserResponseV4? CreateUserFromInvitationV4(CreateUserFromInvitationV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicUpdateUserV4(PublicUpdateUserV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUpdateUserEmailAddressV4(PublicUpdateUserEmailAddressV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountUserResponseV4? PublicUpgradeHeadlessAccountWithVerificationCodeV4(PublicUpgradeHeadlessAccountWithVerificationCodeV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountUserResponseV4? PublicUpgradeHeadlessAccountV4(PublicUpgradeHeadlessAccountV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDisableMyAuthenticatorV4(PublicDisableMyAuthenticatorV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicEnableMyAuthenticatorV4(PublicEnableMyAuthenticatorV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAuthenticatorKeyResponseV4? PublicGenerateMyAuthenticatorKeyV4(PublicGenerateMyAuthenticatorKeyV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicGetMyBackupCodesV4(PublicGetMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicGenerateMyBackupCodesV4(PublicGenerateMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDisableMyBackupCodesV4(PublicDisableMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDownloadMyBackupCodesV4(PublicDownloadMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelBackupCodesResponseV4? PublicEnableMyBackupCodesV4(PublicEnableMyBackupCodesV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicRemoveTrustedDeviceV4(PublicRemoveTrustedDeviceV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelEnabledFactorsResponseV4? PublicGetMyEnabledFactorsV4(PublicGetMyEnabledFactorsV4 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicMakeFactorMyDefaultV4(PublicMakeFactorMyDefaultV4 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }

    public static class UsersV4_OperationExtensions
    {
        public static Model.ModelListValidUserIDResponseV4? Execute(
            this AdminBulkCheckValidUserIDV4.AdminBulkCheckValidUserIDV4Builder builder,
            ModelCheckValidUserIDRequestV4 body,
            string namespace_
        )
        {
            AdminBulkCheckValidUserIDV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).AdminBulkCheckValidUserIDV4(op);
        }

        public static Model.ModelUserResponseV3? Execute(
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

            return ((UsersV4)builder.WrapperObject!).AdminUpdateUserV4(op);
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

            ((UsersV4)builder.WrapperObject!).AdminUpdateUserEmailAddressV4(op);
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

            ((UsersV4)builder.WrapperObject!).AdminDisableUserMFAV4(op);
        }

        public static Model.ModelListUserRolesV4Response? Execute(
            this AdminListUserRolesV4.AdminListUserRolesV4Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminListUserRolesV4 op = builder.Build(
                namespace_,
                userId
            );

            return ((UsersV4)builder.WrapperObject!).AdminListUserRolesV4(op);
        }

        public static Model.ModelListUserRolesV4Response? Execute(
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

            return ((UsersV4)builder.WrapperObject!).AdminUpdateUserRoleV4(op);
        }

        public static Model.ModelListUserRolesV4Response? Execute(
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

            return ((UsersV4)builder.WrapperObject!).AdminAddUserRoleV4(op);
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

            ((UsersV4)builder.WrapperObject!).AdminRemoveUserRoleV4(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this AdminUpdateMyUserV4.AdminUpdateMyUserV4Builder builder,
            ModelUserUpdateRequestV3 body
        )
        {
            AdminUpdateMyUserV4 op = builder.Build(
                body
            );

            return ((UsersV4)builder.WrapperObject!).AdminUpdateMyUserV4(op);
        }

        public static void Execute(
            this AdminDisableMyAuthenticatorV4.AdminDisableMyAuthenticatorV4Builder builder
        )
        {
            AdminDisableMyAuthenticatorV4 op = builder.Build(
            );

            ((UsersV4)builder.WrapperObject!).AdminDisableMyAuthenticatorV4(op);
        }

        public static void Execute(
            this AdminEnableMyAuthenticatorV4.AdminEnableMyAuthenticatorV4Builder builder
        )
        {
            AdminEnableMyAuthenticatorV4 op = builder.Build(
            );

            ((UsersV4)builder.WrapperObject!).AdminEnableMyAuthenticatorV4(op);
        }

        public static Model.ModelAuthenticatorKeyResponseV4? Execute(
            this AdminGenerateMyAuthenticatorKeyV4.AdminGenerateMyAuthenticatorKeyV4Builder builder
        )
        {
            AdminGenerateMyAuthenticatorKeyV4 op = builder.Build(
            );

            return ((UsersV4)builder.WrapperObject!).AdminGenerateMyAuthenticatorKeyV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this AdminGetMyBackupCodesV4.AdminGetMyBackupCodesV4Builder builder
        )
        {
            AdminGetMyBackupCodesV4 op = builder.Build(
            );

            return ((UsersV4)builder.WrapperObject!).AdminGetMyBackupCodesV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this AdminGenerateMyBackupCodesV4.AdminGenerateMyBackupCodesV4Builder builder
        )
        {
            AdminGenerateMyBackupCodesV4 op = builder.Build(
            );

            return ((UsersV4)builder.WrapperObject!).AdminGenerateMyBackupCodesV4(op);
        }

        public static void Execute(
            this AdminDisableMyBackupCodesV4.AdminDisableMyBackupCodesV4Builder builder
        )
        {
            AdminDisableMyBackupCodesV4 op = builder.Build(
            );

            ((UsersV4)builder.WrapperObject!).AdminDisableMyBackupCodesV4(op);
        }

        public static void Execute(
            this AdminDownloadMyBackupCodesV4.AdminDownloadMyBackupCodesV4Builder builder
        )
        {
            AdminDownloadMyBackupCodesV4 op = builder.Build(
            );

            ((UsersV4)builder.WrapperObject!).AdminDownloadMyBackupCodesV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this AdminEnableMyBackupCodesV4.AdminEnableMyBackupCodesV4Builder builder
        )
        {
            AdminEnableMyBackupCodesV4 op = builder.Build(
            );

            return ((UsersV4)builder.WrapperObject!).AdminEnableMyBackupCodesV4(op);
        }

        public static Model.ModelEnabledFactorsResponseV4? Execute(
            this AdminGetMyEnabledFactorsV4.AdminGetMyEnabledFactorsV4Builder builder
        )
        {
            AdminGetMyEnabledFactorsV4 op = builder.Build(
            );

            return ((UsersV4)builder.WrapperObject!).AdminGetMyEnabledFactorsV4(op);
        }

        public static void Execute(
            this AdminMakeFactorMyDefaultV4.AdminMakeFactorMyDefaultV4Builder builder,
            string factor
        )
        {
            AdminMakeFactorMyDefaultV4 op = builder.Build(
                factor
            );

            ((UsersV4)builder.WrapperObject!).AdminMakeFactorMyDefaultV4(op);
        }

        public static Model.ModelInviteUserResponseV3? Execute(
            this AdminInviteUserV4.AdminInviteUserV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {
            AdminInviteUserV4 op = builder.Build(
                body
            );

            return ((UsersV4)builder.WrapperObject!).AdminInviteUserV4(op);
        }

        public static Model.AccountCreateUserResponseV4? Execute(
            this PublicCreateTestUserV4.PublicCreateTestUserV4Builder builder,
            AccountCreateTestUserRequestV4 body,
            string namespace_
        )
        {
            PublicCreateTestUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicCreateTestUserV4(op);
        }

        public static Model.AccountCreateUserResponseV4? Execute(
            this PublicCreateUserV4.PublicCreateUserV4Builder builder,
            AccountCreateUserRequestV4 body,
            string namespace_
        )
        {
            PublicCreateUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicCreateUserV4(op);
        }

        public static Model.AccountCreateUserResponseV4? Execute(
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

            return ((UsersV4)builder.WrapperObject!).CreateUserFromInvitationV4(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this PublicUpdateUserV4.PublicUpdateUserV4Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PublicUpdateUserV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicUpdateUserV4(op);
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

            ((UsersV4)builder.WrapperObject!).PublicUpdateUserEmailAddressV4(op);
        }

        public static Model.AccountUserResponseV4? Execute(
            this PublicUpgradeHeadlessAccountWithVerificationCodeV4.PublicUpgradeHeadlessAccountWithVerificationCodeV4Builder builder,
            AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountWithVerificationCodeV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicUpgradeHeadlessAccountWithVerificationCodeV4(op);
        }

        public static Model.AccountUserResponseV4? Execute(
            this PublicUpgradeHeadlessAccountV4.PublicUpgradeHeadlessAccountV4Builder builder,
            AccountUpgradeHeadlessAccountRequestV4 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountV4 op = builder.Build(
                body,
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicUpgradeHeadlessAccountV4(op);
        }

        public static void Execute(
            this PublicDisableMyAuthenticatorV4.PublicDisableMyAuthenticatorV4Builder builder,
            string namespace_
        )
        {
            PublicDisableMyAuthenticatorV4 op = builder.Build(
                namespace_
            );

            ((UsersV4)builder.WrapperObject!).PublicDisableMyAuthenticatorV4(op);
        }

        public static void Execute(
            this PublicEnableMyAuthenticatorV4.PublicEnableMyAuthenticatorV4Builder builder,
            string namespace_
        )
        {
            PublicEnableMyAuthenticatorV4 op = builder.Build(
                namespace_
            );

            ((UsersV4)builder.WrapperObject!).PublicEnableMyAuthenticatorV4(op);
        }

        public static Model.ModelAuthenticatorKeyResponseV4? Execute(
            this PublicGenerateMyAuthenticatorKeyV4.PublicGenerateMyAuthenticatorKeyV4Builder builder,
            string namespace_
        )
        {
            PublicGenerateMyAuthenticatorKeyV4 op = builder.Build(
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicGenerateMyAuthenticatorKeyV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this PublicGetMyBackupCodesV4.PublicGetMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicGetMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicGetMyBackupCodesV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this PublicGenerateMyBackupCodesV4.PublicGenerateMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicGenerateMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicGenerateMyBackupCodesV4(op);
        }

        public static void Execute(
            this PublicDisableMyBackupCodesV4.PublicDisableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicDisableMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            ((UsersV4)builder.WrapperObject!).PublicDisableMyBackupCodesV4(op);
        }

        public static void Execute(
            this PublicDownloadMyBackupCodesV4.PublicDownloadMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicDownloadMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            ((UsersV4)builder.WrapperObject!).PublicDownloadMyBackupCodesV4(op);
        }

        public static Model.ModelBackupCodesResponseV4? Execute(
            this PublicEnableMyBackupCodesV4.PublicEnableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PublicEnableMyBackupCodesV4 op = builder.Build(
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicEnableMyBackupCodesV4(op);
        }

        public static void Execute(
            this PublicRemoveTrustedDeviceV4.PublicRemoveTrustedDeviceV4Builder builder,
            string namespace_
        )
        {
            PublicRemoveTrustedDeviceV4 op = builder.Build(
                namespace_
            );

            ((UsersV4)builder.WrapperObject!).PublicRemoveTrustedDeviceV4(op);
        }

        public static Model.ModelEnabledFactorsResponseV4? Execute(
            this PublicGetMyEnabledFactorsV4.PublicGetMyEnabledFactorsV4Builder builder,
            string namespace_
        )
        {
            PublicGetMyEnabledFactorsV4 op = builder.Build(
                namespace_
            );

            return ((UsersV4)builder.WrapperObject!).PublicGetMyEnabledFactorsV4(op);
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

            ((UsersV4)builder.WrapperObject!).PublicMakeFactorMyDefaultV4(op);
        }

    }
}