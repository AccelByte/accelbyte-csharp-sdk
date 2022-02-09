# Test Results

```tap
run-cli-sessionbrowser-unit-test.sh

TAP version 13
1..15
ok 1 GetTotalActiveSession
ok 2 GetActiveCustomGameSessions
ok 3 GetActiveMatchmakingGameSessions
ok 4 AdminGetSession
ok 5 QuerySession
ok 6 CreateSession
ok 7 GetSessionByUserIDs
ok 8 GetSession
ok 9 UpdateSession
ok 10 DeleteSession
ok 11 JoinSession
ok 12 DeleteSessionLocalDS
ok 13 AddPlayerToSession
ok 14 RemovePlayerFromSession
ok 15 GetRecentPlayer
```

```tap
run-cli-gametelemetry-unit-test.sh

TAP version 13
1..3
ok 1 ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost
ok 2 ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet
ok 3 ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut
```

```tap
run-cli-seasonpass-unit-test.sh

TAP version 13
1..38
ok 1 GetPass
ok 2 DeletePass
ok 3 UpdatePass
ok 4 QueryPasses
ok 5 CreatePass
ok 6 GetReward
ok 7 DeleteReward
ok 8 UpdateReward
ok 9 QueryRewards
ok 10 CreateReward
ok 11 UnpublishSeason
ok 12 GetSeason
ok 13 DeleteSeason
ok 14 UpdateSeason
ok 15 CloneSeason
ok 16 QuerySeasons
ok 17 CreateSeason
ok 18 RetireSeason
ok 19 PublishSeason
ok 20 GetCurrentSeason
ok 21 UpdateTier
ok 22 DeleteTier
ok 23 QueryTiers
ok 24 CreateTier
ok 25 ExistsAnyPassByPassCodes
ok 26 GrantUserTier
ok 27 GetUserSeason
ok 28 CheckSeasonPurchasable
ok 29 GetCurrentUserSeasonProgression
ok 30 ResetUserSeason
ok 31 GrantUserPass
ok 32 GetUserParticipatedSeasons
ok 33 GrantUserExp
ok 34 PublicGetCurrentSeason
ok 35 PublicClaimUserReward
ok 36 PublicGetCurrentUserSeason
ok 37 PublicBulkClaimUserRewards
ok 38 PublicGetUserSeason
```

```tap
run-cli-basic-unit-test.sh

TAP version 13
1..57
ok 1 GetNamespaces
ok 2 CreateNamespace
ok 3 GetNamespace
ok 4 DeleteNamespace
ok 5 GetActions
ok 6 BanUsers
ok 7 GetBannedUsers
ok 8 ReportUser
ok 9 GetUserStatus
ok 10 UnBanUsers
ok 11 UpdateNamespace
ok 12 GetConfig
ok 13 DeleteConfig
ok 14 UpdateConfig
ok 15 GeneratedUploadUrl
ok 16 GetCountries
ok 17 GetCountryGroups
ok 18 AddCountryGroup
ok 19 UpdateCountryGroup
ok 20 DeleteCountryGroup
ok 21 GetLanguages
ok 22 GetTimeZones
ok 23 AdminGetUserProfilePublicInfoByIds
ok 24 GetNamespacePublisher
ok 25 ChangeNamespaceStatus
ok 26 AnonymizeUserProfile
ok 27 GeneratedUserUploadContentUrl
ok 28 GetUserProfileInfo
ok 29 UpdateUserProfile
ok 30 DeleteUserProfile
ok 31 GetCustomAttributesInfo
ok 32 UpdateCustomAttributesPartially
ok 33 GetPrivateCustomAttributesInfo
ok 34 UpdatePrivateCustomAttributesPartially
ok 35 UpdateUserProfileStatus
ok 36 PublicGetTime
ok 37 PublicGetNamespaces
ok 38 PublicGeneratedUploadUrl
ok 39 PublicGetCountries
ok 40 PublicGetLanguages
ok 41 PublicGetTimeZones
ok 42 PublicGetUserProfilePublicInfoByIds
ok 43 PublicGetNamespacePublisher
ok 44 GetMyProfileInfo
ok 45 UpdateMyProfile
ok 46 CreateMyProfile
ok 47 GetMyZipCode
ok 48 UpdateMyZipCode
ok 49 PublicReportUser
ok 50 PublicGeneratedUserUploadContentUrl
ok 51 PublicGetUserProfileInfo
ok 52 PublicUpdateUserProfile
ok 53 PublicCreateUserProfile
ok 54 PublicGetCustomAttributesInfo
ok 55 PublicUpdateCustomAttributesPartially
ok 56 PublicGetUserProfilePublicInfo
ok 57 PublicUpdateUserProfileStatus
```

