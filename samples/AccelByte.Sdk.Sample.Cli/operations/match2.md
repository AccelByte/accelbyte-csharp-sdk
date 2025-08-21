## C# Extend SDK CLI Sample App Operation Index for Match2 service.

### Operation GetHealthcheckInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op gethealthcheckinfo \

```

### Operation GetHealthcheckInfoV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op gethealthcheckinfov1 \

```

### Operation AdminGetLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetlogconfig \

```

### Operation AdminPatchUpdateLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op adminpatchupdatelogconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlayFeatureFlag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetplayfeatureflag \
    --namespace <namespace value>
```

### Operation AdminUpsertPlayFeatureFlag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op adminupsertplayfeatureflag \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlayFeatureFlag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admindeleteplayfeatureflag \
    --namespace <namespace value>
```

### Operation AdminGetXRayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetxrayconfig \
    --namespace <namespace value>
```

### Operation AdminUpdateXRayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op adminupdatexrayconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetallconfigv1 \

```

### Operation AdminGetConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetconfigv1 \
    --namespace <namespace value>
```

### Operation AdminPatchConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op adminpatchconfigv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation EnvironmentVariableList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op environmentvariablelist \

```

### Operation AdminQueryBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op adminquerybackfill \
    --namespace <namespace value> \
    --fromTime <fromTime value - optional> \
    --isActive <isActive value - optional> \
    --limit <limit value - optional> \
    --matchPool <matchPool value - optional> \
    --offset <offset value - optional> \
    --playerID <playerID value - optional> \
    --region <region value - optional> \
    --sessionID <sessionID value - optional> \
    --toTime <toTime value - optional>
```

### Operation CreateBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op createbackfill \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetBackfillProposal
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op getbackfillproposal \
    --namespace <namespace value> \
    --sessionID <sessionID value>
```

### Operation GetBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op getbackfill \
    --backfillID <backfillID value> \
    --namespace <namespace value>
```

### Operation DeleteBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op deletebackfill \
    --backfillID <backfillID value> \
    --namespace <namespace value>
```

### Operation AcceptBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op acceptbackfill \
    --backfillID <backfillID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RejectBackfill
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op rejectbackfill \
    --backfillID <backfillID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation MatchFunctionList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchfunctionlist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateMatchFunction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op creatematchfunction \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation MatchFunctionGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchfunctionget \
    --name <name value> \
    --namespace <namespace value>
```

### Operation UpdateMatchFunction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op updatematchfunction \
    --name <name value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteMatchFunction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op deletematchfunction \
    --name <name value> \
    --namespace <namespace value>
```

### Operation MatchPoolList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchpoollist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional>
```

### Operation CreateMatchPool
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op creatematchpool \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation MatchPoolDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchpooldetails \
    --namespace <namespace value> \
    --pool <pool value>
```

### Operation UpdateMatchPool
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op updatematchpool \
    --namespace <namespace value> \
    --pool <pool value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteMatchPool
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op deletematchpool \
    --namespace <namespace value> \
    --pool <pool value>
```

### Operation MatchPoolMetric
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchpoolmetric \
    --namespace <namespace value> \
    --pool <pool value>
```

### Operation PostMatchErrorMetric
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op postmatcherrormetric \
    --namespace <namespace value> \
    --pool <pool value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlayerMetric
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op getplayermetric \
    --namespace <namespace value> \
    --pool <pool value>
```

### Operation AdminGetMatchPoolTickets
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op admingetmatchpooltickets \
    --namespace <namespace value> \
    --pool <pool value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CreateMatchTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op creatematchticket \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetMyMatchTickets
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op getmymatchtickets \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --matchPool <matchPool value - optional> \
    --offset <offset value - optional>
```

### Operation MatchTicketDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op matchticketdetails \
    --namespace <namespace value> \
    --ticketid <ticketid value>
```

### Operation DeleteMatchTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op deletematchticket \
    --namespace <namespace value> \
    --ticketid <ticketid value>
```

### Operation RuleSetList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op rulesetlist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional>
```

### Operation CreateRuleSet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op createruleset \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RuleSetDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op rulesetdetails \
    --namespace <namespace value> \
    --ruleset <ruleset value>
```

### Operation UpdateRuleSet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op updateruleset \
    --namespace <namespace value> \
    --ruleset <ruleset value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteRuleSet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op deleteruleset \
    --namespace <namespace value> \
    --ruleset <ruleset value>
```

### Operation PublicGetPlayerMetric
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op publicgetplayermetric \
    --namespace <namespace value> \
    --pool <pool value>
```

### Operation VersionCheckHandler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn match2 \
    --op versioncheckhandler \

```

