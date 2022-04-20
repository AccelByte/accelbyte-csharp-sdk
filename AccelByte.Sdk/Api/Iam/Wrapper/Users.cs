// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Iam.Wrapper
{
    public class Users
    {
        private readonly AccelByteSDK _sdk;

        public Users(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public CreateUser.CreateUserBuilder CreateUserOp
        {
            get { return Operation.CreateUser.Builder.SetWrapperObject(this); }
        }
        public GetAdminUsersByRoleID.GetAdminUsersByRoleIDBuilder GetAdminUsersByRoleIDOp
        {
            get { return Operation.GetAdminUsersByRoleID.Builder.SetWrapperObject(this); }
        }
        public GetUserByLoginID.GetUserByLoginIDBuilder GetUserByLoginIDOp
        {
            get { return Operation.GetUserByLoginID.Builder.SetWrapperObject(this); }
        }
        public GetUserByPlatformUserID.GetUserByPlatformUserIDBuilder GetUserByPlatformUserIDOp
        {
            get { return Operation.GetUserByPlatformUserID.Builder.SetWrapperObject(this); }
        }
        public ForgotPassword.ForgotPasswordBuilder ForgotPasswordOp
        {
            get { return Operation.ForgotPassword.Builder.SetWrapperObject(this); }
        }
        public GetUsersByLoginIds.GetUsersByLoginIdsBuilder GetUsersByLoginIdsOp
        {
            get { return Operation.GetUsersByLoginIds.Builder.SetWrapperObject(this); }
        }
        public ResetPassword.ResetPasswordBuilder ResetPasswordOp
        {
            get { return Operation.ResetPassword.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public SearchUser.SearchUserBuilder SearchUserOp
        {
            get { return Operation.SearchUser.Builder.SetWrapperObject(this); }
        }
        public GetUserByUserID.GetUserByUserIDBuilder GetUserByUserIDOp
        {
            get { return Operation.GetUserByUserID.Builder.SetWrapperObject(this); }
        }
        public UpdateUser.UpdateUserBuilder UpdateUserOp
        {
            get { return Operation.UpdateUser.Builder.SetWrapperObject(this); }
        }
        public DeleteUser.DeleteUserBuilder DeleteUserOp
        {
            get { return Operation.DeleteUser.Builder.SetWrapperObject(this); }
        }
        public BanUser.BanUserBuilder BanUserOp
        {
            get { return Operation.BanUser.Builder.SetWrapperObject(this); }
        }
        public GetUserBanHistory.GetUserBanHistoryBuilder GetUserBanHistoryOp
        {
            get { return Operation.GetUserBanHistory.Builder.SetWrapperObject(this); }
        }
        public DisableUserBan.DisableUserBanBuilder DisableUserBanOp
        {
            get { return Operation.DisableUserBan.Builder.SetWrapperObject(this); }
        }
        public EnableUserBan.EnableUserBanBuilder EnableUserBanOp
        {
            get { return Operation.EnableUserBan.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public ListCrossNamespaceAccountLink.ListCrossNamespaceAccountLinkBuilder ListCrossNamespaceAccountLinkOp
        {
            get { return Operation.ListCrossNamespaceAccountLink.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public DisableUser.DisableUserBuilder DisableUserOp
        {
            get { return Operation.DisableUser.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public EnableUser.EnableUserBuilder EnableUserOp
        {
            get { return Operation.EnableUser.Builder.SetWrapperObject(this); }
        }
        public GetUserInformation.GetUserInformationBuilder GetUserInformationOp
        {
            get { return Operation.GetUserInformation.Builder.SetWrapperObject(this); }
        }
        public DeleteUserInformation.DeleteUserInformationBuilder DeleteUserInformationOp
        {
            get { return Operation.DeleteUserInformation.Builder.SetWrapperObject(this); }
        }
        public GetUserLoginHistories.GetUserLoginHistoriesBuilder GetUserLoginHistoriesOp
        {
            get { return Operation.GetUserLoginHistories.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public UpdatePassword.UpdatePasswordBuilder UpdatePasswordOp
        {
            get { return Operation.UpdatePassword.Builder.SetWrapperObject(this); }
        }
        public SaveUserPermission.SaveUserPermissionBuilder SaveUserPermissionOp
        {
            get { return Operation.SaveUserPermission.Builder.SetWrapperObject(this); }
        }
        public AddUserPermission.AddUserPermissionBuilder AddUserPermissionOp
        {
            get { return Operation.AddUserPermission.Builder.SetWrapperObject(this); }
        }
        public DeleteUserPermission.DeleteUserPermissionBuilder DeleteUserPermissionOp
        {
            get { return Operation.DeleteUserPermission.Builder.SetWrapperObject(this); }
        }
        public GetUserPlatformAccounts.GetUserPlatformAccountsBuilder GetUserPlatformAccountsOp
        {
            get { return Operation.GetUserPlatformAccounts.Builder.SetWrapperObject(this); }
        }
        public GetUserMapping.GetUserMappingBuilder GetUserMappingOp
        {
            get { return Operation.GetUserMapping.Builder.SetWrapperObject(this); }
        }
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public GetUserJusticePlatformAccount.GetUserJusticePlatformAccountBuilder GetUserJusticePlatformAccountOp
        {
            get { return Operation.GetUserJusticePlatformAccount.Builder.SetWrapperObject(this); }
        }
        public PlatformLink.PlatformLinkBuilder PlatformLinkOp
        {
            get { return Operation.PlatformLink.Builder.SetWrapperObject(this); }
        }
        public PlatformUnlink.PlatformUnlinkBuilder PlatformUnlinkOp
        {
            get { return Operation.PlatformUnlink.Builder.SetWrapperObject(this); }
        }
        public GetPublisherUser.GetPublisherUserBuilder GetPublisherUserOp
        {
            get { return Operation.GetPublisherUser.Builder.SetWrapperObject(this); }
        }
        public SaveUserRoles.SaveUserRolesBuilder SaveUserRolesOp
        {
            get { return Operation.SaveUserRoles.Builder.SetWrapperObject(this); }
        }
        public AddUserRole.AddUserRoleBuilder AddUserRoleOp
        {
            get { return Operation.AddUserRole.Builder.SetWrapperObject(this); }
        }
        public DeleteUserRole.DeleteUserRoleBuilder DeleteUserRoleOp
        {
            get { return Operation.DeleteUserRole.Builder.SetWrapperObject(this); }
        }
        public UpgradeHeadlessAccount.UpgradeHeadlessAccountBuilder UpgradeHeadlessAccountOp
        {
            get { return Operation.UpgradeHeadlessAccount.Builder.SetWrapperObject(this); }
        }
        public UpgradeHeadlessAccountWithVerificationCode.UpgradeHeadlessAccountWithVerificationCodeBuilder UpgradeHeadlessAccountWithVerificationCodeOp
        {
            get { return Operation.UpgradeHeadlessAccountWithVerificationCode.Builder.SetWrapperObject(this); }
        }
        public UserVerification.UserVerificationBuilder UserVerificationOp
        {
            get { return Operation.UserVerification.Builder.SetWrapperObject(this); }
        }
        public SendVerificationCode.SendVerificationCodeBuilder SendVerificationCodeOp
        {
            get { return Operation.SendVerificationCode.Builder.SetWrapperObject(this); }
        }
        public AdminGetAgeRestrictionStatusV2.AdminGetAgeRestrictionStatusV2Builder AdminGetAgeRestrictionStatusV2Op
        {
            get { return Operation.AdminGetAgeRestrictionStatusV2.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateAgeRestrictionConfigV2.AdminUpdateAgeRestrictionConfigV2Builder AdminUpdateAgeRestrictionConfigV2Op
        {
            get { return Operation.AdminUpdateAgeRestrictionConfigV2.Builder.SetWrapperObject(this); }
        }
        public GetListCountryAgeRestriction.GetListCountryAgeRestrictionBuilder GetListCountryAgeRestrictionOp
        {
            get { return Operation.GetListCountryAgeRestriction.Builder.SetWrapperObject(this); }
        }
        public UpdateCountryAgeRestriction.UpdateCountryAgeRestrictionBuilder UpdateCountryAgeRestrictionOp
        {
            get { return Operation.UpdateCountryAgeRestriction.Builder.SetWrapperObject(this); }
        }
        public AdminSearchUsersV2.AdminSearchUsersV2Builder AdminSearchUsersV2Op
        {
            get { return Operation.AdminSearchUsersV2.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserByUserIdV2.AdminGetUserByUserIdV2Builder AdminGetUserByUserIdV2Op
        {
            get { return Operation.AdminGetUserByUserIdV2.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserV2.AdminUpdateUserV2Builder AdminUpdateUserV2Op
        {
            get { return Operation.AdminUpdateUserV2.Builder.SetWrapperObject(this); }
        }
        public AdminBanUserV2.AdminBanUserV2Builder AdminBanUserV2Op
        {
            get { return Operation.AdminBanUserV2.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserBanV2.AdminGetUserBanV2Builder AdminGetUserBanV2Op
        {
            get { return Operation.AdminGetUserBanV2.Builder.SetWrapperObject(this); }
        }
        public AdminDisableUserV2.AdminDisableUserV2Builder AdminDisableUserV2Op
        {
            get { return Operation.AdminDisableUserV2.Builder.SetWrapperObject(this); }
        }
        public AdminEnableUserV2.AdminEnableUserV2Builder AdminEnableUserV2Op
        {
            get { return Operation.AdminEnableUserV2.Builder.SetWrapperObject(this); }
        }
        public AdminResetPasswordV2.AdminResetPasswordV2Builder AdminResetPasswordV2Op
        {
            get { return Operation.AdminResetPasswordV2.Builder.SetWrapperObject(this); }
        }
        public AdminDeletePlatformLinkV2.AdminDeletePlatformLinkV2Builder AdminDeletePlatformLinkV2Op
        {
            get { return Operation.AdminDeletePlatformLinkV2.Builder.SetWrapperObject(this); }
        }
        public AdminPutUserRolesV2.AdminPutUserRolesV2Builder AdminPutUserRolesV2Op
        {
            get { return Operation.AdminPutUserRolesV2.Builder.SetWrapperObject(this); }
        }
        public AdminCreateUserRolesV2.AdminCreateUserRolesV2Builder AdminCreateUserRolesV2Op
        {
            get { return Operation.AdminCreateUserRolesV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetCountryAgeRestriction.PublicGetCountryAgeRestrictionBuilder PublicGetCountryAgeRestrictionOp
        {
            get { return Operation.PublicGetCountryAgeRestriction.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserV2.PublicCreateUserV2Builder PublicCreateUserV2Op
        {
            get { return Operation.PublicCreateUserV2.Builder.SetWrapperObject(this); }
        }
        public PublicForgotPasswordV2.PublicForgotPasswordV2Builder PublicForgotPasswordV2Op
        {
            get { return Operation.PublicForgotPasswordV2.Builder.SetWrapperObject(this); }
        }
        public PublicResetPasswordV2.PublicResetPasswordV2Builder PublicResetPasswordV2Op
        {
            get { return Operation.PublicResetPasswordV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserByUserIDV2.PublicGetUserByUserIDV2Builder PublicGetUserByUserIDV2Op
        {
            get { return Operation.PublicGetUserByUserIDV2.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserV2.PublicUpdateUserV2Builder PublicUpdateUserV2Op
        {
            get { return Operation.PublicUpdateUserV2.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserBan.PublicGetUserBanBuilder PublicGetUserBanOp
        {
            get { return Operation.PublicGetUserBan.Builder.SetWrapperObject(this); }
        }
        public PublicUpdatePasswordV2.PublicUpdatePasswordV2Builder PublicUpdatePasswordV2Op
        {
            get { return Operation.PublicUpdatePasswordV2.Builder.SetWrapperObject(this); }
        }
        public GetListJusticePlatformAccounts.GetListJusticePlatformAccountsBuilder GetListJusticePlatformAccountsOp
        {
            get { return Operation.GetListJusticePlatformAccounts.Builder.SetWrapperObject(this); }
        }
        public PublicPlatformLinkV2.PublicPlatformLinkV2Builder PublicPlatformLinkV2Op
        {
            get { return Operation.PublicPlatformLinkV2.Builder.SetWrapperObject(this); }
        }
        public PublicDeletePlatformLinkV2.PublicDeletePlatformLinkV2Builder PublicDeletePlatformLinkV2Op
        {
            get { return Operation.PublicDeletePlatformLinkV2.Builder.SetWrapperObject(this); }
        }
        public ListAdminsV3.ListAdminsV3Builder ListAdminsV3Op
        {
            get { return Operation.ListAdminsV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetAgeRestrictionStatusV3.AdminGetAgeRestrictionStatusV3Builder AdminGetAgeRestrictionStatusV3Op
        {
            get { return Operation.AdminGetAgeRestrictionStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateAgeRestrictionConfigV3.AdminUpdateAgeRestrictionConfigV3Builder AdminUpdateAgeRestrictionConfigV3Op
        {
            get { return Operation.AdminUpdateAgeRestrictionConfigV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetListCountryAgeRestrictionV3.AdminGetListCountryAgeRestrictionV3Builder AdminGetListCountryAgeRestrictionV3Op
        {
            get { return Operation.AdminGetListCountryAgeRestrictionV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateCountryAgeRestrictionV3.AdminUpdateCountryAgeRestrictionV3Builder AdminUpdateCountryAgeRestrictionV3Op
        {
            get { return Operation.AdminUpdateCountryAgeRestrictionV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserByPlatformUserIDV3.AdminGetUserByPlatformUserIDV3Builder AdminGetUserByPlatformUserIDV3Op
        {
            get { return Operation.AdminGetUserByPlatformUserIDV3.Builder.SetWrapperObject(this); }
        }
        public GetAdminUsersByRoleIdV3.GetAdminUsersByRoleIdV3Builder GetAdminUsersByRoleIdV3Op
        {
            get { return Operation.GetAdminUsersByRoleIdV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserByEmailAddressV3.AdminGetUserByEmailAddressV3Builder AdminGetUserByEmailAddressV3Op
        {
            get { return Operation.AdminGetUserByEmailAddressV3.Builder.SetWrapperObject(this); }
        }
        public AdminListUserIDByUserIDsV3.AdminListUserIDByUserIDsV3Builder AdminListUserIDByUserIDsV3Op
        {
            get { return Operation.AdminListUserIDByUserIDsV3.Builder.SetWrapperObject(this); }
        }
        public AdminInviteUserV3.AdminInviteUserV3Builder AdminInviteUserV3Op
        {
            get { return Operation.AdminInviteUserV3.Builder.SetWrapperObject(this); }
        }
        public AdminListUsersV3.AdminListUsersV3Builder AdminListUsersV3Op
        {
            get { return Operation.AdminListUsersV3.Builder.SetWrapperObject(this); }
        }
        public AdminSearchUserV3.AdminSearchUserV3Builder AdminSearchUserV3Op
        {
            get { return Operation.AdminSearchUserV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetBulkUserByEmailAddressV3.AdminGetBulkUserByEmailAddressV3Builder AdminGetBulkUserByEmailAddressV3Op
        {
            get { return Operation.AdminGetBulkUserByEmailAddressV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserByUserIdV3.AdminGetUserByUserIdV3Builder AdminGetUserByUserIdV3Op
        {
            get { return Operation.AdminGetUserByUserIdV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserV3.AdminUpdateUserV3Builder AdminUpdateUserV3Op
        {
            get { return Operation.AdminUpdateUserV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserBanV3.AdminGetUserBanV3Builder AdminGetUserBanV3Op
        {
            get { return Operation.AdminGetUserBanV3.Builder.SetWrapperObject(this); }
        }
        public AdminBanUserV3.AdminBanUserV3Builder AdminBanUserV3Op
        {
            get { return Operation.AdminBanUserV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserBanV3.AdminUpdateUserBanV3Builder AdminUpdateUserBanV3Op
        {
            get { return Operation.AdminUpdateUserBanV3.Builder.SetWrapperObject(this); }
        }
        public AdminSendVerificationCodeV3.AdminSendVerificationCodeV3Builder AdminSendVerificationCodeV3Op
        {
            get { return Operation.AdminSendVerificationCodeV3.Builder.SetWrapperObject(this); }
        }
        public AdminVerifyAccountV3.AdminVerifyAccountV3Builder AdminVerifyAccountV3Op
        {
            get { return Operation.AdminVerifyAccountV3.Builder.SetWrapperObject(this); }
        }
        public GetUserVerificationCode.GetUserVerificationCodeBuilder GetUserVerificationCodeOp
        {
            get { return Operation.GetUserVerificationCode.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserDeletionStatusV3.AdminGetUserDeletionStatusV3Builder AdminGetUserDeletionStatusV3Op
        {
            get { return Operation.AdminGetUserDeletionStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserDeletionStatusV3.AdminUpdateUserDeletionStatusV3Builder AdminUpdateUserDeletionStatusV3Op
        {
            get { return Operation.AdminUpdateUserDeletionStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpgradeHeadlessAccountV3.AdminUpgradeHeadlessAccountV3Builder AdminUpgradeHeadlessAccountV3Op
        {
            get { return Operation.AdminUpgradeHeadlessAccountV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteUserInformationV3.AdminDeleteUserInformationV3Builder AdminDeleteUserInformationV3Op
        {
            get { return Operation.AdminDeleteUserInformationV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserLoginHistoriesV3.AdminGetUserLoginHistoriesV3Builder AdminGetUserLoginHistoriesV3Op
        {
            get { return Operation.AdminGetUserLoginHistoriesV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserPermissionV3.AdminUpdateUserPermissionV3Builder AdminUpdateUserPermissionV3Op
        {
            get { return Operation.AdminUpdateUserPermissionV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddUserPermissionsV3.AdminAddUserPermissionsV3Builder AdminAddUserPermissionsV3Op
        {
            get { return Operation.AdminAddUserPermissionsV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteUserPermissionBulkV3.AdminDeleteUserPermissionBulkV3Builder AdminDeleteUserPermissionBulkV3Op
        {
            get { return Operation.AdminDeleteUserPermissionBulkV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteUserPermissionV3.AdminDeleteUserPermissionV3Builder AdminDeleteUserPermissionV3Op
        {
            get { return Operation.AdminDeleteUserPermissionV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetUserPlatformAccountsV3.AdminGetUserPlatformAccountsV3Builder AdminGetUserPlatformAccountsV3Op
        {
            get { return Operation.AdminGetUserPlatformAccountsV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetListJusticePlatformAccounts.AdminGetListJusticePlatformAccountsBuilder AdminGetListJusticePlatformAccountsOp
        {
            get { return Operation.AdminGetListJusticePlatformAccounts.Builder.SetWrapperObject(this); }
        }
        public AdminCreateJusticeUser.AdminCreateJusticeUserBuilder AdminCreateJusticeUserOp
        {
            get { return Operation.AdminCreateJusticeUser.Builder.SetWrapperObject(this); }
        }
        public AdminLinkPlatformAccount.AdminLinkPlatformAccountBuilder AdminLinkPlatformAccountOp
        {
            get { return Operation.AdminLinkPlatformAccount.Builder.SetWrapperObject(this); }
        }
        public AdminPlatformUnlinkV3.AdminPlatformUnlinkV3Builder AdminPlatformUnlinkV3Op
        {
            get { return Operation.AdminPlatformUnlinkV3.Builder.SetWrapperObject(this); }
        }
        public AdminPlatformLinkV3.AdminPlatformLinkV3Builder AdminPlatformLinkV3Op
        {
            get { return Operation.AdminPlatformLinkV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteUserRolesV3.AdminDeleteUserRolesV3Builder AdminDeleteUserRolesV3Op
        {
            get { return Operation.AdminDeleteUserRolesV3.Builder.SetWrapperObject(this); }
        }
        public AdminSaveUserRoleV3.AdminSaveUserRoleV3Builder AdminSaveUserRoleV3Op
        {
            get { return Operation.AdminSaveUserRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminAddUserRoleV3.AdminAddUserRoleV3Builder AdminAddUserRoleV3Op
        {
            get { return Operation.AdminAddUserRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminDeleteUserRoleV3.AdminDeleteUserRoleV3Builder AdminDeleteUserRoleV3Op
        {
            get { return Operation.AdminDeleteUserRoleV3.Builder.SetWrapperObject(this); }
        }
        public AdminUpdateUserStatusV3.AdminUpdateUserStatusV3Builder AdminUpdateUserStatusV3Op
        {
            get { return Operation.AdminUpdateUserStatusV3.Builder.SetWrapperObject(this); }
        }
        public AdminVerifyUserWithoutVerificationCodeV3.AdminVerifyUserWithoutVerificationCodeV3Builder AdminVerifyUserWithoutVerificationCodeV3Op
        {
            get { return Operation.AdminVerifyUserWithoutVerificationCodeV3.Builder.SetWrapperObject(this); }
        }
        public AdminGetMyUserV3.AdminGetMyUserV3Builder AdminGetMyUserV3Op
        {
            get { return Operation.AdminGetMyUserV3.Builder.SetWrapperObject(this); }
        }
        public PublicListUserIDByPlatformUserIDsV3.PublicListUserIDByPlatformUserIDsV3Builder PublicListUserIDByPlatformUserIDsV3Op
        {
            get { return Operation.PublicListUserIDByPlatformUserIDsV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserByPlatformUserIDV3.PublicGetUserByPlatformUserIDV3Builder PublicGetUserByPlatformUserIDV3Op
        {
            get { return Operation.PublicGetUserByPlatformUserIDV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetAsyncStatus.PublicGetAsyncStatusBuilder PublicGetAsyncStatusOp
        {
            get { return Operation.PublicGetAsyncStatus.Builder.SetWrapperObject(this); }
        }
        public PublicSearchUserV3.PublicSearchUserV3Builder PublicSearchUserV3Op
        {
            get { return Operation.PublicSearchUserV3.Builder.SetWrapperObject(this); }
        }
        public PublicCreateUserV3.PublicCreateUserV3Builder PublicCreateUserV3Op
        {
            get { return Operation.PublicCreateUserV3.Builder.SetWrapperObject(this); }
        }
        public CheckUserAvailability.CheckUserAvailabilityBuilder CheckUserAvailabilityOp
        {
            get { return Operation.CheckUserAvailability.Builder.SetWrapperObject(this); }
        }
        public PublicBulkGetUsers.PublicBulkGetUsersBuilder PublicBulkGetUsersOp
        {
            get { return Operation.PublicBulkGetUsers.Builder.SetWrapperObject(this); }
        }
        public PublicSendRegistrationCode.PublicSendRegistrationCodeBuilder PublicSendRegistrationCodeOp
        {
            get { return Operation.PublicSendRegistrationCode.Builder.SetWrapperObject(this); }
        }
        public PublicVerifyRegistrationCode.PublicVerifyRegistrationCodeBuilder PublicVerifyRegistrationCodeOp
        {
            get { return Operation.PublicVerifyRegistrationCode.Builder.SetWrapperObject(this); }
        }
        public PublicForgotPasswordV3.PublicForgotPasswordV3Builder PublicForgotPasswordV3Op
        {
            get { return Operation.PublicForgotPasswordV3.Builder.SetWrapperObject(this); }
        }
        public GetAdminInvitationV3.GetAdminInvitationV3Builder GetAdminInvitationV3Op
        {
            get { return Operation.GetAdminInvitationV3.Builder.SetWrapperObject(this); }
        }
        public CreateUserFromInvitationV3.CreateUserFromInvitationV3Builder CreateUserFromInvitationV3Op
        {
            get { return Operation.CreateUserFromInvitationV3.Builder.SetWrapperObject(this); }
        }
        public UpdateUserV3.UpdateUserV3Builder UpdateUserV3Op
        {
            get { return Operation.UpdateUserV3.Builder.SetWrapperObject(this); }
        }
        public PublicUpdateUserV3.PublicUpdateUserV3Builder PublicUpdateUserV3Op
        {
            get { return Operation.PublicUpdateUserV3.Builder.SetWrapperObject(this); }
        }
        public PublicSendVerificationCodeV3.PublicSendVerificationCodeV3Builder PublicSendVerificationCodeV3Op
        {
            get { return Operation.PublicSendVerificationCodeV3.Builder.SetWrapperObject(this); }
        }
        public PublicUserVerificationV3.PublicUserVerificationV3Builder PublicUserVerificationV3Op
        {
            get { return Operation.PublicUserVerificationV3.Builder.SetWrapperObject(this); }
        }
        public PublicUpgradeHeadlessAccountV3.PublicUpgradeHeadlessAccountV3Builder PublicUpgradeHeadlessAccountV3Op
        {
            get { return Operation.PublicUpgradeHeadlessAccountV3.Builder.SetWrapperObject(this); }
        }
        public PublicVerifyHeadlessAccountV3.PublicVerifyHeadlessAccountV3Builder PublicVerifyHeadlessAccountV3Op
        {
            get { return Operation.PublicVerifyHeadlessAccountV3.Builder.SetWrapperObject(this); }
        }
        public PublicUpdatePasswordV3.PublicUpdatePasswordV3Builder PublicUpdatePasswordV3Op
        {
            get { return Operation.PublicUpdatePasswordV3.Builder.SetWrapperObject(this); }
        }
        public PublicCreateJusticeUser.PublicCreateJusticeUserBuilder PublicCreateJusticeUserOp
        {
            get { return Operation.PublicCreateJusticeUser.Builder.SetWrapperObject(this); }
        }
        public PublicPlatformLinkV3.PublicPlatformLinkV3Builder PublicPlatformLinkV3Op
        {
            get { return Operation.PublicPlatformLinkV3.Builder.SetWrapperObject(this); }
        }
        public PublicPlatformUnlinkV3.PublicPlatformUnlinkV3Builder PublicPlatformUnlinkV3Op
        {
            get { return Operation.PublicPlatformUnlinkV3.Builder.SetWrapperObject(this); }
        }
        public PublicWebLinkPlatform.PublicWebLinkPlatformBuilder PublicWebLinkPlatformOp
        {
            get { return Operation.PublicWebLinkPlatform.Builder.SetWrapperObject(this); }
        }
        public PublicWebLinkPlatformEstablish.PublicWebLinkPlatformEstablishBuilder PublicWebLinkPlatformEstablishOp
        {
            get { return Operation.PublicWebLinkPlatformEstablish.Builder.SetWrapperObject(this); }
        }
        public ResetPasswordV3.ResetPasswordV3Builder ResetPasswordV3Op
        {
            get { return Operation.ResetPasswordV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserByUserIdV3.PublicGetUserByUserIdV3Builder PublicGetUserByUserIdV3Op
        {
            get { return Operation.PublicGetUserByUserIdV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserBanHistoryV3.PublicGetUserBanHistoryV3Builder PublicGetUserBanHistoryV3Op
        {
            get { return Operation.PublicGetUserBanHistoryV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserLoginHistoriesV3.PublicGetUserLoginHistoriesV3Builder PublicGetUserLoginHistoriesV3Op
        {
            get { return Operation.PublicGetUserLoginHistoriesV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetUserPlatformAccountsV3.PublicGetUserPlatformAccountsV3Builder PublicGetUserPlatformAccountsV3Op
        {
            get { return Operation.PublicGetUserPlatformAccountsV3.Builder.SetWrapperObject(this); }
        }
        public PublicLinkPlatformAccount.PublicLinkPlatformAccountBuilder PublicLinkPlatformAccountOp
        {
            get { return Operation.PublicLinkPlatformAccount.Builder.SetWrapperObject(this); }
        }
        public PublicValidateUserByUserIDAndPasswordV3.PublicValidateUserByUserIDAndPasswordV3Builder PublicValidateUserByUserIDAndPasswordV3Op
        {
            get { return Operation.PublicValidateUserByUserIDAndPasswordV3.Builder.SetWrapperObject(this); }
        }
        public PublicGetMyUserV3.PublicGetMyUserV3Builder PublicGetMyUserV3Op
        {
            get { return Operation.PublicGetMyUserV3.Builder.SetWrapperObject(this); }
        }
        #endregion
        
        public Model.ModelUserCreateResponse? CreateUser(CreateUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetAdminUsersResponse? GetAdminUsersByRoleID(GetAdminUsersByRoleID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPublicUserResponse? GetUserByLoginID(GetUserByLoginID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPublicUserResponse? GetUserByPlatformUserID(GetUserByPlatformUserID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ForgotPassword(ForgotPassword input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPublicUsersResponse? GetUsersByLoginIds(GetUsersByLoginIds input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ResetPassword(ResetPassword input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelSearchUsersResponse? SearchUser(SearchUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelUserResponse? GetUserByUserID(GetUserByUserID input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? UpdateUser(UpdateUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUser(DeleteUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponse? BanUser(BanUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserBanResponse>? GetUserBanHistory(GetUserBanHistory input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponse? DisableUserBan(DisableUserBan input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponse? EnableUserBan(EnableUserBan input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void ListCrossNamespaceAccountLink(ListCrossNamespaceAccountLink input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void DisableUser(DisableUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void EnableUser(EnableUser input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public Model.ModelUserInformation? GetUserInformation(GetUserInformation input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserInformation(DeleteUserInformation input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLoginHistoriesResponse? GetUserLoginHistories(GetUserLoginHistories input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public void UpdatePassword(UpdatePassword input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void SaveUserPermission(SaveUserPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddUserPermission(AddUserPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserPermission(DeleteUserPermission input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.AccountcommonUserLinkedPlatform>? GetUserPlatformAccounts(GetUserPlatformAccounts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUserMapping? GetUserMapping(GetUserMapping input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning disable ab_deprecated_operation
        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public Model.ModelGetUserJusticePlatformAccountResponse? GetUserJusticePlatformAccount(GetUserJusticePlatformAccount input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        #pragma warning restore ab_deprecated_operation
        public void PlatformLink(PlatformLink input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PlatformUnlink(PlatformUnlink input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetPublisherUserResponse? GetPublisherUser(GetPublisherUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SaveUserRoles(SaveUserRoles input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AddUserRole(AddUserRole input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DeleteUserRole(DeleteUserRole input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? UpgradeHeadlessAccount(UpgradeHeadlessAccount input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? UpgradeHeadlessAccountWithVerificationCode(UpgradeHeadlessAccountWithVerificationCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void UserVerification(UserVerification input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void SendVerificationCode(SendVerificationCode input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAgeRestrictionResponse? AdminGetAgeRestrictionStatusV2(AdminGetAgeRestrictionStatusV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAgeRestrictionResponse? AdminUpdateAgeRestrictionConfigV2(AdminUpdateAgeRestrictionConfigV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.AccountcommonCountryAgeRestriction>? GetListCountryAgeRestriction(GetListCountryAgeRestriction input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelCountry? UpdateCountryAgeRestriction(UpdateCountryAgeRestriction input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelSearchUsersByPlatformIDResponse? AdminSearchUsersV2(AdminSearchUsersV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? AdminGetUserByUserIdV2(AdminGetUserByUserIdV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? AdminUpdateUserV2(AdminUpdateUserV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponse? AdminBanUserV2(AdminBanUserV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserBanResponse>? AdminGetUserBanV2(AdminGetUserBanV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDisableUserV2(AdminDisableUserV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminEnableUserV2(AdminEnableUserV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminResetPasswordV2(AdminResetPasswordV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeletePlatformLinkV2(AdminDeletePlatformLinkV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPutUserRolesV2(AdminPutUserRolesV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminCreateUserRolesV2(AdminCreateUserRolesV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.AccountcommonCountryAgeRestriction>? PublicGetCountryAgeRestriction(PublicGetCountryAgeRestriction input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserCreateResponse? PublicCreateUserV2(PublicCreateUserV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicForgotPasswordV2(PublicForgotPasswordV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicResetPasswordV2(PublicResetPasswordV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponse? PublicGetUserByUserIDV2(PublicGetUserByUserIDV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserResponse>? PublicUpdateUserV2(PublicUpdateUserV2 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserBanResponse>? PublicGetUserBan(PublicGetUserBan input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUpdatePasswordV2(PublicUpdatePasswordV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserMapping>? GetListJusticePlatformAccounts(GetListJusticePlatformAccounts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPlatformLinkV2(PublicPlatformLinkV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicDeletePlatformLinkV2(PublicDeletePlatformLinkV2 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUsersResponseWithPaginationV3? ListAdminsV3(ListAdminsV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAgeRestrictionResponseV3? AdminGetAgeRestrictionStatusV3(AdminGetAgeRestrictionStatusV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelAgeRestrictionResponseV3? AdminUpdateAgeRestrictionConfigV3(AdminUpdateAgeRestrictionConfigV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelCountryV3Response>? AdminGetListCountryAgeRestrictionV3(AdminGetListCountryAgeRestrictionV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelCountryV3Response? AdminUpdateCountryAgeRestrictionV3(AdminUpdateCountryAgeRestrictionV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminGetUserByPlatformUserIDV3(AdminGetUserByPlatformUserIDV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUsersResponseWithPaginationV3? GetAdminUsersByRoleIdV3(GetAdminUsersByRoleIdV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminGetUserByEmailAddressV3(AdminGetUserByEmailAddressV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserInformationResult? AdminListUserIDByUserIDsV3(AdminListUserIDByUserIDsV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelInviteUserResponseV3? AdminInviteUserV3(AdminInviteUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonListUsersWithPlatformAccountsResponse? AdminListUsersV3(AdminListUsersV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelSearchUsersResponseWithPaginationV3? AdminSearchUserV3(AdminSearchUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListUserResponseV3? AdminGetBulkUserByEmailAddressV3(AdminGetBulkUserByEmailAddressV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminGetUserByUserIdV3(AdminGetUserByUserIdV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpdateUserV3(AdminUpdateUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUserBanV3Response? AdminGetUserBanV3(AdminGetUserBanV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponseV3? AdminBanUserV3(AdminBanUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserBanResponseV3? AdminUpdateUserBanV3(AdminUpdateUserBanV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSendVerificationCodeV3(AdminSendVerificationCodeV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminVerifyAccountV3(AdminVerifyAccountV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelVerificationCodeResponse? GetUserVerificationCode(GetUserVerificationCode input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserDeletionStatusResponse? AdminGetUserDeletionStatusV3(AdminGetUserDeletionStatusV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateUserDeletionStatusV3(AdminUpdateUserDeletionStatusV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminUpgradeHeadlessAccountV3(AdminUpgradeHeadlessAccountV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserInformationV3(AdminDeleteUserInformationV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLoginHistoriesResponse? AdminGetUserLoginHistoriesV3(AdminGetUserLoginHistoriesV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateUserPermissionV3(AdminUpdateUserPermissionV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddUserPermissionsV3(AdminAddUserPermissionsV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserPermissionBulkV3(AdminDeleteUserPermissionBulkV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserPermissionV3(AdminDeleteUserPermissionV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonUserLinkedPlatformsResponseV3? AdminGetUserPlatformAccountsV3(AdminGetUserPlatformAccountsV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelGetUserMapping>? AdminGetListJusticePlatformAccounts(AdminGetListJusticePlatformAccounts input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelCreateJusticeUserResponse? AdminCreateJusticeUser(AdminCreateJusticeUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminLinkPlatformAccount(AdminLinkPlatformAccount input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPlatformUnlinkV3(AdminPlatformUnlinkV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminPlatformLinkV3(AdminPlatformLinkV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserRolesV3(AdminDeleteUserRolesV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminSaveUserRoleV3(AdminSaveUserRoleV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminAddUserRoleV3(AdminAddUserRoleV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminDeleteUserRoleV3(AdminDeleteUserRoleV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminUpdateUserStatusV3(AdminUpdateUserStatusV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void AdminVerifyUserWithoutVerificationCodeV3(AdminVerifyUserWithoutVerificationCodeV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? AdminGetMyUserV3(AdminGetMyUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonUserPlatforms? PublicListUserIDByPlatformUserIDsV3(PublicListUserIDByPlatformUserIDsV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicGetUserByPlatformUserIDV3(PublicGetUserByPlatformUserIDV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLinkRequest? PublicGetAsyncStatus(PublicGetAsyncStatus input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPublicUserInformationResponseV3? PublicSearchUserV3(PublicSearchUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserCreateResponseV3? PublicCreateUserV3(PublicCreateUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void CheckUserAvailability(CheckUserAvailability input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelListBulkUserResponse? PublicBulkGetUsers(PublicBulkGetUsers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSendRegistrationCode(PublicSendRegistrationCode input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicVerifyRegistrationCode(PublicVerifyRegistrationCode input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicForgotPasswordV3(PublicForgotPasswordV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserInvitationV3? GetAdminInvitationV3(GetAdminInvitationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserCreateResponseV3? CreateUserFromInvitationV3(CreateUserFromInvitationV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserResponseV3>? UpdateUserV3(UpdateUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.ModelUserResponseV3>? PublicUpdateUserV3(PublicUpdateUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicSendVerificationCodeV3(PublicSendVerificationCodeV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUserVerificationV3(PublicUserVerificationV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicUpgradeHeadlessAccountV3(PublicUpgradeHeadlessAccountV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicVerifyHeadlessAccountV3(PublicVerifyHeadlessAccountV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicUpdatePasswordV3(PublicUpdatePasswordV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelCreateJusticeUserResponse? PublicCreateJusticeUser(PublicCreateJusticeUser input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPlatformLinkV3(PublicPlatformLinkV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicPlatformUnlinkV3(PublicPlatformUnlinkV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelWebLinkingResponse? PublicWebLinkPlatform(PublicWebLinkPlatform input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public string PublicWebLinkPlatformEstablish(PublicWebLinkPlatformEstablish input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void ResetPasswordV3(ResetPasswordV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelPublicUserResponseV3? PublicGetUserByUserIdV3(PublicGetUserByUserIdV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelGetUserBanV3Response? PublicGetUserBanHistoryV3(PublicGetUserBanHistoryV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelLoginHistoriesResponse? PublicGetUserLoginHistoriesV3(PublicGetUserLoginHistoriesV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.AccountcommonUserLinkedPlatformsResponseV3? PublicGetUserPlatformAccountsV3(PublicGetUserPlatformAccountsV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicLinkPlatformAccount(PublicLinkPlatformAccount input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void PublicValidateUserByUserIDAndPasswordV3(PublicValidateUserByUserIDAndPasswordV3 input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelUserResponseV3? PublicGetMyUserV3(PublicGetMyUserV3 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}