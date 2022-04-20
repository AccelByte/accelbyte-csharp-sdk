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

    public static class Users_OperationExtensions
    {
        public static Model.ModelUserCreateResponse? Execute(
            this CreateUser.CreateUserBuilder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            CreateUser op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).CreateUser(op);
        }

        public static Model.ModelGetAdminUsersResponse? Execute(
            this GetAdminUsersByRoleID.GetAdminUsersByRoleIDBuilder builder,
            string namespace_
        )
        {
            GetAdminUsersByRoleID op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).GetAdminUsersByRoleID(op);
        }

        public static Model.ModelPublicUserResponse? Execute(
            this GetUserByLoginID.GetUserByLoginIDBuilder builder,
            string namespace_
        )
        {
            GetUserByLoginID op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).GetUserByLoginID(op);
        }

        public static Model.ModelPublicUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).GetUserByPlatformUserID(op);
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

            ((Users)builder.WrapperObject!).ForgotPassword(op);
        }

        public static Model.ModelPublicUsersResponse? Execute(
            this GetUsersByLoginIds.GetUsersByLoginIdsBuilder builder,
            string namespace_
        )
        {
            GetUsersByLoginIds op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).GetUsersByLoginIds(op);
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

            ((Users)builder.WrapperObject!).ResetPassword(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelSearchUsersResponse? Execute(
            this SearchUser.SearchUserBuilder builder,
            string namespace_
        )
        {
            SearchUser op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).SearchUser(op);
        }

        public static Model.ModelUserResponse? Execute(
            this GetUserByUserID.GetUserByUserIDBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserByUserID op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserByUserID(op);
        }

        public static Model.ModelUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).UpdateUser(op);
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

            ((Users)builder.WrapperObject!).DeleteUser(op);
        }

        public static Model.ModelUserBanResponse? Execute(
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

            return ((Users)builder.WrapperObject!).BanUser(op);
        }

        public static List<Model.ModelUserBanResponse>? Execute(
            this GetUserBanHistory.GetUserBanHistoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserBanHistory op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserBanHistory(op);
        }

        public static Model.ModelUserBanResponse? Execute(
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

            return ((Users)builder.WrapperObject!).DisableUserBan(op);
        }

        public static Model.ModelUserBanResponse? Execute(
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

            return ((Users)builder.WrapperObject!).EnableUserBan(op);
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

            ((Users)builder.WrapperObject!).ListCrossNamespaceAccountLink(op);
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

            ((Users)builder.WrapperObject!).DisableUser(op);
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

            ((Users)builder.WrapperObject!).EnableUser(op);
        }

        public static Model.ModelUserInformation? Execute(
            this GetUserInformation.GetUserInformationBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserInformation op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserInformation(op);
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

            ((Users)builder.WrapperObject!).DeleteUserInformation(op);
        }

        public static Model.ModelLoginHistoriesResponse? Execute(
            this GetUserLoginHistories.GetUserLoginHistoriesBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserLoginHistories op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserLoginHistories(op);
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

            ((Users)builder.WrapperObject!).UpdatePassword(op);
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

            ((Users)builder.WrapperObject!).SaveUserPermission(op);
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

            ((Users)builder.WrapperObject!).AddUserPermission(op);
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

            ((Users)builder.WrapperObject!).DeleteUserPermission(op);
        }

        public static List<Model.AccountcommonUserLinkedPlatform>? Execute(
            this GetUserPlatformAccounts.GetUserPlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserPlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserPlatformAccounts(op);
        }

        public static Model.ModelGetUserMapping? Execute(
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

            return ((Users)builder.WrapperObject!).GetUserMapping(op);
        }

        [Obsolete(DiagnosticId ="ab_deprecated_operation_wrapper")]
        public static Model.ModelGetUserJusticePlatformAccountResponse? Execute(
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

            return ((Users)builder.WrapperObject!).GetUserJusticePlatformAccount(op);
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

            ((Users)builder.WrapperObject!).PlatformLink(op);
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

            ((Users)builder.WrapperObject!).PlatformUnlink(op);
        }

        public static Model.ModelGetPublisherUserResponse? Execute(
            this GetPublisherUser.GetPublisherUserBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetPublisherUser op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetPublisherUser(op);
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

            ((Users)builder.WrapperObject!).SaveUserRoles(op);
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

            ((Users)builder.WrapperObject!).AddUserRole(op);
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

            ((Users)builder.WrapperObject!).DeleteUserRole(op);
        }

        public static Model.ModelUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).UpgradeHeadlessAccount(op);
        }

        public static Model.ModelUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).UpgradeHeadlessAccountWithVerificationCode(op);
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

            ((Users)builder.WrapperObject!).UserVerification(op);
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

            ((Users)builder.WrapperObject!).SendVerificationCode(op);
        }

        public static Model.ModelAgeRestrictionResponse? Execute(
            this AdminGetAgeRestrictionStatusV2.AdminGetAgeRestrictionStatusV2Builder builder,
            string namespace_
        )
        {
            AdminGetAgeRestrictionStatusV2 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminGetAgeRestrictionStatusV2(op);
        }

        public static Model.ModelAgeRestrictionResponse? Execute(
            this AdminUpdateAgeRestrictionConfigV2.AdminUpdateAgeRestrictionConfigV2Builder builder,
            ModelAgeRestrictionRequest body,
            string namespace_
        )
        {
            AdminUpdateAgeRestrictionConfigV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminUpdateAgeRestrictionConfigV2(op);
        }

        public static List<Model.AccountcommonCountryAgeRestriction>? Execute(
            this GetListCountryAgeRestriction.GetListCountryAgeRestrictionBuilder builder,
            string namespace_
        )
        {
            GetListCountryAgeRestriction op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).GetListCountryAgeRestriction(op);
        }

        public static Model.ModelCountry? Execute(
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

            return ((Users)builder.WrapperObject!).UpdateCountryAgeRestriction(op);
        }

        public static Model.ModelSearchUsersByPlatformIDResponse? Execute(
            this AdminSearchUsersV2.AdminSearchUsersV2Builder builder,
            string namespace_,
            string platformId
        )
        {
            AdminSearchUsersV2 op = builder.Build(
                namespace_,
                platformId
            );

            return ((Users)builder.WrapperObject!).AdminSearchUsersV2(op);
        }

        public static Model.ModelUserResponse? Execute(
            this AdminGetUserByUserIdV2.AdminGetUserByUserIdV2Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserByUserIdV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserByUserIdV2(op);
        }

        public static Model.ModelUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).AdminUpdateUserV2(op);
        }

        public static Model.ModelUserBanResponse? Execute(
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

            return ((Users)builder.WrapperObject!).AdminBanUserV2(op);
        }

        public static List<Model.ModelUserBanResponse>? Execute(
            this AdminGetUserBanV2.AdminGetUserBanV2Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserBanV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserBanV2(op);
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

            ((Users)builder.WrapperObject!).AdminDisableUserV2(op);
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

            ((Users)builder.WrapperObject!).AdminEnableUserV2(op);
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

            ((Users)builder.WrapperObject!).AdminResetPasswordV2(op);
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

            ((Users)builder.WrapperObject!).AdminDeletePlatformLinkV2(op);
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

            ((Users)builder.WrapperObject!).AdminPutUserRolesV2(op);
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

            ((Users)builder.WrapperObject!).AdminCreateUserRolesV2(op);
        }

        public static List<Model.AccountcommonCountryAgeRestriction>? Execute(
            this PublicGetCountryAgeRestriction.PublicGetCountryAgeRestrictionBuilder builder,
            string countryCode,
            string namespace_
        )
        {
            PublicGetCountryAgeRestriction op = builder.Build(
                countryCode,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicGetCountryAgeRestriction(op);
        }

        public static Model.ModelUserCreateResponse? Execute(
            this PublicCreateUserV2.PublicCreateUserV2Builder builder,
            ModelUserCreateRequest body,
            string namespace_
        )
        {
            PublicCreateUserV2 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicCreateUserV2(op);
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

            ((Users)builder.WrapperObject!).PublicForgotPasswordV2(op);
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

            ((Users)builder.WrapperObject!).PublicResetPasswordV2(op);
        }

        public static Model.ModelUserResponse? Execute(
            this PublicGetUserByUserIDV2.PublicGetUserByUserIDV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserByUserIDV2 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserByUserIDV2(op);
        }

        public static List<Model.ModelUserResponse>? Execute(
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

            return ((Users)builder.WrapperObject!).PublicUpdateUserV2(op);
        }

        public static List<Model.ModelUserBanResponse>? Execute(
            this PublicGetUserBan.PublicGetUserBanBuilder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserBan op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserBan(op);
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

            ((Users)builder.WrapperObject!).PublicUpdatePasswordV2(op);
        }

        public static List<Model.ModelGetUserMapping>? Execute(
            this GetListJusticePlatformAccounts.GetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetListJusticePlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetListJusticePlatformAccounts(op);
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

            ((Users)builder.WrapperObject!).PublicPlatformLinkV2(op);
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

            ((Users)builder.WrapperObject!).PublicDeletePlatformLinkV2(op);
        }

        public static Model.ModelGetUsersResponseWithPaginationV3? Execute(
            this ListAdminsV3.ListAdminsV3Builder builder,
            string namespace_
        )
        {
            ListAdminsV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).ListAdminsV3(op);
        }

        public static Model.ModelAgeRestrictionResponseV3? Execute(
            this AdminGetAgeRestrictionStatusV3.AdminGetAgeRestrictionStatusV3Builder builder,
            string namespace_
        )
        {
            AdminGetAgeRestrictionStatusV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminGetAgeRestrictionStatusV3(op);
        }

        public static Model.ModelAgeRestrictionResponseV3? Execute(
            this AdminUpdateAgeRestrictionConfigV3.AdminUpdateAgeRestrictionConfigV3Builder builder,
            ModelAgeRestrictionRequestV3 body,
            string namespace_
        )
        {
            AdminUpdateAgeRestrictionConfigV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminUpdateAgeRestrictionConfigV3(op);
        }

        public static List<Model.ModelCountryV3Response>? Execute(
            this AdminGetListCountryAgeRestrictionV3.AdminGetListCountryAgeRestrictionV3Builder builder,
            string namespace_
        )
        {
            AdminGetListCountryAgeRestrictionV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminGetListCountryAgeRestrictionV3(op);
        }

        public static Model.ModelCountryV3Response? Execute(
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

            return ((Users)builder.WrapperObject!).AdminUpdateCountryAgeRestrictionV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).AdminGetUserByPlatformUserIDV3(op);
        }

        public static Model.ModelGetUsersResponseWithPaginationV3? Execute(
            this GetAdminUsersByRoleIdV3.GetAdminUsersByRoleIdV3Builder builder,
            string namespace_,
            string roleId
        )
        {
            GetAdminUsersByRoleIdV3 op = builder.Build(
                namespace_,
                roleId
            );

            return ((Users)builder.WrapperObject!).GetAdminUsersByRoleIdV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this AdminGetUserByEmailAddressV3.AdminGetUserByEmailAddressV3Builder builder,
            string namespace_
        )
        {
            AdminGetUserByEmailAddressV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminGetUserByEmailAddressV3(op);
        }

        public static Model.ModelListUserInformationResult? Execute(
            this AdminListUserIDByUserIDsV3.AdminListUserIDByUserIDsV3Builder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            AdminListUserIDByUserIDsV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminListUserIDByUserIDsV3(op);
        }

        public static Model.ModelInviteUserResponseV3? Execute(
            this AdminInviteUserV3.AdminInviteUserV3Builder builder,
            ModelInviteUserRequestV3 body,
            string namespace_
        )
        {
            AdminInviteUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminInviteUserV3(op);
        }

        public static Model.AccountcommonListUsersWithPlatformAccountsResponse? Execute(
            this AdminListUsersV3.AdminListUsersV3Builder builder,
            string namespace_
        )
        {
            AdminListUsersV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminListUsersV3(op);
        }

        public static Model.ModelSearchUsersResponseWithPaginationV3? Execute(
            this AdminSearchUserV3.AdminSearchUserV3Builder builder,
            string namespace_
        )
        {
            AdminSearchUserV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminSearchUserV3(op);
        }

        public static Model.ModelListUserResponseV3? Execute(
            this AdminGetBulkUserByEmailAddressV3.AdminGetBulkUserByEmailAddressV3Builder builder,
            ModelListEmailAddressRequest body,
            string namespace_
        )
        {
            AdminGetBulkUserByEmailAddressV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).AdminGetBulkUserByEmailAddressV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this AdminGetUserByUserIdV3.AdminGetUserByUserIdV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserByUserIdV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserByUserIdV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).AdminUpdateUserV3(op);
        }

        public static Model.ModelGetUserBanV3Response? Execute(
            this AdminGetUserBanV3.AdminGetUserBanV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserBanV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserBanV3(op);
        }

        public static Model.ModelUserBanResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).AdminBanUserV3(op);
        }

        public static Model.ModelUserBanResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).AdminUpdateUserBanV3(op);
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

            ((Users)builder.WrapperObject!).AdminSendVerificationCodeV3(op);
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

            ((Users)builder.WrapperObject!).AdminVerifyAccountV3(op);
        }

        public static Model.ModelVerificationCodeResponse? Execute(
            this GetUserVerificationCode.GetUserVerificationCodeBuilder builder,
            string namespace_,
            string userId
        )
        {
            GetUserVerificationCode op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).GetUserVerificationCode(op);
        }

        public static Model.ModelUserDeletionStatusResponse? Execute(
            this AdminGetUserDeletionStatusV3.AdminGetUserDeletionStatusV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserDeletionStatusV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserDeletionStatusV3(op);
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

            ((Users)builder.WrapperObject!).AdminUpdateUserDeletionStatusV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).AdminUpgradeHeadlessAccountV3(op);
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

            ((Users)builder.WrapperObject!).AdminDeleteUserInformationV3(op);
        }

        public static Model.ModelLoginHistoriesResponse? Execute(
            this AdminGetUserLoginHistoriesV3.AdminGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserLoginHistoriesV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserLoginHistoriesV3(op);
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

            ((Users)builder.WrapperObject!).AdminUpdateUserPermissionV3(op);
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

            ((Users)builder.WrapperObject!).AdminAddUserPermissionsV3(op);
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

            ((Users)builder.WrapperObject!).AdminDeleteUserPermissionBulkV3(op);
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

            ((Users)builder.WrapperObject!).AdminDeleteUserPermissionV3(op);
        }

        public static Model.AccountcommonUserLinkedPlatformsResponseV3? Execute(
            this AdminGetUserPlatformAccountsV3.AdminGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetUserPlatformAccountsV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetUserPlatformAccountsV3(op);
        }

        public static List<Model.ModelGetUserMapping>? Execute(
            this AdminGetListJusticePlatformAccounts.AdminGetListJusticePlatformAccountsBuilder builder,
            string namespace_,
            string userId
        )
        {
            AdminGetListJusticePlatformAccounts op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).AdminGetListJusticePlatformAccounts(op);
        }

        public static Model.ModelCreateJusticeUserResponse? Execute(
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

            return ((Users)builder.WrapperObject!).AdminCreateJusticeUser(op);
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

            ((Users)builder.WrapperObject!).AdminLinkPlatformAccount(op);
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

            ((Users)builder.WrapperObject!).AdminPlatformUnlinkV3(op);
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

            ((Users)builder.WrapperObject!).AdminPlatformLinkV3(op);
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

            ((Users)builder.WrapperObject!).AdminDeleteUserRolesV3(op);
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

            ((Users)builder.WrapperObject!).AdminSaveUserRoleV3(op);
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

            ((Users)builder.WrapperObject!).AdminAddUserRoleV3(op);
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

            ((Users)builder.WrapperObject!).AdminDeleteUserRoleV3(op);
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

            ((Users)builder.WrapperObject!).AdminUpdateUserStatusV3(op);
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

            ((Users)builder.WrapperObject!).AdminVerifyUserWithoutVerificationCodeV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this AdminGetMyUserV3.AdminGetMyUserV3Builder builder
        )
        {
            AdminGetMyUserV3 op = builder.Build(
            );

            return ((Users)builder.WrapperObject!).AdminGetMyUserV3(op);
        }

        public static Model.AccountcommonUserPlatforms? Execute(
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

            return ((Users)builder.WrapperObject!).PublicListUserIDByPlatformUserIDsV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).PublicGetUserByPlatformUserIDV3(op);
        }

        public static Model.ModelLinkRequest? Execute(
            this PublicGetAsyncStatus.PublicGetAsyncStatusBuilder builder,
            string namespace_,
            string requestId
        )
        {
            PublicGetAsyncStatus op = builder.Build(
                namespace_,
                requestId
            );

            return ((Users)builder.WrapperObject!).PublicGetAsyncStatus(op);
        }

        public static Model.ModelPublicUserInformationResponseV3? Execute(
            this PublicSearchUserV3.PublicSearchUserV3Builder builder,
            string namespace_
        )
        {
            PublicSearchUserV3 op = builder.Build(
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicSearchUserV3(op);
        }

        public static Model.ModelUserCreateResponseV3? Execute(
            this PublicCreateUserV3.PublicCreateUserV3Builder builder,
            ModelUserCreateRequestV3 body,
            string namespace_
        )
        {
            PublicCreateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicCreateUserV3(op);
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

            ((Users)builder.WrapperObject!).CheckUserAvailability(op);
        }

        public static Model.ModelListBulkUserResponse? Execute(
            this PublicBulkGetUsers.PublicBulkGetUsersBuilder builder,
            ModelUserIDsRequest body,
            string namespace_
        )
        {
            PublicBulkGetUsers op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicBulkGetUsers(op);
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

            ((Users)builder.WrapperObject!).PublicSendRegistrationCode(op);
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

            ((Users)builder.WrapperObject!).PublicVerifyRegistrationCode(op);
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

            ((Users)builder.WrapperObject!).PublicForgotPasswordV3(op);
        }

        public static Model.ModelUserInvitationV3? Execute(
            this GetAdminInvitationV3.GetAdminInvitationV3Builder builder,
            string invitationId,
            string namespace_
        )
        {
            GetAdminInvitationV3 op = builder.Build(
                invitationId,
                namespace_
            );

            return ((Users)builder.WrapperObject!).GetAdminInvitationV3(op);
        }

        public static Model.ModelUserCreateResponseV3? Execute(
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

            return ((Users)builder.WrapperObject!).CreateUserFromInvitationV3(op);
        }

        public static List<Model.ModelUserResponseV3>? Execute(
            this UpdateUserV3.UpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            UpdateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).UpdateUserV3(op);
        }

        public static List<Model.ModelUserResponseV3>? Execute(
            this PublicUpdateUserV3.PublicUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PublicUpdateUserV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicUpdateUserV3(op);
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

            ((Users)builder.WrapperObject!).PublicSendVerificationCodeV3(op);
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

            ((Users)builder.WrapperObject!).PublicUserVerificationV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this PublicUpgradeHeadlessAccountV3.PublicUpgradeHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3 body,
            string namespace_
        )
        {
            PublicUpgradeHeadlessAccountV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicUpgradeHeadlessAccountV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this PublicVerifyHeadlessAccountV3.PublicVerifyHeadlessAccountV3Builder builder,
            ModelUpgradeHeadlessAccountV3Request body,
            string namespace_
        )
        {
            PublicVerifyHeadlessAccountV3 op = builder.Build(
                body,
                namespace_
            );

            return ((Users)builder.WrapperObject!).PublicVerifyHeadlessAccountV3(op);
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

            ((Users)builder.WrapperObject!).PublicUpdatePasswordV3(op);
        }

        public static Model.ModelCreateJusticeUserResponse? Execute(
            this PublicCreateJusticeUser.PublicCreateJusticeUserBuilder builder,
            string namespace_,
            string targetNamespace
        )
        {
            PublicCreateJusticeUser op = builder.Build(
                namespace_,
                targetNamespace
            );

            return ((Users)builder.WrapperObject!).PublicCreateJusticeUser(op);
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

            ((Users)builder.WrapperObject!).PublicPlatformLinkV3(op);
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

            ((Users)builder.WrapperObject!).PublicPlatformUnlinkV3(op);
        }

        public static Model.ModelWebLinkingResponse? Execute(
            this PublicWebLinkPlatform.PublicWebLinkPlatformBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PublicWebLinkPlatform op = builder.Build(
                namespace_,
                platformId
            );

            return ((Users)builder.WrapperObject!).PublicWebLinkPlatform(op);
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

            return ((Users)builder.WrapperObject!).PublicWebLinkPlatformEstablish(op);
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

            ((Users)builder.WrapperObject!).ResetPasswordV3(op);
        }

        public static Model.ModelPublicUserResponseV3? Execute(
            this PublicGetUserByUserIdV3.PublicGetUserByUserIdV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserByUserIdV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserByUserIdV3(op);
        }

        public static Model.ModelGetUserBanV3Response? Execute(
            this PublicGetUserBanHistoryV3.PublicGetUserBanHistoryV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserBanHistoryV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserBanHistoryV3(op);
        }

        public static Model.ModelLoginHistoriesResponse? Execute(
            this PublicGetUserLoginHistoriesV3.PublicGetUserLoginHistoriesV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserLoginHistoriesV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserLoginHistoriesV3(op);
        }

        public static Model.AccountcommonUserLinkedPlatformsResponseV3? Execute(
            this PublicGetUserPlatformAccountsV3.PublicGetUserPlatformAccountsV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PublicGetUserPlatformAccountsV3 op = builder.Build(
                namespace_,
                userId
            );

            return ((Users)builder.WrapperObject!).PublicGetUserPlatformAccountsV3(op);
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

            ((Users)builder.WrapperObject!).PublicLinkPlatformAccount(op);
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

            ((Users)builder.WrapperObject!).PublicValidateUserByUserIDAndPasswordV3(op);
        }

        public static Model.ModelUserResponseV3? Execute(
            this PublicGetMyUserV3.PublicGetMyUserV3Builder builder
        )
        {
            PublicGetMyUserV3 op = builder.Build(
            );

            return ((Users)builder.WrapperObject!).PublicGetMyUserV3(op);
        }

    }
}