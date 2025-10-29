## C# Extend SDK CLI Sample App Operation Index for Platform service.

### Operation ListFulfillmentScripts
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listfulfillmentscripts \

```

### Operation GetFulfillmentScript
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getfulfillmentscript \
    --id <id value>
```

### Operation CreateFulfillmentScript
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createfulfillmentscript \
    --id <id value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteFulfillmentScript
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletefulfillmentscript \
    --id <id value>
```

### Operation UpdateFulfillmentScript
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatefulfillmentscript \
    --id <id value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListItemTypeConfigs
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listitemtypeconfigs \

```

### Operation CreateItemTypeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createitemtypeconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SearchItemTypeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op searchitemtypeconfig \
    --clazz <clazz value - optional> \
    --itemType <itemType value>
```

### Operation GetItemTypeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitemtypeconfig \
    --id <id value>
```

### Operation UpdateItemTypeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateitemtypeconfig \
    --id <id value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteItemTypeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteitemtypeconfig \
    --id <id value>
```

### Operation QueryCampaigns
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querycampaigns \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --tag <tag value - optional>
```

### Operation CreateCampaign
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createcampaign \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetCampaign
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcampaign \
    --campaignId <campaignId value> \
    --namespace <namespace value>
```

### Operation UpdateCampaign
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatecampaign \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RenameBatch
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op renamebatch \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryCampaignBatchNames
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querycampaignbatchnames \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --batchName <batchName value - optional> \
    --limit <limit value - optional>
```

### Operation GetCampaignDynamic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcampaigndynamic \
    --campaignId <campaignId value> \
    --namespace <namespace value>
```

### Operation GetCatalogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcatalogconfig \
    --namespace <namespace value>
```

### Operation UpdateCatalogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatecatalogconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetLootBoxPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getlootboxpluginconfig \
    --namespace <namespace value>
```

### Operation UpdateLootBoxPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatelootboxpluginconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteLootBoxPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletelootboxpluginconfig \
    --namespace <namespace value>
```

### Operation UplodLootBoxPluginConfigCert
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op uplodlootboxpluginconfigcert \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetLootBoxGrpcInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getlootboxgrpcinfo \
    --namespace <namespace value> \
    --force <force value - optional>
```

### Operation GetSectionPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getsectionpluginconfig \
    --namespace <namespace value>
```

### Operation UpdateSectionPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatesectionpluginconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteSectionPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletesectionpluginconfig \
    --namespace <namespace value>
```

### Operation UploadSectionPluginConfigCert
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op uploadsectionpluginconfigcert \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetRootCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getrootcategories \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation CreateCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createcategory \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListCategoriesBasic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listcategoriesbasic \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation GetCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcategory \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation UpdateCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatecategory \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletecategory \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation GetChildCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getchildcategories \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation GetDescendantCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getdescendantcategories \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation QueryCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querycodes \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --batchName <batchName value - optional> \
    --batchNo <batchNo value - optional> \
    --code <code value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --withBatchName <withBatchName value - optional>
```

### Operation CreateCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createcodes \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation Download
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op download \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --batchName <batchName value - optional> \
    --batchNo <batchNo value - optional> \
    --withBatchName <withBatchName value - optional>
```

### Operation BulkDisableCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkdisablecodes \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --batchName <batchName value - optional> \
    --batchNo <batchNo value - optional>
```

### Operation BulkEnableCodes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkenablecodes \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --batchName <batchName value - optional> \
    --batchNo <batchNo value - optional>
```

### Operation QueryRedeemHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryredeemhistory \
    --campaignId <campaignId value> \
    --namespace <namespace value> \
    --code <code value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --userId <userId value - optional>
```

### Operation GetCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcode \
    --code <code value> \
    --namespace <namespace value> \
    --redeemable <redeemable value - optional> \
    --withBatchName <withBatchName value - optional>
```

### Operation DisableCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op disablecode \
    --code <code value> \
    --namespace <namespace value>
```

### Operation EnableCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op enablecode \
    --code <code value> \
    --namespace <namespace value>
```

### Operation ListCurrencies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listcurrencies \
    --namespace <namespace value> \
    --currencyType <currencyType value - optional>
```

### Operation CreateCurrency
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createcurrency \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateCurrency
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatecurrency \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteCurrency
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletecurrency \
    --currencyCode <currencyCode value> \
    --namespace <namespace value>
```

### Operation GetCurrencyConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcurrencyconfig \
    --currencyCode <currencyCode value> \
    --namespace <namespace value>
```

### Operation GetCurrencySummary
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcurrencysummary \
    --currencyCode <currencyCode value> \
    --namespace <namespace value>
```

### Operation GetDLCItemConfigHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getdlcitemconfighistory \
    --namespace <namespace value> \
    --dlcId <dlcId value>
```

### Operation RestoreDLCItemConfigHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op restoredlcitemconfighistory \
    --id <id value> \
    --namespace <namespace value>
```

### Operation GetDLCItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getdlcitemconfig \
    --namespace <namespace value>
```

### Operation UpdateDLCItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatedlcitemconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteDLCItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletedlcitemconfig \
    --namespace <namespace value>
```

### Operation GetPlatformDLCConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getplatformdlcconfig \
    --namespace <namespace value>
```

### Operation UpdatePlatformDLCConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateplatformdlcconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePlatformDLCConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteplatformdlcconfig \
    --namespace <namespace value>
```

### Operation QueryEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryentitlements \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --appType <appType value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --entitlementName <entitlementName value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --origin <origin value - optional> \
    --userId <userId value - optional>
```

### Operation QueryEntitlementsByItemIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryentitlementsbyitemids \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --itemIds <itemIds value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation EnableEntitlementOriginFeature
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op enableentitlementoriginfeature \
    --namespace <namespace value>
```

### Operation GetEntitlementConfigInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getentitlementconfiginfo \
    --namespace <namespace value> \
    --withoutCache <withoutCache value - optional>
```

### Operation GrantEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op grantentitlements \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RevokeEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeentitlements \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value>
```

### Operation QueryFulfillmentHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryfulfillmenthistories \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional> \
    --userId <userId value - optional>
```

### Operation QueryIAPClawbackHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryiapclawbackhistory \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --eventType <eventType value - optional> \
    --externalOrderId <externalOrderId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional> \
    --status <status value - optional> \
    --userId <userId value - optional>
```

### Operation MockPlayStationStreamEvent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op mockplaystationstreamevent \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation MockXblClawbackEvent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op mockxblclawbackevent \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAppleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getappleiapconfig \
    --namespace <namespace value>
```

