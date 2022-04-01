# Leaderboard Service Index

&nbsp;  

## Operations

### LeaderboardConfiguration Wrapper:  [LeaderboardConfiguration](../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardConfiguration.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards | GET | GetLeaderboardConfigurationsAdminV1 | [GetLeaderboardConfigurationsAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetLeaderboardConfigurationsAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards | POST | CreateLeaderboardConfigurationAdminV1 | [CreateLeaderboardConfigurationAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//CreateLeaderboardConfigurationAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/delete | POST | DeleteBulkLeaderboardConfigurationAdminV1 | [DeleteBulkLeaderboardConfigurationAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//DeleteBulkLeaderboardConfigurationAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode} | GET | GetLeaderboardConfigurationAdminV1 | [GetLeaderboardConfigurationAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetLeaderboardConfigurationAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode} | PUT | UpdateLeaderboardConfigurationAdminV1 | [UpdateLeaderboardConfigurationAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//UpdateLeaderboardConfigurationAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode} | DELETE | DeleteLeaderboardConfigurationAdminV1 | [DeleteLeaderboardConfigurationAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//DeleteLeaderboardConfigurationAdminV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards | GET | GetLeaderboardConfigurationsPublicV1 | [GetLeaderboardConfigurationsPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetLeaderboardConfigurationsPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards | POST | CreateLeaderboardConfigurationPublicV1 | [CreateLeaderboardConfigurationPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//CreateLeaderboardConfigurationPublicV1.cs) |
| /leaderboard/v2/public/namespaces/{namespace}/leaderboards | GET | GetLeaderboardConfigurationsPublicV2 | [GetLeaderboardConfigurationsPublicV2](../AccelByte.Sdk/Api/Leaderboard/Operation//GetLeaderboardConfigurationsPublicV2.cs) |

### LeaderboardData Wrapper:  [LeaderboardData](../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardData.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived | GET | AdminGetArchivedLeaderboardRankingDataV1Handler | [AdminGetArchivedLeaderboardRankingDataV1Handler](../AccelByte.Sdk/Api/Leaderboard/Operation//AdminGetArchivedLeaderboardRankingDataV1Handler.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived | POST | CreateArchivedLeaderboardRankingDataV1Handler | [CreateArchivedLeaderboardRankingDataV1Handler](../AccelByte.Sdk/Api/Leaderboard/Operation//CreateArchivedLeaderboardRankingDataV1Handler.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime | GET | GetAllTimeLeaderboardRankingAdminV1 | [GetAllTimeLeaderboardRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetAllTimeLeaderboardRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/month | GET | GetCurrentMonthLeaderboardRankingAdminV1 | [GetCurrentMonthLeaderboardRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentMonthLeaderboardRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/season | GET | GetCurrentSeasonLeaderboardRankingAdminV1 | [GetCurrentSeasonLeaderboardRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentSeasonLeaderboardRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/today | GET | GetTodayLeaderboardRankingAdminV1 | [GetTodayLeaderboardRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetTodayLeaderboardRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId} | GET | GetUserRankingAdminV1 | [GetUserRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetUserRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId} | PUT | UpdateUserPointAdminV1 | [UpdateUserPointAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//UpdateUserPointAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId} | DELETE | DeleteUserRankingAdminV1 | [DeleteUserRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//DeleteUserRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/week | GET | GetCurrentWeekLeaderboardRankingAdminV1 | [GetCurrentWeekLeaderboardRankingAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentWeekLeaderboardRankingAdminV1.cs) |
| /leaderboard/v1/admin/namespaces/{namespace}/users/{userId} | DELETE | DeleteUserRankingsAdminV1 | [DeleteUserRankingsAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//DeleteUserRankingsAdminV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime | GET | GetAllTimeLeaderboardRankingPublicV1 | [GetAllTimeLeaderboardRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetAllTimeLeaderboardRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/archived | GET | GetArchivedLeaderboardRankingDataV1Handler | [GetArchivedLeaderboardRankingDataV1Handler](../AccelByte.Sdk/Api/Leaderboard/Operation//GetArchivedLeaderboardRankingDataV1Handler.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/month | GET | GetCurrentMonthLeaderboardRankingPublicV1 | [GetCurrentMonthLeaderboardRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentMonthLeaderboardRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/season | GET | GetCurrentSeasonLeaderboardRankingPublicV1 | [GetCurrentSeasonLeaderboardRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentSeasonLeaderboardRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/today | GET | GetTodayLeaderboardRankingPublicV1 | [GetTodayLeaderboardRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetTodayLeaderboardRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId} | GET | GetUserRankingPublicV1 | [GetUserRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetUserRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId} | DELETE | DeleteUserRankingPublicV1 | [DeleteUserRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//DeleteUserRankingPublicV1.cs) |
| /leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/week | GET | GetCurrentWeekLeaderboardRankingPublicV1 | [GetCurrentWeekLeaderboardRankingPublicV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetCurrentWeekLeaderboardRankingPublicV1.cs) |
| /leaderboard/v2/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime | GET | GetAllTimeLeaderboardRankingPublicV2 | [GetAllTimeLeaderboardRankingPublicV2](../AccelByte.Sdk/Api/Leaderboard/Operation//GetAllTimeLeaderboardRankingPublicV2.cs) |

### UserData Wrapper:  [UserData](../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserData.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /leaderboard/v1/admin/namespaces/{namespace}/users/{userId}/leaderboards | GET | GetUserLeaderboardRankingsAdminV1 | [GetUserLeaderboardRankingsAdminV1](../AccelByte.Sdk/Api/Leaderboard/Operation//GetUserLeaderboardRankingsAdminV1.cs) |

### UserVisibility Wrapper:  [UserVisibility](../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserVisibility.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/hidden | GET | GetHiddenUsersV2 | [GetHiddenUsersV2](../AccelByte.Sdk/Api/Leaderboard/Operation//GetHiddenUsersV2.cs) |
| /leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility | GET | GetUserVisibilityStatusV2 | [GetUserVisibilityStatusV2](../AccelByte.Sdk/Api/Leaderboard/Operation//GetUserVisibilityStatusV2.cs) |
| /leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility | PUT | SetUserLeaderboardVisibilityStatusV2 | [SetUserLeaderboardVisibilityStatusV2](../AccelByte.Sdk/Api/Leaderboard/Operation//SetUserLeaderboardVisibilityStatusV2.cs) |
| /leaderboard/v2/admin/namespaces/{namespace}/users/{userId}/visibility | PUT | SetUserVisibilityStatusV2 | [SetUserVisibilityStatusV2](../AccelByte.Sdk/Api/Leaderboard/Operation//SetUserVisibilityStatusV2.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| models.ArchiveLeaderboardReq | [ModelsArchiveLeaderboardReq](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsArchiveLeaderboardReq.cs) |
| models.ArchiveLeaderboardSignedURLResponse | [ModelsArchiveLeaderboardSignedURLResponse](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsArchiveLeaderboardSignedURLResponse.cs) |
| models.DailyConfig | [ModelsDailyConfig](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDailyConfig.cs) |
| models.DeleteBulkLeaderboardFailedResp | [ModelsDeleteBulkLeaderboardFailedResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardFailedResp.cs) |
| models.DeleteBulkLeaderboardsReq | [ModelsDeleteBulkLeaderboardsReq](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardsReq.cs) |
| models.DeleteBulkLeaderboardsResp | [ModelsDeleteBulkLeaderboardsResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardsResp.cs) |
| models.GetAllLeaderboardConfigsPublicResp | [ModelsGetAllLeaderboardConfigsPublicResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsPublicResp.cs) |
| models.GetAllLeaderboardConfigsResp | [ModelsGetAllLeaderboardConfigsResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsResp.cs) |
| models.GetAllUserLeaderboardsResp | [ModelsGetAllUserLeaderboardsResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllUserLeaderboardsResp.cs) |
| models.GetHiddenUserResponse | [ModelsGetHiddenUserResponse](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetHiddenUserResponse.cs) |
| models.GetLeaderboardConfigPublicResp | [ModelsGetLeaderboardConfigPublicResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigPublicResp.cs) |
| models.GetLeaderboardConfigResp | [ModelsGetLeaderboardConfigResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigResp.cs) |
| models.GetLeaderboardRankingResp | [ModelsGetLeaderboardRankingResp](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardRankingResp.cs) |
| models.GetUserVisibilityResponse | [ModelsGetUserVisibilityResponse](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetUserVisibilityResponse.cs) |
| models.LeaderboardConfigReq | [ModelsLeaderboardConfigReq](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsLeaderboardConfigReq.cs) |
| models.MonthlyConfig | [ModelsMonthlyConfig](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsMonthlyConfig.cs) |
| models.Pagination | [ModelsPagination](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsPagination.cs) |
| models.SetUserVisibilityRequest | [ModelsSetUserVisibilityRequest](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsSetUserVisibilityRequest.cs) |
| models.UpdateLeaderboardConfigReq | [ModelsUpdateLeaderboardConfigReq](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateLeaderboardConfigReq.cs) |
| models.UpdateUserPointAdminV1Request | [ModelsUpdateUserPointAdminV1Request](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateUserPointAdminV1Request.cs) |
| models.UpdateUserPointAdminV1Response | [ModelsUpdateUserPointAdminV1Response](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateUserPointAdminV1Response.cs) |
| models.UserLeaderboardRanking | [ModelsUserLeaderboardRanking](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserLeaderboardRanking.cs) |
| models.UserPoint | [ModelsUserPoint](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserPoint.cs) |
| models.UserRankingResponse | [ModelsUserRankingResponse](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponse.cs) |
| models.UserRankingResponseDetail | [ModelsUserRankingResponseDetail](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponseDetail.cs) |
| models.WeeklyConfig | [ModelsWeeklyConfig](../AccelByte.Sdk/Api/Leaderboard/Model/ModelsWeeklyConfig.cs) |
| response.ErrorResponse | [ResponseErrorResponse](../AccelByte.Sdk/Api/Leaderboard/Model/ResponseErrorResponse.cs) |
| v2.Entry | [V2Entry](../AccelByte.Sdk/Api/Leaderboard/Model/V2Entry.cs) |
| v2.GetAllLeaderboardConfigsPublicResp | [V2GetAllLeaderboardConfigsPublicResp](../AccelByte.Sdk/Api/Leaderboard/Model/V2GetAllLeaderboardConfigsPublicResp.cs) |
| v2.GetLeaderboardConfigPublicResp | [V2GetLeaderboardConfigPublicResp](../AccelByte.Sdk/Api/Leaderboard/Model/V2GetLeaderboardConfigPublicResp.cs) |
| v2.GetPublicLeaderboardRankingResponse | [V2GetPublicLeaderboardRankingResponse](../AccelByte.Sdk/Api/Leaderboard/Model/V2GetPublicLeaderboardRankingResponse.cs) |
| v2.Pagination | [V2Pagination](../AccelByte.Sdk/Api/Leaderboard/Model/V2Pagination.cs) |
