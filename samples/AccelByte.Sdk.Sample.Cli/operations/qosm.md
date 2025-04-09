## C# Extend SDK CLI Sample App Operation Index for Qosm service.

### Operation UpdateServerConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op updateserverconfig \
    --namespace <namespace value> \
    --region <region value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op deleteserver \
    --region <region value>
```

### Operation SetServerAlias
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op setserveralias \
    --region <region value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListServerPerNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op listserverpernamespace \
    --namespace <namespace value> \
    --status <status value - optional>
```

### Operation ListServer
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op listserver \

```

### Operation Heartbeat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn qosm \
    --op heartbeat \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