### Operation UpdateAppleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateappleiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteAppleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteappleiapconfig \
    --namespace <namespace value>
```

### Operation UpdateAppleP8File
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateapplep8file \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetEpicGamesIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getepicgamesiapconfig \
    --namespace <namespace value>
```

### Operation UpdateEpicGamesIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateepicgamesiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteEpicGamesIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteepicgamesiapconfig \
    --namespace <namespace value>
```

### Operation GetGoogleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getgoogleiapconfig \
    --namespace <namespace value>
```

### Operation UpdateGoogleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updategoogleiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGoogleIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletegoogleiapconfig \
    --namespace <namespace value>
```

### Operation UpdateGoogleP12File
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updategooglep12file \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetIAPItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getiapitemconfig \
    --namespace <namespace value>
```

### Operation UpdateIAPItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateiapitemconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteIAPItemConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteiapitemconfig \
    --namespace <namespace value>
```

### Operation GetOculusIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getoculusiapconfig \
    --namespace <namespace value>
```

### Operation UpdateOculusIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateoculusiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteOculusIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteoculusiapconfig \
    --namespace <namespace value>
```

### Operation ListOculusSubscriptionGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listoculussubscriptiongroups \
    --namespace <namespace value>
```

### Operation CreateOculusSubscriptionGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createoculussubscriptiongroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteOculusSubscriptionGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteoculussubscriptiongroup \
    --namespace <namespace value> \
    --sku <sku value>
```

### Operation ListOculusSubscriptionGroupTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listoculussubscriptiongrouptier \
    --namespace <namespace value> \
    --sku <sku value>
```

### Operation AddTierIntoMetaQuestSubscriptionGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op addtierintometaquestsubscriptiongroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteOculusSubscriptionTier
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteoculussubscriptiontier \
    --namespace <namespace value> \
    --sku <sku value>
```

### Operation GetPlayStationIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getplaystationiapconfig \
    --namespace <namespace value>
```

### Operation UpdatePlaystationIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateplaystationiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePlaystationIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteplaystationiapconfig \
    --namespace <namespace value>
```

### Operation ValidateExistedPlaystationIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op validateexistedplaystationiapconfig \
    --namespace <namespace value>
```

### Operation ValidatePlaystationIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op validateplaystationiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSteamIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getsteamiapconfig \
    --namespace <namespace value>
```

### Operation UpdateSteamIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatesteamiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteSteamIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletesteamiapconfig \
    --namespace <namespace value>
```

### Operation GetTwitchIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op gettwitchiapconfig \
    --namespace <namespace value>
```

### Operation UpdateTwitchIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatetwitchiapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteTwitchIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletetwitchiapconfig \
    --namespace <namespace value>
```

### Operation GetXblIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getxbliapconfig \
    --namespace <namespace value>
```

### Operation UpdateXblIAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatexbliapconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteXblAPConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletexblapconfig \
    --namespace <namespace value>
```

### Operation UpdateXblBPCertFile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatexblbpcertfile \
    --namespace <namespace value> \
    --upload file <file to upload> \
    --password <password value - optional>
```

### Operation QueryThirdPartyNotifications
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querythirdpartynotifications \
    --namespace <namespace value> \
    --endDate <endDate value - optional> \
    --externalId <externalId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --source <source value - optional> \
    --startDate <startDate value - optional> \
    --status <status value - optional> \
    --type <type value - optional>
```

### Operation QueryAbnormalTransactions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryabnormaltransactions \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --orderId <orderId value - optional> \
    --steamId <steamId value - optional>
```

### Operation AdminGetSteamJobInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op admingetsteamjobinfo \
    --namespace <namespace value>
```

### Operation AdminResetSteamJobTime
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op adminresetsteamjobtime \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRefundIAPOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op adminrefundiaporder \
    --iapOrderNo <iapOrderNo value> \
    --namespace <namespace value>
```

### Operation QuerySteamReportHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querysteamreporthistories \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --orderId <orderId value - optional> \
    --processStatus <processStatus value - optional> \
    --steamId <steamId value - optional>
```

### Operation QueryThirdPartySubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querythirdpartysubscription \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --groupId <groupId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platform <platform value - optional> \
    --productId <productId value - optional> \
    --userId <userId value - optional>
```

### Operation GetIAPOrderConsumeDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getiaporderconsumedetails \
    --iapOrderNo <iapOrderNo value> \
    --namespace <namespace value>
```

### Operation DownloadInvoiceDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op downloadinvoicedetails \
    --namespace <namespace value> \
    --endTime <endTime value> \
    --feature <feature value> \
    --itemId <itemId value> \
    --itemType <itemType value> \
    --startTime <startTime value>
```

### Operation GenerateInvoiceSummary
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op generateinvoicesummary \
    --namespace <namespace value> \
    --endTime <endTime value> \
    --feature <feature value> \
    --itemId <itemId value> \
    --itemType <itemType value> \
    --startTime <startTime value>
```

### Operation SyncInGameItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncingameitem \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createitem \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetItemByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitembyappid \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional> \
    --appId <appId value>
```

### Operation QueryItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryitems \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --appType <appType value - optional> \
    --availableDate <availableDate value - optional> \
    --baseAppId <baseAppId value - optional> \
    --categoryPath <categoryPath value - optional> \
    --features <features value - optional> \
    --includeSubCategoryItem <includeSubCategoryItem value - optional> \
    --itemType <itemType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --sortBy <sortBy value - optional> \
    --storeId <storeId value - optional> \
    --tags <tags value - optional> \
    --targetNamespace <targetNamespace value - optional>
```

### Operation ListBasicItemsByFeatures
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listbasicitemsbyfeatures \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --features <features value - optional>
```

### Operation GetItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitems \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional> \
    --itemIds <itemIds value>
```

### Operation GetItemBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitembysku \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional> \
    --sku <sku value>
```

### Operation GetLocaleItemBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getlocaleitembysku \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --language <language value - optional> \
    --populateBundle <populateBundle value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --sku <sku value>
```

### Operation GetEstimatedPrice
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getestimatedprice \
    --namespace <namespace value> \
    --platform <platform value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --itemIds <itemIds value> \
    --userId <userId value>
```

### Operation GetItemIdBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitemidbysku \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional> \
    --sku <sku value>
```

