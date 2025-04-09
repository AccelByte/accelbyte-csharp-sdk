## C# Extend SDK CLI Sample App Operation Index for Gametelemetry service.

### Operation GetNamespacesGameTelemetryV1AdminNamespacesGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gametelemetry \
    --op getnamespacesgametelemetryv1adminnamespacesget \

```

### Operation GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gametelemetry \
    --op geteventsgametelemetryv1adminnamespacesnamespaceeventsget \
    --namespace <namespace value> \
    --deviceType <deviceType value - optional> \
    --endTime <endTime value - optional> \
    --eventId <eventId value - optional> \
    --eventName <eventName value - optional> \
    --eventPayload <eventPayload value - optional> \
    --flightId <flightId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional> \
    --userId <userId value - optional>
```

### Operation ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gametelemetry \
    --op protectedsaveeventsgametelemetryv1protectedeventspost \
    --Cookie <Cookie value - optional> \
        
    --access_token <access_token value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gametelemetry \
    --op protectedgetplaytimegametelemetryv1protectedsteamidssteamidplaytimeget \
    --Cookie <Cookie value - optional> \
        
    --steamId <steamId value> \
    --access_token <access_token value>
```

### Operation ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gametelemetry \
    --op protectedupdateplaytimegametelemetryv1protectedsteamidssteamidplaytimeplaytimeput \
    --Cookie <Cookie value - optional> \
        
    --playtime <playtime value> \
    --steamId <steamId value> \
    --access_token <access_token value>
```

