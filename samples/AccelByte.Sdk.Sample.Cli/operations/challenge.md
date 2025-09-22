## C# Extend SDK CLI Sample App Operation Index for Challenge service.

### Operation AdminGetChallenges
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetchallenges \
    --namespace <namespace value> \
    --keyword <keyword value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional> \
    --tags <tags value - optional>
```

### Operation AdminCreateChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admincreatechallenge \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetItemReferences
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetitemreferences \
    --namespace <namespace value> \
    --itemId <itemId value>
```

### Operation AdminGetActiveChallenges
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetactivechallenges \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminGetChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetchallenge \
    --challengeCode <challengeCode value> \
    --namespace <namespace value>
```

### Operation AdminUpdateChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminupdatechallenge \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admindeletechallenge \
    --challengeCode <challengeCode value> \
    --namespace <namespace value>
```

### Operation AdminGetGoals
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetgoals \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation AdminCreateGoal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admincreategoal \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetGoal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetgoal \
    --challengeCode <challengeCode value> \
    --code <code value> \
    --namespace <namespace value>
```

### Operation AdminUpdateGoals
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminupdategoals \
    --challengeCode <challengeCode value> \
    --code <code value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteGoal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admindeletegoal \
    --challengeCode <challengeCode value> \
    --code <code value> \
    --namespace <namespace value>
```

### Operation AdminListSchedulesByGoal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminlistschedulesbygoal \
    --challengeCode <challengeCode value> \
    --code <code value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --userId <userId value - optional>
```

### Operation AdminGetPeriods
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetperiods \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminRandomizeChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminrandomizechallenge \
    --challengeCode <challengeCode value> \
    --namespace <namespace value>
```

### Operation AdminListSchedules
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminlistschedules \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --dateTime <dateTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --userId <userId value - optional>
```

### Operation AdminDeleteTiedChallenge
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admindeletetiedchallenge \
    --challengeCode <challengeCode value> \
    --namespace <namespace value>
```

### Operation AdminUpdateTiedChallengeSchedule
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminupdatetiedchallengeschedule \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAssignmentPlugin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetassignmentplugin \
    --namespace <namespace value>
```

### Operation AdminUpdateAssignmentPlugin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminupdateassignmentplugin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCreateAssignmentPlugin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admincreateassignmentplugin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteAssignmentPlugin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admindeleteassignmentplugin \
    --namespace <namespace value>
```

### Operation AdminEvaluateProgress
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminevaluateprogress \
    --namespace <namespace value> \
    --challengeCode <challengeCode value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminClaimUsersRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminclaimusersrewards \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminClaimUserRewardsByGoalCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminclaimuserrewardsbygoalcode \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetuserprogression \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --dateTime <dateTime value - optional> \
    --goalCode <goalCode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation AdminGetUserRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op admingetuserrewards \
    --namespace <namespace value> \
    --userId <userId value> \
    --challengeCode <challengeCode value - optional> \
    --goalProgressionId <goalProgressionId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation AdminClaimUserRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op adminclaimuserrewards \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetChallenges
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op getchallenges \
    --namespace <namespace value> \
    --keyword <keyword value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional> \
    --tags <tags value - optional>
```

### Operation PublicGetScheduledGoals
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicgetscheduledgoals \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --tags <tags value - optional>
```

### Operation PublicListSchedulesByGoal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publiclistschedulesbygoal \
    --challengeCode <challengeCode value> \
    --code <code value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicListSchedules
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publiclistschedules \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --dateTime <dateTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicClaimUserRewardsByGoalCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicclaimuserrewardsbygoalcode \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation EvaluateMyProgress
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op evaluatemyprogress \
    --namespace <namespace value> \
    --challengeCode <challengeCode value - optional>
```

### Operation PublicGetUserProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicgetuserprogression \
    --challengeCode <challengeCode value> \
    --namespace <namespace value> \
    --dateTime <dateTime value - optional> \
    --goalCode <goalCode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation PublicGetPastUserProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicgetpastuserprogression \
    --challengeCode <challengeCode value> \
    --index <index value> \
    --namespace <namespace value> \
    --goalCode <goalCode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation PublicGetUserRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicgetuserrewards \
    --namespace <namespace value> \
    --challengeCode <challengeCode value - optional> \
    --goalProgressionId <goalProgressionId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation PublicClaimUserRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn challenge \
    --op publicclaimuserrewards \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