### Operation GetBulkItemIdBySkus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getbulkitemidbyskus \
    --namespace <namespace value> \
    --sku <sku value - optional> \
    --storeId <storeId value - optional>
```

### Operation BulkGetLocaleItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkgetlocaleitems \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --itemIds <itemIds value>
```

### Operation GetAvailablePredicateTypes
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getavailablepredicatetypes \
    --namespace <namespace value>
```

### Operation ValidateItemPurchaseCondition
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op validateitempurchasecondition \
    --namespace <namespace value> \
    --platform <platform value - optional> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkUpdateRegionData
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkupdateregiondata \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SearchItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op searchitems \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --itemType <itemType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --storeId <storeId value - optional> \
    --keyword <keyword value> \
    --language <language value>
```

### Operation QueryUncategorizedItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuncategorizeditems \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --storeId <storeId value - optional>
```

### Operation GetItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional>
```

### Operation UpdateItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --featuresToCheck <featuresToCheck value - optional> \
    --force <force value - optional> \
    --storeId <storeId value - optional>
```

### Operation AcquireItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op acquireitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetApp
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getapp \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --storeId <storeId value - optional>
```

### Operation UpdateApp
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateapp \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DisableItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op disableitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetItemDynamicData
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getitemdynamicdata \
    --itemId <itemId value> \
    --namespace <namespace value>
```

### Operation EnableItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op enableitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation FeatureItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op featureitem \
    --feature <feature value> \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation DefeatureItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op defeatureitem \
    --feature <feature value> \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation GetLocaleItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getlocaleitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --language <language value - optional> \
    --populateBundle <populateBundle value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional>
```

### Operation UpdateItemPurchaseCondition
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateitempurchasecondition \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryItemReferences
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryitemreferences \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --featuresToCheck <featuresToCheck value - optional> \
    --storeId <storeId value - optional>
```

### Operation ReturnItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op returnitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryKeyGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querykeygroups \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --name <name value - optional> \
    --offset <offset value - optional> \
    --tag <tag value - optional>
```

### Operation CreateKeyGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createkeygroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetKeyGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getkeygroup \
    --keyGroupId <keyGroupId value> \
    --namespace <namespace value>
```

### Operation UpdateKeyGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatekeygroup \
    --keyGroupId <keyGroupId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetKeyGroupDynamic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getkeygroupdynamic \
    --keyGroupId <keyGroupId value> \
    --namespace <namespace value>
```

### Operation ListKeys
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listkeys \
    --keyGroupId <keyGroupId value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional>
```

### Operation UploadKeys
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op uploadkeys \
    --keyGroupId <keyGroupId value> \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation QueryOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryorders \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --orderNos <orderNos value - optional> \
    --sortBy <sortBy value - optional> \
    --startTime <startTime value - optional> \
    --status <status value - optional> \
    --withTotal <withTotal value - optional>
```

### Operation GetOrderStatistics
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getorderstatistics \
    --namespace <namespace value>
```

### Operation GetOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getorder \
    --namespace <namespace value> \
    --orderNo <orderNo value>
```

### Operation RefundOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op refundorder \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPaymentMerchantConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymentmerchantconfig \
    --namespace <namespace value>
```

### Operation UpdatePaymentDomainWhitelistConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatepaymentdomainwhitelistconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryPaymentNotifications
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querypaymentnotifications \
    --namespace <namespace value> \
    --endDate <endDate value - optional> \
    --externalId <externalId value - optional> \
    --limit <limit value - optional> \
    --notificationSource <notificationSource value - optional> \
    --notificationType <notificationType value - optional> \
    --offset <offset value - optional> \
    --paymentOrderNo <paymentOrderNo value - optional> \
    --startDate <startDate value - optional> \
    --status <status value - optional>
```

### Operation QueryPaymentOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querypaymentorders \
    --namespace <namespace value> \
    --channel <channel value - optional> \
    --extTxId <extTxId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional>
```

### Operation CreatePaymentOrderByDedicated
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createpaymentorderbydedicated \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListExtOrderNoByExtTxId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listextordernobyexttxid \
    --namespace <namespace value> \
    --extTxId <extTxId value>
```

### Operation GetPaymentOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymentorder \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value>
```

### Operation ChargePaymentOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op chargepaymentorder \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RefundPaymentOrderByDedicated
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op refundpaymentorderbydedicated \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SimulatePaymentOrderNotification
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op simulatepaymentordernotification \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPaymentOrderChargeStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymentorderchargestatus \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value>
```

### Operation GetPsnEntitlementOwnership
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpsnentitlementownership \
    --entitlementLabel <entitlementLabel value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetXboxEntitlementOwnership
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getxboxentitlementownership \
    --namespace <namespace value> \
    --productSku <productSku value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlatformEntitlementConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getplatformentitlementconfig \
    --namespace <namespace value> \
    --platform <platform value>
```

### Operation UpdatePlatformEntitlementConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateplatformentitlementconfig \
    --namespace <namespace value> \
    --platform <platform value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlatformWalletConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getplatformwalletconfig \
    --namespace <namespace value> \
    --platform <platform value>
```

### Operation UpdatePlatformWalletConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateplatformwalletconfig \
    --namespace <namespace value> \
    --platform <platform value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ResetPlatformWalletConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op resetplatformwalletconfig \
    --namespace <namespace value> \
    --platform <platform value>
```

### Operation GetRevocationConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getrevocationconfig \
    --namespace <namespace value>
```

### Operation UpdateRevocationConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updaterevocationconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteRevocationConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleterevocationconfig \
    --namespace <namespace value>
```

### Operation QueryRevocationHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryrevocationhistories \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --source <source value - optional> \
    --startTime <startTime value - optional> \
    --status <status value - optional> \
    --transactionId <transactionId value - optional> \
    --userId <userId value - optional>
```

### Operation GetRevocationPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getrevocationpluginconfig \
    --namespace <namespace value>
```

### Operation UpdateRevocationPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updaterevocationpluginconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteRevocationPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleterevocationpluginconfig \
    --namespace <namespace value>
```

### Operation UploadRevocationPluginConfigCert
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op uploadrevocationpluginconfigcert \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation CreateReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createreward \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryrewards \
    --namespace <namespace value> \
    --eventTopic <eventTopic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation ExportRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op exportrewards \
    --namespace <namespace value>
```

### Operation ImportRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op importrewards \
    --namespace <namespace value> \
    --replaceExisting <replaceExisting value> \
    --upload file <file to upload>
```