```tap
run-cli-iam-unit-test.sh

TAP version 13
1..270
ok 1 GetBansType
ok 2 GetListBanReason
ok 3 GetClients (skipped deprecated)
ok 4 CreateClient (skipped deprecated)
ok 5 GetClient
ok 6 UpdateClient
ok 7 DeleteClient (skipped deprecated)
ok 8 UpdateClientPermission
ok 9 AddClientPermission
ok 10 DeleteClientPermission
ok 11 UpdateClientSecret
ok 12 GetClientsbyNamespace
ok 13 CreateClientByNamespace
ok 14 DeleteClientByNamespace
ok 15 CreateUser
ok 16 GetAdminUsersByRoleID
ok 17 GetUserByLoginID
ok 18 GetUserByPlatformUserID
ok 19 ForgotPassword
ok 20 GetUsersByLoginIds
ok 21 ResetPassword
ok 22 SearchUser (skipped deprecated)
ok 23 GetUserByUserID
ok 24 UpdateUser
ok 25 DeleteUser
ok 26 BanUser
ok 27 GetUserBanHistory
ok 28 DisableUserBan
ok 29 EnableUserBan
ok 30 ListCrossNamespaceAccountLink (skipped deprecated)
ok 31 DisableUser (skipped deprecated)
ok 32 EnableUser (skipped deprecated)
ok 33 GetUserInformation
ok 34 DeleteUserInformation
ok 35 GetUserLoginHistories
ok 36 UpdatePassword (skipped deprecated)
ok 37 SaveUserPermission
ok 38 AddUserPermission
ok 39 DeleteUserPermission
ok 40 GetUserPlatformAccounts
ok 41 GetUserMapping
ok 42 GetUserJusticePlatformAccount (skipped deprecated)
ok 43 PlatformLink
ok 44 PlatformUnlink
ok 45 GetPublisherUser
ok 46 SaveUserRoles
ok 47 AddUserRole
ok 48 DeleteUserRole
ok 49 UpgradeHeadlessAccount
ok 50 UpgradeHeadlessAccountWithVerificationCode
ok 51 UserVerification
ok 52 SendVerificationCode
ok 53 Authorization
ok 54 GetJWKS
ok 55 PlatformTokenRequestHandler (skipped deprecated)
ok 56 RevokeUser
ok 57 GetRevocationList
ok 58 RevokeToken (skipped deprecated)
ok 59 RevokeAUser (skipped deprecated)
ok 60 TokenGrant
ok 61 VerifyToken
ok 62 GetRoles
ok 63 CreateRole
ok 64 GetRole
ok 65 UpdateRole
ok 66 DeleteRole
ok 67 GetRoleAdminStatus
ok 68 SetRoleAsAdmin
ok 69 RemoveRoleAdmin
ok 70 GetRoleManagers
ok 71 AddRoleManagers
ok 72 RemoveRoleManagers
ok 73 GetRoleMembers
ok 74 AddRoleMembers
ok 75 RemoveRoleMembers
ok 76 UpdateRolePermissions
ok 77 AddRolePermission
ok 78 DeleteRolePermission
ok 79 AdminGetAgeRestrictionStatusV2
ok 80 AdminUpdateAgeRestrictionConfigV2
ok 81 GetListCountryAgeRestriction
ok 82 UpdateCountryAgeRestriction
ok 83 AdminSearchUsersV2
ok 84 AdminGetUserByUserIdV2
ok 85 AdminUpdateUserV2
ok 86 AdminBanUserV2
ok 87 AdminGetUserBanV2
ok 88 AdminDisableUserV2
ok 89 AdminEnableUserV2
ok 90 AdminResetPasswordV2
ok 91 AdminDeletePlatformLinkV2
ok 92 AdminPutUserRolesV2
ok 93 AdminCreateUserRolesV2
ok 94 PublicCreateUserV2
ok 95 PublicForgotPasswordV2
ok 96 PublicResetPasswordV2
ok 97 PublicGetUserByUserIDV2
ok 98 PublicUpdateUserV2
ok 99 PublicGetUserBan
ok 100 PublicUpdatePasswordV2
ok 101 GetListJusticePlatformAccounts
ok 102 PublicPlatformLinkV2
ok 103 PublicDeletePlatformLinkV2
ok 104 AdminGetBansTypeV3
ok 105 AdminGetListBanReasonV3
ok 106 AdminGetInputValidations
ok 107 AdminUpdateInputValidations
ok 108 AdminResetInputValidations
ok 109 ListAdminsV3
ok 110 AdminGetAgeRestrictionStatusV3
ok 111 AdminUpdateAgeRestrictionConfigV3
ok 112 AdminGetListCountryAgeRestrictionV3
ok 113 AdminUpdateCountryAgeRestrictionV3
ok 114 AdminGetBannedUsersV3
ok 115 AdminGetBansTypeWithNamespaceV3
ok 116 AdminGetClientsByNamespaceV3
ok 117 AdminCreateClientV3
ok 118 AdminGetClientsbyNamespacebyIDV3
ok 119 AdminDeleteClientV3
ok 120 AdminUpdateClientV3
ok 121 AdminUpdateClientPermissionV3
ok 122 AdminAddClientPermissionsV3
ok 123 AdminDeleteClientPermissionV3
ok 124 RetrieveAllThirdPartyLoginPlatformCredentialV3
ok 125 RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
ok 126 RetrieveAllSSOLoginPlatformCredentialV3
ok 127 RetrieveThirdPartyLoginPlatformCredentialV3
ok 128 AddThirdPartyLoginPlatformCredentialV3
ok 129 DeleteThirdPartyLoginPlatformCredentialV3
ok 130 UpdateThirdPartyLoginPlatformCredentialV3
ok 131 UpdateThirdPartyLoginPlatformDomainV3
ok 132 DeleteThirdPartyLoginPlatformDomainV3
ok 133 RetrieveSSOLoginPlatformCredential
ok 134 AddSSOLoginPlatformCredential
ok 135 DeleteSSOLoginPlatformCredentialV3
ok 136 UpdateSSOPlatformCredential
ok 137 AdminGetUserByPlatformUserIDV3
ok 138 GetAdminUsersByRoleIdV3
ok 139 AdminGetUserByEmailAddressV3
ok 140 AdminListUserIDByUserIDsV3
ok 141 AdminInviteUserV3
ok 142 AdminListUsersV3
ok 143 AdminSearchUserV3
ok 144 AdminGetBulkUserByEmailAddressV3
ok 145 AdminGetUserByUserIdV3
ok 146 AdminUpdateUserV3
ok 147 AdminGetUserBanV3
ok 148 AdminBanUserV3
ok 149 AdminUpdateUserBanV3
ok 150 AdminSendVerificationCodeV3
ok 151 AdminVerifyAccountV3
ok 152 GetUserVerificationCode
ok 153 AdminGetUserDeletionStatusV3
ok 154 AdminUpdateUserDeletionStatusV3
ok 155 AdminUpgradeHeadlessAccountV3
ok 156 AdminDeleteUserInformationV3
ok 157 AdminGetUserLoginHistoriesV3
ok 158 AdminUpdateUserPermissionV3
ok 159 AdminAddUserPermissionsV3
ok 160 AdminDeleteUserPermissionBulkV3
ok 161 AdminDeleteUserPermissionV3
ok 162 AdminGetUserPlatformAccountsV3
ok 163 AdminGetListJusticePlatformAccounts
ok 164 AdminCreateJusticeUser
ok 165 AdminLinkPlatformAccount
ok 166 AdminPlatformUnlinkV3
ok 167 AdminPlatformLinkV3
ok 168 AdminDeleteUserRolesV3
ok 169 AdminSaveUserRoleV3
ok 170 AdminAddUserRoleV3
ok 171 AdminDeleteUserRoleV3
ok 172 AdminUpdateUserStatusV3
ok 173 AdminVerifyUserWithoutVerificationCodeV3
ok 174 AdminGetRolesV3
ok 175 AdminCreateRoleV3
ok 176 AdminGetRoleV3
ok 177 AdminDeleteRoleV3
ok 178 AdminUpdateRoleV3
ok 179 AdminGetRoleAdminStatusV3
ok 180 AdminUpdateAdminRoleStatusV3
ok 181 AdminRemoveRoleAdminV3
ok 182 AdminGetRoleManagersV3
ok 183 AdminAddRoleManagersV3
ok 184 AdminRemoveRoleManagersV3
ok 185 AdminGetRoleMembersV3
ok 186 AdminAddRoleMembersV3
ok 187 AdminRemoveRoleMembersV3
ok 188 AdminUpdateRolePermissionsV3
ok 189 AdminAddRolePermissionsV3
ok 190 AdminDeleteRolePermissionsV3
ok 191 AdminDeleteRolePermissionV3
ok 192 AdminGetMyUserV3
ok 193 UserAuthenticationV3
ok 194 GetCountryLocationV3
ok 195 Logout
ok 196 AdminRetrieveUserThirdPartyPlatformTokenV3
ok 197 RevokeUserV3
ok 198 AuthorizeV3
ok 199 TokenIntrospectionV3
ok 200 GetJWKSV3
ok 201 RetrieveUserThirdPartyPlatformTokenV3
ok 202 AuthCodeRequestV3
ok 203 PlatformTokenGrantV3
ok 204 GetRevocationListV3
ok 205 TokenRevocationV3
ok 206 TokenGrantV3
ok 207 PlatformAuthenticationV3
ok 208 PublicGetInputValidations
ok 209 RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
ok 210 PublicListUserIDByPlatformUserIDsV3
ok 211 PublicGetUserByPlatformUserIDV3
ok 212 PublicGetAsyncStatus
ok 213 PublicSearchUserV3
ok 214 PublicCreateUserV3
ok 215 CheckUserAvailability
ok 216 PublicBulkGetUsers
ok 217 PublicForgotPasswordV3
ok 218 GetAdminInvitationV3
ok 219 CreateUserFromInvitationV3
ok 220 UpdateUserV3
ok 221 PublicUpdateUserV3
ok 222 PublicSendVerificationCodeV3
ok 223 PublicUserVerificationV3
ok 224 PublicUpgradeHeadlessAccountV3
ok 225 PublicVerifyHeadlessAccountV3
ok 226 PublicUpdatePasswordV3
ok 227 PublicCreateJusticeUser
ok 228 PublicPlatformLinkV3
ok 229 PublicPlatformUnlinkV3
ok 230 PublicWebLinkPlatform
ok 231 PublicWebLinkPlatformEstablish
ok 232 ResetPasswordV3
ok 233 PublicGetUserByUserIdV3
ok 234 PublicGetUserBanHistoryV3
ok 235 PublicGetUserLoginHistoriesV3
ok 236 PublicGetUserPlatformAccountsV3
ok 237 PublicLinkPlatformAccount
ok 238 PublicValidateUserByUserIDAndPasswordV3
ok 239 PublicGetRolesV3
ok 240 PublicGetRoleV3
ok 241 PublicGetMyUserV3
ok 242 PlatformAuthenticateSAMLV3Handler
ok 243 LoginSSOClient
ok 244 LogoutSSOClient
ok 245 AdminUpdateUserV4
ok 246 AdminUpdateUserEmailAddressV4
ok 247 AdminListUserRolesV4
ok 248 AdminUpdateUserRoleV4
ok 249 AdminAddUserRoleV4
ok 250 AdminRemoveUserRoleV4
ok 251 AdminGetRolesV4
ok 252 AdminCreateRoleV4
ok 253 AdminGetRoleV4
ok 254 AdminDeleteRoleV4
ok 255 AdminUpdateRoleV4
ok 256 AdminUpdateRolePermissionsV4
ok 257 AdminAddRolePermissionsV4
ok 258 AdminDeleteRolePermissionsV4
ok 259 AdminListAssignedUsersV4
ok 260 AdminAssignUserToRoleV4
ok 261 AdminRevokeUserFromRoleV4
ok 262 AdminUpdateMyUserV4
ok 263 AdminInviteUserV4
ok 264 PublicCreateTestUserV4
ok 265 PublicCreateUserV4
ok 266 CreateUserFromInvitationV4
ok 267 PublicUpdateUserV4
ok 268 PublicUpdateUserEmailAddressV4
ok 269 PublicUpgradeHeadlessAccountWithVerificationCodeV4
ok 270 PublicUpgradeHeadlessAccountV4
```

