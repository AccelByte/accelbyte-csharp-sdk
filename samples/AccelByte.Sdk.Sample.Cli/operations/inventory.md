## C# Extend SDK CLI Sample App Operation Index for Inventory service.

### Operation AdminCreateChainingOperations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreatechainingoperations \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListIntegrationConfigurations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlistintegrationconfigurations \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateIntegrationConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreateintegrationconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateIntegrationConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminupdateintegrationconfiguration \
    --integrationConfigurationId <integrationConfigurationId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateStatusIntegrationConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminupdatestatusintegrationconfiguration \
    --integrationConfigurationId <integrationConfigurationId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListInventories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlistinventories \
    --namespace <namespace value> \
    --inventoryConfigurationCode <inventoryConfigurationCode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --userId <userId value - optional>
```

### Operation AdminCreateInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreateinventory \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admingetinventory \
    --inventoryId <inventoryId value> \
    --namespace <namespace value>
```

### Operation AdminUpdateInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminupdateinventory \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op deleteinventory \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlistitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --sourceItemId <sourceItemId value - optional> \
    --tags <tags value - optional>
```

### Operation AdminGetInventoryItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admingetinventoryitem \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --slotId <slotId value> \
    --sourceItemId <sourceItemId value>
```

### Operation AdminListInventoryConfigurations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlistinventoryconfigurations \
    --namespace <namespace value> \
    --code <code value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateInventoryConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreateinventoryconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetInventoryConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admingetinventoryconfiguration \
    --inventoryConfigurationId <inventoryConfigurationId value> \
    --namespace <namespace value>
```

### Operation AdminUpdateInventoryConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminupdateinventoryconfiguration \
    --inventoryConfigurationId <inventoryConfigurationId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteInventoryConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admindeleteinventoryconfiguration \
    --inventoryConfigurationId <inventoryConfigurationId value> \
    --namespace <namespace value>
```

### Operation AdminListItemTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlistitemtypes \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateItemType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreateitemtype \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteItemType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admindeleteitemtype \
    --itemTypeName <itemTypeName value> \
    --namespace <namespace value>
```

### Operation AdminListTags
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminlisttags \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --owner <owner value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation AdminCreateTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admincreatetag \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteTag
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op admindeletetag \
    --namespace <namespace value> \
    --tagName <tagName value>
```

### Operation AdminConsumeUserItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminconsumeuseritem \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --dateRangeValidation <dateRangeValidation value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkUpdateMyItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminbulkupdatemyitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSaveItemToInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminsaveitemtoinventory \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkRemoveItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminbulkremoveitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkSaveItemToInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminbulksaveitemtoinventory \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateUserInventoriesByInventoryCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminupdateuserinventoriesbyinventorycode \
    --inventoryConfigurationCode <inventoryConfigurationCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSaveItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminsaveitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkSaveItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminbulksaveitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSyncUserEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminsyncuserentitlements \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPurchasable
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op adminpurchasable \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicListInventoryConfigurations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publiclistinventoryconfigurations \
    --namespace <namespace value> \
    --code <code value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListItemTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publiclistitemtypes \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListTags
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publiclisttags \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicListInventories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publiclistinventories \
    --namespace <namespace value> \
    --inventoryConfigurationCode <inventoryConfigurationCode value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation PublicConsumeMyItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publicconsumemyitem \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicListItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publiclistitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --sourceItemId <sourceItemId value - optional> \
    --tags <tags value - optional>
```

### Operation PublicBulkUpdateMyItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publicbulkupdatemyitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicBulkRemoveMyItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publicbulkremovemyitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicMoveMyItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publicmovemyitems \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn inventory \
    --op publicgetitem \
    --inventoryId <inventoryId value> \
    --namespace <namespace value> \
    --slotId <slotId value> \
    --sourceItemId <sourceItemId value>
```

