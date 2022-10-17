# Seasonpass Service Index

&nbsp;  

## Operations

### Season Wrapper:  [Season](../../AccelByte.Sdk/Api/Seasonpass/Wrapper/Season.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons` | GET | QuerySeasons | [QuerySeasons](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/QuerySeasons.cs) | [QuerySeasons](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QuerySeasons.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons` | POST | CreateSeason | [CreateSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/CreateSeason.cs) | [CreateSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CreateSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/current` | GET | GetCurrentSeason | [GetCurrentSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetCurrentSeason.cs) | [GetCurrentSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetCurrentSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/current/users/bulk/progression` | POST | BulkGetUserSeasonProgression | [BulkGetUserSeasonProgression](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/BulkGetUserSeasonProgression.cs) | [BulkGetUserSeasonProgression](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/BulkGetUserSeasonProgression.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | GET | GetSeason | [GetSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetSeason.cs) | [GetSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | DELETE | DeleteSeason | [DeleteSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/DeleteSeason.cs) | [DeleteSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/DeleteSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}` | PATCH | UpdateSeason | [UpdateSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/UpdateSeason.cs) | [UpdateSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/UpdateSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/clone` | POST | CloneSeason | [CloneSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/CloneSeason.cs) | [CloneSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CloneSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/full` | GET | GetFullSeason | [GetFullSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetFullSeason.cs) | [GetFullSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetFullSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/publish` | PUT | PublishSeason | [PublishSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/PublishSeason.cs) | [PublishSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublishSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire` | PUT | RetireSeason | [RetireSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/RetireSeason.cs) | [RetireSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/RetireSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/unpublish` | PUT | UnpublishSeason | [UnpublishSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/UnpublishSeason.cs) | [UnpublishSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/UnpublishSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons` | GET | GetUserParticipatedSeasons | [GetUserParticipatedSeasons](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetUserParticipatedSeasons.cs) | [GetUserParticipatedSeasons](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetUserParticipatedSeasons.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes/ownership/any` | GET | ExistsAnyPassByPassCodes | [ExistsAnyPassByPassCodes](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/ExistsAnyPassByPassCodes.cs) | [ExistsAnyPassByPassCodes](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/ExistsAnyPassByPassCodes.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/progression` | GET | GetCurrentUserSeasonProgression | [GetCurrentUserSeasonProgression](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetCurrentUserSeasonProgression.cs) | [GetCurrentUserSeasonProgression](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetCurrentUserSeasonProgression.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/purchasable` | POST | CheckSeasonPurchasable | [CheckSeasonPurchasable](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/CheckSeasonPurchasable.cs) | [CheckSeasonPurchasable](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/CheckSeasonPurchasable.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/reset` | DELETE | ResetUserSeason | [ResetUserSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/ResetUserSeason.cs) | [ResetUserSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/ResetUserSeason.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history` | GET | QueryUserExpGrantHistory | [QueryUserExpGrantHistory](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/QueryUserExpGrantHistory.cs) | [QueryUserExpGrantHistory](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QueryUserExpGrantHistory.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/exp/history/tags` | GET | QueryUserExpGrantHistoryTag | [QueryUserExpGrantHistoryTag](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/QueryUserExpGrantHistoryTag.cs) | [QueryUserExpGrantHistoryTag](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/QueryUserExpGrantHistoryTag.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | GetUserSeason | [GetUserSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/GetUserSeason.cs) | [GetUserSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/GetUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/seasons/current` | GET | PublicGetCurrentSeason | [PublicGetCurrentSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/PublicGetCurrentSeason.cs) | [PublicGetCurrentSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetCurrentSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data` | GET | PublicGetCurrentUserSeason | [PublicGetCurrentUserSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/PublicGetCurrentUserSeason.cs) | [PublicGetCurrentUserSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetCurrentUserSeason.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data` | GET | PublicGetUserSeason | [PublicGetUserSeason](../../AccelByte.Sdk/Api/Seasonpass/Operation/Season/PublicGetUserSeason.cs) | [PublicGetUserSeason](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Season/PublicGetUserSeason.cs) |