```tap
run-cli-group-unit-test.sh

TAP version 13
1..44
ok 1 ListGroupConfigurationAdminV1
ok 2 CreateGroupConfigurationAdminV1
ok 3 InitiateGroupConfigurationAdminV1
ok 4 GetGroupConfigurationAdminV1
ok 5 DeleteGroupConfigurationV1
ok 6 UpdateGroupConfigurationAdminV1
ok 7 UpdateGroupConfigurationGlobalRuleAdminV1
ok 8 DeleteGroupConfigurationGlobalRuleAdminV1
ok 9 GetGroupListAdminV1
ok 10 GetSingleGroupAdminV1
ok 11 DeleteGroupAdminV1
ok 12 GetGroupMembersListAdminV1
ok 13 GetMemberRolesListAdminV1
ok 14 CreateMemberRoleAdminV1
ok 15 GetSingleMemberRoleAdminV1
ok 16 DeleteMemberRoleAdminV1
ok 17 UpdateMemberRoleAdminV1
ok 18 UpdateMemberRolePermissionAdminV1
ok 19 GetGroupListPublicV1
ok 20 CreateNewGroupPublicV1
ok 21 GetSingleGroupPublicV1
ok 22 UpdateSingleGroupV1
ok 23 DeleteGroupPublicV1
ok 24 UpdatePatchSingleGroupPublicV1
ok 25 UpdateGroupCustomAttributesPublicV1
ok 26 AcceptGroupInvitationPublicV1
ok 27 RejectGroupInvitationPublicV1
ok 28 JoinGroupV1
ok 29 CancelGroupJoinRequestV1
ok 30 GetGroupJoinRequestPublicV1
ok 31 GetGroupMembersListPublicV1
ok 32 UpdateGroupCustomRulePublicV1
ok 33 UpdateGroupPredefinedRulePublicV1
ok 34 DeleteGroupPredefinedRulePublicV1
ok 35 LeaveGroupPublicV1
ok 36 GetMemberRolesListPublicV1
ok 37 UpdateMemberRolePublicV1
ok 38 DeleteMemberRolePublicV1
ok 39 GetGroupInvitationRequestPublicV1
ok 40 GetUserGroupInformationPublicV1
ok 41 InviteGroupPublicV1
ok 42 AcceptGroupJoinRequestPublicV1
ok 43 RejectGroupJoinRequestPublicV1
ok 44 KickGroupMemberPublicV1
```

```tap
run-cli-social-unit-test.sh

TAP version 13
1..68
ok 1 GetNamespaceSlotConfig
ok 2 UpdateNamespaceSlotConfig
ok 3 DeleteNamespaceSlotConfig
ok 4 GetUserSlotConfig
ok 5 UpdateUserSlotConfig
ok 6 DeleteUserSlotConfig
ok 7 GetUserProfiles
ok 8 GetProfile
ok 9 GetUserNamespaceSlots
ok 10 GetSlotData
ok 11 PublicGetUserGameProfiles
ok 12 PublicGetUserProfiles
ok 13 PublicCreateProfile
ok 14 PublicGetProfile
ok 15 PublicUpdateProfile
ok 16 PublicDeleteProfile
ok 17 PublicGetProfileAttribute
ok 18 PublicUpdateAttribute
ok 19 PublicGetUserNamespaceSlots
ok 20 PublicCreateUserNamespaceSlot
ok 21 PublicGetSlotData
ok 22 PublicUpdateUserNamespaceSlot
ok 23 PublicDeleteUserNamespaceSlot
ok 24 PublicUpdateUserNamespaceSlotMetadata
ok 25 GetGlobalStatItems
ok 26 BulkFetchStatItems
ok 27 BulkIncUserStatItem
ok 28 BulkIncUserStatItemValue
ok 29 BulkResetUserStatItem
ok 30 GetStats
ok 31 CreateStat
ok 32 ExportStats
ok 33 ImportStats
ok 34 QueryStats
ok 35 GetStat
ok 36 DeleteStat
ok 37 UpdateStat
ok 38 GetUserStatItems
ok 39 BulkCreateUserStatItems
ok 40 BulkIncUserStatItem1
ok 41 BulkIncUserStatItemValue1
ok 42 BulkResetUserStatItem1
ok 43 CreateUserStatItem
ok 44 DeleteUserStatItems
ok 45 IncUserStatItemValue
ok 46 ResetUserStatItemValue
ok 47 BulkFetchStatItems1
ok 48 PublicBulkIncUserStatItem
ok 49 PublicBulkIncUserStatItemValue
ok 50 BulkResetUserStatItem2
ok 51 CreateStat1
ok 52 PublicQueryUserStatItems
ok 53 PublicBulkCreateUserStatItems
ok 54 PublicBulkIncUserStatItem1
ok 55 BulkIncUserStatItemValue2
ok 56 BulkResetUserStatItem3
ok 57 PublicCreateUserStatItem
ok 58 DeleteUserStatItems1
ok 59 PublicIncUserStatItem
ok 60 PublicIncUserStatItemValue
ok 61 ResetUserStatItemValue1
ok 62 BulkUpdateUserStatItemV2
ok 63 BulkUpdateUserStatItem
ok 64 DeleteUserStatItems2
ok 65 UpdateUserStatItemValue
ok 66 BulkUpdateUserStatItem1
ok 67 BulkUpdateUserStatItem2
ok 68 UpdateUserStatItemValue1
```

