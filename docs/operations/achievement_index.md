# Achievement Service Index

&nbsp;  

## Operations

### Achievements Wrapper:  [Achievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/Achievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | GET | AdminListAchievements | [AdminListAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminListAchievements.cs) | [AdminListAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminListAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | POST | AdminCreateNewAchievement | [AdminCreateNewAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminCreateNewAchievement.cs) | [AdminCreateNewAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminCreateNewAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/export` | GET | ExportAchievements | [ExportAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/ExportAchievements.cs) | [ExportAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/ExportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/import` | POST | ImportAchievements | [ImportAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/ImportAchievements.cs) | [ImportAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/ImportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | GET | AdminGetAchievement | [AdminGetAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminGetAchievement.cs) | [AdminGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminGetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PUT | AdminUpdateAchievement | [AdminUpdateAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUpdateAchievement.cs) | [AdminUpdateAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | DELETE | AdminDeleteAchievement | [AdminDeleteAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminDeleteAchievement.cs) | [AdminDeleteAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminDeleteAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PATCH | AdminUpdateAchievementListOrder | [AdminUpdateAchievementListOrder](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUpdateAchievementListOrder.cs) | [AdminUpdateAchievementListOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievementListOrder.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements` | GET | PublicListAchievements | [PublicListAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicListAchievements.cs) | [PublicListAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicListAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}` | GET | PublicGetAchievement | [PublicGetAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicGetAchievement.cs) | [PublicGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicGetAchievement.cs) |

