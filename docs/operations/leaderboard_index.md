# Leaderboard Service Index

&nbsp;  

## Operations

### LeaderboardConfiguration Wrapper:  [LeaderboardConfiguration](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards` | GET | GetLeaderboardConfigurationsAdminV1 | [GetLeaderboardConfigurationsAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/GetLeaderboardConfigurationsAdminV1.cs) | [GetLeaderboardConfigurationsAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/GetLeaderboardConfigurationsAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards` | POST | CreateLeaderboardConfigurationAdminV1 | [CreateLeaderboardConfigurationAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/CreateLeaderboardConfigurationAdminV1.cs) | [CreateLeaderboardConfigurationAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/CreateLeaderboardConfigurationAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/delete` | POST | DeleteBulkLeaderboardConfigurationAdminV1 | [DeleteBulkLeaderboardConfigurationAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/DeleteBulkLeaderboardConfigurationAdminV1.cs) | [DeleteBulkLeaderboardConfigurationAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/DeleteBulkLeaderboardConfigurationAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | GET | GetLeaderboardConfigurationAdminV1 | [GetLeaderboardConfigurationAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/GetLeaderboardConfigurationAdminV1.cs) | [GetLeaderboardConfigurationAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/GetLeaderboardConfigurationAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | PUT | UpdateLeaderboardConfigurationAdminV1 | [UpdateLeaderboardConfigurationAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/UpdateLeaderboardConfigurationAdminV1.cs) | [UpdateLeaderboardConfigurationAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/UpdateLeaderboardConfigurationAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | DELETE | DeleteLeaderboardConfigurationAdminV1 | [DeleteLeaderboardConfigurationAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/DeleteLeaderboardConfigurationAdminV1.cs) | [DeleteLeaderboardConfigurationAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/DeleteLeaderboardConfigurationAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/hard` | DELETE | HardDeleteLeaderboardAdminV1 | [HardDeleteLeaderboardAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/HardDeleteLeaderboardAdminV1.cs) | [HardDeleteLeaderboardAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/HardDeleteLeaderboardAdminV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards` | GET | GetLeaderboardConfigurationsPublicV1 | [GetLeaderboardConfigurationsPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/GetLeaderboardConfigurationsPublicV1.cs) | [GetLeaderboardConfigurationsPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/GetLeaderboardConfigurationsPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards` | POST | CreateLeaderboardConfigurationPublicV1 | [CreateLeaderboardConfigurationPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/CreateLeaderboardConfigurationPublicV1.cs) | [CreateLeaderboardConfigurationPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/CreateLeaderboardConfigurationPublicV1.cs) |
| `/leaderboard/v2/public/namespaces/{namespace}/leaderboards` | GET | GetLeaderboardConfigurationsPublicV2 | [GetLeaderboardConfigurationsPublicV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfiguration/GetLeaderboardConfigurationsPublicV2.cs) | [GetLeaderboardConfigurationsPublicV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfiguration/GetLeaderboardConfigurationsPublicV2.cs) |

