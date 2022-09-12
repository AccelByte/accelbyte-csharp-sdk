# C# Server SDK v0.17.0

## cloudsave Service

### What's New
---
* `POST` /cloudsave/v1/admin/namespaces/{namespace}/users/bulk/records/size Bulk get player records size
* `GET` /cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/size Get player record size

## dsmc Service

### What's New
---
* `GET` /dsmcontroller/namespaces/{namespace}/images/limit DS Image Limit for Client

### What's Changed
---
`GET` /dsmcontroller/admin/namespaces/{namespace}/images/limit DS Image Limit  
    Return Type

        Insert data.non_persistent_image_used_in_deployment_number

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.
        Modify endTime //End time of data to be queried. Default: Current time in UTC.

## iam Service

### What's New
---
* `PATCH` /iam/v3/admin/namespaces/{namespace}/bans/users/disabled Bulk unban user
* `PUT` /iam/v3/admin/namespaces/{namespace}/users/{userId}/password Update User Password
* `POST` /iam/v3/namespace/{namespace}/token/request Request code to get game token
* `GET` /iam/v3/public/namespaces/{namespace}/agerestrictions/countries/{countryCode} Public get age restriction by country code
* `GET` /iam/v3/public/namespaces/{namespace}/users/{userId}/platforms/justice Get User Justice Platform Accounts
* `POST` /iam/v3/token/exchange Generate game token by code
* `POST` /iam/v3/admin/namespaces/{namespace}/bans/users Bulk ban user

### What's Changed
---
`GET` /iam/v2/public/namespaces/{namespace}/countries/{countryCode}/agerestrictions Public get age restriction by country code  
    Return Type

        Insert Namespace
`GET` /iam/v3/admin/inputValidations Admin Get Input Validations  
    Return Type

        Insert data.validation.blockedWord
`PUT` /iam/v3/admin/inputValidations Admin Update Input Validations  
    Parameters

        Insert body.validation.blockedWord
`POST` /iam/v3/admin/namespaces/{namespace}/users/{userId}/headless/code/verify Verify or consume verification code.   
    Parameters

        Modify body.validateOnly
`POST` /iam/v3/authenticateWithLink Authentication with platform link  
    Return Type

        Modify display_name
        Modify refresh_expires_in
        Modify refresh_token
        Modify user_id
        Modify xuid
`POST` /iam/v3/headless/token Create headless account and response token  
    Return Type

        Modify display_name
        Modify refresh_expires_in
        Modify refresh_token
        Modify user_id
        Modify xuid
`POST` /iam/v3/oauth/mfa/verify Verify 2FA code  
    Return Type

        Modify display_name
        Modify refresh_expires_in
        Modify refresh_token
        Modify user_id
        Modify xuid
`POST` /iam/v3/oauth/token OAuth2 access token generation endpoint  
    Return Type

        Modify display_name
        Modify refresh_expires_in
        Modify refresh_token
        Modify user_id
        Modify xuid
`POST` /iam/v3/oauth/verify OAuth2 token verification API  
    Return Type

        Modify display_name
        Modify refresh_expires_in
        Modify refresh_token
        Modify user_id
        Modify xuid
`GET` /iam/v3/public/inputValidations Public Get Input Validations  
    Return Type

        Insert data.validation.blockedWord
`POST` /iam/v3/public/namespaces/{namespace}/users/me/code/verify Validate or consume verification code sent to user  
    Parameters

        Modify body.languageTag
        Modify body.validateOnly
`POST` /iam/v3/public/namespaces/{namespace}/users/me/headless/code/verify Verify or consume verification code.  
    Parameters

        Modify body.validateOnly
`POST` /iam/v4/admin/users/me/mfa/backupCode Generate backup codes  
    Return Type

        Modify invalidCodes
`GET` /iam/v4/admin/users/me/mfa/backupCode Get backup codes  
    Return Type

        Modify invalidCodes
`POST` /iam/v4/admin/users/me/mfa/backupCode/enable Enable 2FA backup codes  
    Return Type

        Modify invalidCodes
`POST` /iam/v4/public/namespaces/{namespace}/users Create User  
    Parameters

        Modify body.code
        Modify body.displayName
        Modify body.password
        Modify body.passwordMD5Sum
        Modify body.reachMinimumAge
`POST` /iam/v4/public/namespaces/{namespace}/users/me/headless/code/verify Upgrade headless account and automatically verified the email address if it is succeeded  
    Parameters

        Modify body.reachMinimumAge
        Modify body.validateOnly
`POST` /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode Generate backup codes  
    Return Type

        Modify invalidCodes
`GET` /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode Get backup codes  
    Return Type

        Modify invalidCodes
