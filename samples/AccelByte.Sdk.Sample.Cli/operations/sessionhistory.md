## C# Extend SDK CLI Sample App Operation Index for Sessionhistory service.

### Operation GetHealthcheckInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op gethealthcheckinfo \

```

### Operation GetHealthcheckInfoV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op gethealthcheckinfov1 \

```

### Operation AdminGetEnvConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op admingetenvconfig \

```

### Operation AdminPatchUpdateEnvConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminpatchupdateenvconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op admingetlogconfig \

```

### Operation AdminPatchUpdateLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminpatchupdatelogconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminQueryGameSessionDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminquerygamesessiondetail \
    --namespace <namespace value> \
    --completedOnly <completedOnly value - optional> \
    --configurationName <configurationName value - optional> \
    --dsPodName <dsPodName value - optional> \
    --endDate <endDate value - optional> \
    --gameSessionID <gameSessionID value - optional> \
    --isPersistent <isPersistent value - optional> \
    --joinability <joinability value - optional> \
    --limit <limit value - optional> \
    --matchPool <matchPool value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --startDate <startDate value - optional> \
    --statusV2 <statusV2 value - optional> \
    --userID <userID value - optional>
```

### Operation GetGameSessionDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op getgamesessiondetail \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminQueryMatchmakingDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminquerymatchmakingdetail \
    --namespace <namespace value> \
    --gameSessionID <gameSessionID value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --ticketID <ticketID value - optional> \
    --userID <userID value - optional>
```

### Operation AdminGetMatchmakingDetailBySessionID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op admingetmatchmakingdetailbysessionid \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminGetMatchmakingDetailByTicketID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op admingetmatchmakingdetailbyticketid \
    --namespace <namespace value> \
    --ticketId <ticketId value>
```

### Operation AdminQueryPartyDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminquerypartydetail \
    --namespace <namespace value> \
    --endDate <endDate value - optional> \
    --joinability <joinability value - optional> \
    --leaderID <leaderID value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --orderBy <orderBy value - optional> \
    --partyID <partyID value - optional> \
    --startDate <startDate value - optional> \
    --userID <userID value - optional>
```

### Operation GetPartyDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op getpartydetail \
    --namespace <namespace value> \
    --sessionId <sessionId value>
```

### Operation AdminQueryTicketDetail
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminqueryticketdetail \
    --namespace <namespace value> \
    --endDate <endDate value - optional> \
    --gameMode <gameMode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --partyID <partyID value - optional> \
    --region <region value - optional> \
    --startDate <startDate value - optional> \
    --userIDs <userIDs value - optional>
```

### Operation AdminTicketDetailGetByTicketID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op adminticketdetailgetbyticketid \
    --namespace <namespace value> \
    --ticketId <ticketId value>
```

### Operation PublicQueryGameSessionMe
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op publicquerygamesessionme \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional>
```

### Operation QueryXrayMatchPool
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryxraymatchpool \
    --namespace <namespace value> \
    --poolName <poolName value> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryDetailTickMatchPool
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querydetailtickmatchpool \
    --namespace <namespace value> \
    --podName <podName value> \
    --poolName <poolName value> \
    --all <all value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryDetailTickMatchPoolMatches
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querydetailtickmatchpoolmatches \
    --namespace <namespace value> \
    --podName <podName value> \
    --poolName <poolName value> \
    --tickId <tickId value>
```

### Operation QueryDetailTickMatchPoolTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querydetailtickmatchpoolticket \
    --namespace <namespace value> \
    --podName <podName value> \
    --poolName <poolName value> \
    --tickId <tickId value>
```

### Operation QueryMatchHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querymatchhistories \
    --matchId <matchId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation QueryMatchTicketHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querymatchtickethistories \
    --matchId <matchId value> \
    --namespace <namespace value>
```

### Operation QueryXrayMatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryxraymatch \
    --matchId <matchId value> \
    --namespace <namespace value>
```

### Operation QueryAcquiringDS
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryacquiringds \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryAcquiringDSWaitTimeAvg
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryacquiringdswaittimeavg \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryMatchLengthDurationpAvg
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querymatchlengthdurationpavg \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryMatchLengthDurationp99
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querymatchlengthdurationp99 \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalActiveSession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalactivesession \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --region <region value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalMatchmakingMatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalmatchmakingmatch \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalPlayerPersession
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalplayerpersession \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalMatchmakingCanceled
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalmatchmakingcanceled \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalMatchmakingCreated
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalmatchmakingcreated \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalMatchmakingExpired
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalmatchmakingexpired \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryTotalMatchmakingMatchTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op querytotalmatchmakingmatchticket \
    --namespace <namespace value> \
    --matchPool <matchPool value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation CreateXrayTicketObservability
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op createxrayticketobservability \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateXrayBulkTicketObservability
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op createxraybulkticketobservability \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryXrayTimelineByTicketID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryxraytimelinebyticketid \
    --namespace <namespace value> \
    --ticketId <ticketId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

### Operation QueryXrayTimelineByUserID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn sessionhistory \
    --op queryxraytimelinebyuserid \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --endDate <endDate value> \
    --startDate <startDate value>
```