### Operation GetReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getreward \
    --namespace <namespace value> \
    --rewardId <rewardId value>
```

### Operation UpdateReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatereward \
    --namespace <namespace value> \
    --rewardId <rewardId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteReward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletereward \
    --namespace <namespace value> \
    --rewardId <rewardId value>
```

### Operation CheckEventCondition
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op checkeventcondition \
    --namespace <namespace value> \
    --rewardId <rewardId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteRewardConditionRecord
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleterewardconditionrecord \
    --namespace <namespace value> \
    --rewardId <rewardId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QuerySections
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querysections \
    --namespace <namespace value> \
    --end <end value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --start <start value - optional> \
    --storeId <storeId value - optional> \
    --viewId <viewId value - optional>
```

### Operation CreateSection
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createsection \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PurgeExpiredSection
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op purgeexpiredsection \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation GetSection
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getsection \
    --namespace <namespace value> \
    --sectionId <sectionId value> \
    --storeId <storeId value - optional>
```

### Operation UpdateSection
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatesection \
    --namespace <namespace value> \
    --sectionId <sectionId value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteSection
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletesection \
    --namespace <namespace value> \
    --sectionId <sectionId value> \
    --storeId <storeId value>
```

### Operation ListStores
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op liststores \
    --namespace <namespace value>
```

### Operation CreateStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createstore \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetCatalogDefinition
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getcatalogdefinition \
    --namespace <namespace value> \
    --catalogType <catalogType value>
```

### Operation DownloadCSVTemplates
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op downloadcsvtemplates \
    --namespace <namespace value>
```

### Operation ExportStoreByCSV
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op exportstorebycsv \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPublishedStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpublishedstore \
    --namespace <namespace value>
```

### Operation DeletePublishedStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletepublishedstore \
    --namespace <namespace value>
```

### Operation GetPublishedStoreBackup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpublishedstorebackup \
    --namespace <namespace value>
```

### Operation RollbackPublishedStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op rollbackpublishedstore \
    --namespace <namespace value>
```

### Operation GetStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getstore \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation UpdateStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatestore \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletestore \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation QueryChanges
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querychanges \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --action <action value - optional> \
    --itemSku <itemSku value - optional> \
    --itemType <itemType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --selected <selected value - optional> \
    --sortBy <sortBy value - optional> \
    --status <status value - optional> \
    --type <type value - optional> \
    --updatedAtEnd <updatedAtEnd value - optional> \
    --updatedAtStart <updatedAtStart value - optional> \
    --withTotal <withTotal value - optional>
```

### Operation PublishAll
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publishall \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation PublishSelected
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publishselected \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation SelectAllRecords
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op selectallrecords \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation SelectAllRecordsByCriteria
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op selectallrecordsbycriteria \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --action <action value - optional> \
    --itemSku <itemSku value - optional> \
    --itemType <itemType value - optional> \
    --selected <selected value - optional> \
    --type <type value - optional> \
    --updatedAtEnd <updatedAtEnd value - optional> \
    --updatedAtStart <updatedAtStart value - optional>
```

### Operation GetStatistic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getstatistic \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --action <action value - optional> \
    --itemSku <itemSku value - optional> \
    --itemType <itemType value - optional> \
    --type <type value - optional> \
    --updatedAtEnd <updatedAtEnd value - optional> \
    --updatedAtStart <updatedAtStart value - optional>
```

### Operation UnselectAllRecords
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op unselectallrecords \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation SelectRecord
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op selectrecord \
    --changeId <changeId value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation UnselectRecord
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op unselectrecord \
    --changeId <changeId value> \
    --namespace <namespace value> \
    --storeId <storeId value>
```

### Operation CloneStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op clonestore \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --targetStoreId <targetStoreId value - optional>
```

### Operation QueryImportHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryimporthistory \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --end <end value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional> \
    --start <start value - optional> \
    --success <success value - optional>
```

### Operation ImportStoreByCSV
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op importstorebycsv \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --upload category <file to upload> \
    --upload display <file to upload> \
    --upload item <file to upload> \
    --notes <notes value - optional> \
    --upload section <file to upload>
```

### Operation QuerySubscriptions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querysubscriptions \
    --namespace <namespace value> \
    --chargeStatus <chargeStatus value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sku <sku value - optional> \
    --status <status value - optional> \
    --subscribedBy <subscribedBy value - optional> \
    --userId <userId value - optional>
```

### Operation RecurringChargeSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op recurringchargesubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value>
```

### Operation GetTicketDynamic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getticketdynamic \
    --boothName <boothName value> \
    --namespace <namespace value>
```

### Operation DecreaseTicketSale
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op decreaseticketsale \
    --boothName <boothName value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetTicketBoothID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getticketboothid \
    --boothName <boothName value> \
    --namespace <namespace value>
```

### Operation IncreaseTicketSale
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op increaseticketsale \
    --boothName <boothName value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation Commit
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op commit \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetTradeHistoryByCriteria
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op gettradehistorybycriteria \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional>
```

### Operation GetTradeHistoryByTransactionId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op gettradehistorybytransactionid \
    --namespace <namespace value> \
    --transactionId <transactionId value>
```

### Operation UnlockSteamUserAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op unlocksteamuserachievement \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetXblUserAchievements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getxbluserachievements \
    --namespace <namespace value> \
    --userId <userId value> \
    --xboxUserId <xboxUserId value>
```

### Operation UpdateXblUserAchievement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatexbluserachievement \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AnonymizeCampaign
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizecampaign \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizeentitlement \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeFulfillment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizefulfillment \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeIntegration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizeintegration \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizeorder \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizePayment
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizepayment \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeRevocation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizerevocation \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizesubscription \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AnonymizeWallet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op anonymizewallet \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetUserDLCByPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserdlcbyplatform \
    --namespace <namespace value> \
    --userId <userId value> \
    --type <type value>
```

### Operation GetUserDLC
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserdlc \
    --namespace <namespace value> \
    --userId <userId value> \
    --includeAllNamespaces <includeAllNamespaces value - optional> \
    --status <status value - optional> \
    --type <type value - optional>
```

### Operation QueryUserEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuserentitlements \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --appType <appType value - optional> \
    --collectionId <collectionId value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --entitlementName <entitlementName value - optional> \
    --features <features value - optional> \
    --fuzzyMatchName <fuzzyMatchName value - optional> \
    --ignoreActiveDate <ignoreActiveDate value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --origin <origin value - optional>