```tap
run-cli-eventlog-unit-test.sh

TAP version 13
1..32
ok 1 AgentTypeDescriptionHandler (skipped deprecated)
ok 2 SpecificAgentTypeDescriptionHandler (skipped deprecated)
ok 3 EventIDDescriptionHandler (skipped deprecated)
ok 4 SpecificEventIDDescriptionHandler (skipped deprecated)
ok 5 EventLevelDescriptionHandler (skipped deprecated)
ok 6 SpecificEventLevelDescriptionHandler (skipped deprecated)
ok 7 EventTypeDescriptionHandler (skipped deprecated)
ok 8 SpecificEventTypeDescriptionHandler (skipped deprecated)
ok 9 UXNameDescriptionHandler (skipped deprecated)
ok 10 SpecificUXDescriptionHandler (skipped deprecated)
ok 11 GetEventByNamespaceHandler (skipped deprecated)
ok 12 PostEventHandler (skipped deprecated)
ok 13 GetEventByEventIDHandler (skipped deprecated)
ok 14 GetEventByEventTypeHandler (skipped deprecated)
ok 15 GetEventByEventTypeAndEventIDHandler (skipped deprecated)
ok 16 GetEventByUserIDHandler (skipped deprecated)
ok 17 GetUserActivitiesHandler (skipped deprecated)
ok 18 DeleteUserActivitiesHandler (skipped deprecated)
ok 19 GetEventByUserIDAndEventIDHandler (skipped deprecated)
ok 20 GetEventByUserIDAndEventTypeHandler (skipped deprecated)
ok 21 GetEventByUserEventIDAndEventTypeHandler (skipped deprecated)
ok 22 LastUserActivityTimeHandler (skipped deprecated)
ok 23 GetRegisteredEventsHandler (skipped deprecated)
ok 24 RegisterEventHandler (skipped deprecated)
ok 25 GetRegisteredEventIDHandler (skipped deprecated)
ok 26 UpdateEventRegistryHandler (skipped deprecated)
ok 27 UnregisterEventIDHandler (skipped deprecated)
ok 28 GetRegisteredEventsByEventTypeHandler (skipped deprecated)
ok 29 QueryEventStreamHandler
ok 30 GetEventSpecificUserV2Handler
ok 31 GetPublicEditHistory
ok 32 GetUserEventsV2Public
```

