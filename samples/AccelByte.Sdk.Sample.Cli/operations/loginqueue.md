## C# Extend SDK CLI Sample App Operation Index for Loginqueue service.

### Operation AdminGetConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn loginqueue \
    --op admingetconfiguration \
    --namespace <namespace value>
```

### Operation AdminUpdateConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn loginqueue \
    --op adminupdateconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn loginqueue \
    --op admingetstatus \
    --namespace <namespace value>
```

### Operation RefreshTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn loginqueue \
    --op refreshticket \
    --namespace <namespace value>
```

### Operation CancelTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn loginqueue \
    --op cancelticket \
    --namespace <namespace value>
```

