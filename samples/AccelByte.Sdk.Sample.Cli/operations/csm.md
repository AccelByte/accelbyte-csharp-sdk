## C# Extend SDK CLI Sample App Operation Index for Csm service.

### Operation GetAppReleaseV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getappreleasev1 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op publicgetmessages \

```

### Operation GetAppListV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getapplistv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getappv2 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation CreateAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op createappv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deleteappv2 \
    --app <app value> \
    --namespace <namespace value> \
    --forced <forced value - optional>
```

### Operation UpdateAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updateappv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateDeploymentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op createdeploymentv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAppImageListV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getappimagelistv2 \
    --app <app value> \
    --namespace <namespace value> \
    --cached <cached value - optional>
```

### Operation DeleteAppImagesV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deleteappimagesv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateNoSQLDatabaseCredentialV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op createnosqldatabasecredentialv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetNoSQLDatabaseV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getnosqldatabasev2 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation CreateNoSQLDatabaseV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op createnosqldatabasev2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteNoSQLDatabaseV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletenosqldatabasev2 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation UpdateAppResourcesV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updateappresourcesv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateAppResourcesResourceLimitFormV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updateappresourcesresourcelimitformv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetListOfSecretsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getlistofsecretsv2 \
    --app <app value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation SaveSecretV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op savesecretv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateSecretV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updatesecretv2 \
    --app <app value> \
    --configId <configId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteSecretV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletesecretv2 \
    --app <app value> \
    --configId <configId value> \
    --namespace <namespace value>
```

### Operation StartAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op startappv2 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation StopAppV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op stopappv2 \
    --app <app value> \
    --namespace <namespace value>
```

### Operation GetNotificationSubscriberListV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getnotificationsubscriberlistv2 \
    --app <app value> \
    --namespace <namespace value> \
    --notificationType <notificationType value>
```

### Operation BulkSaveSubscriptionAppNotificationV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op bulksavesubscriptionappnotificationv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SubscribeAppNotificationV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op subscribeappnotificationv2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSubscriptionV2Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getsubscriptionv2handler \
    --app <app value> \
    --namespace <namespace value>
```

### Operation SubscribeV2Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op subscribev2handler \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UnsubscribeV2Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op unsubscribev2handler \
    --app <app value> \
    --namespace <namespace value>
```

### Operation DeleteSubscriptionAppNotificationByUserIDV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletesubscriptionappnotificationbyuseridv2 \
    --app <app value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetListOfVariablesV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getlistofvariablesv2 \
    --app <app value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation SaveVariableV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op savevariablev2 \
    --app <app value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateVariableV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updatevariablev2 \
    --app <app value> \
    --configId <configId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteVariableV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletevariablev2 \
    --app <app value> \
    --configId <configId value> \
    --namespace <namespace value>
```

### Operation GetListOfDeploymentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getlistofdeploymentv2 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetDeploymentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getdeploymentv2 \
    --deploymentId <deploymentId value> \
    --namespace <namespace value>
```

### Operation DeleteDeploymentV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletedeploymentv2 \
    --deploymentId <deploymentId value> \
    --namespace <namespace value>
```

### Operation GetNoSQLClusterV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getnosqlclusterv2 \
    --namespace <namespace value>
```

### Operation UpdateNoSQLClusterV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op updatenosqlclusterv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateNoSQLClusterV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op createnosqlclusterv2 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteNoSQLClusterV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletenosqlclusterv2 \
    --namespace <namespace value>
```

### Operation GetNoSQLAccessTunnelV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getnosqlaccesstunnelv2 \
    --namespace <namespace value>
```

### Operation GetResourcesLimits
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getresourceslimits \
    --namespace <namespace value>
```

### Operation GetNotificationSubscriberListV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op getnotificationsubscriberlistv3 \
    --app <app value> \
    --namespace <namespace value> \
    --notificationType <notificationType value>
```

### Operation DeleteSubscriptionAppNotificationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn csm \
    --op deletesubscriptionappnotificationv3 \
    --app <app value> \
    --namespace <namespace value> \
    --emailAddress <emailAddress value - optional> \
    --userId <userId value - optional>
```