```tap
run-cli-platform-unit-test.sh

TAP version 13
1..316
ok 1 ListFulfillmentScripts
ok 2 TestFulfillmentScriptEval
ok 3 GetFulfillmentScript
ok 4 CreateFulfillmentScript
ok 5 DeleteFulfillmentScript
ok 6 UpdateFulfillmentScript
ok 7 QueryCampaigns
ok 8 CreateCampaign
ok 9 GetCampaign
ok 10 UpdateCampaign
ok 11 GetCampaignDynamic
ok 12 GetRootCategories
ok 13 CreateCategory
ok 14 ListCategoriesBasic
ok 15 GetCategory
ok 16 UpdateCategory
ok 17 DeleteCategory
ok 18 GetChildCategories
ok 19 GetDescendantCategories
ok 20 QueryCodes
ok 21 CreateCodes
ok 22 Download
ok 23 BulkDisableCodes
ok 24 BulkEnableCodes
ok 25 QueryRedeemHistory
ok 26 GetCode
ok 27 DisableCode
ok 28 EnableCode
ok 29 ListCurrencies
ok 30 CreateCurrency
ok 31 UpdateCurrency
ok 32 DeleteCurrency
ok 33 GetCurrencyConfig
ok 34 GetCurrencySummary
ok 35 GetDLCItemConfig
ok 36 UpdateDLCItemConfig
ok 37 DeleteDLCItemConfig
ok 38 GetPlatformDLCConfig
ok 39 UpdatePlatformDLCConfig
ok 40 DeletePlatformDLCConfig
ok 41 QueryEntitlements
ok 42 GetEntitlement
ok 43 QueryFulfillmentHistories
ok 44 GetAppleIAPConfig
ok 45 UpdateAppleIAPConfig
ok 46 DeleteAppleIAPConfig
ok 47 GetEpicGamesIAPConfig
ok 48 UpdateEpicGamesIAPConfig
ok 49 DeleteEpicGamesIAPConfig
ok 50 GetGoogleIAPConfig
ok 51 UpdateGoogleIAPConfig
ok 52 DeleteGoogleIAPConfig
ok 53 UpdateGoogleP12File
ok 54 GetIAPItemConfig
ok 55 UpdateIAPItemConfig
ok 56 DeleteIAPItemConfig
ok 57 GetPlayStationIAPConfig
ok 58 UpdatePlaystationIAPConfig
ok 59 DeletePlaystationIAPConfig
ok 60 GetStadiaIAPConfig
ok 61 DeleteStadiaIAPConfig
ok 62 UpdateStadiaJsonConfigFile
ok 63 GetSteamIAPConfig
ok 64 UpdateSteamIAPConfig
ok 65 DeleteSteamIAPConfig
ok 66 GetXblIAPConfig
ok 67 UpdateXblIAPConfig
ok 68 DeleteXblAPConfig
ok 69 UpdateXblBPCertFile
ok 70 SyncInGameItem
ok 71 CreateItem
ok 72 GetItemByAppId
ok 73 QueryItems
ok 74 ListBasicItemsByFeatures
ok 75 GetItemBySku
ok 76 GetLocaleItemBySku
ok 77 GetItemIdBySku
ok 78 BulkGetLocaleItems
ok 79 SearchItems
ok 80 QueryUncategorizedItems
ok 81 GetItem
ok 82 UpdateItem
ok 83 DeleteItem
ok 84 AcquireItem
ok 85 GetApp
ok 86 UpdateApp
ok 87 DisableItem
ok 88 GetItemDynamicData
ok 89 EnableItem
ok 90 FeatureItem
ok 91 DefeatureItem
ok 92 GetLocaleItem
ok 93 ReturnItem
ok 94 QueryKeyGroups
ok 95 CreateKeyGroup
ok 96 GetKeyGroup
ok 97 UpdateKeyGroup
ok 98 GetKeyGroupDynamic
ok 99 ListKeys
ok 100 UploadKeys
ok 101 QueryOrders
ok 102 GetOrderStatistics
ok 103 GetOrder
ok 104 RefundOrder
ok 105 GetPaymentCallbackConfig
ok 106 UpdatePaymentCallbackConfig
ok 107 QueryPaymentNotifications
ok 108 QueryPaymentOrders
ok 109 CreatePaymentOrderByDedicated
ok 110 ListExtOrderNoByExtTxId
ok 111 GetPaymentOrder
ok 112 ChargePaymentOrder
ok 113 RefundPaymentOrderByDedicated
ok 114 SimulatePaymentOrderNotification
ok 115 GetPaymentOrderChargeStatus
ok 116 CreateReward
ok 117 QueryRewards
ok 118 ExportRewards
ok 119 ImportRewards
ok 120 GetReward
ok 121 UpdateReward
ok 122 DeleteReward
ok 123 CheckEventCondition
ok 124 ListStores
ok 125 CreateStore
ok 126 ImportStore
ok 127 GetPublishedStore
ok 128 DeletePublishedStore
ok 129 GetPublishedStoreBackup
ok 130 RollbackPublishedStore
ok 131 GetStore
ok 132 UpdateStore
ok 133 DeleteStore
ok 134 CloneStore
ok 135 ExportStore
ok 136 QuerySubscriptions
ok 137 RecurringChargeSubscription
ok 138 GetTicketDynamic
ok 139 DecreaseTicketSale
ok 140 GetTicketBoothID
ok 141 IncreaseTicketSale
ok 142 AnonymizeCampaign
ok 143 AnonymizeEntitlement
ok 144 AnonymizeFulfillment
ok 145 AnonymizeIntegration
ok 146 AnonymizeOrder
ok 147 AnonymizePayment
ok 148 AnonymizeSubscription
ok 149 AnonymizeWallet
ok 150 QueryUserEntitlements
ok 151 GrantUserEntitlement
ok 152 GetUserAppEntitlementByAppId
ok 153 QueryUserEntitlementsByAppType
ok 154 GetUserEntitlementByItemId
ok 155 GetUserEntitlementBySku
ok 156 ExistsAnyUserActiveEntitlement
ok 157 ExistsAnyUserActiveEntitlementByItemIds
ok 158 GetUserAppEntitlementOwnershipByAppId
ok 159 GetUserEntitlementOwnershipByItemId
ok 160 GetUserEntitlementOwnershipBySku
ok 161 RevokeUserEntitlements
ok 162 GetUserEntitlement
ok 163 UpdateUserEntitlement
ok 164 ConsumeUserEntitlement
ok 165 DisableUserEntitlement
ok 166 EnableUserEntitlement
ok 167 GetUserEntitlementHistories
ok 168 RevokeUserEntitlement
ok 169 FulfillItem
ok 170 RedeemCode
ok 171 FulfillRewards
ok 172 QueryUserIAPOrders
ok 173 QueryAllUserIAPOrders
ok 174 MockFulfillIAPItem
ok 175 QueryUserOrders
ok 176 CountOfPurchasedItem
ok 177 GetUserOrder
ok 178 UpdateUserOrderStatus
ok 179 FulfillUserOrder
ok 180 GetUserOrderGrant
ok 181 GetUserOrderHistories
ok 182 ProcessUserOrderNotification
ok 183 DownloadUserOrderReceipt
ok 184 CreateUserPaymentOrder
ok 185 RefundUserPaymentOrder
ok 186 ApplyUserRedemption
ok 187 QueryUserSubscriptions
ok 188 GetUserSubscriptionActivities
ok 189 PlatformSubscribeSubscription
ok 190 CheckUserSubscriptionSubscribableByItemId
ok 191 GetUserSubscription
ok 192 DeleteUserSubscription
ok 193 CancelSubscription
ok 194 GrantDaysToSubscription
ok 195 GetUserSubscriptionBillingHistories
ok 196 ProcessUserSubscriptionNotification
ok 197 AcquireUserTicket
ok 198 CheckWallet
ok 199 CreditUserWallet
ok 200 PayWithUserWallet
ok 201 GetUserWallet
ok 202 DebitUserWallet
ok 203 DisableUserWallet
ok 204 EnableUserWallet
ok 205 ListUserWalletTransactions
ok 206 QueryWallets
ok 207 GetWallet
ok 208 SyncOrders
ok 209 TestAdyenConfig
ok 210 TestAliPayConfig
ok 211 TestCheckoutConfig
ok 212 DebugMatchedPaymentMerchantConfig
ok 213 TestPayPalConfig
ok 214 TestStripeConfig
ok 215 TestWxPayConfig
ok 216 TestXsollaConfig
ok 217 GetPaymentMerchantConfig
ok 218 UpdateAdyenConfig
ok 219 TestAdyenConfigById
ok 220 UpdateAliPayConfig
ok 221 TestAliPayConfigById
ok 222 UpdateCheckoutConfig
ok 223 TestCheckoutConfigById
ok 224 UpdatePayPalConfig
ok 225 TestPayPalConfigById
ok 226 UpdateStripeConfig
ok 227 TestStripeConfigById
ok 228 UpdateWxPayConfig
ok 229 UpdateWxPayConfigCert
ok 230 TestWxPayConfigById
ok 231 UpdateXsollaConfig
ok 232 TestXsollaConfigById
ok 233 UpdateXsollaUIConfig
ok 234 QueryPaymentProviderConfig
ok 235 CreatePaymentProviderConfig
ok 236 GetAggregatePaymentProviders
ok 237 DebugMatchedPaymentProviderConfig
ok 238 GetSpecialPaymentProviders
ok 239 UpdatePaymentProviderConfig
ok 240 DeletePaymentProviderConfig
ok 241 GetPaymentTaxConfig
ok 242 UpdatePaymentTaxConfig
ok 243 SyncPaymentOrders
ok 244 PublicGetRootCategories
ok 245 DownloadCategories
ok 246 PublicGetCategory
ok 247 PublicGetChildCategories
ok 248 PublicGetDescendantCategories
ok 249 PublicListCurrencies
ok 250 PublicGetItemByAppId
ok 251 PublicQueryItems
ok 252 PublicGetItemBySku
ok 253 PublicBulkGetItems
ok 254 PublicSearchItems
ok 255 PublicGetApp
ok 256 PublicGetItemDynamicData
ok 257 PublicGetItem
ok 258 GetPaymentCustomization
ok 259 PublicGetPaymentUrl
ok 260 PublicGetPaymentMethods
ok 261 PublicGetUnpaidPaymentOrder
ok 262 Pay
ok 263 PublicCheckPaymentOrderPaidStatus
ok 264 GetPaymentPublicConfig
ok 265 PublicGetQRCode
ok 266 PublicNormalizePaymentReturnUrl
ok 267 GetPaymentTaxValue
ok 268 GetRewardByCode
ok 269 QueryRewards1
ok 270 GetReward1
ok 271 PublicListStores
ok 272 PublicExistsAnyMyActiveEntitlement
ok 273 PublicGetMyAppEntitlementOwnershipByAppId
ok 274 PublicGetMyEntitlementOwnershipByItemId
ok 275 PublicGetMyEntitlementOwnershipBySku
ok 276 PublicGetEntitlementOwnershipToken
ok 277 PublicGetMyWallet
ok 278 PublicSyncPsnDlcInventory
ok 279 SyncSteamDLC
ok 280 SyncXboxDLC
ok 281 PublicQueryUserEntitlements
ok 282 PublicGetUserAppEntitlementByAppId
ok 283 PublicQueryUserEntitlementsByAppType
ok 284 PublicGetUserEntitlementByItemId
ok 285 PublicGetUserEntitlementBySku
ok 286 PublicExistsAnyUserActiveEntitlement
ok 287 PublicGetUserAppEntitlementOwnershipByAppId
ok 288 PublicGetUserEntitlementOwnershipByItemId
ok 289 PublicGetUserEntitlementOwnershipBySku
ok 290 PublicGetUserEntitlement
ok 291 PublicConsumeUserEntitlement
ok 292 PublicRedeemCode
ok 293 PublicFulfillAppleIAPItem
ok 294 SyncEpicGamesInventory
ok 295 PublicFulfillGoogleIAPItem
ok 296 PublicReconcilePlayStationStore
ok 297 SyncStadiaEntitlement
ok 298 SyncSteamInventory
ok 299 SyncXboxInventory
ok 300 PublicQueryUserOrders
ok 301 PublicCreateUserOrder
ok 302 PublicGetUserOrder
ok 303 PublicCancelUserOrder
ok 304 PublicGetUserOrderHistories
ok 305 PublicDownloadUserOrderReceipt
ok 306 PublicGetPaymentAccounts
ok 307 PublicDeletePaymentAccount
ok 308 PublicQueryUserSubscriptions
ok 309 PublicSubscribeSubscription
ok 310 PublicCheckUserSubscriptionSubscribableByItemId
ok 311 PublicGetUserSubscription
ok 312 PublicChangeSubscriptionBillingAccount
ok 313 PublicCancelSubscription
ok 314 PublicGetUserSubscriptionBillingHistories
ok 315 PublicGetWallet
ok 316 PublicListUserWalletTransactions
```