`POST` /iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/enable Enable 2FA backup codes  
    Return Type

        Modify invalidCodes

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/invoice/details.csv Download invoice details
* `GET` /platform/admin/namespaces/{namespace}/invoice/summary Generate invoice summary

# C# Server SDK v0.16.0

## achievement Service

### What's New
---
* `DELETE` /achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements/{achievementCode}/reset Reset an achievement

## dsmc Service

### What's Changed
---
`GET` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments Get All Deployments  
    Return Type

        Insert deployments.unlimited
`GET` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Get Deployment  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Update deployment  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Create deployment  
    Parameters

        Insert body.unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Delete Region Override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Update region override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Create region override  
    Parameters

        Insert body.unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version} Create deployment override  
    Parameters

        Insert body.unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} Delete Deployment Override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} Update deployment override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Delete region override for deployment override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Update region override for deployment override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Create region override for deployment override  
    Parameters

        Insert body.unlimited
`GET` /dsmcontroller/admin/v1/namespaces/{namespace}/configs/export export DSM Controller configuration for a namespace  
    Return Type

        Insert deployments.unlimited

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## iam Service

### What's New
---
* `POST` /iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/force Force linking user's account with platform
* `GET` /iam/v3/public/namespaces/{namespace}/users/{userId}/information Get user's information v3
* `POST` /iam/v3/public/users/me/verify_link/request Send verification link to user, this link will point to '/iam/v3/public/users/verify_link/verify'
* `GET` /iam/v3/public/users/verify_link/verify Verify user email by the verification link code
* `GET` /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/justice/{targetNamespace} Get user mapping

## matchmaking Service

### What's Changed
---
`POST` /matchmaking/namespaces/{namespace}/channels Create a channel  
    Parameters

        Insert body.rule_set.alliance.combination
        Insert body.rule_set.alliance_flexing_rule.combination
`GET` /matchmaking/namespaces/{namespace}/channels Get all channels  
    Return Type

        Insert data.ruleset.alliance.combination
        Insert data.ruleset.alliance_flexing_rule.combination
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/export Export channels  
    Return Type

        Insert ruleSet.alliance.combination
        Insert ruleSet.alliance_flexing_rule.combination
`PATCH` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName} Update a channel  
    Parameters

        Insert body.ruleSet.alliance.combination
        Insert body.ruleSet.alliance_flexing_rule.combination
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName} Get single channel  
    Return Type

        Insert ruleSet.alliance.combination
        Insert ruleSet.alliance_flexing_rule.combination
`GET` /matchmaking/v1/public/namespaces/{namespace}/channels Get all channels  
    Return Type

        Insert ruleSet.alliance.combination
        Insert ruleSet.alliance_flexing_rule.combination
`GET` /matchmaking/v1/public/namespaces/{namespace}/channels/{channelName} Get single channel  
    Return Type

        Insert ruleSet.alliance.combination
        Insert ruleSet.alliance_flexing_rule.combination

## platform Service

### What's New
---
* `GET` /platform/admin/items/configs Get all item type configs
* `POST` /platform/admin/items/configs Create an Item Type Config
* `GET` /platform/admin/items/configs/search Get an item type config
* `GET` /platform/admin/items/configs/{id} Get an item type config
* `PUT` /platform/admin/items/configs/{id} Update an Item Type Config
* `DELETE` /platform/admin/items/configs/{id} Delete an item type config
* `GET` /platform/v2/admin/namespaces/{namespace}/items/byCriteria Query items by criteria

### What's Changed
---
`POST` /platform/admin/fulfillment/scripts/tests/eval Test eval fulfillment script  
    Parameters

        Modify body.context.item.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/entitlements Query entitlements  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/entitlements/{entitlementId} Get entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/fulfillment/history Query fulfillment histories  
    Return Type

        Insert data.extensionFulfillmentSummaries //extension fulfillment granted
        Modify data.fulfillItems.itemType //item type
`POST` /platform/admin/namespaces/{namespace}/items Create an Item  
    Parameters

        Modify body.itemType //Item Type
`PUT` /platform/admin/namespaces/{namespace}/items Sync an in game item  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/byAppId Get item by appId  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Parameters

        Modify itemType
    Return Type

        Modify data.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/byFeatures/basic List basic items by features  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/bySku Get item by sku  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/bySku/locale Get an item by sku in locale  
    Return Type

        Modify itemType //Item type
        Modify items.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/search Search items by keyword  
    Parameters

        Modify itemType
    Return Type

        Modify data.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/uncategorized Query uncategorized items  
    Return Type

        Modify data.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId} Update an item  
    Parameters

        Modify body.itemType //Item Type
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/{itemId} Get an item  
    Return Type

        Modify itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/disable Disable an item  
    Return Type

        Modify itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/enable Enable an item  
    Return Type

        Modify itemType //Item type
