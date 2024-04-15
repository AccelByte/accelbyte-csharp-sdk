# Inventory Service Index

&nbsp;  

## Operations

### Admin Chaining Operations Wrapper:  [AdminChainingOperations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminChainingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/chainingOperations` | POST | AdminCreateChainingOperations | [AdminCreateChainingOperations](../../AccelByte.Sdk/Api/Inventory/Operation/AdminChainingOperations/AdminCreateChainingOperations.cs) | [AdminCreateChainingOperations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminChainingOperations/AdminCreateChainingOperations.cs) |

### Admin Integration Configurations Wrapper:  [AdminIntegrationConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminIntegrationConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations` | GET | AdminListIntegrationConfigurations | [AdminListIntegrationConfigurations](../../AccelByte.Sdk/Api/Inventory/Operation/AdminIntegrationConfigurations/AdminListIntegrationConfigurations.cs) | [AdminListIntegrationConfigurations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminIntegrationConfigurations/AdminListIntegrationConfigurations.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations` | POST | AdminCreateIntegrationConfiguration | [AdminCreateIntegrationConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminIntegrationConfigurations/AdminCreateIntegrationConfiguration.cs) | [AdminCreateIntegrationConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminIntegrationConfigurations/AdminCreateIntegrationConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations/{integrationConfigurationId}` | PUT | AdminUpdateIntegrationConfiguration | [AdminUpdateIntegrationConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminIntegrationConfigurations/AdminUpdateIntegrationConfiguration.cs) | [AdminUpdateIntegrationConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminIntegrationConfigurations/AdminUpdateIntegrationConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/integrationConfigurations/{integrationConfigurationId}/status` | PUT | AdminUpdateStatusIntegrationConfiguration | [AdminUpdateStatusIntegrationConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminIntegrationConfigurations/AdminUpdateStatusIntegrationConfiguration.cs) | [AdminUpdateStatusIntegrationConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminIntegrationConfigurations/AdminUpdateStatusIntegrationConfiguration.cs) |

### Admin Inventories Wrapper:  [AdminInventories](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventories` | GET | AdminListInventories | [AdminListInventories](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/AdminListInventories.cs) | [AdminListInventories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminListInventories.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories` | POST | AdminCreateInventory | [AdminCreateInventory](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/AdminCreateInventory.cs) | [AdminCreateInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminCreateInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | GET | AdminGetInventory | [AdminGetInventory](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/AdminGetInventory.cs) | [AdminGetInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminGetInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | PUT | AdminUpdateInventory | [AdminUpdateInventory](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/AdminUpdateInventory.cs) | [AdminUpdateInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminUpdateInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}` | DELETE | DeleteInventory | [DeleteInventory](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/DeleteInventory.cs) | [DeleteInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/DeleteInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/purchaseable` | POST | AdminPurchasable | [AdminPurchasable](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventories/AdminPurchasable.cs) | [AdminPurchasable](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventories/AdminPurchasable.cs) |

### Admin Items Wrapper:  [AdminItems](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}/items` | GET | AdminListItems | [AdminListItems](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminListItems.cs) | [AdminListItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminListItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventories/{inventoryId}/slots/{slotId}/sourceItems/{sourceItemId}` | GET | AdminGetInventoryItem | [AdminGetInventoryItem](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminGetInventoryItem.cs) | [AdminGetInventoryItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminGetInventoryItem.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/consume` | POST | AdminConsumeUserItem | [AdminConsumeUserItem](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminConsumeUserItem.cs) | [AdminConsumeUserItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminConsumeUserItem.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | PUT | AdminBulkUpdateMyItems | [AdminBulkUpdateMyItems](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminBulkUpdateMyItems.cs) | [AdminBulkUpdateMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminBulkUpdateMyItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | POST | AdminSaveItemToInventory | [AdminSaveItemToInventory](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminSaveItemToInventory.cs) | [AdminSaveItemToInventory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminSaveItemToInventory.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/inventories/{inventoryId}/items` | DELETE | AdminBulkRemoveItems | [AdminBulkRemoveItems](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminBulkRemoveItems.cs) | [AdminBulkRemoveItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminBulkRemoveItems.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items` | POST | AdminSaveItem | [AdminSaveItem](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminSaveItem.cs) | [AdminSaveItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminSaveItem.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/users/{userId}/items/entitlements/sync` | PUT | AdminSyncUserEntitlements | [AdminSyncUserEntitlements](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItems/AdminSyncUserEntitlements.cs) | [AdminSyncUserEntitlements](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItems/AdminSyncUserEntitlements.cs) |

