# Achievement Service Index

&nbsp;  

## Operations

### achievements Wrapper:  [Achievements](../AccelByte.Sdk/Api/Achievement/Wrapper/Achievements.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | GET | AdminListAchievements | [AdminListAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminListAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements` | POST | AdminCreateNewAchievement | [AdminCreateNewAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminCreateNewAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/export` | GET | ExportAchievements | [ExportAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/ExportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/import` | POST | ImportAchievements | [ImportAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/ImportAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | GET | AdminGetAchievement | [AdminGetAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminGetAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PUT | AdminUpdateAchievement | [AdminUpdateAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUpdateAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | DELETE | AdminDeleteAchievement | [AdminDeleteAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminDeleteAchievement.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode}` | PATCH | AdminUpdateAchievementListOrder | [AdminUpdateAchievementListOrder](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUpdateAchievementListOrder.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements` | GET | AdminListUserAchievements | [AdminListUserAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminListUserAchievements.cs) |
| `/achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | AdminUnlockAchievement | [AdminUnlockAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/AdminUnlockAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements` | GET | PublicListAchievements | [PublicListAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicListAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode}` | GET | PublicGetAchievement | [PublicGetAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicGetAchievement.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements` | GET | PublicListUserAchievements | [PublicListUserAchievements](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicListUserAchievements.cs) |
| `/achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/unlock` | PUT | PublicUnlockAchievement | [PublicUnlockAchievement](../AccelByte.Sdk/Api/Achievement/Operation/Achievements/PublicUnlockAchievement.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.Achievement` | [ModelsAchievement](../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievement.cs) |
| `models.AchievementOrderUpdateRequest` | [ModelsAchievementOrderUpdateRequest](../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementOrderUpdateRequest.cs) |
| `models.AchievementRequest` | [ModelsAchievementRequest](../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementRequest.cs) |
| `models.AchievementResponse` | [ModelsAchievementResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementResponse.cs) |
| `models.AchievementUpdateRequest` | [ModelsAchievementUpdateRequest](../AccelByte.Sdk/Api/Achievement/Model/ModelsAchievementUpdateRequest.cs) |
| `models.AdditionalInfo` | [ModelsAdditionalInfo](../AccelByte.Sdk/Api/Achievement/Model/ModelsAdditionalInfo.cs) |
| `models.Icon` | [ModelsIcon](../AccelByte.Sdk/Api/Achievement/Model/ModelsIcon.cs) |
| `models.PaginatedAchievementResponse` | [ModelsPaginatedAchievementResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedAchievementResponse.cs) |
| `models.PaginatedUserAchievementResponse` | [ModelsPaginatedUserAchievementResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsPaginatedUserAchievementResponse.cs) |
| `models.Pagination` | [ModelsPagination](../AccelByte.Sdk/Api/Achievement/Model/ModelsPagination.cs) |
| `models.PublicAchievementResponse` | [ModelsPublicAchievementResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsPublicAchievementResponse.cs) |
| `models.PublicAchievementsResponse` | [ModelsPublicAchievementsResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsPublicAchievementsResponse.cs) |
| `models.UserAchievementResponse` | [ModelsUserAchievementResponse](../AccelByte.Sdk/Api/Achievement/Model/ModelsUserAchievementResponse.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Achievement/Model/ResponseError.cs) |
| `service.ImportConfigResponse` | [ServiceImportConfigResponse](../AccelByte.Sdk/Api/Achievement/Model/ServiceImportConfigResponse.cs) |
