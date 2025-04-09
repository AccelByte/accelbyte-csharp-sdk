## C# Extend SDK CLI Sample App Operation Index for Dslogmanager service.

### Operation GetServerLogs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op getserverlogs \
    --namespace <namespace value> \
    --podName <podName value> \
    --logType <logType value - optional> \
    --offset <offset value - optional> \
    --origin <origin value - optional>
```

### Operation ListTerminatedServers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op listterminatedservers \
    --namespace <namespace value> \
    --deployment <deployment value - optional> \
    --endDate <endDate value - optional> \
    --gameMode <gameMode value - optional> \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --partyId <partyId value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional> \
    --provider <provider value - optional> \
    --region <region value - optional> \
    --sessionId <sessionId value - optional> \
    --source <source value - optional> \
    --startDate <startDate value - optional> \
    --status <status value - optional> \
    --userId <userId value - optional>
```

### Operation DownloadServerLogs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op downloadserverlogs \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation CheckServerLogs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op checkserverlogs \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation BatchDownloadServerLogs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op batchdownloadserverlogs \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListMetadataServers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op listmetadataservers \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListAllTerminatedServers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op listallterminatedservers \
    --deployment <deployment value - optional> \
    --endDate <endDate value - optional> \
    --gameMode <gameMode value - optional> \
    --limit <limit value - optional> \
    --namespace_ <namespace_ value - optional> \
    --next <next value - optional> \
    --partyId <partyId value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional> \
    --provider <provider value - optional> \
    --region <region value - optional> \
    --sessionId <sessionId value - optional> \
    --startDate <startDate value - optional> \
    --status <status value - optional> \
    --userId <userId value - optional>
```

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dslogmanager \
    --op publicgetmessages \

```

