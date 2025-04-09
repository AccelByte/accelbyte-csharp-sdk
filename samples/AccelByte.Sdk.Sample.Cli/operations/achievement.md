## C# Extend SDK CLI Sample App Operation Index for Achievement service.

### Operation AdminListAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlistachievements \
    --namespace <namespace value> \
    --global <global value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation AdminCreateNewAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op admincreatenewachievement \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExportAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op exportachievements \
    --namespace <namespace value> \
    --tags <tags value - optional>
```

### Operation ImportAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op importachievements \
    --namespace <namespace value> \
    --upload file <file to upload> \
    --strategy <strategy value - optional>
```

### Operation AdminGetAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op admingetachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value>
```

### Operation AdminUpdateAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminupdateachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op admindeleteachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value>
```

### Operation AdminUpdateAchievementListOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminupdateachievementlistorder \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListGlobalAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlistglobalachievements \
    --namespace <namespace value> \
    --achievementCodes <achievementCodes value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional> \
    --tags <tags value - optional>
```

### Operation AdminListGlobalAchievementContributors
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlistglobalachievementcontributors \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation ResetGlobalAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op resetglobalachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value>
```

### Operation BulkCreatePSNEvent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op bulkcreatepsnevent \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListTags
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlisttags \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminListUserAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlistuserachievements \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --preferUnlocked <preferUnlocked value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation AdminResetAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminresetachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUnlockAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminunlockachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminAnonymizeUserAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminanonymizeuserachievement \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminListUserContributions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op adminlistusercontributions \
    --namespace <namespace value> \
    --userId <userId value> \
    --achievementCodes <achievementCodes value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation PublicListAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publiclistachievements \
    --namespace <namespace value> \
    --global <global value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional> \
    --language <language value>
```

### Operation PublicGetAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publicgetachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --language <language value>
```

### Operation PublicListGlobalAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publiclistglobalachievements \
    --namespace <namespace value> \
    --achievementCodes <achievementCodes value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional> \
    --tags <tags value - optional>
```

### Operation ListGlobalAchievementContributors
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op listglobalachievementcontributors \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListTags
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publiclisttags \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListUserAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publiclistuserachievements \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --preferUnlocked <preferUnlocked value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation PublicUnlockAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op publicunlockachievement \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation ListUserContributions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op listusercontributions \
    --namespace <namespace value> \
    --userId <userId value> \
    --achievementCodes <achievementCodes value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation ClaimGlobalAchievementReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn achievement \
    --op claimglobalachievementreward \
    --achievementCode <achievementCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

