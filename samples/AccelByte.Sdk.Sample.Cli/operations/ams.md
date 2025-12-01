## C# Extend SDK CLI Sample App Operation Index for Ams service.

### Operation AuthCheck
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op authcheck \

```

### Operation PortalHealthCheck
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op portalhealthcheck \

```

### Operation AdminAccountGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op adminaccountget \
    --namespace <namespace value>
```

### Operation AdminAccountCreate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op adminaccountcreate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAccountLinkTokenGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op adminaccountlinktokenget \
    --namespace <namespace value>
```

### Operation AdminAccountLink
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op adminaccountlink \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ArtifactGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op artifactget \
    --namespace <namespace value> \
    --artifactType <artifactType value - optional> \
    --count <count value - optional> \
    --endDate <endDate value - optional> \
    --fleetID <fleetID value - optional> \
    --imageID <imageID value - optional> \
    --maxSize <maxSize value - optional> \
    --minSize <minSize value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --serverId <serverId value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional> \
    --startDate <startDate value - optional> \
    --status <status value - optional>
```

### Operation ArtifactBulkDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op artifactbulkdelete \
    --namespace <namespace value> \
    --artifactType <artifactType value - optional> \
    --fleetId <fleetId value - optional> \
    --uploadedBefore <uploadedBefore value - optional>
```

### Operation ArtifactUsageGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op artifactusageget \
    --namespace <namespace value>
```

### Operation ArtifactDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op artifactdelete \
    --artifactID <artifactID value> \
    --namespace <namespace value>
```

### Operation ArtifactGetURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op artifactgeturl \
    --artifactID <artifactID value> \
    --namespace <namespace value>
```

### Operation DevelopmentServerConfigurationList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op developmentserverconfigurationlist \
    --namespace <namespace value> \
    --count <count value - optional> \
    --imageId <imageId value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional>
```

### Operation DevelopmentServerConfigurationCreate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op developmentserverconfigurationcreate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DevelopmentServerConfigurationGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op developmentserverconfigurationget \
    --developmentServerConfigID <developmentServerConfigID value> \
    --namespace <namespace value>
```

### Operation DevelopmentServerConfigurationDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op developmentserverconfigurationdelete \
    --developmentServerConfigID <developmentServerConfigID value> \
    --namespace <namespace value>
```

### Operation DevelopmentServerConfigurationPatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op developmentserverconfigurationpatch \
    --developmentServerConfigID <developmentServerConfigID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FleetList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetlist \
    --namespace <namespace value> \
    --active <active value - optional> \
    --count <count value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional>
```

### Operation FleetCreate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetcreate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkFleetDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op bulkfleetdelete \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FleetGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetget \
    --fleetID <fleetID value> \
    --namespace <namespace value>
```

### Operation FleetUpdate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetupdate \
    --fleetID <fleetID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FleetDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetdelete \
    --fleetID <fleetID value> \
    --namespace <namespace value>
```

### Operation FleetArtifactSamplingRulesGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetartifactsamplingrulesget \
    --fleetID <fleetID value> \
    --namespace <namespace value>
```

### Operation FleetArtifactSamplingRulesSet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetartifactsamplingrulesset \
    --fleetID <fleetID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FleetServers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetservers \
    --fleetID <fleetID value> \
    --namespace <namespace value> \
    --count <count value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --serverId <serverId value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional> \
    --status <status value - optional>
```

### Operation FleetServerHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetserverhistory \
    --fleetID <fleetID value> \
    --namespace <namespace value> \
    --count <count value - optional> \
    --offset <offset value - optional> \
    --reason <reason value - optional> \
    --region <region value - optional> \
    --serverId <serverId value - optional> \
    --sortDirection <sortDirection value - optional> \
    --status <status value - optional>
```

### Operation ImageList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imagelist \
    --namespace <namespace value> \
    --count <count value - optional> \
    --inUse <inUse value - optional> \
    --isProtected <isProtected value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --sortDirection <sortDirection value - optional> \
    --status <status value - optional> \
    --tag <tag value - optional> \
    --targetArchitecture <targetArchitecture value - optional>
```

### Operation ImagesStorage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imagesstorage \
    --namespace <namespace value>
```

### Operation ImageGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imageget \
    --imageID <imageID value> \
    --namespace <namespace value>
```

### Operation ImageMarkForDeletion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imagemarkfordeletion \
    --imageID <imageID value> \
    --namespace <namespace value>
```

### Operation ImagePatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imagepatch \
    --imageID <imageID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ImageUnmarkForDeletion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op imageunmarkfordeletion \
    --imageID <imageID value> \
    --namespace <namespace value>
```

### Operation QoSRegionsGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op qosregionsget \
    --namespace <namespace value> \
    --status <status value - optional>
```

### Operation QoSRegionsUpdate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op qosregionsupdate \
    --namespace <namespace value> \
    --region <region value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation InfoRegions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op inforegions \
    --namespace <namespace value>
```

### Operation FleetServerInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetserverinfo \
    --namespace <namespace value> \
    --serverID <serverID value>
```

### Operation FleetServerConnectionInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetserverconnectioninfo \
    --namespace <namespace value> \
    --serverID <serverID value>
```

### Operation ServerHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op serverhistory \
    --namespace <namespace value> \
    --serverID <serverID value>
```

### Operation InfoSupportedInstances
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op infosupportedinstances \
    --namespace <namespace value>
```

### Operation AccountGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op accountget \
    --namespace <namespace value>
```

### Operation FleetClaimByID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetclaimbyid \
    --fleetID <fleetID value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation LocalWatchdogConnect
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op localwatchdogconnect \
    --namespace <namespace value> \
    --watchdogID <watchdogID value>
```

### Operation FleetClaimByKeys
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op fleetclaimbykeys \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation WatchdogConnect
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op watchdogconnect \
    --namespace <namespace value> \
    --watchdogID <watchdogID value>
```

### Operation UploadURLGet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op uploadurlget \

```

### Operation Func1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op func1 \

```

### Operation BasicHealthCheck
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn ams \
    --op basichealthcheck \

```