### LeaderboardData Wrapper:  [LeaderboardData](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardData.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived` | GET | AdminGetArchivedLeaderboardRankingDataV1Handler | [AdminGetArchivedLeaderboardRankingDataV1Handler](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/AdminGetArchivedLeaderboardRankingDataV1Handler.cs) | [AdminGetArchivedLeaderboardRankingDataV1Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/AdminGetArchivedLeaderboardRankingDataV1Handler.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/archived` | POST | CreateArchivedLeaderboardRankingDataV1Handler | [CreateArchivedLeaderboardRankingDataV1Handler](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/CreateArchivedLeaderboardRankingDataV1Handler.cs) | [CreateArchivedLeaderboardRankingDataV1Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/CreateArchivedLeaderboardRankingDataV1Handler.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime` | GET | GetAllTimeLeaderboardRankingAdminV1 | [GetAllTimeLeaderboardRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetAllTimeLeaderboardRankingAdminV1.cs) | [GetAllTimeLeaderboardRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetAllTimeLeaderboardRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/month` | GET | GetCurrentMonthLeaderboardRankingAdminV1 | [GetCurrentMonthLeaderboardRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentMonthLeaderboardRankingAdminV1.cs) | [GetCurrentMonthLeaderboardRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentMonthLeaderboardRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/reset` | DELETE | DeleteUserRankingByLeaderboardCodeAdminV1 | [DeleteUserRankingByLeaderboardCodeAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/DeleteUserRankingByLeaderboardCodeAdminV1.cs) | [DeleteUserRankingByLeaderboardCodeAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/DeleteUserRankingByLeaderboardCodeAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/season` | GET | GetCurrentSeasonLeaderboardRankingAdminV1 | [GetCurrentSeasonLeaderboardRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentSeasonLeaderboardRankingAdminV1.cs) | [GetCurrentSeasonLeaderboardRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentSeasonLeaderboardRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/today` | GET | GetTodayLeaderboardRankingAdminV1 | [GetTodayLeaderboardRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetTodayLeaderboardRankingAdminV1.cs) | [GetTodayLeaderboardRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetTodayLeaderboardRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | GET | GetUserRankingAdminV1 | [GetUserRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetUserRankingAdminV1.cs) | [GetUserRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetUserRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | PUT | UpdateUserPointAdminV1 | [UpdateUserPointAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/UpdateUserPointAdminV1.cs) | [UpdateUserPointAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/UpdateUserPointAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | DELETE | DeleteUserRankingAdminV1 | [DeleteUserRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/DeleteUserRankingAdminV1.cs) | [DeleteUserRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/DeleteUserRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/week` | GET | GetCurrentWeekLeaderboardRankingAdminV1 | [GetCurrentWeekLeaderboardRankingAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentWeekLeaderboardRankingAdminV1.cs) | [GetCurrentWeekLeaderboardRankingAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentWeekLeaderboardRankingAdminV1.cs) |
| `/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}` | DELETE | DeleteUserRankingsAdminV1 | [DeleteUserRankingsAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/DeleteUserRankingsAdminV1.cs) | [DeleteUserRankingsAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/DeleteUserRankingsAdminV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime` | GET | GetAllTimeLeaderboardRankingPublicV1 | [GetAllTimeLeaderboardRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetAllTimeLeaderboardRankingPublicV1.cs) | [GetAllTimeLeaderboardRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetAllTimeLeaderboardRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/archived` | GET | GetArchivedLeaderboardRankingDataV1Handler | [GetArchivedLeaderboardRankingDataV1Handler](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetArchivedLeaderboardRankingDataV1Handler.cs) | [GetArchivedLeaderboardRankingDataV1Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetArchivedLeaderboardRankingDataV1Handler.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/month` | GET | GetCurrentMonthLeaderboardRankingPublicV1 | [GetCurrentMonthLeaderboardRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentMonthLeaderboardRankingPublicV1.cs) | [GetCurrentMonthLeaderboardRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentMonthLeaderboardRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/season` | GET | GetCurrentSeasonLeaderboardRankingPublicV1 | [GetCurrentSeasonLeaderboardRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentSeasonLeaderboardRankingPublicV1.cs) | [GetCurrentSeasonLeaderboardRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentSeasonLeaderboardRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/today` | GET | GetTodayLeaderboardRankingPublicV1 | [GetTodayLeaderboardRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetTodayLeaderboardRankingPublicV1.cs) | [GetTodayLeaderboardRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetTodayLeaderboardRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | GET | GetUserRankingPublicV1 | [GetUserRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetUserRankingPublicV1.cs) | [GetUserRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetUserRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | DELETE | DeleteUserRankingPublicV1 | [DeleteUserRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/DeleteUserRankingPublicV1.cs) | [DeleteUserRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/DeleteUserRankingPublicV1.cs) |
| `/leaderboard/v1/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/week` | GET | GetCurrentWeekLeaderboardRankingPublicV1 | [GetCurrentWeekLeaderboardRankingPublicV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetCurrentWeekLeaderboardRankingPublicV1.cs) | [GetCurrentWeekLeaderboardRankingPublicV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetCurrentWeekLeaderboardRankingPublicV1.cs) |
| `/leaderboard/v2/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime` | GET | GetAllTimeLeaderboardRankingPublicV2 | [GetAllTimeLeaderboardRankingPublicV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardData/GetAllTimeLeaderboardRankingPublicV2.cs) | [GetAllTimeLeaderboardRankingPublicV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardData/GetAllTimeLeaderboardRankingPublicV2.cs) |

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/leaderboards` | DELETE | AdminAnonymizeUserLeaderboardAdminV1 | [AdminAnonymizeUserLeaderboardAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/Anonymization/AdminAnonymizeUserLeaderboardAdminV1.cs) | [AdminAnonymizeUserLeaderboardAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/Anonymization/AdminAnonymizeUserLeaderboardAdminV1.cs) |

### UserData Wrapper:  [UserData](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserData.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v1/admin/namespaces/{namespace}/users/{userId}/leaderboards` | GET | GetUserLeaderboardRankingsAdminV1 | [GetUserLeaderboardRankingsAdminV1](../../AccelByte.Sdk/Api/Leaderboard/Operation/UserData/GetUserLeaderboardRankingsAdminV1.cs) | [GetUserLeaderboardRankingsAdminV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/UserData/GetUserLeaderboardRankingsAdminV1.cs) |

### UserVisibility Wrapper:  [UserVisibility](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserVisibility.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/hidden` | GET | GetHiddenUsersV2 | [GetHiddenUsersV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/UserVisibility/GetHiddenUsersV2.cs) | [GetHiddenUsersV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/UserVisibility/GetHiddenUsersV2.cs) |
| `/leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility` | GET | GetUserVisibilityStatusV2 | [GetUserVisibilityStatusV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/UserVisibility/GetUserVisibilityStatusV2.cs) | [GetUserVisibilityStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/UserVisibility/GetUserVisibilityStatusV2.cs) |
| `/leaderboard/v2/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}/visibility` | PUT | SetUserLeaderboardVisibilityStatusV2 | [SetUserLeaderboardVisibilityStatusV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/UserVisibility/SetUserLeaderboardVisibilityStatusV2.cs) | [SetUserLeaderboardVisibilityStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/UserVisibility/SetUserLeaderboardVisibilityStatusV2.cs) |
| `/leaderboard/v2/admin/namespaces/{namespace}/users/{userId}/visibility` | PUT | SetUserVisibilityStatusV2 | [SetUserVisibilityStatusV2](../../AccelByte.Sdk/Api/Leaderboard/Operation/UserVisibility/SetUserVisibilityStatusV2.cs) | [SetUserVisibilityStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/UserVisibility/SetUserVisibilityStatusV2.cs) |

### LeaderboardConfigurationV3 Wrapper:  [LeaderboardConfigurationV3](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardConfigurationV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards` | GET | GetLeaderboardConfigurationsAdminV3 | [GetLeaderboardConfigurationsAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/GetLeaderboardConfigurationsAdminV3.cs) | [GetLeaderboardConfigurationsAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/GetLeaderboardConfigurationsAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards` | POST | CreateLeaderboardConfigurationAdminV3 | [CreateLeaderboardConfigurationAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/CreateLeaderboardConfigurationAdminV3.cs) | [CreateLeaderboardConfigurationAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/CreateLeaderboardConfigurationAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/delete` | POST | DeleteBulkLeaderboardConfigurationAdminV3 | [DeleteBulkLeaderboardConfigurationAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/DeleteBulkLeaderboardConfigurationAdminV3.cs) | [DeleteBulkLeaderboardConfigurationAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/DeleteBulkLeaderboardConfigurationAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | GET | GetLeaderboardConfigurationAdminV3 | [GetLeaderboardConfigurationAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/GetLeaderboardConfigurationAdminV3.cs) | [GetLeaderboardConfigurationAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/GetLeaderboardConfigurationAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | PUT | UpdateLeaderboardConfigurationAdminV3 | [UpdateLeaderboardConfigurationAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/UpdateLeaderboardConfigurationAdminV3.cs) | [UpdateLeaderboardConfigurationAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/UpdateLeaderboardConfigurationAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}` | DELETE | DeleteLeaderboardConfigurationAdminV3 | [DeleteLeaderboardConfigurationAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/DeleteLeaderboardConfigurationAdminV3.cs) | [DeleteLeaderboardConfigurationAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/DeleteLeaderboardConfigurationAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/hard` | DELETE | HardDeleteLeaderboardAdminV3 | [HardDeleteLeaderboardAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/HardDeleteLeaderboardAdminV3.cs) | [HardDeleteLeaderboardAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/HardDeleteLeaderboardAdminV3.cs) |
| `/leaderboard/v3/public/namespaces/{namespace}/leaderboards` | GET | GetLeaderboardConfigurationsPublicV3 | [GetLeaderboardConfigurationsPublicV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/GetLeaderboardConfigurationsPublicV3.cs) | [GetLeaderboardConfigurationsPublicV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/GetLeaderboardConfigurationsPublicV3.cs) |
| `/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}` | GET | GetLeaderboardConfigurationPublicV3 | [GetLeaderboardConfigurationPublicV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardConfigurationV3/GetLeaderboardConfigurationPublicV3.cs) | [GetLeaderboardConfigurationPublicV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardConfigurationV3/GetLeaderboardConfigurationPublicV3.cs) |

### LeaderboardDataV3 Wrapper:  [LeaderboardDataV3](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardDataV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime` | GET | GetAllTimeLeaderboardRankingAdminV3 | [GetAllTimeLeaderboardRankingAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetAllTimeLeaderboardRankingAdminV3.cs) | [GetAllTimeLeaderboardRankingAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetAllTimeLeaderboardRankingAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/cycles/{cycleId}` | GET | GetCurrentCycleLeaderboardRankingAdminV3 | [GetCurrentCycleLeaderboardRankingAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetCurrentCycleLeaderboardRankingAdminV3.cs) | [GetCurrentCycleLeaderboardRankingAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetCurrentCycleLeaderboardRankingAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/reset` | DELETE | DeleteUserRankingByLeaderboardCodeAdminV3 | [DeleteUserRankingByLeaderboardCodeAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/DeleteUserRankingByLeaderboardCodeAdminV3.cs) | [DeleteUserRankingByLeaderboardCodeAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/DeleteUserRankingByLeaderboardCodeAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | GET | GetUserRankingAdminV3 | [GetUserRankingAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetUserRankingAdminV3.cs) | [GetUserRankingAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetUserRankingAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | DELETE | DeleteUserRankingAdminV3 | [DeleteUserRankingAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/DeleteUserRankingAdminV3.cs) | [DeleteUserRankingAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/DeleteUserRankingAdminV3.cs) |
| `/leaderboard/v3/admin/namespaces/{namespace}/users/{userId}` | DELETE | DeleteUserRankingsAdminV3 | [DeleteUserRankingsAdminV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/DeleteUserRankingsAdminV3.cs) | [DeleteUserRankingsAdminV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/DeleteUserRankingsAdminV3.cs) |
| `/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/alltime` | GET | GetAllTimeLeaderboardRankingPublicV3 | [GetAllTimeLeaderboardRankingPublicV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetAllTimeLeaderboardRankingPublicV3.cs) | [GetAllTimeLeaderboardRankingPublicV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetAllTimeLeaderboardRankingPublicV3.cs) |
| `/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/cycles/{cycleId}` | GET | GetCurrentCycleLeaderboardRankingPublicV3 | [GetCurrentCycleLeaderboardRankingPublicV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetCurrentCycleLeaderboardRankingPublicV3.cs) | [GetCurrentCycleLeaderboardRankingPublicV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetCurrentCycleLeaderboardRankingPublicV3.cs) |
| `/leaderboard/v3/public/namespaces/{namespace}/leaderboards/{leaderboardCode}/users/{userId}` | GET | GetUserRankingPublicV3 | [GetUserRankingPublicV3](../../AccelByte.Sdk/Api/Leaderboard/Operation/LeaderboardDataV3/GetUserRankingPublicV3.cs) | [GetUserRankingPublicV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Leaderboard/LeaderboardDataV3/GetUserRankingPublicV3.cs) |


&nbsp;  

## Operations with Generic Response

### LeaderboardConfiguration Wrapper:  [LeaderboardConfiguration](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### LeaderboardData Wrapper:  [LeaderboardData](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardData.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### UserData Wrapper:  [UserData](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserData.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### UserVisibility Wrapper:  [UserVisibility](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/UserVisibility.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### LeaderboardConfigurationV3 Wrapper:  [LeaderboardConfigurationV3](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardConfigurationV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### LeaderboardDataV3 Wrapper:  [LeaderboardDataV3](../../AccelByte.Sdk/Api/Leaderboard/Wrapper/LeaderboardDataV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.ArchiveLeaderboardReq` | [ModelsArchiveLeaderboardReq](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsArchiveLeaderboardReq.cs) |
| `models.ArchiveLeaderboardSignedURLResponse` | [ModelsArchiveLeaderboardSignedURLResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsArchiveLeaderboardSignedURLResponse.cs) |
| `models.DailyConfig` | [ModelsDailyConfig](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDailyConfig.cs) |
| `models.DeleteBulkLeaderboardFailedResp` | [ModelsDeleteBulkLeaderboardFailedResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardFailedResp.cs) |
| `models.DeleteBulkLeaderboardsReq` | [ModelsDeleteBulkLeaderboardsReq](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardsReq.cs) |
| `models.DeleteBulkLeaderboardsResp` | [ModelsDeleteBulkLeaderboardsResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsDeleteBulkLeaderboardsResp.cs) |
| `models.GetAllLeaderboardConfigsPublicResp` | [ModelsGetAllLeaderboardConfigsPublicResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsPublicResp.cs) |
| `models.GetAllLeaderboardConfigsPublicRespV3` | [ModelsGetAllLeaderboardConfigsPublicRespV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsPublicRespV3.cs) |
| `models.GetAllLeaderboardConfigsResp` | [ModelsGetAllLeaderboardConfigsResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsResp.cs) |
| `models.GetAllLeaderboardConfigsRespV3` | [ModelsGetAllLeaderboardConfigsRespV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllLeaderboardConfigsRespV3.cs) |
| `models.GetAllUserLeaderboardsResp` | [ModelsGetAllUserLeaderboardsResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetAllUserLeaderboardsResp.cs) |
| `models.GetHiddenUserResponse` | [ModelsGetHiddenUserResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetHiddenUserResponse.cs) |
| `models.GetLeaderboardConfigPublicResp` | [ModelsGetLeaderboardConfigPublicResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigPublicResp.cs) |
| `models.GetLeaderboardConfigPublicRespV3` | [ModelsGetLeaderboardConfigPublicRespV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigPublicRespV3.cs) |
| `models.GetLeaderboardConfigResp` | [ModelsGetLeaderboardConfigResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigResp.cs) |
| `models.GetLeaderboardConfigRespV3` | [ModelsGetLeaderboardConfigRespV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardConfigRespV3.cs) |
| `models.GetLeaderboardRankingResp` | [ModelsGetLeaderboardRankingResp](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetLeaderboardRankingResp.cs) |
| `models.GetUserVisibilityResponse` | [ModelsGetUserVisibilityResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsGetUserVisibilityResponse.cs) |
| `models.LeaderboardConfigReq` | [ModelsLeaderboardConfigReq](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsLeaderboardConfigReq.cs) |
| `models.LeaderboardConfigReqV3` | [ModelsLeaderboardConfigReqV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsLeaderboardConfigReqV3.cs) |
| `models.MonthlyConfig` | [ModelsMonthlyConfig](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsMonthlyConfig.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsPagination.cs) |
| `models.PaginationV3` | [ModelsPaginationV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsPaginationV3.cs) |
| `models.SetUserVisibilityRequest` | [ModelsSetUserVisibilityRequest](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsSetUserVisibilityRequest.cs) |
| `models.UpdateLeaderboardConfigReq` | [ModelsUpdateLeaderboardConfigReq](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateLeaderboardConfigReq.cs) |
| `models.UpdateLeaderboardConfigReqV3` | [ModelsUpdateLeaderboardConfigReqV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateLeaderboardConfigReqV3.cs) |
| `models.UpdateUserPointAdminV1Request` | [ModelsUpdateUserPointAdminV1Request](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateUserPointAdminV1Request.cs) |
| `models.UpdateUserPointAdminV1Response` | [ModelsUpdateUserPointAdminV1Response](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUpdateUserPointAdminV1Response.cs) |
| `models.UserCycleRankingResponseDetail` | [ModelsUserCycleRankingResponseDetail](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserCycleRankingResponseDetail.cs) |
| `models.UserLeaderboardRanking` | [ModelsUserLeaderboardRanking](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserLeaderboardRanking.cs) |
| `models.UserPoint` | [ModelsUserPoint](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserPoint.cs) |
| `models.UserRankingResponse` | [ModelsUserRankingResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponse.cs) |
| `models.UserRankingResponseDetail` | [ModelsUserRankingResponseDetail](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponseDetail.cs) |
| `models.UserRankingResponseDetailV3` | [ModelsUserRankingResponseDetailV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponseDetailV3.cs) |
| `models.UserRankingResponseV3` | [ModelsUserRankingResponseV3](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsUserRankingResponseV3.cs) |
| `models.WeeklyConfig` | [ModelsWeeklyConfig](../../AccelByte.Sdk/Api/Leaderboard/Model/ModelsWeeklyConfig.cs) |
| `response.ErrorResponse` | [ResponseErrorResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/ResponseErrorResponse.cs) |
| `v2.Entry` | [V2Entry](../../AccelByte.Sdk/Api/Leaderboard/Model/V2Entry.cs) |
| `v2.GetAllLeaderboardConfigsPublicResp` | [V2GetAllLeaderboardConfigsPublicResp](../../AccelByte.Sdk/Api/Leaderboard/Model/V2GetAllLeaderboardConfigsPublicResp.cs) |
| `v2.GetLeaderboardConfigPublicResp` | [V2GetLeaderboardConfigPublicResp](../../AccelByte.Sdk/Api/Leaderboard/Model/V2GetLeaderboardConfigPublicResp.cs) |
| `v2.GetPublicLeaderboardRankingResponse` | [V2GetPublicLeaderboardRankingResponse](../../AccelByte.Sdk/Api/Leaderboard/Model/V2GetPublicLeaderboardRankingResponse.cs) |
| `v2.Pagination` | [V2Pagination](../../AccelByte.Sdk/Api/Leaderboard/Model/V2Pagination.cs) |