```tap
run-cli-leaderboard-unit-test.sh

TAP version 13
1..34
ok 1 GetLeaderboardConfigurationsAdminV1
ok 2 CreateLeaderboardConfigurationAdminV1
ok 3 AdminGetArchivedLeaderboardRankingDataV1Handler
ok 4 CreateArchivedLeaderboardRankingDataV1Handler
ok 5 DeleteBulkLeaderboardConfigurationAdminV1
ok 6 GetLeaderboardConfigurationAdminV1
ok 7 UpdateLeaderboardConfigurationAdminV1
ok 8 DeleteLeaderboardConfigurationAdminV1
ok 9 GetAllTimeLeaderboardRankingAdminV1
ok 10 GetCurrentMonthLeaderboardRankingAdminV1
ok 11 GetCurrentSeasonLeaderboardRankingAdminV1
ok 12 GetTodayLeaderboardRankingAdminV1
ok 13 GetUserRankingAdminV1
ok 14 UpdateUserPointAdminV1
ok 15 DeleteUserRankingAdminV1
ok 16 GetCurrentWeekLeaderboardRankingAdminV1
ok 17 DeleteUserRankingsAdminV1
ok 18 GetUserLeaderboardRankingsAdminV1
ok 19 GetLeaderboardConfigurationsPublicV1
ok 20 CreateLeaderboardConfigurationPublicV1
ok 21 GetAllTimeLeaderboardRankingPublicV1
ok 22 GetArchivedLeaderboardRankingDataV1Handler
ok 23 GetCurrentMonthLeaderboardRankingPublicV1
ok 24 GetCurrentSeasonLeaderboardRankingPublicV1
ok 25 GetTodayLeaderboardRankingPublicV1
ok 26 GetUserRankingPublicV1
ok 27 DeleteUserRankingPublicV1
ok 28 GetCurrentWeekLeaderboardRankingPublicV1
ok 29 GetHiddenUsersV2
ok 30 GetUserVisibilityStatusV2
ok 31 SetUserLeaderboardVisibilityStatusV2
ok 32 SetUserVisibilityStatusV2
ok 33 GetLeaderboardConfigurationsPublicV2
ok 34 GetAllTimeLeaderboardRankingPublicV2
```

```tap
run-cli-cloudsave-unit-test.sh

TAP version 13
1..30
ok 1 ListGameRecordsHandlerV1
ok 2 AdminGetGameRecordHandlerV1
ok 3 AdminPutGameRecordHandlerV1
ok 4 AdminPostGameRecordHandlerV1
ok 5 AdminDeleteGameRecordHandlerV1
ok 6 ListPlayerRecordHandlerV1 (skipped deprecated)
ok 7 AdminRetrievePlayerRecords
ok 8 AdminGetPlayerRecordHandlerV1
ok 9 AdminPutPlayerRecordHandlerV1
ok 10 AdminPostPlayerRecordHandlerV1
ok 11 AdminDeletePlayerRecordHandlerV1
ok 12 AdminGetPlayerPublicRecordHandlerV1
ok 13 AdminPutPlayerPublicRecordHandlerV1
ok 14 AdminPostPlayerPublicRecordHandlerV1
ok 15 AdminDeletePlayerPublicRecordHandlerV1
ok 16 PutGameRecordConcurrentHandlerV1
ok 17 GetGameRecordHandlerV1
ok 18 PutGameRecordHandlerV1
ok 19 PostGameRecordHandlerV1
ok 20 DeleteGameRecordHandlerV1
ok 21 BulkGetPlayerPublicRecordHandlerV1
ok 22 PublicDeletePlayerPublicRecordHandlerV1
ok 23 PutPlayerPublicRecordConcurrentHandlerV1
ok 24 GetPlayerRecordHandlerV1
ok 25 PutPlayerRecordHandlerV1
ok 26 PostPlayerRecordHandlerV1
ok 27 DeletePlayerRecordHandlerV1
ok 28 GetPlayerPublicRecordHandlerV1
ok 29 PutPlayerPublicRecordHandlerV1
ok 30 PostPlayerPublicRecordHandlerV1
```

```tap
run-cli-matchmaking-unit-test.sh

TAP version 13
1..28
ok 1 GetHealthcheckInfo
ok 2 HandlerV3Healthz
ok 3 GetAllChannelsHandler
ok 4 CreateChannelHandler
ok 5 DeleteChannelHandler
ok 6 StoreMatchResults
ok 7 QueueSessionHandler
ok 8 DequeueSessionHandler
ok 9 QuerySessionHandler
ok 10 UpdatePlayTimeWeight
ok 11 GetAllPartyInAllChannel
ok 12 BulkGetSessions
ok 13 ExportChannels
ok 14 ImportChannels
ok 15 GetSingleMatchmakingChannel
ok 16 UpdateMatchmakingChannel
ok 17 GetAllPartyInChannel
ok 18 GetAllSessionsInChannel
ok 19 AddUserIntoSessionInChannel
ok 20 DeleteSessionInChannel
ok 21 DeleteUserFromSessionInChannel
ok 22 SearchSessions
ok 23 GetSessionHistoryDetailed
ok 24 PublicGetMessages
ok 25 PublicGetAllMatchmakingChannel
ok 26 PublicGetSingleMatchmakingChannel
ok 27 SearchSessionsV2
ok 28 VersionCheckHandler
```

