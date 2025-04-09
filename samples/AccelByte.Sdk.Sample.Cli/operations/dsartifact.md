## C# Extend SDK CLI Sample App Operation Index for Dsartifact service.

### Operation ListNodesIPAddress
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listnodesipaddress \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --nodeIP <nodeIP value - optional> \
    --previous <previous value - optional>
```

### Operation DeleteNodeByID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op deletenodebyid \
    --nodeIP <nodeIP value> \
    --podName <podName value>
```

### Operation ListQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listqueue \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --previous <previous value - optional> \
    --nodeIP <nodeIP value>
```

### Operation GetActiveQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op getactivequeue \
    --nodeIP <nodeIP value>
```

### Operation SetActiveQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op setactivequeue \
    --nodeIP <nodeIP value> \
    --podName <podName value>
```

### Operation DeleteActiveQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op deleteactivequeue \
    --nodeIP <nodeIP value>
```

### Operation ReportFailedUpload
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op reportfailedupload \
    --nodeIP <nodeIP value> \
    --podName <podName value>
```

### Operation DeleteQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op deletequeue \
    --namespace <namespace value> \
    --nodeIP <nodeIP value> \
    --podName <podName value>
```

### Operation ListAllActiveQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listallactivequeue \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --nodeIP <nodeIP value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional>
```

### Operation ListAllQueue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listallqueue \
    --namespace <namespace value> \
    --excludeUploading <excludeUploading value - optional> \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --nodeIP <nodeIP value - optional> \
    --order <order value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional>
```

### Operation ListTerminatedServersWithNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listterminatedserverswithnamespace \
    --namespace <namespace value> \
    --deployment <deployment value - optional> \
    --gameMode <gameMode value - optional> \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --partyId <partyId value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional> \
    --provider <provider value - optional> \
    --region <region value - optional> \
    --sessionId <sessionId value - optional> \
    --userId <userId value - optional>
```

### Operation DownloadServerArtifacts
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op downloadserverartifacts \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation CheckServerArtifact
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op checkserverartifact \
    --namespace <namespace value> \
    --podName <podName value>
```

### Operation ListTerminatedServers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op listterminatedservers \
    --deployment <deployment value - optional> \
    --gameMode <gameMode value - optional> \
    --limit <limit value - optional> \
    --next <next value - optional> \
    --partyId <partyId value - optional> \
    --podName <podName value - optional> \
    --previous <previous value - optional> \
    --provider <provider value - optional> \
    --region <region value - optional> \
    --sessionId <sessionId value - optional> \
    --userId <userId value - optional>
```

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn dsartifact \
    --op publicgetmessages \

```

