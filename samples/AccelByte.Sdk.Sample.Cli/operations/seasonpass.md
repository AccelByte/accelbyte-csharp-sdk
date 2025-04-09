## C# Extend SDK CLI Sample App Operation Index for Seasonpass service.

### Operation ExportSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op exportseason \
    --namespace <namespace value>
```

### Operation QuerySeasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op queryseasons \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional>
```

### Operation CreateSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op createseason \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetCurrentSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getcurrentseason \
    --namespace <namespace value>
```

### Operation BulkGetUserSeasonProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op bulkgetuserseasonprogression \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetItemReferences
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getitemreferences \
    --namespace <namespace value> \
    --itemId <itemId value>
```

### Operation GetSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getseason \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation DeleteSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op deleteseason \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation UpdateSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op updateseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CloneSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op cloneseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetFullSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getfullseason \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation QueryPasses
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op querypasses \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation CreatePass
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op createpass \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPass
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getpass \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation DeletePass
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op deletepass \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation UpdatePass
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op updatepass \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublishSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publishseason \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation RetireSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op retireseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --force <force value - optional>
```

### Operation QueryRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op queryrewards \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --q <q value - optional>
```

### Operation CreateReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op createreward \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getreward \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation DeleteReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op deletereward \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation UpdateReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op updatereward \
    --code <code value> \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryTiers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op querytiers \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op createtier \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op updatetier \
    --id <id value> \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op deletetier \
    --id <id value> \
    --namespace <namespace value> \
    --seasonId <seasonId value>
```

### Operation ReorderTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op reordertier \
    --id <id value> \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UnpublishSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op unpublishseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --force <force value - optional>
```

### Operation GetUserParticipatedSeasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getuserparticipatedseasons \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GrantUserExp
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op grantuserexp \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GrantUserPass
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op grantuserpass \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExistsAnyPassByPassCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op existsanypassbypasscodes \
    --namespace <namespace value> \
    --userId <userId value> \
    --passCodes <passCodes value - optional>
```

### Operation GetCurrentUserSeasonProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getcurrentuserseasonprogression \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation CheckSeasonPurchasable
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op checkseasonpurchasable \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ResetUserSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op resetuserseason \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GrantUserTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op grantusertier \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryUserExpGrantHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op queryuserexpgranthistory \
    --namespace <namespace value> \
    --userId <userId value> \
    --from <from value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --seasonId <seasonId value - optional> \
    --source <source value - optional> \
    --tags <tags value - optional> \
    --to <to value - optional>
```

### Operation QueryUserExpGrantHistoryTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op queryuserexpgranthistorytag \
    --namespace <namespace value> \
    --userId <userId value> \
    --seasonId <seasonId value - optional>
```

### Operation GetUserSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op getuserseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --userId <userId value>
```

### Operation PublicGetCurrentSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publicgetcurrentseason \
    --namespace <namespace value> \
    --language <language value - optional>
```

### Operation PublicGetCurrentUserSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publicgetcurrentuserseason \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicClaimUserReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publicclaimuserreward \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicBulkClaimUserRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publicbulkclaimuserrewards \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicGetUserSeason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn seasonpass \
    --op publicgetuserseason \
    --namespace <namespace value> \
    --seasonId <seasonId value> \
    --userId <userId value>
```