### Global Achievements Wrapper:  [GlobalAchievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/GlobalAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements` | GET | AdminListGlobalAchievements | [AdminListGlobalAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListGlobalAchievements.cs) | [AdminListGlobalAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListGlobalAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/contributors` | GET | AdminListGlobalAchievementContributors | [AdminListGlobalAchievementContributors](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListGlobalAchievementContributors.cs) | [AdminListGlobalAchievementContributors](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListGlobalAchievementContributors.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/global/achievements/{achievementCode}/reset` | DELETE | ResetGlobalAchievement | [ResetGlobalAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ResetGlobalAchievement.cs) | [ResetGlobalAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ResetGlobalAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/global/achievements` | GET | AdminListUserContributions | [AdminListUserContributions](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/AdminListUserContributions.cs) | [AdminListUserContributions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/AdminListUserContributions.cs) |
| `/achievement/v1/public/namespaces/{namespace}/global/achievements` | GET | PublicListGlobalAchievements | [PublicListGlobalAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/PublicListGlobalAchievements.cs) | [PublicListGlobalAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/PublicListGlobalAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/global/achievements/{achievementCode}/contributors` | GET | ListGlobalAchievementContributors | [ListGlobalAchievementContributors](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ListGlobalAchievementContributors.cs) | [ListGlobalAchievementContributors](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ListGlobalAchievementContributors.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements` | GET | ListUserContributions | [ListUserContributions](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ListUserContributions.cs) | [ListUserContributions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ListUserContributions.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements/{achievementCode}/claim` | POST | ClaimGlobalAchievementReward | [ClaimGlobalAchievementReward](../../AccelByte.Sdk/Api/Achievement/Operation/GlobalAchievements/ClaimGlobalAchievementReward.cs) | [ClaimGlobalAchievementReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/GlobalAchievements/ClaimGlobalAchievementReward.cs) |

### Tags Wrapper:  [Tags](../../AccelByte.Sdk/Api/Achievement/Wrapper/Tags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/tags` | GET | AdminListTags | [AdminListTags](../../AccelByte.Sdk/Api/Achievement/Operation/Tags/AdminListTags.cs) | [AdminListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Tags/AdminListTags.cs) |
| `/achievement/v1/public/namespaces/{namespace}/tags` | GET | PublicListTags | [PublicListTags](../../AccelByte.Sdk/Api/Achievement/Operation/Tags/PublicListTags.cs) | [PublicListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Tags/PublicListTags.cs) |

### User Achievements Wrapper:  [UserAchievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/UserAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements` | GET | AdminListUserAchievements | [AdminListUserAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/AdminListUserAchievements.cs) | [AdminListUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminListUserAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/reset` | DELETE | AdminResetAchievement | [AdminResetAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/AdminResetAchievement.cs) | [AdminResetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminResetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | AdminUnlockAchievement | [AdminUnlockAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/AdminUnlockAchievement.cs) | [AdminUnlockAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/AdminUnlockAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements` | GET | PublicListUserAchievements | [PublicListUserAchievements](../../AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/PublicListUserAchievements.cs) | [PublicListUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/PublicListUserAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | PublicUnlockAchievement | [PublicUnlockAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/UserAchievements/PublicUnlockAchievement.cs) | [PublicUnlockAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/UserAchievements/PublicUnlockAchievement.cs) |

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Achievement/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/achievements` | DELETE | AdminAnonymizeUserAchievement | [AdminAnonymizeUserAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Anonymization/AdminAnonymizeUserAchievement.cs) | [AdminAnonymizeUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Anonymization/AdminAnonymizeUserAchievement.cs) |


&nbsp;  

## Operations with Generic Response

### Achievements Wrapper:  [Achievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/Achievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | POST | AdminCreateNewAchievement | [AdminCreateNewAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminCreateNewAchievement.cs) | [AdminCreateNewAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminCreateNewAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | GET | AdminGetAchievement | [AdminGetAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminGetAchievement.cs) | [AdminGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminGetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PUT | AdminUpdateAchievement | [AdminUpdateAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUpdateAchievement.cs) | [AdminUpdateAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/AdminUpdateAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}` | GET | PublicGetAchievement | [PublicGetAchievement](../../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicGetAchievement.cs) | [PublicGetAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Achievement/Achievements/PublicGetAchievement.cs) |

### Global Achievements Wrapper:  [GlobalAchievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/GlobalAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Tags Wrapper:  [Tags](../../AccelByte.Sdk/Api/Achievement/Wrapper/Tags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### User Achievements Wrapper:  [UserAchievements](../../AccelByte.Sdk/Api/Achievement/Wrapper/UserAchievements.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Achievement/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AchievementOrderUpdateRequest` | [ModelsAchievementOrderUpdateRequest](../../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementOrderUpdateRequest.cs) |
| `models.AchievementRequest` | [ModelsAchievementRequest](../../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementRequest.cs) |
| `models.AchievementResponse` | [ModelsAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementResponse.cs) |
| `models.AchievementUpdateRequest` | [ModelsAchievementUpdateRequest](../../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementUpdateRequest.cs) |
| `models.AdditionalInfo` | [ModelsAdditionalInfo](../../AccelByte.Sdk/Api/Achievement/Model/ModelsAdditionalInfo.cs) |
| `models.ContributorResponse` | [ModelsContributorResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsContributorResponse.cs) |
| `models.GlobalAchievementResponse` | [ModelsGlobalAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsGlobalAchievementResponse.cs) |
| `models.Icon` | [ModelsIcon](../../AccelByte.Sdk/Api/Achievement/Model/ModelsIcon.cs) |
| `models.PaginatedAchievementResponse` | [ModelsPaginatedAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedAchievementResponse.cs) |
| `models.PaginatedContributorResponse` | [ModelsPaginatedContributorResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedContributorResponse.cs) |
| `models.PaginatedGlobalAchievementResponse` | [ModelsPaginatedGlobalAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedGlobalAchievementResponse.cs) |
| `models.PaginatedTagResponse` | [ModelsPaginatedTagResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedTagResponse.cs) |
| `models.PaginatedUserAchievementResponse` | [ModelsPaginatedUserAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedUserAchievementResponse.cs) |
| `models.PaginatedUserContributionResponse` | [ModelsPaginatedUserContributionResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedUserContributionResponse.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPagination.cs) |
| `models.PublicAchievementResponse` | [ModelsPublicAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPublicAchievementResponse.cs) |
| `models.PublicAchievementsResponse` | [ModelsPublicAchievementsResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsPublicAchievementsResponse.cs) |
| `models.TagResponse` | [ModelsTagResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsTagResponse.cs) |
| `models.UserAchievementResponse` | [ModelsUserAchievementResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsUserAchievementResponse.cs) |
| `models.UserContributionResponse` | [ModelsUserContributionResponse](../../AccelByte.Sdk/Api/Achievement/Model/ModelsUserContributionResponse.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Achievement/Model/ResponseError.cs) |
| `service.ImportConfigResponse` | [ServiceImportConfigResponse](../../AccelByte.Sdk/Api/Achievement/Model/ServiceImportConfigResponse.cs) |