### Pass Wrapper:  [Pass](../../AccelByte.Sdk/Api/Seasonpass/Wrapper/Pass.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes` | GET | QueryPasses | [QueryPasses](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/QueryPasses.cs) | [QueryPasses](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/QueryPasses.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes` | POST | CreatePass | [CreatePass](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/CreatePass.cs) | [CreatePass](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/CreatePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | GET | GetPass | [GetPass](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/GetPass.cs) | [GetPass](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/GetPass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | DELETE | DeletePass | [DeletePass](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/DeletePass.cs) | [DeletePass](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/DeletePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code}` | PATCH | UpdatePass | [UpdatePass](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/UpdatePass.cs) | [UpdatePass](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/UpdatePass.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes` | POST | GrantUserPass | [GrantUserPass](../../AccelByte.Sdk/Api/Seasonpass/Operation/Pass/GrantUserPass.cs) | [GrantUserPass](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Pass/GrantUserPass.cs) |

### Reward Wrapper:  [Reward](../../AccelByte.Sdk/Api/Seasonpass/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards` | GET | QueryRewards | [QueryRewards](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/QueryRewards.cs) | [QueryRewards](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/QueryRewards.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards` | POST | CreateReward | [CreateReward](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/CreateReward.cs) | [CreateReward](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/CreateReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | GET | GetReward | [GetReward](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/GetReward.cs) | [GetReward](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/GetReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | DELETE | DeleteReward | [DeleteReward](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/DeleteReward.cs) | [DeleteReward](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/DeleteReward.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}` | PATCH | UpdateReward | [UpdateReward](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/UpdateReward.cs) | [UpdateReward](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/UpdateReward.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards` | POST | PublicClaimUserReward | [PublicClaimUserReward](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/PublicClaimUserReward.cs) | [PublicClaimUserReward](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicClaimUserReward.cs) |
| `/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards/bulk` | POST | PublicBulkClaimUserRewards | [PublicBulkClaimUserRewards](../../AccelByte.Sdk/Api/Seasonpass/Operation/Reward/PublicBulkClaimUserRewards.cs) | [PublicBulkClaimUserRewards](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Reward/PublicBulkClaimUserRewards.cs) |

