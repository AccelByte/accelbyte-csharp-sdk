# Platform Service Index

&nbsp;  

## Operations

### FulfillmentScript Wrapper:  [FulfillmentScript](../../AccelByte.Sdk/Api/Platform/Wrapper/FulfillmentScript.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/fulfillment/scripts` | GET | ListFulfillmentScripts | [ListFulfillmentScripts](../../AccelByte.Sdk/Api/Platform/Operation/FulfillmentScript/ListFulfillmentScripts.cs) | [ListFulfillmentScripts](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/ListFulfillmentScripts.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | GET | GetFulfillmentScript | [GetFulfillmentScript](../../AccelByte.Sdk/Api/Platform/Operation/FulfillmentScript/GetFulfillmentScript.cs) | [GetFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/GetFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | POST | CreateFulfillmentScript | [CreateFulfillmentScript](../../AccelByte.Sdk/Api/Platform/Operation/FulfillmentScript/CreateFulfillmentScript.cs) | [CreateFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/CreateFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | DELETE | DeleteFulfillmentScript | [DeleteFulfillmentScript](../../AccelByte.Sdk/Api/Platform/Operation/FulfillmentScript/DeleteFulfillmentScript.cs) | [DeleteFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/DeleteFulfillmentScript.cs) |
| `/platform/admin/fulfillment/scripts/{id}` | PATCH | UpdateFulfillmentScript | [UpdateFulfillmentScript](../../AccelByte.Sdk/Api/Platform/Operation/FulfillmentScript/UpdateFulfillmentScript.cs) | [UpdateFulfillmentScript](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/FulfillmentScript/UpdateFulfillmentScript.cs) |

