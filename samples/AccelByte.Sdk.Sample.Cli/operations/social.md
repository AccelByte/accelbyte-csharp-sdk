## C# Extend SDK CLI Sample App Operation Index for Social service.

### Operation GetGlobalStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getglobalstatitems \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --statCodes <statCodes value - optional>
```

### Operation GetGlobalStatItemByStatCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getglobalstatitembystatcode \
    --namespace <namespace value> \
    --statCode <statCode value>
```

### Operation GetStatCycles
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstatcycles \
    --namespace <namespace value> \
    --cycleType <cycleType value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation CreateStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op createstatcycle \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkGetStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkgetstatcycle \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExportStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op exportstatcycle \
    --namespace <namespace value>
```

### Operation ImportStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op importstatcycle \
    --namespace <namespace value> \
    --replaceExisting <replaceExisting value - optional> \
    --upload file <file to upload>
```

### Operation GetStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstatcycle \
    --cycleId <cycleId value> \
    --namespace <namespace value>
```

### Operation UpdateStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op updatestatcycle \
    --cycleId <cycleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deletestatcycle \
    --cycleId <cycleId value> \
    --namespace <namespace value>
```

### Operation BulkAddStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkaddstats \
    --cycleId <cycleId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation StopStatCycle
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op stopstatcycle \
    --cycleId <cycleId value> \
    --namespace <namespace value>
```

### Operation BulkFetchStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkfetchstatitems \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userIds <userIds value>
```

### Operation BulkIncUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkincuserstatitem \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkIncUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkincuserstatitemvalue \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkFetchOrDefaultStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkfetchordefaultstatitems \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userIds <userIds value>
```

### Operation BulkResetUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkresetuserstatitem \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstats \
    --namespace <namespace value> \
    --cycleIds <cycleIds value - optional> \
    --isGlobal <isGlobal value - optional> \
    --isPublic <isPublic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateStat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op createstat \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExportStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op exportstats \
    --namespace <namespace value>
```

### Operation ImportStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op importstats \
    --namespace <namespace value> \
    --replaceExisting <replaceExisting value - optional> \
    --upload file <file to upload>
```

### Operation QueryStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op querystats \
    --namespace <namespace value> \
    --isGlobal <isGlobal value - optional> \
    --isPublic <isPublic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --keyword <keyword value>
```

### Operation GetStat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstat \
    --namespace <namespace value> \
    --statCode <statCode value>
```

### Operation DeleteStat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deletestat \
    --namespace <namespace value> \
    --statCode <statCode value>
```

### Operation UpdateStat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op updatestat \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstatitems \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation DeleteTiedStat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deletetiedstat \
    --namespace <namespace value> \
    --statCode <statCode value>
```

### Operation GetUserStatCycleItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getuserstatcycleitems \
    --cycleId <cycleId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --isPublic <isPublic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional>
```

### Operation GetUserStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getuserstatitems \
    --namespace <namespace value> \
    --userId <userId value> \
    --isPublic <isPublic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation BulkCreateUserStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkcreateuserstatitems \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkIncUserStatItem1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkincuserstatitem1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkIncUserStatItemValue1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkincuserstatitemvalue1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkResetUserStatItem1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkresetuserstatitem1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op createuserstatitem \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value>
```

### Operation DeleteUserStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deleteuserstatitems \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value>
```

### Operation IncUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op incuserstatitemvalue \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ResetUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op resetuserstatitemvalue \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGlobalStatItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getglobalstatitems1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --statCodes <statCodes value - optional>
```

### Operation GetGlobalStatItemByStatCode1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getglobalstatitembystatcode1 \
    --namespace <namespace value> \
    --statCode <statCode value>
```

### Operation GetStatCycles1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstatcycles1 \
    --namespace <namespace value> \
    --cycleType <cycleType value - optional> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation BulkGetStatCycle1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkgetstatcycle1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetStatCycle1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getstatcycle1 \
    --cycleId <cycleId value> \
    --namespace <namespace value>
```

### Operation BulkFetchStatItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkfetchstatitems1 \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userIds <userIds value>
```

### Operation PublicBulkIncUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicbulkincuserstatitem \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicBulkIncUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicbulkincuserstatitemvalue \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkResetUserStatItem2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkresetuserstatitem2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateStat1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op createstat1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicListMyStatCycleItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publiclistmystatcycleitems \
    --cycleId <cycleId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional>
```

### Operation PublicListMyStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publiclistmystatitems \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation PublicListAllMyStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publiclistallmystatitems \
    --namespace <namespace value> \
    --additionalKey <additionalKey value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation GetUserStatCycleItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op getuserstatcycleitems1 \
    --cycleId <cycleId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional>
```

### Operation PublicQueryUserStatItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicqueryuserstatitems1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation PublicBulkCreateUserStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicbulkcreateuserstatitems \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryUserStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicqueryuserstatitems \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation PublicBulkIncUserStatItem1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicbulkincuserstatitem1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkIncUserStatItemValue2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkincuserstatitemvalue2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkResetUserStatItem3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkresetuserstatitem3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCreateUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publiccreateuserstatitem \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value>
```

### Operation DeleteUserStatItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deleteuserstatitems1 \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value>
```

### Operation PublicIncUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicincuserstatitem \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicIncUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicincuserstatitemvalue \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ResetUserStatItemValue1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op resetuserstatitemvalue1 \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value>
```

### Operation BulkUpdateUserStatItemV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkupdateuserstatitemv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkFetchOrDefaultStatItems1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkfetchordefaultstatitems1 \
    --namespace <namespace value> \
    --additionalKey <additionalKey value - optional> \
    --statCode <statCode value> \
    --userIds <userIds value>
```

### Operation AdminListUsersStatItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op adminlistusersstatitems \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation BulkUpdateUserStatItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkupdateuserstatitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkGetOrDefaultByUserId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkgetordefaultbyuserid \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkResetUserStatItemValues
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkresetuserstatitemvalues \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteUserStatItems2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op deleteuserstatitems2 \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional>
```

### Operation UpdateUserStatItemValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op updateuserstatitemvalue \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkUpdateUserStatItem1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkupdateuserstatitem1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryUserStatItems2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op publicqueryuserstatitems2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --statCodes <statCodes value - optional> \
    --tags <tags value - optional>
```

### Operation BulkUpdateUserStatItem2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op bulkupdateuserstatitem2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateUserStatItemValue1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn social \
    --op updateuserstatitemvalue1 \
    --namespace <namespace value> \
    --statCode <statCode value> \
    --userId <userId value> \
    --additionalKey <additionalKey value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