### Admin Inventory Configurations Wrapper:  [AdminInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations` | GET | AdminListInventoryConfigurations | [AdminListInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventoryConfigurations/AdminListInventoryConfigurations.cs) | [AdminListInventoryConfigurations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminListInventoryConfigurations.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations` | POST | AdminCreateInventoryConfiguration | [AdminCreateInventoryConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventoryConfigurations/AdminCreateInventoryConfiguration.cs) | [AdminCreateInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminCreateInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | GET | AdminGetInventoryConfiguration | [AdminGetInventoryConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventoryConfigurations/AdminGetInventoryConfiguration.cs) | [AdminGetInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminGetInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | PUT | AdminUpdateInventoryConfiguration | [AdminUpdateInventoryConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventoryConfigurations/AdminUpdateInventoryConfiguration.cs) | [AdminUpdateInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminUpdateInventoryConfiguration.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/inventoryConfigurations/{inventoryConfigurationId}` | DELETE | AdminDeleteInventoryConfiguration | [AdminDeleteInventoryConfiguration](../../AccelByte.Sdk/Api/Inventory/Operation/AdminInventoryConfigurations/AdminDeleteInventoryConfiguration.cs) | [AdminDeleteInventoryConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminInventoryConfigurations/AdminDeleteInventoryConfiguration.cs) |

### Admin Item Types Wrapper:  [AdminItemTypes](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes` | GET | AdminListItemTypes | [AdminListItemTypes](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItemTypes/AdminListItemTypes.cs) | [AdminListItemTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminListItemTypes.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes` | POST | AdminCreateItemType | [AdminCreateItemType](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItemTypes/AdminCreateItemType.cs) | [AdminCreateItemType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminCreateItemType.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/itemtypes/{itemTypeName}` | DELETE | AdminDeleteItemType | [AdminDeleteItemType](../../AccelByte.Sdk/Api/Inventory/Operation/AdminItemTypes/AdminDeleteItemType.cs) | [AdminDeleteItemType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminItemTypes/AdminDeleteItemType.cs) |

### Admin Tags Wrapper:  [AdminTags](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/admin/namespaces/{namespace}/tags` | GET | AdminListTags | [AdminListTags](../../AccelByte.Sdk/Api/Inventory/Operation/AdminTags/AdminListTags.cs) | [AdminListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminListTags.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/tags` | POST | AdminCreateTag | [AdminCreateTag](../../AccelByte.Sdk/Api/Inventory/Operation/AdminTags/AdminCreateTag.cs) | [AdminCreateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminCreateTag.cs) |
| `/inventory/v1/admin/namespaces/{namespace}/tags/{tagName}` | DELETE | AdminDeleteTag | [AdminDeleteTag](../../AccelByte.Sdk/Api/Inventory/Operation/AdminTags/AdminDeleteTag.cs) | [AdminDeleteTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/AdminTags/AdminDeleteTag.cs) |

### Public Inventory Configurations Wrapper:  [PublicInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/inventoryConfigurations` | GET | PublicListInventoryConfigurations | [PublicListInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Operation/PublicInventoryConfigurations/PublicListInventoryConfigurations.cs) | [PublicListInventoryConfigurations](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicInventoryConfigurations/PublicListInventoryConfigurations.cs) |

### Public Item Types Wrapper:  [PublicItemTypes](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/itemtypes` | GET | PublicListItemTypes | [PublicListItemTypes](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItemTypes/PublicListItemTypes.cs) | [PublicListItemTypes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItemTypes/PublicListItemTypes.cs) |

