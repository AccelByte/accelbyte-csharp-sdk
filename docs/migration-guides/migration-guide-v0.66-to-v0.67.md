<a name="v0.67.0"></a>
## [v0.67.0] - 2024-11-21

### BREAKING CHANGE

### Achievement

- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListGlobalAchievementContributors`
    - `SortBy` param type changed from `string?` to `AdminListGlobalAchievementContributorsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListGlobalAchievements`
    - `SortBy` param type changed from `string?` to `AdminListGlobalAchievementsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListUserContributions`
    - `SortBy` param type changed from `string?` to `AdminListUserContributionsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ListGlobalAchievementContributors`
    - `SortBy` param type changed from `string?` to `ListGlobalAchievementContributorsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ListUserContributions`
    - `SortBy` param type changed from `string?` to `ListUserContributionsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/PublicListGlobalAchievements`
    - `SortBy` param type changed from `string?` to `PublicListGlobalAchievementsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/Tags/AdminListTags`
    - `SortBy` param type changed from `string?` to `AdminListTagsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/Tags/PublicListTags`
    - `SortBy` param type changed from `string?` to `PublicListTagsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/AdminListUserAchievements`
    - `SortBy` param type changed from `string?` to `AdminListUserAchievementsSortBy?`.
- Operation `AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/PublicListUserAchievements`
    - `SortBy` param type changed from `string?` to `PublicListUserAchievementsSortBy?`.

### AMS

- Model `AccelByte.Sdk.Api.Ams.Model.ApiFleetArtifactsSampleRules`
    - field `Coredumps ` type changed from `ApiArtifactTypeSamplingRules` to `ApiCoredumpSamplingRules`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiAvailableInstanceType`
    - Renamed to `ApiInstanceTypeForNamespaceResponse`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiAvailableInstanceTypesResponse`
    - Renamed to `ApiInstanceTypesForNamespaceResponse`.

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Ams/Operation/AMSInfo/InfoSupportedInstances`
    - response type changed from `ApiAvailableInstanceTypesResponse?` to `ApiInstanceTypesForNamespaceResponse?`.
- Operation `AccelByte.Sdk/Api/Ams/Operation/AMSInfo/AdminAccountLinkTokenPost`
    - Renamed to `AdminAccountLink`.

### Group

- Model `AccelByte.Sdk.Api.Group.Model.ModelsRule`
    - field `AllowedAction` type changed from `string?` to `ModelsRuleAllowedAction?`.
- Model `AccelByte.Sdk.Api.Group.Model.ModelsRuleResponseV1`
    - field `AllowedAction` type changed from `string?` to `ModelsRuleResponseV1AllowedAction?`.

### Session

- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsPutPlatformCredentialsRequest`
    - field `Psn` type changed from `ModelsPSNAppServerCredentials?` to `ApimodelsPSNAppServerCredentialRecord?`.

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Session/Operation/Certificate/HandleUploadXboxPFXCertificate`
    - Renamed to `AdminUploadXBoxCertificate`.
    - It is marked as deprecated.

### Social

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatConfiguration/CreateStat`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatConfiguration/CreateStat1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatConfiguration/UpdateStat`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatCycleConfiguration/BulkAddStats`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatCycleConfiguration/BulkGetStatCycle`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatCycleConfiguration/BulkGetStatCycle1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatCycleConfiguration/CreateStatCycle`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/StatCycleConfiguration/UpdateStatCycle`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/UpdateStatCycle`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkCreateUserStatItems`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkGetOrDefaultByUserId`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkIncUserStatItem`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkIncUserStatItem1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkIncUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkIncUserStatItemValue1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkIncUserStatItemValue2`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkResetUserStatItem`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkResetUserStatItem1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkResetUserStatItem2`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkResetUserStatItem3`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkResetUserStatItemValues`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkUpdateUserStatItem`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkUpdateUserStatItem1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkUpdateUserStatItem2`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/BulkUpdateUserStatItemV2`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/IncUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicBulkCreateUserStatItems`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicBulkIncUserStatItem`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicBulkIncUserStatItem1`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicBulkIncUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicIncUserStatItem`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicIncUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/ResetUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/UpdateUserStatItemValue`
    - Body is now required.
- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/UpdateUserStatItemValue1`
    - Body is now required.

[v0.67.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.66.0...v0.67.0