### Tier Wrapper:  [Tier](../../AccelByte.Sdk/Api/Seasonpass/Wrapper/Tier.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers` | GET | QueryTiers | [QueryTiers](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/QueryTiers.cs) | [QueryTiers](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/QueryTiers.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers` | POST | CreateTier | [CreateTier](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/CreateTier.cs) | [CreateTier](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/CreateTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}` | PUT | UpdateTier | [UpdateTier](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/UpdateTier.cs) | [UpdateTier](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/UpdateTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}` | DELETE | DeleteTier | [DeleteTier](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/DeleteTier.cs) | [DeleteTier](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/DeleteTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}/reorder` | PUT | ReorderTier | [ReorderTier](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/ReorderTier.cs) | [ReorderTier](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/ReorderTier.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/exp` | POST | GrantUserExp | [GrantUserExp](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/GrantUserExp.cs) | [GrantUserExp](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/GrantUserExp.cs) |
| `/seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/tiers` | POST | GrantUserTier | [GrantUserTier](../../AccelByte.Sdk/Api/Seasonpass/Operation/Tier/GrantUserTier.cs) | [GrantUserTier](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Seasonpass/Tier/GrantUserTier.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `BulkUserProgressionRequest` | [BulkUserProgressionRequest](../../AccelByte.Sdk/Api/Seasonpass/Model/BulkUserProgressionRequest.cs) |
| `ClaimableRewards` | [ClaimableRewards](../../AccelByte.Sdk/Api/Seasonpass/Model/ClaimableRewards.cs) |
| `ClaimableUserSeasonInfo` | [ClaimableUserSeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/ClaimableUserSeasonInfo.cs) |
| `ErrorEntity` | [ErrorEntity](../../AccelByte.Sdk/Api/Seasonpass/Model/ErrorEntity.cs) |
| `ExcessStrategy` | [ExcessStrategy](../../AccelByte.Sdk/Api/Seasonpass/Model/ExcessStrategy.cs) |
| `ExpGrantHistoryInfo` | [ExpGrantHistoryInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/ExpGrantHistoryInfo.cs) |
| `ExpGrantHistoryPagingSlicedResult` | [ExpGrantHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Seasonpass/Model/ExpGrantHistoryPagingSlicedResult.cs) |
| `FieldValidationError` | [FieldValidationError](../../AccelByte.Sdk/Api/Seasonpass/Model/FieldValidationError.cs) |
| `FullSeasonInfo` | [FullSeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/FullSeasonInfo.cs) |
| `Image` | [Image](../../AccelByte.Sdk/Api/Seasonpass/Model/Image.cs) |
| `ListSeasonInfo` | [ListSeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/ListSeasonInfo.cs) |
| `ListSeasonInfoPagingSlicedResult` | [ListSeasonInfoPagingSlicedResult](../../AccelByte.Sdk/Api/Seasonpass/Model/ListSeasonInfoPagingSlicedResult.cs) |
| `ListUserSeasonInfo` | [ListUserSeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/ListUserSeasonInfo.cs) |
| `ListUserSeasonInfoPagingSlicedResult` | [ListUserSeasonInfoPagingSlicedResult](../../AccelByte.Sdk/Api/Seasonpass/Model/ListUserSeasonInfoPagingSlicedResult.cs) |
| `Localization` | [Localization](../../AccelByte.Sdk/Api/Seasonpass/Model/Localization.cs) |
| `LocalizedPassInfo` | [LocalizedPassInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/LocalizedPassInfo.cs) |
| `LocalizedSeasonInfo` | [LocalizedSeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/LocalizedSeasonInfo.cs) |
| `Ownership` | [Ownership](../../AccelByte.Sdk/Api/Seasonpass/Model/Ownership.cs) |
| `Paging` | [Paging](../../AccelByte.Sdk/Api/Seasonpass/Model/Paging.cs) |
| `PassCreate` | [PassCreate](../../AccelByte.Sdk/Api/Seasonpass/Model/PassCreate.cs) |
| `PassInfo` | [PassInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/PassInfo.cs) |
| `PassUpdate` | [PassUpdate](../../AccelByte.Sdk/Api/Seasonpass/Model/PassUpdate.cs) |
| `ReasonTagsResult` | [ReasonTagsResult](../../AccelByte.Sdk/Api/Seasonpass/Model/ReasonTagsResult.cs) |
| `RewardCreate` | [RewardCreate](../../AccelByte.Sdk/Api/Seasonpass/Model/RewardCreate.cs) |
| `RewardCurrency` | [RewardCurrency](../../AccelByte.Sdk/Api/Seasonpass/Model/RewardCurrency.cs) |
| `RewardInfo` | [RewardInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/RewardInfo.cs) |
| `RewardUpdate` | [RewardUpdate](../../AccelByte.Sdk/Api/Seasonpass/Model/RewardUpdate.cs) |
| `SeasonCloneRequest` | [SeasonCloneRequest](../../AccelByte.Sdk/Api/Seasonpass/Model/SeasonCloneRequest.cs) |
| `SeasonCreate` | [SeasonCreate](../../AccelByte.Sdk/Api/Seasonpass/Model/SeasonCreate.cs) |
| `SeasonInfo` | [SeasonInfo](../../AccelByte.Sdk/Api/Seasonpass/Model/SeasonInfo.cs) |
| `SeasonSummary` | [SeasonSummary](../../AccelByte.Sdk/Api/Seasonpass/Model/SeasonSummary.cs) |
| `SeasonUpdate` | [SeasonUpdate](../../AccelByte.Sdk/Api/Seasonpass/Model/SeasonUpdate.cs) |
| `Tier` | [Tier](../../AccelByte.Sdk/Api/Seasonpass/Model/Tier.cs) |
| `TierCreate` | [TierCreate](../../AccelByte.Sdk/Api/Seasonpass/Model/TierCreate.cs) |
| `TierInput` | [TierInput](../../AccelByte.Sdk/Api/Seasonpass/Model/TierInput.cs) |
| `TierPagingSlicedResult` | [TierPagingSlicedResult](../../AccelByte.Sdk/Api/Seasonpass/Model/TierPagingSlicedResult.cs) |
| `TierReorder` | [TierReorder](../../AccelByte.Sdk/Api/Seasonpass/Model/TierReorder.cs) |
| `UserExpGrant` | [UserExpGrant](../../AccelByte.Sdk/Api/Seasonpass/Model/UserExpGrant.cs) |
| `UserPassGrant` | [UserPassGrant](../../AccelByte.Sdk/Api/Seasonpass/Model/UserPassGrant.cs) |
| `UserPurchasable` | [UserPurchasable](../../AccelByte.Sdk/Api/Seasonpass/Model/UserPurchasable.cs) |
| `UserRewardClaim` | [UserRewardClaim](../../AccelByte.Sdk/Api/Seasonpass/Model/UserRewardClaim.cs) |
| `UserSeasonSummary` | [UserSeasonSummary](../../AccelByte.Sdk/Api/Seasonpass/Model/UserSeasonSummary.cs) |
| `UserTierGrant` | [UserTierGrant](../../AccelByte.Sdk/Api/Seasonpass/Model/UserTierGrant.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../AccelByte.Sdk/Api/Seasonpass/Model/ValidationErrorEntity.cs) |
