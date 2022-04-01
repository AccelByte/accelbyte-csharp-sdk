# Social Service Index

&nbsp;  

## Operations

### SlotConfig Wrapper:  [SlotConfig](../AccelByte.Sdk/Api/Social/Wrapper/SlotConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/admin/namespaces/{namespace}/config | GET | GetNamespaceSlotConfig | [GetNamespaceSlotConfig](../AccelByte.Sdk/Api/Social/Operation//GetNamespaceSlotConfig.cs) |
| /social/admin/namespaces/{namespace}/config | PUT | UpdateNamespaceSlotConfig | [UpdateNamespaceSlotConfig](../AccelByte.Sdk/Api/Social/Operation//UpdateNamespaceSlotConfig.cs) |
| /social/admin/namespaces/{namespace}/config | DELETE | DeleteNamespaceSlotConfig | [DeleteNamespaceSlotConfig](../AccelByte.Sdk/Api/Social/Operation//DeleteNamespaceSlotConfig.cs) |
| /social/admin/namespaces/{namespace}/users/{userId}/config | GET | GetUserSlotConfig | [GetUserSlotConfig](../AccelByte.Sdk/Api/Social/Operation//GetUserSlotConfig.cs) |
| /social/admin/namespaces/{namespace}/users/{userId}/config | PUT | UpdateUserSlotConfig | [UpdateUserSlotConfig](../AccelByte.Sdk/Api/Social/Operation//UpdateUserSlotConfig.cs) |
| /social/admin/namespaces/{namespace}/users/{userId}/config | DELETE | DeleteUserSlotConfig | [DeleteUserSlotConfig](../AccelByte.Sdk/Api/Social/Operation//DeleteUserSlotConfig.cs) |

### GameProfile Wrapper:  [GameProfile](../AccelByte.Sdk/Api/Social/Wrapper/GameProfile.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/admin/namespaces/{namespace}/users/{userId}/profiles | GET | GetUserProfiles | [GetUserProfiles](../AccelByte.Sdk/Api/Social/Operation//GetUserProfiles.cs) |
| /social/admin/namespaces/{namespace}/users/{userId}/profiles/{profileId} | GET | GetProfile | [GetProfile](../AccelByte.Sdk/Api/Social/Operation//GetProfile.cs) |
| /social/public/namespaces/{namespace}/profiles | GET | PublicGetUserGameProfiles | [PublicGetUserGameProfiles](../AccelByte.Sdk/Api/Social/Operation//PublicGetUserGameProfiles.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles | GET | PublicGetUserProfiles | [PublicGetUserProfiles](../AccelByte.Sdk/Api/Social/Operation//PublicGetUserProfiles.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles | POST | PublicCreateProfile | [PublicCreateProfile](../AccelByte.Sdk/Api/Social/Operation//PublicCreateProfile.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId} | GET | PublicGetProfile | [PublicGetProfile](../AccelByte.Sdk/Api/Social/Operation//PublicGetProfile.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId} | PUT | PublicUpdateProfile | [PublicUpdateProfile](../AccelByte.Sdk/Api/Social/Operation//PublicUpdateProfile.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId} | DELETE | PublicDeleteProfile | [PublicDeleteProfile](../AccelByte.Sdk/Api/Social/Operation//PublicDeleteProfile.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName} | GET | PublicGetProfileAttribute | [PublicGetProfileAttribute](../AccelByte.Sdk/Api/Social/Operation//PublicGetProfileAttribute.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName} | PUT | PublicUpdateAttribute | [PublicUpdateAttribute](../AccelByte.Sdk/Api/Social/Operation//PublicUpdateAttribute.cs) |

### Slot Wrapper:  [Slot](../AccelByte.Sdk/Api/Social/Wrapper/Slot.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/admin/namespaces/{namespace}/users/{userId}/slots | GET | GetUserNamespaceSlots | [GetUserNamespaceSlots](../AccelByte.Sdk/Api/Social/Operation//GetUserNamespaceSlots.cs) |
| /social/admin/namespaces/{namespace}/users/{userId}/slots/{slotId} | GET | GetSlotData | [GetSlotData](../AccelByte.Sdk/Api/Social/Operation//GetSlotData.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots | GET | PublicGetUserNamespaceSlots | [PublicGetUserNamespaceSlots](../AccelByte.Sdk/Api/Social/Operation//PublicGetUserNamespaceSlots.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots | POST | PublicCreateUserNamespaceSlot | [PublicCreateUserNamespaceSlot](../AccelByte.Sdk/Api/Social/Operation//PublicCreateUserNamespaceSlot.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots/{slotId} | GET | PublicGetSlotData | [PublicGetSlotData](../AccelByte.Sdk/Api/Social/Operation//PublicGetSlotData.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots/{slotId} | PUT | PublicUpdateUserNamespaceSlot | [PublicUpdateUserNamespaceSlot](../AccelByte.Sdk/Api/Social/Operation//PublicUpdateUserNamespaceSlot.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots/{slotId} | DELETE | PublicDeleteUserNamespaceSlot | [PublicDeleteUserNamespaceSlot](../AccelByte.Sdk/Api/Social/Operation//PublicDeleteUserNamespaceSlot.cs) |
| /social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}/metadata | PUT | PublicUpdateUserNamespaceSlotMetadata | [PublicUpdateUserNamespaceSlotMetadata](../AccelByte.Sdk/Api/Social/Operation//PublicUpdateUserNamespaceSlotMetadata.cs) |

### GlobalStatistic Wrapper:  [GlobalStatistic](../AccelByte.Sdk/Api/Social/Wrapper/GlobalStatistic.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/v1/admin/namespaces/{namespace}/globalstatitems | GET | GetGlobalStatItems | [GetGlobalStatItems](../AccelByte.Sdk/Api/Social/Operation//GetGlobalStatItems.cs) |

### UserStatistic Wrapper:  [UserStatistic](../AccelByte.Sdk/Api/Social/Wrapper/UserStatistic.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/v1/admin/namespaces/{namespace}/statitems/bulk | GET | BulkFetchStatItems | [BulkFetchStatItems](../AccelByte.Sdk/Api/Social/Operation//BulkFetchStatItems.cs) |
| /social/v1/admin/namespaces/{namespace}/statitems/value/bulk | PUT | BulkIncUserStatItem | [BulkIncUserStatItem](../AccelByte.Sdk/Api/Social/Operation//BulkIncUserStatItem.cs) |
| /social/v1/admin/namespaces/{namespace}/statitems/value/bulk | PATCH | BulkIncUserStatItemValue | [BulkIncUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//BulkIncUserStatItemValue.cs) |
| /social/v1/admin/namespaces/{namespace}/statitems/value/reset/bulk | PUT | BulkResetUserStatItem | [BulkResetUserStatItem](../AccelByte.Sdk/Api/Social/Operation//BulkResetUserStatItem.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems | GET | GetUserStatItems | [GetUserStatItems](../AccelByte.Sdk/Api/Social/Operation//GetUserStatItems.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/bulk | POST | BulkCreateUserStatItems | [BulkCreateUserStatItems](../AccelByte.Sdk/Api/Social/Operation//BulkCreateUserStatItems.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PUT | BulkIncUserStatItem1 | [BulkIncUserStatItem1](../AccelByte.Sdk/Api/Social/Operation//BulkIncUserStatItem1.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PATCH | BulkIncUserStatItemValue1 | [BulkIncUserStatItemValue1](../AccelByte.Sdk/Api/Social/Operation//BulkIncUserStatItemValue1.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk | PUT | BulkResetUserStatItem1 | [BulkResetUserStatItem1](../AccelByte.Sdk/Api/Social/Operation//BulkResetUserStatItem1.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems | POST | CreateUserStatItem | [CreateUserStatItem](../AccelByte.Sdk/Api/Social/Operation//CreateUserStatItem.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems | DELETE | DeleteUserStatItems | [DeleteUserStatItems](../AccelByte.Sdk/Api/Social/Operation//DeleteUserStatItems.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value | PATCH | IncUserStatItemValue | [IncUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//IncUserStatItemValue.cs) |
| /social/v1/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset | PUT | ResetUserStatItemValue | [ResetUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//ResetUserStatItemValue.cs) |
| /social/v1/public/namespaces/{namespace}/statitems/bulk | GET | BulkFetchStatItems1 | [BulkFetchStatItems1](../AccelByte.Sdk/Api/Social/Operation//BulkFetchStatItems1.cs) |
| /social/v1/public/namespaces/{namespace}/statitems/value/bulk | PUT | PublicBulkIncUserStatItem | [PublicBulkIncUserStatItem](../AccelByte.Sdk/Api/Social/Operation//PublicBulkIncUserStatItem.cs) |
| /social/v1/public/namespaces/{namespace}/statitems/value/bulk | PATCH | PublicBulkIncUserStatItemValue | [PublicBulkIncUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//PublicBulkIncUserStatItemValue.cs) |
| /social/v1/public/namespaces/{namespace}/statitems/value/reset/bulk | PUT | BulkResetUserStatItem2 | [BulkResetUserStatItem2](../AccelByte.Sdk/Api/Social/Operation//BulkResetUserStatItem2.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/statitems | GET | PublicQueryUserStatItems | [PublicQueryUserStatItems](../AccelByte.Sdk/Api/Social/Operation//PublicQueryUserStatItems.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/statitems/bulk | POST | PublicBulkCreateUserStatItems | [PublicBulkCreateUserStatItems](../AccelByte.Sdk/Api/Social/Operation//PublicBulkCreateUserStatItems.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PUT | PublicBulkIncUserStatItem1 | [PublicBulkIncUserStatItem1](../AccelByte.Sdk/Api/Social/Operation//PublicBulkIncUserStatItem1.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PATCH | BulkIncUserStatItemValue2 | [BulkIncUserStatItemValue2](../AccelByte.Sdk/Api/Social/Operation//BulkIncUserStatItemValue2.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk | PUT | BulkResetUserStatItem3 | [BulkResetUserStatItem3](../AccelByte.Sdk/Api/Social/Operation//BulkResetUserStatItem3.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems | POST | PublicCreateUserStatItem | [PublicCreateUserStatItem](../AccelByte.Sdk/Api/Social/Operation//PublicCreateUserStatItem.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems | DELETE | DeleteUserStatItems1 | [DeleteUserStatItems1](../AccelByte.Sdk/Api/Social/Operation//DeleteUserStatItems1.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value | PUT | PublicIncUserStatItem | [PublicIncUserStatItem](../AccelByte.Sdk/Api/Social/Operation//PublicIncUserStatItem.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value | PATCH | PublicIncUserStatItemValue | [PublicIncUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//PublicIncUserStatItemValue.cs) |
| /social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value/reset | PUT | ResetUserStatItemValue1 | [ResetUserStatItemValue1](../AccelByte.Sdk/Api/Social/Operation//ResetUserStatItemValue1.cs) |
| /social/v2/admin/namespaces/{namespace}/statitems/value/bulk | PUT | BulkUpdateUserStatItemV2 | [BulkUpdateUserStatItemV2](../AccelByte.Sdk/Api/Social/Operation//BulkUpdateUserStatItemV2.cs) |
| /social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PUT | BulkUpdateUserStatItem | [BulkUpdateUserStatItem](../AccelByte.Sdk/Api/Social/Operation//BulkUpdateUserStatItem.cs) |
| /social/v2/admin/namespaces/{namespace}/users/{userId}/statitems/value/reset/bulk | PUT | BulkResetUserStatItemValues | [BulkResetUserStatItemValues](../AccelByte.Sdk/Api/Social/Operation//BulkResetUserStatItemValues.cs) |
| /social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems | DELETE | DeleteUserStatItems2 | [DeleteUserStatItems2](../AccelByte.Sdk/Api/Social/Operation//DeleteUserStatItems2.cs) |
| /social/v2/admin/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value | PUT | UpdateUserStatItemValue | [UpdateUserStatItemValue](../AccelByte.Sdk/Api/Social/Operation//UpdateUserStatItemValue.cs) |
| /social/v2/public/namespaces/{namespace}/statitems/value/bulk | PUT | BulkUpdateUserStatItem1 | [BulkUpdateUserStatItem1](../AccelByte.Sdk/Api/Social/Operation//BulkUpdateUserStatItem1.cs) |
| /social/v2/public/namespaces/{namespace}/users/{userId}/statitems/value/bulk | PUT | BulkUpdateUserStatItem2 | [BulkUpdateUserStatItem2](../AccelByte.Sdk/Api/Social/Operation//BulkUpdateUserStatItem2.cs) |
| /social/v2/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems/value | PUT | UpdateUserStatItemValue1 | [UpdateUserStatItemValue1](../AccelByte.Sdk/Api/Social/Operation//UpdateUserStatItemValue1.cs) |

### StatConfiguration Wrapper:  [StatConfiguration](../AccelByte.Sdk/Api/Social/Wrapper/StatConfiguration.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /social/v1/admin/namespaces/{namespace}/stats | GET | GetStats | [GetStats](../AccelByte.Sdk/Api/Social/Operation//GetStats.cs) |
| /social/v1/admin/namespaces/{namespace}/stats | POST | CreateStat | [CreateStat](../AccelByte.Sdk/Api/Social/Operation//CreateStat.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/export | GET | ExportStats | [ExportStats](../AccelByte.Sdk/Api/Social/Operation//ExportStats.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/import | POST | ImportStats | [ImportStats](../AccelByte.Sdk/Api/Social/Operation//ImportStats.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/search | GET | QueryStats | [QueryStats](../AccelByte.Sdk/Api/Social/Operation//QueryStats.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/{statCode} | GET | GetStat | [GetStat](../AccelByte.Sdk/Api/Social/Operation//GetStat.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/{statCode} | DELETE | DeleteStat | [DeleteStat](../AccelByte.Sdk/Api/Social/Operation//DeleteStat.cs) |
| /social/v1/admin/namespaces/{namespace}/stats/{statCode} | PATCH | UpdateStat | [UpdateStat](../AccelByte.Sdk/Api/Social/Operation//UpdateStat.cs) |
| /social/v1/public/namespaces/{namespace}/stats | POST | CreateStat1 | [CreateStat1](../AccelByte.Sdk/Api/Social/Operation//CreateStat1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| A DTO object for resetting user stat items | [ADTOObjectForResettingUserStatItems](../AccelByte.Sdk/Api/Social/Model/ADTOObjectForResettingUserStatItems.cs) |
| Attribute | [Attribute](../AccelByte.Sdk/Api/Social/Model/Attribute.cs) |
| BulkStatItemCreate | [BulkStatItemCreate](../AccelByte.Sdk/Api/Social/Model/BulkStatItemCreate.cs) |
| BulkStatItemInc | [BulkStatItemInc](../AccelByte.Sdk/Api/Social/Model/BulkStatItemInc.cs) |
| BulkStatItemOperationResult | [BulkStatItemOperationResult](../AccelByte.Sdk/Api/Social/Model/BulkStatItemOperationResult.cs) |
| BulkStatItemReset | [BulkStatItemReset](../AccelByte.Sdk/Api/Social/Model/BulkStatItemReset.cs) |
| BulkStatItemUpdate | [BulkStatItemUpdate](../AccelByte.Sdk/Api/Social/Model/BulkStatItemUpdate.cs) |
| BulkUserStatItemInc | [BulkUserStatItemInc](../AccelByte.Sdk/Api/Social/Model/BulkUserStatItemInc.cs) |
| BulkUserStatItemReset | [BulkUserStatItemReset](../AccelByte.Sdk/Api/Social/Model/BulkUserStatItemReset.cs) |
| BulkUserStatItemUpdate | [BulkUserStatItemUpdate](../AccelByte.Sdk/Api/Social/Model/BulkUserStatItemUpdate.cs) |
| ErrorEntity | [ErrorEntity](../AccelByte.Sdk/Api/Social/Model/ErrorEntity.cs) |
| FieldValidationError | [FieldValidationError](../AccelByte.Sdk/Api/Social/Model/FieldValidationError.cs) |
| GameProfileHeader | [GameProfileHeader](../AccelByte.Sdk/Api/Social/Model/GameProfileHeader.cs) |
| GameProfileInfo | [GameProfileInfo](../AccelByte.Sdk/Api/Social/Model/GameProfileInfo.cs) |
| GameProfilePublicInfo | [GameProfilePublicInfo](../AccelByte.Sdk/Api/Social/Model/GameProfilePublicInfo.cs) |
| GameProfileRequest | [GameProfileRequest](../AccelByte.Sdk/Api/Social/Model/GameProfileRequest.cs) |
| GlobalStatItemInfo | [GlobalStatItemInfo](../AccelByte.Sdk/Api/Social/Model/GlobalStatItemInfo.cs) |
| GlobalStatItemPagingSlicedResult | [GlobalStatItemPagingSlicedResult](../AccelByte.Sdk/Api/Social/Model/GlobalStatItemPagingSlicedResult.cs) |
| NamespaceSlotConfigInfo | [NamespaceSlotConfigInfo](../AccelByte.Sdk/Api/Social/Model/NamespaceSlotConfigInfo.cs) |
| Paging | [Paging](../AccelByte.Sdk/Api/Social/Model/Paging.cs) |
| SlotConfigUpdate | [SlotConfigUpdate](../AccelByte.Sdk/Api/Social/Model/SlotConfigUpdate.cs) |
| SlotInfo | [SlotInfo](../AccelByte.Sdk/Api/Social/Model/SlotInfo.cs) |
| SlotMetadataUpdate | [SlotMetadataUpdate](../AccelByte.Sdk/Api/Social/Model/SlotMetadataUpdate.cs) |
| StatCreate | [StatCreate](../AccelByte.Sdk/Api/Social/Model/StatCreate.cs) |
| StatImportInfo | [StatImportInfo](../AccelByte.Sdk/Api/Social/Model/StatImportInfo.cs) |
| StatInfo | [StatInfo](../AccelByte.Sdk/Api/Social/Model/StatInfo.cs) |
| StatItemInc | [StatItemInc](../AccelByte.Sdk/Api/Social/Model/StatItemInc.cs) |
| StatItemIncResult | [StatItemIncResult](../AccelByte.Sdk/Api/Social/Model/StatItemIncResult.cs) |
| StatItemUpdate | [StatItemUpdate](../AccelByte.Sdk/Api/Social/Model/StatItemUpdate.cs) |
| StatPagingSlicedResult | [StatPagingSlicedResult](../AccelByte.Sdk/Api/Social/Model/StatPagingSlicedResult.cs) |
| StatResetInfo | [StatResetInfo](../AccelByte.Sdk/Api/Social/Model/StatResetInfo.cs) |
| StatUpdate | [StatUpdate](../AccelByte.Sdk/Api/Social/Model/StatUpdate.cs) |
| UserGameProfiles | [UserGameProfiles](../AccelByte.Sdk/Api/Social/Model/UserGameProfiles.cs) |
| UserSlotConfigInfo | [UserSlotConfigInfo](../AccelByte.Sdk/Api/Social/Model/UserSlotConfigInfo.cs) |
| UserStatItemInfo | [UserStatItemInfo](../AccelByte.Sdk/Api/Social/Model/UserStatItemInfo.cs) |
| UserStatItemPagingSlicedResult | [UserStatItemPagingSlicedResult](../AccelByte.Sdk/Api/Social/Model/UserStatItemPagingSlicedResult.cs) |
| ValidationErrorEntity | [ValidationErrorEntity](../AccelByte.Sdk/Api/Social/Model/ValidationErrorEntity.cs) |