```

### Operation GrantUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op grantuserentitlement \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserAppEntitlementByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserappentitlementbyappid \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --appId <appId value>
```

### Operation QueryUserEntitlementsByAppType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuserentitlementsbyapptype \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --appType <appType value>
```

### Operation GetUserEntitlementsByIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementsbyids \
    --namespace <namespace value> \
    --userId <userId value> \
    --ids <ids value - optional>
```

### Operation GetUserEntitlementByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementbyitemid \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --platform <platform value - optional> \
    --itemId <itemId value>
```

### Operation GetUserActiveEntitlementsByItemIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuseractiveentitlementsbyitemids \
    --namespace <namespace value> \
    --userId <userId value> \
    --ids <ids value - optional> \
    --platform <platform value - optional>
```

### Operation GetUserEntitlementBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementbysku \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --platform <platform value - optional> \
    --sku <sku value>
```

### Operation ExistsAnyUserActiveEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op existsanyuseractiveentitlement \
    --namespace <namespace value> \
    --userId <userId value> \
    --appIds <appIds value - optional> \
    --itemIds <itemIds value - optional> \
    --platform <platform value - optional> \
    --skus <skus value - optional>
```

### Operation ExistsAnyUserActiveEntitlementByItemIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op existsanyuseractiveentitlementbyitemids \
    --namespace <namespace value> \
    --userId <userId value> \
    --platform <platform value - optional> \
    --itemIds <itemIds value>
```

### Operation GetUserAppEntitlementOwnershipByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserappentitlementownershipbyappid \
    --namespace <namespace value> \
    --userId <userId value> \
    --appId <appId value>
```

### Operation GetUserEntitlementOwnershipByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementownershipbyitemid \
    --namespace <namespace value> \
    --userId <userId value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --platform <platform value - optional> \
    --itemId <itemId value>
```

### Operation GetUserEntitlementOwnershipByItemIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementownershipbyitemids \
    --namespace <namespace value> \
    --userId <userId value> \
    --ids <ids value - optional> \
    --platform <platform value - optional>
```

### Operation GetUserEntitlementOwnershipBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementownershipbysku \
    --namespace <namespace value> \
    --userId <userId value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --platform <platform value - optional> \
    --sku <sku value>
```

### Operation RevokeAllEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeallentitlements \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation RevokeUserEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeuserentitlements \
    --namespace <namespace value> \
    --userId <userId value> \
    --entitlementIds <entitlementIds value>
```

### Operation GetUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ConsumeUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op consumeuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DisableUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op disableuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation EnableUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op enableuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetUserEntitlementHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserentitlementhistories \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation RevokeUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RevokeUserEntitlementByUseCount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeuserentitlementbyusecount \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PreCheckRevokeUserEntitlementByUseCount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op precheckrevokeuserentitlementbyusecount \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --quantity <quantity value>
```

### Operation SellUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op selluserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FulfillItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op fulfillitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RedeemCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op redeemcode \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PreCheckFulfillItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op precheckfulfillitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FulfillRewards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op fulfillrewards \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryUserIAPOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuseriaporders \
    --namespace <namespace value> \
    --userId <userId value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --productId <productId value - optional> \
    --startTime <startTime value - optional> \
    --status <status value - optional> \
    --type <type value - optional>
```

### Operation QueryAllUserIAPOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryalluseriaporders \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation QueryUserIAPConsumeHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuseriapconsumehistory \
    --namespace <namespace value> \
    --userId <userId value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional> \
    --status <status value - optional> \
    --type <type value - optional>
```

### Operation MockFulfillIAPItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op mockfulfilliapitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSyncOculusSubscriptions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op adminsyncoculussubscriptions \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetIAPOrderLineItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op admingetiaporderlineitems \
    --iapOrderNo <iapOrderNo value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminSyncSteamAbnormalTransaction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op adminsyncsteamabnormaltransaction \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminSyncSteamIAPByTransaction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op adminsyncsteamiapbytransaction \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryUserThirdPartySubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuserthirdpartysubscription \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --groupId <groupId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platform <platform value - optional> \
    --productId <productId value - optional>
```

### Operation GetThirdPartyPlatformSubscriptionOwnershipByGroupId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getthirdpartyplatformsubscriptionownershipbygroupid \
    --namespace <namespace value> \
    --platform <platform value> \
    --userId <userId value> \
    --groupId <groupId value>
```

### Operation GetThirdPartyPlatformSubscriptionOwnershipByProductId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getthirdpartyplatformsubscriptionownershipbyproductid \
    --namespace <namespace value> \
    --platform <platform value> \
    --userId <userId value> \
    --productId <productId value>
```

### Operation QueryUserThirdPartySubscriptionTransactions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuserthirdpartysubscriptiontransactions \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --groupId <groupId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platform <platform value - optional> \
    --productId <productId value - optional>
```

### Operation GetThirdPartySubscriptionDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getthirdpartysubscriptiondetails \
    --id <id value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetSubscriptionHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getsubscriptionhistory \
    --id <id value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation SyncSubscriptionTransaction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsubscriptiontransaction \
    --id <id value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetThirdPartyUserSubscriptionDetails
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getthirdpartyusersubscriptiondetails \
    --id <id value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation SyncSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsubscription \
    --id <id value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation QueryUserOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryuserorders \
    --namespace <namespace value> \
    --userId <userId value> \
    --discounted <discounted value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional>
```

### Operation AdminCreateUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op admincreateuserorder \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CountOfPurchasedItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op countofpurchaseditem \
    --namespace <namespace value> \
    --userId <userId value> \
    --itemId <itemId value>
```

### Operation GetUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserorder \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation UpdateUserOrderStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateuserorderstatus \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FulfillUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op fulfilluserorder \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation GetUserOrderHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserorderhistories \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation ProcessUserOrderNotification
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op processuserordernotification \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DownloadUserOrderReceipt
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op downloaduserorderreceipt \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation CreateUserPaymentOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createuserpaymentorder \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RefundUserPaymentOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op refunduserpaymentorder \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserPlatformAccountClosureHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getuserplatformaccountclosurehistories \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation ApplyUserRedemption
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op applyuserredemption \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DoRevocation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op dorevocation \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RegisterXblSessions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op registerxblsessions \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryUserSubscriptions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryusersubscriptions \
    --namespace <namespace value> \
    --userId <userId value> \
    --chargeStatus <chargeStatus value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sku <sku value - optional> \
    --status <status value - optional> \
    --subscribedBy <subscribedBy value - optional>
```