### Public Tags Wrapper:  [PublicTags](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/tags` | GET | PublicListTags | [PublicListTags](../../AccelByte.Sdk/Api/Inventory/Operation/PublicTags/PublicListTags.cs) | [PublicListTags](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicTags/PublicListTags.cs) |

### Public Inventories Wrapper:  [PublicInventories](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories` | GET | PublicListInventories | [PublicListInventories](../../AccelByte.Sdk/Api/Inventory/Operation/PublicInventories/PublicListInventories.cs) | [PublicListInventories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicInventories/PublicListInventories.cs) |

### Public Items Wrapper:  [PublicItems](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/consume` | POST | PublicConsumeMyItem | [PublicConsumeMyItem](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicConsumeMyItem.cs) | [PublicConsumeMyItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicConsumeMyItem.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | GET | PublicListItems | [PublicListItems](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicListItems.cs) | [PublicListItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicListItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | PUT | PublicBulkUpdateMyItems | [PublicBulkUpdateMyItems](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicBulkUpdateMyItems.cs) | [PublicBulkUpdateMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicBulkUpdateMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items` | DELETE | PublicBulkRemoveMyItems | [PublicBulkRemoveMyItems](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicBulkRemoveMyItems.cs) | [PublicBulkRemoveMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicBulkRemoveMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/items/movement` | POST | PublicMoveMyItems | [PublicMoveMyItems](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicMoveMyItems.cs) | [PublicMoveMyItems](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicMoveMyItems.cs) |
| `/inventory/v1/public/namespaces/{namespace}/users/me/inventories/{inventoryId}/slots/{slotId}/sourceItems/{sourceItemId}` | GET | PublicGetItem | [PublicGetItem](../../AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicGetItem.cs) | [PublicGetItem](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Inventory/PublicItems/PublicGetItem.cs) |


&nbsp;  

## Operations with Generic Response

