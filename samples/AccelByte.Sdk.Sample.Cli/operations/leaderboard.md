## C# Extend SDK CLI Sample App Operation Index for Leaderboard service.

### Operation GetLeaderboardConfigurationsAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationsadminv1 \
    --namespace <namespace value> \
    --isArchived <isArchived value - optional> \
    --isDeleted <isDeleted value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateLeaderboardConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op createleaderboardconfigurationadminv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetArchivedLeaderboardRankingDataV1Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op admingetarchivedleaderboardrankingdatav1handler \
    --namespace <namespace value> \
    --slug <slug value - optional> \
    --leaderboardCodes <leaderboardCodes value>
```

### Operation CreateArchivedLeaderboardRankingDataV1Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op createarchivedleaderboardrankingdatav1handler \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteBulkLeaderboardConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deletebulkleaderboardconfigurationadminv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLeaderboardConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation UpdateLeaderboardConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op updateleaderboardconfigurationadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteLeaderboardConfigurationAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteleaderboardconfigurationadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetAllTimeLeaderboardRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getalltimeleaderboardrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation HardDeleteLeaderboardAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op harddeleteleaderboardadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetCurrentMonthLeaderboardRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentmonthleaderboardrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation DeleteUserRankingByLeaderboardCodeAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingbyleaderboardcodeadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetCurrentSeasonLeaderboardRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentseasonleaderboardrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetTodayLeaderboardRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op gettodayleaderboardrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetUserRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --previousVersion <previousVersion value - optional>
```

### Operation UpdateUserPointAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op updateuserpointadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteUserRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetCurrentWeekLeaderboardRankingAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentweekleaderboardrankingadminv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation DeleteUserRankingsAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingsadminv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --leaderboardCode <leaderboardCode value>
```

### Operation AdminAnonymizeUserLeaderboardAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op adminanonymizeuserleaderboardadminv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetUserLeaderboardRankingsAdminV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserleaderboardrankingsadminv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetLeaderboardConfigurationsPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationspublicv1 \
    --namespace <namespace value> \
    --isArchived <isArchived value - optional> \
    --isDeleted <isDeleted value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateLeaderboardConfigurationPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op createleaderboardconfigurationpublicv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAllTimeLeaderboardRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getalltimeleaderboardrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetArchivedLeaderboardRankingDataV1Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getarchivedleaderboardrankingdatav1handler \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --slug <slug value - optional> \
    --leaderboardCodes <leaderboardCodes value>
```

### Operation GetCurrentMonthLeaderboardRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentmonthleaderboardrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetCurrentSeasonLeaderboardRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentseasonleaderboardrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetTodayLeaderboardRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op gettodayleaderboardrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetUserRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --previousVersion <previousVersion value - optional>
```

### Operation DeleteUserRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetCurrentWeekLeaderboardRankingPublicV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentweekleaderboardrankingpublicv1 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation GetHiddenUsersV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op gethiddenusersv2 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserVisibilityStatusV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuservisibilitystatusv2 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation SetUserLeaderboardVisibilityStatusV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op setuserleaderboardvisibilitystatusv2 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SetUserVisibilityStatusV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op setuservisibilitystatusv2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLeaderboardConfigurationsPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationspublicv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetAllTimeLeaderboardRankingPublicV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getalltimeleaderboardrankingpublicv2 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetLeaderboardConfigurationsAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationsadminv3 \
    --namespace <namespace value> \
    --isDeleted <isDeleted value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateLeaderboardConfigurationAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op createleaderboardconfigurationadminv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteBulkLeaderboardConfigurationAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deletebulkleaderboardconfigurationadminv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLeaderboardConfigurationAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation UpdateLeaderboardConfigurationAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op updateleaderboardconfigurationadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteLeaderboardConfigurationAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteleaderboardconfigurationadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetAllTimeLeaderboardRankingAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getalltimeleaderboardrankingadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetCurrentCycleLeaderboardRankingAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentcycleleaderboardrankingadminv3 \
    --cycleId <cycleId value> \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation DeleteAllUserRankingByCycleIdAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deletealluserrankingbycycleidadminv3 \
    --cycleId <cycleId value> \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation DeleteUserRankingByCycleIdAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingbycycleidadminv3 \
    --cycleId <cycleId value> \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation HardDeleteLeaderboardAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op harddeleteleaderboardadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation DeleteUserRankingByLeaderboardCodeAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingbyleaderboardcodeadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetHiddenUsersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op gethiddenusersv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserRankingAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserrankingadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --previousVersion <previousVersion value - optional>
```

### Operation DeleteUserRankingAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingadminv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetUserVisibilityStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuservisibilitystatusv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation SetUserLeaderboardVisibilityV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op setuserleaderboardvisibilityv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteUserRankingsAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op deleteuserrankingsadminv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --leaderboardCode <leaderboardCode value>
```

### Operation GetUserLeaderboardRankingsAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserleaderboardrankingsadminv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation SetUserVisibilityV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op setuservisibilityv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLeaderboardConfigurationsPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationspublicv3 \
    --namespace <namespace value> \
    --isDeleted <isDeleted value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetLeaderboardConfigurationPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getleaderboardconfigurationpublicv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value>
```

### Operation GetAllTimeLeaderboardRankingPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getalltimeleaderboardrankingpublicv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetCurrentCycleLeaderboardRankingPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getcurrentcycleleaderboardrankingpublicv3 \
    --cycleId <cycleId value> \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --previousVersion <previousVersion value - optional>
```

### Operation BulkGetUsersRankingPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op bulkgetusersrankingpublicv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --previousVersion <previousVersion value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserRankingPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn leaderboard \
    --op getuserrankingpublicv3 \
    --leaderboardCode <leaderboardCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --previousVersion <previousVersion value - optional>
```