### Operation GetUserSubscriptionActivities
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getusersubscriptionactivities \
    --namespace <namespace value> \
    --userId <userId value> \
    --excludeSystem <excludeSystem value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --subscriptionId <subscriptionId value - optional>
```

### Operation PlatformSubscribeSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op platformsubscribesubscription \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CheckUserSubscriptionSubscribableByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op checkusersubscriptionsubscribablebyitemid \
    --namespace <namespace value> \
    --userId <userId value> \
    --itemId <itemId value>
```

### Operation GetUserSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getusersubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value>
```

### Operation DeleteUserSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteusersubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value>
```

### Operation CancelSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op cancelsubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --force <force value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GrantDaysToSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op grantdaystosubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserSubscriptionBillingHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getusersubscriptionbillinghistories \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --excludeFree <excludeFree value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation ProcessUserSubscriptionNotification
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op processusersubscriptionnotification \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AcquireUserTicket
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op acquireuserticket \
    --boothName <boothName value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryUserCurrencyWallets
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryusercurrencywallets \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation DebitUserWalletByCurrencyCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op debituserwalletbycurrencycode \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListUserCurrencyTransactions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listusercurrencytransactions \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation CheckBalance
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op checkbalance \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreditUserWallet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op credituserwallet \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DebitByWalletPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op debitbywalletplatform \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PayWithUserWallet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op paywithuserwallet \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListViews
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op listviews \
    --namespace <namespace value> \
    --storeId <storeId value - optional>
```

### Operation CreateView
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createview \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetView
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getview \
    --namespace <namespace value> \
    --viewId <viewId value> \
    --storeId <storeId value - optional>
```

### Operation UpdateView
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateview \
    --namespace <namespace value> \
    --viewId <viewId value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteView
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deleteview \
    --namespace <namespace value> \
    --viewId <viewId value> \
    --storeId <storeId value>
```

### Operation GetWalletConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getwalletconfig \
    --namespace <namespace value>
```

### Operation UpdateWalletConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatewalletconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkCredit
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkcredit \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkDebit
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op bulkdebit \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncorders \
    --nextEvaluatedKey <nextEvaluatedKey value - optional> \
    --end <end value> \
    --start <start value>
```

### Operation TestAdyenConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testadyenconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestAliPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testalipayconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestCheckoutConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testcheckoutconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DebugMatchedPaymentMerchantConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op debugmatchedpaymentmerchantconfig \
    --namespace_ <namespace_ value - optional> \
    --region <region value - optional>
```

### Operation TestNeonPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testneonpayconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestPayPalConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testpaypalconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestStripeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op teststripeconfig \
    --sandbox <sandbox value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestWxPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testwxpayconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestXsollaConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testxsollaconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPaymentMerchantConfig1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymentmerchantconfig1 \
    --id <id value>
```

### Operation UpdateAdyenConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateadyenconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestAdyenConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testadyenconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdateAliPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatealipayconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestAliPayConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testalipayconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdateCheckoutConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatecheckoutconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestCheckoutConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testcheckoutconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdateNeonPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updateneonpayconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestNeonPayConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testneonpayconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdatePayPalConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatepaypalconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestPayPalConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testpaypalconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdateStripeConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatestripeconfig \
    --id <id value> \
    --sandbox <sandbox value - optional> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestStripeConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op teststripeconfigbyid \
    --id <id value> \
    --sandbox <sandbox value - optional>
```

### Operation UpdateWxPayConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatewxpayconfig \
    --id <id value> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateWxPayConfigCert
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatewxpayconfigcert \
    --id <id value> \
    --upload file <file to upload>
```

### Operation TestWxPayConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testwxpayconfigbyid \
    --id <id value>
```

### Operation UpdateXsollaConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatexsollaconfig \
    --id <id value> \
    --validate <validate value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation TestXsollaConfigById
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op testxsollaconfigbyid \
    --id <id value>
```

### Operation UpdateXsollaUIConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatexsollauiconfig \
    --id <id value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation QueryPaymentProviderConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op querypaymentproviderconfig \
    --limit <limit value - optional> \
    --namespace_ <namespace_ value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional>
```

### Operation CreatePaymentProviderConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op createpaymentproviderconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAggregatePaymentProviders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getaggregatepaymentproviders \

```

### Operation DebugMatchedPaymentProviderConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op debugmatchedpaymentproviderconfig \
    --namespace_ <namespace_ value - optional> \
    --region <region value - optional>
```

### Operation GetSpecialPaymentProviders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getspecialpaymentproviders \

```

### Operation UpdatePaymentProviderConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatepaymentproviderconfig \
    --id <id value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePaymentProviderConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op deletepaymentproviderconfig \
    --id <id value>
```

### Operation GetPaymentTaxConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymenttaxconfig \

```

### Operation UpdatePaymentTaxConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op updatepaymenttaxconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncPaymentOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncpaymentorders \
    --nextEvaluatedKey <nextEvaluatedKey value - optional> \
    --end <end value> \
    --start <start value>
```

### Operation PublicGetRootCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetrootcategories \
    --namespace <namespace value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation DownloadCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op downloadcategories \
    --namespace <namespace value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetcategory \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetChildCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetchildcategories \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetDescendantCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetdescendantcategories \
    --categoryPath <categoryPath value> \
    --namespace <namespace value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicListCurrencies
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiclistcurrencies \
    --namespace <namespace value> \
    --currencyType <currencyType value - optional>
```

### Operation GeDLCDurableRewardShortMap
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op gedlcdurablerewardshortmap \
    --namespace <namespace value> \
    --dlcType <dlcType value>
```

### Operation GetAppleConfigVersion
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getappleconfigversion \
    --namespace <namespace value>
```

### Operation GetIAPItemMapping
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getiapitemmapping \
    --namespace <namespace value> \
    --platform <platform value - optional>
```

### Operation PublicGetItemByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetitembyappid \
    --namespace <namespace value> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --appId <appId value>
```

### Operation PublicQueryItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryitems \
    --namespace <namespace value> \
    --appType <appType value - optional> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --baseAppId <baseAppId value - optional> \
    --categoryPath <categoryPath value - optional> \
    --features <features value - optional> \
    --includeSubCategoryItem <includeSubCategoryItem value - optional> \
    --itemType <itemType value - optional> \
    --language <language value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --sortBy <sortBy value - optional> \
    --storeId <storeId value - optional> \
    --tags <tags value - optional>
```