### Item Wrapper:  [Item](../../AccelByte.Sdk/Api/Platform/Wrapper/Item.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/items/configs` | GET | ListItemTypeConfigs | [ListItemTypeConfigs](../../AccelByte.Sdk/Api/Platform/Operation/Item/ListItemTypeConfigs.cs) | [ListItemTypeConfigs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ListItemTypeConfigs.cs) |
| `/platform/admin/items/configs` | POST | CreateItemTypeConfig | [CreateItemTypeConfig](../../AccelByte.Sdk/Api/Platform/Operation/Item/CreateItemTypeConfig.cs) | [CreateItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/CreateItemTypeConfig.cs) |
| `/platform/admin/items/configs/search` | GET | SearchItemTypeConfig | [SearchItemTypeConfig](../../AccelByte.Sdk/Api/Platform/Operation/Item/SearchItemTypeConfig.cs) | [SearchItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SearchItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | GET | GetItemTypeConfig | [GetItemTypeConfig](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItemTypeConfig.cs) | [GetItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | PUT | UpdateItemTypeConfig | [UpdateItemTypeConfig](../../AccelByte.Sdk/Api/Platform/Operation/Item/UpdateItemTypeConfig.cs) | [UpdateItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItemTypeConfig.cs) |
| `/platform/admin/items/configs/{id}` | DELETE | DeleteItemTypeConfig | [DeleteItemTypeConfig](../../AccelByte.Sdk/Api/Platform/Operation/Item/DeleteItemTypeConfig.cs) | [DeleteItemTypeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DeleteItemTypeConfig.cs) |
| `/platform/admin/namespaces/{namespace}/items` | PUT | SyncInGameItem | [SyncInGameItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/SyncInGameItem.cs) | [SyncInGameItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SyncInGameItem.cs) |
| `/platform/admin/namespaces/{namespace}/items` | POST | CreateItem | [CreateItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/CreateItem.cs) | [CreateItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/CreateItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/byAppId` | GET | GetItemByAppId | [GetItemByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItemByAppId.cs) | [GetItemByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/items/byCriteria` | GET | QueryItems | [QueryItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/QueryItems.cs) | [QueryItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/byFeatures/basic` | GET | ListBasicItemsByFeatures | [ListBasicItemsByFeatures](../../AccelByte.Sdk/Api/Platform/Operation/Item/ListBasicItemsByFeatures.cs) | [ListBasicItemsByFeatures](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ListBasicItemsByFeatures.cs) |
| `/platform/admin/namespaces/{namespace}/items/byIds` | GET | GetItems | [GetItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItems.cs) | [GetItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/bySku` | GET | GetItemBySku | [GetItemBySku](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItemBySku.cs) | [GetItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/bySku/locale` | GET | GetLocaleItemBySku | [GetLocaleItemBySku](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetLocaleItemBySku.cs) | [GetLocaleItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetLocaleItemBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/estimatedPrice` | GET | GetEstimatedPrice | [GetEstimatedPrice](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetEstimatedPrice.cs) | [GetEstimatedPrice](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetEstimatedPrice.cs) |
| `/platform/admin/namespaces/{namespace}/items/itemId/bySku` | GET | GetItemIdBySku | [GetItemIdBySku](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItemIdBySku.cs) | [GetItemIdBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemIdBySku.cs) |
| `/platform/admin/namespaces/{namespace}/items/itemId/bySkus` | GET | GetBulkItemIdBySkus | [GetBulkItemIdBySkus](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetBulkItemIdBySkus.cs) | [GetBulkItemIdBySkus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetBulkItemIdBySkus.cs) |
| `/platform/admin/namespaces/{namespace}/items/locale/byIds` | GET | BulkGetLocaleItems | [BulkGetLocaleItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/BulkGetLocaleItems.cs) | [BulkGetLocaleItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/BulkGetLocaleItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/predicate/types` | GET | GetAvailablePredicateTypes | [GetAvailablePredicateTypes](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetAvailablePredicateTypes.cs) | [GetAvailablePredicateTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetAvailablePredicateTypes.cs) |
| `/platform/admin/namespaces/{namespace}/items/purchase/conditions/validate` | POST | ValidateItemPurchaseCondition | [ValidateItemPurchaseCondition](../../AccelByte.Sdk/Api/Platform/Operation/Item/ValidateItemPurchaseCondition.cs) | [ValidateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ValidateItemPurchaseCondition.cs) |
| `/platform/admin/namespaces/{namespace}/items/regiondata` | PUT | BulkUpdateRegionData | [BulkUpdateRegionData](../../AccelByte.Sdk/Api/Platform/Operation/Item/BulkUpdateRegionData.cs) | [BulkUpdateRegionData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/BulkUpdateRegionData.cs) |
| `/platform/admin/namespaces/{namespace}/items/search` | GET | SearchItems | [SearchItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/SearchItems.cs) | [SearchItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/SearchItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/uncategorized` | GET | QueryUncategorizedItems | [QueryUncategorizedItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/QueryUncategorizedItems.cs) | [QueryUncategorizedItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryUncategorizedItems.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | GET | GetItem | [GetItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItem.cs) | [GetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | PUT | UpdateItem | [UpdateItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/UpdateItem.cs) | [UpdateItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}` | DELETE | DeleteItem | [DeleteItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/DeleteItem.cs) | [DeleteItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DeleteItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/acquire` | PUT | AcquireItem | [AcquireItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/AcquireItem.cs) | [AcquireItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/AcquireItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/app` | GET | GetApp | [GetApp](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetApp.cs) | [GetApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetApp.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/app` | PUT | UpdateApp | [UpdateApp](../../AccelByte.Sdk/Api/Platform/Operation/Item/UpdateApp.cs) | [UpdateApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateApp.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/disable` | PUT | DisableItem | [DisableItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/DisableItem.cs) | [DisableItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DisableItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/dynamic` | GET | GetItemDynamicData | [GetItemDynamicData](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetItemDynamicData.cs) | [GetItemDynamicData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetItemDynamicData.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/enable` | PUT | EnableItem | [EnableItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/EnableItem.cs) | [EnableItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/EnableItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}` | PUT | FeatureItem | [FeatureItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/FeatureItem.cs) | [FeatureItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/FeatureItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}` | DELETE | DefeatureItem | [DefeatureItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/DefeatureItem.cs) | [DefeatureItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/DefeatureItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/locale` | GET | GetLocaleItem | [GetLocaleItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/GetLocaleItem.cs) | [GetLocaleItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/GetLocaleItem.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition` | PUT | UpdateItemPurchaseCondition | [UpdateItemPurchaseCondition](../../AccelByte.Sdk/Api/Platform/Operation/Item/UpdateItemPurchaseCondition.cs) | [UpdateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/UpdateItemPurchaseCondition.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/references` | GET | QueryItemReferences | [QueryItemReferences](../../AccelByte.Sdk/Api/Platform/Operation/Item/QueryItemReferences.cs) | [QueryItemReferences](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryItemReferences.cs) |
| `/platform/admin/namespaces/{namespace}/items/{itemId}/return` | PUT | ReturnItem | [ReturnItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/ReturnItem.cs) | [ReturnItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/ReturnItem.cs) |
| `/platform/public/namespaces/{namespace}/items/byAppId` | GET | PublicGetItemByAppId | [PublicGetItemByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetItemByAppId.cs) | [PublicGetItemByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemByAppId.cs) |
| `/platform/public/namespaces/{namespace}/items/byCriteria` | GET | PublicQueryItems | [PublicQueryItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicQueryItems.cs) | [PublicQueryItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicQueryItems.cs) |
| `/platform/public/namespaces/{namespace}/items/bySku` | GET | PublicGetItemBySku | [PublicGetItemBySku](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetItemBySku.cs) | [PublicGetItemBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemBySku.cs) |
| `/platform/public/namespaces/{namespace}/items/estimatedPrice` | GET | PublicGetEstimatedPrice | [PublicGetEstimatedPrice](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetEstimatedPrice.cs) | [PublicGetEstimatedPrice](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetEstimatedPrice.cs) |
| `/platform/public/namespaces/{namespace}/items/locale/byIds` | GET | PublicBulkGetItems | [PublicBulkGetItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicBulkGetItems.cs) | [PublicBulkGetItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicBulkGetItems.cs) |
| `/platform/public/namespaces/{namespace}/items/purchase/conditions/validate` | POST | PublicValidateItemPurchaseCondition | [PublicValidateItemPurchaseCondition](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicValidateItemPurchaseCondition.cs) | [PublicValidateItemPurchaseCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicValidateItemPurchaseCondition.cs) |
| `/platform/public/namespaces/{namespace}/items/search` | GET | PublicSearchItems | [PublicSearchItems](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicSearchItems.cs) | [PublicSearchItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicSearchItems.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/app/locale` | GET | PublicGetApp | [PublicGetApp](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetApp.cs) | [PublicGetApp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetApp.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/dynamic` | GET | PublicGetItemDynamicData | [PublicGetItemDynamicData](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetItemDynamicData.cs) | [PublicGetItemDynamicData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItemDynamicData.cs) |
| `/platform/public/namespaces/{namespace}/items/{itemId}/locale` | GET | PublicGetItem | [PublicGetItem](../../AccelByte.Sdk/Api/Platform/Operation/Item/PublicGetItem.cs) | [PublicGetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/PublicGetItem.cs) |
| `/platform/v2/admin/namespaces/{namespace}/items/byCriteria` | GET | QueryItemsV2 | [QueryItemsV2](../../AccelByte.Sdk/Api/Platform/Operation/Item/QueryItemsV2.cs) | [QueryItemsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Item/QueryItemsV2.cs) |

### Campaign Wrapper:  [Campaign](../../AccelByte.Sdk/Api/Platform/Wrapper/Campaign.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/campaigns` | GET | QueryCampaigns | [QueryCampaigns](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/QueryCampaigns.cs) | [QueryCampaigns](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryCampaigns.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns` | POST | CreateCampaign | [CreateCampaign](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/CreateCampaign.cs) | [CreateCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/CreateCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}` | GET | GetCampaign | [GetCampaign](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/GetCampaign.cs) | [GetCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}` | PUT | UpdateCampaign | [UpdateCampaign](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/UpdateCampaign.cs) | [UpdateCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/UpdateCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}/batchName` | PUT | RenameBatch | [RenameBatch](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/RenameBatch.cs) | [RenameBatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/RenameBatch.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}/batchNames` | GET | QueryCampaignBatchNames | [QueryCampaignBatchNames](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/QueryCampaignBatchNames.cs) | [QueryCampaignBatchNames](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryCampaignBatchNames.cs) |
| `/platform/admin/namespaces/{namespace}/campaigns/{campaignId}/dynamic` | GET | GetCampaignDynamic | [GetCampaignDynamic](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/GetCampaignDynamic.cs) | [GetCampaignDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCampaignDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}` | GET | QueryCodes | [QueryCodes](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/QueryCodes.cs) | [QueryCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}` | POST | CreateCodes | [CreateCodes](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/CreateCodes.cs) | [CreateCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/CreateCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/codes.csv` | GET | Download | [Download](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/Download.cs) | [Download](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/Download.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk` | PUT | BulkDisableCodes | [BulkDisableCodes](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/BulkDisableCodes.cs) | [BulkDisableCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/BulkDisableCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/enable/bulk` | PUT | BulkEnableCodes | [BulkEnableCodes](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/BulkEnableCodes.cs) | [BulkEnableCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/BulkEnableCodes.cs) |
| `/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/history` | GET | QueryRedeemHistory | [QueryRedeemHistory](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/QueryRedeemHistory.cs) | [QueryRedeemHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/QueryRedeemHistory.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}` | GET | GetCode | [GetCode](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/GetCode.cs) | [GetCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/GetCode.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}/disable` | PUT | DisableCode | [DisableCode](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/DisableCode.cs) | [DisableCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/DisableCode.cs) |
| `/platform/admin/namespaces/{namespace}/codes/{code}/enable` | PUT | EnableCode | [EnableCode](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/EnableCode.cs) | [EnableCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/EnableCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/redemption` | POST | ApplyUserRedemption | [ApplyUserRedemption](../../AccelByte.Sdk/Api/Platform/Operation/Campaign/ApplyUserRedemption.cs) | [ApplyUserRedemption](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Campaign/ApplyUserRedemption.cs) |

### Store Wrapper:  [Store](../../AccelByte.Sdk/Api/Platform/Wrapper/Store.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/catalog/configs` | GET | GetCatalogConfig | [GetCatalogConfig](../../AccelByte.Sdk/Api/Platform/Operation/Store/GetCatalogConfig.cs) | [GetCatalogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetCatalogConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/configs` | PUT | UpdateCatalogConfig | [UpdateCatalogConfig](../../AccelByte.Sdk/Api/Platform/Operation/Store/UpdateCatalogConfig.cs) | [UpdateCatalogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/UpdateCatalogConfig.cs) |
| `/platform/admin/namespaces/{namespace}/stores` | GET | ListStores | [ListStores](../../AccelByte.Sdk/Api/Platform/Operation/Store/ListStores.cs) | [ListStores](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ListStores.cs) |
| `/platform/admin/namespaces/{namespace}/stores` | POST | CreateStore | [CreateStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/CreateStore.cs) | [CreateStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/CreateStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/catalogDefinition` | GET | GetCatalogDefinition | [GetCatalogDefinition](../../AccelByte.Sdk/Api/Platform/Operation/Store/GetCatalogDefinition.cs) | [GetCatalogDefinition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetCatalogDefinition.cs) |
| `/platform/admin/namespaces/{namespace}/stores/downloadCSVTemplates` | GET | DownloadCSVTemplates | [DownloadCSVTemplates](../../AccelByte.Sdk/Api/Platform/Operation/Store/DownloadCSVTemplates.cs) | [DownloadCSVTemplates](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/DownloadCSVTemplates.cs) |
| `/platform/admin/namespaces/{namespace}/stores/exportByCSV` | POST | ExportStoreByCSV | [ExportStoreByCSV](../../AccelByte.Sdk/Api/Platform/Operation/Store/ExportStoreByCSV.cs) | [ExportStoreByCSV](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ExportStoreByCSV.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/stores/import` | PUT | ImportStore | [ImportStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/ImportStore.cs) | [ImportStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ImportStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published` | GET | GetPublishedStore | [GetPublishedStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/GetPublishedStore.cs) | [GetPublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetPublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published` | DELETE | DeletePublishedStore | [DeletePublishedStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/DeletePublishedStore.cs) | [DeletePublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/DeletePublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published/backup` | GET | GetPublishedStoreBackup | [GetPublishedStoreBackup](../../AccelByte.Sdk/Api/Platform/Operation/Store/GetPublishedStoreBackup.cs) | [GetPublishedStoreBackup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetPublishedStoreBackup.cs) |
| `/platform/admin/namespaces/{namespace}/stores/published/rollback` | PUT | RollbackPublishedStore | [RollbackPublishedStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/RollbackPublishedStore.cs) | [RollbackPublishedStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/RollbackPublishedStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | GET | GetStore | [GetStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/GetStore.cs) | [GetStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/GetStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | PUT | UpdateStore | [UpdateStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/UpdateStore.cs) | [UpdateStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/UpdateStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}` | DELETE | DeleteStore | [DeleteStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/DeleteStore.cs) | [DeleteStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/DeleteStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/clone` | PUT | CloneStore | [CloneStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/CloneStore.cs) | [CloneStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/CloneStore.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/stores/{storeId}/export` | GET | ExportStore | [ExportStore](../../AccelByte.Sdk/Api/Platform/Operation/Store/ExportStore.cs) | [ExportStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ExportStore.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/import/history` | GET | QueryImportHistory | [QueryImportHistory](../../AccelByte.Sdk/Api/Platform/Operation/Store/QueryImportHistory.cs) | [QueryImportHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/QueryImportHistory.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/importByCSV` | POST | ImportStoreByCSV | [ImportStoreByCSV](../../AccelByte.Sdk/Api/Platform/Operation/Store/ImportStoreByCSV.cs) | [ImportStoreByCSV](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ImportStoreByCSV.cs) |
| `/platform/public/namespaces/{namespace}/stores` | GET | PublicListStores | [PublicListStores](../../AccelByte.Sdk/Api/Platform/Operation/Store/PublicListStores.cs) | [PublicListStores](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/PublicListStores.cs) |
| `/platform/v2/admin/namespaces/{namespace}/stores/import` | PUT | ImportStore1 | [ImportStore1](../../AccelByte.Sdk/Api/Platform/Operation/Store/ImportStore1.cs) | [ImportStore1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ImportStore1.cs) |
| `/platform/v2/admin/namespaces/{namespace}/stores/{storeId}/export` | POST | ExportStore1 | [ExportStore1](../../AccelByte.Sdk/Api/Platform/Operation/Store/ExportStore1.cs) | [ExportStore1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Store/ExportStore1.cs) |

### ServicePluginConfig Wrapper:  [ServicePluginConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/ServicePluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | GET | GetLootBoxPluginConfig | [GetLootBoxPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/GetLootBoxPluginConfig.cs) | [GetLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | PUT | UpdateLootBoxPluginConfig | [UpdateLootBoxPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UpdateLootBoxPluginConfig.cs) | [UpdateLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox` | DELETE | DeleteLootBoxPluginConfig | [DeleteLootBoxPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/DeleteLootBoxPluginConfig.cs) | [DeleteLootBoxPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteLootBoxPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/customConfig/cert` | PUT | UplodLootBoxPluginConfigCert | [UplodLootBoxPluginConfigCert](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UplodLootBoxPluginConfigCert.cs) | [UplodLootBoxPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UplodLootBoxPluginConfigCert.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/lootbox/grpcInfo` | GET | GetLootBoxGrpcInfo | [GetLootBoxGrpcInfo](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/GetLootBoxGrpcInfo.cs) | [GetLootBoxGrpcInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetLootBoxGrpcInfo.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | GET | GetSectionPluginConfig | [GetSectionPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/GetSectionPluginConfig.cs) | [GetSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | PUT | UpdateSectionPluginConfig | [UpdateSectionPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UpdateSectionPluginConfig.cs) | [UpdateSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section` | DELETE | DeleteSectionPluginConfig | [DeleteSectionPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/DeleteSectionPluginConfig.cs) | [DeleteSectionPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteSectionPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/catalog/plugins/section/customConfig/cert` | PUT | UploadSectionPluginConfigCert | [UploadSectionPluginConfigCert](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UploadSectionPluginConfigCert.cs) | [UploadSectionPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UploadSectionPluginConfigCert.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | GET | GetServicePluginConfig | [GetServicePluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/GetServicePluginConfig.cs) | [GetServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetServicePluginConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | PUT | UpdateServicePluginConfig | [UpdateServicePluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UpdateServicePluginConfig.cs) | [UpdateServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateServicePluginConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/configs/servicePlugin` | DELETE | DeleteServicePluginConfig | [DeleteServicePluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/DeleteServicePluginConfig.cs) | [DeleteServicePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteServicePluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | GET | GetRevocationPluginConfig | [GetRevocationPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/GetRevocationPluginConfig.cs) | [GetRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/GetRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | PUT | UpdateRevocationPluginConfig | [UpdateRevocationPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UpdateRevocationPluginConfig.cs) | [UpdateRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UpdateRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation` | DELETE | DeleteRevocationPluginConfig | [DeleteRevocationPluginConfig](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/DeleteRevocationPluginConfig.cs) | [DeleteRevocationPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/DeleteRevocationPluginConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/plugins/revocation/revocation/customConfig/cert` | PUT | UploadRevocationPluginConfigCert | [UploadRevocationPluginConfigCert](../../AccelByte.Sdk/Api/Platform/Operation/ServicePluginConfig/UploadRevocationPluginConfigCert.cs) | [UploadRevocationPluginConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/ServicePluginConfig/UploadRevocationPluginConfigCert.cs) |

### Category Wrapper:  [Category](../../AccelByte.Sdk/Api/Platform/Wrapper/Category.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/categories` | GET | GetRootCategories | [GetRootCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/GetRootCategories.cs) | [GetRootCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetRootCategories.cs) |
| `/platform/admin/namespaces/{namespace}/categories` | POST | CreateCategory | [CreateCategory](../../AccelByte.Sdk/Api/Platform/Operation/Category/CreateCategory.cs) | [CreateCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/CreateCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/basic` | GET | ListCategoriesBasic | [ListCategoriesBasic](../../AccelByte.Sdk/Api/Platform/Operation/Category/ListCategoriesBasic.cs) | [ListCategoriesBasic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/ListCategoriesBasic.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | GET | GetCategory | [GetCategory](../../AccelByte.Sdk/Api/Platform/Operation/Category/GetCategory.cs) | [GetCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | PUT | UpdateCategory | [UpdateCategory](../../AccelByte.Sdk/Api/Platform/Operation/Category/UpdateCategory.cs) | [UpdateCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/UpdateCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}` | DELETE | DeleteCategory | [DeleteCategory](../../AccelByte.Sdk/Api/Platform/Operation/Category/DeleteCategory.cs) | [DeleteCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/DeleteCategory.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}/children` | GET | GetChildCategories | [GetChildCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/GetChildCategories.cs) | [GetChildCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetChildCategories.cs) |
| `/platform/admin/namespaces/{namespace}/categories/{categoryPath}/descendants` | GET | GetDescendantCategories | [GetDescendantCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/GetDescendantCategories.cs) | [GetDescendantCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/GetDescendantCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories` | GET | PublicGetRootCategories | [PublicGetRootCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/PublicGetRootCategories.cs) | [PublicGetRootCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetRootCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/download` | GET | DownloadCategories | [DownloadCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/DownloadCategories.cs) | [DownloadCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/DownloadCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}` | GET | PublicGetCategory | [PublicGetCategory](../../AccelByte.Sdk/Api/Platform/Operation/Category/PublicGetCategory.cs) | [PublicGetCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetCategory.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}/children` | GET | PublicGetChildCategories | [PublicGetChildCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/PublicGetChildCategories.cs) | [PublicGetChildCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetChildCategories.cs) |
| `/platform/public/namespaces/{namespace}/categories/{categoryPath}/descendants` | GET | PublicGetDescendantCategories | [PublicGetDescendantCategories](../../AccelByte.Sdk/Api/Platform/Operation/Category/PublicGetDescendantCategories.cs) | [PublicGetDescendantCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Category/PublicGetDescendantCategories.cs) |

### Currency Wrapper:  [Currency](../../AccelByte.Sdk/Api/Platform/Wrapper/Currency.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/currencies` | GET | ListCurrencies | [ListCurrencies](../../AccelByte.Sdk/Api/Platform/Operation/Currency/ListCurrencies.cs) | [ListCurrencies](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/ListCurrencies.cs) |
| `/platform/admin/namespaces/{namespace}/currencies` | POST | CreateCurrency | [CreateCurrency](../../AccelByte.Sdk/Api/Platform/Operation/Currency/CreateCurrency.cs) | [CreateCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/CreateCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}` | PUT | UpdateCurrency | [UpdateCurrency](../../AccelByte.Sdk/Api/Platform/Operation/Currency/UpdateCurrency.cs) | [UpdateCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/UpdateCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}` | DELETE | DeleteCurrency | [DeleteCurrency](../../AccelByte.Sdk/Api/Platform/Operation/Currency/DeleteCurrency.cs) | [DeleteCurrency](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/DeleteCurrency.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/config` | GET | GetCurrencyConfig | [GetCurrencyConfig](../../AccelByte.Sdk/Api/Platform/Operation/Currency/GetCurrencyConfig.cs) | [GetCurrencyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/GetCurrencyConfig.cs) |
| `/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary` | GET | GetCurrencySummary | [GetCurrencySummary](../../AccelByte.Sdk/Api/Platform/Operation/Currency/GetCurrencySummary.cs) | [GetCurrencySummary](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/GetCurrencySummary.cs) |
| `/platform/public/namespaces/{namespace}/currencies` | GET | PublicListCurrencies | [PublicListCurrencies](../../AccelByte.Sdk/Api/Platform/Operation/Currency/PublicListCurrencies.cs) | [PublicListCurrencies](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Currency/PublicListCurrencies.cs) |

### DLC Wrapper:  [DLC](../../AccelByte.Sdk/Api/Platform/Wrapper/DLC.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/dlc/config/history` | GET | GetDLCItemConfigHistory | [GetDLCItemConfigHistory](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetDLCItemConfigHistory.cs) | [GetDLCItemConfigHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetDLCItemConfigHistory.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/history/{id}/restore` | POST | RestoreDLCItemConfigHistory | [RestoreDLCItemConfigHistory](../../AccelByte.Sdk/Api/Platform/Operation/DLC/RestoreDLCItemConfigHistory.cs) | [RestoreDLCItemConfigHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/RestoreDLCItemConfigHistory.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | GET | GetDLCItemConfig | [GetDLCItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetDLCItemConfig.cs) | [GetDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | PUT | UpdateDLCItemConfig | [UpdateDLCItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/UpdateDLCItemConfig.cs) | [UpdateDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/UpdateDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/item` | DELETE | DeleteDLCItemConfig | [DeleteDLCItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/DeleteDLCItemConfig.cs) | [DeleteDLCItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/DeleteDLCItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | GET | GetPlatformDLCConfig | [GetPlatformDLCConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetPlatformDLCConfig.cs) | [GetPlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetPlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | PUT | UpdatePlatformDLCConfig | [UpdatePlatformDLCConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/UpdatePlatformDLCConfig.cs) | [UpdatePlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/UpdatePlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/dlc/config/platformMap` | DELETE | DeletePlatformDLCConfig | [DeletePlatformDLCConfig](../../AccelByte.Sdk/Api/Platform/Operation/DLC/DeletePlatformDLCConfig.cs) | [DeletePlatformDLCConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/DeletePlatformDLCConfig.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc` | GET | GetUserDLCByPlatform | [GetUserDLCByPlatform](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetUserDLCByPlatform.cs) | [GetUserDLCByPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLCByPlatform.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc/records` | GET | GetUserDLC | [GetUserDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetUserDLC.cs) | [GetUserDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLC.cs) |
| `/platform/public/namespaces/{namespace}/dlc/rewards/durable/map` | GET | GeDLCDurableRewardShortMap | [GeDLCDurableRewardShortMap](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GeDLCDurableRewardShortMap.cs) | [GeDLCDurableRewardShortMap](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GeDLCDurableRewardShortMap.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/epicgames/sync` | PUT | SyncEpicGameDLC | [SyncEpicGameDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/SyncEpicGameDLC.cs) | [SyncEpicGameDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncEpicGameDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/oculus/sync` | PUT | SyncOculusDLC | [SyncOculusDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/SyncOculusDLC.cs) | [SyncOculusDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncOculusDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync` | PUT | PublicSyncPsnDlcInventory | [PublicSyncPsnDlcInventory](../../AccelByte.Sdk/Api/Platform/Operation/DLC/PublicSyncPsnDlcInventory.cs) | [PublicSyncPsnDlcInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/PublicSyncPsnDlcInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync/multiServiceLabels` | PUT | PublicSyncPsnDlcInventoryWithMultipleServiceLabels | [PublicSyncPsnDlcInventoryWithMultipleServiceLabels](../../AccelByte.Sdk/Api/Platform/Operation/DLC/PublicSyncPsnDlcInventoryWithMultipleServiceLabels.cs) | [PublicSyncPsnDlcInventoryWithMultipleServiceLabels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/PublicSyncPsnDlcInventoryWithMultipleServiceLabels.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/steam/sync` | PUT | SyncSteamDLC | [SyncSteamDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/SyncSteamDLC.cs) | [SyncSteamDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncSteamDLC.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/dlc/xbl/sync` | PUT | SyncXboxDLC | [SyncXboxDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/SyncXboxDLC.cs) | [SyncXboxDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/SyncXboxDLC.cs) |
| `/platform/public/users/me/dlc/content` | GET | PublicGetMyDLCContent | [PublicGetMyDLCContent](../../AccelByte.Sdk/Api/Platform/Operation/DLC/PublicGetMyDLCContent.cs) | [PublicGetMyDLCContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/PublicGetMyDLCContent.cs) |

### Entitlement Wrapper:  [Entitlement](../../AccelByte.Sdk/Api/Platform/Wrapper/Entitlement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/entitlements` | GET | QueryEntitlements | [QueryEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/QueryEntitlements.cs) | [QueryEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/byItemIds` | GET | QueryEntitlementsByItemIds | [QueryEntitlementsByItemIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/QueryEntitlementsByItemIds.cs) | [QueryEntitlementsByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryEntitlementsByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/config/entitlementOrigin/enable` | PUT | EnableEntitlementOriginFeature | [EnableEntitlementOriginFeature](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/EnableEntitlementOriginFeature.cs) | [EnableEntitlementOriginFeature](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/EnableEntitlementOriginFeature.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/config/info` | GET | GetEntitlementConfigInfo | [GetEntitlementConfigInfo](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetEntitlementConfigInfo.cs) | [GetEntitlementConfigInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetEntitlementConfigInfo.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/grant` | POST | GrantEntitlements | [GrantEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GrantEntitlements.cs) | [GrantEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GrantEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/revoke` | POST | RevokeEntitlements | [RevokeEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeEntitlements.cs) | [RevokeEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/entitlements/{entitlementId}` | GET | GetEntitlement | [GetEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetEntitlement.cs) | [GetEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/entitlement/config` | GET | GetPlatformEntitlementConfig | [GetPlatformEntitlementConfig](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetPlatformEntitlementConfig.cs) | [GetPlatformEntitlementConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetPlatformEntitlementConfig.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/entitlement/config` | PUT | UpdatePlatformEntitlementConfig | [UpdatePlatformEntitlementConfig](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/UpdatePlatformEntitlementConfig.cs) | [UpdatePlatformEntitlementConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/UpdatePlatformEntitlementConfig.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements` | GET | QueryUserEntitlements | [QueryUserEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/QueryUserEntitlements.cs) | [QueryUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryUserEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements` | POST | GrantUserEntitlement | [GrantUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GrantUserEntitlement.cs) | [GrantUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GrantUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId` | GET | GetUserAppEntitlementByAppId | [GetUserAppEntitlementByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserAppEntitlementByAppId.cs) | [GetUserAppEntitlementByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserAppEntitlementByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType` | GET | QueryUserEntitlementsByAppType | [QueryUserEntitlementsByAppType](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/QueryUserEntitlementsByAppType.cs) | [QueryUserEntitlementsByAppType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/QueryUserEntitlementsByAppType.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byIds` | GET | GetUserEntitlementsByIds | [GetUserEntitlementsByIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementsByIds.cs) | [GetUserEntitlementsByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementsByIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId` | GET | GetUserEntitlementByItemId | [GetUserEntitlementByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementByItemId.cs) | [GetUserEntitlementByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemIds` | GET | GetUserActiveEntitlementsByItemIds | [GetUserActiveEntitlementsByItemIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserActiveEntitlementsByItemIds.cs) | [GetUserActiveEntitlementsByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserActiveEntitlementsByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku` | GET | GetUserEntitlementBySku | [GetUserEntitlementBySku](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementBySku.cs) | [GetUserEntitlementBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementBySku.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/any` | GET | ExistsAnyUserActiveEntitlement | [ExistsAnyUserActiveEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/ExistsAnyUserActiveEntitlement.cs) | [ExistsAnyUserActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ExistsAnyUserActiveEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/anyOf` | GET | ExistsAnyUserActiveEntitlementByItemIds | [ExistsAnyUserActiveEntitlementByItemIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/ExistsAnyUserActiveEntitlementByItemIds.cs) | [ExistsAnyUserActiveEntitlementByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ExistsAnyUserActiveEntitlementByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId` | GET | GetUserAppEntitlementOwnershipByAppId | [GetUserAppEntitlementOwnershipByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserAppEntitlementOwnershipByAppId.cs) | [GetUserAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserAppEntitlementOwnershipByAppId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId` | GET | GetUserEntitlementOwnershipByItemId | [GetUserEntitlementOwnershipByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementOwnershipByItemId.cs) | [GetUserEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemIds` | GET | GetUserEntitlementOwnershipByItemIds | [GetUserEntitlementOwnershipByItemIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementOwnershipByItemIds.cs) | [GetUserEntitlementOwnershipByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipByItemIds.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku` | GET | GetUserEntitlementOwnershipBySku | [GetUserEntitlementOwnershipBySku](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementOwnershipBySku.cs) | [GetUserEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementOwnershipBySku.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke` | PUT | RevokeAllEntitlements | [RevokeAllEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeAllEntitlements.cs) | [RevokeAllEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeAllEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke/byIds` | PUT | RevokeUserEntitlements | [RevokeUserEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeUserEntitlements.cs) | [RevokeUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUserEntitlements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | GET | GetUserEntitlement | [GetUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlement.cs) | [GetUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | PUT | UpdateUserEntitlement | [UpdateUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/UpdateUserEntitlement.cs) | [UpdateUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/UpdateUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement` | PUT | ConsumeUserEntitlement | [ConsumeUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/ConsumeUserEntitlement.cs) | [ConsumeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/ConsumeUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable` | PUT | DisableUserEntitlement | [DisableUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/DisableUserEntitlement.cs) | [DisableUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/DisableUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable` | PUT | EnableUserEntitlement | [EnableUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/EnableUserEntitlement.cs) | [EnableUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/EnableUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/history` | GET | GetUserEntitlementHistories | [GetUserEntitlementHistories](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/GetUserEntitlementHistories.cs) | [GetUserEntitlementHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/GetUserEntitlementHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke` | PUT | RevokeUserEntitlement | [RevokeUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeUserEntitlement.cs) | [RevokeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUserEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke/byUseCount` | POST | RevokeUserEntitlementByUseCount | [RevokeUserEntitlementByUseCount](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeUserEntitlementByUseCount.cs) | [RevokeUserEntitlementByUseCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUserEntitlementByUseCount.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke/byUseCount/preCheck` | GET | PreCheckRevokeUserEntitlementByUseCount | [PreCheckRevokeUserEntitlementByUseCount](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PreCheckRevokeUserEntitlementByUseCount.cs) | [PreCheckRevokeUserEntitlementByUseCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PreCheckRevokeUserEntitlementByUseCount.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revokeByUseCount` | PUT | RevokeUseCount | [RevokeUseCount](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/RevokeUseCount.cs) | [RevokeUseCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/RevokeUseCount.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell` | PUT | SellUserEntitlement | [SellUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/SellUserEntitlement.cs) | [SellUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/SellUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/any` | GET | PublicExistsAnyMyActiveEntitlement | [PublicExistsAnyMyActiveEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicExistsAnyMyActiveEntitlement.cs) | [PublicExistsAnyMyActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicExistsAnyMyActiveEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byAppId` | GET | PublicGetMyAppEntitlementOwnershipByAppId | [PublicGetMyAppEntitlementOwnershipByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetMyAppEntitlementOwnershipByAppId.cs) | [PublicGetMyAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyAppEntitlementOwnershipByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byItemId` | GET | PublicGetMyEntitlementOwnershipByItemId | [PublicGetMyEntitlementOwnershipByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetMyEntitlementOwnershipByItemId.cs) | [PublicGetMyEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyEntitlementOwnershipByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku` | GET | PublicGetMyEntitlementOwnershipBySku | [PublicGetMyEntitlementOwnershipBySku](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetMyEntitlementOwnershipBySku.cs) | [PublicGetMyEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetMyEntitlementOwnershipBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken` | GET | PublicGetEntitlementOwnershipToken | [PublicGetEntitlementOwnershipToken](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetEntitlementOwnershipToken.cs) | [PublicGetEntitlementOwnershipToken](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetEntitlementOwnershipToken.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements` | GET | PublicQueryUserEntitlements | [PublicQueryUserEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicQueryUserEntitlements.cs) | [PublicQueryUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicQueryUserEntitlements.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId` | GET | PublicGetUserAppEntitlementByAppId | [PublicGetUserAppEntitlementByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserAppEntitlementByAppId.cs) | [PublicGetUserAppEntitlementByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserAppEntitlementByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType` | GET | PublicQueryUserEntitlementsByAppType | [PublicQueryUserEntitlementsByAppType](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicQueryUserEntitlementsByAppType.cs) | [PublicQueryUserEntitlementsByAppType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicQueryUserEntitlementsByAppType.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byIds` | GET | PublicGetUserEntitlementsByIds | [PublicGetUserEntitlementsByIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementsByIds.cs) | [PublicGetUserEntitlementsByIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementsByIds.cs) |
| [DEPRECATED] `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId` | GET | PublicGetUserEntitlementByItemId | [PublicGetUserEntitlementByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementByItemId.cs) | [PublicGetUserEntitlementByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementByItemId.cs) |
| [DEPRECATED] `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku` | GET | PublicGetUserEntitlementBySku | [PublicGetUserEntitlementBySku](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementBySku.cs) | [PublicGetUserEntitlementBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/history` | GET | PublicUserEntitlementHistory | [PublicUserEntitlementHistory](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicUserEntitlementHistory.cs) | [PublicUserEntitlementHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicUserEntitlementHistory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/any` | GET | PublicExistsAnyUserActiveEntitlement | [PublicExistsAnyUserActiveEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicExistsAnyUserActiveEntitlement.cs) | [PublicExistsAnyUserActiveEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicExistsAnyUserActiveEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId` | GET | PublicGetUserAppEntitlementOwnershipByAppId | [PublicGetUserAppEntitlementOwnershipByAppId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserAppEntitlementOwnershipByAppId.cs) | [PublicGetUserAppEntitlementOwnershipByAppId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserAppEntitlementOwnershipByAppId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId` | GET | PublicGetUserEntitlementOwnershipByItemId | [PublicGetUserEntitlementOwnershipByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipByItemId.cs) | [PublicGetUserEntitlementOwnershipByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemIds` | GET | PublicGetUserEntitlementOwnershipByItemIds | [PublicGetUserEntitlementOwnershipByItemIds](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipByItemIds.cs) | [PublicGetUserEntitlementOwnershipByItemIds](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipByItemIds.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku` | GET | PublicGetUserEntitlementOwnershipBySku | [PublicGetUserEntitlementOwnershipBySku](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlementOwnershipBySku.cs) | [PublicGetUserEntitlementOwnershipBySku](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlementOwnershipBySku.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}` | GET | PublicGetUserEntitlement | [PublicGetUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicGetUserEntitlement.cs) | [PublicGetUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicGetUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement` | PUT | PublicConsumeUserEntitlement | [PublicConsumeUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicConsumeUserEntitlement.cs) | [PublicConsumeUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicConsumeUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/sell` | PUT | PublicSellUserEntitlement | [PublicSellUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicSellUserEntitlement.cs) | [PublicSellUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicSellUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/split` | PUT | PublicSplitUserEntitlement | [PublicSplitUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicSplitUserEntitlement.cs) | [PublicSplitUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicSplitUserEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/transfer` | PUT | PublicTransferUserEntitlement | [PublicTransferUserEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Entitlement/PublicTransferUserEntitlement.cs) | [PublicTransferUserEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Entitlement/PublicTransferUserEntitlement.cs) |

### Fulfillment Wrapper:  [Fulfillment](../../AccelByte.Sdk/Api/Platform/Wrapper/Fulfillment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/fulfillment/history` | GET | QueryFulfillmentHistories | [QueryFulfillmentHistories](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/QueryFulfillmentHistories.cs) | [QueryFulfillmentHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/QueryFulfillmentHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment` | POST | FulfillItem | [FulfillItem](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/FulfillItem.cs) | [FulfillItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/code` | POST | RedeemCode | [RedeemCode](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/RedeemCode.cs) | [RedeemCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RedeemCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/preCheck` | POST | PreCheckFulfillItem | [PreCheckFulfillItem](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/PreCheckFulfillItem.cs) | [PreCheckFulfillItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/PreCheckFulfillItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards` | POST | FulfillRewards | [FulfillRewards](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/FulfillRewards.cs) | [FulfillRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillRewards.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/fulfillment/code` | POST | PublicRedeemCode | [PublicRedeemCode](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/PublicRedeemCode.cs) | [PublicRedeemCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/PublicRedeemCode.cs) |
| `/platform/v2/admin/namespaces/{namespace}/fulfillments` | GET | QueryFulfillments | [QueryFulfillments](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/QueryFulfillments.cs) | [QueryFulfillments](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/QueryFulfillments.cs) |
| `/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards` | POST | FulfillRewardsV2 | [FulfillRewardsV2](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/FulfillRewardsV2.cs) | [FulfillRewardsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillRewardsV2.cs) |
| [DEPRECATED] `/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}` | PUT | FulfillItems | [FulfillItems](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/FulfillItems.cs) | [FulfillItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillItems.cs) |
| [DEPRECATED] `/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/retry` | PUT | RetryFulfillItems | [RetryFulfillItems](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/RetryFulfillItems.cs) | [RetryFulfillItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RetryFulfillItems.cs) |
| [DEPRECATED] `/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/revoke` | PUT | RevokeItems | [RevokeItems](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/RevokeItems.cs) | [RevokeItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RevokeItems.cs) |
| `/platform/v3/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}` | PUT | FulfillItemsV3 | [FulfillItemsV3](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/FulfillItemsV3.cs) | [FulfillItemsV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/FulfillItemsV3.cs) |
| `/platform/v3/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/retry` | PUT | RetryFulfillItemsV3 | [RetryFulfillItemsV3](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/RetryFulfillItemsV3.cs) | [RetryFulfillItemsV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RetryFulfillItemsV3.cs) |
| `/platform/v3/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/revoke` | PUT | RevokeItemsV3 | [RevokeItemsV3](../../AccelByte.Sdk/Api/Platform/Operation/Fulfillment/RevokeItemsV3.cs) | [RevokeItemsV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Fulfillment/RevokeItemsV3.cs) |

### Clawback Wrapper:  [Clawback](../../AccelByte.Sdk/Api/Platform/Wrapper/Clawback.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/clawback/histories` | GET | QueryIAPClawbackHistory | [QueryIAPClawbackHistory](../../AccelByte.Sdk/Api/Platform/Operation/Clawback/QueryIAPClawbackHistory.cs) | [QueryIAPClawbackHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/QueryIAPClawbackHistory.cs) |
| `/platform/admin/namespaces/{namespace}/iap/clawback/playstation/mock` | POST | MockPlayStationStreamEvent | [MockPlayStationStreamEvent](../../AccelByte.Sdk/Api/Platform/Operation/Clawback/MockPlayStationStreamEvent.cs) | [MockPlayStationStreamEvent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/MockPlayStationStreamEvent.cs) |
| `/platform/admin/namespaces/{namespace}/iap/clawback/xbl/mock` | POST | MockXblClawbackEvent | [MockXblClawbackEvent](../../AccelByte.Sdk/Api/Platform/Operation/Clawback/MockXblClawbackEvent.cs) | [MockXblClawbackEvent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/MockXblClawbackEvent.cs) |

### IAP Wrapper:  [IAP](../../AccelByte.Sdk/Api/Platform/Wrapper/IAP.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | GET | GetAppleIAPConfig | [GetAppleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetAppleIAPConfig.cs) | [GetAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | PUT | UpdateAppleIAPConfig | [UpdateAppleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateAppleIAPConfig.cs) | [UpdateAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/apple` | DELETE | DeleteAppleIAPConfig | [DeleteAppleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteAppleIAPConfig.cs) | [DeleteAppleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteAppleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/apple/cert` | PUT | UpdateAppleP8File | [UpdateAppleP8File](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateAppleP8File.cs) | [UpdateAppleP8File](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateAppleP8File.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | GET | GetEpicGamesIAPConfig | [GetEpicGamesIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetEpicGamesIAPConfig.cs) | [GetEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | PUT | UpdateEpicGamesIAPConfig | [UpdateEpicGamesIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateEpicGamesIAPConfig.cs) | [UpdateEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/epicgames` | DELETE | DeleteEpicGamesIAPConfig | [DeleteEpicGamesIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteEpicGamesIAPConfig.cs) | [DeleteEpicGamesIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteEpicGamesIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | GET | GetGoogleIAPConfig | [GetGoogleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetGoogleIAPConfig.cs) | [GetGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | PUT | UpdateGoogleIAPConfig | [UpdateGoogleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateGoogleIAPConfig.cs) | [UpdateGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google` | DELETE | DeleteGoogleIAPConfig | [DeleteGoogleIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteGoogleIAPConfig.cs) | [DeleteGoogleIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteGoogleIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/google/cert` | PUT | UpdateGoogleP12File | [UpdateGoogleP12File](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateGoogleP12File.cs) | [UpdateGoogleP12File](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateGoogleP12File.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | GET | GetIAPItemConfig | [GetIAPItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetIAPItemConfig.cs) | [GetIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | PUT | UpdateIAPItemConfig | [UpdateIAPItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateIAPItemConfig.cs) | [UpdateIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/item` | DELETE | DeleteIAPItemConfig | [DeleteIAPItemConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteIAPItemConfig.cs) | [DeleteIAPItemConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteIAPItemConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | GET | GetOculusIAPConfig | [GetOculusIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetOculusIAPConfig.cs) | [GetOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | PUT | UpdateOculusIAPConfig | [UpdateOculusIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateOculusIAPConfig.cs) | [UpdateOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/oculus` | DELETE | DeleteOculusIAPConfig | [DeleteOculusIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteOculusIAPConfig.cs) | [DeleteOculusIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteOculusIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | GET | GetPlayStationIAPConfig | [GetPlayStationIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetPlayStationIAPConfig.cs) | [GetPlayStationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetPlayStationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | PUT | UpdatePlaystationIAPConfig | [UpdatePlaystationIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdatePlaystationIAPConfig.cs) | [UpdatePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdatePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation` | DELETE | DeletePlaystationIAPConfig | [DeletePlaystationIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeletePlaystationIAPConfig.cs) | [DeletePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeletePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation/validate` | GET | ValidateExistedPlaystationIAPConfig | [ValidateExistedPlaystationIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/ValidateExistedPlaystationIAPConfig.cs) | [ValidateExistedPlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/ValidateExistedPlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/playstation/validate` | PUT | ValidatePlaystationIAPConfig | [ValidatePlaystationIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/ValidatePlaystationIAPConfig.cs) | [ValidatePlaystationIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/ValidatePlaystationIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | GET | GetSteamIAPConfig | [GetSteamIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetSteamIAPConfig.cs) | [GetSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | PUT | UpdateSteamIAPConfig | [UpdateSteamIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateSteamIAPConfig.cs) | [UpdateSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/steam` | DELETE | DeleteSteamIAPConfig | [DeleteSteamIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteSteamIAPConfig.cs) | [DeleteSteamIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteSteamIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | GET | GetTwitchIAPConfig | [GetTwitchIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetTwitchIAPConfig.cs) | [GetTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | PUT | UpdateTwitchIAPConfig | [UpdateTwitchIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateTwitchIAPConfig.cs) | [UpdateTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/twitch` | DELETE | DeleteTwitchIAPConfig | [DeleteTwitchIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteTwitchIAPConfig.cs) | [DeleteTwitchIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteTwitchIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | GET | GetXblIAPConfig | [GetXblIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetXblIAPConfig.cs) | [GetXblIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetXblIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | PUT | UpdateXblIAPConfig | [UpdateXblIAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateXblIAPConfig.cs) | [UpdateXblIAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateXblIAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl` | DELETE | DeleteXblAPConfig | [DeleteXblAPConfig](../../AccelByte.Sdk/Api/Platform/Operation/IAP/DeleteXblAPConfig.cs) | [DeleteXblAPConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/DeleteXblAPConfig.cs) |
| `/platform/admin/namespaces/{namespace}/iap/config/xbl/cert` | PUT | UpdateXblBPCertFile | [UpdateXblBPCertFile](../../AccelByte.Sdk/Api/Platform/Operation/IAP/UpdateXblBPCertFile.cs) | [UpdateXblBPCertFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/UpdateXblBPCertFile.cs) |
| `/platform/admin/namespaces/{namespace}/iap/steam/abnormal_transactions` | GET | QueryAbnormalTransactions | [QueryAbnormalTransactions](../../AccelByte.Sdk/Api/Platform/Operation/IAP/QueryAbnormalTransactions.cs) | [QueryAbnormalTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryAbnormalTransactions.cs) |
| `/platform/admin/namespaces/{namespace}/iap/steam/job` | GET | AdminGetSteamJobInfo | [AdminGetSteamJobInfo](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminGetSteamJobInfo.cs) | [AdminGetSteamJobInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminGetSteamJobInfo.cs) |
| `/platform/admin/namespaces/{namespace}/iap/steam/job/reset` | PUT | AdminResetSteamJobTime | [AdminResetSteamJobTime](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminResetSteamJobTime.cs) | [AdminResetSteamJobTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminResetSteamJobTime.cs) |
| `/platform/admin/namespaces/{namespace}/iap/steam/orders/{iapOrderNo}/refund` | PUT | AdminRefundIAPOrder | [AdminRefundIAPOrder](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminRefundIAPOrder.cs) | [AdminRefundIAPOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminRefundIAPOrder.cs) |
| `/platform/admin/namespaces/{namespace}/iap/steam/report/histories` | GET | QuerySteamReportHistories | [QuerySteamReportHistories](../../AccelByte.Sdk/Api/Platform/Operation/IAP/QuerySteamReportHistories.cs) | [QuerySteamReportHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QuerySteamReportHistories.cs) |
| `/platform/admin/namespaces/{namespace}/iap/{iapOrderNo}/consumedetails` | GET | GetIAPOrderConsumeDetails | [GetIAPOrderConsumeDetails](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetIAPOrderConsumeDetails.cs) | [GetIAPOrderConsumeDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetIAPOrderConsumeDetails.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap` | GET | QueryUserIAPOrders | [QueryUserIAPOrders](../../AccelByte.Sdk/Api/Platform/Operation/IAP/QueryUserIAPOrders.cs) | [QueryUserIAPOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryUserIAPOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/all` | GET | QueryAllUserIAPOrders | [QueryAllUserIAPOrders](../../AccelByte.Sdk/Api/Platform/Operation/IAP/QueryAllUserIAPOrders.cs) | [QueryAllUserIAPOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryAllUserIAPOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/consume/history` | GET | QueryUserIAPConsumeHistory | [QueryUserIAPConsumeHistory](../../AccelByte.Sdk/Api/Platform/Operation/IAP/QueryUserIAPConsumeHistory.cs) | [QueryUserIAPConsumeHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/QueryUserIAPConsumeHistory.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/mock/receipt` | PUT | MockFulfillIAPItem | [MockFulfillIAPItem](../../AccelByte.Sdk/Api/Platform/Operation/IAP/MockFulfillIAPItem.cs) | [MockFulfillIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/MockFulfillIAPItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/orders/{iapOrderNo}/line_items` | GET | AdminGetIAPOrderLineItems | [AdminGetIAPOrderLineItems](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminGetIAPOrderLineItems.cs) | [AdminGetIAPOrderLineItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminGetIAPOrderLineItems.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/steam/syncAbnormalTransaction` | PUT | AdminSyncSteamAbnormalTransaction | [AdminSyncSteamAbnormalTransaction](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminSyncSteamAbnormalTransaction.cs) | [AdminSyncSteamAbnormalTransaction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminSyncSteamAbnormalTransaction.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/steam/syncByTransaction` | PUT | AdminSyncSteamIAPByTransaction | [AdminSyncSteamIAPByTransaction](../../AccelByte.Sdk/Api/Platform/Operation/IAP/AdminSyncSteamIAPByTransaction.cs) | [AdminSyncSteamIAPByTransaction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/AdminSyncSteamIAPByTransaction.cs) |
| `/platform/public/namespaces/{namespace}/iap/apple/config/version` | GET | GetAppleConfigVersion | [GetAppleConfigVersion](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetAppleConfigVersion.cs) | [GetAppleConfigVersion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetAppleConfigVersion.cs) |
| `/platform/public/namespaces/{namespace}/iap/item/mapping` | GET | GetIAPItemMapping | [GetIAPItemMapping](../../AccelByte.Sdk/Api/Platform/Operation/IAP/GetIAPItemMapping.cs) | [GetIAPItemMapping](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/GetIAPItemMapping.cs) |
| `/platform/public/namespaces/{namespace}/users/me/iap/twitch/sync` | PUT | SyncTwitchDropsEntitlement | [SyncTwitchDropsEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncTwitchDropsEntitlement.cs) | [SyncTwitchDropsEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncTwitchDropsEntitlement.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt` | PUT | PublicFulfillAppleIAPItem | [PublicFulfillAppleIAPItem](../../AccelByte.Sdk/Api/Platform/Operation/IAP/PublicFulfillAppleIAPItem.cs) | [PublicFulfillAppleIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicFulfillAppleIAPItem.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/epicgames/sync` | PUT | SyncEpicGamesInventory | [SyncEpicGamesInventory](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncEpicGamesInventory.cs) | [SyncEpicGamesInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncEpicGamesInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/google/receipt` | PUT | PublicFulfillGoogleIAPItem | [PublicFulfillGoogleIAPItem](../../AccelByte.Sdk/Api/Platform/Operation/IAP/PublicFulfillGoogleIAPItem.cs) | [PublicFulfillGoogleIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicFulfillGoogleIAPItem.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/oculus/sync` | PUT | SyncOculusConsumableEntitlements | [SyncOculusConsumableEntitlements](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncOculusConsumableEntitlements.cs) | [SyncOculusConsumableEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncOculusConsumableEntitlements.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync` | PUT | PublicReconcilePlayStationStore | [PublicReconcilePlayStationStore](../../AccelByte.Sdk/Api/Platform/Operation/IAP/PublicReconcilePlayStationStore.cs) | [PublicReconcilePlayStationStore](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicReconcilePlayStationStore.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync/multiServiceLabels` | PUT | PublicReconcilePlayStationStoreWithMultipleServiceLabels | [PublicReconcilePlayStationStoreWithMultipleServiceLabels](../../AccelByte.Sdk/Api/Platform/Operation/IAP/PublicReconcilePlayStationStoreWithMultipleServiceLabels.cs) | [PublicReconcilePlayStationStoreWithMultipleServiceLabels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/PublicReconcilePlayStationStoreWithMultipleServiceLabels.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/sync` | PUT | SyncSteamInventory | [SyncSteamInventory](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncSteamInventory.cs) | [SyncSteamInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncSteamInventory.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/syncAbnormalTransaction` | PUT | SyncSteamAbnormalTransaction | [SyncSteamAbnormalTransaction](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncSteamAbnormalTransaction.cs) | [SyncSteamAbnormalTransaction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncSteamAbnormalTransaction.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/syncByTransaction` | PUT | SyncSteamIAPByTransaction | [SyncSteamIAPByTransaction](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncSteamIAPByTransaction.cs) | [SyncSteamIAPByTransaction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncSteamIAPByTransaction.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/twitch/sync` | PUT | SyncTwitchDropsEntitlement1 | [SyncTwitchDropsEntitlement1](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncTwitchDropsEntitlement1.cs) | [SyncTwitchDropsEntitlement1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncTwitchDropsEntitlement1.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/xbl/sync` | PUT | SyncXboxInventory | [SyncXboxInventory](../../AccelByte.Sdk/Api/Platform/Operation/IAP/SyncXboxInventory.cs) | [SyncXboxInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/SyncXboxInventory.cs) |
| `/platform/v2/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt` | PUT | V2PublicFulfillAppleIAPItem | [V2PublicFulfillAppleIAPItem](../../AccelByte.Sdk/Api/Platform/Operation/IAP/V2PublicFulfillAppleIAPItem.cs) | [V2PublicFulfillAppleIAPItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAP/V2PublicFulfillAppleIAPItem.cs) |

### IAP(Notification) Wrapper:  [IAPNotification](../../AccelByte.Sdk/Api/Platform/Wrapper/IAPNotification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/notifications` | GET | QueryThirdPartyNotifications | [QueryThirdPartyNotifications](../../AccelByte.Sdk/Api/Platform/Operation/IAPNotification/QueryThirdPartyNotifications.cs) | [QueryThirdPartyNotifications](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPNotification/QueryThirdPartyNotifications.cs) |

### IAP(Subscription) Wrapper:  [IAPSubscription](../../AccelByte.Sdk/Api/Platform/Wrapper/IAPSubscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/subscriptions` | GET | QueryThirdPartySubscription | [QueryThirdPartySubscription](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/QueryThirdPartySubscription.cs) | [QueryThirdPartySubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/QueryThirdPartySubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions` | GET | QueryUserThirdPartySubscription | [QueryUserThirdPartySubscription](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/QueryUserThirdPartySubscription.cs) | [QueryUserThirdPartySubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/QueryUserThirdPartySubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/platforms/{platform}/ownership/byGroupId` | GET | GetThirdPartyPlatformSubscriptionOwnershipByGroupId | [GetThirdPartyPlatformSubscriptionOwnershipByGroupId](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/GetThirdPartyPlatformSubscriptionOwnershipByGroupId.cs) | [GetThirdPartyPlatformSubscriptionOwnershipByGroupId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/GetThirdPartyPlatformSubscriptionOwnershipByGroupId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/platforms/{platform}/ownership/byProductId` | GET | GetThirdPartyPlatformSubscriptionOwnershipByProductId | [GetThirdPartyPlatformSubscriptionOwnershipByProductId](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/GetThirdPartyPlatformSubscriptionOwnershipByProductId.cs) | [GetThirdPartyPlatformSubscriptionOwnershipByProductId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/GetThirdPartyPlatformSubscriptionOwnershipByProductId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions` | GET | QueryUserThirdPartySubscriptionTransactions | [QueryUserThirdPartySubscriptionTransactions](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/QueryUserThirdPartySubscriptionTransactions.cs) | [QueryUserThirdPartySubscriptionTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/QueryUserThirdPartySubscriptionTransactions.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions/{id}` | GET | GetThirdPartySubscriptionDetails | [GetThirdPartySubscriptionDetails](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/GetThirdPartySubscriptionDetails.cs) | [GetThirdPartySubscriptionDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/GetThirdPartySubscriptionDetails.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions/{id}/histories` | GET | GetSubscriptionHistory | [GetSubscriptionHistory](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/GetSubscriptionHistory.cs) | [GetSubscriptionHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/GetSubscriptionHistory.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/transactions/{id}/sync` | PUT | SyncSubscriptionTransaction | [SyncSubscriptionTransaction](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/SyncSubscriptionTransaction.cs) | [SyncSubscriptionTransaction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/SyncSubscriptionTransaction.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/{id}` | GET | GetThirdPartyUserSubscriptionDetails | [GetThirdPartyUserSubscriptionDetails](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/GetThirdPartyUserSubscriptionDetails.cs) | [GetThirdPartyUserSubscriptionDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/GetThirdPartyUserSubscriptionDetails.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/iap/subscriptions/{id}/sync` | PUT | SyncSubscription | [SyncSubscription](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/SyncSubscription.cs) | [SyncSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/SyncSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/iap/subscriptions/platforms/{platform}` | GET | PublicQueryUserThirdPartySubscription | [PublicQueryUserThirdPartySubscription](../../AccelByte.Sdk/Api/Platform/Operation/IAPSubscription/PublicQueryUserThirdPartySubscription.cs) | [PublicQueryUserThirdPartySubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/IAPSubscription/PublicQueryUserThirdPartySubscription.cs) |

### Invoice Wrapper:  [Invoice](../../AccelByte.Sdk/Api/Platform/Wrapper/Invoice.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/invoice/details.csv` | GET | DownloadInvoiceDetails | [DownloadInvoiceDetails](../../AccelByte.Sdk/Api/Platform/Operation/Invoice/DownloadInvoiceDetails.cs) | [DownloadInvoiceDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Invoice/DownloadInvoiceDetails.cs) |
| `/platform/admin/namespaces/{namespace}/invoice/summary` | GET | GenerateInvoiceSummary | [GenerateInvoiceSummary](../../AccelByte.Sdk/Api/Platform/Operation/Invoice/GenerateInvoiceSummary.cs) | [GenerateInvoiceSummary](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Invoice/GenerateInvoiceSummary.cs) |

### KeyGroup Wrapper:  [KeyGroup](../../AccelByte.Sdk/Api/Platform/Wrapper/KeyGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/keygroups` | GET | QueryKeyGroups | [QueryKeyGroups](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/QueryKeyGroups.cs) | [QueryKeyGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/QueryKeyGroups.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups` | POST | CreateKeyGroup | [CreateKeyGroup](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/CreateKeyGroup.cs) | [CreateKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/CreateKeyGroup.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/keygroups/byBoothName` | GET | GetKeyGroupByBoothName | [GetKeyGroupByBoothName](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/GetKeyGroupByBoothName.cs) | [GetKeyGroupByBoothName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroupByBoothName.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}` | GET | GetKeyGroup | [GetKeyGroup](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/GetKeyGroup.cs) | [GetKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroup.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}` | PUT | UpdateKeyGroup | [UpdateKeyGroup](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/UpdateKeyGroup.cs) | [UpdateKeyGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/UpdateKeyGroup.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/dynamic` | GET | GetKeyGroupDynamic | [GetKeyGroupDynamic](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/GetKeyGroupDynamic.cs) | [GetKeyGroupDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/GetKeyGroupDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys` | GET | ListKeys | [ListKeys](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/ListKeys.cs) | [ListKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/ListKeys.cs) |
| `/platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys` | POST | UploadKeys | [UploadKeys](../../AccelByte.Sdk/Api/Platform/Operation/KeyGroup/UploadKeys.cs) | [UploadKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/KeyGroup/UploadKeys.cs) |

### Order Wrapper:  [Order](../../AccelByte.Sdk/Api/Platform/Wrapper/Order.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/orders` | GET | QueryOrders | [QueryOrders](../../AccelByte.Sdk/Api/Platform/Operation/Order/QueryOrders.cs) | [QueryOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/QueryOrders.cs) |
| `/platform/admin/namespaces/{namespace}/orders/stats` | GET | GetOrderStatistics | [GetOrderStatistics](../../AccelByte.Sdk/Api/Platform/Operation/Order/GetOrderStatistics.cs) | [GetOrderStatistics](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetOrderStatistics.cs) |
| `/platform/admin/namespaces/{namespace}/orders/{orderNo}` | GET | GetOrder | [GetOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/GetOrder.cs) | [GetOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetOrder.cs) |
| `/platform/admin/namespaces/{namespace}/orders/{orderNo}/refund` | PUT | RefundOrder | [RefundOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/RefundOrder.cs) | [RefundOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/RefundOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders` | GET | QueryUserOrders | [QueryUserOrders](../../AccelByte.Sdk/Api/Platform/Operation/Order/QueryUserOrders.cs) | [QueryUserOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/QueryUserOrders.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders` | POST | AdminCreateUserOrder | [AdminCreateUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/AdminCreateUserOrder.cs) | [AdminCreateUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/AdminCreateUserOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/countOfItem` | GET | CountOfPurchasedItem | [CountOfPurchasedItem](../../AccelByte.Sdk/Api/Platform/Operation/Order/CountOfPurchasedItem.cs) | [CountOfPurchasedItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/CountOfPurchasedItem.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | GET | GetUserOrder | [GetUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/GetUserOrder.cs) | [GetUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | PUT | UpdateUserOrderStatus | [UpdateUserOrderStatus](../../AccelByte.Sdk/Api/Platform/Operation/Order/UpdateUserOrderStatus.cs) | [UpdateUserOrderStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/UpdateUserOrderStatus.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill` | PUT | FulfillUserOrder | [FulfillUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/FulfillUserOrder.cs) | [FulfillUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/FulfillUserOrder.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/grant` | GET | GetUserOrderGrant | [GetUserOrderGrant](../../AccelByte.Sdk/Api/Platform/Operation/Order/GetUserOrderGrant.cs) | [GetUserOrderGrant](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrderGrant.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history` | GET | GetUserOrderHistories | [GetUserOrderHistories](../../AccelByte.Sdk/Api/Platform/Operation/Order/GetUserOrderHistories.cs) | [GetUserOrderHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/GetUserOrderHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/notifications` | POST | ProcessUserOrderNotification | [ProcessUserOrderNotification](../../AccelByte.Sdk/Api/Platform/Operation/Order/ProcessUserOrderNotification.cs) | [ProcessUserOrderNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/ProcessUserOrderNotification.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf` | GET | DownloadUserOrderReceipt | [DownloadUserOrderReceipt](../../AccelByte.Sdk/Api/Platform/Operation/Order/DownloadUserOrderReceipt.cs) | [DownloadUserOrderReceipt](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/DownloadUserOrderReceipt.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders` | GET | PublicQueryUserOrders | [PublicQueryUserOrders](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicQueryUserOrders.cs) | [PublicQueryUserOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicQueryUserOrders.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders` | POST | PublicCreateUserOrder | [PublicCreateUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicCreateUserOrder.cs) | [PublicCreateUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicCreateUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/discount/preview` | POST | PublicPreviewOrderPrice | [PublicPreviewOrderPrice](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicPreviewOrderPrice.cs) | [PublicPreviewOrderPrice](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicPreviewOrderPrice.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}` | GET | PublicGetUserOrder | [PublicGetUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicGetUserOrder.cs) | [PublicGetUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicGetUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel` | PUT | PublicCancelUserOrder | [PublicCancelUserOrder](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicCancelUserOrder.cs) | [PublicCancelUserOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicCancelUserOrder.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history` | GET | PublicGetUserOrderHistories | [PublicGetUserOrderHistories](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicGetUserOrderHistories.cs) | [PublicGetUserOrderHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicGetUserOrderHistories.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf` | GET | PublicDownloadUserOrderReceipt | [PublicDownloadUserOrderReceipt](../../AccelByte.Sdk/Api/Platform/Operation/Order/PublicDownloadUserOrderReceipt.cs) | [PublicDownloadUserOrderReceipt](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Order/PublicDownloadUserOrderReceipt.cs) |

### PaymentCallbackConfig Wrapper:  [PaymentCallbackConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentCallbackConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/payment/config/callback` | GET | GetPaymentCallbackConfig | [GetPaymentCallbackConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentCallbackConfig/GetPaymentCallbackConfig.cs) | [GetPaymentCallbackConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentCallbackConfig/GetPaymentCallbackConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/payment/config/callback` | PUT | UpdatePaymentCallbackConfig | [UpdatePaymentCallbackConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentCallbackConfig/UpdatePaymentCallbackConfig.cs) | [UpdatePaymentCallbackConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentCallbackConfig/UpdatePaymentCallbackConfig.cs) |

### PaymentConfig Wrapper:  [PaymentConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/config/domains` | GET | GetPaymentMerchantConfig | [GetPaymentMerchantConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/GetPaymentMerchantConfig.cs) | [GetPaymentMerchantConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetPaymentMerchantConfig.cs) |
| `/platform/admin/namespaces/{namespace}/payment/config/domains` | PUT | UpdatePaymentDomainWhitelistConfig | [UpdatePaymentDomainWhitelistConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdatePaymentDomainWhitelistConfig.cs) | [UpdatePaymentDomainWhitelistConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePaymentDomainWhitelistConfig.cs) |
| `/platform/admin/payment/config/merchant/adyenconfig/test` | POST | TestAdyenConfig | [TestAdyenConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestAdyenConfig.cs) | [TestAdyenConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAdyenConfig.cs) |
| `/platform/admin/payment/config/merchant/alipayconfig/test` | POST | TestAliPayConfig | [TestAliPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestAliPayConfig.cs) | [TestAliPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAliPayConfig.cs) |
| `/platform/admin/payment/config/merchant/checkoutconfig/test` | POST | TestCheckoutConfig | [TestCheckoutConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestCheckoutConfig.cs) | [TestCheckoutConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestCheckoutConfig.cs) |
| `/platform/admin/payment/config/merchant/matched` | GET | DebugMatchedPaymentMerchantConfig | [DebugMatchedPaymentMerchantConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/DebugMatchedPaymentMerchantConfig.cs) | [DebugMatchedPaymentMerchantConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DebugMatchedPaymentMerchantConfig.cs) |
| `/platform/admin/payment/config/merchant/neonpayconfig/test` | POST | TestNeonPayConfig | [TestNeonPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestNeonPayConfig.cs) | [TestNeonPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestNeonPayConfig.cs) |
| `/platform/admin/payment/config/merchant/paypalconfig/test` | POST | TestPayPalConfig | [TestPayPalConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestPayPalConfig.cs) | [TestPayPalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestPayPalConfig.cs) |
| `/platform/admin/payment/config/merchant/stripeconfig/test` | POST | TestStripeConfig | [TestStripeConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestStripeConfig.cs) | [TestStripeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestStripeConfig.cs) |
| `/platform/admin/payment/config/merchant/wxpayconfig/test` | POST | TestWxPayConfig | [TestWxPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestWxPayConfig.cs) | [TestWxPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestWxPayConfig.cs) |
| `/platform/admin/payment/config/merchant/xsollaconfig/test` | POST | TestXsollaConfig | [TestXsollaConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestXsollaConfig.cs) | [TestXsollaConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestXsollaConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}` | GET | GetPaymentMerchantConfig1 | [GetPaymentMerchantConfig1](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/GetPaymentMerchantConfig1.cs) | [GetPaymentMerchantConfig1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetPaymentMerchantConfig1.cs) |
| `/platform/admin/payment/config/merchant/{id}/adyenconfig` | PUT | UpdateAdyenConfig | [UpdateAdyenConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateAdyenConfig.cs) | [UpdateAdyenConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateAdyenConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/adyenconfig/test` | GET | TestAdyenConfigById | [TestAdyenConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestAdyenConfigById.cs) | [TestAdyenConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAdyenConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/alipayconfig` | PUT | UpdateAliPayConfig | [UpdateAliPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateAliPayConfig.cs) | [UpdateAliPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateAliPayConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/alipayconfig/test` | GET | TestAliPayConfigById | [TestAliPayConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestAliPayConfigById.cs) | [TestAliPayConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestAliPayConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/checkoutconfig` | PUT | UpdateCheckoutConfig | [UpdateCheckoutConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateCheckoutConfig.cs) | [UpdateCheckoutConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateCheckoutConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/checkoutconfig/test` | GET | TestCheckoutConfigById | [TestCheckoutConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestCheckoutConfigById.cs) | [TestCheckoutConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestCheckoutConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/neonpayconfig` | PUT | UpdateNeonPayConfig | [UpdateNeonPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateNeonPayConfig.cs) | [UpdateNeonPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateNeonPayConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/neonpayconfig/test` | GET | TestNeonPayConfigById | [TestNeonPayConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestNeonPayConfigById.cs) | [TestNeonPayConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestNeonPayConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/paypalconfig` | PUT | UpdatePayPalConfig | [UpdatePayPalConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdatePayPalConfig.cs) | [UpdatePayPalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePayPalConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/paypalconfig/test` | GET | TestPayPalConfigById | [TestPayPalConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestPayPalConfigById.cs) | [TestPayPalConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestPayPalConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/stripeconfig` | PUT | UpdateStripeConfig | [UpdateStripeConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateStripeConfig.cs) | [UpdateStripeConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateStripeConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/stripeconfig/test` | GET | TestStripeConfigById | [TestStripeConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestStripeConfigById.cs) | [TestStripeConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestStripeConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig` | PUT | UpdateWxPayConfig | [UpdateWxPayConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateWxPayConfig.cs) | [UpdateWxPayConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateWxPayConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig/cert` | PUT | UpdateWxPayConfigCert | [UpdateWxPayConfigCert](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateWxPayConfigCert.cs) | [UpdateWxPayConfigCert](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateWxPayConfigCert.cs) |
| `/platform/admin/payment/config/merchant/{id}/wxpayconfig/test` | GET | TestWxPayConfigById | [TestWxPayConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestWxPayConfigById.cs) | [TestWxPayConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestWxPayConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollaconfig` | PUT | UpdateXsollaConfig | [UpdateXsollaConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateXsollaConfig.cs) | [UpdateXsollaConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateXsollaConfig.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollaconfig/test` | GET | TestXsollaConfigById | [TestXsollaConfigById](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/TestXsollaConfigById.cs) | [TestXsollaConfigById](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/TestXsollaConfigById.cs) |
| `/platform/admin/payment/config/merchant/{id}/xsollauiconfig` | PUT | UpdateXsollaUIConfig | [UpdateXsollaUIConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdateXsollaUIConfig.cs) | [UpdateXsollaUIConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdateXsollaUIConfig.cs) |
| `/platform/admin/payment/config/provider` | GET | QueryPaymentProviderConfig | [QueryPaymentProviderConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/QueryPaymentProviderConfig.cs) | [QueryPaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/QueryPaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider` | POST | CreatePaymentProviderConfig | [CreatePaymentProviderConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/CreatePaymentProviderConfig.cs) | [CreatePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/CreatePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/aggregate` | GET | GetAggregatePaymentProviders | [GetAggregatePaymentProviders](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/GetAggregatePaymentProviders.cs) | [GetAggregatePaymentProviders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetAggregatePaymentProviders.cs) |
| `/platform/admin/payment/config/provider/matched` | GET | DebugMatchedPaymentProviderConfig | [DebugMatchedPaymentProviderConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/DebugMatchedPaymentProviderConfig.cs) | [DebugMatchedPaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DebugMatchedPaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/special` | GET | GetSpecialPaymentProviders | [GetSpecialPaymentProviders](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/GetSpecialPaymentProviders.cs) | [GetSpecialPaymentProviders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetSpecialPaymentProviders.cs) |
| `/platform/admin/payment/config/provider/{id}` | PUT | UpdatePaymentProviderConfig | [UpdatePaymentProviderConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdatePaymentProviderConfig.cs) | [UpdatePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/provider/{id}` | DELETE | DeletePaymentProviderConfig | [DeletePaymentProviderConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/DeletePaymentProviderConfig.cs) | [DeletePaymentProviderConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/DeletePaymentProviderConfig.cs) |
| `/platform/admin/payment/config/tax` | GET | GetPaymentTaxConfig | [GetPaymentTaxConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/GetPaymentTaxConfig.cs) | [GetPaymentTaxConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/GetPaymentTaxConfig.cs) |
| `/platform/admin/payment/config/tax` | PUT | UpdatePaymentTaxConfig | [UpdatePaymentTaxConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentConfig/UpdatePaymentTaxConfig.cs) | [UpdatePaymentTaxConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentConfig/UpdatePaymentTaxConfig.cs) |

### Payment Wrapper:  [Payment](../../AccelByte.Sdk/Api/Platform/Wrapper/Payment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/notifications` | GET | QueryPaymentNotifications | [QueryPaymentNotifications](../../AccelByte.Sdk/Api/Platform/Operation/Payment/QueryPaymentNotifications.cs) | [QueryPaymentNotifications](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/QueryPaymentNotifications.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders` | GET | QueryPaymentOrders | [QueryPaymentOrders](../../AccelByte.Sdk/Api/Platform/Operation/Payment/QueryPaymentOrders.cs) | [QueryPaymentOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/QueryPaymentOrders.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/byExtTxId` | GET | ListExtOrderNoByExtTxId | [ListExtOrderNoByExtTxId](../../AccelByte.Sdk/Api/Platform/Operation/Payment/ListExtOrderNoByExtTxId.cs) | [ListExtOrderNoByExtTxId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/ListExtOrderNoByExtTxId.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}` | GET | GetPaymentOrder | [GetPaymentOrder](../../AccelByte.Sdk/Api/Platform/Operation/Payment/GetPaymentOrder.cs) | [GetPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/GetPaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}` | PUT | ChargePaymentOrder | [ChargePaymentOrder](../../AccelByte.Sdk/Api/Platform/Operation/Payment/ChargePaymentOrder.cs) | [ChargePaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/ChargePaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/simulate-notification` | PUT | SimulatePaymentOrderNotification | [SimulatePaymentOrderNotification](../../AccelByte.Sdk/Api/Platform/Operation/Payment/SimulatePaymentOrderNotification.cs) | [SimulatePaymentOrderNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/SimulatePaymentOrderNotification.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status` | GET | GetPaymentOrderChargeStatus | [GetPaymentOrderChargeStatus](../../AccelByte.Sdk/Api/Platform/Operation/Payment/GetPaymentOrderChargeStatus.cs) | [GetPaymentOrderChargeStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/GetPaymentOrderChargeStatus.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders` | POST | CreateUserPaymentOrder | [CreateUserPaymentOrder](../../AccelByte.Sdk/Api/Platform/Operation/Payment/CreateUserPaymentOrder.cs) | [CreateUserPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/CreateUserPaymentOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund` | PUT | RefundUserPaymentOrder | [RefundUserPaymentOrder](../../AccelByte.Sdk/Api/Platform/Operation/Payment/RefundUserPaymentOrder.cs) | [RefundUserPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Payment/RefundUserPaymentOrder.cs) |

### Payment(Dedicated) Wrapper:  [PaymentDedicated](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/payment/orders` | POST | CreatePaymentOrderByDedicated | [CreatePaymentOrderByDedicated](../../AccelByte.Sdk/Api/Platform/Operation/PaymentDedicated/CreatePaymentOrderByDedicated.cs) | [CreatePaymentOrderByDedicated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/CreatePaymentOrderByDedicated.cs) |
| `/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/refund` | PUT | RefundPaymentOrderByDedicated | [RefundPaymentOrderByDedicated](../../AccelByte.Sdk/Api/Platform/Operation/PaymentDedicated/RefundPaymentOrderByDedicated.cs) | [RefundPaymentOrderByDedicated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/RefundPaymentOrderByDedicated.cs) |
| `/platform/admin/payment/orders` | GET | SyncPaymentOrders | [SyncPaymentOrders](../../AccelByte.Sdk/Api/Platform/Operation/PaymentDedicated/SyncPaymentOrders.cs) | [SyncPaymentOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentDedicated/SyncPaymentOrders.cs) |

### Platform Wrapper:  [Platform](../../AccelByte.Sdk/Api/Platform/Wrapper/Platform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/platforms/psn/entitlements/{entitlementLabel}/ownership` | POST | GetPsnEntitlementOwnership | [GetPsnEntitlementOwnership](../../AccelByte.Sdk/Api/Platform/Operation/Platform/GetPsnEntitlementOwnership.cs) | [GetPsnEntitlementOwnership](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Platform/GetPsnEntitlementOwnership.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/xbl/entitlements/{productSku}/ownership` | POST | GetXboxEntitlementOwnership | [GetXboxEntitlementOwnership](../../AccelByte.Sdk/Api/Platform/Operation/Platform/GetXboxEntitlementOwnership.cs) | [GetXboxEntitlementOwnership](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Platform/GetXboxEntitlementOwnership.cs) |

### Wallet Wrapper:  [Wallet](../../AccelByte.Sdk/Api/Platform/Wrapper/Wallet.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config` | GET | GetPlatformWalletConfig | [GetPlatformWalletConfig](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/GetPlatformWalletConfig.cs) | [GetPlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetPlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config` | PUT | UpdatePlatformWalletConfig | [UpdatePlatformWalletConfig](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/UpdatePlatformWalletConfig.cs) | [UpdatePlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/UpdatePlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config/reset` | PUT | ResetPlatformWalletConfig | [ResetPlatformWalletConfig](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/ResetPlatformWalletConfig.cs) | [ResetPlatformWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ResetPlatformWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/summary` | GET | QueryUserCurrencyWallets | [QueryUserCurrencyWallets](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/QueryUserCurrencyWallets.cs) | [QueryUserCurrencyWallets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/QueryUserCurrencyWallets.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/debit` | PUT | DebitUserWalletByCurrencyCode | [DebitUserWalletByCurrencyCode](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/DebitUserWalletByCurrencyCode.cs) | [DebitUserWalletByCurrencyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DebitUserWalletByCurrencyCode.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/transactions` | GET | ListUserCurrencyTransactions | [ListUserCurrencyTransactions](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/ListUserCurrencyTransactions.cs) | [ListUserCurrencyTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ListUserCurrencyTransactions.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/balanceCheck` | POST | CheckBalance | [CheckBalance](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/CheckBalance.cs) | [CheckBalance](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/CheckBalance.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/check` | GET | CheckWallet | [CheckWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/CheckWallet.cs) | [CheckWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/CheckWallet.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/credit` | PUT | CreditUserWallet | [CreditUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/CreditUserWallet.cs) | [CreditUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/CreditUserWallet.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/debitByWalletPlatform` | PUT | DebitByWalletPlatform | [DebitByWalletPlatform](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/DebitByWalletPlatform.cs) | [DebitByWalletPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DebitByWalletPlatform.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment` | PUT | PayWithUserWallet | [PayWithUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/PayWithUserWallet.cs) | [PayWithUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PayWithUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}` | GET | GetUserWallet | [GetUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/GetUserWallet.cs) | [GetUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/debit` | PUT | DebitUserWallet | [DebitUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/DebitUserWallet.cs) | [DebitUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DebitUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/disable` | PUT | DisableUserWallet | [DisableUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/DisableUserWallet.cs) | [DisableUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/DisableUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/enable` | PUT | EnableUserWallet | [EnableUserWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/EnableUserWallet.cs) | [EnableUserWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/EnableUserWallet.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/transactions` | GET | ListUserWalletTransactions | [ListUserWalletTransactions](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/ListUserWalletTransactions.cs) | [ListUserWalletTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/ListUserWalletTransactions.cs) |
| `/platform/admin/namespaces/{namespace}/wallet/config` | GET | GetWalletConfig | [GetWalletConfig](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/GetWalletConfig.cs) | [GetWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetWalletConfig.cs) |
| `/platform/admin/namespaces/{namespace}/wallet/config` | PUT | UpdateWalletConfig | [UpdateWalletConfig](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/UpdateWalletConfig.cs) | [UpdateWalletConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/UpdateWalletConfig.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/wallets` | GET | QueryWallets | [QueryWallets](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/QueryWallets.cs) | [QueryWallets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/QueryWallets.cs) |
| `/platform/admin/namespaces/{namespace}/wallets/credit` | POST | BulkCredit | [BulkCredit](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/BulkCredit.cs) | [BulkCredit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/BulkCredit.cs) |
| `/platform/admin/namespaces/{namespace}/wallets/debit` | POST | BulkDebit | [BulkDebit](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/BulkDebit.cs) | [BulkDebit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/BulkDebit.cs) |
| [DEPRECATED] `/platform/admin/namespaces/{namespace}/wallets/{walletId}` | GET | GetWallet | [GetWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/GetWallet.cs) | [GetWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/GetWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode}` | GET | PublicGetMyWallet | [PublicGetMyWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/PublicGetMyWallet.cs) | [PublicGetMyWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicGetMyWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}` | GET | PublicGetWallet | [PublicGetWallet](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/PublicGetWallet.cs) | [PublicGetWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicGetWallet.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions` | GET | PublicListUserWalletTransactions | [PublicListUserWalletTransactions](../../AccelByte.Sdk/Api/Platform/Operation/Wallet/PublicListUserWalletTransactions.cs) | [PublicListUserWalletTransactions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Wallet/PublicListUserWalletTransactions.cs) |

### Revocation Wrapper:  [Revocation](../../AccelByte.Sdk/Api/Platform/Wrapper/Revocation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/revocation/config` | GET | GetRevocationConfig | [GetRevocationConfig](../../AccelByte.Sdk/Api/Platform/Operation/Revocation/GetRevocationConfig.cs) | [GetRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/GetRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/config` | PUT | UpdateRevocationConfig | [UpdateRevocationConfig](../../AccelByte.Sdk/Api/Platform/Operation/Revocation/UpdateRevocationConfig.cs) | [UpdateRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/UpdateRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/config` | DELETE | DeleteRevocationConfig | [DeleteRevocationConfig](../../AccelByte.Sdk/Api/Platform/Operation/Revocation/DeleteRevocationConfig.cs) | [DeleteRevocationConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/DeleteRevocationConfig.cs) |
| `/platform/admin/namespaces/{namespace}/revocation/history` | GET | QueryRevocationHistories | [QueryRevocationHistories](../../AccelByte.Sdk/Api/Platform/Operation/Revocation/QueryRevocationHistories.cs) | [QueryRevocationHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/QueryRevocationHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/revocation` | PUT | DoRevocation | [DoRevocation](../../AccelByte.Sdk/Api/Platform/Operation/Revocation/DoRevocation.cs) | [DoRevocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Revocation/DoRevocation.cs) |

### Reward Wrapper:  [Reward](../../AccelByte.Sdk/Api/Platform/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/rewards` | POST | CreateReward | [CreateReward](../../AccelByte.Sdk/Api/Platform/Operation/Reward/CreateReward.cs) | [CreateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/CreateReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/byCriteria` | GET | QueryRewards | [QueryRewards](../../AccelByte.Sdk/Api/Platform/Operation/Reward/QueryRewards.cs) | [QueryRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/QueryRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/export` | GET | ExportRewards | [ExportRewards](../../AccelByte.Sdk/Api/Platform/Operation/Reward/ExportRewards.cs) | [ExportRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/ExportRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/import` | POST | ImportRewards | [ImportRewards](../../AccelByte.Sdk/Api/Platform/Operation/Reward/ImportRewards.cs) | [ImportRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/ImportRewards.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | GET | GetReward | [GetReward](../../AccelByte.Sdk/Api/Platform/Operation/Reward/GetReward.cs) | [GetReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | PUT | UpdateReward | [UpdateReward](../../AccelByte.Sdk/Api/Platform/Operation/Reward/UpdateReward.cs) | [UpdateReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/UpdateReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}` | DELETE | DeleteReward | [DeleteReward](../../AccelByte.Sdk/Api/Platform/Operation/Reward/DeleteReward.cs) | [DeleteReward](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/DeleteReward.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}/match` | PUT | CheckEventCondition | [CheckEventCondition](../../AccelByte.Sdk/Api/Platform/Operation/Reward/CheckEventCondition.cs) | [CheckEventCondition](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/CheckEventCondition.cs) |
| `/platform/admin/namespaces/{namespace}/rewards/{rewardId}/record` | DELETE | DeleteRewardConditionRecord | [DeleteRewardConditionRecord](../../AccelByte.Sdk/Api/Platform/Operation/Reward/DeleteRewardConditionRecord.cs) | [DeleteRewardConditionRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/DeleteRewardConditionRecord.cs) |
| `/platform/public/namespaces/{namespace}/rewards/byCode` | GET | GetRewardByCode | [GetRewardByCode](../../AccelByte.Sdk/Api/Platform/Operation/Reward/GetRewardByCode.cs) | [GetRewardByCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetRewardByCode.cs) |
| `/platform/public/namespaces/{namespace}/rewards/byCriteria` | GET | QueryRewards1 | [QueryRewards1](../../AccelByte.Sdk/Api/Platform/Operation/Reward/QueryRewards1.cs) | [QueryRewards1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/QueryRewards1.cs) |
| `/platform/public/namespaces/{namespace}/rewards/{rewardId}` | GET | GetReward1 | [GetReward1](../../AccelByte.Sdk/Api/Platform/Operation/Reward/GetReward1.cs) | [GetReward1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Reward/GetReward1.cs) |

### Section Wrapper:  [Section](../../AccelByte.Sdk/Api/Platform/Wrapper/Section.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/sections` | GET | QuerySections | [QuerySections](../../AccelByte.Sdk/Api/Platform/Operation/Section/QuerySections.cs) | [QuerySections](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/QuerySections.cs) |
| `/platform/admin/namespaces/{namespace}/sections` | POST | CreateSection | [CreateSection](../../AccelByte.Sdk/Api/Platform/Operation/Section/CreateSection.cs) | [CreateSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/CreateSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/purge/expired` | DELETE | PurgeExpiredSection | [PurgeExpiredSection](../../AccelByte.Sdk/Api/Platform/Operation/Section/PurgeExpiredSection.cs) | [PurgeExpiredSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/PurgeExpiredSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | GET | GetSection | [GetSection](../../AccelByte.Sdk/Api/Platform/Operation/Section/GetSection.cs) | [GetSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/GetSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | PUT | UpdateSection | [UpdateSection](../../AccelByte.Sdk/Api/Platform/Operation/Section/UpdateSection.cs) | [UpdateSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/UpdateSection.cs) |
| `/platform/admin/namespaces/{namespace}/sections/{sectionId}` | DELETE | DeleteSection | [DeleteSection](../../AccelByte.Sdk/Api/Platform/Operation/Section/DeleteSection.cs) | [DeleteSection](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/DeleteSection.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/sections` | GET | PublicListActiveSections | [PublicListActiveSections](../../AccelByte.Sdk/Api/Platform/Operation/Section/PublicListActiveSections.cs) | [PublicListActiveSections](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Section/PublicListActiveSections.cs) |

### CatalogChanges Wrapper:  [CatalogChanges](../../AccelByte.Sdk/Api/Platform/Wrapper/CatalogChanges.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria` | GET | QueryChanges | [QueryChanges](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/QueryChanges.cs) | [QueryChanges](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/QueryChanges.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/publishAll` | PUT | PublishAll | [PublishAll](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/PublishAll.cs) | [PublishAll](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/PublishAll.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/publishSelected` | PUT | PublishSelected | [PublishSelected](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/PublishSelected.cs) | [PublishSelected](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/PublishSelected.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/selectAll` | PUT | SelectAllRecords | [SelectAllRecords](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/SelectAllRecords.cs) | [SelectAllRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/SelectAllRecords.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/selectAllByCriteria` | PUT | SelectAllRecordsByCriteria | [SelectAllRecordsByCriteria](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/SelectAllRecordsByCriteria.cs) | [SelectAllRecordsByCriteria](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/SelectAllRecordsByCriteria.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/statistics` | GET | GetStatistic | [GetStatistic](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/GetStatistic.cs) | [GetStatistic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/GetStatistic.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/unselectAll` | PUT | UnselectAllRecords | [UnselectAllRecords](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/UnselectAllRecords.cs) | [UnselectAllRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/UnselectAllRecords.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/{changeId}/select` | PUT | SelectRecord | [SelectRecord](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/SelectRecord.cs) | [SelectRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/SelectRecord.cs) |
| `/platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/{changeId}/unselect` | PUT | UnselectRecord | [UnselectRecord](../../AccelByte.Sdk/Api/Platform/Operation/CatalogChanges/UnselectRecord.cs) | [UnselectRecord](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/CatalogChanges/UnselectRecord.cs) |

### Subscription Wrapper:  [Subscription](../../AccelByte.Sdk/Api/Platform/Wrapper/Subscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/subscriptions` | GET | QuerySubscriptions | [QuerySubscriptions](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/QuerySubscriptions.cs) | [QuerySubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/QuerySubscriptions.cs) |
| `/platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring` | PUT | RecurringChargeSubscription | [RecurringChargeSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/RecurringChargeSubscription.cs) | [RecurringChargeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/RecurringChargeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions` | GET | QueryUserSubscriptions | [QueryUserSubscriptions](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/QueryUserSubscriptions.cs) | [QueryUserSubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/QueryUserSubscriptions.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/activities` | GET | GetUserSubscriptionActivities | [GetUserSubscriptionActivities](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/GetUserSubscriptionActivities.cs) | [GetUserSubscriptionActivities](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscriptionActivities.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe` | POST | PlatformSubscribeSubscription | [PlatformSubscribeSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PlatformSubscribeSubscription.cs) | [PlatformSubscribeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PlatformSubscribeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId` | GET | CheckUserSubscriptionSubscribableByItemId | [CheckUserSubscriptionSubscribableByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/CheckUserSubscriptionSubscribableByItemId.cs) | [CheckUserSubscriptionSubscribableByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/CheckUserSubscriptionSubscribableByItemId.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | GET | GetUserSubscription | [GetUserSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/GetUserSubscription.cs) | [GetUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | DELETE | DeleteUserSubscription | [DeleteUserSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/DeleteUserSubscription.cs) | [DeleteUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/DeleteUserSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel` | PUT | CancelSubscription | [CancelSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/CancelSubscription.cs) | [CancelSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/CancelSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant` | PUT | GrantDaysToSubscription | [GrantDaysToSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/GrantDaysToSubscription.cs) | [GrantDaysToSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GrantDaysToSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history` | GET | GetUserSubscriptionBillingHistories | [GetUserSubscriptionBillingHistories](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/GetUserSubscriptionBillingHistories.cs) | [GetUserSubscriptionBillingHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/GetUserSubscriptionBillingHistories.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/notifications` | POST | ProcessUserSubscriptionNotification | [ProcessUserSubscriptionNotification](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/ProcessUserSubscriptionNotification.cs) | [ProcessUserSubscriptionNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/ProcessUserSubscriptionNotification.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions` | GET | PublicQueryUserSubscriptions | [PublicQueryUserSubscriptions](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicQueryUserSubscriptions.cs) | [PublicQueryUserSubscriptions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicQueryUserSubscriptions.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions` | POST | PublicSubscribeSubscription | [PublicSubscribeSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicSubscribeSubscription.cs) | [PublicSubscribeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicSubscribeSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId` | GET | PublicCheckUserSubscriptionSubscribableByItemId | [PublicCheckUserSubscriptionSubscribableByItemId](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicCheckUserSubscriptionSubscribableByItemId.cs) | [PublicCheckUserSubscriptionSubscribableByItemId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicCheckUserSubscriptionSubscribableByItemId.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}` | GET | PublicGetUserSubscription | [PublicGetUserSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicGetUserSubscription.cs) | [PublicGetUserSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicGetUserSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount` | PUT | PublicChangeSubscriptionBillingAccount | [PublicChangeSubscriptionBillingAccount](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicChangeSubscriptionBillingAccount.cs) | [PublicChangeSubscriptionBillingAccount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicChangeSubscriptionBillingAccount.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel` | PUT | PublicCancelSubscription | [PublicCancelSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicCancelSubscription.cs) | [PublicCancelSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicCancelSubscription.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history` | GET | PublicGetUserSubscriptionBillingHistories | [PublicGetUserSubscriptionBillingHistories](../../AccelByte.Sdk/Api/Platform/Operation/Subscription/PublicGetUserSubscriptionBillingHistories.cs) | [PublicGetUserSubscriptionBillingHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Subscription/PublicGetUserSubscriptionBillingHistories.cs) |

### Ticket Wrapper:  [Ticket](../../AccelByte.Sdk/Api/Platform/Wrapper/Ticket.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}` | GET | GetTicketDynamic | [GetTicketDynamic](../../AccelByte.Sdk/Api/Platform/Operation/Ticket/GetTicketDynamic.cs) | [GetTicketDynamic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/GetTicketDynamic.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/decrement` | PUT | DecreaseTicketSale | [DecreaseTicketSale](../../AccelByte.Sdk/Api/Platform/Operation/Ticket/DecreaseTicketSale.cs) | [DecreaseTicketSale](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/DecreaseTicketSale.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/id` | GET | GetTicketBoothID | [GetTicketBoothID](../../AccelByte.Sdk/Api/Platform/Operation/Ticket/GetTicketBoothID.cs) | [GetTicketBoothID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/GetTicketBoothID.cs) |
| `/platform/admin/namespaces/{namespace}/tickets/{boothName}/increment` | PUT | IncreaseTicketSale | [IncreaseTicketSale](../../AccelByte.Sdk/Api/Platform/Operation/Ticket/IncreaseTicketSale.cs) | [IncreaseTicketSale](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/IncreaseTicketSale.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/tickets/{boothName}` | POST | AcquireUserTicket | [AcquireUserTicket](../../AccelByte.Sdk/Api/Platform/Operation/Ticket/AcquireUserTicket.cs) | [AcquireUserTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Ticket/AcquireUserTicket.cs) |

### TradeAction Wrapper:  [TradeAction](../../AccelByte.Sdk/Api/Platform/Wrapper/TradeAction.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/trade/commit` | POST | Commit | [Commit](../../AccelByte.Sdk/Api/Platform/Operation/TradeAction/Commit.cs) | [Commit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/TradeAction/Commit.cs) |
| `/platform/admin/namespaces/{namespace}/trade/history/byCriteria` | GET | GetTradeHistoryByCriteria | [GetTradeHistoryByCriteria](../../AccelByte.Sdk/Api/Platform/Operation/TradeAction/GetTradeHistoryByCriteria.cs) | [GetTradeHistoryByCriteria](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/TradeAction/GetTradeHistoryByCriteria.cs) |
| `/platform/admin/namespaces/{namespace}/trade/{transactionId}` | GET | GetTradeHistoryByTransactionId | [GetTradeHistoryByTransactionId](../../AccelByte.Sdk/Api/Platform/Operation/TradeAction/GetTradeHistoryByTransactionId.cs) | [GetTradeHistoryByTransactionId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/TradeAction/GetTradeHistoryByTransactionId.cs) |

### Achievement(Platform) Wrapper:  [AchievementPlatform](../../AccelByte.Sdk/Api/Platform/Wrapper/AchievementPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/steam` | PUT | UnlockSteamUserAchievement | [UnlockSteamUserAchievement](../../AccelByte.Sdk/Api/Platform/Operation/AchievementPlatform/UnlockSteamUserAchievement.cs) | [UnlockSteamUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/UnlockSteamUserAchievement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl` | GET | GetXblUserAchievements | [GetXblUserAchievements](../../AccelByte.Sdk/Api/Platform/Operation/AchievementPlatform/GetXblUserAchievements.cs) | [GetXblUserAchievements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/GetXblUserAchievements.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/achievement/xbl` | PUT | UpdateXblUserAchievement | [UpdateXblUserAchievement](../../AccelByte.Sdk/Api/Platform/Operation/AchievementPlatform/UpdateXblUserAchievement.cs) | [UpdateXblUserAchievement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/AchievementPlatform/UpdateXblUserAchievement.cs) |

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Platform/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/campaign` | DELETE | AnonymizeCampaign | [AnonymizeCampaign](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeCampaign.cs) | [AnonymizeCampaign](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeCampaign.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/entitlements` | DELETE | AnonymizeEntitlement | [AnonymizeEntitlement](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeEntitlement.cs) | [AnonymizeEntitlement](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeEntitlement.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/fulfillment` | DELETE | AnonymizeFulfillment | [AnonymizeFulfillment](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeFulfillment.cs) | [AnonymizeFulfillment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeFulfillment.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/integrations` | DELETE | AnonymizeIntegration | [AnonymizeIntegration](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeIntegration.cs) | [AnonymizeIntegration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeIntegration.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/orders` | DELETE | AnonymizeOrder | [AnonymizeOrder](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeOrder.cs) | [AnonymizeOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeOrder.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/payment` | DELETE | AnonymizePayment | [AnonymizePayment](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizePayment.cs) | [AnonymizePayment](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizePayment.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/revocation` | DELETE | AnonymizeRevocation | [AnonymizeRevocation](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeRevocation.cs) | [AnonymizeRevocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeRevocation.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/subscriptions` | DELETE | AnonymizeSubscription | [AnonymizeSubscription](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeSubscription.cs) | [AnonymizeSubscription](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeSubscription.cs) |
| `/platform/admin/namespaces/{namespace}/users/{userId}/anonymization/wallets` | DELETE | AnonymizeWallet | [AnonymizeWallet](../../AccelByte.Sdk/Api/Platform/Operation/Anonymization/AnonymizeWallet.cs) | [AnonymizeWallet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Anonymization/AnonymizeWallet.cs) |

### Platform Account Closure Wrapper:  [PlatformAccountClosure](../../AccelByte.Sdk/Api/Platform/Wrapper/PlatformAccountClosure.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/platform/closure/history` | GET | GetUserPlatformAccountClosureHistories | [GetUserPlatformAccountClosureHistories](../../AccelByte.Sdk/Api/Platform/Operation/PlatformAccountClosure/GetUserPlatformAccountClosureHistories.cs) | [GetUserPlatformAccountClosureHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PlatformAccountClosure/GetUserPlatformAccountClosureHistories.cs) |

### Session(Platform) Wrapper:  [SessionPlatform](../../AccelByte.Sdk/Api/Platform/Wrapper/SessionPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/session/xbl` | PUT | RegisterXblSessions | [RegisterXblSessions](../../AccelByte.Sdk/Api/Platform/Operation/SessionPlatform/RegisterXblSessions.cs) | [RegisterXblSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/SessionPlatform/RegisterXblSessions.cs) |

### View Wrapper:  [View](../../AccelByte.Sdk/Api/Platform/Wrapper/View.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/views` | GET | ListViews | [ListViews](../../AccelByte.Sdk/Api/Platform/Operation/View/ListViews.cs) | [ListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/ListViews.cs) |
| `/platform/admin/namespaces/{namespace}/views` | POST | CreateView | [CreateView](../../AccelByte.Sdk/Api/Platform/Operation/View/CreateView.cs) | [CreateView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/CreateView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | GET | GetView | [GetView](../../AccelByte.Sdk/Api/Platform/Operation/View/GetView.cs) | [GetView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/GetView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | PUT | UpdateView | [UpdateView](../../AccelByte.Sdk/Api/Platform/Operation/View/UpdateView.cs) | [UpdateView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/UpdateView.cs) |
| `/platform/admin/namespaces/{namespace}/views/{viewId}` | DELETE | DeleteView | [DeleteView](../../AccelByte.Sdk/Api/Platform/Operation/View/DeleteView.cs) | [DeleteView](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/DeleteView.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/views` | GET | PublicListViews | [PublicListViews](../../AccelByte.Sdk/Api/Platform/Operation/View/PublicListViews.cs) | [PublicListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/PublicListViews.cs) |

### Order(Dedicated) Wrapper:  [OrderDedicated](../../AccelByte.Sdk/Api/Platform/Wrapper/OrderDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/orders` | GET | SyncOrders | [SyncOrders](../../AccelByte.Sdk/Api/Platform/Operation/OrderDedicated/SyncOrders.cs) | [SyncOrders](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/OrderDedicated/SyncOrders.cs) |

### PaymentStation Wrapper:  [PaymentStation](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentStation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/platform/public/namespaces/{namespace}/payment/customization` | GET | GetPaymentCustomization | [GetPaymentCustomization](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/GetPaymentCustomization.cs) | [GetPaymentCustomization](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentCustomization.cs) |
| `/platform/public/namespaces/{namespace}/payment/link` | POST | PublicGetPaymentUrl | [PublicGetPaymentUrl](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetPaymentUrl.cs) | [PublicGetPaymentUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetPaymentUrl.cs) |
| `/platform/public/namespaces/{namespace}/payment/methods` | GET | PublicGetPaymentMethods | [PublicGetPaymentMethods](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetPaymentMethods.cs) | [PublicGetPaymentMethods](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetPaymentMethods.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/info` | GET | PublicGetUnpaidPaymentOrder | [PublicGetUnpaidPaymentOrder](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetUnpaidPaymentOrder.cs) | [PublicGetUnpaidPaymentOrder](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetUnpaidPaymentOrder.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/pay` | POST | Pay | [Pay](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/Pay.cs) | [Pay](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/Pay.cs) |
| `/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status` | GET | PublicCheckPaymentOrderPaidStatus | [PublicCheckPaymentOrderPaidStatus](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicCheckPaymentOrderPaidStatus.cs) | [PublicCheckPaymentOrderPaidStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicCheckPaymentOrderPaidStatus.cs) |
| `/platform/public/namespaces/{namespace}/payment/publicconfig` | GET | GetPaymentPublicConfig | [GetPaymentPublicConfig](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/GetPaymentPublicConfig.cs) | [GetPaymentPublicConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentPublicConfig.cs) |
| `/platform/public/namespaces/{namespace}/payment/qrcode` | GET | PublicGetQRCode | [PublicGetQRCode](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetQRCode.cs) | [PublicGetQRCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicGetQRCode.cs) |
| `/platform/public/namespaces/{namespace}/payment/returnurl` | GET | PublicNormalizePaymentReturnUrl | [PublicNormalizePaymentReturnUrl](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicNormalizePaymentReturnUrl.cs) | [PublicNormalizePaymentReturnUrl](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/PublicNormalizePaymentReturnUrl.cs) |
| `/platform/public/namespaces/{namespace}/payment/tax` | GET | GetPaymentTaxValue | [GetPaymentTaxValue](../../AccelByte.Sdk/Api/Platform/Operation/PaymentStation/GetPaymentTaxValue.cs) | [GetPaymentTaxValue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentStation/GetPaymentTaxValue.cs) |

### PaymentAccount Wrapper:  [PaymentAccount](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentAccount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts` | GET | PublicGetPaymentAccounts | [PublicGetPaymentAccounts](../../AccelByte.Sdk/Api/Platform/Operation/PaymentAccount/PublicGetPaymentAccounts.cs) | [PublicGetPaymentAccounts](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentAccount/PublicGetPaymentAccounts.cs) |
| `/platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id}` | DELETE | PublicDeletePaymentAccount | [PublicDeletePaymentAccount](../../AccelByte.Sdk/Api/Platform/Operation/PaymentAccount/PublicDeletePaymentAccount.cs) | [PublicDeletePaymentAccount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/PaymentAccount/PublicDeletePaymentAccount.cs) |


&nbsp;  

## Operations with Generic Response

### FulfillmentScript Wrapper:  [FulfillmentScript](../../AccelByte.Sdk/Api/Platform/Wrapper/FulfillmentScript.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Item Wrapper:  [Item](../../AccelByte.Sdk/Api/Platform/Wrapper/Item.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Campaign Wrapper:  [Campaign](../../AccelByte.Sdk/Api/Platform/Wrapper/Campaign.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Store Wrapper:  [Store](../../AccelByte.Sdk/Api/Platform/Wrapper/Store.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### ServicePluginConfig Wrapper:  [ServicePluginConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/ServicePluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Category Wrapper:  [Category](../../AccelByte.Sdk/Api/Platform/Wrapper/Category.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Currency Wrapper:  [Currency](../../AccelByte.Sdk/Api/Platform/Wrapper/Currency.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### DLC Wrapper:  [DLC](../../AccelByte.Sdk/Api/Platform/Wrapper/DLC.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/users/{userId}/dlc/records` | GET | GetUserDLC | [GetUserDLC](../../AccelByte.Sdk/Api/Platform/Operation/DLC/GetUserDLC.cs) | [GetUserDLC](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/DLC/GetUserDLC.cs) |

### Entitlement Wrapper:  [Entitlement](../../AccelByte.Sdk/Api/Platform/Wrapper/Entitlement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fulfillment Wrapper:  [Fulfillment](../../AccelByte.Sdk/Api/Platform/Wrapper/Fulfillment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Clawback Wrapper:  [Clawback](../../AccelByte.Sdk/Api/Platform/Wrapper/Clawback.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/iap/clawback/playstation/mock` | POST | MockPlayStationStreamEvent | [MockPlayStationStreamEvent](../../AccelByte.Sdk/Api/Platform/Operation/Clawback/MockPlayStationStreamEvent.cs) | [MockPlayStationStreamEvent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/MockPlayStationStreamEvent.cs) |
| `/platform/admin/namespaces/{namespace}/iap/clawback/xbl/mock` | POST | MockXblClawbackEvent | [MockXblClawbackEvent](../../AccelByte.Sdk/Api/Platform/Operation/Clawback/MockXblClawbackEvent.cs) | [MockXblClawbackEvent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/Clawback/MockXblClawbackEvent.cs) |

### IAP Wrapper:  [IAP](../../AccelByte.Sdk/Api/Platform/Wrapper/IAP.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### IAP(Notification) Wrapper:  [IAPNotification](../../AccelByte.Sdk/Api/Platform/Wrapper/IAPNotification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### IAP(Subscription) Wrapper:  [IAPSubscription](../../AccelByte.Sdk/Api/Platform/Wrapper/IAPSubscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Invoice Wrapper:  [Invoice](../../AccelByte.Sdk/Api/Platform/Wrapper/Invoice.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### KeyGroup Wrapper:  [KeyGroup](../../AccelByte.Sdk/Api/Platform/Wrapper/KeyGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Order Wrapper:  [Order](../../AccelByte.Sdk/Api/Platform/Wrapper/Order.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentCallbackConfig Wrapper:  [PaymentCallbackConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentCallbackConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentConfig Wrapper:  [PaymentConfig](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Payment Wrapper:  [Payment](../../AccelByte.Sdk/Api/Platform/Wrapper/Payment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Payment(Dedicated) Wrapper:  [PaymentDedicated](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Platform Wrapper:  [Platform](../../AccelByte.Sdk/Api/Platform/Wrapper/Platform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Wallet Wrapper:  [Wallet](../../AccelByte.Sdk/Api/Platform/Wrapper/Wallet.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Revocation Wrapper:  [Revocation](../../AccelByte.Sdk/Api/Platform/Wrapper/Revocation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Reward Wrapper:  [Reward](../../AccelByte.Sdk/Api/Platform/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Section Wrapper:  [Section](../../AccelByte.Sdk/Api/Platform/Wrapper/Section.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### CatalogChanges Wrapper:  [CatalogChanges](../../AccelByte.Sdk/Api/Platform/Wrapper/CatalogChanges.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Subscription Wrapper:  [Subscription](../../AccelByte.Sdk/Api/Platform/Wrapper/Subscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Ticket Wrapper:  [Ticket](../../AccelByte.Sdk/Api/Platform/Wrapper/Ticket.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### TradeAction Wrapper:  [TradeAction](../../AccelByte.Sdk/Api/Platform/Wrapper/TradeAction.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/admin/namespaces/{namespace}/trade/commit` | POST | Commit | [Commit](../../AccelByte.Sdk/Api/Platform/Operation/TradeAction/Commit.cs) | [Commit](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/TradeAction/Commit.cs) |
| `/platform/admin/namespaces/{namespace}/trade/{transactionId}` | GET | GetTradeHistoryByTransactionId | [GetTradeHistoryByTransactionId](../../AccelByte.Sdk/Api/Platform/Operation/TradeAction/GetTradeHistoryByTransactionId.cs) | [GetTradeHistoryByTransactionId](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/TradeAction/GetTradeHistoryByTransactionId.cs) |

### Achievement(Platform) Wrapper:  [AchievementPlatform](../../AccelByte.Sdk/Api/Platform/Wrapper/AchievementPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Platform/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Platform Account Closure Wrapper:  [PlatformAccountClosure](../../AccelByte.Sdk/Api/Platform/Wrapper/PlatformAccountClosure.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Session(Platform) Wrapper:  [SessionPlatform](../../AccelByte.Sdk/Api/Platform/Wrapper/SessionPlatform.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### View Wrapper:  [View](../../AccelByte.Sdk/Api/Platform/Wrapper/View.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/platform/public/namespaces/{namespace}/users/{userId}/views` | GET | PublicListViews | [PublicListViews](../../AccelByte.Sdk/Api/Platform/Operation/View/PublicListViews.cs) | [PublicListViews](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Platform/View/PublicListViews.cs) |

### Order(Dedicated) Wrapper:  [OrderDedicated](../../AccelByte.Sdk/Api/Platform/Wrapper/OrderDedicated.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentStation Wrapper:  [PaymentStation](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentStation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PaymentAccount Wrapper:  [PaymentAccount](../../AccelByte.Sdk/Api/Platform/Wrapper/PaymentAccount.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `AchievementInfo` | [AchievementInfo](../../AccelByte.Sdk/Api/Platform/Model/AchievementInfo.cs) |
| `Action` | [Action](../../AccelByte.Sdk/Api/Platform/Model/Action.cs) |
| `ActionRequest` | [ActionRequest](../../AccelByte.Sdk/Api/Platform/Model/ActionRequest.cs) |
| `AdditionalData` | [AdditionalData](../../AccelByte.Sdk/Api/Platform/Model/AdditionalData.cs) |
| `AdditionalDataEntitlement` | [AdditionalDataEntitlement](../../AccelByte.Sdk/Api/Platform/Model/AdditionalDataEntitlement.cs) |
| `AdminEntitlementDecrement` | [AdminEntitlementDecrement](../../AccelByte.Sdk/Api/Platform/Model/AdminEntitlementDecrement.cs) |
| `AdminEntitlementSoldRequest` | [AdminEntitlementSoldRequest](../../AccelByte.Sdk/Api/Platform/Model/AdminEntitlementSoldRequest.cs) |
| `AdminOrderCreate` | [AdminOrderCreate](../../AccelByte.Sdk/Api/Platform/Model/AdminOrderCreate.cs) |
| `AdyenConfig` | [AdyenConfig](../../AccelByte.Sdk/Api/Platform/Model/AdyenConfig.cs) |
| `AliPayConfig` | [AliPayConfig](../../AccelByte.Sdk/Api/Platform/Model/AliPayConfig.cs) |
| `AppConfig` | [AppConfig](../../AccelByte.Sdk/Api/Platform/Model/AppConfig.cs) |
| `AppEntitlementInfo` | [AppEntitlementInfo](../../AccelByte.Sdk/Api/Platform/Model/AppEntitlementInfo.cs) |
| `AppEntitlementPagingSlicedResult` | [AppEntitlementPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/AppEntitlementPagingSlicedResult.cs) |
| `AppInfo` | [AppInfo](../../AccelByte.Sdk/Api/Platform/Model/AppInfo.cs) |
| `AppLocalization` | [AppLocalization](../../AccelByte.Sdk/Api/Platform/Model/AppLocalization.cs) |
| `AppUpdate` | [AppUpdate](../../AccelByte.Sdk/Api/Platform/Model/AppUpdate.cs) |
| `AppleIAPConfigInfo` | [AppleIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/AppleIAPConfigInfo.cs) |
| `AppleIAPConfigRequest` | [AppleIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/AppleIAPConfigRequest.cs) |
| `AppleIAPConfigVersionInfo` | [AppleIAPConfigVersionInfo](../../AccelByte.Sdk/Api/Platform/Model/AppleIAPConfigVersionInfo.cs) |
| `AppleIAPReceipt` | [AppleIAPReceipt](../../AccelByte.Sdk/Api/Platform/Model/AppleIAPReceipt.cs) |
| `AppleIAPRequest` | [AppleIAPRequest](../../AccelByte.Sdk/Api/Platform/Model/AppleIAPRequest.cs) |
| `AvailableComparison` | [AvailableComparison](../../AccelByte.Sdk/Api/Platform/Model/AvailableComparison.cs) |
| `AvailablePredicate` | [AvailablePredicate](../../AccelByte.Sdk/Api/Platform/Model/AvailablePredicate.cs) |
| `AvailablePrice` | [AvailablePrice](../../AccelByte.Sdk/Api/Platform/Model/AvailablePrice.cs) |
| `BaseCustomConfig` | [BaseCustomConfig](../../AccelByte.Sdk/Api/Platform/Model/BaseCustomConfig.cs) |
| `BaseTLSConfig` | [BaseTLSConfig](../../AccelByte.Sdk/Api/Platform/Model/BaseTLSConfig.cs) |
| `BasicCategoryInfo` | [BasicCategoryInfo](../../AccelByte.Sdk/Api/Platform/Model/BasicCategoryInfo.cs) |
| `BasicItem` | [BasicItem](../../AccelByte.Sdk/Api/Platform/Model/BasicItem.cs) |
| `BillingAccount` | [BillingAccount](../../AccelByte.Sdk/Api/Platform/Model/BillingAccount.cs) |
| `BillingHistoryInfo` | [BillingHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/BillingHistoryInfo.cs) |
| `BillingHistoryPagingSlicedResult` | [BillingHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/BillingHistoryPagingSlicedResult.cs) |
| `BinarySchema` | [BinarySchema](../../AccelByte.Sdk/Api/Platform/Model/BinarySchema.cs) |
| `BoxItem` | [BoxItem](../../AccelByte.Sdk/Api/Platform/Model/BoxItem.cs) |
| `BulkCreditRequest` | [BulkCreditRequest](../../AccelByte.Sdk/Api/Platform/Model/BulkCreditRequest.cs) |
| `BulkCreditResult` | [BulkCreditResult](../../AccelByte.Sdk/Api/Platform/Model/BulkCreditResult.cs) |
| `BulkDebitRequest` | [BulkDebitRequest](../../AccelByte.Sdk/Api/Platform/Model/BulkDebitRequest.cs) |
| `BulkDebitResult` | [BulkDebitResult](../../AccelByte.Sdk/Api/Platform/Model/BulkDebitResult.cs) |
| `BulkEntitlementGrantRequest` | [BulkEntitlementGrantRequest](../../AccelByte.Sdk/Api/Platform/Model/BulkEntitlementGrantRequest.cs) |
| `BulkEntitlementGrantResult` | [BulkEntitlementGrantResult](../../AccelByte.Sdk/Api/Platform/Model/BulkEntitlementGrantResult.cs) |
| `BulkEntitlementRevokeResult` | [BulkEntitlementRevokeResult](../../AccelByte.Sdk/Api/Platform/Model/BulkEntitlementRevokeResult.cs) |
| `BulkOperationResult` | [BulkOperationResult](../../AccelByte.Sdk/Api/Platform/Model/BulkOperationResult.cs) |
| `BulkRegionDataChangeRequest` | [BulkRegionDataChangeRequest](../../AccelByte.Sdk/Api/Platform/Model/BulkRegionDataChangeRequest.cs) |
| `BundledItemInfo` | [BundledItemInfo](../../AccelByte.Sdk/Api/Platform/Model/BundledItemInfo.cs) |
| `CampaignBatchNameChange` | [CampaignBatchNameChange](../../AccelByte.Sdk/Api/Platform/Model/CampaignBatchNameChange.cs) |
| `CampaignBatchNameInfo` | [CampaignBatchNameInfo](../../AccelByte.Sdk/Api/Platform/Model/CampaignBatchNameInfo.cs) |
| `CampaignCreate` | [CampaignCreate](../../AccelByte.Sdk/Api/Platform/Model/CampaignCreate.cs) |
| `CampaignDynamicInfo` | [CampaignDynamicInfo](../../AccelByte.Sdk/Api/Platform/Model/CampaignDynamicInfo.cs) |
| `CampaignIfc` | [CampaignIfc](../../AccelByte.Sdk/Api/Platform/Model/CampaignIfc.cs) |
| `CampaignInfo` | [CampaignInfo](../../AccelByte.Sdk/Api/Platform/Model/CampaignInfo.cs) |
| `CampaignPagingSlicedResult` | [CampaignPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/CampaignPagingSlicedResult.cs) |
| `CampaignUpdate` | [CampaignUpdate](../../AccelByte.Sdk/Api/Platform/Model/CampaignUpdate.cs) |
| `CancelRequest` | [CancelRequest](../../AccelByte.Sdk/Api/Platform/Model/CancelRequest.cs) |
| `CatalogChangeInfo` | [CatalogChangeInfo](../../AccelByte.Sdk/Api/Platform/Model/CatalogChangeInfo.cs) |
| `CatalogChangePagingResult` | [CatalogChangePagingResult](../../AccelByte.Sdk/Api/Platform/Model/CatalogChangePagingResult.cs) |
| `CatalogChangeStatistics` | [CatalogChangeStatistics](../../AccelByte.Sdk/Api/Platform/Model/CatalogChangeStatistics.cs) |
| `CatalogConfigInfo` | [CatalogConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/CatalogConfigInfo.cs) |
| `CatalogConfigUpdate` | [CatalogConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/CatalogConfigUpdate.cs) |
| `CatalogDefinitionInfo` | [CatalogDefinitionInfo](../../AccelByte.Sdk/Api/Platform/Model/CatalogDefinitionInfo.cs) |
| `CategoryCreate` | [CategoryCreate](../../AccelByte.Sdk/Api/Platform/Model/CategoryCreate.cs) |
| `CategoryInfo` | [CategoryInfo](../../AccelByte.Sdk/Api/Platform/Model/CategoryInfo.cs) |
| `CategoryUpdate` | [CategoryUpdate](../../AccelByte.Sdk/Api/Platform/Model/CategoryUpdate.cs) |
| `ChangeStatusItemRequest` | [ChangeStatusItemRequest](../../AccelByte.Sdk/Api/Platform/Model/ChangeStatusItemRequest.cs) |
| `CheckoutConfig` | [CheckoutConfig](../../AccelByte.Sdk/Api/Platform/Model/CheckoutConfig.cs) |
| `ClawbackInfo` | [ClawbackInfo](../../AccelByte.Sdk/Api/Platform/Model/ClawbackInfo.cs) |
| `ClientRequestParameter` | [ClientRequestParameter](../../AccelByte.Sdk/Api/Platform/Model/ClientRequestParameter.cs) |
| `ClientTransaction` | [ClientTransaction](../../AccelByte.Sdk/Api/Platform/Model/ClientTransaction.cs) |
| `CodeCreate` | [CodeCreate](../../AccelByte.Sdk/Api/Platform/Model/CodeCreate.cs) |
| `CodeCreateResult` | [CodeCreateResult](../../AccelByte.Sdk/Api/Platform/Model/CodeCreateResult.cs) |
| `CodeInfo` | [CodeInfo](../../AccelByte.Sdk/Api/Platform/Model/CodeInfo.cs) |
| `CodeInfoPagingSlicedResult` | [CodeInfoPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/CodeInfoPagingSlicedResult.cs) |
| `ConditionGroup` | [ConditionGroup](../../AccelByte.Sdk/Api/Platform/Model/ConditionGroup.cs) |
| `ConditionGroupValidateResult` | [ConditionGroupValidateResult](../../AccelByte.Sdk/Api/Platform/Model/ConditionGroupValidateResult.cs) |
| `ConditionMatchResult` | [ConditionMatchResult](../../AccelByte.Sdk/Api/Platform/Model/ConditionMatchResult.cs) |
| `ConsumableEntitlementRevocationConfig` | [ConsumableEntitlementRevocationConfig](../../AccelByte.Sdk/Api/Platform/Model/ConsumableEntitlementRevocationConfig.cs) |
| `ConsumeItem` | [ConsumeItem](../../AccelByte.Sdk/Api/Platform/Model/ConsumeItem.cs) |
| `CreditPayload` | [CreditPayload](../../AccelByte.Sdk/Api/Platform/Model/CreditPayload.cs) |
| `CreditRequest` | [CreditRequest](../../AccelByte.Sdk/Api/Platform/Model/CreditRequest.cs) |
| `CreditResult` | [CreditResult](../../AccelByte.Sdk/Api/Platform/Model/CreditResult.cs) |
| `CreditRevocation` | [CreditRevocation](../../AccelByte.Sdk/Api/Platform/Model/CreditRevocation.cs) |
| `CreditSummary` | [CreditSummary](../../AccelByte.Sdk/Api/Platform/Model/CreditSummary.cs) |
| `CurrencyConfig` | [CurrencyConfig](../../AccelByte.Sdk/Api/Platform/Model/CurrencyConfig.cs) |
| `CurrencyCreate` | [CurrencyCreate](../../AccelByte.Sdk/Api/Platform/Model/CurrencyCreate.cs) |
| `CurrencyInfo` | [CurrencyInfo](../../AccelByte.Sdk/Api/Platform/Model/CurrencyInfo.cs) |
| `CurrencySummary` | [CurrencySummary](../../AccelByte.Sdk/Api/Platform/Model/CurrencySummary.cs) |
| `CurrencyUpdate` | [CurrencyUpdate](../../AccelByte.Sdk/Api/Platform/Model/CurrencyUpdate.cs) |
| `CurrencyWallet` | [CurrencyWallet](../../AccelByte.Sdk/Api/Platform/Model/CurrencyWallet.cs) |
| `Customization` | [Customization](../../AccelByte.Sdk/Api/Platform/Model/Customization.cs) |
| `DLCConfigRewardShortInfo` | [DLCConfigRewardShortInfo](../../AccelByte.Sdk/Api/Platform/Model/DLCConfigRewardShortInfo.cs) |
| `DLCItem` | [DLCItem](../../AccelByte.Sdk/Api/Platform/Model/DLCItem.cs) |
| `DLCItemConfigHistoryInfo` | [DLCItemConfigHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigHistoryInfo.cs) |
| `DLCItemConfigHistoryResult` | [DLCItemConfigHistoryResult](../../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigHistoryResult.cs) |
| `DLCItemConfigInfo` | [DLCItemConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigInfo.cs) |
| `DLCItemConfigUpdate` | [DLCItemConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigUpdate.cs) |
| `DLCRecord` | [DLCRecord](../../AccelByte.Sdk/Api/Platform/Model/DLCRecord.cs) |
| `DebitByCurrencyCodeRequest` | [DebitByCurrencyCodeRequest](../../AccelByte.Sdk/Api/Platform/Model/DebitByCurrencyCodeRequest.cs) |
| `DebitByWalletPlatformRequest` | [DebitByWalletPlatformRequest](../../AccelByte.Sdk/Api/Platform/Model/DebitByWalletPlatformRequest.cs) |
| `DebitPayload` | [DebitPayload](../../AccelByte.Sdk/Api/Platform/Model/DebitPayload.cs) |
| `DebitRequest` | [DebitRequest](../../AccelByte.Sdk/Api/Platform/Model/DebitRequest.cs) |
| `DebitResult` | [DebitResult](../../AccelByte.Sdk/Api/Platform/Model/DebitResult.cs) |
| `DeductionDetail` | [DeductionDetail](../../AccelByte.Sdk/Api/Platform/Model/DeductionDetail.cs) |
| `DeleteRewardConditionRequest` | [DeleteRewardConditionRequest](../../AccelByte.Sdk/Api/Platform/Model/DeleteRewardConditionRequest.cs) |
| `DetailedWalletTransactionInfo` | [DetailedWalletTransactionInfo](../../AccelByte.Sdk/Api/Platform/Model/DetailedWalletTransactionInfo.cs) |
| `DetailedWalletTransactionPagingSlicedResult` | [DetailedWalletTransactionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/DetailedWalletTransactionPagingSlicedResult.cs) |
| `DiscountCategory` | [DiscountCategory](../../AccelByte.Sdk/Api/Platform/Model/DiscountCategory.cs) |
| `DiscountCodeDeductionDetail` | [DiscountCodeDeductionDetail](../../AccelByte.Sdk/Api/Platform/Model/DiscountCodeDeductionDetail.cs) |
| `DiscountCodeInfo` | [DiscountCodeInfo](../../AccelByte.Sdk/Api/Platform/Model/DiscountCodeInfo.cs) |
| `DiscountConfig` | [DiscountConfig](../../AccelByte.Sdk/Api/Platform/Model/DiscountConfig.cs) |
| `DiscountItem` | [DiscountItem](../../AccelByte.Sdk/Api/Platform/Model/DiscountItem.cs) |
| `DurableEntitlementRevocationConfig` | [DurableEntitlementRevocationConfig](../../AccelByte.Sdk/Api/Platform/Model/DurableEntitlementRevocationConfig.cs) |
| `EntitlementConfigInfo` | [EntitlementConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/EntitlementConfigInfo.cs) |
| `EntitlementDecrementResult` | [EntitlementDecrementResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementDecrementResult.cs) |
| `EntitlementGrant` | [EntitlementGrant](../../AccelByte.Sdk/Api/Platform/Model/EntitlementGrant.cs) |
| `EntitlementGrantResult` | [EntitlementGrantResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementGrantResult.cs) |
| `EntitlementHistoryInfo` | [EntitlementHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/EntitlementHistoryInfo.cs) |
| `EntitlementIfc` | [EntitlementIfc](../../AccelByte.Sdk/Api/Platform/Model/EntitlementIfc.cs) |
| `EntitlementInfo` | [EntitlementInfo](../../AccelByte.Sdk/Api/Platform/Model/EntitlementInfo.cs) |
| `EntitlementLootBoxReward` | [EntitlementLootBoxReward](../../AccelByte.Sdk/Api/Platform/Model/EntitlementLootBoxReward.cs) |
| `EntitlementOriginSyncResult` | [EntitlementOriginSyncResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementOriginSyncResult.cs) |
| `EntitlementOwnership` | [EntitlementOwnership](../../AccelByte.Sdk/Api/Platform/Model/EntitlementOwnership.cs) |
| `EntitlementPagingSlicedResult` | [EntitlementPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementPagingSlicedResult.cs) |
| `EntitlementPlatformConfigInfo` | [EntitlementPlatformConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/EntitlementPlatformConfigInfo.cs) |
| `EntitlementPlatformConfigUpdate` | [EntitlementPlatformConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/EntitlementPlatformConfigUpdate.cs) |
| `EntitlementPrechekResult` | [EntitlementPrechekResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementPrechekResult.cs) |
| `EntitlementRevocation` | [EntitlementRevocation](../../AccelByte.Sdk/Api/Platform/Model/EntitlementRevocation.cs) |
| `EntitlementRevocationConfig` | [EntitlementRevocationConfig](../../AccelByte.Sdk/Api/Platform/Model/EntitlementRevocationConfig.cs) |
| `EntitlementRevokeRequest` | [EntitlementRevokeRequest](../../AccelByte.Sdk/Api/Platform/Model/EntitlementRevokeRequest.cs) |
| `EntitlementRevokeResult` | [EntitlementRevokeResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementRevokeResult.cs) |
| `EntitlementSoldRequest` | [EntitlementSoldRequest](../../AccelByte.Sdk/Api/Platform/Model/EntitlementSoldRequest.cs) |
| `EntitlementSoldResult` | [EntitlementSoldResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementSoldResult.cs) |
| `EntitlementSplitRequest` | [EntitlementSplitRequest](../../AccelByte.Sdk/Api/Platform/Model/EntitlementSplitRequest.cs) |
| `EntitlementSplitResult` | [EntitlementSplitResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementSplitResult.cs) |
| `EntitlementSummary` | [EntitlementSummary](../../AccelByte.Sdk/Api/Platform/Model/EntitlementSummary.cs) |
| `EntitlementTransferRequest` | [EntitlementTransferRequest](../../AccelByte.Sdk/Api/Platform/Model/EntitlementTransferRequest.cs) |
| `EntitlementTransferResult` | [EntitlementTransferResult](../../AccelByte.Sdk/Api/Platform/Model/EntitlementTransferResult.cs) |
| `EntitlementUpdate` | [EntitlementUpdate](../../AccelByte.Sdk/Api/Platform/Model/EntitlementUpdate.cs) |
| `EpicGamesDLCSyncRequest` | [EpicGamesDLCSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/EpicGamesDLCSyncRequest.cs) |
| `EpicGamesIAPConfigInfo` | [EpicGamesIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/EpicGamesIAPConfigInfo.cs) |
| `EpicGamesIAPConfigRequest` | [EpicGamesIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/EpicGamesIAPConfigRequest.cs) |
| `EpicGamesReconcileRequest` | [EpicGamesReconcileRequest](../../AccelByte.Sdk/Api/Platform/Model/EpicGamesReconcileRequest.cs) |
| `EpicGamesReconcileResult` | [EpicGamesReconcileResult](../../AccelByte.Sdk/Api/Platform/Model/EpicGamesReconcileResult.cs) |
| `ErrorEntity` | [ErrorEntity](../../AccelByte.Sdk/Api/Platform/Model/ErrorEntity.cs) |
| `EstimatedPriceInfo` | [EstimatedPriceInfo](../../AccelByte.Sdk/Api/Platform/Model/EstimatedPriceInfo.cs) |
| `EventAdditionalData` | [EventAdditionalData](../../AccelByte.Sdk/Api/Platform/Model/EventAdditionalData.cs) |
| `EventPayload` | [EventPayload](../../AccelByte.Sdk/Api/Platform/Model/EventPayload.cs) |
| `ExportStoreRequest` | [ExportStoreRequest](../../AccelByte.Sdk/Api/Platform/Model/ExportStoreRequest.cs) |
| `ExportStoreToCSVRequest` | [ExportStoreToCSVRequest](../../AccelByte.Sdk/Api/Platform/Model/ExportStoreToCSVRequest.cs) |
| `ExtensionFulfillmentSummary` | [ExtensionFulfillmentSummary](../../AccelByte.Sdk/Api/Platform/Model/ExtensionFulfillmentSummary.cs) |
| `ExternalPaymentOrderCreate` | [ExternalPaymentOrderCreate](../../AccelByte.Sdk/Api/Platform/Model/ExternalPaymentOrderCreate.cs) |
| `FeatureReference` | [FeatureReference](../../AccelByte.Sdk/Api/Platform/Model/FeatureReference.cs) |
| `FieldValidationError` | [FieldValidationError](../../AccelByte.Sdk/Api/Platform/Model/FieldValidationError.cs) |
| `FixedPeriodRotationConfig` | [FixedPeriodRotationConfig](../../AccelByte.Sdk/Api/Platform/Model/FixedPeriodRotationConfig.cs) |
| `FulFillItemPayload` | [FulFillItemPayload](../../AccelByte.Sdk/Api/Platform/Model/FulFillItemPayload.cs) |
| `FulfillBundledItemResult` | [FulfillBundledItemResult](../../AccelByte.Sdk/Api/Platform/Model/FulfillBundledItemResult.cs) |
| `FulfillCodeRequest` | [FulfillCodeRequest](../../AccelByte.Sdk/Api/Platform/Model/FulfillCodeRequest.cs) |
| `FulfillItemResult` | [FulfillItemResult](../../AccelByte.Sdk/Api/Platform/Model/FulfillItemResult.cs) |
| `FulfillmentActionHistory` | [FulfillmentActionHistory](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentActionHistory.cs) |
| `FulfillmentError` | [FulfillmentError](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentError.cs) |
| `FulfillmentHistoryInfo` | [FulfillmentHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentHistoryInfo.cs) |
| `FulfillmentHistoryPagingSlicedResult` | [FulfillmentHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentHistoryPagingSlicedResult.cs) |
| `FulfillmentInfo` | [FulfillmentInfo](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentInfo.cs) |
| `FulfillmentItem` | [FulfillmentItem](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentItem.cs) |
| `FulfillmentPagingSlicedResult` | [FulfillmentPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentPagingSlicedResult.cs) |
| `FulfillmentRequest` | [FulfillmentRequest](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentRequest.cs) |
| `FulfillmentResult` | [FulfillmentResult](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentResult.cs) |
| `FulfillmentScriptCreate` | [FulfillmentScriptCreate](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptCreate.cs) |
| `FulfillmentScriptInfo` | [FulfillmentScriptInfo](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptInfo.cs) |
| `FulfillmentScriptUpdate` | [FulfillmentScriptUpdate](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptUpdate.cs) |
| `FulfillmentStateInfo` | [FulfillmentStateInfo](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentStateInfo.cs) |
| `FulfillmentV2Request` | [FulfillmentV2Request](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentV2Request.cs) |
| `FulfillmentV2RequestItem` | [FulfillmentV2RequestItem](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentV2RequestItem.cs) |
| `FulfillmentV2Result` | [FulfillmentV2Result](../../AccelByte.Sdk/Api/Platform/Model/FulfillmentV2Result.cs) |
| `FullAppInfo` | [FullAppInfo](../../AccelByte.Sdk/Api/Platform/Model/FullAppInfo.cs) |
| `FullCategoryInfo` | [FullCategoryInfo](../../AccelByte.Sdk/Api/Platform/Model/FullCategoryInfo.cs) |
| `FullItemInfo` | [FullItemInfo](../../AccelByte.Sdk/Api/Platform/Model/FullItemInfo.cs) |
| `FullItemPagingResult` | [FullItemPagingResult](../../AccelByte.Sdk/Api/Platform/Model/FullItemPagingResult.cs) |
| `FullItemPagingSlicedResult` | [FullItemPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/FullItemPagingSlicedResult.cs) |
| `FullSectionInfo` | [FullSectionInfo](../../AccelByte.Sdk/Api/Platform/Model/FullSectionInfo.cs) |
| `FullViewInfo` | [FullViewInfo](../../AccelByte.Sdk/Api/Platform/Model/FullViewInfo.cs) |
| `GoogleIAPConfigInfo` | [GoogleIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/GoogleIAPConfigInfo.cs) |
| `GoogleIAPConfigRequest` | [GoogleIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/GoogleIAPConfigRequest.cs) |
| `GoogleIAPReceipt` | [GoogleIAPReceipt](../../AccelByte.Sdk/Api/Platform/Model/GoogleIAPReceipt.cs) |
| `GoogleReceiptResolveResult` | [GoogleReceiptResolveResult](../../AccelByte.Sdk/Api/Platform/Model/GoogleReceiptResolveResult.cs) |
| `GrantSubscriptionDaysRequest` | [GrantSubscriptionDaysRequest](../../AccelByte.Sdk/Api/Platform/Model/GrantSubscriptionDaysRequest.cs) |
| `GrpcServerInfo` | [GrpcServerInfo](../../AccelByte.Sdk/Api/Platform/Model/GrpcServerInfo.cs) |
| `HierarchicalCategoryInfo` | [HierarchicalCategoryInfo](../../AccelByte.Sdk/Api/Platform/Model/HierarchicalCategoryInfo.cs) |
| `IAPClawbackPagingSlicedResult` | [IAPClawbackPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/IAPClawbackPagingSlicedResult.cs) |
| `IAPConsumeHistoryInfo` | [IAPConsumeHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPConsumeHistoryInfo.cs) |
| `IAPConsumeHistoryPagingSlicedResult` | [IAPConsumeHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/IAPConsumeHistoryPagingSlicedResult.cs) |
| `IAPItemConfigInfo` | [IAPItemConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPItemConfigInfo.cs) |
| `IAPItemConfigUpdate` | [IAPItemConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/IAPItemConfigUpdate.cs) |
| `IAPItemEntry` | [IAPItemEntry](../../AccelByte.Sdk/Api/Platform/Model/IAPItemEntry.cs) |
| `IAPItemFlatEntry` | [IAPItemFlatEntry](../../AccelByte.Sdk/Api/Platform/Model/IAPItemFlatEntry.cs) |
| `IAPItemMappingInfo` | [IAPItemMappingInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPItemMappingInfo.cs) |
| `IAPOrderConsumeDetailInfo` | [IAPOrderConsumeDetailInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPOrderConsumeDetailInfo.cs) |
| `IAPOrderInfo` | [IAPOrderInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPOrderInfo.cs) |
| `IAPOrderLineItemInfo` | [IAPOrderLineItemInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPOrderLineItemInfo.cs) |
| `IAPOrderPagingSlicedResult` | [IAPOrderPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/IAPOrderPagingSlicedResult.cs) |
| `IAPOrderShortInfo` | [IAPOrderShortInfo](../../AccelByte.Sdk/Api/Platform/Model/IAPOrderShortInfo.cs) |
| `Image` | [Image](../../AccelByte.Sdk/Api/Platform/Model/Image.cs) |
| `ImportErrorDetails` | [ImportErrorDetails](../../AccelByte.Sdk/Api/Platform/Model/ImportErrorDetails.cs) |
| `ImportStoreAppInfo` | [ImportStoreAppInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreAppInfo.cs) |
| `ImportStoreCategoryInfo` | [ImportStoreCategoryInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreCategoryInfo.cs) |
| `ImportStoreError` | [ImportStoreError](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreError.cs) |
| `ImportStoreHistoryInfo` | [ImportStoreHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreHistoryInfo.cs) |
| `ImportStoreHistoryPagingResult` | [ImportStoreHistoryPagingResult](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreHistoryPagingResult.cs) |
| `ImportStoreItemInfo` | [ImportStoreItemInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreItemInfo.cs) |
| `ImportStoreResult` | [ImportStoreResult](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreResult.cs) |
| `ImportStoreSectionInfo` | [ImportStoreSectionInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreSectionInfo.cs) |
| `ImportStoreViewInfo` | [ImportStoreViewInfo](../../AccelByte.Sdk/Api/Platform/Model/ImportStoreViewInfo.cs) |
| `InGameItemSync` | [InGameItemSync](../../AccelByte.Sdk/Api/Platform/Model/InGameItemSync.cs) |
| `InventoryConfig` | [InventoryConfig](../../AccelByte.Sdk/Api/Platform/Model/InventoryConfig.cs) |
| `InvoiceCurrencySummary` | [InvoiceCurrencySummary](../../AccelByte.Sdk/Api/Platform/Model/InvoiceCurrencySummary.cs) |
| `InvoiceSummary` | [InvoiceSummary](../../AccelByte.Sdk/Api/Platform/Model/InvoiceSummary.cs) |
| `ItemAcquireRequest` | [ItemAcquireRequest](../../AccelByte.Sdk/Api/Platform/Model/ItemAcquireRequest.cs) |
| `ItemAcquireResult` | [ItemAcquireResult](../../AccelByte.Sdk/Api/Platform/Model/ItemAcquireResult.cs) |
| `ItemCreate` | [ItemCreate](../../AccelByte.Sdk/Api/Platform/Model/ItemCreate.cs) |
| `ItemDependency` | [ItemDependency](../../AccelByte.Sdk/Api/Platform/Model/ItemDependency.cs) |
| `ItemDynamicDataInfo` | [ItemDynamicDataInfo](../../AccelByte.Sdk/Api/Platform/Model/ItemDynamicDataInfo.cs) |
| `ItemId` | [ItemId](../../AccelByte.Sdk/Api/Platform/Model/ItemId.cs) |
| `ItemInfo` | [ItemInfo](../../AccelByte.Sdk/Api/Platform/Model/ItemInfo.cs) |
| `ItemNaming` | [ItemNaming](../../AccelByte.Sdk/Api/Platform/Model/ItemNaming.cs) |
| `ItemPagingSlicedResult` | [ItemPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/ItemPagingSlicedResult.cs) |
| `ItemPurchaseConditionValidateRequest` | [ItemPurchaseConditionValidateRequest](../../AccelByte.Sdk/Api/Platform/Model/ItemPurchaseConditionValidateRequest.cs) |
| `ItemPurchaseConditionValidateResult` | [ItemPurchaseConditionValidateResult](../../AccelByte.Sdk/Api/Platform/Model/ItemPurchaseConditionValidateResult.cs) |
| `ItemReference` | [ItemReference](../../AccelByte.Sdk/Api/Platform/Model/ItemReference.cs) |
| `ItemReturnRequest` | [ItemReturnRequest](../../AccelByte.Sdk/Api/Platform/Model/ItemReturnRequest.cs) |
| `ItemRevocation` | [ItemRevocation](../../AccelByte.Sdk/Api/Platform/Model/ItemRevocation.cs) |
| `ItemSnapshot` | [ItemSnapshot](../../AccelByte.Sdk/Api/Platform/Model/ItemSnapshot.cs) |
| `ItemTypeConfigCreate` | [ItemTypeConfigCreate](../../AccelByte.Sdk/Api/Platform/Model/ItemTypeConfigCreate.cs) |
| `ItemTypeConfigInfo` | [ItemTypeConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/ItemTypeConfigInfo.cs) |
| `ItemTypeConfigUpdate` | [ItemTypeConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/ItemTypeConfigUpdate.cs) |
| `ItemUpdate` | [ItemUpdate](../../AccelByte.Sdk/Api/Platform/Model/ItemUpdate.cs) |
| `KeyGroupCreate` | [KeyGroupCreate](../../AccelByte.Sdk/Api/Platform/Model/KeyGroupCreate.cs) |
| `KeyGroupDynamicInfo` | [KeyGroupDynamicInfo](../../AccelByte.Sdk/Api/Platform/Model/KeyGroupDynamicInfo.cs) |
| `KeyGroupInfo` | [KeyGroupInfo](../../AccelByte.Sdk/Api/Platform/Model/KeyGroupInfo.cs) |
| `KeyGroupPagingSlicedResult` | [KeyGroupPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/KeyGroupPagingSlicedResult.cs) |
| `KeyGroupUpdate` | [KeyGroupUpdate](../../AccelByte.Sdk/Api/Platform/Model/KeyGroupUpdate.cs) |
| `KeyInfo` | [KeyInfo](../../AccelByte.Sdk/Api/Platform/Model/KeyInfo.cs) |
| `KeyPagingSliceResult` | [KeyPagingSliceResult](../../AccelByte.Sdk/Api/Platform/Model/KeyPagingSliceResult.cs) |
| `ListViewInfo` | [ListViewInfo](../../AccelByte.Sdk/Api/Platform/Model/ListViewInfo.cs) |
| `Localization` | [Localization](../../AccelByte.Sdk/Api/Platform/Model/Localization.cs) |
| `LootBoxConfig` | [LootBoxConfig](../../AccelByte.Sdk/Api/Platform/Model/LootBoxConfig.cs) |
| `LootBoxPluginConfigInfo` | [LootBoxPluginConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/LootBoxPluginConfigInfo.cs) |
| `LootBoxPluginConfigUpdate` | [LootBoxPluginConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/LootBoxPluginConfigUpdate.cs) |
| `LootBoxReward` | [LootBoxReward](../../AccelByte.Sdk/Api/Platform/Model/LootBoxReward.cs) |
| `MockIAPReceipt` | [MockIAPReceipt](../../AccelByte.Sdk/Api/Platform/Model/MockIAPReceipt.cs) |
| `ModuleReference` | [ModuleReference](../../AccelByte.Sdk/Api/Platform/Model/ModuleReference.cs) |
| `NeonPayConfig` | [NeonPayConfig](../../AccelByte.Sdk/Api/Platform/Model/NeonPayConfig.cs) |
| `NotificationPagingSlicedResult` | [NotificationPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/NotificationPagingSlicedResult.cs) |
| `NotificationProcessResult` | [NotificationProcessResult](../../AccelByte.Sdk/Api/Platform/Model/NotificationProcessResult.cs) |
| `OculusIAPConfigInfo` | [OculusIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/OculusIAPConfigInfo.cs) |
| `OculusIAPConfigRequest` | [OculusIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/OculusIAPConfigRequest.cs) |
| `OculusReconcileResult` | [OculusReconcileResult](../../AccelByte.Sdk/Api/Platform/Model/OculusReconcileResult.cs) |
| `Operation` | [Operation](../../AccelByte.Sdk/Api/Platform/Model/Operation.cs) |
| `OperationRequest` | [OperationRequest](../../AccelByte.Sdk/Api/Platform/Model/OperationRequest.cs) |
| `OptionBoxConfig` | [OptionBoxConfig](../../AccelByte.Sdk/Api/Platform/Model/OptionBoxConfig.cs) |
| `Order` | [Order](../../AccelByte.Sdk/Api/Platform/Model/Order.cs) |
| `OrderBundleItemInfo` | [OrderBundleItemInfo](../../AccelByte.Sdk/Api/Platform/Model/OrderBundleItemInfo.cs) |
| `OrderCreate` | [OrderCreate](../../AccelByte.Sdk/Api/Platform/Model/OrderCreate.cs) |
| `OrderCreationOptions` | [OrderCreationOptions](../../AccelByte.Sdk/Api/Platform/Model/OrderCreationOptions.cs) |
| `OrderDiscountPreviewRequest` | [OrderDiscountPreviewRequest](../../AccelByte.Sdk/Api/Platform/Model/OrderDiscountPreviewRequest.cs) |
| `OrderDiscountPreviewResponse` | [OrderDiscountPreviewResponse](../../AccelByte.Sdk/Api/Platform/Model/OrderDiscountPreviewResponse.cs) |
| `OrderGrantInfo` | [OrderGrantInfo](../../AccelByte.Sdk/Api/Platform/Model/OrderGrantInfo.cs) |
| `OrderHistoryInfo` | [OrderHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/OrderHistoryInfo.cs) |
| `OrderInfo` | [OrderInfo](../../AccelByte.Sdk/Api/Platform/Model/OrderInfo.cs) |
| `OrderPagingResult` | [OrderPagingResult](../../AccelByte.Sdk/Api/Platform/Model/OrderPagingResult.cs) |
| `OrderPagingSlicedResult` | [OrderPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/OrderPagingSlicedResult.cs) |
| `OrderRefundCreate` | [OrderRefundCreate](../../AccelByte.Sdk/Api/Platform/Model/OrderRefundCreate.cs) |
| `OrderStatistics` | [OrderStatistics](../../AccelByte.Sdk/Api/Platform/Model/OrderStatistics.cs) |
| `OrderSummary` | [OrderSummary](../../AccelByte.Sdk/Api/Platform/Model/OrderSummary.cs) |
| `OrderSyncResult` | [OrderSyncResult](../../AccelByte.Sdk/Api/Platform/Model/OrderSyncResult.cs) |
| `OrderUpdate` | [OrderUpdate](../../AccelByte.Sdk/Api/Platform/Model/OrderUpdate.cs) |
| `Ownership` | [Ownership](../../AccelByte.Sdk/Api/Platform/Model/Ownership.cs) |
| `OwnershipToken` | [OwnershipToken](../../AccelByte.Sdk/Api/Platform/Model/OwnershipToken.cs) |
| `Paging` | [Paging](../../AccelByte.Sdk/Api/Platform/Model/Paging.cs) |
| `PayPalConfig` | [PayPalConfig](../../AccelByte.Sdk/Api/Platform/Model/PayPalConfig.cs) |
| `PaymentAccount` | [PaymentAccount](../../AccelByte.Sdk/Api/Platform/Model/PaymentAccount.cs) |
| `PaymentCallbackConfigInfo` | [PaymentCallbackConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentCallbackConfigInfo.cs) |
| `PaymentCallbackConfigUpdate` | [PaymentCallbackConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/PaymentCallbackConfigUpdate.cs) |
| `PaymentData` | [PaymentData](../../AccelByte.Sdk/Api/Platform/Model/PaymentData.cs) |
| `PaymentDomainWhitelistConfigEdit` | [PaymentDomainWhitelistConfigEdit](../../AccelByte.Sdk/Api/Platform/Model/PaymentDomainWhitelistConfigEdit.cs) |
| `PaymentDomainWhitelistConfigInfo` | [PaymentDomainWhitelistConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentDomainWhitelistConfigInfo.cs) |
| `PaymentMerchantConfigInfo` | [PaymentMerchantConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentMerchantConfigInfo.cs) |
| `PaymentMethod` | [PaymentMethod](../../AccelByte.Sdk/Api/Platform/Model/PaymentMethod.cs) |
| `PaymentNotificationInfo` | [PaymentNotificationInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentNotificationInfo.cs) |
| `PaymentNotificationPagingSlicedResult` | [PaymentNotificationPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentNotificationPagingSlicedResult.cs) |
| `PaymentOrder` | [PaymentOrder](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrder.cs) |
| `PaymentOrderChargeRequest` | [PaymentOrderChargeRequest](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderChargeRequest.cs) |
| `PaymentOrderChargeStatus` | [PaymentOrderChargeStatus](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderChargeStatus.cs) |
| `PaymentOrderCreate` | [PaymentOrderCreate](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderCreate.cs) |
| `PaymentOrderCreateResult` | [PaymentOrderCreateResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderCreateResult.cs) |
| `PaymentOrderDetails` | [PaymentOrderDetails](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderDetails.cs) |
| `PaymentOrderInfo` | [PaymentOrderInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderInfo.cs) |
| `PaymentOrderNeonPayConfig` | [PaymentOrderNeonPayConfig](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderNeonPayConfig.cs) |
| `PaymentOrderNotifySimulation` | [PaymentOrderNotifySimulation](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderNotifySimulation.cs) |
| `PaymentOrderPagingSlicedResult` | [PaymentOrderPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderPagingSlicedResult.cs) |
| `PaymentOrderPaidResult` | [PaymentOrderPaidResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderPaidResult.cs) |
| `PaymentOrderRefund` | [PaymentOrderRefund](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderRefund.cs) |
| `PaymentOrderRefundResult` | [PaymentOrderRefundResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderRefundResult.cs) |
| `PaymentOrderSyncResult` | [PaymentOrderSyncResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentOrderSyncResult.cs) |
| `PaymentProcessResult` | [PaymentProcessResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentProcessResult.cs) |
| `PaymentProviderConfigEdit` | [PaymentProviderConfigEdit](../../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigEdit.cs) |
| `PaymentProviderConfigInfo` | [PaymentProviderConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigInfo.cs) |
| `PaymentProviderConfigPagingSlicedResult` | [PaymentProviderConfigPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigPagingSlicedResult.cs) |
| `PaymentRequest` | [PaymentRequest](../../AccelByte.Sdk/Api/Platform/Model/PaymentRequest.cs) |
| `PaymentTaxConfigEdit` | [PaymentTaxConfigEdit](../../AccelByte.Sdk/Api/Platform/Model/PaymentTaxConfigEdit.cs) |
| `PaymentTaxConfigInfo` | [PaymentTaxConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PaymentTaxConfigInfo.cs) |
| `PaymentToken` | [PaymentToken](../../AccelByte.Sdk/Api/Platform/Model/PaymentToken.cs) |
| `PaymentUrl` | [PaymentUrl](../../AccelByte.Sdk/Api/Platform/Model/PaymentUrl.cs) |
| `PaymentUrlCreate` | [PaymentUrlCreate](../../AccelByte.Sdk/Api/Platform/Model/PaymentUrlCreate.cs) |
| `Permission` | [Permission](../../AccelByte.Sdk/Api/Platform/Model/Permission.cs) |
| `PlatformAccountClosureHistoryInfo` | [PlatformAccountClosureHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/PlatformAccountClosureHistoryInfo.cs) |
| `PlatformDLCConfigInfo` | [PlatformDLCConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PlatformDLCConfigInfo.cs) |
| `PlatformDLCConfigUpdate` | [PlatformDLCConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/PlatformDLCConfigUpdate.cs) |
| `PlatformDlcEntry` | [PlatformDlcEntry](../../AccelByte.Sdk/Api/Platform/Model/PlatformDlcEntry.cs) |
| `PlatformOwnership` | [PlatformOwnership](../../AccelByte.Sdk/Api/Platform/Model/PlatformOwnership.cs) |
| `PlatformReward` | [PlatformReward](../../AccelByte.Sdk/Api/Platform/Model/PlatformReward.cs) |
| `PlatformRewardCurrency` | [PlatformRewardCurrency](../../AccelByte.Sdk/Api/Platform/Model/PlatformRewardCurrency.cs) |
| `PlatformRewardItem` | [PlatformRewardItem](../../AccelByte.Sdk/Api/Platform/Model/PlatformRewardItem.cs) |
| `PlatformSubscribeRequest` | [PlatformSubscribeRequest](../../AccelByte.Sdk/Api/Platform/Model/PlatformSubscribeRequest.cs) |
| `PlatformWallet` | [PlatformWallet](../../AccelByte.Sdk/Api/Platform/Model/PlatformWallet.cs) |
| `PlatformWalletConfigInfo` | [PlatformWalletConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PlatformWalletConfigInfo.cs) |
| `PlatformWalletConfigUpdate` | [PlatformWalletConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/PlatformWalletConfigUpdate.cs) |
| `PlayStationDLCSyncMultiServiceLabelsRequest` | [PlayStationDLCSyncMultiServiceLabelsRequest](../../AccelByte.Sdk/Api/Platform/Model/PlayStationDLCSyncMultiServiceLabelsRequest.cs) |
| `PlayStationDLCSyncRequest` | [PlayStationDLCSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/PlayStationDLCSyncRequest.cs) |
| `PlayStationIAPConfigInfo` | [PlayStationIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PlayStationIAPConfigInfo.cs) |
| `PlayStationMultiServiceLabelsReconcileRequest` | [PlayStationMultiServiceLabelsReconcileRequest](../../AccelByte.Sdk/Api/Platform/Model/PlayStationMultiServiceLabelsReconcileRequest.cs) |
| `PlayStationReconcileRequest` | [PlayStationReconcileRequest](../../AccelByte.Sdk/Api/Platform/Model/PlayStationReconcileRequest.cs) |
| `PlayStationReconcileResult` | [PlayStationReconcileResult](../../AccelByte.Sdk/Api/Platform/Model/PlayStationReconcileResult.cs) |
| `PlaystationIAPConfigRequest` | [PlaystationIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/PlaystationIAPConfigRequest.cs) |
| `PopulatedItemInfo` | [PopulatedItemInfo](../../AccelByte.Sdk/Api/Platform/Model/PopulatedItemInfo.cs) |
| `PreCheckFulfillmentRequest` | [PreCheckFulfillmentRequest](../../AccelByte.Sdk/Api/Platform/Model/PreCheckFulfillmentRequest.cs) |
| `Predicate` | [Predicate](../../AccelByte.Sdk/Api/Platform/Model/Predicate.cs) |
| `PredicateValidateResult` | [PredicateValidateResult](../../AccelByte.Sdk/Api/Platform/Model/PredicateValidateResult.cs) |
| `PsnEntitlementOwnershipRequest` | [PsnEntitlementOwnershipRequest](../../AccelByte.Sdk/Api/Platform/Model/PsnEntitlementOwnershipRequest.cs) |
| `PublicCustomConfigInfo` | [PublicCustomConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/PublicCustomConfigInfo.cs) |
| `PublicEntitlementDecrement` | [PublicEntitlementDecrement](../../AccelByte.Sdk/Api/Platform/Model/PublicEntitlementDecrement.cs) |
| `PublicEntitlementHistoryInfo` | [PublicEntitlementHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/PublicEntitlementHistoryInfo.cs) |
| `PublicEntitlementMetadata` | [PublicEntitlementMetadata](../../AccelByte.Sdk/Api/Platform/Model/PublicEntitlementMetadata.cs) |
| `PurchaseCondition` | [PurchaseCondition](../../AccelByte.Sdk/Api/Platform/Model/PurchaseCondition.cs) |
| `PurchaseConditionUpdate` | [PurchaseConditionUpdate](../../AccelByte.Sdk/Api/Platform/Model/PurchaseConditionUpdate.cs) |
| `PurchasedItemCount` | [PurchasedItemCount](../../AccelByte.Sdk/Api/Platform/Model/PurchasedItemCount.cs) |
| `Recurring` | [Recurring](../../AccelByte.Sdk/Api/Platform/Model/Recurring.cs) |
| `RecurringChargeResult` | [RecurringChargeResult](../../AccelByte.Sdk/Api/Platform/Model/RecurringChargeResult.cs) |
| `RedeemHistoryInfo` | [RedeemHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/RedeemHistoryInfo.cs) |
| `RedeemHistoryPagingSlicedResult` | [RedeemHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/RedeemHistoryPagingSlicedResult.cs) |
| `RedeemRequest` | [RedeemRequest](../../AccelByte.Sdk/Api/Platform/Model/RedeemRequest.cs) |
| `RedeemResult` | [RedeemResult](../../AccelByte.Sdk/Api/Platform/Model/RedeemResult.cs) |
| `RedeemableItem` | [RedeemableItem](../../AccelByte.Sdk/Api/Platform/Model/RedeemableItem.cs) |
| `RegionDataChange` | [RegionDataChange](../../AccelByte.Sdk/Api/Platform/Model/RegionDataChange.cs) |
| `RegionDataItem` | [RegionDataItem](../../AccelByte.Sdk/Api/Platform/Model/RegionDataItem.cs) |
| `RegionDataItemDTO` | [RegionDataItemDTO](../../AccelByte.Sdk/Api/Platform/Model/RegionDataItemDTO.cs) |
| `RequestHistory` | [RequestHistory](../../AccelByte.Sdk/Api/Platform/Model/RequestHistory.cs) |
| `Requirement` | [Requirement](../../AccelByte.Sdk/Api/Platform/Model/Requirement.cs) |
| `ResetJobRequest` | [ResetJobRequest](../../AccelByte.Sdk/Api/Platform/Model/ResetJobRequest.cs) |
| `RevocationConfigInfo` | [RevocationConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/RevocationConfigInfo.cs) |
| `RevocationConfigUpdate` | [RevocationConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/RevocationConfigUpdate.cs) |
| `RevocationError` | [RevocationError](../../AccelByte.Sdk/Api/Platform/Model/RevocationError.cs) |
| `RevocationHistoryInfo` | [RevocationHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/RevocationHistoryInfo.cs) |
| `RevocationHistoryPagingSlicedResult` | [RevocationHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/RevocationHistoryPagingSlicedResult.cs) |
| `RevocationPluginConfigInfo` | [RevocationPluginConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/RevocationPluginConfigInfo.cs) |
| `RevocationPluginConfigUpdate` | [RevocationPluginConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/RevocationPluginConfigUpdate.cs) |
| `RevocationRequest` | [RevocationRequest](../../AccelByte.Sdk/Api/Platform/Model/RevocationRequest.cs) |
| `RevocationResult` | [RevocationResult](../../AccelByte.Sdk/Api/Platform/Model/RevocationResult.cs) |
| `RevokeCurrency` | [RevokeCurrency](../../AccelByte.Sdk/Api/Platform/Model/RevokeCurrency.cs) |
| `RevokeEntitlement` | [RevokeEntitlement](../../AccelByte.Sdk/Api/Platform/Model/RevokeEntitlement.cs) |
| `RevokeEntitlementPayload` | [RevokeEntitlementPayload](../../AccelByte.Sdk/Api/Platform/Model/RevokeEntitlementPayload.cs) |
| `RevokeEntry` | [RevokeEntry](../../AccelByte.Sdk/Api/Platform/Model/RevokeEntry.cs) |
| `RevokeFulfillmentV2Result` | [RevokeFulfillmentV2Result](../../AccelByte.Sdk/Api/Platform/Model/RevokeFulfillmentV2Result.cs) |
| `RevokeItem` | [RevokeItem](../../AccelByte.Sdk/Api/Platform/Model/RevokeItem.cs) |
| `RevokeItemSummary` | [RevokeItemSummary](../../AccelByte.Sdk/Api/Platform/Model/RevokeItemSummary.cs) |
| `RevokeResult` | [RevokeResult](../../AccelByte.Sdk/Api/Platform/Model/RevokeResult.cs) |
| `RevokeUseCountRequest` | [RevokeUseCountRequest](../../AccelByte.Sdk/Api/Platform/Model/RevokeUseCountRequest.cs) |
| `RewardCondition` | [RewardCondition](../../AccelByte.Sdk/Api/Platform/Model/RewardCondition.cs) |
| `RewardCreate` | [RewardCreate](../../AccelByte.Sdk/Api/Platform/Model/RewardCreate.cs) |
| `RewardInfo` | [RewardInfo](../../AccelByte.Sdk/Api/Platform/Model/RewardInfo.cs) |
| `RewardItem` | [RewardItem](../../AccelByte.Sdk/Api/Platform/Model/RewardItem.cs) |
| `RewardMigrationResult` | [RewardMigrationResult](../../AccelByte.Sdk/Api/Platform/Model/RewardMigrationResult.cs) |
| `RewardPagingSlicedResult` | [RewardPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/RewardPagingSlicedResult.cs) |
| `RewardUpdate` | [RewardUpdate](../../AccelByte.Sdk/Api/Platform/Model/RewardUpdate.cs) |
| `RewardsRequest` | [RewardsRequest](../../AccelByte.Sdk/Api/Platform/Model/RewardsRequest.cs) |
| `SaleConfig` | [SaleConfig](../../AccelByte.Sdk/Api/Platform/Model/SaleConfig.cs) |
| `SectionCreate` | [SectionCreate](../../AccelByte.Sdk/Api/Platform/Model/SectionCreate.cs) |
| `SectionInfo` | [SectionInfo](../../AccelByte.Sdk/Api/Platform/Model/SectionInfo.cs) |
| `SectionItem` | [SectionItem](../../AccelByte.Sdk/Api/Platform/Model/SectionItem.cs) |
| `SectionPagingSlicedResult` | [SectionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/SectionPagingSlicedResult.cs) |
| `SectionPluginConfigInfo` | [SectionPluginConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/SectionPluginConfigInfo.cs) |
| `SectionPluginConfigUpdate` | [SectionPluginConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/SectionPluginConfigUpdate.cs) |
| `SectionUpdate` | [SectionUpdate](../../AccelByte.Sdk/Api/Platform/Model/SectionUpdate.cs) |
| `ServicePluginConfigInfo` | [ServicePluginConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/ServicePluginConfigInfo.cs) |
| `ServicePluginConfigUpdate` | [ServicePluginConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/ServicePluginConfigUpdate.cs) |
| `SimpleDLCRewardItem` | [SimpleDLCRewardItem](../../AccelByte.Sdk/Api/Platform/Model/SimpleDLCRewardItem.cs) |
| `SimpleEntitlement` | [SimpleEntitlement](../../AccelByte.Sdk/Api/Platform/Model/SimpleEntitlement.cs) |
| `SimpleUserDLC` | [SimpleUserDLC](../../AccelByte.Sdk/Api/Platform/Model/SimpleUserDLC.cs) |
| `SimpleUserDLCRewardContent` | [SimpleUserDLCRewardContent](../../AccelByte.Sdk/Api/Platform/Model/SimpleUserDLCRewardContent.cs) |
| `SimpleUserDLCRewardContentsResponse` | [SimpleUserDLCRewardContentsResponse](../../AccelByte.Sdk/Api/Platform/Model/SimpleUserDLCRewardContentsResponse.cs) |
| `SimpleWallet` | [SimpleWallet](../../AccelByte.Sdk/Api/Platform/Model/SimpleWallet.cs) |
| `Slide` | [Slide](../../AccelByte.Sdk/Api/Platform/Model/Slide.cs) |
| `StackableEntitlementInfo` | [StackableEntitlementInfo](../../AccelByte.Sdk/Api/Platform/Model/StackableEntitlementInfo.cs) |
| `SteamAbnormalTransactionPagingSlicedResult` | [SteamAbnormalTransactionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/SteamAbnormalTransactionPagingSlicedResult.cs) |
| `SteamAchievement` | [SteamAchievement](../../AccelByte.Sdk/Api/Platform/Model/SteamAchievement.cs) |
| `SteamAchievementUpdateRequest` | [SteamAchievementUpdateRequest](../../AccelByte.Sdk/Api/Platform/Model/SteamAchievementUpdateRequest.cs) |
| `SteamDLCSyncRequest` | [SteamDLCSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/SteamDLCSyncRequest.cs) |
| `SteamIAPConfig` | [SteamIAPConfig](../../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfig.cs) |
| `SteamIAPConfigInfo` | [SteamIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfigInfo.cs) |
| `SteamIAPConfigRequest` | [SteamIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfigRequest.cs) |
| `SteamReportInfoPagingSlicedResult` | [SteamReportInfoPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/SteamReportInfoPagingSlicedResult.cs) |
| `SteamReportJobInfo` | [SteamReportJobInfo](../../AccelByte.Sdk/Api/Platform/Model/SteamReportJobInfo.cs) |
| `SteamSyncByTransactionRequest` | [SteamSyncByTransactionRequest](../../AccelByte.Sdk/Api/Platform/Model/SteamSyncByTransactionRequest.cs) |
| `SteamSyncRequest` | [SteamSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/SteamSyncRequest.cs) |
| `StoreBackupInfo` | [StoreBackupInfo](../../AccelByte.Sdk/Api/Platform/Model/StoreBackupInfo.cs) |
| `StoreCreate` | [StoreCreate](../../AccelByte.Sdk/Api/Platform/Model/StoreCreate.cs) |
| `StoreInfo` | [StoreInfo](../../AccelByte.Sdk/Api/Platform/Model/StoreInfo.cs) |
| `StoreUpdate` | [StoreUpdate](../../AccelByte.Sdk/Api/Platform/Model/StoreUpdate.cs) |
| `StreamEvent` | [StreamEvent](../../AccelByte.Sdk/Api/Platform/Model/StreamEvent.cs) |
| `StreamEventBody` | [StreamEventBody](../../AccelByte.Sdk/Api/Platform/Model/StreamEventBody.cs) |
| `StripeConfig` | [StripeConfig](../../AccelByte.Sdk/Api/Platform/Model/StripeConfig.cs) |
| `SubItemAvailablePrice` | [SubItemAvailablePrice](../../AccelByte.Sdk/Api/Platform/Model/SubItemAvailablePrice.cs) |
| `Subscribable` | [Subscribable](../../AccelByte.Sdk/Api/Platform/Model/Subscribable.cs) |
| `SubscribeRequest` | [SubscribeRequest](../../AccelByte.Sdk/Api/Platform/Model/SubscribeRequest.cs) |
| `SubscriptionActivityInfo` | [SubscriptionActivityInfo](../../AccelByte.Sdk/Api/Platform/Model/SubscriptionActivityInfo.cs) |
| `SubscriptionActivityPagingSlicedResult` | [SubscriptionActivityPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/SubscriptionActivityPagingSlicedResult.cs) |
| `SubscriptionInfo` | [SubscriptionInfo](../../AccelByte.Sdk/Api/Platform/Model/SubscriptionInfo.cs) |
| `SubscriptionPagingSlicedResult` | [SubscriptionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/SubscriptionPagingSlicedResult.cs) |
| `SubscriptionSummary` | [SubscriptionSummary](../../AccelByte.Sdk/Api/Platform/Model/SubscriptionSummary.cs) |
| `TLSConfig` | [TLSConfig](../../AccelByte.Sdk/Api/Platform/Model/TLSConfig.cs) |
| `TaxResult` | [TaxResult](../../AccelByte.Sdk/Api/Platform/Model/TaxResult.cs) |
| `TestResult` | [TestResult](../../AccelByte.Sdk/Api/Platform/Model/TestResult.cs) |
| `ThirdPartySubscriptionOwnership` | [ThirdPartySubscriptionOwnership](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartySubscriptionOwnership.cs) |
| `ThirdPartySubscriptionTransactionHistoryInfo` | [ThirdPartySubscriptionTransactionHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartySubscriptionTransactionHistoryInfo.cs) |
| `ThirdPartySubscriptionTransactionHistoryPagingSlicedResult` | [ThirdPartySubscriptionTransactionHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartySubscriptionTransactionHistoryPagingSlicedResult.cs) |
| `ThirdPartySubscriptionTransactionInfo` | [ThirdPartySubscriptionTransactionInfo](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartySubscriptionTransactionInfo.cs) |
| `ThirdPartySubscriptionTransactionPagingSlicedResult` | [ThirdPartySubscriptionTransactionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartySubscriptionTransactionPagingSlicedResult.cs) |
| `ThirdPartyUserSubscriptionInfo` | [ThirdPartyUserSubscriptionInfo](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartyUserSubscriptionInfo.cs) |
| `ThirdPartyUserSubscriptionPagingSlicedResult` | [ThirdPartyUserSubscriptionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/ThirdPartyUserSubscriptionPagingSlicedResult.cs) |
| `TicketAcquireRequest` | [TicketAcquireRequest](../../AccelByte.Sdk/Api/Platform/Model/TicketAcquireRequest.cs) |
| `TicketAcquireResult` | [TicketAcquireResult](../../AccelByte.Sdk/Api/Platform/Model/TicketAcquireResult.cs) |
| `TicketBoothID` | [TicketBoothID](../../AccelByte.Sdk/Api/Platform/Model/TicketBoothID.cs) |
| `TicketDynamicInfo` | [TicketDynamicInfo](../../AccelByte.Sdk/Api/Platform/Model/TicketDynamicInfo.cs) |
| `TicketSaleDecrementRequest` | [TicketSaleDecrementRequest](../../AccelByte.Sdk/Api/Platform/Model/TicketSaleDecrementRequest.cs) |
| `TicketSaleIncrementRequest` | [TicketSaleIncrementRequest](../../AccelByte.Sdk/Api/Platform/Model/TicketSaleIncrementRequest.cs) |
| `TicketSaleIncrementResult` | [TicketSaleIncrementResult](../../AccelByte.Sdk/Api/Platform/Model/TicketSaleIncrementResult.cs) |
| `TimeLimitedBalance` | [TimeLimitedBalance](../../AccelByte.Sdk/Api/Platform/Model/TimeLimitedBalance.cs) |
| `TimedOwnership` | [TimedOwnership](../../AccelByte.Sdk/Api/Platform/Model/TimedOwnership.cs) |
| `TradeActionPagingSlicedResult` | [TradeActionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/TradeActionPagingSlicedResult.cs) |
| `TradeChainActionHistoryInfo` | [TradeChainActionHistoryInfo](../../AccelByte.Sdk/Api/Platform/Model/TradeChainActionHistoryInfo.cs) |
| `TradeChainedActionCommitRequest` | [TradeChainedActionCommitRequest](../../AccelByte.Sdk/Api/Platform/Model/TradeChainedActionCommitRequest.cs) |
| `TradeNotification` | [TradeNotification](../../AccelByte.Sdk/Api/Platform/Model/TradeNotification.cs) |
| `Transaction` | [Transaction](../../AccelByte.Sdk/Api/Platform/Model/Transaction.cs) |
| `TransactionAmountDetails` | [TransactionAmountDetails](../../AccelByte.Sdk/Api/Platform/Model/TransactionAmountDetails.cs) |
| `TwitchIAPConfigInfo` | [TwitchIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/TwitchIAPConfigInfo.cs) |
| `TwitchIAPConfigRequest` | [TwitchIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/TwitchIAPConfigRequest.cs) |
| `TwitchSyncRequest` | [TwitchSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/TwitchSyncRequest.cs) |
| `TwitchSyncResult` | [TwitchSyncResult](../../AccelByte.Sdk/Api/Platform/Model/TwitchSyncResult.cs) |
| `UserDLC` | [UserDLC](../../AccelByte.Sdk/Api/Platform/Model/UserDLC.cs) |
| `UserDLCRecord` | [UserDLCRecord](../../AccelByte.Sdk/Api/Platform/Model/UserDLCRecord.cs) |
| `UserEntitlementHistoryPagingSlicedResult` | [UserEntitlementHistoryPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/UserEntitlementHistoryPagingSlicedResult.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../../AccelByte.Sdk/Api/Platform/Model/ValidationErrorEntity.cs) |
| `ViewCreate` | [ViewCreate](../../AccelByte.Sdk/Api/Platform/Model/ViewCreate.cs) |
| `ViewInfo` | [ViewInfo](../../AccelByte.Sdk/Api/Platform/Model/ViewInfo.cs) |
| `ViewUpdate` | [ViewUpdate](../../AccelByte.Sdk/Api/Platform/Model/ViewUpdate.cs) |
| `WalletConfigInfo` | [WalletConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/WalletConfigInfo.cs) |
| `WalletConfigUpdate` | [WalletConfigUpdate](../../AccelByte.Sdk/Api/Platform/Model/WalletConfigUpdate.cs) |
| `WalletInfo` | [WalletInfo](../../AccelByte.Sdk/Api/Platform/Model/WalletInfo.cs) |
| `WalletPagingSlicedResult` | [WalletPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/WalletPagingSlicedResult.cs) |
| `WalletRevocationConfig` | [WalletRevocationConfig](../../AccelByte.Sdk/Api/Platform/Model/WalletRevocationConfig.cs) |
| `WalletTransactionInfo` | [WalletTransactionInfo](../../AccelByte.Sdk/Api/Platform/Model/WalletTransactionInfo.cs) |
| `WalletTransactionPagingSlicedResult` | [WalletTransactionPagingSlicedResult](../../AccelByte.Sdk/Api/Platform/Model/WalletTransactionPagingSlicedResult.cs) |
| `WxPayConfigInfo` | [WxPayConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/WxPayConfigInfo.cs) |
| `WxPayConfigRequest` | [WxPayConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/WxPayConfigRequest.cs) |
| `XblAchievementUpdateRequest` | [XblAchievementUpdateRequest](../../AccelByte.Sdk/Api/Platform/Model/XblAchievementUpdateRequest.cs) |
| `XblClawbackContractV2` | [XblClawbackContractV2](../../AccelByte.Sdk/Api/Platform/Model/XblClawbackContractV2.cs) |
| `XblClawbackEvent` | [XblClawbackEvent](../../AccelByte.Sdk/Api/Platform/Model/XblClawbackEvent.cs) |
| `XblClawbackEventSubscriptionData` | [XblClawbackEventSubscriptionData](../../AccelByte.Sdk/Api/Platform/Model/XblClawbackEventSubscriptionData.cs) |
| `XblDLCSyncRequest` | [XblDLCSyncRequest](../../AccelByte.Sdk/Api/Platform/Model/XblDLCSyncRequest.cs) |
| `XblEntitlementOwnershipRequest` | [XblEntitlementOwnershipRequest](../../AccelByte.Sdk/Api/Platform/Model/XblEntitlementOwnershipRequest.cs) |
| `XblIAPConfigInfo` | [XblIAPConfigInfo](../../AccelByte.Sdk/Api/Platform/Model/XblIAPConfigInfo.cs) |
| `XblIAPConfigRequest` | [XblIAPConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/XblIAPConfigRequest.cs) |
| `XblReconcileRequest` | [XblReconcileRequest](../../AccelByte.Sdk/Api/Platform/Model/XblReconcileRequest.cs) |
| `XblReconcileResult` | [XblReconcileResult](../../AccelByte.Sdk/Api/Platform/Model/XblReconcileResult.cs) |
| `XblUserAchievements` | [XblUserAchievements](../../AccelByte.Sdk/Api/Platform/Model/XblUserAchievements.cs) |
| `XblUserSessionRequest` | [XblUserSessionRequest](../../AccelByte.Sdk/Api/Platform/Model/XblUserSessionRequest.cs) |
| `XboxAchievement` | [XboxAchievement](../../AccelByte.Sdk/Api/Platform/Model/XboxAchievement.cs) |
| `XsollaConfig` | [XsollaConfig](../../AccelByte.Sdk/Api/Platform/Model/XsollaConfig.cs) |
| `XsollaPaywallConfig` | [XsollaPaywallConfig](../../AccelByte.Sdk/Api/Platform/Model/XsollaPaywallConfig.cs) |
| `XsollaPaywallConfigRequest` | [XsollaPaywallConfigRequest](../../AccelByte.Sdk/Api/Platform/Model/XsollaPaywallConfigRequest.cs) |
