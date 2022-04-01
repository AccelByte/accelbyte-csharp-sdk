# Platform Service Index

&nbsp;  

## Operations

### FulfillmentScript Wrapper:  [FulfillmentScript](../AccelByte.Sdk/Api/Platform/Wrapper/FulfillmentScript.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/fulfillment/scripts | GET | ListFulfillmentScripts | [ListFulfillmentScripts](../AccelByte.Sdk/Api/Platform/Operation//ListFulfillmentScripts.cs) |
| /platform/admin/fulfillment/scripts/tests/eval | POST | TestFulfillmentScriptEval | [TestFulfillmentScriptEval](../AccelByte.Sdk/Api/Platform/Operation//TestFulfillmentScriptEval.cs) |
| /platform/admin/fulfillment/scripts/{id} | GET | GetFulfillmentScript | [GetFulfillmentScript](../AccelByte.Sdk/Api/Platform/Operation//GetFulfillmentScript.cs) |
| /platform/admin/fulfillment/scripts/{id} | POST | CreateFulfillmentScript | [CreateFulfillmentScript](../AccelByte.Sdk/Api/Platform/Operation//CreateFulfillmentScript.cs) |
| /platform/admin/fulfillment/scripts/{id} | DELETE | DeleteFulfillmentScript | [DeleteFulfillmentScript](../AccelByte.Sdk/Api/Platform/Operation//DeleteFulfillmentScript.cs) |
| /platform/admin/fulfillment/scripts/{id} | PATCH | UpdateFulfillmentScript | [UpdateFulfillmentScript](../AccelByte.Sdk/Api/Platform/Operation//UpdateFulfillmentScript.cs) |

### Campaign Wrapper:  [Campaign](../AccelByte.Sdk/Api/Platform/Wrapper/Campaign.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/campaigns | GET | QueryCampaigns | [QueryCampaigns](../AccelByte.Sdk/Api/Platform/Operation//QueryCampaigns.cs) |
| /platform/admin/namespaces/{namespace}/campaigns | POST | CreateCampaign | [CreateCampaign](../AccelByte.Sdk/Api/Platform/Operation//CreateCampaign.cs) |
| /platform/admin/namespaces/{namespace}/campaigns/{campaignId} | GET | GetCampaign | [GetCampaign](../AccelByte.Sdk/Api/Platform/Operation//GetCampaign.cs) |
| /platform/admin/namespaces/{namespace}/campaigns/{campaignId} | PUT | UpdateCampaign | [UpdateCampaign](../AccelByte.Sdk/Api/Platform/Operation//UpdateCampaign.cs) |
| /platform/admin/namespaces/{namespace}/campaigns/{campaignId}/dynamic | GET | GetCampaignDynamic | [GetCampaignDynamic](../AccelByte.Sdk/Api/Platform/Operation//GetCampaignDynamic.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId} | GET | QueryCodes | [QueryCodes](../AccelByte.Sdk/Api/Platform/Operation//QueryCodes.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId} | POST | CreateCodes | [CreateCodes](../AccelByte.Sdk/Api/Platform/Operation//CreateCodes.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/codes.csv | GET | Download | [Download](../AccelByte.Sdk/Api/Platform/Operation//Download.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk | PUT | BulkDisableCodes | [BulkDisableCodes](../AccelByte.Sdk/Api/Platform/Operation//BulkDisableCodes.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/enable/bulk | PUT | BulkEnableCodes | [BulkEnableCodes](../AccelByte.Sdk/Api/Platform/Operation//BulkEnableCodes.cs) |
| /platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/history | GET | QueryRedeemHistory | [QueryRedeemHistory](../AccelByte.Sdk/Api/Platform/Operation//QueryRedeemHistory.cs) |
| /platform/admin/namespaces/{namespace}/codes/{code} | GET | GetCode | [GetCode](../AccelByte.Sdk/Api/Platform/Operation//GetCode.cs) |
| /platform/admin/namespaces/{namespace}/codes/{code}/disable | PUT | DisableCode | [DisableCode](../AccelByte.Sdk/Api/Platform/Operation//DisableCode.cs) |
| /platform/admin/namespaces/{namespace}/codes/{code}/enable | PUT | EnableCode | [EnableCode](../AccelByte.Sdk/Api/Platform/Operation//EnableCode.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/redemption | POST | ApplyUserRedemption | [ApplyUserRedemption](../AccelByte.Sdk/Api/Platform/Operation//ApplyUserRedemption.cs) |

### Category Wrapper:  [Category](../AccelByte.Sdk/Api/Platform/Wrapper/Category.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/categories | GET | GetRootCategories | [GetRootCategories](../AccelByte.Sdk/Api/Platform/Operation//GetRootCategories.cs) |
| /platform/admin/namespaces/{namespace}/categories | POST | CreateCategory | [CreateCategory](../AccelByte.Sdk/Api/Platform/Operation//CreateCategory.cs) |
| /platform/admin/namespaces/{namespace}/categories/basic | GET | ListCategoriesBasic | [ListCategoriesBasic](../AccelByte.Sdk/Api/Platform/Operation//ListCategoriesBasic.cs) |
| /platform/admin/namespaces/{namespace}/categories/{categoryPath} | GET | GetCategory | [GetCategory](../AccelByte.Sdk/Api/Platform/Operation//GetCategory.cs) |
| /platform/admin/namespaces/{namespace}/categories/{categoryPath} | PUT | UpdateCategory | [UpdateCategory](../AccelByte.Sdk/Api/Platform/Operation//UpdateCategory.cs) |
| /platform/admin/namespaces/{namespace}/categories/{categoryPath} | DELETE | DeleteCategory | [DeleteCategory](../AccelByte.Sdk/Api/Platform/Operation//DeleteCategory.cs) |
| /platform/admin/namespaces/{namespace}/categories/{categoryPath}/children | GET | GetChildCategories | [GetChildCategories](../AccelByte.Sdk/Api/Platform/Operation//GetChildCategories.cs) |
| /platform/admin/namespaces/{namespace}/categories/{categoryPath}/descendants | GET | GetDescendantCategories | [GetDescendantCategories](../AccelByte.Sdk/Api/Platform/Operation//GetDescendantCategories.cs) |
| /platform/public/namespaces/{namespace}/categories | GET | PublicGetRootCategories | [PublicGetRootCategories](../AccelByte.Sdk/Api/Platform/Operation//PublicGetRootCategories.cs) |
| /platform/public/namespaces/{namespace}/categories/download | GET | DownloadCategories | [DownloadCategories](../AccelByte.Sdk/Api/Platform/Operation//DownloadCategories.cs) |
| /platform/public/namespaces/{namespace}/categories/{categoryPath} | GET | PublicGetCategory | [PublicGetCategory](../AccelByte.Sdk/Api/Platform/Operation//PublicGetCategory.cs) |
| /platform/public/namespaces/{namespace}/categories/{categoryPath}/children | GET | PublicGetChildCategories | [PublicGetChildCategories](../AccelByte.Sdk/Api/Platform/Operation//PublicGetChildCategories.cs) |
| /platform/public/namespaces/{namespace}/categories/{categoryPath}/descendants | GET | PublicGetDescendantCategories | [PublicGetDescendantCategories](../AccelByte.Sdk/Api/Platform/Operation//PublicGetDescendantCategories.cs) |

### Currency Wrapper:  [Currency](../AccelByte.Sdk/Api/Platform/Wrapper/Currency.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/currencies | GET | ListCurrencies | [ListCurrencies](../AccelByte.Sdk/Api/Platform/Operation//ListCurrencies.cs) |
| /platform/admin/namespaces/{namespace}/currencies | POST | CreateCurrency | [CreateCurrency](../AccelByte.Sdk/Api/Platform/Operation//CreateCurrency.cs) |
| /platform/admin/namespaces/{namespace}/currencies/{currencyCode} | PUT | UpdateCurrency | [UpdateCurrency](../AccelByte.Sdk/Api/Platform/Operation//UpdateCurrency.cs) |
| /platform/admin/namespaces/{namespace}/currencies/{currencyCode} | DELETE | DeleteCurrency | [DeleteCurrency](../AccelByte.Sdk/Api/Platform/Operation//DeleteCurrency.cs) |
| /platform/admin/namespaces/{namespace}/currencies/{currencyCode}/config | GET | GetCurrencyConfig | [GetCurrencyConfig](../AccelByte.Sdk/Api/Platform/Operation//GetCurrencyConfig.cs) |
| /platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary | GET | GetCurrencySummary | [GetCurrencySummary](../AccelByte.Sdk/Api/Platform/Operation//GetCurrencySummary.cs) |
| /platform/public/namespaces/{namespace}/currencies | GET | PublicListCurrencies | [PublicListCurrencies](../AccelByte.Sdk/Api/Platform/Operation//PublicListCurrencies.cs) |

### DLC Wrapper:  [DLC](../AccelByte.Sdk/Api/Platform/Wrapper/DLC.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/dlc/config/item | GET | GetDLCItemConfig | [GetDLCItemConfig](../AccelByte.Sdk/Api/Platform/Operation//GetDLCItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/dlc/config/item | PUT | UpdateDLCItemConfig | [UpdateDLCItemConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateDLCItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/dlc/config/item | DELETE | DeleteDLCItemConfig | [DeleteDLCItemConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteDLCItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/dlc/config/platformMap | GET | GetPlatformDLCConfig | [GetPlatformDLCConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPlatformDLCConfig.cs) |
| /platform/admin/namespaces/{namespace}/dlc/config/platformMap | PUT | UpdatePlatformDLCConfig | [UpdatePlatformDLCConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePlatformDLCConfig.cs) |
| /platform/admin/namespaces/{namespace}/dlc/config/platformMap | DELETE | DeletePlatformDLCConfig | [DeletePlatformDLCConfig](../AccelByte.Sdk/Api/Platform/Operation//DeletePlatformDLCConfig.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/dlc/psn/sync | PUT | PublicSyncPsnDlcInventory | [PublicSyncPsnDlcInventory](../AccelByte.Sdk/Api/Platform/Operation//PublicSyncPsnDlcInventory.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/dlc/steam/sync | PUT | SyncSteamDLC | [SyncSteamDLC](../AccelByte.Sdk/Api/Platform/Operation//SyncSteamDLC.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/dlc/xbl/sync | PUT | SyncXboxDLC | [SyncXboxDLC](../AccelByte.Sdk/Api/Platform/Operation//SyncXboxDLC.cs) |

### Entitlement Wrapper:  [Entitlement](../AccelByte.Sdk/Api/Platform/Wrapper/Entitlement.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/entitlements | GET | QueryEntitlements | [QueryEntitlements](../AccelByte.Sdk/Api/Platform/Operation//QueryEntitlements.cs) |
| /platform/admin/namespaces/{namespace}/entitlements/{entitlementId} | GET | GetEntitlement | [GetEntitlement](../AccelByte.Sdk/Api/Platform/Operation//GetEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements | GET | QueryUserEntitlements | [QueryUserEntitlements](../AccelByte.Sdk/Api/Platform/Operation//QueryUserEntitlements.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements | POST | GrantUserEntitlement | [GrantUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//GrantUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId | GET | GetUserAppEntitlementByAppId | [GetUserAppEntitlementByAppId](../AccelByte.Sdk/Api/Platform/Operation//GetUserAppEntitlementByAppId.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType | GET | QueryUserEntitlementsByAppType | [QueryUserEntitlementsByAppType](../AccelByte.Sdk/Api/Platform/Operation//QueryUserEntitlementsByAppType.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId | GET | GetUserEntitlementByItemId | [GetUserEntitlementByItemId](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlementByItemId.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku | GET | GetUserEntitlementBySku | [GetUserEntitlementBySku](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlementBySku.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/any | GET | ExistsAnyUserActiveEntitlement | [ExistsAnyUserActiveEntitlement](../AccelByte.Sdk/Api/Platform/Operation//ExistsAnyUserActiveEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/anyOf | GET | ExistsAnyUserActiveEntitlementByItemIds | [ExistsAnyUserActiveEntitlementByItemIds](../AccelByte.Sdk/Api/Platform/Operation//ExistsAnyUserActiveEntitlementByItemIds.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId | GET | GetUserAppEntitlementOwnershipByAppId | [GetUserAppEntitlementOwnershipByAppId](../AccelByte.Sdk/Api/Platform/Operation//GetUserAppEntitlementOwnershipByAppId.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId | GET | GetUserEntitlementOwnershipByItemId | [GetUserEntitlementOwnershipByItemId](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlementOwnershipByItemId.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku | GET | GetUserEntitlementOwnershipBySku | [GetUserEntitlementOwnershipBySku](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlementOwnershipBySku.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/revoke/byIds | PUT | RevokeUserEntitlements | [RevokeUserEntitlements](../AccelByte.Sdk/Api/Platform/Operation//RevokeUserEntitlements.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} | GET | GetUserEntitlement | [GetUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} | PUT | UpdateUserEntitlement | [UpdateUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//UpdateUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement | PUT | ConsumeUserEntitlement | [ConsumeUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//ConsumeUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable | PUT | DisableUserEntitlement | [DisableUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//DisableUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable | PUT | EnableUserEntitlement | [EnableUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//EnableUserEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/history | GET | GetUserEntitlementHistories | [GetUserEntitlementHistories](../AccelByte.Sdk/Api/Platform/Operation//GetUserEntitlementHistories.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke | PUT | RevokeUserEntitlement | [RevokeUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//RevokeUserEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/me/entitlements/ownership/any | GET | PublicExistsAnyMyActiveEntitlement | [PublicExistsAnyMyActiveEntitlement](../AccelByte.Sdk/Api/Platform/Operation//PublicExistsAnyMyActiveEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byAppId | GET | PublicGetMyAppEntitlementOwnershipByAppId | [PublicGetMyAppEntitlementOwnershipByAppId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetMyAppEntitlementOwnershipByAppId.cs) |
| /platform/public/namespaces/{namespace}/users/me/entitlements/ownership/byItemId | GET | PublicGetMyEntitlementOwnershipByItemId | [PublicGetMyEntitlementOwnershipByItemId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetMyEntitlementOwnershipByItemId.cs) |
| /platform/public/namespaces/{namespace}/users/me/entitlements/ownership/bySku | GET | PublicGetMyEntitlementOwnershipBySku | [PublicGetMyEntitlementOwnershipBySku](../AccelByte.Sdk/Api/Platform/Operation//PublicGetMyEntitlementOwnershipBySku.cs) |
| /platform/public/namespaces/{namespace}/users/me/entitlements/ownershipToken | GET | PublicGetEntitlementOwnershipToken | [PublicGetEntitlementOwnershipToken](../AccelByte.Sdk/Api/Platform/Operation//PublicGetEntitlementOwnershipToken.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements | GET | PublicQueryUserEntitlements | [PublicQueryUserEntitlements](../AccelByte.Sdk/Api/Platform/Operation//PublicQueryUserEntitlements.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId | GET | PublicGetUserAppEntitlementByAppId | [PublicGetUserAppEntitlementByAppId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserAppEntitlementByAppId.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType | GET | PublicQueryUserEntitlementsByAppType | [PublicQueryUserEntitlementsByAppType](../AccelByte.Sdk/Api/Platform/Operation//PublicQueryUserEntitlementsByAppType.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId | GET | PublicGetUserEntitlementByItemId | [PublicGetUserEntitlementByItemId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserEntitlementByItemId.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku | GET | PublicGetUserEntitlementBySku | [PublicGetUserEntitlementBySku](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserEntitlementBySku.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/any | GET | PublicExistsAnyUserActiveEntitlement | [PublicExistsAnyUserActiveEntitlement](../AccelByte.Sdk/Api/Platform/Operation//PublicExistsAnyUserActiveEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byAppId | GET | PublicGetUserAppEntitlementOwnershipByAppId | [PublicGetUserAppEntitlementOwnershipByAppId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserAppEntitlementOwnershipByAppId.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/byItemId | GET | PublicGetUserEntitlementOwnershipByItemId | [PublicGetUserEntitlementOwnershipByItemId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserEntitlementOwnershipByItemId.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/ownership/bySku | GET | PublicGetUserEntitlementOwnershipBySku | [PublicGetUserEntitlementOwnershipBySku](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserEntitlementOwnershipBySku.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} | GET | PublicGetUserEntitlement | [PublicGetUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement | PUT | PublicConsumeUserEntitlement | [PublicConsumeUserEntitlement](../AccelByte.Sdk/Api/Platform/Operation//PublicConsumeUserEntitlement.cs) |

### Fulfillment Wrapper:  [Fulfillment](../AccelByte.Sdk/Api/Platform/Wrapper/Fulfillment.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/fulfillment/history | GET | QueryFulfillmentHistories | [QueryFulfillmentHistories](../AccelByte.Sdk/Api/Platform/Operation//QueryFulfillmentHistories.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/fulfillment | POST | FulfillItem | [FulfillItem](../AccelByte.Sdk/Api/Platform/Operation//FulfillItem.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/code | POST | RedeemCode | [RedeemCode](../AccelByte.Sdk/Api/Platform/Operation//RedeemCode.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards | POST | FulfillRewards | [FulfillRewards](../AccelByte.Sdk/Api/Platform/Operation//FulfillRewards.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/fulfillment/code | POST | PublicRedeemCode | [PublicRedeemCode](../AccelByte.Sdk/Api/Platform/Operation//PublicRedeemCode.cs) |

### IAP Wrapper:  [IAP](../AccelByte.Sdk/Api/Platform/Wrapper/IAP.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/iap/config/apple | GET | GetAppleIAPConfig | [GetAppleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetAppleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/apple | PUT | UpdateAppleIAPConfig | [UpdateAppleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateAppleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/apple | DELETE | DeleteAppleIAPConfig | [DeleteAppleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteAppleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/epicgames | GET | GetEpicGamesIAPConfig | [GetEpicGamesIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetEpicGamesIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/epicgames | PUT | UpdateEpicGamesIAPConfig | [UpdateEpicGamesIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateEpicGamesIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/epicgames | DELETE | DeleteEpicGamesIAPConfig | [DeleteEpicGamesIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteEpicGamesIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/google | GET | GetGoogleIAPConfig | [GetGoogleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetGoogleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/google | PUT | UpdateGoogleIAPConfig | [UpdateGoogleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateGoogleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/google | DELETE | DeleteGoogleIAPConfig | [DeleteGoogleIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteGoogleIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/google/cert | PUT | UpdateGoogleP12File | [UpdateGoogleP12File](../AccelByte.Sdk/Api/Platform/Operation//UpdateGoogleP12File.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/item | GET | GetIAPItemConfig | [GetIAPItemConfig](../AccelByte.Sdk/Api/Platform/Operation//GetIAPItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/item | PUT | UpdateIAPItemConfig | [UpdateIAPItemConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateIAPItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/item | DELETE | DeleteIAPItemConfig | [DeleteIAPItemConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteIAPItemConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/playstation | GET | GetPlayStationIAPConfig | [GetPlayStationIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPlayStationIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/playstation | PUT | UpdatePlaystationIAPConfig | [UpdatePlaystationIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePlaystationIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/playstation | DELETE | DeletePlaystationIAPConfig | [DeletePlaystationIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeletePlaystationIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/stadia | GET | GetStadiaIAPConfig | [GetStadiaIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetStadiaIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/stadia | DELETE | DeleteStadiaIAPConfig | [DeleteStadiaIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteStadiaIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/stadia/cert | PUT | UpdateStadiaJsonConfigFile | [UpdateStadiaJsonConfigFile](../AccelByte.Sdk/Api/Platform/Operation//UpdateStadiaJsonConfigFile.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/steam | GET | GetSteamIAPConfig | [GetSteamIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetSteamIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/steam | PUT | UpdateSteamIAPConfig | [UpdateSteamIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateSteamIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/steam | DELETE | DeleteSteamIAPConfig | [DeleteSteamIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteSteamIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/twitch | GET | GetTwitchIAPConfig | [GetTwitchIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetTwitchIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/twitch | PUT | UpdateTwitchIAPConfig | [UpdateTwitchIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateTwitchIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/twitch | DELETE | DeleteTwitchIAPConfig | [DeleteTwitchIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteTwitchIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/xbl | GET | GetXblIAPConfig | [GetXblIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//GetXblIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/xbl | PUT | UpdateXblIAPConfig | [UpdateXblIAPConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateXblIAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/xbl | DELETE | DeleteXblAPConfig | [DeleteXblAPConfig](../AccelByte.Sdk/Api/Platform/Operation//DeleteXblAPConfig.cs) |
| /platform/admin/namespaces/{namespace}/iap/config/xbl/cert | PUT | UpdateXblBPCertFile | [UpdateXblBPCertFile](../AccelByte.Sdk/Api/Platform/Operation//UpdateXblBPCertFile.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/iap | GET | QueryUserIAPOrders | [QueryUserIAPOrders](../AccelByte.Sdk/Api/Platform/Operation//QueryUserIAPOrders.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/iap/all | GET | QueryAllUserIAPOrders | [QueryAllUserIAPOrders](../AccelByte.Sdk/Api/Platform/Operation//QueryAllUserIAPOrders.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/iap/mock/receipt | PUT | MockFulfillIAPItem | [MockFulfillIAPItem](../AccelByte.Sdk/Api/Platform/Operation//MockFulfillIAPItem.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt | PUT | PublicFulfillAppleIAPItem | [PublicFulfillAppleIAPItem](../AccelByte.Sdk/Api/Platform/Operation//PublicFulfillAppleIAPItem.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/epicgames/sync | PUT | SyncEpicGamesInventory | [SyncEpicGamesInventory](../AccelByte.Sdk/Api/Platform/Operation//SyncEpicGamesInventory.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/google/receipt | PUT | PublicFulfillGoogleIAPItem | [PublicFulfillGoogleIAPItem](../AccelByte.Sdk/Api/Platform/Operation//PublicFulfillGoogleIAPItem.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync | PUT | PublicReconcilePlayStationStore | [PublicReconcilePlayStationStore](../AccelByte.Sdk/Api/Platform/Operation//PublicReconcilePlayStationStore.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/stadia/sync | PUT | SyncStadiaEntitlement | [SyncStadiaEntitlement](../AccelByte.Sdk/Api/Platform/Operation//SyncStadiaEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/steam/sync | PUT | SyncSteamInventory | [SyncSteamInventory](../AccelByte.Sdk/Api/Platform/Operation//SyncSteamInventory.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/twitch/sync | PUT | SyncTwitchDropsEntitlement | [SyncTwitchDropsEntitlement](../AccelByte.Sdk/Api/Platform/Operation//SyncTwitchDropsEntitlement.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/iap/xbl/sync | PUT | SyncXboxInventory | [SyncXboxInventory](../AccelByte.Sdk/Api/Platform/Operation//SyncXboxInventory.cs) |

### Item Wrapper:  [Item](../AccelByte.Sdk/Api/Platform/Wrapper/Item.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/items | PUT | SyncInGameItem | [SyncInGameItem](../AccelByte.Sdk/Api/Platform/Operation//SyncInGameItem.cs) |
| /platform/admin/namespaces/{namespace}/items | POST | CreateItem | [CreateItem](../AccelByte.Sdk/Api/Platform/Operation//CreateItem.cs) |
| /platform/admin/namespaces/{namespace}/items/byAppId | GET | GetItemByAppId | [GetItemByAppId](../AccelByte.Sdk/Api/Platform/Operation//GetItemByAppId.cs) |
| /platform/admin/namespaces/{namespace}/items/byCriteria | GET | QueryItems | [QueryItems](../AccelByte.Sdk/Api/Platform/Operation//QueryItems.cs) |
| /platform/admin/namespaces/{namespace}/items/byFeatures/basic | GET | ListBasicItemsByFeatures | [ListBasicItemsByFeatures](../AccelByte.Sdk/Api/Platform/Operation//ListBasicItemsByFeatures.cs) |
| /platform/admin/namespaces/{namespace}/items/bySku | GET | GetItemBySku | [GetItemBySku](../AccelByte.Sdk/Api/Platform/Operation//GetItemBySku.cs) |
| /platform/admin/namespaces/{namespace}/items/bySku/locale | GET | GetLocaleItemBySku | [GetLocaleItemBySku](../AccelByte.Sdk/Api/Platform/Operation//GetLocaleItemBySku.cs) |
| /platform/admin/namespaces/{namespace}/items/itemId/bySku | GET | GetItemIdBySku | [GetItemIdBySku](../AccelByte.Sdk/Api/Platform/Operation//GetItemIdBySku.cs) |
| /platform/admin/namespaces/{namespace}/items/locale/byIds | GET | BulkGetLocaleItems | [BulkGetLocaleItems](../AccelByte.Sdk/Api/Platform/Operation//BulkGetLocaleItems.cs) |
| /platform/admin/namespaces/{namespace}/items/search | GET | SearchItems | [SearchItems](../AccelByte.Sdk/Api/Platform/Operation//SearchItems.cs) |
| /platform/admin/namespaces/{namespace}/items/uncategorized | GET | QueryUncategorizedItems | [QueryUncategorizedItems](../AccelByte.Sdk/Api/Platform/Operation//QueryUncategorizedItems.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId} | GET | GetItem | [GetItem](../AccelByte.Sdk/Api/Platform/Operation//GetItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId} | PUT | UpdateItem | [UpdateItem](../AccelByte.Sdk/Api/Platform/Operation//UpdateItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId} | DELETE | DeleteItem | [DeleteItem](../AccelByte.Sdk/Api/Platform/Operation//DeleteItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/acquire | PUT | AcquireItem | [AcquireItem](../AccelByte.Sdk/Api/Platform/Operation//AcquireItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/app | GET | GetApp | [GetApp](../AccelByte.Sdk/Api/Platform/Operation//GetApp.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/app | PUT | UpdateApp | [UpdateApp](../AccelByte.Sdk/Api/Platform/Operation//UpdateApp.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/disable | PUT | DisableItem | [DisableItem](../AccelByte.Sdk/Api/Platform/Operation//DisableItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/dynamic | GET | GetItemDynamicData | [GetItemDynamicData](../AccelByte.Sdk/Api/Platform/Operation//GetItemDynamicData.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/enable | PUT | EnableItem | [EnableItem](../AccelByte.Sdk/Api/Platform/Operation//EnableItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} | PUT | FeatureItem | [FeatureItem](../AccelByte.Sdk/Api/Platform/Operation//FeatureItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} | DELETE | DefeatureItem | [DefeatureItem](../AccelByte.Sdk/Api/Platform/Operation//DefeatureItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/locale | GET | GetLocaleItem | [GetLocaleItem](../AccelByte.Sdk/Api/Platform/Operation//GetLocaleItem.cs) |
| /platform/admin/namespaces/{namespace}/items/{itemId}/return | PUT | ReturnItem | [ReturnItem](../AccelByte.Sdk/Api/Platform/Operation//ReturnItem.cs) |
| /platform/public/namespaces/{namespace}/items/byAppId | GET | PublicGetItemByAppId | [PublicGetItemByAppId](../AccelByte.Sdk/Api/Platform/Operation//PublicGetItemByAppId.cs) |
| /platform/public/namespaces/{namespace}/items/byCriteria | GET | PublicQueryItems | [PublicQueryItems](../AccelByte.Sdk/Api/Platform/Operation//PublicQueryItems.cs) |
| /platform/public/namespaces/{namespace}/items/bySku | GET | PublicGetItemBySku | [PublicGetItemBySku](../AccelByte.Sdk/Api/Platform/Operation//PublicGetItemBySku.cs) |
| /platform/public/namespaces/{namespace}/items/locale/byIds | GET | PublicBulkGetItems | [PublicBulkGetItems](../AccelByte.Sdk/Api/Platform/Operation//PublicBulkGetItems.cs) |
| /platform/public/namespaces/{namespace}/items/search | GET | PublicSearchItems | [PublicSearchItems](../AccelByte.Sdk/Api/Platform/Operation//PublicSearchItems.cs) |
| /platform/public/namespaces/{namespace}/items/{itemId}/app/locale | GET | PublicGetApp | [PublicGetApp](../AccelByte.Sdk/Api/Platform/Operation//PublicGetApp.cs) |
| /platform/public/namespaces/{namespace}/items/{itemId}/dynamic | GET | PublicGetItemDynamicData | [PublicGetItemDynamicData](../AccelByte.Sdk/Api/Platform/Operation//PublicGetItemDynamicData.cs) |
| /platform/public/namespaces/{namespace}/items/{itemId}/locale | GET | PublicGetItem | [PublicGetItem](../AccelByte.Sdk/Api/Platform/Operation//PublicGetItem.cs) |

### KeyGroup Wrapper:  [KeyGroup](../AccelByte.Sdk/Api/Platform/Wrapper/KeyGroup.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/keygroups | GET | QueryKeyGroups | [QueryKeyGroups](../AccelByte.Sdk/Api/Platform/Operation//QueryKeyGroups.cs) |
| /platform/admin/namespaces/{namespace}/keygroups | POST | CreateKeyGroup | [CreateKeyGroup](../AccelByte.Sdk/Api/Platform/Operation//CreateKeyGroup.cs) |
| /platform/admin/namespaces/{namespace}/keygroups/{keyGroupId} | GET | GetKeyGroup | [GetKeyGroup](../AccelByte.Sdk/Api/Platform/Operation//GetKeyGroup.cs) |
| /platform/admin/namespaces/{namespace}/keygroups/{keyGroupId} | PUT | UpdateKeyGroup | [UpdateKeyGroup](../AccelByte.Sdk/Api/Platform/Operation//UpdateKeyGroup.cs) |
| /platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/dynamic | GET | GetKeyGroupDynamic | [GetKeyGroupDynamic](../AccelByte.Sdk/Api/Platform/Operation//GetKeyGroupDynamic.cs) |
| /platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys | GET | ListKeys | [ListKeys](../AccelByte.Sdk/Api/Platform/Operation//ListKeys.cs) |
| /platform/admin/namespaces/{namespace}/keygroups/{keyGroupId}/keys | POST | UploadKeys | [UploadKeys](../AccelByte.Sdk/Api/Platform/Operation//UploadKeys.cs) |

### Order Wrapper:  [Order](../AccelByte.Sdk/Api/Platform/Wrapper/Order.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/orders | GET | QueryOrders | [QueryOrders](../AccelByte.Sdk/Api/Platform/Operation//QueryOrders.cs) |
| /platform/admin/namespaces/{namespace}/orders/stats | GET | GetOrderStatistics | [GetOrderStatistics](../AccelByte.Sdk/Api/Platform/Operation//GetOrderStatistics.cs) |
| /platform/admin/namespaces/{namespace}/orders/{orderNo} | GET | GetOrder | [GetOrder](../AccelByte.Sdk/Api/Platform/Operation//GetOrder.cs) |
| /platform/admin/namespaces/{namespace}/orders/{orderNo}/refund | PUT | RefundOrder | [RefundOrder](../AccelByte.Sdk/Api/Platform/Operation//RefundOrder.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders | GET | QueryUserOrders | [QueryUserOrders](../AccelByte.Sdk/Api/Platform/Operation//QueryUserOrders.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/countOfItem | GET | CountOfPurchasedItem | [CountOfPurchasedItem](../AccelByte.Sdk/Api/Platform/Operation//CountOfPurchasedItem.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} | GET | GetUserOrder | [GetUserOrder](../AccelByte.Sdk/Api/Platform/Operation//GetUserOrder.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} | PUT | UpdateUserOrderStatus | [UpdateUserOrderStatus](../AccelByte.Sdk/Api/Platform/Operation//UpdateUserOrderStatus.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill | PUT | FulfillUserOrder | [FulfillUserOrder](../AccelByte.Sdk/Api/Platform/Operation//FulfillUserOrder.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/grant | GET | GetUserOrderGrant | [GetUserOrderGrant](../AccelByte.Sdk/Api/Platform/Operation//GetUserOrderGrant.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history | GET | GetUserOrderHistories | [GetUserOrderHistories](../AccelByte.Sdk/Api/Platform/Operation//GetUserOrderHistories.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/notifications | POST | ProcessUserOrderNotification | [ProcessUserOrderNotification](../AccelByte.Sdk/Api/Platform/Operation//ProcessUserOrderNotification.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf | GET | DownloadUserOrderReceipt | [DownloadUserOrderReceipt](../AccelByte.Sdk/Api/Platform/Operation//DownloadUserOrderReceipt.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders | GET | PublicQueryUserOrders | [PublicQueryUserOrders](../AccelByte.Sdk/Api/Platform/Operation//PublicQueryUserOrders.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders | POST | PublicCreateUserOrder | [PublicCreateUserOrder](../AccelByte.Sdk/Api/Platform/Operation//PublicCreateUserOrder.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo} | GET | PublicGetUserOrder | [PublicGetUserOrder](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserOrder.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel | PUT | PublicCancelUserOrder | [PublicCancelUserOrder](../AccelByte.Sdk/Api/Platform/Operation//PublicCancelUserOrder.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/history | GET | PublicGetUserOrderHistories | [PublicGetUserOrderHistories](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserOrderHistories.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf | GET | PublicDownloadUserOrderReceipt | [PublicDownloadUserOrderReceipt](../AccelByte.Sdk/Api/Platform/Operation//PublicDownloadUserOrderReceipt.cs) |

### PaymentCallbackConfig Wrapper:  [PaymentCallbackConfig](../AccelByte.Sdk/Api/Platform/Wrapper/PaymentCallbackConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/payment/config/callback | GET | GetPaymentCallbackConfig | [GetPaymentCallbackConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentCallbackConfig.cs) |
| /platform/admin/namespaces/{namespace}/payment/config/callback | PUT | UpdatePaymentCallbackConfig | [UpdatePaymentCallbackConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePaymentCallbackConfig.cs) |

### Payment Wrapper:  [Payment](../AccelByte.Sdk/Api/Platform/Wrapper/Payment.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/payment/notifications | GET | QueryPaymentNotifications | [QueryPaymentNotifications](../AccelByte.Sdk/Api/Platform/Operation//QueryPaymentNotifications.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders | GET | QueryPaymentOrders | [QueryPaymentOrders](../AccelByte.Sdk/Api/Platform/Operation//QueryPaymentOrders.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/byExtTxId | GET | ListExtOrderNoByExtTxId | [ListExtOrderNoByExtTxId](../AccelByte.Sdk/Api/Platform/Operation//ListExtOrderNoByExtTxId.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo} | GET | GetPaymentOrder | [GetPaymentOrder](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentOrder.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo} | PUT | ChargePaymentOrder | [ChargePaymentOrder](../AccelByte.Sdk/Api/Platform/Operation//ChargePaymentOrder.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/simulate-notification | PUT | SimulatePaymentOrderNotification | [SimulatePaymentOrderNotification](../AccelByte.Sdk/Api/Platform/Operation//SimulatePaymentOrderNotification.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status | GET | GetPaymentOrderChargeStatus | [GetPaymentOrderChargeStatus](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentOrderChargeStatus.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/payment/orders | POST | CreateUserPaymentOrder | [CreateUserPaymentOrder](../AccelByte.Sdk/Api/Platform/Operation//CreateUserPaymentOrder.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund | PUT | RefundUserPaymentOrder | [RefundUserPaymentOrder](../AccelByte.Sdk/Api/Platform/Operation//RefundUserPaymentOrder.cs) |

### Payment(Dedicated) Wrapper:  [PaymentDedicated](../AccelByte.Sdk/Api/Platform/Wrapper/PaymentDedicated.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/payment/orders | POST | CreatePaymentOrderByDedicated | [CreatePaymentOrderByDedicated](../AccelByte.Sdk/Api/Platform/Operation//CreatePaymentOrderByDedicated.cs) |
| /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/refund | PUT | RefundPaymentOrderByDedicated | [RefundPaymentOrderByDedicated](../AccelByte.Sdk/Api/Platform/Operation//RefundPaymentOrderByDedicated.cs) |
| /platform/admin/payment/orders | GET | SyncPaymentOrders | [SyncPaymentOrders](../AccelByte.Sdk/Api/Platform/Operation//SyncPaymentOrders.cs) |

### Reward Wrapper:  [Reward](../AccelByte.Sdk/Api/Platform/Wrapper/Reward.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/rewards | POST | CreateReward | [CreateReward](../AccelByte.Sdk/Api/Platform/Operation//CreateReward.cs) |
| /platform/admin/namespaces/{namespace}/rewards/byCriteria | GET | QueryRewards | [QueryRewards](../AccelByte.Sdk/Api/Platform/Operation//QueryRewards.cs) |
| /platform/admin/namespaces/{namespace}/rewards/export | GET | ExportRewards | [ExportRewards](../AccelByte.Sdk/Api/Platform/Operation//ExportRewards.cs) |
| /platform/admin/namespaces/{namespace}/rewards/import | POST | ImportRewards | [ImportRewards](../AccelByte.Sdk/Api/Platform/Operation//ImportRewards.cs) |
| /platform/admin/namespaces/{namespace}/rewards/{rewardId} | GET | GetReward | [GetReward](../AccelByte.Sdk/Api/Platform/Operation//GetReward.cs) |
| /platform/admin/namespaces/{namespace}/rewards/{rewardId} | PUT | UpdateReward | [UpdateReward](../AccelByte.Sdk/Api/Platform/Operation//UpdateReward.cs) |
| /platform/admin/namespaces/{namespace}/rewards/{rewardId} | DELETE | DeleteReward | [DeleteReward](../AccelByte.Sdk/Api/Platform/Operation//DeleteReward.cs) |
| /platform/admin/namespaces/{namespace}/rewards/{rewardId}/match | PUT | CheckEventCondition | [CheckEventCondition](../AccelByte.Sdk/Api/Platform/Operation//CheckEventCondition.cs) |
| /platform/public/namespaces/{namespace}/rewards/byCode | GET | GetRewardByCode | [GetRewardByCode](../AccelByte.Sdk/Api/Platform/Operation//GetRewardByCode.cs) |
| /platform/public/namespaces/{namespace}/rewards/byCriteria | GET | QueryRewards1 | [QueryRewards1](../AccelByte.Sdk/Api/Platform/Operation//QueryRewards1.cs) |
| /platform/public/namespaces/{namespace}/rewards/{rewardId} | GET | GetReward1 | [GetReward1](../AccelByte.Sdk/Api/Platform/Operation//GetReward1.cs) |

### Store Wrapper:  [Store](../AccelByte.Sdk/Api/Platform/Wrapper/Store.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/stores | GET | ListStores | [ListStores](../AccelByte.Sdk/Api/Platform/Operation//ListStores.cs) |
| /platform/admin/namespaces/{namespace}/stores | POST | CreateStore | [CreateStore](../AccelByte.Sdk/Api/Platform/Operation//CreateStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/import | PUT | ImportStore | [ImportStore](../AccelByte.Sdk/Api/Platform/Operation//ImportStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/published | GET | GetPublishedStore | [GetPublishedStore](../AccelByte.Sdk/Api/Platform/Operation//GetPublishedStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/published | DELETE | DeletePublishedStore | [DeletePublishedStore](../AccelByte.Sdk/Api/Platform/Operation//DeletePublishedStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/published/backup | GET | GetPublishedStoreBackup | [GetPublishedStoreBackup](../AccelByte.Sdk/Api/Platform/Operation//GetPublishedStoreBackup.cs) |
| /platform/admin/namespaces/{namespace}/stores/published/rollback | PUT | RollbackPublishedStore | [RollbackPublishedStore](../AccelByte.Sdk/Api/Platform/Operation//RollbackPublishedStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/{storeId} | GET | GetStore | [GetStore](../AccelByte.Sdk/Api/Platform/Operation//GetStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/{storeId} | PUT | UpdateStore | [UpdateStore](../AccelByte.Sdk/Api/Platform/Operation//UpdateStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/{storeId} | DELETE | DeleteStore | [DeleteStore](../AccelByte.Sdk/Api/Platform/Operation//DeleteStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/{storeId}/clone | PUT | CloneStore | [CloneStore](../AccelByte.Sdk/Api/Platform/Operation//CloneStore.cs) |
| /platform/admin/namespaces/{namespace}/stores/{storeId}/export | GET | ExportStore | [ExportStore](../AccelByte.Sdk/Api/Platform/Operation//ExportStore.cs) |
| /platform/public/namespaces/{namespace}/stores | GET | PublicListStores | [PublicListStores](../AccelByte.Sdk/Api/Platform/Operation//PublicListStores.cs) |

### Subscription Wrapper:  [Subscription](../AccelByte.Sdk/Api/Platform/Wrapper/Subscription.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/subscriptions | GET | QuerySubscriptions | [QuerySubscriptions](../AccelByte.Sdk/Api/Platform/Operation//QuerySubscriptions.cs) |
| /platform/admin/namespaces/{namespace}/subscriptions/{subscriptionId}/recurring | PUT | RecurringChargeSubscription | [RecurringChargeSubscription](../AccelByte.Sdk/Api/Platform/Operation//RecurringChargeSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions | GET | QueryUserSubscriptions | [QueryUserSubscriptions](../AccelByte.Sdk/Api/Platform/Operation//QueryUserSubscriptions.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/activities | GET | GetUserSubscriptionActivities | [GetUserSubscriptionActivities](../AccelByte.Sdk/Api/Platform/Operation//GetUserSubscriptionActivities.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe | POST | PlatformSubscribeSubscription | [PlatformSubscribeSubscription](../AccelByte.Sdk/Api/Platform/Operation//PlatformSubscribeSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId | GET | CheckUserSubscriptionSubscribableByItemId | [CheckUserSubscriptionSubscribableByItemId](../AccelByte.Sdk/Api/Platform/Operation//CheckUserSubscriptionSubscribableByItemId.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} | GET | GetUserSubscription | [GetUserSubscription](../AccelByte.Sdk/Api/Platform/Operation//GetUserSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} | DELETE | DeleteUserSubscription | [DeleteUserSubscription](../AccelByte.Sdk/Api/Platform/Operation//DeleteUserSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel | PUT | CancelSubscription | [CancelSubscription](../AccelByte.Sdk/Api/Platform/Operation//CancelSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant | PUT | GrantDaysToSubscription | [GrantDaysToSubscription](../AccelByte.Sdk/Api/Platform/Operation//GrantDaysToSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history | GET | GetUserSubscriptionBillingHistories | [GetUserSubscriptionBillingHistories](../AccelByte.Sdk/Api/Platform/Operation//GetUserSubscriptionBillingHistories.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/notifications | POST | ProcessUserSubscriptionNotification | [ProcessUserSubscriptionNotification](../AccelByte.Sdk/Api/Platform/Operation//ProcessUserSubscriptionNotification.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions | GET | PublicQueryUserSubscriptions | [PublicQueryUserSubscriptions](../AccelByte.Sdk/Api/Platform/Operation//PublicQueryUserSubscriptions.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions | POST | PublicSubscribeSubscription | [PublicSubscribeSubscription](../AccelByte.Sdk/Api/Platform/Operation//PublicSubscribeSubscription.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/subscribable/byItemId | GET | PublicCheckUserSubscriptionSubscribableByItemId | [PublicCheckUserSubscriptionSubscribableByItemId](../AccelByte.Sdk/Api/Platform/Operation//PublicCheckUserSubscriptionSubscribableByItemId.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} | GET | PublicGetUserSubscription | [PublicGetUserSubscription](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserSubscription.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount | PUT | PublicChangeSubscriptionBillingAccount | [PublicChangeSubscriptionBillingAccount](../AccelByte.Sdk/Api/Platform/Operation//PublicChangeSubscriptionBillingAccount.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel | PUT | PublicCancelSubscription | [PublicCancelSubscription](../AccelByte.Sdk/Api/Platform/Operation//PublicCancelSubscription.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/history | GET | PublicGetUserSubscriptionBillingHistories | [PublicGetUserSubscriptionBillingHistories](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUserSubscriptionBillingHistories.cs) |

### Ticket Wrapper:  [Ticket](../AccelByte.Sdk/Api/Platform/Wrapper/Ticket.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/tickets/{boothName} | GET | GetTicketDynamic | [GetTicketDynamic](../AccelByte.Sdk/Api/Platform/Operation//GetTicketDynamic.cs) |
| /platform/admin/namespaces/{namespace}/tickets/{boothName}/decrement | PUT | DecreaseTicketSale | [DecreaseTicketSale](../AccelByte.Sdk/Api/Platform/Operation//DecreaseTicketSale.cs) |
| /platform/admin/namespaces/{namespace}/tickets/{boothName}/id | GET | GetTicketBoothID | [GetTicketBoothID](../AccelByte.Sdk/Api/Platform/Operation//GetTicketBoothID.cs) |
| /platform/admin/namespaces/{namespace}/tickets/{boothName}/increment | PUT | IncreaseTicketSale | [IncreaseTicketSale](../AccelByte.Sdk/Api/Platform/Operation//IncreaseTicketSale.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/tickets/{boothName} | POST | AcquireUserTicket | [AcquireUserTicket](../AccelByte.Sdk/Api/Platform/Operation//AcquireUserTicket.cs) |

### Anonymization Wrapper:  [Anonymization](../AccelByte.Sdk/Api/Platform/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/campaign | DELETE | AnonymizeCampaign | [AnonymizeCampaign](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeCampaign.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/entitlements | DELETE | AnonymizeEntitlement | [AnonymizeEntitlement](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeEntitlement.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/fulfillment | DELETE | AnonymizeFulfillment | [AnonymizeFulfillment](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeFulfillment.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/integrations | DELETE | AnonymizeIntegration | [AnonymizeIntegration](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeIntegration.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/orders | DELETE | AnonymizeOrder | [AnonymizeOrder](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeOrder.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/payment | DELETE | AnonymizePayment | [AnonymizePayment](../AccelByte.Sdk/Api/Platform/Operation//AnonymizePayment.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/subscriptions | DELETE | AnonymizeSubscription | [AnonymizeSubscription](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeSubscription.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/wallets | DELETE | AnonymizeWallet | [AnonymizeWallet](../AccelByte.Sdk/Api/Platform/Operation//AnonymizeWallet.cs) |

### Wallet Wrapper:  [Wallet](../AccelByte.Sdk/Api/Platform/Wrapper/Wallet.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/check | GET | CheckWallet | [CheckWallet](../AccelByte.Sdk/Api/Platform/Operation//CheckWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/credit | PUT | CreditUserWallet | [CreditUserWallet](../AccelByte.Sdk/Api/Platform/Operation//CreditUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment | PUT | PayWithUserWallet | [PayWithUserWallet](../AccelByte.Sdk/Api/Platform/Operation//PayWithUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId} | GET | GetUserWallet | [GetUserWallet](../AccelByte.Sdk/Api/Platform/Operation//GetUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/debit | PUT | DebitUserWallet | [DebitUserWallet](../AccelByte.Sdk/Api/Platform/Operation//DebitUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/disable | PUT | DisableUserWallet | [DisableUserWallet](../AccelByte.Sdk/Api/Platform/Operation//DisableUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/enable | PUT | EnableUserWallet | [EnableUserWallet](../AccelByte.Sdk/Api/Platform/Operation//EnableUserWallet.cs) |
| /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{walletId}/transactions | GET | ListUserWalletTransactions | [ListUserWalletTransactions](../AccelByte.Sdk/Api/Platform/Operation//ListUserWalletTransactions.cs) |
| /platform/admin/namespaces/{namespace}/wallets | GET | QueryWallets | [QueryWallets](../AccelByte.Sdk/Api/Platform/Operation//QueryWallets.cs) |
| /platform/admin/namespaces/{namespace}/wallets/{walletId} | GET | GetWallet | [GetWallet](../AccelByte.Sdk/Api/Platform/Operation//GetWallet.cs) |
| /platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode} | GET | PublicGetMyWallet | [PublicGetMyWallet](../AccelByte.Sdk/Api/Platform/Operation//PublicGetMyWallet.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode} | GET | PublicGetWallet | [PublicGetWallet](../AccelByte.Sdk/Api/Platform/Operation//PublicGetWallet.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/transactions | GET | PublicListUserWalletTransactions | [PublicListUserWalletTransactions](../AccelByte.Sdk/Api/Platform/Operation//PublicListUserWalletTransactions.cs) |

### Order(Dedicated) Wrapper:  [OrderDedicated](../AccelByte.Sdk/Api/Platform/Wrapper/OrderDedicated.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/orders | GET | SyncOrders | [SyncOrders](../AccelByte.Sdk/Api/Platform/Operation//SyncOrders.cs) |

### PaymentConfig Wrapper:  [PaymentConfig](../AccelByte.Sdk/Api/Platform/Wrapper/PaymentConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/admin/payment/config/merchant/adyenconfig/test | POST | TestAdyenConfig | [TestAdyenConfig](../AccelByte.Sdk/Api/Platform/Operation//TestAdyenConfig.cs) |
| /platform/admin/payment/config/merchant/alipayconfig/test | POST | TestAliPayConfig | [TestAliPayConfig](../AccelByte.Sdk/Api/Platform/Operation//TestAliPayConfig.cs) |
| /platform/admin/payment/config/merchant/checkoutconfig/test | POST | TestCheckoutConfig | [TestCheckoutConfig](../AccelByte.Sdk/Api/Platform/Operation//TestCheckoutConfig.cs) |
| /platform/admin/payment/config/merchant/matched | GET | DebugMatchedPaymentMerchantConfig | [DebugMatchedPaymentMerchantConfig](../AccelByte.Sdk/Api/Platform/Operation//DebugMatchedPaymentMerchantConfig.cs) |
| /platform/admin/payment/config/merchant/paypalconfig/test | POST | TestPayPalConfig | [TestPayPalConfig](../AccelByte.Sdk/Api/Platform/Operation//TestPayPalConfig.cs) |
| /platform/admin/payment/config/merchant/stripeconfig/test | POST | TestStripeConfig | [TestStripeConfig](../AccelByte.Sdk/Api/Platform/Operation//TestStripeConfig.cs) |
| /platform/admin/payment/config/merchant/wxpayconfig/test | POST | TestWxPayConfig | [TestWxPayConfig](../AccelByte.Sdk/Api/Platform/Operation//TestWxPayConfig.cs) |
| /platform/admin/payment/config/merchant/xsollaconfig/test | POST | TestXsollaConfig | [TestXsollaConfig](../AccelByte.Sdk/Api/Platform/Operation//TestXsollaConfig.cs) |
| /platform/admin/payment/config/merchant/{id} | GET | GetPaymentMerchantConfig | [GetPaymentMerchantConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentMerchantConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/adyenconfig | PUT | UpdateAdyenConfig | [UpdateAdyenConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateAdyenConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/adyenconfig/test | GET | TestAdyenConfigById | [TestAdyenConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestAdyenConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/alipayconfig | PUT | UpdateAliPayConfig | [UpdateAliPayConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateAliPayConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/alipayconfig/test | GET | TestAliPayConfigById | [TestAliPayConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestAliPayConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/checkoutconfig | PUT | UpdateCheckoutConfig | [UpdateCheckoutConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateCheckoutConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/checkoutconfig/test | GET | TestCheckoutConfigById | [TestCheckoutConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestCheckoutConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/paypalconfig | PUT | UpdatePayPalConfig | [UpdatePayPalConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePayPalConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/paypalconfig/test | GET | TestPayPalConfigById | [TestPayPalConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestPayPalConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/stripeconfig | PUT | UpdateStripeConfig | [UpdateStripeConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateStripeConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/stripeconfig/test | GET | TestStripeConfigById | [TestStripeConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestStripeConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/wxpayconfig | PUT | UpdateWxPayConfig | [UpdateWxPayConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateWxPayConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/wxpayconfig/cert | PUT | UpdateWxPayConfigCert | [UpdateWxPayConfigCert](../AccelByte.Sdk/Api/Platform/Operation//UpdateWxPayConfigCert.cs) |
| /platform/admin/payment/config/merchant/{id}/wxpayconfig/test | GET | TestWxPayConfigById | [TestWxPayConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestWxPayConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/xsollaconfig | PUT | UpdateXsollaConfig | [UpdateXsollaConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateXsollaConfig.cs) |
| /platform/admin/payment/config/merchant/{id}/xsollaconfig/test | GET | TestXsollaConfigById | [TestXsollaConfigById](../AccelByte.Sdk/Api/Platform/Operation//TestXsollaConfigById.cs) |
| /platform/admin/payment/config/merchant/{id}/xsollauiconfig | PUT | UpdateXsollaUIConfig | [UpdateXsollaUIConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdateXsollaUIConfig.cs) |
| /platform/admin/payment/config/provider | GET | QueryPaymentProviderConfig | [QueryPaymentProviderConfig](../AccelByte.Sdk/Api/Platform/Operation//QueryPaymentProviderConfig.cs) |
| /platform/admin/payment/config/provider | POST | CreatePaymentProviderConfig | [CreatePaymentProviderConfig](../AccelByte.Sdk/Api/Platform/Operation//CreatePaymentProviderConfig.cs) |
| /platform/admin/payment/config/provider/aggregate | GET | GetAggregatePaymentProviders | [GetAggregatePaymentProviders](../AccelByte.Sdk/Api/Platform/Operation//GetAggregatePaymentProviders.cs) |
| /platform/admin/payment/config/provider/matched | GET | DebugMatchedPaymentProviderConfig | [DebugMatchedPaymentProviderConfig](../AccelByte.Sdk/Api/Platform/Operation//DebugMatchedPaymentProviderConfig.cs) |
| /platform/admin/payment/config/provider/special | GET | GetSpecialPaymentProviders | [GetSpecialPaymentProviders](../AccelByte.Sdk/Api/Platform/Operation//GetSpecialPaymentProviders.cs) |
| /platform/admin/payment/config/provider/{id} | PUT | UpdatePaymentProviderConfig | [UpdatePaymentProviderConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePaymentProviderConfig.cs) |
| /platform/admin/payment/config/provider/{id} | DELETE | DeletePaymentProviderConfig | [DeletePaymentProviderConfig](../AccelByte.Sdk/Api/Platform/Operation//DeletePaymentProviderConfig.cs) |
| /platform/admin/payment/config/tax | GET | GetPaymentTaxConfig | [GetPaymentTaxConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentTaxConfig.cs) |
| /platform/admin/payment/config/tax | PUT | UpdatePaymentTaxConfig | [UpdatePaymentTaxConfig](../AccelByte.Sdk/Api/Platform/Operation//UpdatePaymentTaxConfig.cs) |

### PaymentStation Wrapper:  [PaymentStation](../AccelByte.Sdk/Api/Platform/Wrapper/PaymentStation.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/public/namespaces/{namespace}/payment/customization | GET | GetPaymentCustomization | [GetPaymentCustomization](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentCustomization.cs) |
| /platform/public/namespaces/{namespace}/payment/link | POST | PublicGetPaymentUrl | [PublicGetPaymentUrl](../AccelByte.Sdk/Api/Platform/Operation//PublicGetPaymentUrl.cs) |
| /platform/public/namespaces/{namespace}/payment/methods | GET | PublicGetPaymentMethods | [PublicGetPaymentMethods](../AccelByte.Sdk/Api/Platform/Operation//PublicGetPaymentMethods.cs) |
| /platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/info | GET | PublicGetUnpaidPaymentOrder | [PublicGetUnpaidPaymentOrder](../AccelByte.Sdk/Api/Platform/Operation//PublicGetUnpaidPaymentOrder.cs) |
| /platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/pay | POST | Pay | [Pay](../AccelByte.Sdk/Api/Platform/Operation//Pay.cs) |
| /platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/status | GET | PublicCheckPaymentOrderPaidStatus | [PublicCheckPaymentOrderPaidStatus](../AccelByte.Sdk/Api/Platform/Operation//PublicCheckPaymentOrderPaidStatus.cs) |
| /platform/public/namespaces/{namespace}/payment/publicconfig | GET | GetPaymentPublicConfig | [GetPaymentPublicConfig](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentPublicConfig.cs) |
| /platform/public/namespaces/{namespace}/payment/qrcode | GET | PublicGetQRCode | [PublicGetQRCode](../AccelByte.Sdk/Api/Platform/Operation//PublicGetQRCode.cs) |
| /platform/public/namespaces/{namespace}/payment/returnurl | GET | PublicNormalizePaymentReturnUrl | [PublicNormalizePaymentReturnUrl](../AccelByte.Sdk/Api/Platform/Operation//PublicNormalizePaymentReturnUrl.cs) |
| /platform/public/namespaces/{namespace}/payment/tax | GET | GetPaymentTaxValue | [GetPaymentTaxValue](../AccelByte.Sdk/Api/Platform/Operation//GetPaymentTaxValue.cs) |

### PaymentAccount Wrapper:  [PaymentAccount](../AccelByte.Sdk/Api/Platform/Wrapper/PaymentAccount.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /platform/public/namespaces/{namespace}/users/{userId}/payment/accounts | GET | PublicGetPaymentAccounts | [PublicGetPaymentAccounts](../AccelByte.Sdk/Api/Platform/Operation//PublicGetPaymentAccounts.cs) |
| /platform/public/namespaces/{namespace}/users/{userId}/payment/accounts/{type}/{id} | DELETE | PublicDeletePaymentAccount | [PublicDeletePaymentAccount](../AccelByte.Sdk/Api/Platform/Operation//PublicDeletePaymentAccount.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| AdditionalData | [AdditionalData](../AccelByte.Sdk/Api/Platform/Model/AdditionalData.cs) |
| AdyenConfig | [AdyenConfig](../AccelByte.Sdk/Api/Platform/Model/AdyenConfig.cs) |
| AliPayConfig | [AliPayConfig](../AccelByte.Sdk/Api/Platform/Model/AliPayConfig.cs) |
| AppEntitlementInfo | [AppEntitlementInfo](../AccelByte.Sdk/Api/Platform/Model/AppEntitlementInfo.cs) |
| AppEntitlementPagingSlicedResult | [AppEntitlementPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/AppEntitlementPagingSlicedResult.cs) |
| AppInfo | [AppInfo](../AccelByte.Sdk/Api/Platform/Model/AppInfo.cs) |
| AppLocalization | [AppLocalization](../AccelByte.Sdk/Api/Platform/Model/AppLocalization.cs) |
| AppUpdate | [AppUpdate](../AccelByte.Sdk/Api/Platform/Model/AppUpdate.cs) |
| AppleIAPConfigInfo | [AppleIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/AppleIAPConfigInfo.cs) |
| AppleIAPConfigRequest | [AppleIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/AppleIAPConfigRequest.cs) |
| AppleIAPReceipt | [AppleIAPReceipt](../AccelByte.Sdk/Api/Platform/Model/AppleIAPReceipt.cs) |
| BasicCategoryInfo | [BasicCategoryInfo](../AccelByte.Sdk/Api/Platform/Model/BasicCategoryInfo.cs) |
| BasicItem | [BasicItem](../AccelByte.Sdk/Api/Platform/Model/BasicItem.cs) |
| BillingAccount | [BillingAccount](../AccelByte.Sdk/Api/Platform/Model/BillingAccount.cs) |
| BillingHistoryInfo | [BillingHistoryInfo](../AccelByte.Sdk/Api/Platform/Model/BillingHistoryInfo.cs) |
| BillingHistoryPagingSlicedResult | [BillingHistoryPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/BillingHistoryPagingSlicedResult.cs) |
| BulkOperationResult | [BulkOperationResult](../AccelByte.Sdk/Api/Platform/Model/BulkOperationResult.cs) |
| BundledItemInfo | [BundledItemInfo](../AccelByte.Sdk/Api/Platform/Model/BundledItemInfo.cs) |
| CampaignCreate | [CampaignCreate](../AccelByte.Sdk/Api/Platform/Model/CampaignCreate.cs) |
| CampaignDynamicInfo | [CampaignDynamicInfo](../AccelByte.Sdk/Api/Platform/Model/CampaignDynamicInfo.cs) |
| CampaignInfo | [CampaignInfo](../AccelByte.Sdk/Api/Platform/Model/CampaignInfo.cs) |
| CampaignPagingSlicedResult | [CampaignPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/CampaignPagingSlicedResult.cs) |
| CampaignUpdate | [CampaignUpdate](../AccelByte.Sdk/Api/Platform/Model/CampaignUpdate.cs) |
| CancelRequest | [CancelRequest](../AccelByte.Sdk/Api/Platform/Model/CancelRequest.cs) |
| CategoryCreate | [CategoryCreate](../AccelByte.Sdk/Api/Platform/Model/CategoryCreate.cs) |
| CategoryInfo | [CategoryInfo](../AccelByte.Sdk/Api/Platform/Model/CategoryInfo.cs) |
| CategoryUpdate | [CategoryUpdate](../AccelByte.Sdk/Api/Platform/Model/CategoryUpdate.cs) |
| CheckoutConfig | [CheckoutConfig](../AccelByte.Sdk/Api/Platform/Model/CheckoutConfig.cs) |
| CodeCreate | [CodeCreate](../AccelByte.Sdk/Api/Platform/Model/CodeCreate.cs) |
| CodeCreateResult | [CodeCreateResult](../AccelByte.Sdk/Api/Platform/Model/CodeCreateResult.cs) |
| CodeInfo | [CodeInfo](../AccelByte.Sdk/Api/Platform/Model/CodeInfo.cs) |
| CodeInfoPagingSlicedResult | [CodeInfoPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/CodeInfoPagingSlicedResult.cs) |
| ConditionMatchResult | [ConditionMatchResult](../AccelByte.Sdk/Api/Platform/Model/ConditionMatchResult.cs) |
| CreditRequest | [CreditRequest](../AccelByte.Sdk/Api/Platform/Model/CreditRequest.cs) |
| CreditSummary | [CreditSummary](../AccelByte.Sdk/Api/Platform/Model/CreditSummary.cs) |
| CurrencyConfig | [CurrencyConfig](../AccelByte.Sdk/Api/Platform/Model/CurrencyConfig.cs) |
| CurrencyCreate | [CurrencyCreate](../AccelByte.Sdk/Api/Platform/Model/CurrencyCreate.cs) |
| CurrencyInfo | [CurrencyInfo](../AccelByte.Sdk/Api/Platform/Model/CurrencyInfo.cs) |
| CurrencySummary | [CurrencySummary](../AccelByte.Sdk/Api/Platform/Model/CurrencySummary.cs) |
| CurrencyUpdate | [CurrencyUpdate](../AccelByte.Sdk/Api/Platform/Model/CurrencyUpdate.cs) |
| Customization | [Customization](../AccelByte.Sdk/Api/Platform/Model/Customization.cs) |
| DLCItem | [DLCItem](../AccelByte.Sdk/Api/Platform/Model/DLCItem.cs) |
| DLCItemConfigInfo | [DLCItemConfigInfo](../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigInfo.cs) |
| DLCItemConfigUpdate | [DLCItemConfigUpdate](../AccelByte.Sdk/Api/Platform/Model/DLCItemConfigUpdate.cs) |
| DebitRequest | [DebitRequest](../AccelByte.Sdk/Api/Platform/Model/DebitRequest.cs) |
| EntitlementDecrement | [EntitlementDecrement](../AccelByte.Sdk/Api/Platform/Model/EntitlementDecrement.cs) |
| EntitlementGrant | [EntitlementGrant](../AccelByte.Sdk/Api/Platform/Model/EntitlementGrant.cs) |
| EntitlementHistoryInfo | [EntitlementHistoryInfo](../AccelByte.Sdk/Api/Platform/Model/EntitlementHistoryInfo.cs) |
| EntitlementInfo | [EntitlementInfo](../AccelByte.Sdk/Api/Platform/Model/EntitlementInfo.cs) |
| EntitlementPagingSlicedResult | [EntitlementPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/EntitlementPagingSlicedResult.cs) |
| EntitlementSummary | [EntitlementSummary](../AccelByte.Sdk/Api/Platform/Model/EntitlementSummary.cs) |
| EntitlementUpdate | [EntitlementUpdate](../AccelByte.Sdk/Api/Platform/Model/EntitlementUpdate.cs) |
| EpicGamesIAPConfigInfo | [EpicGamesIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/EpicGamesIAPConfigInfo.cs) |
| EpicGamesIAPConfigRequest | [EpicGamesIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/EpicGamesIAPConfigRequest.cs) |
| EpicGamesReconcileRequest | [EpicGamesReconcileRequest](../AccelByte.Sdk/Api/Platform/Model/EpicGamesReconcileRequest.cs) |
| EpicGamesReconcileResult | [EpicGamesReconcileResult](../AccelByte.Sdk/Api/Platform/Model/EpicGamesReconcileResult.cs) |
| ErrorEntity | [ErrorEntity](../AccelByte.Sdk/Api/Platform/Model/ErrorEntity.cs) |
| EventPayload | [EventPayload](../AccelByte.Sdk/Api/Platform/Model/EventPayload.cs) |
| ExternalPaymentOrderCreate | [ExternalPaymentOrderCreate](../AccelByte.Sdk/Api/Platform/Model/ExternalPaymentOrderCreate.cs) |
| FieldValidationError | [FieldValidationError](../AccelByte.Sdk/Api/Platform/Model/FieldValidationError.cs) |
| FulfillCodeRequest | [FulfillCodeRequest](../AccelByte.Sdk/Api/Platform/Model/FulfillCodeRequest.cs) |
| FulfillmentError | [FulfillmentError](../AccelByte.Sdk/Api/Platform/Model/FulfillmentError.cs) |
| FulfillmentHistoryInfo | [FulfillmentHistoryInfo](../AccelByte.Sdk/Api/Platform/Model/FulfillmentHistoryInfo.cs) |
| FulfillmentHistoryPagingSlicedResult | [FulfillmentHistoryPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/FulfillmentHistoryPagingSlicedResult.cs) |
| FulfillmentItem | [FulfillmentItem](../AccelByte.Sdk/Api/Platform/Model/FulfillmentItem.cs) |
| FulfillmentRequest | [FulfillmentRequest](../AccelByte.Sdk/Api/Platform/Model/FulfillmentRequest.cs) |
| FulfillmentResult | [FulfillmentResult](../AccelByte.Sdk/Api/Platform/Model/FulfillmentResult.cs) |
| FulfillmentScriptContext | [FulfillmentScriptContext](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptContext.cs) |
| FulfillmentScriptCreate | [FulfillmentScriptCreate](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptCreate.cs) |
| FulfillmentScriptEvalTestRequest | [FulfillmentScriptEvalTestRequest](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptEvalTestRequest.cs) |
| FulfillmentScriptEvalTestResult | [FulfillmentScriptEvalTestResult](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptEvalTestResult.cs) |
| FulfillmentScriptInfo | [FulfillmentScriptInfo](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptInfo.cs) |
| FulfillmentScriptUpdate | [FulfillmentScriptUpdate](../AccelByte.Sdk/Api/Platform/Model/FulfillmentScriptUpdate.cs) |
| FullAppInfo | [FullAppInfo](../AccelByte.Sdk/Api/Platform/Model/FullAppInfo.cs) |
| FullCategoryInfo | [FullCategoryInfo](../AccelByte.Sdk/Api/Platform/Model/FullCategoryInfo.cs) |
| FullItemInfo | [FullItemInfo](../AccelByte.Sdk/Api/Platform/Model/FullItemInfo.cs) |
| FullItemPagingSlicedResult | [FullItemPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/FullItemPagingSlicedResult.cs) |
| GoogleIAPConfigInfo | [GoogleIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/GoogleIAPConfigInfo.cs) |
| GoogleIAPConfigRequest | [GoogleIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/GoogleIAPConfigRequest.cs) |
| GoogleIAPReceipt | [GoogleIAPReceipt](../AccelByte.Sdk/Api/Platform/Model/GoogleIAPReceipt.cs) |
| GoogleReceiptResolveResult | [GoogleReceiptResolveResult](../AccelByte.Sdk/Api/Platform/Model/GoogleReceiptResolveResult.cs) |
| GrantSubscriptionDaysRequest | [GrantSubscriptionDaysRequest](../AccelByte.Sdk/Api/Platform/Model/GrantSubscriptionDaysRequest.cs) |
| HierarchicalCategoryInfo | [HierarchicalCategoryInfo](../AccelByte.Sdk/Api/Platform/Model/HierarchicalCategoryInfo.cs) |
| IAPItemConfigInfo | [IAPItemConfigInfo](../AccelByte.Sdk/Api/Platform/Model/IAPItemConfigInfo.cs) |
| IAPItemConfigUpdate | [IAPItemConfigUpdate](../AccelByte.Sdk/Api/Platform/Model/IAPItemConfigUpdate.cs) |
| IAPItemEntry | [IAPItemEntry](../AccelByte.Sdk/Api/Platform/Model/IAPItemEntry.cs) |
| IAPOrderInfo | [IAPOrderInfo](../AccelByte.Sdk/Api/Platform/Model/IAPOrderInfo.cs) |
| IAPOrderPagingSlicedResult | [IAPOrderPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/IAPOrderPagingSlicedResult.cs) |
| Image | [Image](../AccelByte.Sdk/Api/Platform/Model/Image.cs) |
| InGameItemSync | [InGameItemSync](../AccelByte.Sdk/Api/Platform/Model/InGameItemSync.cs) |
| ItemAcquireRequest | [ItemAcquireRequest](../AccelByte.Sdk/Api/Platform/Model/ItemAcquireRequest.cs) |
| ItemAcquireResult | [ItemAcquireResult](../AccelByte.Sdk/Api/Platform/Model/ItemAcquireResult.cs) |
| ItemCreate | [ItemCreate](../AccelByte.Sdk/Api/Platform/Model/ItemCreate.cs) |
| ItemDynamicDataInfo | [ItemDynamicDataInfo](../AccelByte.Sdk/Api/Platform/Model/ItemDynamicDataInfo.cs) |
| ItemId | [ItemId](../AccelByte.Sdk/Api/Platform/Model/ItemId.cs) |
| ItemInfo | [ItemInfo](../AccelByte.Sdk/Api/Platform/Model/ItemInfo.cs) |
| ItemPagingSlicedResult | [ItemPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/ItemPagingSlicedResult.cs) |
| ItemReturnRequest | [ItemReturnRequest](../AccelByte.Sdk/Api/Platform/Model/ItemReturnRequest.cs) |
| ItemSnapshot | [ItemSnapshot](../AccelByte.Sdk/Api/Platform/Model/ItemSnapshot.cs) |
| ItemUpdate | [ItemUpdate](../AccelByte.Sdk/Api/Platform/Model/ItemUpdate.cs) |
| KeyGroupCreate | [KeyGroupCreate](../AccelByte.Sdk/Api/Platform/Model/KeyGroupCreate.cs) |
| KeyGroupDynamicInfo | [KeyGroupDynamicInfo](../AccelByte.Sdk/Api/Platform/Model/KeyGroupDynamicInfo.cs) |
| KeyGroupInfo | [KeyGroupInfo](../AccelByte.Sdk/Api/Platform/Model/KeyGroupInfo.cs) |
| KeyGroupPagingSlicedResult | [KeyGroupPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/KeyGroupPagingSlicedResult.cs) |
| KeyGroupUpdate | [KeyGroupUpdate](../AccelByte.Sdk/Api/Platform/Model/KeyGroupUpdate.cs) |
| KeyInfo | [KeyInfo](../AccelByte.Sdk/Api/Platform/Model/KeyInfo.cs) |
| KeyPagingSliceResult | [KeyPagingSliceResult](../AccelByte.Sdk/Api/Platform/Model/KeyPagingSliceResult.cs) |
| Localization | [Localization](../AccelByte.Sdk/Api/Platform/Model/Localization.cs) |
| MockIAPReceipt | [MockIAPReceipt](../AccelByte.Sdk/Api/Platform/Model/MockIAPReceipt.cs) |
| NotificationProcessResult | [NotificationProcessResult](../AccelByte.Sdk/Api/Platform/Model/NotificationProcessResult.cs) |
| Order | [Order](../AccelByte.Sdk/Api/Platform/Model/Order.cs) |
| OrderCreate | [OrderCreate](../AccelByte.Sdk/Api/Platform/Model/OrderCreate.cs) |
| OrderGrantInfo | [OrderGrantInfo](../AccelByte.Sdk/Api/Platform/Model/OrderGrantInfo.cs) |
| OrderHistoryInfo | [OrderHistoryInfo](../AccelByte.Sdk/Api/Platform/Model/OrderHistoryInfo.cs) |
| OrderInfo | [OrderInfo](../AccelByte.Sdk/Api/Platform/Model/OrderInfo.cs) |
| OrderPagingResult | [OrderPagingResult](../AccelByte.Sdk/Api/Platform/Model/OrderPagingResult.cs) |
| OrderPagingSlicedResult | [OrderPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/OrderPagingSlicedResult.cs) |
| OrderRefundCreate | [OrderRefundCreate](../AccelByte.Sdk/Api/Platform/Model/OrderRefundCreate.cs) |
| OrderStatistics | [OrderStatistics](../AccelByte.Sdk/Api/Platform/Model/OrderStatistics.cs) |
| OrderSummary | [OrderSummary](../AccelByte.Sdk/Api/Platform/Model/OrderSummary.cs) |
| OrderSyncResult | [OrderSyncResult](../AccelByte.Sdk/Api/Platform/Model/OrderSyncResult.cs) |
| OrderUpdate | [OrderUpdate](../AccelByte.Sdk/Api/Platform/Model/OrderUpdate.cs) |
| Ownership | [Ownership](../AccelByte.Sdk/Api/Platform/Model/Ownership.cs) |
| OwnershipToken | [OwnershipToken](../AccelByte.Sdk/Api/Platform/Model/OwnershipToken.cs) |
| Paging | [Paging](../AccelByte.Sdk/Api/Platform/Model/Paging.cs) |
| PayPalConfig | [PayPalConfig](../AccelByte.Sdk/Api/Platform/Model/PayPalConfig.cs) |
| PaymentAccount | [PaymentAccount](../AccelByte.Sdk/Api/Platform/Model/PaymentAccount.cs) |
| PaymentCallbackConfigInfo | [PaymentCallbackConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentCallbackConfigInfo.cs) |
| PaymentCallbackConfigUpdate | [PaymentCallbackConfigUpdate](../AccelByte.Sdk/Api/Platform/Model/PaymentCallbackConfigUpdate.cs) |
| PaymentMerchantConfigInfo | [PaymentMerchantConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentMerchantConfigInfo.cs) |
| PaymentMethod | [PaymentMethod](../AccelByte.Sdk/Api/Platform/Model/PaymentMethod.cs) |
| PaymentNotificationInfo | [PaymentNotificationInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentNotificationInfo.cs) |
| PaymentNotificationPagingSlicedResult | [PaymentNotificationPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/PaymentNotificationPagingSlicedResult.cs) |
| PaymentOrder | [PaymentOrder](../AccelByte.Sdk/Api/Platform/Model/PaymentOrder.cs) |
| PaymentOrderChargeRequest | [PaymentOrderChargeRequest](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderChargeRequest.cs) |
| PaymentOrderChargeStatus | [PaymentOrderChargeStatus](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderChargeStatus.cs) |
| PaymentOrderCreate | [PaymentOrderCreate](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderCreate.cs) |
| PaymentOrderCreateResult | [PaymentOrderCreateResult](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderCreateResult.cs) |
| PaymentOrderDetails | [PaymentOrderDetails](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderDetails.cs) |
| PaymentOrderInfo | [PaymentOrderInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderInfo.cs) |
| PaymentOrderNotifySimulation | [PaymentOrderNotifySimulation](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderNotifySimulation.cs) |
| PaymentOrderPagingSlicedResult | [PaymentOrderPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderPagingSlicedResult.cs) |
| PaymentOrderPaidResult | [PaymentOrderPaidResult](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderPaidResult.cs) |
| PaymentOrderRefund | [PaymentOrderRefund](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderRefund.cs) |
| PaymentOrderRefundResult | [PaymentOrderRefundResult](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderRefundResult.cs) |
| PaymentOrderSyncResult | [PaymentOrderSyncResult](../AccelByte.Sdk/Api/Platform/Model/PaymentOrderSyncResult.cs) |
| PaymentProcessResult | [PaymentProcessResult](../AccelByte.Sdk/Api/Platform/Model/PaymentProcessResult.cs) |
| PaymentProviderConfigEdit | [PaymentProviderConfigEdit](../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigEdit.cs) |
| PaymentProviderConfigInfo | [PaymentProviderConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigInfo.cs) |
| PaymentProviderConfigPagingSlicedResult | [PaymentProviderConfigPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/PaymentProviderConfigPagingSlicedResult.cs) |
| PaymentRequest | [PaymentRequest](../AccelByte.Sdk/Api/Platform/Model/PaymentRequest.cs) |
| PaymentTaxConfigEdit | [PaymentTaxConfigEdit](../AccelByte.Sdk/Api/Platform/Model/PaymentTaxConfigEdit.cs) |
| PaymentTaxConfigInfo | [PaymentTaxConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PaymentTaxConfigInfo.cs) |
| PaymentToken | [PaymentToken](../AccelByte.Sdk/Api/Platform/Model/PaymentToken.cs) |
| PaymentUrl | [PaymentUrl](../AccelByte.Sdk/Api/Platform/Model/PaymentUrl.cs) |
| PaymentUrlCreate | [PaymentUrlCreate](../AccelByte.Sdk/Api/Platform/Model/PaymentUrlCreate.cs) |
| PlatformDLCConfigInfo | [PlatformDLCConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PlatformDLCConfigInfo.cs) |
| PlatformDLCConfigUpdate | [PlatformDLCConfigUpdate](../AccelByte.Sdk/Api/Platform/Model/PlatformDLCConfigUpdate.cs) |
| PlatformDlcEntry | [PlatformDlcEntry](../AccelByte.Sdk/Api/Platform/Model/PlatformDlcEntry.cs) |
| PlatformReward | [PlatformReward](../AccelByte.Sdk/Api/Platform/Model/PlatformReward.cs) |
| PlatformRewardCurrency | [PlatformRewardCurrency](../AccelByte.Sdk/Api/Platform/Model/PlatformRewardCurrency.cs) |
| PlatformRewardItem | [PlatformRewardItem](../AccelByte.Sdk/Api/Platform/Model/PlatformRewardItem.cs) |
| PlatformSubscribeRequest | [PlatformSubscribeRequest](../AccelByte.Sdk/Api/Platform/Model/PlatformSubscribeRequest.cs) |
| PlayStationDLCSyncRequest | [PlayStationDLCSyncRequest](../AccelByte.Sdk/Api/Platform/Model/PlayStationDLCSyncRequest.cs) |
| PlayStationIAPConfigInfo | [PlayStationIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/PlayStationIAPConfigInfo.cs) |
| PlayStationReconcileRequest | [PlayStationReconcileRequest](../AccelByte.Sdk/Api/Platform/Model/PlayStationReconcileRequest.cs) |
| PlayStationReconcileResult | [PlayStationReconcileResult](../AccelByte.Sdk/Api/Platform/Model/PlayStationReconcileResult.cs) |
| PlaystationIAPConfigRequest | [PlaystationIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/PlaystationIAPConfigRequest.cs) |
| PopulatedItemInfo | [PopulatedItemInfo](../AccelByte.Sdk/Api/Platform/Model/PopulatedItemInfo.cs) |
| PurchasedItemCount | [PurchasedItemCount](../AccelByte.Sdk/Api/Platform/Model/PurchasedItemCount.cs) |
| Recurring | [Recurring](../AccelByte.Sdk/Api/Platform/Model/Recurring.cs) |
| RecurringChargeResult | [RecurringChargeResult](../AccelByte.Sdk/Api/Platform/Model/RecurringChargeResult.cs) |
| RedeemHistoryInfo | [RedeemHistoryInfo](../AccelByte.Sdk/Api/Platform/Model/RedeemHistoryInfo.cs) |
| RedeemHistoryPagingSlicedResult | [RedeemHistoryPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/RedeemHistoryPagingSlicedResult.cs) |
| RedeemRequest | [RedeemRequest](../AccelByte.Sdk/Api/Platform/Model/RedeemRequest.cs) |
| RedeemResult | [RedeemResult](../AccelByte.Sdk/Api/Platform/Model/RedeemResult.cs) |
| RedeemableItem | [RedeemableItem](../AccelByte.Sdk/Api/Platform/Model/RedeemableItem.cs) |
| RegionDataItem | [RegionDataItem](../AccelByte.Sdk/Api/Platform/Model/RegionDataItem.cs) |
| Requirement | [Requirement](../AccelByte.Sdk/Api/Platform/Model/Requirement.cs) |
| RewardCondition | [RewardCondition](../AccelByte.Sdk/Api/Platform/Model/RewardCondition.cs) |
| RewardCreate | [RewardCreate](../AccelByte.Sdk/Api/Platform/Model/RewardCreate.cs) |
| RewardInfo | [RewardInfo](../AccelByte.Sdk/Api/Platform/Model/RewardInfo.cs) |
| RewardItem | [RewardItem](../AccelByte.Sdk/Api/Platform/Model/RewardItem.cs) |
| RewardPagingSlicedResult | [RewardPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/RewardPagingSlicedResult.cs) |
| RewardUpdate | [RewardUpdate](../AccelByte.Sdk/Api/Platform/Model/RewardUpdate.cs) |
| RewardsRequest | [RewardsRequest](../AccelByte.Sdk/Api/Platform/Model/RewardsRequest.cs) |
| Slide | [Slide](../AccelByte.Sdk/Api/Platform/Model/Slide.cs) |
| StackableEntitlementInfo | [StackableEntitlementInfo](../AccelByte.Sdk/Api/Platform/Model/StackableEntitlementInfo.cs) |
| StadiaIAPConfigInfo | [StadiaIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/StadiaIAPConfigInfo.cs) |
| StadiaSyncRequest | [StadiaSyncRequest](../AccelByte.Sdk/Api/Platform/Model/StadiaSyncRequest.cs) |
| SteamDLCSyncRequest | [SteamDLCSyncRequest](../AccelByte.Sdk/Api/Platform/Model/SteamDLCSyncRequest.cs) |
| SteamIAPConfig | [SteamIAPConfig](../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfig.cs) |
| SteamIAPConfigInfo | [SteamIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfigInfo.cs) |
| SteamIAPConfigRequest | [SteamIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/SteamIAPConfigRequest.cs) |
| SteamSyncRequest | [SteamSyncRequest](../AccelByte.Sdk/Api/Platform/Model/SteamSyncRequest.cs) |
| StoreBackupInfo | [StoreBackupInfo](../AccelByte.Sdk/Api/Platform/Model/StoreBackupInfo.cs) |
| StoreCreate | [StoreCreate](../AccelByte.Sdk/Api/Platform/Model/StoreCreate.cs) |
| StoreInfo | [StoreInfo](../AccelByte.Sdk/Api/Platform/Model/StoreInfo.cs) |
| StoreUpdate | [StoreUpdate](../AccelByte.Sdk/Api/Platform/Model/StoreUpdate.cs) |
| StripeConfig | [StripeConfig](../AccelByte.Sdk/Api/Platform/Model/StripeConfig.cs) |
| Subscribable | [Subscribable](../AccelByte.Sdk/Api/Platform/Model/Subscribable.cs) |
| SubscribeRequest | [SubscribeRequest](../AccelByte.Sdk/Api/Platform/Model/SubscribeRequest.cs) |
| SubscriptionActivityInfo | [SubscriptionActivityInfo](../AccelByte.Sdk/Api/Platform/Model/SubscriptionActivityInfo.cs) |
| SubscriptionActivityPagingSlicedResult | [SubscriptionActivityPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/SubscriptionActivityPagingSlicedResult.cs) |
| SubscriptionInfo | [SubscriptionInfo](../AccelByte.Sdk/Api/Platform/Model/SubscriptionInfo.cs) |
| SubscriptionPagingSlicedResult | [SubscriptionPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/SubscriptionPagingSlicedResult.cs) |
| SubscriptionSummary | [SubscriptionSummary](../AccelByte.Sdk/Api/Platform/Model/SubscriptionSummary.cs) |
| TaxResult | [TaxResult](../AccelByte.Sdk/Api/Platform/Model/TaxResult.cs) |
| TestResult | [TestResult](../AccelByte.Sdk/Api/Platform/Model/TestResult.cs) |
| TicketAcquireRequest | [TicketAcquireRequest](../AccelByte.Sdk/Api/Platform/Model/TicketAcquireRequest.cs) |
| TicketAcquireResult | [TicketAcquireResult](../AccelByte.Sdk/Api/Platform/Model/TicketAcquireResult.cs) |
| TicketBoothID | [TicketBoothID](../AccelByte.Sdk/Api/Platform/Model/TicketBoothID.cs) |
| TicketDynamicInfo | [TicketDynamicInfo](../AccelByte.Sdk/Api/Platform/Model/TicketDynamicInfo.cs) |
| TicketSaleDecrementRequest | [TicketSaleDecrementRequest](../AccelByte.Sdk/Api/Platform/Model/TicketSaleDecrementRequest.cs) |
| TicketSaleIncrementRequest | [TicketSaleIncrementRequest](../AccelByte.Sdk/Api/Platform/Model/TicketSaleIncrementRequest.cs) |
| TicketSaleIncrementResult | [TicketSaleIncrementResult](../AccelByte.Sdk/Api/Platform/Model/TicketSaleIncrementResult.cs) |
| TimedOwnership | [TimedOwnership](../AccelByte.Sdk/Api/Platform/Model/TimedOwnership.cs) |
| TradeNotification | [TradeNotification](../AccelByte.Sdk/Api/Platform/Model/TradeNotification.cs) |
| Transaction | [Transaction](../AccelByte.Sdk/Api/Platform/Model/Transaction.cs) |
| TwitchIAPConfigInfo | [TwitchIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/TwitchIAPConfigInfo.cs) |
| TwitchIAPConfigRequest | [TwitchIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/TwitchIAPConfigRequest.cs) |
| TwitchSyncRequest | [TwitchSyncRequest](../AccelByte.Sdk/Api/Platform/Model/TwitchSyncRequest.cs) |
| ValidationErrorEntity | [ValidationErrorEntity](../AccelByte.Sdk/Api/Platform/Model/ValidationErrorEntity.cs) |
| WalletInfo | [WalletInfo](../AccelByte.Sdk/Api/Platform/Model/WalletInfo.cs) |
| WalletPagingSlicedResult | [WalletPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/WalletPagingSlicedResult.cs) |
| WalletTransactionInfo | [WalletTransactionInfo](../AccelByte.Sdk/Api/Platform/Model/WalletTransactionInfo.cs) |
| WalletTransactionPagingSlicedResult | [WalletTransactionPagingSlicedResult](../AccelByte.Sdk/Api/Platform/Model/WalletTransactionPagingSlicedResult.cs) |
| WxPayConfigInfo | [WxPayConfigInfo](../AccelByte.Sdk/Api/Platform/Model/WxPayConfigInfo.cs) |
| WxPayConfigRequest | [WxPayConfigRequest](../AccelByte.Sdk/Api/Platform/Model/WxPayConfigRequest.cs) |
| XblDLCSyncRequest | [XblDLCSyncRequest](../AccelByte.Sdk/Api/Platform/Model/XblDLCSyncRequest.cs) |
| XblIAPConfigInfo | [XblIAPConfigInfo](../AccelByte.Sdk/Api/Platform/Model/XblIAPConfigInfo.cs) |
| XblIAPConfigRequest | [XblIAPConfigRequest](../AccelByte.Sdk/Api/Platform/Model/XblIAPConfigRequest.cs) |
| XblReconcileRequest | [XblReconcileRequest](../AccelByte.Sdk/Api/Platform/Model/XblReconcileRequest.cs) |
| XblReconcileResult | [XblReconcileResult](../AccelByte.Sdk/Api/Platform/Model/XblReconcileResult.cs) |
| XsollaConfig | [XsollaConfig](../AccelByte.Sdk/Api/Platform/Model/XsollaConfig.cs) |
| XsollaPaywallConfig | [XsollaPaywallConfig](../AccelByte.Sdk/Api/Platform/Model/XsollaPaywallConfig.cs) |
| XsollaPaywallConfigRequest | [XsollaPaywallConfigRequest](../AccelByte.Sdk/Api/Platform/Model/XsollaPaywallConfigRequest.cs) |