### Admin Chaining Operations Wrapper:  [AdminChainingOperations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminChainingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Integration Configurations Wrapper:  [AdminIntegrationConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminIntegrationConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Inventories Wrapper:  [AdminInventories](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Items Wrapper:  [AdminItems](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Inventory Configurations Wrapper:  [AdminInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Item Types Wrapper:  [AdminItemTypes](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Tags Wrapper:  [AdminTags](../../AccelByte.Sdk/Api/Inventory/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Inventory Configurations Wrapper:  [PublicInventoryConfigurations](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicInventoryConfigurations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Item Types Wrapper:  [PublicItemTypes](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicItemTypes.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Tags Wrapper:  [PublicTags](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Inventories Wrapper:  [PublicInventories](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicInventories.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Items Wrapper:  [PublicItems](../../AccelByte.Sdk/Api/Inventory/Wrapper/PublicItems.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodels.AdminUpdateItemReq` | [ApimodelsAdminUpdateItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsAdminUpdateItemReq.cs) |
| `apimodels.ChainingOperationReq` | [ApimodelsChainingOperationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsChainingOperationReq.cs) |
| `apimodels.ChainingOperationResp` | [ApimodelsChainingOperationResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsChainingOperationResp.cs) |
| `apimodels.ConsumeItem` | [ApimodelsConsumeItem](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsConsumeItem.cs) |
| `apimodels.ConsumeItemReq` | [ApimodelsConsumeItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsConsumeItemReq.cs) |
| `apimodels.CreateIntegrationConfigurationReq` | [ApimodelsCreateIntegrationConfigurationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateIntegrationConfigurationReq.cs) |
| `apimodels.CreateInventoryConfigurationReq` | [ApimodelsCreateInventoryConfigurationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateInventoryConfigurationReq.cs) |
| `apimodels.CreateInventoryReq` | [ApimodelsCreateInventoryReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateInventoryReq.cs) |
| `apimodels.CreateItem` | [ApimodelsCreateItem](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateItem.cs) |
| `apimodels.CreateItemTypeReq` | [ApimodelsCreateItemTypeReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateItemTypeReq.cs) |
| `apimodels.CreateItemTypeResp` | [ApimodelsCreateItemTypeResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateItemTypeResp.cs) |
| `apimodels.CreateTagReq` | [ApimodelsCreateTagReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateTagReq.cs) |
| `apimodels.CreateTagResp` | [ApimodelsCreateTagResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsCreateTagResp.cs) |
| `apimodels.DeleteInventoryReq` | [ApimodelsDeleteInventoryReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsDeleteInventoryReq.cs) |
| `apimodels.ErrorResponse` | [ApimodelsErrorResponse](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsErrorResponse.cs) |
| `apimodels.IntegrationConfigurationResp` | [ApimodelsIntegrationConfigurationResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsIntegrationConfigurationResp.cs) |
| `apimodels.InventoryConfig` | [ApimodelsInventoryConfig](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsInventoryConfig.cs) |
| `apimodels.InventoryConfigurationReq` | [ApimodelsInventoryConfigurationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsInventoryConfigurationReq.cs) |
| `apimodels.InventoryConfigurationResp` | [ApimodelsInventoryConfigurationResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsInventoryConfigurationResp.cs) |
| `apimodels.InventoryResp` | [ApimodelsInventoryResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsInventoryResp.cs) |
| `apimodels.ItemResp` | [ApimodelsItemResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsItemResp.cs) |
| `apimodels.ListIntegrationConfigurationsResp` | [ApimodelsListIntegrationConfigurationsResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListIntegrationConfigurationsResp.cs) |
| `apimodels.ListInventoryConfigurationsResp` | [ApimodelsListInventoryConfigurationsResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListInventoryConfigurationsResp.cs) |
| `apimodels.ListInventoryResp` | [ApimodelsListInventoryResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListInventoryResp.cs) |
| `apimodels.ListItemResp` | [ApimodelsListItemResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListItemResp.cs) |
| `apimodels.ListItemTypesResp` | [ApimodelsListItemTypesResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListItemTypesResp.cs) |
| `apimodels.ListTagsResp` | [ApimodelsListTagsResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsListTagsResp.cs) |
| `apimodels.MoveItemsReq` | [ApimodelsMoveItemsReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsMoveItemsReq.cs) |
| `apimodels.MoveItemsResp` | [ApimodelsMoveItemsResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsMoveItemsResp.cs) |
| `apimodels.Operation` | [ApimodelsOperation](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsOperation.cs) |
| `apimodels.Paging` | [ApimodelsPaging](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsPaging.cs) |
| `apimodels.PurchaseValidationItemReq` | [ApimodelsPurchaseValidationItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsPurchaseValidationItemReq.cs) |
| `apimodels.PurchaseValidationReq` | [ApimodelsPurchaseValidationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsPurchaseValidationReq.cs) |
| `apimodels.RemoveInventoryItemReq` | [ApimodelsRemoveInventoryItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsRemoveInventoryItemReq.cs) |
| `apimodels.RemoveItem` | [ApimodelsRemoveItem](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsRemoveItem.cs) |
| `apimodels.SaveItemReq` | [ApimodelsSaveItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsSaveItemReq.cs) |
| `apimodels.SaveItemToInventoryReq` | [ApimodelsSaveItemToInventoryReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsSaveItemToInventoryReq.cs) |
| `apimodels.TradeItem` | [ApimodelsTradeItem](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsTradeItem.cs) |
| `apimodels.TradeItemResp` | [ApimodelsTradeItemResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsTradeItemResp.cs) |
| `apimodels.UpdateIntegrationConfigurationReq` | [ApimodelsUpdateIntegrationConfigurationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateIntegrationConfigurationReq.cs) |
| `apimodels.UpdateInventoryReq` | [ApimodelsUpdateInventoryReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateInventoryReq.cs) |
| `apimodels.UpdateItem` | [ApimodelsUpdateItem](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateItem.cs) |
| `apimodels.UpdateItemReq` | [ApimodelsUpdateItemReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateItemReq.cs) |
| `apimodels.UpdateItemResp` | [ApimodelsUpdateItemResp](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateItemResp.cs) |
| `apimodels.UpdateStatusIntegrationConfigurationReq` | [ApimodelsUpdateStatusIntegrationConfigurationReq](../../AccelByte.Sdk/Api/Inventory/Model/ApimodelsUpdateStatusIntegrationConfigurationReq.cs) |
