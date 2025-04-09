## C# Extend SDK CLI Sample App Operation Index for Reporting service.

### Operation AdminFindActionList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op adminfindactionlist \

```

### Operation AdminCreateModAction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admincreatemodaction \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminFindExtensionCategoryList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op adminfindextensioncategorylist \
    --order <order value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateExtensionCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admincreateextensioncategory \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation Get
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op get \
    --namespace <namespace value> \
    --category <category value - optional>
```

### Operation Upsert
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op upsert \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListReasonGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op adminlistreasongroups \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateReasonGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op createreasongroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetReasonGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op getreasongroup \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation DeleteReasonGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op deletereasongroup \
    --groupId <groupId value> \
    --namespace <namespace value>
```

### Operation UpdateReasonGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op updatereasongroup \
    --groupId <groupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetReasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admingetreasons \
    --namespace <namespace value> \
    --group <group value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --title <title value - optional>
```

### Operation CreateReason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op createreason \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllReasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admingetallreasons \
    --namespace <namespace value>
```

### Operation AdminGetUnusedReasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admingetunusedreasons \
    --namespace <namespace value> \
    --extensionCategory <extensionCategory value - optional> \
    --category <category value>
```

### Operation AdminGetReason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op admingetreason \
    --namespace <namespace value> \
    --reasonId <reasonId value>
```

### Operation DeleteReason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op deletereason \
    --namespace <namespace value> \
    --reasonId <reasonId value>
```

### Operation UpdateReason
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op updatereason \
    --namespace <namespace value> \
    --reasonId <reasonId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListReports
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op listreports \
    --namespace <namespace value> \
    --category <category value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --reportedUserId <reportedUserId value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminSubmitReport
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op adminsubmitreport \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateModerationRule
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op createmoderationrule \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateModerationRule
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op updatemoderationrule \
    --namespace <namespace value> \
    --ruleId <ruleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteModerationRule
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op deletemoderationrule \
    --namespace <namespace value> \
    --ruleId <ruleId value>
```

### Operation UpdateModerationRuleStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op updatemoderationrulestatus \
    --namespace <namespace value> \
    --ruleId <ruleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetModerationRules
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op getmoderationrules \
    --namespace <namespace value> \
    --category <category value - optional> \
    --extensionCategory <extensionCategory value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetModerationRuleDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op getmoderationruledetails \
    --namespace <namespace value> \
    --ruleId <ruleId value>
```

### Operation ListTickets
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op listtickets \
    --namespace <namespace value> \
    --category <category value - optional> \
    --extensionCategory <extensionCategory value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --reportedUserId <reportedUserId value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional>
```

### Operation TicketStatistic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op ticketstatistic \
    --namespace <namespace value> \
    --extensionCategory <extensionCategory value - optional> \
    --category <category value>
```

### Operation GetTicketDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op getticketdetail \
    --namespace <namespace value> \
    --ticketId <ticketId value>
```

### Operation DeleteTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op deleteticket \
    --namespace <namespace value> \
    --ticketId <ticketId value>
```

### Operation GetReportsByTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op getreportsbyticket \
    --namespace <namespace value> \
    --ticketId <ticketId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation UpdateTicketResolutions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op updateticketresolutions \
    --namespace <namespace value> \
    --ticketId <ticketId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicListReasonGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op publiclistreasongroups \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicGetReasons
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op publicgetreasons \
    --namespace <namespace value> \
    --group <group value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --title <title value - optional>
```

### Operation SubmitReport
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn reporting \
    --op submitreport \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