```tap
run-cli-legal-unit-test.sh

TAP version 13
1..41
ok 1 RetrieveAcceptedAgreements
ok 2 RetrieveAllUsersByPolicyVersion
ok 3 RetrieveAllLegalPolicies
ok 4 CreatePolicy
ok 5 RetrieveSinglePolicy
ok 6 PartialUpdatePolicy
ok 7 RetrievePolicyCountry
ok 8 RetrieveLocalizedPolicyVersions
ok 9 CreateLocalizedPolicyVersion
ok 10 RetrieveSingleLocalizedPolicyVersion
ok 11 UpdateLocalizedPolicyVersion
ok 12 RequestPresignedURL
ok 13 SetDefaultPolicy
ok 14 IndirectBulkAcceptVersionedPolicy
ok 15 AdminRetrieveEligibilities
ok 16 RetrievePolicies
ok 17 UpdatePolicyVersion
ok 18 PublishPolicyVersion
ok 19 UpdatePolicy
ok 20 SetDefaultPolicy1
ok 21 RetrieveSinglePolicyVersion
ok 22 CreatePolicyVersion
ok 23 RetrieveAllPolicyTypes
ok 24 GetUserInfoStatus
ok 25 SyncUserInfo
ok 26 InvalidateUserInfoCache
ok 27 AnonymizeUserAgreement
ok 28 ChangePreferenceConsent
ok 29 AcceptVersionedPolicy
ok 30 RetrieveAgreementsPublic
ok 31 BulkAcceptVersionedPolicy
ok 32 IndirectBulkAcceptVersionedPolicyV2
ok 33 IndirectBulkAcceptVersionedPolicy1
ok 34 RetrieveEligibilitiesPublic
ok 35 RetrieveEligibilitiesPublicIndirect
ok 36 RetrieveSingleLocalizedPolicyVersion1
ok 37 RetrievePolicyVersions
ok 38 RetrieveLatestPolicies
ok 39 RetrieveLatestPoliciesPublic
ok 40 RetrieveLatestPoliciesByNamespaceAndCountryPublic
ok 41 CheckReadiness
```

```tap
run-cli-lobby-unit-test.sh

TAP version 13
1..89
ok 1 GetUserFriendsUpdated
ok 2 GetUserIncomingFriends
ok 3 GetUserOutgoingFriends
ok 4 UserRequestFriend
ok 5 UserAcceptFriendRequest
ok 6 UserCancelFriendRequest
ok 7 UserRejectFriendRequest
ok 8 UserGetFriendshipStatus
ok 9 UserUnfriendRequest
ok 10 AddFriendsWithoutConfirmation
ok 11 PersonalChatHistory
ok 12 AdminChatHistory
ok 13 AdminGetAllConfigV1
ok 14 AdminGetConfigV1
ok 15 AdminUpdateConfigV1
ok 16 ExportConfig
ok 17 ImportConfig
ok 18 GetListOfFriends
ok 19 SendMultipleUsersFreeformNotificationV1Admin
ok 20 SendUsersFreeformNotificationV1Admin
ok 21 SendPartyFreeformNotificationV1Admin
ok 22 SendPartyTemplatedNotificationV1Admin
ok 23 GetAllNotificationTemplatesV1Admin
ok 24 CreateNotificationTemplateV1Admin
ok 25 SendUsersTemplatedNotificationV1Admin
ok 26 GetTemplateSlugLocalizationsTemplateV1Admin
ok 27 DeleteNotificationTemplateSlugV1Admin
ok 28 GetSingleTemplateLocalizationV1Admin
ok 29 UpdateTemplateLocalizationV1Admin
ok 30 DeleteTemplateLocalizationV1Admin
ok 31 PublishTemplateLocalizationV1Admin
ok 32 GetAllNotificationTopicsV1Admin
ok 33 CreateNotificationTopicV1Admin
ok 34 GetNotificationTopicV1Admin
ok 35 UpdateNotificationTopicV1Admin
ok 36 DeleteNotificationTopicV1Admin
ok 37 SendSpecificUserFreeformNotificationV1Admin
ok 38 SendSpecificUserTemplatedNotificationV1Admin
ok 39 AdminGetPartyDataV1
ok 40 AdminUpdatePartyAttributesV1
ok 41 AdminGetUserPartyV1
ok 42 AdminGetLobbyCCU
ok 43 AdminGetAllPlayerSessionAttribute
ok 44 AdminSetPlayerSessionAttribute
ok 45 AdminGetPlayerSessionAttribute
ok 46 AdminGetPlayerBlockedPlayersV1
ok 47 AdminGetPlayerBlockedByPlayersV1
ok 48 AdminBulkBlockPlayersV1
ok 49 AdminDebugProfanityFilters
ok 50 AdminGetProfanityListFiltersV1
ok 51 AdminAddProfanityFilterIntoList
ok 52 AdminAddProfanityFilters
ok 53 AdminImportProfanityFiltersFromFile
ok 54 AdminDeleteProfanityFilter
ok 55 AdminGetProfanityLists
ok 56 AdminCreateProfanityList
ok 57 AdminUpdateProfanityList
ok 58 AdminDeleteProfanityList
ok 59 AdminGetProfanityRule
ok 60 AdminSetProfanityRuleForNamespace
ok 61 AdminVerifyMessageProfanityResponse
ok 62 AdminGetThirdPartyConfig
ok 63 AdminUpdateThirdPartyConfig
ok 64 AdminCreateThirdPartyConfig
ok 65 AdminDeleteThirdPartyConfig
ok 66 PublicGetMessages
ok 67 GetPersonalChatHistoryV1Public
ok 68 PublicGetPartyDataV1
ok 69 PublicUpdatePartyAttributesV1
ok 70 PublicGetPlayerBlockedPlayersV1
ok 71 PublicGetPlayerBlockedByPlayersV1
ok 72 UsersPresenceHandlerV1
ok 73 FreeFormNotification
ok 74 NotificationWithTemplate
ok 75 GetGameTemplate
ok 76 CreateTemplate
ok 77 GetSlugTemplate
ok 78 DeleteTemplateSlug
ok 79 GetLocalizationTemplate
ok 80 UpdateLocalizationTemplate
ok 81 DeleteTemplateLocalization
ok 82 PublishTemplate
ok 83 GetTopicByNamespace
ok 84 CreateTopic
ok 85 GetTopicByTopicName
ok 86 UpdateTopicByTopicName
ok 87 DeleteTopicByTopicName
ok 88 FreeFormNotificationByUserID
ok 89 NotificationWithTemplateByUserID
```

```tap
run-cli-qosm-unit-test.sh

TAP version 13
1..4
ok 1 DeleteServer
ok 2 SetServerAlias
ok 3 ListServer
ok 4 Heartbeat
```

```tap
run-cli-dslogmanager-unit-test.sh

TAP version 13
1..6
ok 1 ListTerminatedServers
ok 2 DownloadServerLogs
ok 3 CheckServerLogs
ok 4 BatchDownloadServerLogs
ok 5 ListAllTerminatedServers
ok 6 PublicGetMessages
```