`DELETE` /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} Defeature an item  
    Return Type

        Modify itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} Feature an item  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Modify itemType //Item type
        Modify items.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition Update item purchase condition  
    Return Type

        Modify itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/orders Query orders  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/orders/{orderNo} Get order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/orders/{orderNo}/refund Refund order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`POST` /platform/admin/namespaces/{namespace}/payment/orders Create payment order by dedicated server  
    Parameters

        Modify body.itemType //item type
`GET` /platform/admin/namespaces/{namespace}/payment/orders Query payment orders  
    Return Type

        Modify data.itemType //Order item type
`PUT` /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo} Charge payment order without payment flow  
    Return Type

        Modify itemType //Order item type
`GET` /platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo} Get payment order  
    Return Type

        Modify itemType //Order item type
`GET` /platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria Query catalog changes  
    Parameters

        Modify itemType
    Return Type

        Modify data.itemType //item type
`GET` /platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/statistics Get catalog changes statistics  
    Parameters

        Modify itemType
`GET` /platform/admin/namespaces/{namespace}/subscriptions Query subscriptions  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId Get user app entitlement by appId  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType Query app entitlements by appType  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId Get user entitlement by itemId  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku Get user entitlement by sku  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Update user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Get user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable Disable user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable Enable user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke Revoke user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/orders Query user orders  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} Update order status  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} Get an order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill Fulfill an order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`POST` /platform/admin/namespaces/{namespace}/users/{userId}/payment/orders Create payment order  
    Parameters

        Modify body.itemType //item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/payment/orders/{paymentOrderNo}/refund Refund payment order  
    Return Type

        Modify itemType //Order item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions Query user subscriptions  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`POST` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe Free subscribe by platform  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} Get user subscription  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel Cancel a subscription  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant Grant days to a subscription  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/admin/orders Sync orders  
    Return Type

        Modify orders.itemSnapshot.itemType //Item type
`GET` /platform/admin/payment/orders Sync payment orders  
    Return Type

        Modify paymentOrders.itemType
`GET` /platform/public/namespaces/{namespace}/items/byAppId Get item by appId  
    Return Type

        Modify itemType //Item type
`GET` /platform/public/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Parameters

        Modify itemType
    Return Type

        Modify data.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/items/bySku Get item by sku  
    Return Type

        Modify itemType //Item type
`GET` /platform/public/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Modify itemType //Item type
`GET` /platform/public/namespaces/{namespace}/items/search Search items by keyword  
    Parameters

        Modify itemType
    Return Type

        Modify data.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Modify itemType //Item type
        Modify items.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId Get user app entitlement by appId  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType Query app entitlements by appType  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId Get user entitlement by itemId  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku Get user entitlement by sku  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Get user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/orders Query user orders  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo} Get user order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel Cancel user order  
    Return Type

        Modify itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions Query user subscriptions  
    Return Type

        Modify data.itemSnapshot.itemType //Item type
`GET` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} Get user subscription  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount Request to change a subscription billing account  
    Return Type

        Modify itemSnapshot.itemType //Item type
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel Cancel a subscription  
    Return Type

        Modify itemSnapshot.itemType //Item type

## seasonpass Service

### What's New
---
* `GET` /seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/full Get a season full content

## ugc Service

### What's Changed
---
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search Search contents specific to a channel  
    Return Type

        Modify data.creatorName
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/contents Get user's generated contents  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/search Search contents  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.creatorName
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Return Type

        Modify creatorName
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Modify data.creatorName
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide Hide/Unhide user's generated contents  
    Return Type

        Modify creatorName
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents Search contents specific to a channel  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/contents Search contents  
    Return Type

        Modify data.creatorName
`POST` /ugc/v1/public/namespaces/{namespace}/contents/bulk Get contents by content Ids   
    Return Type

        Modify creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/contents/followed Get contents from followed creators  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/contents/liked Get liked contents  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Modify creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Modify creatorName
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Return Type

        Modify creatorName
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Modify creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Modify data.creatorName
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.creatorName

# C# Server SDK v0.15.0

## dsmc Service

### What's Changed
---
`POST` /dsmcontroller/admin/images Create image  
    Parameters

        Insert body.imageSize
`POST` /dsmcontroller/admin/images/patches Create image patch  
    Parameters

        Insert body.imageSize
`GET` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments Get All Deployments  
    Return Type

        Insert deployments.unlimited
`GET` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Get Deployment  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Update deployment  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} Create deployment  
    Parameters

        Insert body.unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Delete Region Override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Update region override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} Create region override  
    Parameters

        Insert body.unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version} Create deployment override  
    Parameters

        Insert body.unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} Delete Deployment Override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} Update deployment override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`DELETE` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Delete region override for deployment override  
    Return Type

        Insert unlimited