### Operation PublicGetItemBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetitembysku \
    --namespace <namespace value> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --sku <sku value>
```

### Operation PublicGetEstimatedPrice
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetestimatedprice \
    --namespace <namespace value> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --itemIds <itemIds value>
```

### Operation PublicBulkGetItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicbulkgetitems \
    --namespace <namespace value> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --itemIds <itemIds value>
```

### Operation PublicValidateItemPurchaseCondition
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicvalidateitempurchasecondition \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSearchItems
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicsearchitems \
    --namespace <namespace value> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --itemType <itemType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --keyword <keyword value> \
    --language <language value>
```

### Operation PublicGetApp
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetapp \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetItemDynamicData
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetitemdynamicdata \
    --itemId <itemId value> \
    --namespace <namespace value>
```

### Operation PublicGetItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetitem \
    --itemId <itemId value> \
    --namespace <namespace value> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --language <language value - optional> \
    --populateBundle <populateBundle value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetPaymentUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetpaymenturl \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetPaymentMethods
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetpaymentmethods \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value>
```

### Operation PublicGetUnpaidPaymentOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetunpaidpaymentorder \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value>
```

### Operation Pay
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op pay \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value> \
    --paymentProvider <paymentProvider value - optional> \
    --zipCode <zipCode value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCheckPaymentOrderPaidStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiccheckpaymentorderpaidstatus \
    --namespace <namespace value> \
    --paymentOrderNo <paymentOrderNo value>
```

### Operation GetPaymentPublicConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymentpublicconfig \
    --namespace <namespace value> \
    --sandbox <sandbox value - optional> \
    --paymentProvider <paymentProvider value> \
    --region <region value>
```

### Operation PublicGetQRCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetqrcode \
    --namespace <namespace value> \
    --code <code value>
```

### Operation PublicNormalizePaymentReturnUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicnormalizepaymentreturnurl \
    --namespace <namespace value> \
    --payerID <payerID value - optional> \
    --foreinginvoice <foreinginvoice value - optional> \
    --invoiceId <invoiceId value - optional> \
    --payload <payload value - optional> \
    --redirectResult <redirectResult value - optional> \
    --resultCode <resultCode value - optional> \
    --sessionId <sessionId value - optional> \
    --status <status value - optional> \
    --token <token value - optional> \
    --type <type value - optional> \
    --userId <userId value - optional> \
    --orderNo <orderNo value> \
    --paymentOrderNo <paymentOrderNo value> \
    --paymentProvider <paymentProvider value> \
    --returnUrl <returnUrl value>
```

### Operation GetPaymentTaxValue
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getpaymenttaxvalue \
    --namespace <namespace value> \
    --zipCode <zipCode value - optional> \
    --paymentOrderNo <paymentOrderNo value> \
    --paymentProvider <paymentProvider value>
```

### Operation GetRewardByCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getrewardbycode \
    --namespace <namespace value> \
    --rewardCode <rewardCode value>
```

### Operation QueryRewards1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryrewards1 \
    --namespace <namespace value> \
    --eventTopic <eventTopic value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sortBy <sortBy value - optional>
```

### Operation GetReward1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op getreward1 \
    --namespace <namespace value> \
    --rewardId <rewardId value>
```

### Operation PublicListStores
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicliststores \
    --namespace <namespace value>
```

### Operation PublicExistsAnyMyActiveEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicexistsanymyactiveentitlement \
    --namespace <namespace value> \
    --appIds <appIds value - optional> \
    --itemIds <itemIds value - optional> \
    --skus <skus value - optional>
```

### Operation PublicGetMyAppEntitlementOwnershipByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetmyappentitlementownershipbyappid \
    --namespace <namespace value> \
    --appId <appId value>
```

### Operation PublicGetMyEntitlementOwnershipByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetmyentitlementownershipbyitemid \
    --namespace <namespace value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --itemId <itemId value>
```

### Operation PublicGetMyEntitlementOwnershipBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetmyentitlementownershipbysku \
    --namespace <namespace value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --sku <sku value>
```

### Operation PublicGetEntitlementOwnershipToken
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetentitlementownershiptoken \
    --namespace <namespace value> \
    --appIds <appIds value - optional> \
    --itemIds <itemIds value - optional> \
    --skus <skus value - optional>
```

### Operation SyncTwitchDropsEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op synctwitchdropsentitlement \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetMyWallet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetmywallet \
    --currencyCode <currencyCode value> \
    --namespace <namespace value>
```

### Operation SyncEpicGameDLC
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncepicgamedlc \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncOculusDLC
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncoculusdlc \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicSyncPsnDlcInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicsyncpsndlcinventory \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSyncPsnDlcInventoryWithMultipleServiceLabels
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicsyncpsndlcinventorywithmultipleservicelabels \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncSteamDLC
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsteamdlc \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncXboxDLC
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncxboxdlc \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryUserEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryuserentitlements \
    --namespace <namespace value> \
    --userId <userId value> \
    --appType <appType value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --entitlementName <entitlementName value - optional> \
    --features <features value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicGetUserAppEntitlementByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserappentitlementbyappid \
    --namespace <namespace value> \
    --userId <userId value> \
    --appId <appId value>
```

### Operation PublicQueryUserEntitlementsByAppType
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryuserentitlementsbyapptype \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --appType <appType value>
```

### Operation PublicGetUserEntitlementsByIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserentitlementsbyids \
    --namespace <namespace value> \
    --userId <userId value> \
    --availablePlatformOnly <availablePlatformOnly value - optional> \
    --ids <ids value - optional>
```

### Operation PublicUserEntitlementHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicuserentitlementhistory \
    --namespace <namespace value> \
    --userId <userId value> \
    --endDate <endDate value - optional> \
    --entitlementClazz <entitlementClazz value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startDate <startDate value - optional>
```

### Operation PublicExistsAnyUserActiveEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicexistsanyuseractiveentitlement \
    --namespace <namespace value> \
    --userId <userId value> \
    --appIds <appIds value - optional> \
    --itemIds <itemIds value - optional> \
    --skus <skus value - optional>
```

### Operation PublicGetUserAppEntitlementOwnershipByAppId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserappentitlementownershipbyappid \
    --namespace <namespace value> \
    --userId <userId value> \
    --appId <appId value>
```