```tap
run-cli-ugc-unit-test.sh

TAP version 13
1..84
ok 1 SingleAdminGetChannel
ok 2 AdminCreateChannel
ok 3 SingleAdminUpdateChannel
ok 4 SingleAdminDeleteChannel
ok 5 AdminUploadContentDirect (skipped deprecated)
ok 6 AdminUploadContentS3
ok 7 SingleAdminUpdateContentS3
ok 8 AdminSearchChannelSpecificContent
ok 9 SingleAdminUpdateContentDirect (skipped deprecated)
ok 10 SingleAdminDeleteContent
ok 11 SingleAdminGetContent
ok 12 AdminSearchContent
ok 13 AdminGetSpecificContent
ok 14 AdminDownloadContentPreview
ok 15 AdminUpdateScreenshots
ok 16 AdminUploadContentScreenshot
ok 17 AdminDeleteContentScreenshot
ok 18 SingleAdminGetAllGroups
ok 19 AdminCreateGroup
ok 20 SingleAdminGetGroup
ok 21 SingleAdminUpdateGroup
ok 22 SingleAdminDeleteGroup
ok 23 SingleAdminGetGroupContents
ok 24 AdminGetTag
ok 25 AdminCreateTag
ok 26 AdminUpdateTag
ok 27 AdminDeleteTag
ok 28 AdminGetType
ok 29 AdminCreateType
ok 30 AdminUpdateType
ok 31 AdminDeleteType
ok 32 AdminGetChannel
ok 33 AdminDeleteAllUserChannels
ok 34 AdminUpdateChannel
ok 35 AdminDeleteChannel
ok 36 AdminUpdateContentS3
ok 37 AdminUpdateContentDirect (skipped deprecated)
ok 38 AdminDeleteContent
ok 39 AdminGetContent
ok 40 AdminDeleteAllUserContents
ok 41 AdminHideUserContent
ok 42 AdminGetAllGroups
ok 43 AdminDeleteAllUserGroup
ok 44 AdminGetGroup
ok 45 AdminUpdateGroup
ok 46 AdminDeleteGroup
ok 47 AdminGetGroupContents
ok 48 AdminDeleteAllUserStates
ok 49 SearchChannelSpecificContent
ok 50 PublicSearchContent
ok 51 GetFollowedContent
ok 52 GetLikedContent
ok 53 DownloadContentByShareCode
ok 54 PublicDownloadContentByContentID
ok 55 AddDownloadCount
ok 56 UpdateContentLikeStatus
ok 57 PublicDownloadContentPreview
ok 58 GetTag
ok 59 GetType
ok 60 GetFollowedUsers
ok 61 GetChannels
ok 62 CreateChannel
ok 63 DeleteAllUserChannel
ok 64 UpdateChannel
ok 65 DeleteChannel
ok 66 CreateContentDirect (skipped deprecated)
ok 67 CreateContentS3
ok 68 UpdateContentS3
ok 69 UpdateContentDirect (skipped deprecated)
ok 70 DeleteContent
ok 71 PublicGetUserContent
ok 72 DeleteAllUserContents
ok 73 UpdateScreenshots
ok 74 UploadContentScreenshot
ok 75 DeleteContentScreenshot
ok 76 UpdateUserFollowStatus
ok 77 GetGroups
ok 78 CreateGroup
ok 79 DeleteAllUserGroup
ok 80 GetGroup
ok 81 UpdateGroup
ok 82 DeleteGroup
ok 83 GetGroupContent
ok 84 DeleteAllUserStates
```

```tap
run-cli-dsmc-unit-test.sh

TAP version 13
1..63
ok 1 ListConfig
ok 2 SaveConfig (skipped deprecated)
ok 3 UpdateImage
ok 4 CreateImage
ok 5 ImportImages
ok 6 GetConfig
ok 7 CreateConfig
ok 8 DeleteConfig
ok 9 UpdateConfig
ok 10 ClearCache
ok 11 GetAllDeployment
ok 12 GetDeployment
ok 13 CreateDeployment
ok 14 DeleteDeployment
ok 15 UpdateDeployment
ok 16 CreateRootRegionOverride
ok 17 DeleteRootRegionOverride
ok 18 UpdateRootRegionOverride
ok 19 CreateDeploymentOverride
ok 20 DeleteDeploymentOverride
ok 21 UpdateDeploymentOverride
ok 22 CreateOverrideRegionOverride
ok 23 DeleteOverrideRegionOverride
ok 24 UpdateOverrideRegionOverride
ok 25 GetAllPodConfig
ok 26 GetPodConfig
ok 27 CreatePodConfig
ok 28 DeletePodConfig
ok 29 UpdatePodConfig
ok 30 AddPort
ok 31 DeletePort
ok 32 UpdatePort
ok 33 ListImages
ok 34 DeleteImage
ok 35 ExportImages
ok 36 GetImageLimit
ok 37 GetImageDetail
ok 38 ListServer
ok 39 CountServer
ok 40 CountServerDetailed
ok 41 ListLocalServer
ok 42 DeleteLocalServer
ok 43 GetServer
ok 44 DeleteServer
ok 45 GetServerLogs
ok 46 ListSession
ok 47 CountSession
ok 48 DeleteSession
ok 49 ExportConfigV1
ok 50 ImportConfigV1
ok 51 ImageDetailClient
ok 52 DeregisterLocalServer
ok 53 RegisterLocalServer
ok 54 RegisterServer
ok 55 ShutdownServer
ok 56 GetServerSession
ok 57 CreateSession
ok 58 ClaimServer
ok 59 GetSession
ok 60 GetDefaultProvider
ok 61 ListProviders
ok 62 ListProvidersByRegion
ok 63 PublicGetMessages
```

```tap
run-cli-achievement-unit-test.sh

TAP version 13
1..14
ok 1 AdminListAchievements
ok 2 AdminCreateNewAchievement
ok 3 ExportAchievements
ok 4 ImportAchievements
ok 5 AdminGetAchievement
ok 6 AdminUpdateAchievement
ok 7 AdminDeleteAchievement
ok 8 AdminUpdateAchievementListOrder
ok 9 AdminListUserAchievements
ok 10 AdminUnlockAchievement
ok 11 PublicListAchievements
ok 12 PublicGetAchievement
ok 13 PublicListUserAchievements
ok 14 PublicUnlockAchievement
```

```tap
run-cli-gdpr-unit-test.sh

TAP version 13
1..20
ok 1 AdminGetListDeletionDataRequest
ok 2 GetAdminEmailConfiguration
ok 3 UpdateAdminEmailConfiguration
ok 4 SaveAdminEmailConfiguration
ok 5 DeleteAdminEmailConfiguration
ok 6 AdminGetListPersonalDataRequest
ok 7 AdminGetUserAccountDeletionRequest
ok 8 AdminSubmitUserAccountDeletionRequest
ok 9 AdminCancelUserAccountDeletionRequest
ok 10 AdminGetUserPersonalDataRequests
ok 11 AdminRequestDataRetrieval
ok 12 AdminCancelUserPersonalDataRequest
ok 13 AdminGeneratePersonalDataURL
ok 14 PublicSubmitUserAccountDeletionRequest
ok 15 PublicCancelUserAccountDeletionRequest
ok 16 PublicGetUserAccountDeletionStatus
ok 17 PublicGetUserPersonalDataRequests
ok 18 PublicRequestDataRetrieval
ok 19 PublicCancelUserPersonalDataRequest
ok 20 PublicGeneratePersonalDataURL
```

