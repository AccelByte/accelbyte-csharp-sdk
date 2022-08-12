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