### Operation PublicGetUserEntitlementOwnershipByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserentitlementownershipbyitemid \
    --namespace <namespace value> \
    --userId <userId value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --itemId <itemId value>
```

### Operation PublicGetUserEntitlementOwnershipByItemIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserentitlementownershipbyitemids \
    --namespace <namespace value> \
    --userId <userId value> \
    --ids <ids value - optional>
```

### Operation PublicGetUserEntitlementOwnershipBySku
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserentitlementownershipbysku \
    --namespace <namespace value> \
    --userId <userId value> \
    --entitlementClazz <entitlementClazz value - optional> \
    --sku <sku value>
```

### Operation PublicGetUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicConsumeUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicconsumeuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSellUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicselluserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSplitUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicsplituserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicTransferUserEntitlement
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publictransferuserentitlement \
    --entitlementId <entitlementId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicRedeemCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicredeemcode \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicFulfillAppleIAPItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicfulfillappleiapitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncEpicGamesInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncepicgamesinventory \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicFulfillGoogleIAPItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicfulfillgoogleiapitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncOculusSubscriptions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncoculussubscriptions \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncOculusConsumableEntitlements
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncoculusconsumableentitlements \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicReconcilePlayStationStore
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicreconcileplaystationstore \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicReconcilePlayStationStoreWithMultipleServiceLabels
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicreconcileplaystationstorewithmultipleservicelabels \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncSteamInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsteaminventory \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncSteamAbnormalTransaction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsteamabnormaltransaction \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation SyncSteamIAPByTransaction
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncsteamiapbytransaction \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryUserThirdPartySubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryuserthirdpartysubscription \
    --namespace <namespace value> \
    --platform <platform value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --groupId <groupId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --productId <productId value - optional>
```

### Operation SyncTwitchDropsEntitlement1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op synctwitchdropsentitlement1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncXboxInventory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op syncxboxinventory \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicQueryUserOrders
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryuserorders \
    --namespace <namespace value> \
    --userId <userId value> \
    --discounted <discounted value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional>
```

### Operation PublicCreateUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiccreateuserorder \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicPreviewOrderPrice
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicprevieworderprice \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserorder \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation PublicCancelUserOrder
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiccanceluserorder \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation PublicGetUserOrderHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetuserorderhistories \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation PublicDownloadUserOrderReceipt
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicdownloaduserorderreceipt \
    --namespace <namespace value> \
    --orderNo <orderNo value> \
    --userId <userId value>
```

### Operation PublicGetPaymentAccounts
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetpaymentaccounts \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicDeletePaymentAccount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicdeletepaymentaccount \
    --id <id value> \
    --namespace <namespace value> \
    --type <type value> \
    --userId <userId value>
```

### Operation PublicListActiveSections
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiclistactivesections \
    --namespace <namespace value> \
    --userId <userId value> \
    --autoCalcEstimatedPrice <autoCalcEstimatedPrice value - optional> \
    --language <language value - optional> \
    --region <region value - optional> \
    --storeId <storeId value - optional> \
    --viewId <viewId value - optional>
```

### Operation PublicQueryUserSubscriptions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicqueryusersubscriptions \
    --namespace <namespace value> \
    --userId <userId value> \
    --chargeStatus <chargeStatus value - optional> \
    --itemId <itemId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --sku <sku value - optional> \
    --status <status value - optional> \
    --subscribedBy <subscribedBy value - optional>
```

### Operation PublicSubscribeSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicsubscribesubscription \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCheckUserSubscriptionSubscribableByItemId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiccheckusersubscriptionsubscribablebyitemid \
    --namespace <namespace value> \
    --userId <userId value> \
    --itemId <itemId value>
```

### Operation PublicGetUserSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetusersubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value>
```

### Operation PublicChangeSubscriptionBillingAccount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicchangesubscriptionbillingaccount \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value>
```

### Operation PublicCancelSubscription
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiccancelsubscription \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserSubscriptionBillingHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetusersubscriptionbillinghistories \
    --namespace <namespace value> \
    --subscriptionId <subscriptionId value> \
    --userId <userId value> \
    --excludeFree <excludeFree value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicListViews
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiclistviews \
    --namespace <namespace value> \
    --userId <userId value> \
    --language <language value - optional> \
    --storeId <storeId value - optional>
```

### Operation PublicGetWallet
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetwallet \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicListUserWalletTransactions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publiclistuserwallettransactions \
    --currencyCode <currencyCode value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicGetMyDLCContent
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op publicgetmydlccontent \
    --includeAllNamespaces <includeAllNamespaces value - optional> \
    --type <type value>
```

### Operation QueryFulfillments
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryfulfillments \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional> \
    --state <state value - optional> \
    --transactionId <transactionId value - optional> \
    --userId <userId value - optional>
```

### Operation QueryItemsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op queryitemsv2 \
    --namespace <namespace value> \
    --appType <appType value - optional> \
    --availableDate <availableDate value - optional> \
    --baseAppId <baseAppId value - optional> \
    --categoryPath <categoryPath value - optional> \
    --features <features value - optional> \
    --includeSubCategoryItem <includeSubCategoryItem value - optional> \
    --itemName <itemName value - optional> \
    --itemStatus <itemStatus value - optional> \
    --itemType <itemType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --region <region value - optional> \
    --sectionExclusive <sectionExclusive value - optional> \
    --sortBy <sortBy value - optional> \
    --storeId <storeId value - optional> \
    --tags <tags value - optional> \
    --targetNamespace <targetNamespace value - optional> \
    --withTotal <withTotal value - optional>
```

### Operation ImportStore1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op importstore1 \
    --namespace <namespace value> \
    --storeId <storeId value - optional> \
    --strictMode <strictMode value - optional> \
    --upload file <file to upload>
```

### Operation ExportStore1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op exportstore1 \
    --namespace <namespace value> \
    --storeId <storeId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FulfillRewardsV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op fulfillrewardsv2 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation V2PublicFulfillAppleIAPItem
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op v2publicfulfillappleiapitem \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FulfillItemsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op fulfillitemsv3 \
    --namespace <namespace value> \
    --transactionId <transactionId value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetryFulfillItemsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op retryfulfillitemsv3 \
    --namespace <namespace value> \
    --transactionId <transactionId value> \
    --userId <userId value>
```

### Operation RevokeItemsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn platform \
    --op revokeitemsv3 \
    --namespace <namespace value> \
    --transactionId <transactionId value> \
    --userId <userId value>
```

