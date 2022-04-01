# Seasonpass Service Index

&nbsp;  

## Operations

### Season Wrapper:  [Season](../AccelByte.Sdk/Api/Seasonpass/Wrapper/Season.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /seasonpass/admin/namespaces/{namespace}/seasons | GET | QuerySeasons | [QuerySeasons](../AccelByte.Sdk/Api/Seasonpass/Operation//QuerySeasons.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons | POST | CreateSeason | [CreateSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//CreateSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/current | GET | GetCurrentSeason | [GetCurrentSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//GetCurrentSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId} | GET | GetSeason | [GetSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//GetSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId} | DELETE | DeleteSeason | [DeleteSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//DeleteSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId} | PATCH | UpdateSeason | [UpdateSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//UpdateSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/clone | POST | CloneSeason | [CloneSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//CloneSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/publish | PUT | PublishSeason | [PublishSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//PublishSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/retire | PUT | RetireSeason | [RetireSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//RetireSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/unpublish | PUT | UnpublishSeason | [UnpublishSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//UnpublishSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons | GET | GetUserParticipatedSeasons | [GetUserParticipatedSeasons](../AccelByte.Sdk/Api/Seasonpass/Operation//GetUserParticipatedSeasons.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes/ownership/any | GET | ExistsAnyPassByPassCodes | [ExistsAnyPassByPassCodes](../AccelByte.Sdk/Api/Seasonpass/Operation//ExistsAnyPassByPassCodes.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/progression | GET | GetCurrentUserSeasonProgression | [GetCurrentUserSeasonProgression](../AccelByte.Sdk/Api/Seasonpass/Operation//GetCurrentUserSeasonProgression.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/purchasable | POST | CheckSeasonPurchasable | [CheckSeasonPurchasable](../AccelByte.Sdk/Api/Seasonpass/Operation//CheckSeasonPurchasable.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/reset | DELETE | ResetUserSeason | [ResetUserSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//ResetUserSeason.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data | GET | GetUserSeason | [GetUserSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//GetUserSeason.cs) |
| /seasonpass/public/namespaces/{namespace}/seasons/current | GET | PublicGetCurrentSeason | [PublicGetCurrentSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//PublicGetCurrentSeason.cs) |
| /seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/data | GET | PublicGetCurrentUserSeason | [PublicGetCurrentUserSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//PublicGetCurrentUserSeason.cs) |
| /seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/{seasonId}/data | GET | PublicGetUserSeason | [PublicGetUserSeason](../AccelByte.Sdk/Api/Seasonpass/Operation//PublicGetUserSeason.cs) |

### Pass Wrapper:  [Pass](../AccelByte.Sdk/Api/Seasonpass/Wrapper/Pass.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes | GET | QueryPasses | [QueryPasses](../AccelByte.Sdk/Api/Seasonpass/Operation//QueryPasses.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes | POST | CreatePass | [CreatePass](../AccelByte.Sdk/Api/Seasonpass/Operation//CreatePass.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code} | GET | GetPass | [GetPass](../AccelByte.Sdk/Api/Seasonpass/Operation//GetPass.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code} | DELETE | DeletePass | [DeletePass](../AccelByte.Sdk/Api/Seasonpass/Operation//DeletePass.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes/{code} | PATCH | UpdatePass | [UpdatePass](../AccelByte.Sdk/Api/Seasonpass/Operation//UpdatePass.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/passes | POST | GrantUserPass | [GrantUserPass](../AccelByte.Sdk/Api/Seasonpass/Operation//GrantUserPass.cs) |

### Reward Wrapper:  [Reward](../AccelByte.Sdk/Api/Seasonpass/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards | GET | QueryRewards | [QueryRewards](../AccelByte.Sdk/Api/Seasonpass/Operation//QueryRewards.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards | POST | CreateReward | [CreateReward](../AccelByte.Sdk/Api/Seasonpass/Operation//CreateReward.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code} | GET | GetReward | [GetReward](../AccelByte.Sdk/Api/Seasonpass/Operation//GetReward.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code} | DELETE | DeleteReward | [DeleteReward](../AccelByte.Sdk/Api/Seasonpass/Operation//DeleteReward.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code} | PATCH | UpdateReward | [UpdateReward](../AccelByte.Sdk/Api/Seasonpass/Operation//UpdateReward.cs) |
| /seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards | POST | PublicClaimUserReward | [PublicClaimUserReward](../AccelByte.Sdk/Api/Seasonpass/Operation//PublicClaimUserReward.cs) |
| /seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards/bulk | POST | PublicBulkClaimUserRewards | [PublicBulkClaimUserRewards](../AccelByte.Sdk/Api/Seasonpass/Operation//PublicBulkClaimUserRewards.cs) |

### Tier Wrapper:  [Tier](../AccelByte.Sdk/Api/Seasonpass/Wrapper/Tier.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers | GET | QueryTiers | [QueryTiers](../AccelByte.Sdk/Api/Seasonpass/Operation//QueryTiers.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers | POST | CreateTier | [CreateTier](../AccelByte.Sdk/Api/Seasonpass/Operation//CreateTier.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id} | PUT | UpdateTier | [UpdateTier](../AccelByte.Sdk/Api/Seasonpass/Operation//UpdateTier.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id} | DELETE | DeleteTier | [DeleteTier](../AccelByte.Sdk/Api/Seasonpass/Operation//DeleteTier.cs) |
| /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/tiers/{id}/reorder | PUT | ReorderTier | [ReorderTier](../AccelByte.Sdk/Api/Seasonpass/Operation//ReorderTier.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/exp | POST | GrantUserExp | [GrantUserExp](../AccelByte.Sdk/Api/Seasonpass/Operation//GrantUserExp.cs) |
| /seasonpass/admin/namespaces/{namespace}/users/{userId}/seasons/current/tiers | POST | GrantUserTier | [GrantUserTier](../AccelByte.Sdk/Api/Seasonpass/Operation//GrantUserTier.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| ClaimableRewards | [ClaimableRewards](../AccelByte.Sdk/Api/Seasonpass/Model/ClaimableRewards.cs) |
| ClaimableUserSeasonInfo | [ClaimableUserSeasonInfo](../AccelByte.Sdk/Api/Seasonpass/Model/ClaimableUserSeasonInfo.cs) |
| ErrorEntity | [ErrorEntity](../AccelByte.Sdk/Api/Seasonpass/Model/ErrorEntity.cs) |
| ExcessStrategy | [ExcessStrategy](../AccelByte.Sdk/Api/Seasonpass/Model/ExcessStrategy.cs) |
| FieldValidationError | [FieldValidationError](../AccelByte.Sdk/Api/Seasonpass/Model/FieldValidationError.cs) |
| Image | [Image](../AccelByte.Sdk/Api/Seasonpass/Model/Image.cs) |
| ListSeasonInfo | [ListSeasonInfo](../AccelByte.Sdk/Api/Seasonpass/Model/ListSeasonInfo.cs) |
| ListSeasonInfoPagingSlicedResult | [ListSeasonInfoPagingSlicedResult](../AccelByte.Sdk/Api/Seasonpass/Model/ListSeasonInfoPagingSlicedResult.cs) |
| ListUserSeasonInfo | [ListUserSeasonInfo](../AccelByte.Sdk/Api/Seasonpass/Model/ListUserSeasonInfo.cs) |
| ListUserSeasonInfoPagingSlicedResult | [ListUserSeasonInfoPagingSlicedResult](../AccelByte.Sdk/Api/Seasonpass/Model/ListUserSeasonInfoPagingSlicedResult.cs) |
| Localization | [Localization](../AccelByte.Sdk/Api/Seasonpass/Model/Localization.cs) |
| LocalizedPassInfo | [LocalizedPassInfo](../AccelByte.Sdk/Api/Seasonpass/Model/LocalizedPassInfo.cs) |
| LocalizedSeasonInfo | [LocalizedSeasonInfo](../AccelByte.Sdk/Api/Seasonpass/Model/LocalizedSeasonInfo.cs) |
| Ownership | [Ownership](../AccelByte.Sdk/Api/Seasonpass/Model/Ownership.cs) |
| Paging | [Paging](../AccelByte.Sdk/Api/Seasonpass/Model/Paging.cs) |
| PassCreate | [PassCreate](../AccelByte.Sdk/Api/Seasonpass/Model/PassCreate.cs) |
| PassInfo | [PassInfo](../AccelByte.Sdk/Api/Seasonpass/Model/PassInfo.cs) |
| PassUpdate | [PassUpdate](../AccelByte.Sdk/Api/Seasonpass/Model/PassUpdate.cs) |
| RewardCreate | [RewardCreate](../AccelByte.Sdk/Api/Seasonpass/Model/RewardCreate.cs) |
| RewardCurrency | [RewardCurrency](../AccelByte.Sdk/Api/Seasonpass/Model/RewardCurrency.cs) |
| RewardInfo | [RewardInfo](../AccelByte.Sdk/Api/Seasonpass/Model/RewardInfo.cs) |
| RewardUpdate | [RewardUpdate](../AccelByte.Sdk/Api/Seasonpass/Model/RewardUpdate.cs) |
| SeasonCloneRequest | [SeasonCloneRequest](../AccelByte.Sdk/Api/Seasonpass/Model/SeasonCloneRequest.cs) |
| SeasonCreate | [SeasonCreate](../AccelByte.Sdk/Api/Seasonpass/Model/SeasonCreate.cs) |
| SeasonInfo | [SeasonInfo](../AccelByte.Sdk/Api/Seasonpass/Model/SeasonInfo.cs) |
| SeasonSummary | [SeasonSummary](../AccelByte.Sdk/Api/Seasonpass/Model/SeasonSummary.cs) |
| SeasonUpdate | [SeasonUpdate](../AccelByte.Sdk/Api/Seasonpass/Model/SeasonUpdate.cs) |
| Tier | [Tier](../AccelByte.Sdk/Api/Seasonpass/Model/Tier.cs) |
| TierCreate | [TierCreate](../AccelByte.Sdk/Api/Seasonpass/Model/TierCreate.cs) |
| TierInput | [TierInput](../AccelByte.Sdk/Api/Seasonpass/Model/TierInput.cs) |
| TierPagingSlicedResult | [TierPagingSlicedResult](../AccelByte.Sdk/Api/Seasonpass/Model/TierPagingSlicedResult.cs) |
| TierReorder | [TierReorder](../AccelByte.Sdk/Api/Seasonpass/Model/TierReorder.cs) |
| UserExpGrant | [UserExpGrant](../AccelByte.Sdk/Api/Seasonpass/Model/UserExpGrant.cs) |
| UserPassGrant | [UserPassGrant](../AccelByte.Sdk/Api/Seasonpass/Model/UserPassGrant.cs) |
| UserPurchasable | [UserPurchasable](../AccelByte.Sdk/Api/Seasonpass/Model/UserPurchasable.cs) |
| UserRewardClaim | [UserRewardClaim](../AccelByte.Sdk/Api/Seasonpass/Model/UserRewardClaim.cs) |
| UserSeasonSummary | [UserSeasonSummary](../AccelByte.Sdk/Api/Seasonpass/Model/UserSeasonSummary.cs) |
| UserTierGrant | [UserTierGrant](../AccelByte.Sdk/Api/Seasonpass/Model/UserTierGrant.cs) |
| ValidationErrorEntity | [ValidationErrorEntity](../AccelByte.Sdk/Api/Seasonpass/Model/ValidationErrorEntity.cs) |