`PATCH` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Update region override for deployment override  
    Parameters

        Insert body.unlimited
    Return Type

        Insert unlimited
`POST` /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} Create region override for deployment override  
    Parameters

        Insert body.unlimited
`GET` /dsmcontroller/admin/namespaces/{namespace}/images List all DS images  
    Return Type

        Insert images.imageSize
`GET` /dsmcontroller/admin/namespaces/{namespace}/images/export export DSM Controller images for a namespace  
    Return Type

        Insert imageSize
`GET` /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version} DS Image Detail  
    Return Type

        Insert data.imageSize
`GET` /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches Get All Image Patches by Version  
    Return Type

        Insert images.imageSize
`GET` /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches/{versionPatch} DS Image patch Detail  
    Return Type

        Insert data.imageSize
`GET` /dsmcontroller/admin/v1/namespaces/{namespace}/configs/export export DSM Controller configuration for a namespace  
    Return Type

        Insert deployments.unlimited
        Insert images.imageSize
`GET` /dsmcontroller/namespaces/{namespace}/images/versions/{version} DS Image Detail Client  
    Return Type

        Insert data.imageSize

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## group Service

### What's Changed
---
`DELETE` /group/v1/public/namespaces/{namespace}/roles/{memberRoleId}/members Remove role from group member  
    Return Type

        Delete memberRoleId
        Delete memberRoleName
        Delete memberRolePermissions

## iam Service

### What's New
---
* `GET` /iam/v3/public/namespaces/{namespace}/users/{userId}/publisher Get Publisher User
* `POST` /iam/v4/admin/namespaces/{namespace}/test_users [TEST FACILITY ONLY]Create test Users

### What's Changed
---
`GET` /iam/v3/admin/namespaces/{namespace}/users/platforms/justice Admin List Users V3  
    Return Type

        Insert data.linkedPlatforms.platformId
`GET` /iam/v3/public/namespaces/{namespace}/requests/{requestId}/async/status Get Linking Progress Status  
    Return Type

        Insert error.messageVariables.publisherAccounts.linkedPlatforms.platformId

## lobby Service

### What's Changed
---
`GET` /lobby/v1/admin/config admin get all namespaces config  
    Return Type

        Insert configs.maxDSWaitTime
`PUT` /lobby/v1/admin/config/namespaces/{namespace} admin update namespace config  
    Parameters

        Insert body.maxDSWaitTime
    Return Type

        Insert maxDSWaitTime
`GET` /lobby/v1/admin/config/namespaces/{namespace} admin get namespace config  
    Return Type

        Insert maxDSWaitTime
`GET` /lobby/v1/admin/config/namespaces/{namespace}/export Export lobby config to a json file.  
    Return Type

        Insert maxDSWaitTime

## platform Service

### What's New
---
* `DELETE` /platform/admin/namespaces/{namespace}/rewards/{rewardId}/record Delete a reward condition record

### What's Changed
---
`POST` /platform/admin/fulfillment/scripts/tests/eval Test eval fulfillment script  
    Parameters

        Insert body.context.item.fresh //fresh
`GET` /platform/admin/namespaces/{namespace}/items/bySku/locale Get an item by sku in locale  
    Return Type

        Insert fresh //fresh
        Insert items.fresh //fresh
`GET` /platform/admin/namespaces/{namespace}/items/itemId/bySku Get itemId by sku  
    Return Type

        Insert status //status
`GET` /platform/admin/namespaces/{namespace}/items/itemId/bySkus Get multiple itemId by sku  
    Return Type

        Insert status //status
`GET` /platform/admin/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Insert fresh //fresh
`DELETE` /platform/admin/namespaces/{namespace}/items/{itemId} Delete an item  
    Parameters

        Add force //default is false
`GET` /platform/admin/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Insert fresh //fresh
        Insert items.fresh //fresh
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Parameters

        Add features
`GET` /platform/public/namespaces/{namespace}/items/byAppId Get item by appId  
    Return Type

        Insert fresh //fresh
`GET` /platform/public/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Return Type

        Insert data.fresh //fresh
`GET` /platform/public/namespaces/{namespace}/items/bySku Get item by sku  
    Return Type

        Insert fresh //fresh
`GET` /platform/public/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Insert fresh //fresh
`GET` /platform/public/namespaces/{namespace}/items/search Search items by keyword  
    Return Type

        Insert data.fresh //fresh
`GET` /platform/public/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Insert fresh //fresh
        Insert items.fresh //fresh
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Parameters

        Add features

## seasonpass Service

### What's Changed
---
`GET` /seasonpass/admin/namespaces/{namespace}/seasons Query seasons  
    Return Type

        Insert data.tierItemId //tier item id
        Insert data.tierItemName //tier item name

## ugc Service

### What's New
---
* `GET` /ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode
