# Iam Service Index

&nbsp;  

## Operations

### Bans Wrapper:  [Bans](../AccelByte.Sdk/Api/Iam/Wrapper/Bans.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/bans | GET | GetBansType | [GetBansType](../AccelByte.Sdk/Api/Iam/Operation//GetBansType.cs) |
| /iam/bans/reasons | GET | GetListBanReason | [GetListBanReason](../AccelByte.Sdk/Api/Iam/Operation//GetListBanReason.cs) |
| /iam/v3/admin/bans | GET | AdminGetBansTypeV3 | [AdminGetBansTypeV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetBansTypeV3.cs) |
| /iam/v3/admin/bans/reasons | GET | AdminGetListBanReasonV3 | [AdminGetListBanReasonV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetListBanReasonV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/bans/users | GET | AdminGetBannedUsersV3 | [AdminGetBannedUsersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetBannedUsersV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/bantypes | GET | AdminGetBansTypeWithNamespaceV3 | [AdminGetBansTypeWithNamespaceV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetBansTypeWithNamespaceV3.cs) |

### Clients Wrapper:  [Clients](../AccelByte.Sdk/Api/Iam/Wrapper/Clients.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/clients | GET | GetClients | [GetClients](../AccelByte.Sdk/Api/Iam/Operation//GetClients.cs) |
| /iam/clients | POST | CreateClient | [CreateClient](../AccelByte.Sdk/Api/Iam/Operation//CreateClient.cs) |
| /iam/clients/{clientId} | GET | GetClient | [GetClient](../AccelByte.Sdk/Api/Iam/Operation//GetClient.cs) |
| /iam/clients/{clientId} | PUT | UpdateClient | [UpdateClient](../AccelByte.Sdk/Api/Iam/Operation//UpdateClient.cs) |
| /iam/clients/{clientId} | DELETE | DeleteClient | [DeleteClient](../AccelByte.Sdk/Api/Iam/Operation//DeleteClient.cs) |
| /iam/clients/{clientId}/clientpermissions | POST | UpdateClientPermission | [UpdateClientPermission](../AccelByte.Sdk/Api/Iam/Operation//UpdateClientPermission.cs) |
| /iam/clients/{clientId}/clientpermissions/{resource}/{action} | POST | AddClientPermission | [AddClientPermission](../AccelByte.Sdk/Api/Iam/Operation//AddClientPermission.cs) |
| /iam/clients/{clientId}/clientpermissions/{resource}/{action} | DELETE | DeleteClientPermission | [DeleteClientPermission](../AccelByte.Sdk/Api/Iam/Operation//DeleteClientPermission.cs) |
| /iam/clients/{clientId}/secret | PUT | UpdateClientSecret | [UpdateClientSecret](../AccelByte.Sdk/Api/Iam/Operation//UpdateClientSecret.cs) |
| /iam/namespaces/{namespace}/clients | GET | GetClientsbyNamespace | [GetClientsbyNamespace](../AccelByte.Sdk/Api/Iam/Operation//GetClientsbyNamespace.cs) |
| /iam/namespaces/{namespace}/clients | POST | CreateClientByNamespace | [CreateClientByNamespace](../AccelByte.Sdk/Api/Iam/Operation//CreateClientByNamespace.cs) |
| /iam/namespaces/{namespace}/clients/{clientId} | DELETE | DeleteClientByNamespace | [DeleteClientByNamespace](../AccelByte.Sdk/Api/Iam/Operation//DeleteClientByNamespace.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients | GET | AdminGetClientsByNamespaceV3 | [AdminGetClientsByNamespaceV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetClientsByNamespaceV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients | POST | AdminCreateClientV3 | [AdminCreateClientV3](../AccelByte.Sdk/Api/Iam/Operation//AdminCreateClientV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId} | GET | AdminGetClientsbyNamespacebyIDV3 | [AdminGetClientsbyNamespacebyIDV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetClientsbyNamespacebyIDV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId} | DELETE | AdminDeleteClientV3 | [AdminDeleteClientV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteClientV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId} | PATCH | AdminUpdateClientV3 | [AdminUpdateClientV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateClientV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions | PUT | AdminUpdateClientPermissionV3 | [AdminUpdateClientPermissionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateClientPermissionV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions | POST | AdminAddClientPermissionsV3 | [AdminAddClientPermissionsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddClientPermissionsV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/clients/{clientId}/permissions/{resource}/{action} | DELETE | AdminDeleteClientPermissionV3 | [AdminDeleteClientPermissionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteClientPermissionV3.cs) |

### Users Wrapper:  [Users](../AccelByte.Sdk/Api/Iam/Wrapper/Users.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/namespaces/{namespace}/users | POST | CreateUser | [CreateUser](../AccelByte.Sdk/Api/Iam/Operation//CreateUser.cs) |
| /iam/namespaces/{namespace}/users/admin | GET | GetAdminUsersByRoleID | [GetAdminUsersByRoleID](../AccelByte.Sdk/Api/Iam/Operation//GetAdminUsersByRoleID.cs) |
| /iam/namespaces/{namespace}/users/byLoginId | GET | GetUserByLoginID | [GetUserByLoginID](../AccelByte.Sdk/Api/Iam/Operation//GetUserByLoginID.cs) |
| /iam/namespaces/{namespace}/users/byPlatformUserID | GET | GetUserByPlatformUserID | [GetUserByPlatformUserID](../AccelByte.Sdk/Api/Iam/Operation//GetUserByPlatformUserID.cs) |
| /iam/namespaces/{namespace}/users/forgotPassword | POST | ForgotPassword | [ForgotPassword](../AccelByte.Sdk/Api/Iam/Operation//ForgotPassword.cs) |
| /iam/namespaces/{namespace}/users/listByLoginIds | GET | GetUsersByLoginIds | [GetUsersByLoginIds](../AccelByte.Sdk/Api/Iam/Operation//GetUsersByLoginIds.cs) |
| /iam/namespaces/{namespace}/users/resetPassword | POST | ResetPassword | [ResetPassword](../AccelByte.Sdk/Api/Iam/Operation//ResetPassword.cs) |
| /iam/namespaces/{namespace}/users/search | GET | SearchUser | [SearchUser](../AccelByte.Sdk/Api/Iam/Operation//SearchUser.cs) |
| /iam/namespaces/{namespace}/users/{userId} | GET | GetUserByUserID | [GetUserByUserID](../AccelByte.Sdk/Api/Iam/Operation//GetUserByUserID.cs) |
| /iam/namespaces/{namespace}/users/{userId} | PUT | UpdateUser | [UpdateUser](../AccelByte.Sdk/Api/Iam/Operation//UpdateUser.cs) |
| /iam/namespaces/{namespace}/users/{userId} | DELETE | DeleteUser | [DeleteUser](../AccelByte.Sdk/Api/Iam/Operation//DeleteUser.cs) |
| /iam/namespaces/{namespace}/users/{userId}/ban | POST | BanUser | [BanUser](../AccelByte.Sdk/Api/Iam/Operation//BanUser.cs) |
| /iam/namespaces/{namespace}/users/{userId}/bans | GET | GetUserBanHistory | [GetUserBanHistory](../AccelByte.Sdk/Api/Iam/Operation//GetUserBanHistory.cs) |
| /iam/namespaces/{namespace}/users/{userId}/bans/{banId}/disable | PUT | DisableUserBan | [DisableUserBan](../AccelByte.Sdk/Api/Iam/Operation//DisableUserBan.cs) |
| /iam/namespaces/{namespace}/users/{userId}/bans/{banId}/enable | PUT | EnableUserBan | [EnableUserBan](../AccelByte.Sdk/Api/Iam/Operation//EnableUserBan.cs) |
| /iam/namespaces/{namespace}/users/{userId}/crosslink | POST | ListCrossNamespaceAccountLink | [ListCrossNamespaceAccountLink](../AccelByte.Sdk/Api/Iam/Operation//ListCrossNamespaceAccountLink.cs) |
| /iam/namespaces/{namespace}/users/{userId}/disable | PUT | DisableUser | [DisableUser](../AccelByte.Sdk/Api/Iam/Operation//DisableUser.cs) |
| /iam/namespaces/{namespace}/users/{userId}/enable | PUT | EnableUser | [EnableUser](../AccelByte.Sdk/Api/Iam/Operation//EnableUser.cs) |
| /iam/namespaces/{namespace}/users/{userId}/information | GET | GetUserInformation | [GetUserInformation](../AccelByte.Sdk/Api/Iam/Operation//GetUserInformation.cs) |
| /iam/namespaces/{namespace}/users/{userId}/information | DELETE | DeleteUserInformation | [DeleteUserInformation](../AccelByte.Sdk/Api/Iam/Operation//DeleteUserInformation.cs) |
| /iam/namespaces/{namespace}/users/{userId}/logins/histories | GET | GetUserLoginHistories | [GetUserLoginHistories](../AccelByte.Sdk/Api/Iam/Operation//GetUserLoginHistories.cs) |
| /iam/namespaces/{namespace}/users/{userId}/password | PUT | UpdatePassword | [UpdatePassword](../AccelByte.Sdk/Api/Iam/Operation//UpdatePassword.cs) |
| /iam/namespaces/{namespace}/users/{userId}/permissions | POST | SaveUserPermission | [SaveUserPermission](../AccelByte.Sdk/Api/Iam/Operation//SaveUserPermission.cs) |
| /iam/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action} | POST | AddUserPermission | [AddUserPermission](../AccelByte.Sdk/Api/Iam/Operation//AddUserPermission.cs) |
| /iam/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action} | DELETE | DeleteUserPermission | [DeleteUserPermission](../AccelByte.Sdk/Api/Iam/Operation//DeleteUserPermission.cs) |
| /iam/namespaces/{namespace}/users/{userId}/platforms | GET | GetUserPlatformAccounts | [GetUserPlatformAccounts](../AccelByte.Sdk/Api/Iam/Operation//GetUserPlatformAccounts.cs) |
| /iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace} | GET | GetUserMapping | [GetUserMapping](../AccelByte.Sdk/Api/Iam/Operation//GetUserMapping.cs) |
| /iam/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace} | POST | GetUserJusticePlatformAccount | [GetUserJusticePlatformAccount](../AccelByte.Sdk/Api/Iam/Operation//GetUserJusticePlatformAccount.cs) |
| /iam/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link | POST | PlatformLink | [PlatformLink](../AccelByte.Sdk/Api/Iam/Operation//PlatformLink.cs) |
| /iam/namespaces/{namespace}/users/{userId}/platforms/{platformId}/unlink | POST | PlatformUnlink | [PlatformUnlink](../AccelByte.Sdk/Api/Iam/Operation//PlatformUnlink.cs) |
| /iam/namespaces/{namespace}/users/{userId}/publisher | GET | GetPublisherUser | [GetPublisherUser](../AccelByte.Sdk/Api/Iam/Operation//GetPublisherUser.cs) |
| /iam/namespaces/{namespace}/users/{userId}/roles | POST | SaveUserRoles | [SaveUserRoles](../AccelByte.Sdk/Api/Iam/Operation//SaveUserRoles.cs) |
| /iam/namespaces/{namespace}/users/{userId}/roles/{roleId} | POST | AddUserRole | [AddUserRole](../AccelByte.Sdk/Api/Iam/Operation//AddUserRole.cs) |
| /iam/namespaces/{namespace}/users/{userId}/roles/{roleId} | DELETE | DeleteUserRole | [DeleteUserRole](../AccelByte.Sdk/Api/Iam/Operation//DeleteUserRole.cs) |
| /iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccount | POST | UpgradeHeadlessAccount | [UpgradeHeadlessAccount](../AccelByte.Sdk/Api/Iam/Operation//UpgradeHeadlessAccount.cs) |
| /iam/namespaces/{namespace}/users/{userId}/upgradeHeadlessAccountWithVerificationCode | POST | UpgradeHeadlessAccountWithVerificationCode | [UpgradeHeadlessAccountWithVerificationCode](../AccelByte.Sdk/Api/Iam/Operation//UpgradeHeadlessAccountWithVerificationCode.cs) |
| /iam/namespaces/{namespace}/users/{userId}/verification | POST | UserVerification | [UserVerification](../AccelByte.Sdk/Api/Iam/Operation//UserVerification.cs) |
| /iam/namespaces/{namespace}/users/{userId}/verificationcode | POST | SendVerificationCode | [SendVerificationCode](../AccelByte.Sdk/Api/Iam/Operation//SendVerificationCode.cs) |
| /iam/v2/admin/namespaces/{namespace}/agerestrictions | GET | AdminGetAgeRestrictionStatusV2 | [AdminGetAgeRestrictionStatusV2](../AccelByte.Sdk/Api/Iam/Operation//AdminGetAgeRestrictionStatusV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/agerestrictions | PATCH | AdminUpdateAgeRestrictionConfigV2 | [AdminUpdateAgeRestrictionConfigV2](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateAgeRestrictionConfigV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/countries/agerestrictions | GET | GetListCountryAgeRestriction | [GetListCountryAgeRestriction](../AccelByte.Sdk/Api/Iam/Operation//GetListCountryAgeRestriction.cs) |
| /iam/v2/admin/namespaces/{namespace}/countries/{countryCode} | PATCH | UpdateCountryAgeRestriction | [UpdateCountryAgeRestriction](../AccelByte.Sdk/Api/Iam/Operation//UpdateCountryAgeRestriction.cs) |
| /iam/v2/admin/namespaces/{namespace}/users | GET | AdminSearchUsersV2 | [AdminSearchUsersV2](../AccelByte.Sdk/Api/Iam/Operation//AdminSearchUsersV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId} | GET | AdminGetUserByUserIdV2 | [AdminGetUserByUserIdV2](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserByUserIdV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId} | PATCH | AdminUpdateUserV2 | [AdminUpdateUserV2](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/ban | POST | AdminBanUserV2 | [AdminBanUserV2](../AccelByte.Sdk/Api/Iam/Operation//AdminBanUserV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/bans | GET | AdminGetUserBanV2 | [AdminGetUserBanV2](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserBanV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/disable | PUT | AdminDisableUserV2 | [AdminDisableUserV2](../AccelByte.Sdk/Api/Iam/Operation//AdminDisableUserV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/enable | PUT | AdminEnableUserV2 | [AdminEnableUserV2](../AccelByte.Sdk/Api/Iam/Operation//AdminEnableUserV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/password | PUT | AdminResetPasswordV2 | [AdminResetPasswordV2](../AccelByte.Sdk/Api/Iam/Operation//AdminResetPasswordV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link | DELETE | AdminDeletePlatformLinkV2 | [AdminDeletePlatformLinkV2](../AccelByte.Sdk/Api/Iam/Operation//AdminDeletePlatformLinkV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/roles | PUT | AdminPutUserRolesV2 | [AdminPutUserRolesV2](../AccelByte.Sdk/Api/Iam/Operation//AdminPutUserRolesV2.cs) |
| /iam/v2/admin/namespaces/{namespace}/users/{userId}/roles | POST | AdminCreateUserRolesV2 | [AdminCreateUserRolesV2](../AccelByte.Sdk/Api/Iam/Operation//AdminCreateUserRolesV2.cs) |
| /iam/v2/public/namespaces/{namespace}/countries/{countryCode}/agerestrictions | GET | PublicGetCountryAgeRestriction | [PublicGetCountryAgeRestriction](../AccelByte.Sdk/Api/Iam/Operation//PublicGetCountryAgeRestriction.cs) |
| /iam/v2/public/namespaces/{namespace}/users | POST | PublicCreateUserV2 | [PublicCreateUserV2](../AccelByte.Sdk/Api/Iam/Operation//PublicCreateUserV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/forgotPassword | POST | PublicForgotPasswordV2 | [PublicForgotPasswordV2](../AccelByte.Sdk/Api/Iam/Operation//PublicForgotPasswordV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/resetPassword | POST | PublicResetPasswordV2 | [PublicResetPasswordV2](../AccelByte.Sdk/Api/Iam/Operation//PublicResetPasswordV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId} | GET | PublicGetUserByUserIDV2 | [PublicGetUserByUserIDV2](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserByUserIDV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId} | PATCH | PublicUpdateUserV2 | [PublicUpdateUserV2](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdateUserV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId}/bans | GET | PublicGetUserBan | [PublicGetUserBan](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserBan.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId}/password | PUT | PublicUpdatePasswordV2 | [PublicUpdatePasswordV2](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdatePasswordV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/justice | GET | GetListJusticePlatformAccounts | [GetListJusticePlatformAccounts](../AccelByte.Sdk/Api/Iam/Operation//GetListJusticePlatformAccounts.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link | POST | PublicPlatformLinkV2 | [PublicPlatformLinkV2](../AccelByte.Sdk/Api/Iam/Operation//PublicPlatformLinkV2.cs) |
| /iam/v2/public/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link | DELETE | PublicDeletePlatformLinkV2 | [PublicDeletePlatformLinkV2](../AccelByte.Sdk/Api/Iam/Operation//PublicDeletePlatformLinkV2.cs) |
| /iam/v3/admin/namespaces/{namespace}/admins | GET | ListAdminsV3 | [ListAdminsV3](../AccelByte.Sdk/Api/Iam/Operation//ListAdminsV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/agerestrictions | GET | AdminGetAgeRestrictionStatusV3 | [AdminGetAgeRestrictionStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetAgeRestrictionStatusV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/agerestrictions | PATCH | AdminUpdateAgeRestrictionConfigV3 | [AdminUpdateAgeRestrictionConfigV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateAgeRestrictionConfigV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/agerestrictions/countries | GET | AdminGetListCountryAgeRestrictionV3 | [AdminGetListCountryAgeRestrictionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetListCountryAgeRestrictionV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/agerestrictions/countries/{countryCode} | PATCH | AdminUpdateCountryAgeRestrictionV3 | [AdminUpdateCountryAgeRestrictionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateCountryAgeRestrictionV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} | GET | AdminGetUserByPlatformUserIDV3 | [AdminGetUserByPlatformUserIDV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserByPlatformUserIDV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/roles/{roleId}/users | GET | GetAdminUsersByRoleIdV3 | [GetAdminUsersByRoleIdV3](../AccelByte.Sdk/Api/Iam/Operation//GetAdminUsersByRoleIdV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users | GET | AdminGetUserByEmailAddressV3 | [AdminGetUserByEmailAddressV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserByEmailAddressV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/bulk | POST | AdminListUserIDByUserIDsV3 | [AdminListUserIDByUserIDsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminListUserIDByUserIDsV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/invite | POST | AdminInviteUserV3 | [AdminInviteUserV3](../AccelByte.Sdk/Api/Iam/Operation//AdminInviteUserV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/platforms/justice | GET | AdminListUsersV3 | [AdminListUsersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminListUsersV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/search | GET | AdminSearchUserV3 | [AdminSearchUserV3](../AccelByte.Sdk/Api/Iam/Operation//AdminSearchUserV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/search/bulk | POST | AdminGetBulkUserByEmailAddressV3 | [AdminGetBulkUserByEmailAddressV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetBulkUserByEmailAddressV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId} | GET | AdminGetUserByUserIdV3 | [AdminGetUserByUserIdV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserByUserIdV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId} | PATCH | AdminUpdateUserV3 | [AdminUpdateUserV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans | GET | AdminGetUserBanV3 | [AdminGetUserBanV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserBanV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans | POST | AdminBanUserV3 | [AdminBanUserV3](../AccelByte.Sdk/Api/Iam/Operation//AdminBanUserV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/bans/{banId} | PATCH | AdminUpdateUserBanV3 | [AdminUpdateUserBanV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserBanV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/code/request | POST | AdminSendVerificationCodeV3 | [AdminSendVerificationCodeV3](../AccelByte.Sdk/Api/Iam/Operation//AdminSendVerificationCodeV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/code/verify | POST | AdminVerifyAccountV3 | [AdminVerifyAccountV3](../AccelByte.Sdk/Api/Iam/Operation//AdminVerifyAccountV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/codes | GET | GetUserVerificationCode | [GetUserVerificationCode](../AccelByte.Sdk/Api/Iam/Operation//GetUserVerificationCode.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/deletion/status | GET | AdminGetUserDeletionStatusV3 | [AdminGetUserDeletionStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserDeletionStatusV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/deletion/status | PATCH | AdminUpdateUserDeletionStatusV3 | [AdminUpdateUserDeletionStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserDeletionStatusV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/headless/code/verify | POST | AdminUpgradeHeadlessAccountV3 | [AdminUpgradeHeadlessAccountV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpgradeHeadlessAccountV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/information | DELETE | AdminDeleteUserInformationV3 | [AdminDeleteUserInformationV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteUserInformationV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/logins/histories | GET | AdminGetUserLoginHistoriesV3 | [AdminGetUserLoginHistoriesV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserLoginHistoriesV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions | PUT | AdminUpdateUserPermissionV3 | [AdminUpdateUserPermissionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserPermissionV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions | POST | AdminAddUserPermissionsV3 | [AdminAddUserPermissionsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddUserPermissionsV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions | DELETE | AdminDeleteUserPermissionBulkV3 | [AdminDeleteUserPermissionBulkV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteUserPermissionBulkV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action} | DELETE | AdminDeleteUserPermissionV3 | [AdminDeleteUserPermissionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteUserPermissionV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms | GET | AdminGetUserPlatformAccountsV3 | [AdminGetUserPlatformAccountsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetUserPlatformAccountsV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice | GET | AdminGetListJusticePlatformAccounts | [AdminGetListJusticePlatformAccounts](../AccelByte.Sdk/Api/Iam/Operation//AdminGetListJusticePlatformAccounts.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace} | POST | AdminCreateJusticeUser | [AdminCreateJusticeUser](../AccelByte.Sdk/Api/Iam/Operation//AdminCreateJusticeUser.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/link | POST | AdminLinkPlatformAccount | [AdminLinkPlatformAccount](../AccelByte.Sdk/Api/Iam/Operation//AdminLinkPlatformAccount.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId} | DELETE | AdminPlatformUnlinkV3 | [AdminPlatformUnlinkV3](../AccelByte.Sdk/Api/Iam/Operation//AdminPlatformUnlinkV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/link | POST | AdminPlatformLinkV3 | [AdminPlatformLinkV3](../AccelByte.Sdk/Api/Iam/Operation//AdminPlatformLinkV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/roles | DELETE | AdminDeleteUserRolesV3 | [AdminDeleteUserRolesV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteUserRolesV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/roles | PATCH | AdminSaveUserRoleV3 | [AdminSaveUserRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminSaveUserRoleV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/roles/{roleId} | POST | AdminAddUserRoleV3 | [AdminAddUserRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddUserRoleV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/roles/{roleId} | DELETE | AdminDeleteUserRoleV3 | [AdminDeleteUserRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteUserRoleV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/status | PATCH | AdminUpdateUserStatusV3 | [AdminUpdateUserStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserStatusV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/users/{userId}/verify | PUT | AdminVerifyUserWithoutVerificationCodeV3 | [AdminVerifyUserWithoutVerificationCodeV3](../AccelByte.Sdk/Api/Iam/Operation//AdminVerifyUserWithoutVerificationCodeV3.cs) |
| /iam/v3/admin/users/me | GET | AdminGetMyUserV3 | [AdminGetMyUserV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetMyUserV3.cs) |
| /iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users | POST | PublicListUserIDByPlatformUserIDsV3 | [PublicListUserIDByPlatformUserIDsV3](../AccelByte.Sdk/Api/Iam/Operation//PublicListUserIDByPlatformUserIDsV3.cs) |
| /iam/v3/public/namespaces/{namespace}/platforms/{platformId}/users/{platformUserId} | GET | PublicGetUserByPlatformUserIDV3 | [PublicGetUserByPlatformUserIDV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserByPlatformUserIDV3.cs) |
| /iam/v3/public/namespaces/{namespace}/requests/{requestId}/async/status | GET | PublicGetAsyncStatus | [PublicGetAsyncStatus](../AccelByte.Sdk/Api/Iam/Operation//PublicGetAsyncStatus.cs) |
| /iam/v3/public/namespaces/{namespace}/users | GET | PublicSearchUserV3 | [PublicSearchUserV3](../AccelByte.Sdk/Api/Iam/Operation//PublicSearchUserV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users | POST | PublicCreateUserV3 | [PublicCreateUserV3](../AccelByte.Sdk/Api/Iam/Operation//PublicCreateUserV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/availability | GET | CheckUserAvailability | [CheckUserAvailability](../AccelByte.Sdk/Api/Iam/Operation//CheckUserAvailability.cs) |
| /iam/v3/public/namespaces/{namespace}/users/bulk/basic | POST | PublicBulkGetUsers | [PublicBulkGetUsers](../AccelByte.Sdk/Api/Iam/Operation//PublicBulkGetUsers.cs) |
| /iam/v3/public/namespaces/{namespace}/users/code/request | POST | PublicSendRegistrationCode | [PublicSendRegistrationCode](../AccelByte.Sdk/Api/Iam/Operation//PublicSendRegistrationCode.cs) |
| /iam/v3/public/namespaces/{namespace}/users/code/verify | POST | PublicVerifyRegistrationCode | [PublicVerifyRegistrationCode](../AccelByte.Sdk/Api/Iam/Operation//PublicVerifyRegistrationCode.cs) |
| /iam/v3/public/namespaces/{namespace}/users/forgot | POST | PublicForgotPasswordV3 | [PublicForgotPasswordV3](../AccelByte.Sdk/Api/Iam/Operation//PublicForgotPasswordV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/invite/{invitationId} | GET | GetAdminInvitationV3 | [GetAdminInvitationV3](../AccelByte.Sdk/Api/Iam/Operation//GetAdminInvitationV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/invite/{invitationId} | POST | CreateUserFromInvitationV3 | [CreateUserFromInvitationV3](../AccelByte.Sdk/Api/Iam/Operation//CreateUserFromInvitationV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me | PUT | UpdateUserV3 | [UpdateUserV3](../AccelByte.Sdk/Api/Iam/Operation//UpdateUserV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me | PATCH | PublicUpdateUserV3 | [PublicUpdateUserV3](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdateUserV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/code/request | POST | PublicSendVerificationCodeV3 | [PublicSendVerificationCodeV3](../AccelByte.Sdk/Api/Iam/Operation//PublicSendVerificationCodeV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/code/verify | POST | PublicUserVerificationV3 | [PublicUserVerificationV3](../AccelByte.Sdk/Api/Iam/Operation//PublicUserVerificationV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/headless/code/verify | POST | PublicUpgradeHeadlessAccountV3 | [PublicUpgradeHeadlessAccountV3](../AccelByte.Sdk/Api/Iam/Operation//PublicUpgradeHeadlessAccountV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/headless/verify | POST | PublicVerifyHeadlessAccountV3 | [PublicVerifyHeadlessAccountV3](../AccelByte.Sdk/Api/Iam/Operation//PublicVerifyHeadlessAccountV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/password | PUT | PublicUpdatePasswordV3 | [PublicUpdatePasswordV3](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdatePasswordV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/platforms/justice/{targetNamespace} | POST | PublicCreateJusticeUser | [PublicCreateJusticeUser](../AccelByte.Sdk/Api/Iam/Operation//PublicCreateJusticeUser.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId} | POST | PublicPlatformLinkV3 | [PublicPlatformLinkV3](../AccelByte.Sdk/Api/Iam/Operation//PublicPlatformLinkV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId} | DELETE | PublicPlatformUnlinkV3 | [PublicPlatformUnlinkV3](../AccelByte.Sdk/Api/Iam/Operation//PublicPlatformUnlinkV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link | GET | PublicWebLinkPlatform | [PublicWebLinkPlatform](../AccelByte.Sdk/Api/Iam/Operation//PublicWebLinkPlatform.cs) |
| /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link/establish | GET | PublicWebLinkPlatformEstablish | [PublicWebLinkPlatformEstablish](../AccelByte.Sdk/Api/Iam/Operation//PublicWebLinkPlatformEstablish.cs) |
| /iam/v3/public/namespaces/{namespace}/users/reset | POST | ResetPasswordV3 | [ResetPasswordV3](../AccelByte.Sdk/Api/Iam/Operation//ResetPasswordV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId} | GET | PublicGetUserByUserIdV3 | [PublicGetUserByUserIdV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserByUserIdV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId}/bans | GET | PublicGetUserBanHistoryV3 | [PublicGetUserBanHistoryV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserBanHistoryV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId}/logins/histories | GET | PublicGetUserLoginHistoriesV3 | [PublicGetUserLoginHistoriesV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserLoginHistoriesV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId}/platforms | GET | PublicGetUserPlatformAccountsV3 | [PublicGetUserPlatformAccountsV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetUserPlatformAccountsV3.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/link | POST | PublicLinkPlatformAccount | [PublicLinkPlatformAccount](../AccelByte.Sdk/Api/Iam/Operation//PublicLinkPlatformAccount.cs) |
| /iam/v3/public/namespaces/{namespace}/users/{userId}/validate | POST | PublicValidateUserByUserIDAndPasswordV3 | [PublicValidateUserByUserIDAndPasswordV3](../AccelByte.Sdk/Api/Iam/Operation//PublicValidateUserByUserIDAndPasswordV3.cs) |
| /iam/v3/public/users/me | GET | PublicGetMyUserV3 | [PublicGetMyUserV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetMyUserV3.cs) |

### OAuth Wrapper:  [OAuth](../AccelByte.Sdk/Api/Iam/Wrapper/OAuth.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/oauth/authorize | POST | Authorization | [Authorization](../AccelByte.Sdk/Api/Iam/Operation//Authorization.cs) |
| /iam/oauth/jwks | GET | GetJWKS | [GetJWKS](../AccelByte.Sdk/Api/Iam/Operation//GetJWKS.cs) |
| /iam/oauth/namespaces/{namespace}/platforms/{platformId}/token | POST | PlatformTokenRequestHandler | [PlatformTokenRequestHandler](../AccelByte.Sdk/Api/Iam/Operation//PlatformTokenRequestHandler.cs) |
| /iam/oauth/namespaces/{namespace}/users/{userId}/revoke | POST | RevokeUser | [RevokeUser](../AccelByte.Sdk/Api/Iam/Operation//RevokeUser.cs) |
| /iam/oauth/revocationlist | GET | GetRevocationList | [GetRevocationList](../AccelByte.Sdk/Api/Iam/Operation//GetRevocationList.cs) |
| /iam/oauth/revoke/token | POST | RevokeToken | [RevokeToken](../AccelByte.Sdk/Api/Iam/Operation//RevokeToken.cs) |
| /iam/oauth/revoke/user | POST | RevokeAUser | [RevokeAUser](../AccelByte.Sdk/Api/Iam/Operation//RevokeAUser.cs) |
| /iam/oauth/token | POST | TokenGrant | [TokenGrant](../AccelByte.Sdk/Api/Iam/Operation//TokenGrant.cs) |
| /iam/oauth/verify | POST | VerifyToken | [VerifyToken](../AccelByte.Sdk/Api/Iam/Operation//VerifyToken.cs) |

### Roles Wrapper:  [Roles](../AccelByte.Sdk/Api/Iam/Wrapper/Roles.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/roles | GET | GetRoles | [GetRoles](../AccelByte.Sdk/Api/Iam/Operation//GetRoles.cs) |
| /iam/roles | POST | CreateRole | [CreateRole](../AccelByte.Sdk/Api/Iam/Operation//CreateRole.cs) |
| /iam/roles/{roleId} | GET | GetRole | [GetRole](../AccelByte.Sdk/Api/Iam/Operation//GetRole.cs) |
| /iam/roles/{roleId} | PUT | UpdateRole | [UpdateRole](../AccelByte.Sdk/Api/Iam/Operation//UpdateRole.cs) |
| /iam/roles/{roleId} | DELETE | DeleteRole | [DeleteRole](../AccelByte.Sdk/Api/Iam/Operation//DeleteRole.cs) |
| /iam/roles/{roleId}/admin | GET | GetRoleAdminStatus | [GetRoleAdminStatus](../AccelByte.Sdk/Api/Iam/Operation//GetRoleAdminStatus.cs) |
| /iam/roles/{roleId}/admin | POST | SetRoleAsAdmin | [SetRoleAsAdmin](../AccelByte.Sdk/Api/Iam/Operation//SetRoleAsAdmin.cs) |
| /iam/roles/{roleId}/admin | DELETE | RemoveRoleAdmin | [RemoveRoleAdmin](../AccelByte.Sdk/Api/Iam/Operation//RemoveRoleAdmin.cs) |
| /iam/roles/{roleId}/managers | GET | GetRoleManagers | [GetRoleManagers](../AccelByte.Sdk/Api/Iam/Operation//GetRoleManagers.cs) |
| /iam/roles/{roleId}/managers | POST | AddRoleManagers | [AddRoleManagers](../AccelByte.Sdk/Api/Iam/Operation//AddRoleManagers.cs) |
| /iam/roles/{roleId}/managers | DELETE | RemoveRoleManagers | [RemoveRoleManagers](../AccelByte.Sdk/Api/Iam/Operation//RemoveRoleManagers.cs) |
| /iam/roles/{roleId}/members | GET | GetRoleMembers | [GetRoleMembers](../AccelByte.Sdk/Api/Iam/Operation//GetRoleMembers.cs) |
| /iam/roles/{roleId}/members | POST | AddRoleMembers | [AddRoleMembers](../AccelByte.Sdk/Api/Iam/Operation//AddRoleMembers.cs) |
| /iam/roles/{roleId}/members | DELETE | RemoveRoleMembers | [RemoveRoleMembers](../AccelByte.Sdk/Api/Iam/Operation//RemoveRoleMembers.cs) |
| /iam/roles/{roleId}/permissions | POST | UpdateRolePermissions | [UpdateRolePermissions](../AccelByte.Sdk/Api/Iam/Operation//UpdateRolePermissions.cs) |
| /iam/roles/{roleId}/permissions/{resource}/{action} | POST | AddRolePermission | [AddRolePermission](../AccelByte.Sdk/Api/Iam/Operation//AddRolePermission.cs) |
| /iam/roles/{roleId}/permissions/{resource}/{action} | DELETE | DeleteRolePermission | [DeleteRolePermission](../AccelByte.Sdk/Api/Iam/Operation//DeleteRolePermission.cs) |
| /iam/v3/admin/roles | GET | AdminGetRolesV3 | [AdminGetRolesV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRolesV3.cs) |
| /iam/v3/admin/roles | POST | AdminCreateRoleV3 | [AdminCreateRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminCreateRoleV3.cs) |
| /iam/v3/admin/roles/{roleId} | GET | AdminGetRoleV3 | [AdminGetRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRoleV3.cs) |
| /iam/v3/admin/roles/{roleId} | DELETE | AdminDeleteRoleV3 | [AdminDeleteRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteRoleV3.cs) |
| /iam/v3/admin/roles/{roleId} | PATCH | AdminUpdateRoleV3 | [AdminUpdateRoleV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateRoleV3.cs) |
| /iam/v3/admin/roles/{roleId}/admin | GET | AdminGetRoleAdminStatusV3 | [AdminGetRoleAdminStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRoleAdminStatusV3.cs) |
| /iam/v3/admin/roles/{roleId}/admin | POST | AdminUpdateAdminRoleStatusV3 | [AdminUpdateAdminRoleStatusV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateAdminRoleStatusV3.cs) |
| /iam/v3/admin/roles/{roleId}/admin | DELETE | AdminRemoveRoleAdminV3 | [AdminRemoveRoleAdminV3](../AccelByte.Sdk/Api/Iam/Operation//AdminRemoveRoleAdminV3.cs) |
| /iam/v3/admin/roles/{roleId}/managers | GET | AdminGetRoleManagersV3 | [AdminGetRoleManagersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRoleManagersV3.cs) |
| /iam/v3/admin/roles/{roleId}/managers | POST | AdminAddRoleManagersV3 | [AdminAddRoleManagersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddRoleManagersV3.cs) |
| /iam/v3/admin/roles/{roleId}/managers | DELETE | AdminRemoveRoleManagersV3 | [AdminRemoveRoleManagersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminRemoveRoleManagersV3.cs) |
| /iam/v3/admin/roles/{roleId}/members | GET | AdminGetRoleMembersV3 | [AdminGetRoleMembersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRoleMembersV3.cs) |
| /iam/v3/admin/roles/{roleId}/members | POST | AdminAddRoleMembersV3 | [AdminAddRoleMembersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddRoleMembersV3.cs) |
| /iam/v3/admin/roles/{roleId}/members | DELETE | AdminRemoveRoleMembersV3 | [AdminRemoveRoleMembersV3](../AccelByte.Sdk/Api/Iam/Operation//AdminRemoveRoleMembersV3.cs) |
| /iam/v3/admin/roles/{roleId}/permissions | PUT | AdminUpdateRolePermissionsV3 | [AdminUpdateRolePermissionsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateRolePermissionsV3.cs) |
| /iam/v3/admin/roles/{roleId}/permissions | POST | AdminAddRolePermissionsV3 | [AdminAddRolePermissionsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminAddRolePermissionsV3.cs) |
| /iam/v3/admin/roles/{roleId}/permissions | DELETE | AdminDeleteRolePermissionsV3 | [AdminDeleteRolePermissionsV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteRolePermissionsV3.cs) |
| /iam/v3/admin/roles/{roleId}/permissions/{resource}/{action} | DELETE | AdminDeleteRolePermissionV3 | [AdminDeleteRolePermissionV3](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteRolePermissionV3.cs) |
| /iam/v3/public/roles | GET | PublicGetRolesV3 | [PublicGetRolesV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetRolesV3.cs) |
| /iam/v3/public/roles/{roleId} | GET | PublicGetRoleV3 | [PublicGetRoleV3](../AccelByte.Sdk/Api/Iam/Operation//PublicGetRoleV3.cs) |
| /iam/v4/admin/roles | GET | AdminGetRolesV4 | [AdminGetRolesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRolesV4.cs) |
| /iam/v4/admin/roles | POST | AdminCreateRoleV4 | [AdminCreateRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminCreateRoleV4.cs) |
| /iam/v4/admin/roles/{roleId} | GET | AdminGetRoleV4 | [AdminGetRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGetRoleV4.cs) |
| /iam/v4/admin/roles/{roleId} | DELETE | AdminDeleteRoleV4 | [AdminDeleteRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteRoleV4.cs) |
| /iam/v4/admin/roles/{roleId} | PATCH | AdminUpdateRoleV4 | [AdminUpdateRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateRoleV4.cs) |
| /iam/v4/admin/roles/{roleId}/permissions | PUT | AdminUpdateRolePermissionsV4 | [AdminUpdateRolePermissionsV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateRolePermissionsV4.cs) |
| /iam/v4/admin/roles/{roleId}/permissions | POST | AdminAddRolePermissionsV4 | [AdminAddRolePermissionsV4](../AccelByte.Sdk/Api/Iam/Operation//AdminAddRolePermissionsV4.cs) |
| /iam/v4/admin/roles/{roleId}/permissions | DELETE | AdminDeleteRolePermissionsV4 | [AdminDeleteRolePermissionsV4](../AccelByte.Sdk/Api/Iam/Operation//AdminDeleteRolePermissionsV4.cs) |
| /iam/v4/admin/roles/{roleId}/users | GET | AdminListAssignedUsersV4 | [AdminListAssignedUsersV4](../AccelByte.Sdk/Api/Iam/Operation//AdminListAssignedUsersV4.cs) |
| /iam/v4/admin/roles/{roleId}/users | POST | AdminAssignUserToRoleV4 | [AdminAssignUserToRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminAssignUserToRoleV4.cs) |
| /iam/v4/admin/roles/{roleId}/users | DELETE | AdminRevokeUserFromRoleV4 | [AdminRevokeUserFromRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminRevokeUserFromRoleV4.cs) |

### InputValidations Wrapper:  [InputValidations](../AccelByte.Sdk/Api/Iam/Wrapper/InputValidations.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/admin/inputValidations | GET | AdminGetInputValidations | [AdminGetInputValidations](../AccelByte.Sdk/Api/Iam/Operation//AdminGetInputValidations.cs) |
| /iam/v3/admin/inputValidations | PUT | AdminUpdateInputValidations | [AdminUpdateInputValidations](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateInputValidations.cs) |
| /iam/v3/admin/inputValidations/{field} | DELETE | AdminResetInputValidations | [AdminResetInputValidations](../AccelByte.Sdk/Api/Iam/Operation//AdminResetInputValidations.cs) |
| /iam/v3/public/inputValidations | GET | PublicGetInputValidations | [PublicGetInputValidations](../AccelByte.Sdk/Api/Iam/Operation//PublicGetInputValidations.cs) |

### Third Party Credential Wrapper:  [ThirdPartyCredential](../AccelByte.Sdk/Api/Iam/Wrapper/ThirdPartyCredential.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/admin/namespaces/{namespace}/platforms/all/clients | GET | RetrieveAllThirdPartyLoginPlatformCredentialV3 | [RetrieveAllThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveAllThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/all/clients/active | GET | RetrieveAllActiveThirdPartyLoginPlatformCredentialV3 | [RetrieveAllActiveThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveAllActiveThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients | GET | RetrieveThirdPartyLoginPlatformCredentialV3 | [RetrieveThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients | POST | AddThirdPartyLoginPlatformCredentialV3 | [AddThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//AddThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients | DELETE | DeleteThirdPartyLoginPlatformCredentialV3 | [DeleteThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//DeleteThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients | PATCH | UpdateThirdPartyLoginPlatformCredentialV3 | [UpdateThirdPartyLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//UpdateThirdPartyLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients/domain | PUT | UpdateThirdPartyLoginPlatformDomainV3 | [UpdateThirdPartyLoginPlatformDomainV3](../AccelByte.Sdk/Api/Iam/Operation//UpdateThirdPartyLoginPlatformDomainV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients/domain | DELETE | DeleteThirdPartyLoginPlatformDomainV3 | [DeleteThirdPartyLoginPlatformDomainV3](../AccelByte.Sdk/Api/Iam/Operation//DeleteThirdPartyLoginPlatformDomainV3.cs) |
| /iam/v3/public/namespaces/{namespace}/platforms/clients/active | GET | RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 | [RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3.cs) |

### SSO Credential Wrapper:  [SSOCredential](../AccelByte.Sdk/Api/Iam/Wrapper/SSOCredential.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/admin/namespaces/{namespace}/platforms/sso | GET | RetrieveAllSSOLoginPlatformCredentialV3 | [RetrieveAllSSOLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveAllSSOLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso | GET | RetrieveSSOLoginPlatformCredential | [RetrieveSSOLoginPlatformCredential](../AccelByte.Sdk/Api/Iam/Operation//RetrieveSSOLoginPlatformCredential.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso | POST | AddSSOLoginPlatformCredential | [AddSSOLoginPlatformCredential](../AccelByte.Sdk/Api/Iam/Operation//AddSSOLoginPlatformCredential.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso | DELETE | DeleteSSOLoginPlatformCredentialV3 | [DeleteSSOLoginPlatformCredentialV3](../AccelByte.Sdk/Api/Iam/Operation//DeleteSSOLoginPlatformCredentialV3.cs) |
| /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/sso | PATCH | UpdateSSOPlatformCredential | [UpdateSSOPlatformCredential](../AccelByte.Sdk/Api/Iam/Operation//UpdateSSOPlatformCredential.cs) |

### OAuth2.0 - Extension Wrapper:  [OAuth20Extension](../AccelByte.Sdk/Api/Iam/Wrapper/OAuth20Extension.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/authenticate | POST | UserAuthenticationV3 | [UserAuthenticationV3](../AccelByte.Sdk/Api/Iam/Operation//UserAuthenticationV3.cs) |
| /iam/v3/location/country | GET | GetCountryLocationV3 | [GetCountryLocationV3](../AccelByte.Sdk/Api/Iam/Operation//GetCountryLocationV3.cs) |
| /iam/v3/logout | POST | Logout | [Logout](../AccelByte.Sdk/Api/Iam/Operation//Logout.cs) |
| /iam/v3/platforms/{platformId}/authenticate | GET | PlatformAuthenticationV3 | [PlatformAuthenticationV3](../AccelByte.Sdk/Api/Iam/Operation//PlatformAuthenticationV3.cs) |

### OAuth2.0 Wrapper:  [OAuth20](../AccelByte.Sdk/Api/Iam/Wrapper/OAuth20.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken | GET | AdminRetrieveUserThirdPartyPlatformTokenV3 | [AdminRetrieveUserThirdPartyPlatformTokenV3](../AccelByte.Sdk/Api/Iam/Operation//AdminRetrieveUserThirdPartyPlatformTokenV3.cs) |
| /iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/revoke | POST | RevokeUserV3 | [RevokeUserV3](../AccelByte.Sdk/Api/Iam/Operation//RevokeUserV3.cs) |
| /iam/v3/oauth/authorize | GET | AuthorizeV3 | [AuthorizeV3](../AccelByte.Sdk/Api/Iam/Operation//AuthorizeV3.cs) |
| /iam/v3/oauth/introspect | POST | TokenIntrospectionV3 | [TokenIntrospectionV3](../AccelByte.Sdk/Api/Iam/Operation//TokenIntrospectionV3.cs) |
| /iam/v3/oauth/jwks | GET | GetJWKSV3 | [GetJWKSV3](../AccelByte.Sdk/Api/Iam/Operation//GetJWKSV3.cs) |
| /iam/v3/oauth/mfa/factor/change | POST | Change2faMethod | [Change2faMethod](../AccelByte.Sdk/Api/Iam/Operation//Change2faMethod.cs) |
| /iam/v3/oauth/mfa/verify | POST | Verify2faCode | [Verify2faCode](../AccelByte.Sdk/Api/Iam/Operation//Verify2faCode.cs) |
| /iam/v3/oauth/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken | GET | RetrieveUserThirdPartyPlatformTokenV3 | [RetrieveUserThirdPartyPlatformTokenV3](../AccelByte.Sdk/Api/Iam/Operation//RetrieveUserThirdPartyPlatformTokenV3.cs) |
| /iam/v3/oauth/platforms/{platformId}/authorize | GET | AuthCodeRequestV3 | [AuthCodeRequestV3](../AccelByte.Sdk/Api/Iam/Operation//AuthCodeRequestV3.cs) |
| /iam/v3/oauth/platforms/{platformId}/token | POST | PlatformTokenGrantV3 | [PlatformTokenGrantV3](../AccelByte.Sdk/Api/Iam/Operation//PlatformTokenGrantV3.cs) |
| /iam/v3/oauth/revocationlist | GET | GetRevocationListV3 | [GetRevocationListV3](../AccelByte.Sdk/Api/Iam/Operation//GetRevocationListV3.cs) |
| /iam/v3/oauth/revoke | POST | TokenRevocationV3 | [TokenRevocationV3](../AccelByte.Sdk/Api/Iam/Operation//TokenRevocationV3.cs) |
| /iam/v3/oauth/token | POST | TokenGrantV3 | [TokenGrantV3](../AccelByte.Sdk/Api/Iam/Operation//TokenGrantV3.cs) |

### SSO SAML 2.0 Wrapper:  [SSOSAML20](../AccelByte.Sdk/Api/Iam/Wrapper/SSOSAML20.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/sso/saml/platforms/{platformId}/authenticate | POST | PlatformAuthenticateSAMLV3Handler | [PlatformAuthenticateSAMLV3Handler](../AccelByte.Sdk/Api/Iam/Operation//PlatformAuthenticateSAMLV3Handler.cs) |

### SSO Wrapper:  [SSO](../AccelByte.Sdk/Api/Iam/Wrapper/SSO.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v3/sso/{platformId} | GET | LoginSSOClient | [LoginSSOClient](../AccelByte.Sdk/Api/Iam/Operation//LoginSSOClient.cs) |
| /iam/v3/sso/{platformId}/logout | POST | LogoutSSOClient | [LogoutSSOClient](../AccelByte.Sdk/Api/Iam/Operation//LogoutSSOClient.cs) |

### Users V4 Wrapper:  [UsersV4](../AccelByte.Sdk/Api/Iam/Wrapper/UsersV4.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /iam/v4/admin/namespaces/{namespace}/users/bulk/validate | POST | AdminBulkCheckValidUserIDV4 | [AdminBulkCheckValidUserIDV4](../AccelByte.Sdk/Api/Iam/Operation//AdminBulkCheckValidUserIDV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId} | PUT | AdminUpdateUserV4 | [AdminUpdateUserV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId}/email | PUT | AdminUpdateUserEmailAddressV4 | [AdminUpdateUserEmailAddressV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserEmailAddressV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId}/roles | GET | AdminListUserRolesV4 | [AdminListUserRolesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminListUserRolesV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId}/roles | PUT | AdminUpdateUserRoleV4 | [AdminUpdateUserRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateUserRoleV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId}/roles | POST | AdminAddUserRoleV4 | [AdminAddUserRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminAddUserRoleV4.cs) |
| /iam/v4/admin/namespaces/{namespace}/users/{userId}/roles | DELETE | AdminRemoveUserRoleV4 | [AdminRemoveUserRoleV4](../AccelByte.Sdk/Api/Iam/Operation//AdminRemoveUserRoleV4.cs) |
| /iam/v4/admin/users/me | PATCH | AdminUpdateMyUserV4 | [AdminUpdateMyUserV4](../AccelByte.Sdk/Api/Iam/Operation//AdminUpdateMyUserV4.cs) |
| /iam/v4/admin/users/me/mfa/authenticator/disable | DELETE | AdminDisableMyAuthenticatorV4 | [AdminDisableMyAuthenticatorV4](../AccelByte.Sdk/Api/Iam/Operation//AdminDisableMyAuthenticatorV4.cs) |
| /iam/v4/admin/users/me/mfa/authenticator/enable | POST | AdminEnableMyAuthenticatorV4 | [AdminEnableMyAuthenticatorV4](../AccelByte.Sdk/Api/Iam/Operation//AdminEnableMyAuthenticatorV4.cs) |
| /iam/v4/admin/users/me/mfa/authenticator/key | POST | AdminGenerateMyAuthenticatorKeyV4 | [AdminGenerateMyAuthenticatorKeyV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGenerateMyAuthenticatorKeyV4.cs) |
| /iam/v4/admin/users/me/mfa/backupCode | GET | AdminGetMyBackupCodesV4 | [AdminGetMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGetMyBackupCodesV4.cs) |
| /iam/v4/admin/users/me/mfa/backupCode | POST | AdminGenerateMyBackupCodesV4 | [AdminGenerateMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGenerateMyBackupCodesV4.cs) |
| /iam/v4/admin/users/me/mfa/backupCode/disable | DELETE | AdminDisableMyBackupCodesV4 | [AdminDisableMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminDisableMyBackupCodesV4.cs) |
| /iam/v4/admin/users/me/mfa/backupCode/download | GET | AdminDownloadMyBackupCodesV4 | [AdminDownloadMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminDownloadMyBackupCodesV4.cs) |
| /iam/v4/admin/users/me/mfa/backupCode/enable | POST | AdminEnableMyBackupCodesV4 | [AdminEnableMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//AdminEnableMyBackupCodesV4.cs) |
| /iam/v4/admin/users/me/mfa/factor | GET | AdminGetMyEnabledFactorsV4 | [AdminGetMyEnabledFactorsV4](../AccelByte.Sdk/Api/Iam/Operation//AdminGetMyEnabledFactorsV4.cs) |
| /iam/v4/admin/users/me/mfa/factor | POST | AdminMakeFactorMyDefaultV4 | [AdminMakeFactorMyDefaultV4](../AccelByte.Sdk/Api/Iam/Operation//AdminMakeFactorMyDefaultV4.cs) |
| /iam/v4/admin/users/users/invite | POST | AdminInviteUserV4 | [AdminInviteUserV4](../AccelByte.Sdk/Api/Iam/Operation//AdminInviteUserV4.cs) |
| /iam/v4/public/namespaces/{namespace}/test_users | POST | PublicCreateTestUserV4 | [PublicCreateTestUserV4](../AccelByte.Sdk/Api/Iam/Operation//PublicCreateTestUserV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users | POST | PublicCreateUserV4 | [PublicCreateUserV4](../AccelByte.Sdk/Api/Iam/Operation//PublicCreateUserV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/invite/{invitationId} | POST | CreateUserFromInvitationV4 | [CreateUserFromInvitationV4](../AccelByte.Sdk/Api/Iam/Operation//CreateUserFromInvitationV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me | PATCH | PublicUpdateUserV4 | [PublicUpdateUserV4](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdateUserV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/email | PUT | PublicUpdateUserEmailAddressV4 | [PublicUpdateUserEmailAddressV4](../AccelByte.Sdk/Api/Iam/Operation//PublicUpdateUserEmailAddressV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/headless/code/verify | POST | PublicUpgradeHeadlessAccountWithVerificationCodeV4 | [PublicUpgradeHeadlessAccountWithVerificationCodeV4](../AccelByte.Sdk/Api/Iam/Operation//PublicUpgradeHeadlessAccountWithVerificationCodeV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/headless/verify | POST | PublicUpgradeHeadlessAccountV4 | [PublicUpgradeHeadlessAccountV4](../AccelByte.Sdk/Api/Iam/Operation//PublicUpgradeHeadlessAccountV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/disable | DELETE | PublicDisableMyAuthenticatorV4 | [PublicDisableMyAuthenticatorV4](../AccelByte.Sdk/Api/Iam/Operation//PublicDisableMyAuthenticatorV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/enable | POST | PublicEnableMyAuthenticatorV4 | [PublicEnableMyAuthenticatorV4](../AccelByte.Sdk/Api/Iam/Operation//PublicEnableMyAuthenticatorV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/key | POST | PublicGenerateMyAuthenticatorKeyV4 | [PublicGenerateMyAuthenticatorKeyV4](../AccelByte.Sdk/Api/Iam/Operation//PublicGenerateMyAuthenticatorKeyV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode | GET | PublicGetMyBackupCodesV4 | [PublicGetMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//PublicGetMyBackupCodesV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode | POST | PublicGenerateMyBackupCodesV4 | [PublicGenerateMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//PublicGenerateMyBackupCodesV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/disable | DELETE | PublicDisableMyBackupCodesV4 | [PublicDisableMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//PublicDisableMyBackupCodesV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/download | GET | PublicDownloadMyBackupCodesV4 | [PublicDownloadMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//PublicDownloadMyBackupCodesV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/enable | POST | PublicEnableMyBackupCodesV4 | [PublicEnableMyBackupCodesV4](../AccelByte.Sdk/Api/Iam/Operation//PublicEnableMyBackupCodesV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/factor | GET | PublicGetMyEnabledFactorsV4 | [PublicGetMyEnabledFactorsV4](../AccelByte.Sdk/Api/Iam/Operation//PublicGetMyEnabledFactorsV4.cs) |
| /iam/v4/public/namespaces/{namespace}/users/me/mfa/factor | POST | PublicMakeFactorMyDefaultV4 | [PublicMakeFactorMyDefaultV4](../AccelByte.Sdk/Api/Iam/Operation//PublicMakeFactorMyDefaultV4.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| .BannedBy | [BannedBy](../AccelByte.Sdk/Api/Iam/Model/BannedBy.cs) |
| .validation | [Validation](../AccelByte.Sdk/Api/Iam/Model/Validation.cs) |
| .validation.description | [ValidationDescription](../AccelByte.Sdk/Api/Iam/Model/ValidationDescription.cs) |
| account.UserActiveBanResponseV4 | [AccountUserActiveBanResponseV4](../AccelByte.Sdk/Api/Iam/Model/AccountUserActiveBanResponseV4.cs) |
| account.UserPermissionsResponseV4 | [AccountUserPermissionsResponseV4](../AccelByte.Sdk/Api/Iam/Model/AccountUserPermissionsResponseV4.cs) |
| account.UserResponseV4 | [AccountUserResponseV4](../AccelByte.Sdk/Api/Iam/Model/AccountUserResponseV4.cs) |
| account.createTestUserRequestV4 | [AccountCreateTestUserRequestV4](../AccelByte.Sdk/Api/Iam/Model/AccountCreateTestUserRequestV4.cs) |
| account.createUserRequestV4 | [AccountCreateUserRequestV4](../AccelByte.Sdk/Api/Iam/Model/AccountCreateUserRequestV4.cs) |
| account.createUserResponseV4 | [AccountCreateUserResponseV4](../AccelByte.Sdk/Api/Iam/Model/AccountCreateUserResponseV4.cs) |
| account.upgradeHeadlessAccountRequestV4 | [AccountUpgradeHeadlessAccountRequestV4](../AccelByte.Sdk/Api/Iam/Model/AccountUpgradeHeadlessAccountRequestV4.cs) |
| account.upgradeHeadlessAccountWithVerificationCodeRequestV4 | [AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4](../AccelByte.Sdk/Api/Iam/Model/AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4.cs) |
| accountcommon.Ban | [AccountcommonBan](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBan.cs) |
| accountcommon.BanReason | [AccountcommonBanReason](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBanReason.cs) |
| accountcommon.BanReasonV3 | [AccountcommonBanReasonV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBanReasonV3.cs) |
| accountcommon.BanReasons | [AccountcommonBanReasons](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBanReasons.cs) |
| accountcommon.BanReasonsV3 | [AccountcommonBanReasonsV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBanReasonsV3.cs) |
| accountcommon.BanV3 | [AccountcommonBanV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBanV3.cs) |
| accountcommon.BannedByV3 | [AccountcommonBannedByV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBannedByV3.cs) |
| accountcommon.Bans | [AccountcommonBans](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBans.cs) |
| accountcommon.BansV3 | [AccountcommonBansV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonBansV3.cs) |
| accountcommon.ClientPermission | [AccountcommonClientPermission](../AccelByte.Sdk/Api/Iam/Model/AccountcommonClientPermission.cs) |
| accountcommon.ClientPermissionV3 | [AccountcommonClientPermissionV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonClientPermissionV3.cs) |
| accountcommon.ClientPermissions | [AccountcommonClientPermissions](../AccelByte.Sdk/Api/Iam/Model/AccountcommonClientPermissions.cs) |
| accountcommon.ClientPermissionsV3 | [AccountcommonClientPermissionsV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonClientPermissionsV3.cs) |
| accountcommon.ConflictedUserPlatformAccounts | [AccountcommonConflictedUserPlatformAccounts](../AccelByte.Sdk/Api/Iam/Model/AccountcommonConflictedUserPlatformAccounts.cs) |
| accountcommon.CountryAgeRestriction | [AccountcommonCountryAgeRestriction](../AccelByte.Sdk/Api/Iam/Model/AccountcommonCountryAgeRestriction.cs) |
| accountcommon.Description | [AccountcommonDescription](../AccelByte.Sdk/Api/Iam/Model/AccountcommonDescription.cs) |
| accountcommon.InputValidationDescription | [AccountcommonInputValidationDescription](../AccelByte.Sdk/Api/Iam/Model/AccountcommonInputValidationDescription.cs) |
| accountcommon.JWTBanV3 | [AccountcommonJWTBanV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonJWTBanV3.cs) |
| accountcommon.ListUsersWithPlatformAccountsResponse | [AccountcommonListUsersWithPlatformAccountsResponse](../AccelByte.Sdk/Api/Iam/Model/AccountcommonListUsersWithPlatformAccountsResponse.cs) |
| accountcommon.NamespaceRole | [AccountcommonNamespaceRole](../AccelByte.Sdk/Api/Iam/Model/AccountcommonNamespaceRole.cs) |
| accountcommon.Pagination | [AccountcommonPagination](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPagination.cs) |
| accountcommon.PaginationV3 | [AccountcommonPaginationV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPaginationV3.cs) |
| accountcommon.Permission | [AccountcommonPermission](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPermission.cs) |
| accountcommon.PermissionV3 | [AccountcommonPermissionV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPermissionV3.cs) |
| accountcommon.Permissions | [AccountcommonPermissions](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPermissions.cs) |
| accountcommon.PermissionsV3 | [AccountcommonPermissionsV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPermissionsV3.cs) |
| accountcommon.PlatformAccount | [AccountcommonPlatformAccount](../AccelByte.Sdk/Api/Iam/Model/AccountcommonPlatformAccount.cs) |
| accountcommon.RegisteredDomain | [AccountcommonRegisteredDomain](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRegisteredDomain.cs) |
| accountcommon.Role | [AccountcommonRole](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRole.cs) |
| accountcommon.RoleManager | [AccountcommonRoleManager](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRoleManager.cs) |
| accountcommon.RoleManagerV3 | [AccountcommonRoleManagerV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRoleManagerV3.cs) |
| accountcommon.RoleMember | [AccountcommonRoleMember](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRoleMember.cs) |
| accountcommon.RoleMemberV3 | [AccountcommonRoleMemberV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRoleMemberV3.cs) |
| accountcommon.RoleV3 | [AccountcommonRoleV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonRoleV3.cs) |
| accountcommon.UserLinkedPlatform | [AccountcommonUserLinkedPlatform](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserLinkedPlatform.cs) |
| accountcommon.UserLinkedPlatformV3 | [AccountcommonUserLinkedPlatformV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserLinkedPlatformV3.cs) |
| accountcommon.UserLinkedPlatformsResponseV3 | [AccountcommonUserLinkedPlatformsResponseV3](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserLinkedPlatformsResponseV3.cs) |
| accountcommon.UserPlatformInfo | [AccountcommonUserPlatformInfo](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserPlatformInfo.cs) |
| accountcommon.UserPlatforms | [AccountcommonUserPlatforms](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserPlatforms.cs) |
| accountcommon.UserSearchByPlatformIDResult | [AccountcommonUserSearchByPlatformIDResult](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserSearchByPlatformIDResult.cs) |
| accountcommon.UserSearchResult | [AccountcommonUserSearchResult](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserSearchResult.cs) |
| accountcommon.UserWithLinkedPlatformAccounts | [AccountcommonUserWithLinkedPlatformAccounts](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserWithLinkedPlatformAccounts.cs) |
| accountcommon.UserWithPlatformAccounts | [AccountcommonUserWithPlatformAccounts](../AccelByte.Sdk/Api/Iam/Model/AccountcommonUserWithPlatformAccounts.cs) |
| bloom.FilterJSON | [BloomFilterJSON](../AccelByte.Sdk/Api/Iam/Model/BloomFilterJSON.cs) |
| clientmodel.ClientCreateRequest | [ClientmodelClientCreateRequest](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientCreateRequest.cs) |
| clientmodel.ClientCreationResponse | [ClientmodelClientCreationResponse](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientCreationResponse.cs) |
| clientmodel.ClientCreationV3Request | [ClientmodelClientCreationV3Request](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientCreationV3Request.cs) |
| clientmodel.ClientResponse | [ClientmodelClientResponse](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientResponse.cs) |
| clientmodel.ClientUpdateRequest | [ClientmodelClientUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientUpdateRequest.cs) |
| clientmodel.ClientUpdateSecretRequest | [ClientmodelClientUpdateSecretRequest](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientUpdateSecretRequest.cs) |
| clientmodel.ClientUpdateV3Request | [ClientmodelClientUpdateV3Request](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientUpdateV3Request.cs) |
| clientmodel.ClientV3Response | [ClientmodelClientV3Response](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientV3Response.cs) |
| clientmodel.ClientsV3Response | [ClientmodelClientsV3Response](../AccelByte.Sdk/Api/Iam/Model/ClientmodelClientsV3Response.cs) |
| legal.AcceptedPoliciesRequest | [LegalAcceptedPoliciesRequest](../AccelByte.Sdk/Api/Iam/Model/LegalAcceptedPoliciesRequest.cs) |
| model.AddUserRoleV4Request | [ModelAddUserRoleV4Request](../AccelByte.Sdk/Api/Iam/Model/ModelAddUserRoleV4Request.cs) |
| model.AgeRestrictionRequest | [ModelAgeRestrictionRequest](../AccelByte.Sdk/Api/Iam/Model/ModelAgeRestrictionRequest.cs) |
| model.AgeRestrictionRequestV3 | [ModelAgeRestrictionRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelAgeRestrictionRequestV3.cs) |
| model.AgeRestrictionResponse | [ModelAgeRestrictionResponse](../AccelByte.Sdk/Api/Iam/Model/ModelAgeRestrictionResponse.cs) |
| model.AgeRestrictionResponseV3 | [ModelAgeRestrictionResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelAgeRestrictionResponseV3.cs) |
| model.AssignUserV4Request | [ModelAssignUserV4Request](../AccelByte.Sdk/Api/Iam/Model/ModelAssignUserV4Request.cs) |
| model.AssignedUserV4Response | [ModelAssignedUserV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelAssignedUserV4Response.cs) |
| model.AuthenticatorKeyResponseV4 | [ModelAuthenticatorKeyResponseV4](../AccelByte.Sdk/Api/Iam/Model/ModelAuthenticatorKeyResponseV4.cs) |
| model.BackupCodesResponseV4 | [ModelBackupCodesResponseV4](../AccelByte.Sdk/Api/Iam/Model/ModelBackupCodesResponseV4.cs) |
| model.BanCreateRequest | [ModelBanCreateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelBanCreateRequest.cs) |
| model.BanUpdateRequest | [ModelBanUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelBanUpdateRequest.cs) |
| model.CheckValidUserIDRequestV4 | [ModelCheckValidUserIDRequestV4](../AccelByte.Sdk/Api/Iam/Model/ModelCheckValidUserIDRequestV4.cs) |
| model.Country | [ModelCountry](../AccelByte.Sdk/Api/Iam/Model/ModelCountry.cs) |
| model.CountryAgeRestrictionRequest | [ModelCountryAgeRestrictionRequest](../AccelByte.Sdk/Api/Iam/Model/ModelCountryAgeRestrictionRequest.cs) |
| model.CountryAgeRestrictionV3Request | [ModelCountryAgeRestrictionV3Request](../AccelByte.Sdk/Api/Iam/Model/ModelCountryAgeRestrictionV3Request.cs) |
| model.CountryV3Response | [ModelCountryV3Response](../AccelByte.Sdk/Api/Iam/Model/ModelCountryV3Response.cs) |
| model.CreateJusticeUserResponse | [ModelCreateJusticeUserResponse](../AccelByte.Sdk/Api/Iam/Model/ModelCreateJusticeUserResponse.cs) |
| model.DisableUserRequest | [ModelDisableUserRequest](../AccelByte.Sdk/Api/Iam/Model/ModelDisableUserRequest.cs) |
| model.EmailUpdateRequestV4 | [ModelEmailUpdateRequestV4](../AccelByte.Sdk/Api/Iam/Model/ModelEmailUpdateRequestV4.cs) |
| model.EnabledFactorsResponseV4 | [ModelEnabledFactorsResponseV4](../AccelByte.Sdk/Api/Iam/Model/ModelEnabledFactorsResponseV4.cs) |
| model.ForgotPasswordRequestV3 | [ModelForgotPasswordRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelForgotPasswordRequestV3.cs) |
| model.GetAdminUsersResponse | [ModelGetAdminUsersResponse](../AccelByte.Sdk/Api/Iam/Model/ModelGetAdminUsersResponse.cs) |
| model.GetPublisherUserResponse | [ModelGetPublisherUserResponse](../AccelByte.Sdk/Api/Iam/Model/ModelGetPublisherUserResponse.cs) |
| model.GetUserBanV3Response | [ModelGetUserBanV3Response](../AccelByte.Sdk/Api/Iam/Model/ModelGetUserBanV3Response.cs) |
| model.GetUserJusticePlatformAccountResponse | [ModelGetUserJusticePlatformAccountResponse](../AccelByte.Sdk/Api/Iam/Model/ModelGetUserJusticePlatformAccountResponse.cs) |
| model.GetUserMapping | [ModelGetUserMapping](../AccelByte.Sdk/Api/Iam/Model/ModelGetUserMapping.cs) |
| model.GetUsersResponseWithPaginationV3 | [ModelGetUsersResponseWithPaginationV3](../AccelByte.Sdk/Api/Iam/Model/ModelGetUsersResponseWithPaginationV3.cs) |
| model.InputValidationData | [ModelInputValidationData](../AccelByte.Sdk/Api/Iam/Model/ModelInputValidationData.cs) |
| model.InputValidationDataPublic | [ModelInputValidationDataPublic](../AccelByte.Sdk/Api/Iam/Model/ModelInputValidationDataPublic.cs) |
| model.InputValidationUpdatePayload | [ModelInputValidationUpdatePayload](../AccelByte.Sdk/Api/Iam/Model/ModelInputValidationUpdatePayload.cs) |
| model.InputValidationsPublicResponse | [ModelInputValidationsPublicResponse](../AccelByte.Sdk/Api/Iam/Model/ModelInputValidationsPublicResponse.cs) |
| model.InputValidationsResponse | [ModelInputValidationsResponse](../AccelByte.Sdk/Api/Iam/Model/ModelInputValidationsResponse.cs) |
| model.InviteUserRequestV3 | [ModelInviteUserRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelInviteUserRequestV3.cs) |
| model.InviteUserRequestV4 | [ModelInviteUserRequestV4](../AccelByte.Sdk/Api/Iam/Model/ModelInviteUserRequestV4.cs) |
| model.InviteUserResponseV3 | [ModelInviteUserResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelInviteUserResponseV3.cs) |
| model.LinkPlatformAccountRequest | [ModelLinkPlatformAccountRequest](../AccelByte.Sdk/Api/Iam/Model/ModelLinkPlatformAccountRequest.cs) |
| model.LinkRequest | [ModelLinkRequest](../AccelByte.Sdk/Api/Iam/Model/ModelLinkRequest.cs) |
| model.ListAssignedUsersV4Response | [ModelListAssignedUsersV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelListAssignedUsersV4Response.cs) |
| model.ListBulkUserResponse | [ModelListBulkUserResponse](../AccelByte.Sdk/Api/Iam/Model/ModelListBulkUserResponse.cs) |
| model.ListEmailAddressRequest | [ModelListEmailAddressRequest](../AccelByte.Sdk/Api/Iam/Model/ModelListEmailAddressRequest.cs) |
| model.ListRoleV4Response | [ModelListRoleV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelListRoleV4Response.cs) |
| model.ListUserInformationResult | [ModelListUserInformationResult](../AccelByte.Sdk/Api/Iam/Model/ModelListUserInformationResult.cs) |
| model.ListUserResponseV3 | [ModelListUserResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelListUserResponseV3.cs) |
| model.ListUserRolesV4Response | [ModelListUserRolesV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelListUserRolesV4Response.cs) |
| model.ListValidUserIDResponseV4 | [ModelListValidUserIDResponseV4](../AccelByte.Sdk/Api/Iam/Model/ModelListValidUserIDResponseV4.cs) |
| model.LoginHistoriesResponse | [ModelLoginHistoriesResponse](../AccelByte.Sdk/Api/Iam/Model/ModelLoginHistoriesResponse.cs) |
| model.NamespaceRoleRequest | [ModelNamespaceRoleRequest](../AccelByte.Sdk/Api/Iam/Model/ModelNamespaceRoleRequest.cs) |
| model.PermissionDeleteRequest | [ModelPermissionDeleteRequest](../AccelByte.Sdk/Api/Iam/Model/ModelPermissionDeleteRequest.cs) |
| model.PlatformDomainDeleteRequest | [ModelPlatformDomainDeleteRequest](../AccelByte.Sdk/Api/Iam/Model/ModelPlatformDomainDeleteRequest.cs) |
| model.PlatformDomainResponse | [ModelPlatformDomainResponse](../AccelByte.Sdk/Api/Iam/Model/ModelPlatformDomainResponse.cs) |
| model.PlatformDomainUpdateRequest | [ModelPlatformDomainUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelPlatformDomainUpdateRequest.cs) |
| model.PlatformUserIDRequest | [ModelPlatformUserIDRequest](../AccelByte.Sdk/Api/Iam/Model/ModelPlatformUserIDRequest.cs) |
| model.PlatformUserInformation | [ModelPlatformUserInformation](../AccelByte.Sdk/Api/Iam/Model/ModelPlatformUserInformation.cs) |
| model.PublicThirdPartyPlatformInfo | [ModelPublicThirdPartyPlatformInfo](../AccelByte.Sdk/Api/Iam/Model/ModelPublicThirdPartyPlatformInfo.cs) |
| model.PublicUserInformationResponseV3 | [ModelPublicUserInformationResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelPublicUserInformationResponseV3.cs) |
| model.PublicUserInformationV3 | [ModelPublicUserInformationV3](../AccelByte.Sdk/Api/Iam/Model/ModelPublicUserInformationV3.cs) |
| model.PublicUserResponse | [ModelPublicUserResponse](../AccelByte.Sdk/Api/Iam/Model/ModelPublicUserResponse.cs) |
| model.PublicUserResponseV3 | [ModelPublicUserResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelPublicUserResponseV3.cs) |
| model.PublicUsersResponse | [ModelPublicUsersResponse](../AccelByte.Sdk/Api/Iam/Model/ModelPublicUsersResponse.cs) |
| model.RemoveUserRoleV4Request | [ModelRemoveUserRoleV4Request](../AccelByte.Sdk/Api/Iam/Model/ModelRemoveUserRoleV4Request.cs) |
| model.ResetPasswordRequest | [ModelResetPasswordRequest](../AccelByte.Sdk/Api/Iam/Model/ModelResetPasswordRequest.cs) |
| model.ResetPasswordRequestV3 | [ModelResetPasswordRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelResetPasswordRequestV3.cs) |
| model.RevokeUserV4Request | [ModelRevokeUserV4Request](../AccelByte.Sdk/Api/Iam/Model/ModelRevokeUserV4Request.cs) |
| model.RoleAdminStatusResponse | [ModelRoleAdminStatusResponse](../AccelByte.Sdk/Api/Iam/Model/ModelRoleAdminStatusResponse.cs) |
| model.RoleAdminStatusResponseV3 | [ModelRoleAdminStatusResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleAdminStatusResponseV3.cs) |
| model.RoleCreateRequest | [ModelRoleCreateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelRoleCreateRequest.cs) |
| model.RoleCreateV3Request | [ModelRoleCreateV3Request](../AccelByte.Sdk/Api/Iam/Model/ModelRoleCreateV3Request.cs) |
| model.RoleManagersRequest | [ModelRoleManagersRequest](../AccelByte.Sdk/Api/Iam/Model/ModelRoleManagersRequest.cs) |
| model.RoleManagersRequestV3 | [ModelRoleManagersRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleManagersRequestV3.cs) |
| model.RoleManagersResponse | [ModelRoleManagersResponse](../AccelByte.Sdk/Api/Iam/Model/ModelRoleManagersResponse.cs) |
| model.RoleManagersResponsesV3 | [ModelRoleManagersResponsesV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleManagersResponsesV3.cs) |
| model.RoleMembersRequest | [ModelRoleMembersRequest](../AccelByte.Sdk/Api/Iam/Model/ModelRoleMembersRequest.cs) |
| model.RoleMembersRequestV3 | [ModelRoleMembersRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleMembersRequestV3.cs) |
| model.RoleMembersResponse | [ModelRoleMembersResponse](../AccelByte.Sdk/Api/Iam/Model/ModelRoleMembersResponse.cs) |
| model.RoleMembersResponseV3 | [ModelRoleMembersResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleMembersResponseV3.cs) |
| model.RoleNamesResponseV3 | [ModelRoleNamesResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleNamesResponseV3.cs) |
| model.RoleResponse | [ModelRoleResponse](../AccelByte.Sdk/Api/Iam/Model/ModelRoleResponse.cs) |
| model.RoleResponseV3 | [ModelRoleResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleResponseV3.cs) |
| model.RoleResponseWithManagers | [ModelRoleResponseWithManagers](../AccelByte.Sdk/Api/Iam/Model/ModelRoleResponseWithManagers.cs) |
| model.RoleResponseWithManagersAndPaginationV3 | [ModelRoleResponseWithManagersAndPaginationV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleResponseWithManagersAndPaginationV3.cs) |
| model.RoleResponseWithManagersV3 | [ModelRoleResponseWithManagersV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleResponseWithManagersV3.cs) |
| model.RoleUpdateRequest | [ModelRoleUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelRoleUpdateRequest.cs) |
| model.RoleUpdateRequestV3 | [ModelRoleUpdateRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelRoleUpdateRequestV3.cs) |
| model.RoleV4Request | [ModelRoleV4Request](../AccelByte.Sdk/Api/Iam/Model/ModelRoleV4Request.cs) |
| model.RoleV4Response | [ModelRoleV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelRoleV4Response.cs) |
| model.SSOPlatformCredentialRequest | [ModelSSOPlatformCredentialRequest](../AccelByte.Sdk/Api/Iam/Model/ModelSSOPlatformCredentialRequest.cs) |
| model.SSOPlatformCredentialResponse | [ModelSSOPlatformCredentialResponse](../AccelByte.Sdk/Api/Iam/Model/ModelSSOPlatformCredentialResponse.cs) |
| model.SearchUsersByPlatformIDResponse | [ModelSearchUsersByPlatformIDResponse](../AccelByte.Sdk/Api/Iam/Model/ModelSearchUsersByPlatformIDResponse.cs) |
| model.SearchUsersResponse | [ModelSearchUsersResponse](../AccelByte.Sdk/Api/Iam/Model/ModelSearchUsersResponse.cs) |
| model.SearchUsersResponseWithPaginationV3 | [ModelSearchUsersResponseWithPaginationV3](../AccelByte.Sdk/Api/Iam/Model/ModelSearchUsersResponseWithPaginationV3.cs) |
| model.SendRegisterVerificationCodeRequest | [ModelSendRegisterVerificationCodeRequest](../AccelByte.Sdk/Api/Iam/Model/ModelSendRegisterVerificationCodeRequest.cs) |
| model.SendVerificationCodeRequest | [ModelSendVerificationCodeRequest](../AccelByte.Sdk/Api/Iam/Model/ModelSendVerificationCodeRequest.cs) |
| model.SendVerificationCodeRequestV3 | [ModelSendVerificationCodeRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelSendVerificationCodeRequestV3.cs) |
| model.ThirdPartyLoginPlatformCredentialRequest | [ModelThirdPartyLoginPlatformCredentialRequest](../AccelByte.Sdk/Api/Iam/Model/ModelThirdPartyLoginPlatformCredentialRequest.cs) |
| model.ThirdPartyLoginPlatformCredentialResponse | [ModelThirdPartyLoginPlatformCredentialResponse](../AccelByte.Sdk/Api/Iam/Model/ModelThirdPartyLoginPlatformCredentialResponse.cs) |
| model.UnlinkUserPlatformRequest | [ModelUnlinkUserPlatformRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUnlinkUserPlatformRequest.cs) |
| model.UpdatePermissionScheduleRequest | [ModelUpdatePermissionScheduleRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUpdatePermissionScheduleRequest.cs) |
| model.UpdateUserDeletionStatusRequest | [ModelUpdateUserDeletionStatusRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUpdateUserDeletionStatusRequest.cs) |
| model.UpdateUserStatusRequest | [ModelUpdateUserStatusRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUpdateUserStatusRequest.cs) |
| model.UpgradeHeadlessAccountRequest | [ModelUpgradeHeadlessAccountRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUpgradeHeadlessAccountRequest.cs) |
| model.UpgradeHeadlessAccountV3Request | [ModelUpgradeHeadlessAccountV3Request](../AccelByte.Sdk/Api/Iam/Model/ModelUpgradeHeadlessAccountV3Request.cs) |
| model.UpgradeHeadlessAccountWithVerificationCodeRequest | [ModelUpgradeHeadlessAccountWithVerificationCodeRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUpgradeHeadlessAccountWithVerificationCodeRequest.cs) |
| model.UpgradeHeadlessAccountWithVerificationCodeRequestV3 | [ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelUpgradeHeadlessAccountWithVerificationCodeRequestV3.cs) |
| model.UserActiveBanResponse | [ModelUserActiveBanResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserActiveBanResponse.cs) |
| model.UserActiveBanResponseV3 | [ModelUserActiveBanResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserActiveBanResponseV3.cs) |
| model.UserBanResponse | [ModelUserBanResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserBanResponse.cs) |
| model.UserBanResponseV3 | [ModelUserBanResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserBanResponseV3.cs) |
| model.UserBaseInfo | [ModelUserBaseInfo](../AccelByte.Sdk/Api/Iam/Model/ModelUserBaseInfo.cs) |
| model.UserCreateFromInvitationRequestV3 | [ModelUserCreateFromInvitationRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateFromInvitationRequestV3.cs) |
| model.UserCreateFromInvitationRequestV4 | [ModelUserCreateFromInvitationRequestV4](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateFromInvitationRequestV4.cs) |
| model.UserCreateRequest | [ModelUserCreateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateRequest.cs) |
| model.UserCreateRequestV3 | [ModelUserCreateRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateRequestV3.cs) |
| model.UserCreateResponse | [ModelUserCreateResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateResponse.cs) |
| model.UserCreateResponseV3 | [ModelUserCreateResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserCreateResponseV3.cs) |
| model.UserDeletionStatusResponse | [ModelUserDeletionStatusResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserDeletionStatusResponse.cs) |
| model.UserIDsRequest | [ModelUserIDsRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUserIDsRequest.cs) |
| model.UserInfoResponse | [ModelUserInfoResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserInfoResponse.cs) |
| model.UserInformation | [ModelUserInformation](../AccelByte.Sdk/Api/Iam/Model/ModelUserInformation.cs) |
| model.UserInvitationV3 | [ModelUserInvitationV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserInvitationV3.cs) |
| model.UserLoginHistoryResponse | [ModelUserLoginHistoryResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserLoginHistoryResponse.cs) |
| model.UserPasswordUpdateRequest | [ModelUserPasswordUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUserPasswordUpdateRequest.cs) |
| model.UserPasswordUpdateV3Request | [ModelUserPasswordUpdateV3Request](../AccelByte.Sdk/Api/Iam/Model/ModelUserPasswordUpdateV3Request.cs) |
| model.UserPermissionsResponseV3 | [ModelUserPermissionsResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserPermissionsResponseV3.cs) |
| model.UserResponse | [ModelUserResponse](../AccelByte.Sdk/Api/Iam/Model/ModelUserResponse.cs) |
| model.UserResponseV3 | [ModelUserResponseV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserResponseV3.cs) |
| model.UserRolesV4Response | [ModelUserRolesV4Response](../AccelByte.Sdk/Api/Iam/Model/ModelUserRolesV4Response.cs) |
| model.UserUpdateRequest | [ModelUserUpdateRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUserUpdateRequest.cs) |
| model.UserUpdateRequestV3 | [ModelUserUpdateRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserUpdateRequestV3.cs) |
| model.UserVerificationRequest | [ModelUserVerificationRequest](../AccelByte.Sdk/Api/Iam/Model/ModelUserVerificationRequest.cs) |
| model.UserVerificationRequestV3 | [ModelUserVerificationRequestV3](../AccelByte.Sdk/Api/Iam/Model/ModelUserVerificationRequestV3.cs) |
| model.ValidUserIDResponseV4 | [ModelValidUserIDResponseV4](../AccelByte.Sdk/Api/Iam/Model/ModelValidUserIDResponseV4.cs) |
| model.ValidationDetail | [ModelValidationDetail](../AccelByte.Sdk/Api/Iam/Model/ModelValidationDetail.cs) |
| model.ValidationDetailPublic | [ModelValidationDetailPublic](../AccelByte.Sdk/Api/Iam/Model/ModelValidationDetailPublic.cs) |
| model.VerificationCodeResponse | [ModelVerificationCodeResponse](../AccelByte.Sdk/Api/Iam/Model/ModelVerificationCodeResponse.cs) |
| model.VerifyRegistrationCode | [ModelVerifyRegistrationCode](../AccelByte.Sdk/Api/Iam/Model/ModelVerifyRegistrationCode.cs) |
| model.WebLinkingResponse | [ModelWebLinkingResponse](../AccelByte.Sdk/Api/Iam/Model/ModelWebLinkingResponse.cs) |
| oauthapi.RevocationList | [OauthapiRevocationList](../AccelByte.Sdk/Api/Iam/Model/OauthapiRevocationList.cs) |
| oauthcommon.JWKKey | [OauthcommonJWKKey](../AccelByte.Sdk/Api/Iam/Model/OauthcommonJWKKey.cs) |
| oauthcommon.JWKSet | [OauthcommonJWKSet](../AccelByte.Sdk/Api/Iam/Model/OauthcommonJWKSet.cs) |
| oauthcommon.UserRevocationListRecord | [OauthcommonUserRevocationListRecord](../AccelByte.Sdk/Api/Iam/Model/OauthcommonUserRevocationListRecord.cs) |
| oauthmodel.CountryLocationResponse | [OauthmodelCountryLocationResponse](../AccelByte.Sdk/Api/Iam/Model/OauthmodelCountryLocationResponse.cs) |
| oauthmodel.ErrorResponse | [OauthmodelErrorResponse](../AccelByte.Sdk/Api/Iam/Model/OauthmodelErrorResponse.cs) |
| oauthmodel.TokenIntrospectResponse | [OauthmodelTokenIntrospectResponse](../AccelByte.Sdk/Api/Iam/Model/OauthmodelTokenIntrospectResponse.cs) |
| oauthmodel.TokenResponse | [OauthmodelTokenResponse](../AccelByte.Sdk/Api/Iam/Model/OauthmodelTokenResponse.cs) |
| oauthmodel.TokenResponseV3 | [OauthmodelTokenResponseV3](../AccelByte.Sdk/Api/Iam/Model/OauthmodelTokenResponseV3.cs) |
| oauthmodel.TokenThirdPartyResponse | [OauthmodelTokenThirdPartyResponse](../AccelByte.Sdk/Api/Iam/Model/OauthmodelTokenThirdPartyResponse.cs) |
| rest.ErrorResponse | [RestErrorResponse](../AccelByte.Sdk/Api/Iam/Model/RestErrorResponse.cs) |
| restapi.ErrorResponse | [RestapiErrorResponse](../AccelByte.Sdk/Api/Iam/Model/RestapiErrorResponse.cs) |
