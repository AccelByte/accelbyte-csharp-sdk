
# C# Server SDK v0.28.0

## achievement Service

### What's New
---
* `GET` /achievement/v1/public/namespaces/{namespace}/global/achievements Query global achievements [include achieved and in-progress]
* `POST` /achievement/v1/public/namespaces/{namespace}/users/{userId}/global/achievements/{achievementCode}/claim Claim global achievement reward

### What's Changed
---
`GET` /achievement/v1/admin/namespaces/{namespace}/achievements Query achievements  
    Parameters

        Add global //filter by global achievement flag
    Return Type

        Insert data.global
`POST` /achievement/v1/admin/namespaces/{namespace}/achievements Create new achievement  
    Parameters

        Insert body.global
`GET` /achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode} Get an achievement  
    Return Type

        Insert global
`PUT` /achievement/v1/admin/namespaces/{namespace}/achievements/{achievementCode} Update an achievement  
    Return Type

        Insert global
`GET` /achievement/v1/public/namespaces/{namespace}/achievements Query achievements  
    Parameters

        Add global //filter by global achievement flag
    Return Type

        Insert data.global
`GET` /achievement/v1/public/namespaces/{namespace}/achievements/{achievementCode} Get an achievement  
    Return Type

        Insert global

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.
        Modify endTime //End time of data to be queried. Default: Current time in UTC.

## group Service

### What's Changed
---
`GET` /group/v1/admin/namespaces/{namespace}/groups get list of groups  
    Return Type

        Modify data.groupType
`GET` /group/v1/admin/namespaces/{namespace}/groups/{groupId} get single group  
    Return Type

        Modify groupType
`GET` /group/v1/public/namespaces/{namespace}/groups get list of groups  
    Return Type

        Modify data.groupType
`PATCH` /group/v1/public/namespaces/{namespace}/groups/{groupId} update existing group  
    Return Type

        Modify groupType
`PUT` /group/v1/public/namespaces/{namespace}/groups/{groupId} update existing group  
    Return Type

        Modify groupType
`GET` /group/v1/public/namespaces/{namespace}/groups/{groupId} get single group  
    Return Type

        Modify groupType
`PUT` /group/v1/public/namespaces/{namespace}/groups/{groupId}/attributes/custom Update group custom attributes  
    Return Type

        Modify groupType
`PUT` /group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/custom update group custom rule  
    Return Type

        Modify groupType
`PUT` /group/v1/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction} update predefined group rule  
    Return Type

        Modify groupType
`POST` /group/v2/public/namespaces/{namespace}/groups/bulk get list of groups by group Ids  
    Return Type

        Modify data.groupType
`PATCH` /group/v2/public/namespaces/{namespace}/groups/{groupId} update existing group  
    Return Type

        Modify groupType
`PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId} update existing group  
    Return Type

        Modify groupType
`PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/attributes/custom Update group custom attributes  
    Return Type

        Modify groupType
`PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/custom update group custom rule  
    Return Type

        Modify groupType
`PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction} update predefined group rule  
    Return Type

        Modify groupType

## iam Service

### What's Changed
---
`GET` /iam/v3/admin/namespaces/{namespace}/users/linkhistories Search linking history of the query platform with platform user id  
    Parameters

        platformId Notes Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, stadia, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon change into Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon
        Modify platformId //Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon
`GET` /iam/v3/admin/namespaces/{namespace}/users/search Search User  
    Parameters

        platformId Notes Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, stadia, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon change into Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon
        Modify platformId //Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon
`GET` /iam/v3/public/users/me/headless/link/conflict Get conflict result when link headless account to current full account by one time code  
    Return Type

        Modify currentAccount.linkedGames
        Modify headlessAccount.linkedGames

## legal Service

### What's New
---
* `GET` /agreement/admin/namespaces/{namespace}/agreements/policies/users/{userId} Retrieve Accepted Legal Agreements
* `GET` /agreement/admin/namespaces/{namespace}/agreements/policy-versions/users Retrieve All Users Accepting Legal Agreements
* `GET` /agreement/admin/namespaces/{namespace}/base-policies Retrieve All Base Legal Policy in the namespace
* `POST` /agreement/admin/namespaces/{namespace}/base-policies Create a Base Legal Policy
* `GET` /agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId} Retrieve a Base Legal Policy
* `PATCH` /agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId} Update Base Legal Policy
* `GET` /agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}/countries/{countryCode} Retrieve a Base Legal Policy based on a Particular Country
* `GET` /agreement/admin/namespaces/{namespace}/localized-policy-versions/versions/{policyVersionId} Retrieve Versions from Country-Specific Policy
* `POST` /agreement/admin/namespaces/{namespace}/localized-policy-versions/versions/{policyVersionId} Create a Localized Version from Country-Specific Policy
* `GET` /agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId} Retrieve a Localized Version from Country-Specific Policy
* `PUT` /agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId} Update a Localized Version from Country-Specific Policy
* `POST` /agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}/attachments Request Presigned URL for Upload Document
* `PATCH` /agreement/admin/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId}/default Set Default Localized Policy
* `PATCH` /agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId} Update a Version of Policy
* `PATCH` /agreement/admin/namespaces/{namespace}/policies/versions/{policyVersionId}/latest Manually Publish a Version from Country-Specific Policy
* `PATCH` /agreement/admin/namespaces/{namespace}/policies/{policyId} Update Country-Specific Policy
* `PATCH` /agreement/admin/namespaces/{namespace}/policies/{policyId}/default Set Default Policy
* `GET` /agreement/admin/namespaces/{namespace}/policies/{policyId}/versions Retrieve a Version from Country-Specific Policy
* `POST` /agreement/admin/namespaces/{namespace}/policies/{policyId}/versions Create a Version from Country-Specific Policy
* `GET` /agreement/admin/namespaces/{namespace}/policy-types Retrieve All Policy Type
* `GET` /agreement/public/namespaces/{namespace}/localized-policy-versions/{localizedPolicyVersionId} Retrieve a Localized Version

## match2 Service

### What's Changed
---
`POST` /match2/v1/namespaces/{namespace}/rulesets Create a match rule set  
    Parameters

        Insert body.enable_custom_match_function
        Modify body.data
`PUT` /match2/v1/namespaces/{namespace}/rulesets/{ruleset} Update a match rule set  
    Parameters

        Insert body.enable_custom_match_function
        Insert body.name
        Modify body.data
    Return Type

        Insert enable_custom_match_function
        Modify data
`GET` /match2/v1/namespaces/{namespace}/rulesets/{ruleset} Get details for a specific rule set  
    Return Type

        Insert enable_custom_match_function
        Modify data

## matchmaking Service

### What's Changed
---
`POST` /matchmaking/namespaces/{namespace}/rebalance Rebalance Matchmaking based on MMR  
    Return Type

        Insert matching_allies.matching_parties.ticket_created_at
`POST` /matchmaking/namespaces/{namespace}/sessions Queue joinable session  
    Parameters

        Insert body.matching_allies.matching_parties.ticket_created_at
`GET` /matchmaking/namespaces/{namespace}/sessions/{matchID}/status Query joinable session status  
    Return Type

        Insert matching_allies.matching_parties.ticket_created_at
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk Bulk get sessions  
    Return Type

        Insert matching_allies.matching_parties.ticket_created_at
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties Get all party in a channel  
    Return Type

        Insert ticket_created_at
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions Get all channel sessions  
    Return Type

        Insert matching_allies.matching_parties.ticket_created_at
`GET` /matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed Get session history detailed  
    Return Type

        Insert matching_allies.matching_parties.ticket_created_at

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/revocation/config Get revocation configuration
* `PUT` /platform/admin/namespaces/{namespace}/revocation/config Update revocation configuration
* `DELETE` /platform/admin/namespaces/{namespace}/revocation/config Delete revocation config
* `GET` /platform/admin/namespaces/{namespace}/revocation/history Query revocation histories
* `DELETE` /platform/admin/namespaces/{namespace}/users/{userId}/anonymization/revocation anonymize revocation
* `PUT` /platform/admin/namespaces/{namespace}/users/{userId}/revocation Do revocation.
* `PUT` /platform/admin/namespaces/{namespace}/users/{userId}/wallets/currencies/{currencyCode}/debit Debit a user wallet by currency code

### What's Deprecated
---
* `GET` /platform/admin/namespaces/{namespace}/iap/config/stadia Get stadia iap config
* `DELETE` /platform/admin/namespaces/{namespace}/iap/config/stadia Delete stadia iap config
* `PUT` /platform/admin/namespaces/{namespace}/iap/config/stadia/cert Upload stadia json config file
* `PUT` /platform/public/namespaces/{namespace}/users/{userId}/iap/stadia/sync Sync stadia inventory.

### What's Changed
---
`PUT` /platform/admin/namespaces/{namespace}/platforms/{platform}/wallet/config Update platform wallet config  
    Parameters

        Modify body.allowedBalanceOrigins
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/dlc Get user dlc by platform  
    Return Type

        Insert dlcs.revocationResult
        Insert dlcs.transactionId
        Insert dlcs.version
        Modify dlcs.status
`POST` /platform/admin/namespaces/{namespace}/users/{userId}/fulfillment Fulfill item  
    Parameters

        Modify body.origin //origin
`POST` /platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards Fulfill rewards  
    Parameters

        Modify body.origin //origin, if rewards contains item icon, it will credit into related origin wallet. if not set, it will be credit into System wallet
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/check Check wallet by balance origin and currency code  
    Parameters

        Modify origin
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/credit Credit a user wallet by currency code and balance origin  
    Parameters

        Modify body.origin //origin, balance origin decided on the type of wallet, default is System
`GET` /platform/admin/namespaces/{namespace}/wallets Query wallets  
    Parameters

        Modify origin //balance origin

## sessionbrowser Service

### What's Changed
---
`GET` /sessionbrowser/admin/namespaces/{namespace}/sessions/history/search Search sessions  
    Return Type

        Insert data.joining
        Insert data.players
        Insert data.removed_reason
        Insert data.session_type

## social Service

### What's Changed
---
`GET` /social/v1/admin/namespaces/{namespace}/stats List stats  
    Parameters

        Add isGlobal //flag to filter global statcode
`GET` /social/v1/admin/namespaces/{namespace}/stats/search Query stats by keyword  
    Parameters

        Add isGlobal //flag to filter global statcode
`GET` /social/v1/admin/namespaces/{namespace}/users/{userId}/statitems List user's statItems  
    Parameters

        Add sortBy //default is updatedAt:asc, allow values: [statCode, statCode:asc, statCode:desc, createdAt, createdAt:asc, createdAt:desc, updatedAt, updatedAt:asc, updatedAt:desc],and support sort group, eg: sortBy=statCode:asc,createdAt:desc.
`GET` /social/v1/public/namespaces/{namespace}/users/{userId}/statitems Public list user's statItems  
    Parameters

        Add sortBy //default is updatedAt:asc, allow values: [statCode, statCode:asc, statCode:desc, createdAt, createdAt:asc, createdAt:desc, updatedAt, updatedAt:asc, updatedAt:desc],and support sort group, eg: sortBy=statCode:asc,createdAt:desc.


# C# Server SDK v0.27.0

## basic Service

### What's Changed
---
`GET` /basic/v1/admin/namespaces Get all namespaces  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`GET` /basic/v1/admin/namespaces/{namespace} Get a namespace  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`DELETE` /basic/v1/admin/namespaces/{namespace} Delete a namespace  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`PATCH` /basic/v1/admin/namespaces/{namespace}/basic Update namespace basic info  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`GET` /basic/v1/admin/namespaces/{namespace}/game Get game namespaces  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`PATCH` /basic/v1/admin/namespaces/{namespace}/status Change namespace status  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace
`GET` /basic/v1/public/namespaces Get all namespaces  
    Return Type

        Insert clientId //clientId is only present on multi tenant mode with namespace is not publisher namespace

## dsmc Service

### What's Changed
---
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers List all managed servers in a region  
    Return Type

        Insert servers.deployment_override
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/local List all managed local servers  
    Return Type

        Insert servers.deployment_override
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/{podName} Query a server in a region  
    Return Type

        Insert deployment_override
`GET` /dsmcontroller/admin/namespaces/{namespace}/sessions List all managed sessions in a region  
    Return Type

        Insert sessions.Server.deployment_override
`POST` /dsmcontroller/namespaces/{namespace}/servers/local/register Register a local DS  
    Return Type

        Insert deployment_override
`POST` /dsmcontroller/namespaces/{namespace}/servers/register Register a DS  
    Return Type

        Insert deployment_override
`POST` /dsmcontroller/namespaces/{namespace}/sessions Register a new game session  
    Return Type

        Insert session.Server.deployment_override
`GET` /dsmcontroller/namespaces/{namespace}/sessions/{sessionID} Query specified session  
    Return Type

        Insert session.Server.deployment_override

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## group Service

### What's New
---
* `GET` /group/v2/admin/namespaces/{namespace}/users/{userId}/groups Get User Joined Group Information
* `POST` /group/v2/public/namespaces/{namespace}/groups create new group
* `POST` /group/v2/public/namespaces/{namespace}/groups/bulk get list of groups by group Ids
* `PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId} update existing group
* `DELETE` /group/v2/public/namespaces/{namespace}/groups/{groupId} Delete existing group
* `PATCH` /group/v2/public/namespaces/{namespace}/groups/{groupId} update existing group
* `PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/attributes/custom Update group custom attributes
* `POST` /group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/accept Accept Group Invitation
* `POST` /group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/reject Reject Group Invitation
* `GET` /group/v2/public/namespaces/{namespace}/groups/{groupId}/invite/request Get Group Invite Request List
* `POST` /group/v2/public/namespaces/{namespace}/groups/{groupId}/join Join to group
* `GET` /group/v2/public/namespaces/{namespace}/groups/{groupId}/join/request Get Group Join Request List
* `POST` /group/v2/public/namespaces/{namespace}/groups/{groupId}/leave Leave group
* `PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/custom update group custom rule
* `PUT` /group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction} update predefined group rule
* `DELETE` /group/v2/public/namespaces/{namespace}/groups/{groupId}/rules/defined/{allowedAction} Delete group predefined rule
* `GET` /group/v2/public/namespaces/{namespace}/roles get all list of member roles
* `POST` /group/v2/public/namespaces/{namespace}/roles/{memberRoleId}/groups/{groupId}/members Assign role to group member
* `DELETE` /group/v2/public/namespaces/{namespace}/roles/{memberRoleId}/groups/{groupId}/members Remove role from group member
* `GET` /group/v2/public/namespaces/{namespace}/users/me/groups Get User Joined Group Information
* `GET` /group/v2/public/namespaces/{namespace}/users/me/join/request Get My Join Request To The Groups
* `POST` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/invite Invite user to group
* `POST` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/invite/cancel Cancel Invitation Group Member
* `POST` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/join/accept Accept Group Join Request
* `POST` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/join/reject Reject Group Join Request
* `POST` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/kick Kick Group Member
* `GET` /group/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/status User Group Status Information

### What's Changed
---
`POST` /group/v1/admin/namespaces/{namespace}/configuration create new configuration  
    Parameters

        Insert body.allowMultiple
`GET` /group/v1/admin/namespaces/{namespace}/configuration List Group Configuration  
    Return Type

        Insert data.allowMultiple
`PATCH` /group/v1/admin/namespaces/{namespace}/configuration/{configurationCode} update existing configuration  
    Return Type

        Insert allowMultiple
`GET` /group/v1/admin/namespaces/{namespace}/configuration/{configurationCode} get existing configuration  
    Return Type

        Insert allowMultiple
`PUT` /group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction} update existing configuration global rule  
    Return Type

        Insert allowMultiple
`DELETE` /group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction} delete existing configuration global rule based on allowed action  
    Return Type

        Insert allowMultiple
`GET` /group/v1/admin/namespaces/{namespace}/roles get all list of member roles  
    Return Type

        Delete data.memberRoleId
        Delete data.memberRoleName
        Delete data.memberRolePermissions
`GET` /group/v1/public/namespaces/{namespace}/roles get all list of member roles  
    Return Type

        Delete data.memberRoleId
        Delete data.memberRoleName
        Delete data.memberRolePermissions

## iam Service

### What's Changed
---
`GET` /iam/v3/admin/namespaces/{namespace}/clients Get clients by namespace  
    Return Type

        Insert data.roles
`PATCH` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Update Client  
    Return Type

        Insert roles
`GET` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Get clients by namespace and client id. Multi tenant mode allows admin portal client to be accessible regardless of namespace path.  
    Return Type

        Insert roles

## match2 Service

### What's New
---
* `GET` /match2/v1/namespaces/{namespace}/backfill/proposal Get backfill proposal
* `GET` /match2/v1/namespaces/{namespace}/backfill/{backfillID} Get a backfill ticket
* `DELETE` /match2/v1/namespaces/{namespace}/backfill/{backfillID} Delete a backfill ticket

### What's Changed
---
`POST` /match2/v1/namespaces/{namespace}/match-pools Create a match pool  
    Parameters

        Insert body.auto_accept_backfill_proposal
        Insert body.backfill_proposal_expiration_seconds
`GET` /match2/v1/namespaces/{namespace}/match-pools List match pools  
    Return Type

        Insert data.auto_accept_backfill_proposal
        Insert data.backfill_proposal_expiration_seconds
`GET` /match2/v1/namespaces/{namespace}/match-pools/{pool} Get details for a specific match pool  
    Return Type

        Insert auto_accept_backfill_proposal
        Insert backfill_proposal_expiration_seconds
`PUT` /match2/v1/namespaces/{namespace}/match-pools/{pool} Update a match pool  
    Parameters

        Insert body.auto_accept_backfill_proposal
        Insert body.backfill_proposal_expiration_seconds
    Return Type

        Insert auto_accept_backfill_proposal
        Insert backfill_proposal_expiration_seconds
`GET` /match2/v1/namespaces/{namespace}/match-tickets/{ticketid} Get details for a specific match ticket  
    Return Type

        Insert proposedProposal

## platform Service

### What's Changed
---
`POST` /platform/admin/fulfillment/scripts/tests/eval Test eval fulfillment script  
    Parameters

        Insert body.context.item.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/entitlements Query entitlements  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/entitlements/{entitlementId} Get entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`POST` /platform/admin/namespaces/{namespace}/items Create an Item  
    Parameters

        Insert body.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items Sync an in game item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/byAppId Get item by appId  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/bySku Get item by sku  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/bySku/locale Get an item by sku in locale  
    Return Type

        Insert items.lootBoxConfig.rollFunction //roll function
        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/search Search items by keyword  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/uncategorized Query uncategorized items  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId} Update an item  
    Parameters

        Insert body.lootBoxConfig.rollFunction //roll function
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/{itemId} Get an item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/disable Disable an item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/enable Enable an item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`DELETE` /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} Defeature an item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature} Feature an item  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Insert items.lootBoxConfig.rollFunction //roll function
        Insert lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/items/{itemId}/purchase/condition Update item purchase condition  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/orders Query orders  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/orders/{orderNo} Get order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/orders/{orderNo}/refund Refund order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/subscriptions Query subscriptions  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId Get user app entitlement by appId  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppType Query app entitlements by appType  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemId Get user entitlement by itemId  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemIds Get user entitlements by itemIds  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/bySku Get user entitlement by sku  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Update user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Get user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/disable Disable user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/enable Enable user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/revoke Revoke user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/orders Query user orders  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} Update order status  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo} Get an order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill Fulfill an order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions Query user subscriptions  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`POST` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/platformSubscribe Free subscribe by platform  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} Get user subscription  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel Cancel a subscription  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/grant Grant days to a subscription  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/admin/orders Sync orders  
    Return Type

        Insert orders.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/byAppId Get item by appId  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/bySku Get item by sku  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/locale/byIds Bulk get locale items  
    Return Type

        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/search Search items by keyword  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/items/{itemId}/locale Get an item in locale  
    Return Type

        Insert items.lootBoxConfig.rollFunction //roll function
        Insert lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements Query user entitlements  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppId Get user app entitlement by appId  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byAppType Query app entitlements by appType  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/byItemId Get user entitlement by itemId  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/bySku Get user entitlement by sku  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId} Get user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/orders Query user orders  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo} Get user order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/cancel Cancel user order  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/sections List active section contents  
    Return Type

        Insert currentRotationItems.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions Query user subscriptions  
    Return Type

        Insert data.itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId} Get user subscription  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/billingAccount Request to change a subscription billing account  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/subscriptions/{subscriptionId}/cancel Cancel a subscription  
    Return Type

        Insert itemSnapshot.lootBoxConfig.rollFunction //roll function
`GET` /platform/v2/admin/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Return Type

        Insert data.lootBoxConfig.rollFunction //roll function

## session Service

### What's New
---
* `GET` /session/v1/admin/namespaces/{namespace}/users/attributes Query player attributes. Requires ADMIN:NAMESPACE:{namespace}:SESSION:PLAYER:{userId} [READ]
* `GET` /session/v1/admin/namespaces/{namespace}/users/{userId}/attributes Get player attributes. Requires ADMIN:NAMESPACE:{namespace}:SESSION:PLAYER:{userId} [READ]
* `GET` /session/v1/public/namespaces/{namespace}/users/me/attributes Get player attributes. Requires NAMESPACE:{namespace}:SESSION:PLAYER [READ]
* `POST` /session/v1/public/namespaces/{namespace}/users/me/attributes Store player attributes. Requires NAMESPACE:{namespace}:SESSION:PLAYER [CREATE]
* `DELETE` /session/v1/public/namespaces/{namespace}/users/me/attributes Remove player attributes. Requires NAMESPACE:{namespace}:SESSION:PLAYER [DELETE]

### What's Changed
---
`GET` /session/v1/admin/namespaces/{namespace}/gamesessions Get all game sessions.  
    Parameters

        Add isSoftDeleted //game session is soft deleted. supported: TRUE, FALSE

## sessionbrowser Service

### What's Changed
---
`GET` /sessionbrowser/admin/namespaces/{namespace}/sessions/history/search Search sessions  
    Parameters

        Add sessionType //Type of the session, value must be 'p2p' or 'dedicated'
        Add status //Status of the session, value must be 'active' or 'deleted'. Only work with p2p session type

## ugc Service

### What's Changed
---
`GET` /ugc/v1/admin/namespaces/{namespace}/channels Get Channels  
    Return Type

        Insert data.parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId} Update Channel  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.payload
        Insert body.updateContentFile
    Return Type

        Insert parentNamespace
        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search Search contents specific to a channel  
    Return Type

        Modify data.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Insert parentNamespace
        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents Get user's generated contents  
    Return Type

        Modify data.customAttributes
`POST` /ugc/v1/admin/namespaces/{namespace}/contents/bulk Bulk get content by content IDs  
    Return Type

        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/search Search contents  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/groups Get all user groups  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/admin/namespaces/{namespace}/groups/{groupId} Get specific user group  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/groups/{groupId} Update group  
    Return Type

        Insert parentNamespace
`GET` /ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/types Get types  
    Return Type

        Insert data.parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/types/{typeId} Update types  
    Return Type

        Insert parentNamespace
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels Get Channels  
    Return Type

        Insert data.parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId} Update Channel  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.payload
        Insert body.updateContentFile
    Return Type

        Insert parentNamespace
        Modify customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Insert parentNamespace
        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Modify data.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide Hide/Unhide user's generated contents  
    Return Type

        Insert parentNamespace
        Modify customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups Get all user groups  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId} Get specific user group  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId} Update group  
    Return Type

        Insert parentNamespace
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents Search contents specific to a channel  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents Search contents  
    Return Type

        Modify data.customAttributes
`POST` /ugc/v1/public/namespaces/{namespace}/contents/bulk Get contents by content Ids   
    Return Type

        Modify customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/followed Get contents from followed creators  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/liked Get liked contents  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Modify customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Modify customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/types Get types  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users Search creator  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/followed Get followed creators  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId} Get creator stats: number of total like by other user, number of total following and follower user  
    Return Type

        Insert parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels Get Channels  
    Return Type

        Insert data.parentNamespace
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId} Update Channel  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.payload
        Insert body.updateContentFile
    Return Type

        Insert parentNamespace
        Modify customAttributes
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Return Type

        Insert parentNamespace
        Modify customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Modify data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/followers Get list of followers  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/following Get list of following  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups Get all user groups  
    Return Type

        Insert data.parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId} Get user's groups  
    Return Type

        Insert parentNamespace
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId} Update group  
    Return Type

        Insert parentNamespace
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Modify data.customAttributes

# C# Server SDK v0.26.0

## cloudsave Service

### What's New
---
* `POST` /cloudsave/v1/namespaces/{namespace}/records/bulk Bulk get game records
* `GET` /cloudsave/v1/namespaces/{namespace}/users/me/records Query player records key
* `POST` /cloudsave/v1/namespaces/{namespace}/users/me/records/bulk Get player records bulk

## dslogmanager Service

### What's Changed
---
`GET` /dslogmanager/namespaces/{namespace}/servers/search Retrieve All Terminated Servers  
    Return Type

        Insert data.server.termination_reason
`GET` /dslogmanager/servers/search Retrieve All Terminated Servers  
    Return Type

        Insert data.server.termination_reason

## dsmc Service

### What's Changed
---
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers List all managed servers in a region  
    Return Type

        Insert servers.termination_reason
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/local List all managed local servers  
    Return Type

        Insert servers.termination_reason
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/{podName} Query a server in a region  
    Return Type

        Insert termination_reason
`GET` /dsmcontroller/admin/namespaces/{namespace}/sessions List all managed sessions in a region  
    Return Type

        Insert sessions.Server.termination_reason
`POST` /dsmcontroller/namespaces/{namespace}/servers/local/register Register a local DS  
    Return Type

        Insert termination_reason
`POST` /dsmcontroller/namespaces/{namespace}/servers/register Register a DS  
    Return Type

        Insert termination_reason
`POST` /dsmcontroller/namespaces/{namespace}/sessions Register a new game session  
    Return Type

        Insert session.Server.termination_reason
`GET` /dsmcontroller/namespaces/{namespace}/sessions/{sessionID} Query specified session  
    Return Type

        Insert session.Server.termination_reason

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## iam Service

### What's Changed
---
`GET` /iam/v3/admin/namespaces/{namespace}/clients Get clients by namespace  
    Return Type

        Insert data.parentNamespace
`POST` /iam/v3/admin/namespaces/{namespace}/clients Create Client  
    Parameters

        Insert body.parentNamespace
`PATCH` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Update Client  
    Return Type

        Insert parentNamespace
`GET` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Get clients by namespace and client id. Multi tenant mode allows admin portal client to be accessible regardless of namespace path.  
    Return Type

        Insert parentNamespace
`POST` /iam/v3/admin/namespaces/{namespace}/users/invite Invite User  
    Parameters

        Insert body.namespace //multi tenant studio namespace
`GET` /iam/v3/public/namespaces/{namespace}/users/invite/{invitationId} Get User Invitation  
    Return Type

        Insert namespace
`POST` /iam/v4/admin/users/users/invite Admin invite User v4  
    Parameters

        Insert body.namespace //multi tenant studio namespace

## match2 Service

### What's Changed
---
`POST` /match2/v1/namespaces/{namespace}/match-pools Create a match pool  
    Parameters

        Insert body.match_function_override
`GET` /match2/v1/namespaces/{namespace}/match-pools List match pools  
    Return Type

        Insert data.match_function_override
`GET` /match2/v1/namespaces/{namespace}/match-pools/{pool} Get details for a specific match pool  
    Return Type

        Insert match_function_override
`PUT` /match2/v1/namespaces/{namespace}/match-pools/{pool} Update a match pool  
    Parameters

        Insert body.match_function_override
    Return Type

        Insert match_function_override

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/configs/servicePlugin Get service plugin config
* `PUT` /platform/admin/namespaces/{namespace}/configs/servicePlugin Update service plugin config service
* `DELETE` /platform/admin/namespaces/{namespace}/configs/servicePlugin Delete service plugin config

### What's Changed
---
`POST` /platform/admin/namespaces/{namespace}/sections Create a section  
    Parameters

        Insert body.fixedPeriodRotationConfig.backfillType //backfill type: NONE/CUSTOM, default is NONE
        Insert body.items.sku //item sku
        Modify body.fixedPeriodRotationConfig.itemCount //rotation item count, min is 1, default is 1
        Modify body.rotationType //rotation type, default is NONE
`GET` /platform/admin/namespaces/{namespace}/sections List sections  
    Return Type

        Insert data.viewName //view name
        Insert data.fixedPeriodRotationConfig.backfillType //backfill type: NONE/CUSTOM, default is NONE
        Insert data.items.sku //item sku
        Modify data.fixedPeriodRotationConfig.itemCount //rotation item count, min is 1, default is 1
        Modify data.rotationType //rotation type, default is NONE
`PUT` /platform/admin/namespaces/{namespace}/sections/{sectionId} Update s section  
    Parameters

        Insert body.fixedPeriodRotationConfig.backfillType //backfill type: NONE/CUSTOM, default is NONE
        Insert body.items.sku //item sku
        Modify body.fixedPeriodRotationConfig.itemCount //rotation item count, min is 1, default is 1
        Modify body.rotationType //rotation type, default is NONE
    Return Type

        Insert viewName //view name
        Insert fixedPeriodRotationConfig.backfillType //backfill type: NONE/CUSTOM, default is NONE
        Insert items.sku //item sku
        Modify fixedPeriodRotationConfig.itemCount //rotation item count, min is 1, default is 1
        Modify rotationType //rotation type, default is NONE
`GET` /platform/admin/namespaces/{namespace}/sections/{sectionId} Get a section  
    Return Type

        Insert viewName //view name
        Insert fixedPeriodRotationConfig.backfillType //backfill type: NONE/CUSTOM, default is NONE
        Insert items.sku //item sku
        Modify fixedPeriodRotationConfig.itemCount //rotation item count, min is 1, default is 1
        Modify rotationType //rotation type, default is NONE
`GET` /platform/public/namespaces/{namespace}/users/{userId}/sections List active section contents  
    Return Type

        Insert ext //customized section properties
        Modify createdAt //view created time
        Modify updatedAt //view updated time

## session Service

### What's Changed
---
`GET` /session/v1/admin/namespaces/{namespace}/gamesessions Get all game sessions.  
    Parameters

        Add statusV2 //game session status to filter. supported status: NEED_TO_REQUEST,REQUESTED,AVAILABLE,FAILED_TO_REQUEST,UNKNOWN,ENDED
    Return Type

        Insert data.DSInformation.StatusV2
        Insert data.members.statusV2
        Insert data.teams.parties
`PUT` /session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType} Update status of a game session member. Requires ADMIN:NAMESPACE:{namespace}:SESSION:GAME [UPDATE]  
    Return Type

        Insert statusV2
`GET` /session/v1/admin/namespaces/{namespace}/parties Query parties. Requires ADMIN:NAMESPACE:{namespace}:SESSION:PARTY [READ]  
    Return Type

        Insert data.members.statusV2
`POST` /session/v1/public/namespaces/{namespace}/gamesession Create a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [CREATE]  
    Parameters

        Insert body.teams.parties
`POST` /session/v1/public/namespaces/{namespace}/gamesessions Query game sessions  
    Return Type

        Insert data.DSInformation.StatusV2
        Insert data.members.statusV2
        Insert data.teams.parties
`GET` /session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName} Get game session detail. Requires NAMESPACE:{namespace}:SESSION:GAME [READ]  
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`PUT` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Update a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [UPDATE]  
    Parameters

        Insert body.teams.parties
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`PATCH` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Patch update a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [UPDATE]  
    Parameters

        Insert body.teams.parties
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`GET` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Get game session detail. Requires NAMESPACE:{namespace}:SESSION:GAME [READ]  
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`POST` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join Join a game session. Requires NAMESPACE:{namespace}:SESSION:GAME:PLAYER [CREATE]  
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`POST` /session/v1/public/namespaces/{namespace}/parties/users/me/join/code Join a party by code. Requires NAMESPACE:{namespace}:SESSION:PARTY:PLAYER [CREATE]  
    Return Type

        Insert members.statusV2
`PUT` /session/v1/public/namespaces/{namespace}/parties/{partyId} Update a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert members.statusV2
`PATCH` /session/v1/public/namespaces/{namespace}/parties/{partyId} Patch update a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert members.statusV2
`GET` /session/v1/public/namespaces/{namespace}/parties/{partyId} Get party details. Requires NAMESPACE:{namespace}:SESSION:PARTY [READ]  
    Return Type

        Insert members.statusV2
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/code Generate party code. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert members.statusV2
`DELETE` /session/v1/public/namespaces/{namespace}/parties/{partyId}/code Revoke party code. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert members.statusV2
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/leader Promote new party leader. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert members.statusV2
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join Join a party. Requires NAMESPACE:{namespace}:SESSION:PARTY:PLAYER [CREATE]  
    Return Type

        Insert members.statusV2
`DELETE` /session/v1/public/namespaces/{namespace}/parties/{partyId}/users/{userId}/kick Kick a player from a party. Requires NAMESPACE:{namespace}:SESSION:PARTY:PLAYER [DELETE]  
    Return Type

        Insert members.statusV2
`POST` /session/v1/public/namespaces/{namespace}/party Create a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [CREATE]  
    Return Type

        Insert members.statusV2
`GET` /session/v1/public/namespaces/{namespace}/users/me/gamesessions Query user's game sessions  
    Return Type

        Insert DSInformation.StatusV2
        Insert members.statusV2
        Insert teams.parties
`GET` /session/v1/public/namespaces/{namespace}/users/me/parties Query my parties. Require valid JWT.  
    Return Type

        Insert members.statusV2

## sessionbrowser Service

### What's New
---
* `GET` /sessionbrowser/admin/namespaces/{namespace}/gamesession Query to available game session

## ugc Service

### What's New
---
* `POST` /ugc/v1/admin/namespaces/{namespace}/contents/bulk Bulk get content by content IDs

### What's Changed
---
`POST` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents Upload content to a channel  
    Parameters

        Insert body.customAttributes
`POST` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3 Upload content to S3 bucket  
    Parameters

        Insert body.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search Search contents specific to a channel  
    Return Type

        Insert data.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents Get user's generated contents  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/search Search contents  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Insert data.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Insert data.customAttributes
`PUT` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide Hide/Unhide user's generated contents  
    Return Type

        Insert customAttributes
`GET` /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents Search contents specific to a channel  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents Search contents  
    Return Type

        Insert data.customAttributes
`POST` /ugc/v1/public/namespaces/{namespace}/contents/bulk Get contents by content Ids   
    Return Type

        Insert customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/followed Get contents from followed creators  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/liked Get liked contents  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode} Get content by sharecode  
    Return Type

        Insert customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/contents/{contentId} Get user specific content  
    Return Type

        Insert customAttributes
`POST` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents Upload content to a channel  
    Parameters

        Insert body.customAttributes
`POST` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3 Upload content to S3 bucket  
    Parameters

        Insert body.customAttributes
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} Update content to S3 bucket  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`PUT` /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} Update content to a channel  
    Parameters

        Insert body.customAttributes
    Return Type

        Insert customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents Get user's generated contents  
    Return Type

        Insert data.customAttributes
`GET` /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents Get contents belong to a group  
    Return Type

        Insert data.customAttributes


















# C# Server SDK v0.25.0

## achievement Service

### What's Changed
---
`GET` /achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Parameters

        Add sortBy //sort by, allow values: [achievedAt, achievedAt:asc, achievedAt:desc, createdAt, createdAt:asc, createdAt:desc]
`GET` /achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Parameters

        Add sortBy //sort by, allow values: [achievedAt, achievedAt:asc, achievedAt:desc, createdAt, createdAt:asc, createdAt:desc]

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## lobby Service

### What's Changed
---
`GET` /lobby/v1/public/presence/namespaces/{namespace}/users/presence Query users presence  
    Return Type

        Insert away

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/sections List sections
* `POST` /platform/admin/namespaces/{namespace}/sections Create a section
* `DELETE` /platform/admin/namespaces/{namespace}/sections/purge/expired purge expired section
* `GET` /platform/admin/namespaces/{namespace}/sections/{sectionId} Get a section
* `PUT` /platform/admin/namespaces/{namespace}/sections/{sectionId} Update s section
* `DELETE` /platform/admin/namespaces/{namespace}/sections/{sectionId} Delete a section
* `GET` /platform/admin/namespaces/{namespace}/views List all views
* `POST` /platform/admin/namespaces/{namespace}/views Create a view
* `GET` /platform/admin/namespaces/{namespace}/views/{viewId} Get a view
* `PUT` /platform/admin/namespaces/{namespace}/views/{viewId} Update a view
* `DELETE` /platform/admin/namespaces/{namespace}/views/{viewId} Delete a view
* `GET` /platform/public/namespaces/{namespace}/users/{userId}/sections List active section contents
* `GET` /platform/public/namespaces/{namespace}/users/{userId}/views Get all views

### What's Changed
---
`GET` /platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/byCriteria Query catalog changes  
    Parameters

        Modify type
    Return Type

        Insert data.sectionId //section id, only exists when change type is section
        Insert data.viewId //view id, only exists when change type is view
        Modify data.type //change type
`GET` /platform/admin/namespaces/{namespace}/stores/{storeId}/catalogChanges/statistics Get catalog changes statistics  
    Parameters

        Modify type

## sessionbrowser Service

### What's Changed
---
`GET` /sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game Get all active session for custom game, this return only dedicated session type  
    Parameters

        Add limit //max item to be returned
        Add offset //skip some item(s), offset=3, will skip 3 first items
`GET` /sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game Get all active session for matchmaking game, this return only dedicated session type  
    Parameters

        Add limit //max item to be returned
        Add offset //skip some item(s), offset=3, will skip 3 first items
`GET` /sessionbrowser/namespaces/{namespace}/gamesession Query to available game session  
    Parameters

        Modify offset //skip some item(s), offset=3, will skip 3 first items
        Modify limit //max item to be returned

## social Service

### What's New
---
* `GET` /social/v1/admin/namespaces/{namespace}/globalstatitems/{statCode} Get global statItem by stat code
* `GET` /social/v1/public/namespaces/{namespace}/globalstatitems List global statItems
* `GET` /social/v1/public/namespaces/{namespace}/globalstatitems/{statCode} Get global statItem by stat code

### What's Changed
---
`GET` /social/v1/admin/namespaces/{namespace}/globalstatitems List global statItems  
    Parameters

        Add statCodes //comma separated stat codes


# C# Server SDK v0.24.0

## achievement Service

### What's New
---
* `GET` /achievement/v1/admin/namespaces/{namespace}/tags Query tags
* `DELETE` /achievement/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/achievements Anonymize user's achievement
* `GET` /achievement/v1/public/namespaces/{namespace}/tags Query tags

### What's Changed
---
`GET` /achievement/v1/admin/namespaces/{namespace}/achievements Query achievements  
    Parameters

        Add tags //tags
`GET` /achievement/v1/admin/namespaces/{namespace}/achievements/export Export achievements configuration into a json file  
    Parameters

        Add tags //tags
`GET` /achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Parameters

        Add tags //tags
`GET` /achievement/v1/public/namespaces/{namespace}/achievements Query achievements  
    Parameters

        Add tags //tags
`GET` /achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Parameters

        Add tags //tags

## basic Service

### What's New
---
* `GET` /basic/v1/admin/namespaces/{namespace}/game Get game namespaces

### What's Changed
---
`GET` /basic/v1/admin/namespaces Get all namespaces  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode
`GET` /basic/v1/admin/namespaces/{namespace} Get a namespace  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode
`DELETE` /basic/v1/admin/namespaces/{namespace} Delete a namespace  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode
`PATCH` /basic/v1/admin/namespaces/{namespace}/basic Update namespace basic info  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode
`PATCH` /basic/v1/admin/namespaces/{namespace}/status Change namespace status  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode
`GET` /basic/v1/public/namespaces Get all namespaces  
    Return Type

        Insert parentNamespace //parentNamespace is only present in multi tenant mode

## dslogmanager Service

### What's New
---
* `GET` /dslogmanager/admin/namespaces/{namespace}/servers/{podName}/logs Queries server logs

## dsmc Service

### What's Deprecated
---
* `GET` /dsmcontroller/admin/namespaces/{namespace}/servers/{podName}/logs Queries server logs

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
* `GET` /iam/v3/admin/namespaces/{namespace}/users/linkhistories Search linking history of the query platform with platform user id
* `POST` /iam/v3/link/code/request Generate one time linking code
* `POST` /iam/v3/link/code/validate Validate one time linking code
* `POST` /iam/v3/link/token/exchange Generate publisher token by headless account's one time link code
* `GET` /iam/v3/public/users/me/headless/link/conflict Get conflict result when link headless account to current full account by one time code
* `POST` /iam/v3/public/users/me/headless/linkWithProgression Link headless account to current full account

### What's Changed
---
`GET` /iam/v3/oauth/authorize OAuth2 authorize API  
    Parameters

        Add oneTimeLinkCode //One time link code for headless account to link. Can get from [/iam/v3/link/code/request]


# C# Server SDK v0.23.0

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
* `POST` /iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/linkStatus Admin get the link status of the third party platform token with user id.

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/users/{userId}/dlc Get user dlc by platform
* `GET` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byItemIds Get user entitlements by itemIds

### What's Changed
---
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync Synchronize with entitlements in PSN Store.  
    Return Type

        Insert itemId
        Insert psnItemId
        Insert sku
        Insert status
        Insert transactionId
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/iap/psn/sync/multiServiceLabels Synchronize with entitlements in PSN Store with multiple service labels.  
    Return Type

        Insert itemId
        Insert psnItemId
        Insert sku
        Insert status
        Insert transactionId

## session Service

### What's Changed
---
`POST` /session/v1/admin/namespaces/{namespace}/configuration Create configuration template. Requires ADMIN:NAMESPACE:{namespace}:SESSION:CONFIGURATION [CREATE]  
    Parameters

        Insert body.textChat
`GET` /session/v1/admin/namespaces/{namespace}/configurations Get configuration templates. Requires ADMIN:NAMESPACE:{namespace}:SESSION:CONFIGURATION [READ]  
    Return Type

        Insert data.textChat
`PUT` /session/v1/admin/namespaces/{namespace}/configurations/{name} Update configuration template. Requires ADMIN:NAMESPACE:{namespace}:SESSION:CONFIGURATION [CREATE]  
    Parameters

        Insert body.textChat
    Return Type

        Insert textChat
`GET` /session/v1/admin/namespaces/{namespace}/configurations/{name} Get configuration template. Requires ADMIN:NAMESPACE:{namespace}:SESSION:CONFIGURATION [READ]  
    Return Type

        Insert textChat
`GET` /session/v1/admin/namespaces/{namespace}/gamesessions Get all game sessions.  
    Return Type

        Insert data.configuration.textChat
`GET` /session/v1/admin/namespaces/{namespace}/parties Query parties. Requires ADMIN:NAMESPACE:{namespace}:SESSION:PARTY [READ]  
    Return Type

        Insert data.configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/gamesession Create a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [CREATE]  
    Parameters

        Insert body.textChat
`POST` /session/v1/public/namespaces/{namespace}/gamesessions Query game sessions  
    Return Type

        Insert data.configuration.textChat
`GET` /session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName} Get game session detail. Requires NAMESPACE:{namespace}:SESSION:GAME [READ]  
    Return Type

        Insert configuration.textChat
`PUT` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Update a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [UPDATE]  
    Return Type

        Insert configuration.textChat
`PATCH` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Patch update a game session. Requires NAMESPACE:{namespace}:SESSION:GAME [UPDATE]  
    Return Type

        Insert configuration.textChat
`GET` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId} Get game session detail. Requires NAMESPACE:{namespace}:SESSION:GAME [READ]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join Join a game session. Requires NAMESPACE:{namespace}:SESSION:GAME:PLAYER [CREATE]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/parties/users/me/join/code Join a party by code. Requires NAMESPACE:{namespace}:SESSION:PARTY:PLAYER [CREATE]  
    Return Type

        Insert configuration.textChat
`PUT` /session/v1/public/namespaces/{namespace}/parties/{partyId} Update a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert configuration.textChat
`PATCH` /session/v1/public/namespaces/{namespace}/parties/{partyId} Patch update a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert configuration.textChat
`GET` /session/v1/public/namespaces/{namespace}/parties/{partyId} Get party details. Requires NAMESPACE:{namespace}:SESSION:PARTY [READ]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/code Generate party code. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert configuration.textChat
`DELETE` /session/v1/public/namespaces/{namespace}/parties/{partyId}/code Revoke party code. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/leader Promote new party leader. Requires NAMESPACE:{namespace}:SESSION:PARTY [UPDATE]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join Join a party. Requires NAMESPACE:{namespace}:SESSION:PARTY:PLAYER [CREATE]  
    Return Type

        Insert configuration.textChat
`POST` /session/v1/public/namespaces/{namespace}/party Create a party. Requires NAMESPACE:{namespace}:SESSION:PARTY [CREATE]  
    Parameters

        Insert body.textChat
    Return Type

        Insert configuration.textChat
`GET` /session/v1/public/namespaces/{namespace}/users/me/gamesessions Query user's game sessions  
    Return Type

        Insert configuration.textChat
`GET` /session/v1/public/namespaces/{namespace}/users/me/parties Query my parties. Require valid JWT.  
    Return Type

        Insert configuration.textChat


# C# Server SDK v0.21.0

## achievement Service

### What's Changed
---
`GET` /achievement/v1/admin/namespaces/{namespace}/achievements/export Export achievements configuration into a json file  
    Return Type

        Delete AchievementCode
        Delete CreatedAt
        Delete DefaultLanguage
        Delete Description
        Delete GoalValue
        Delete Hidden
        Delete ID
        Delete Incremental
        Delete ListOrder
        Delete LockedIcons
        Delete Name
        Delete Namespace
        Delete StatCode
        Delete Tags
        Delete UnlockedIcons
        Delete UpdatedAt
`GET` /achievement/v1/admin/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Return Type

        Modify data.achievedAt
`GET` /achievement/v1/public/namespaces/{namespace}/users/{userId}/achievements Query user achievements [include achieved and in-progress]  
    Return Type

        Modify data.achievedAt

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.
`POST` /game-telemetry/v1/protected/events Protected Save Events  
    Parameters

        Delete body.EventId
        Delete body.EventTimestamp

## iam Service

### What's Changed
---
`GET` /iam/oauth/revocationlist OAuth2 revocation list API  
    Return Type

        Modify revoked_tokens.bits
`GET` /iam/v3/admin/namespaces/{namespace}/platforms/all/clients Get All Third Party Platform Credential  
    Return Type

        Insert scopes //scopes for generic OAuth Authorization code flow
`GET` /iam/v3/admin/namespaces/{namespace}/platforms/all/clients/active Get All Active Third Party Platform Active Credential  
    Return Type

        Insert scopes //scopes for generic OAuth Authorization code flow
`POST` /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients Add Third Party Platform Credential  
    Parameters

        Insert body.scopes //scopes for generic OAuth Authorization code flow. Default is [openid, profile, email]
`GET` /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients Retrieve Third Party Platform Credential  
    Return Type

        Insert scopes //scopes for generic OAuth Authorization code flow
`PATCH` /iam/v3/admin/namespaces/{namespace}/platforms/{platformId}/clients Update Third Party Platform Credential  
    Parameters

        Insert body.scopes //scopes for generic OAuth Authorization code flow. Default is [openid, profile, email]
    Return Type

        Insert scopes //scopes for generic OAuth Authorization code flow
`GET` /iam/v3/oauth/authorize OAuth2 authorize API  
    Parameters

        Add useRedirectUriAsLoginUrlWhenLocked //Use Redirect URI as the Login URL after resetting password when got locked
`GET` /iam/v3/oauth/revocationlist OAuth2 revocation list API  
    Return Type

        Modify revoked_tokens.bits
`POST` /iam/v3/public/namespaces/{namespace}/users/bulk/basic Bulk get users' basic info by user Id  
    Return Type

        Insert data.username

## lobby Service

### What's Changed
---
`GET` /lobby/v1/admin/config/namespaces/{namespace}/export Export lobby config to a json file.  
    Return Type

        Delete allowInviteNonConnectedUser
        Delete allowJoinPartyDuringMatchmaking
        Delete autoKickOnDisconnect
        Delete autoKickOnDisconnectDelay
        Delete cancelTicketOnDisconnect
        Delete chatRateLimitBurst
        Delete chatRateLimitDuration
        Delete concurrentUsersLimit
        Delete disableInvitationOnJoinParty
        Delete enableChat
        Delete entitlementCheck
        Delete entitlementItemID
        Delete generalRateLimitBurst
        Delete generalRateLimitDuration
        Delete keepPresenceActivityOnDisconnect
        Delete maxDSWaitTime
        Delete maxPartyMember
        Delete namespace
        Delete profanityFilter
        Delete readyConsentTimeout

# C# Server SDK v0.20.0

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.
        Modify endTime //End time of data to be queried. Default: Current time in UTC.

# C# Server SDK v0.19.0

## basic Service

### What's New
---
* `GET` /basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes Get my private custom attributes
* `PUT` /basic/v1/public/namespaces/{namespace}/users/me/profiles/privateCustomAttributes Update partially private custom attributes tied to me

## dslogmanager Service

### What's Changed
---
`GET` /dslogmanager/namespaces/{namespace}/servers/search Retrieve All Terminated Servers  
    Return Type

        Insert data.server.allocation_events
`GET` /dslogmanager/servers/search Retrieve All Terminated Servers  
    Return Type

        Insert data.server.allocation_events

## dsmc Service

### What's Changed
---
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers List all managed servers in a region  
    Return Type

        Insert servers.allocation_events
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/local List all managed local servers  
    Return Type

        Insert servers.allocation_events
`GET` /dsmcontroller/admin/namespaces/{namespace}/servers/{podName} Query a server in a region  
    Return Type

        Insert allocation_events
`GET` /dsmcontroller/admin/namespaces/{namespace}/sessions List all managed sessions in a region  
    Return Type

        Insert sessions.Server.allocation_events
`POST` /dsmcontroller/namespaces/{namespace}/servers/local/register Register a local DS  
    Return Type

        Insert allocation_events
`POST` /dsmcontroller/namespaces/{namespace}/servers/register Register a DS  
    Return Type

        Insert allocation_events
`POST` /dsmcontroller/namespaces/{namespace}/sessions Register a new game session  
    Return Type

        Insert session.Server.allocation_events
`GET` /dsmcontroller/namespaces/{namespace}/sessions/{sessionID} Query specified session  
    Return Type

        Insert session.Server.allocation_events

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
* `GET` /iam/v4/admin/namespaces/{namespace}/devices Admin get devices by user id
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/banned Admin get banned devices
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/bans Admin get device bans of user
* `POST` /iam/v4/admin/namespaces/{namespace}/devices/bans Admin Ban a device
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/bans/{banId} Admin get device ban config
* `PUT` /iam/v4/admin/namespaces/{namespace}/devices/bans/{banId} Admin update device ban config
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/report Admin generate device report
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/types Admin get device types
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/bans Admin get device ban list
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/decrypt Admin decrypt device id
* `PUT` /iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/unban Admin unban device
* `GET` /iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/users Admin get users by device id

### What's Changed
---
`POST` /iam/clients Create Client  
    Parameters

        Insert body.TwoFactorEnabled
`GET` /iam/clients Get All Clients  
    Return Type

        Insert TwoFactorEnabled
`GET` /iam/clients/{clientId} Get Client  
    Return Type

        Insert TwoFactorEnabled
`PUT` /iam/clients/{clientId} Update Client  
    Parameters

        Insert body.TwoFactorEnabled
    Return Type

        Insert TwoFactorEnabled
`POST` /iam/namespaces/{namespace}/clients Create Client  
    Parameters

        Insert body.TwoFactorEnabled
`GET` /iam/namespaces/{namespace}/clients Get clients by namespace  
    Return Type

        Insert TwoFactorEnabled
`POST` /iam/oauth/namespaces/{namespace}/platforms/{platformId}/token OAuth2 access token generation specific to platform  
    Parameters

        Add macAddress //Mac address of device
`POST` /iam/v3/admin/namespaces/{namespace}/clients Create Client  
    Parameters

        Insert body.twoFactorEnabled
`GET` /iam/v3/admin/namespaces/{namespace}/clients Get clients by namespace  
    Return Type

        Insert data.twoFactorEnabled
`GET` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Get clients by namespace and client id  
    Return Type

        Insert twoFactorEnabled
`PATCH` /iam/v3/admin/namespaces/{namespace}/clients/{clientId} Update Client  
    Parameters

        Insert body.twoFactorEnabled
    Return Type

        Insert twoFactorEnabled
`POST` /iam/v3/oauth/platforms/{platformId}/token OAuth2 access token generation specific to platform  
    Parameters

        Add macAddress //Mac address of device
`POST` /iam/v3/oauth/token OAuth2 access token generation endpoint  
    Parameters

        Add Auth-Trust-Id //Auth-Trust-Id for Device Cookie Validation (Used on grant type 'password')
    Return Type

        Insert auth_trust_id //Authentication Trust Id for device cookie validation. Only exist when login using grant_type=password and no existing Auth-Trust-Id given from request header
`GET` /iam/v3/public/namespaces/{namespace}/requests/{requestId}/async/status Get Linking Progress Status  
    Return Type

        Insert refreshToken

## matchmaking Service

### What's Changed
---
`POST` /matchmaking/namespaces/{namespace}/sessions Queue joinable session  
    Parameters

        Insert body.error_code
        Insert body.error_message
`GET` /matchmaking/namespaces/{namespace}/sessions/{matchID}/status Query joinable session status  
    Return Type

        Insert error_code
        Insert error_message
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk Bulk get sessions  
    Return Type

        Insert error_code
        Insert error_message
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions Get all channel sessions  
    Return Type

        Insert error_code
        Insert error_message

## platform Service

### What's New
---
* `GET` /platform/admin/namespaces/{namespace}/keygroups/byBoothName Get key group by booth name
* `PUT` /platform/v2/admin/namespaces/{namespace}/stores/import Import a store
* `POST` /platform/v2/admin/namespaces/{namespace}/stores/{storeId}/export Export a store

### What's Changed
---
`GET` /platform/admin/namespaces/{namespace}/items/search Search items by keyword  
    Parameters

        Add sortBy //default is name:asc,createdAt:asc, allow values: [name, name:asc, name:desc, createdAt, createdAt:asc, createdAt:desc, updatedAt, updatedAt:asc, updatedAt:desc, displayOrder, displayOrder:asc, displayOrder:desc],and support sort group, eg: sortBy=name:asc,createdAt:desc. Make sure to always use more than one sort if the first sort is not an unique valuefor example, if you wish to sort by displayOrder, make sure to include other sort such as name or createdAt after the first sort, eg: displayOrder:asc,name:asc
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Parameters

        Insert body.requestId //Request id(Optional), client should provide a unique request id to perform at most once execution, When a request id is resubmitted, it will return original successful response
    Return Type

        Insert replayed //replayed, if true,the response is original successful response. This will not be included in response if client have not pass request id.
        Insert requestId //request id
`PUT` /platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement Consume user entitlement  
    Parameters

        Insert body.requestId //Request id(Optional), client should provide a unique request id to perform at most once execution, When a request id is resubmitted, it will return original successful response
    Return Type

        Insert replayed //replayed, if true,the response is original successful response. This will not be included in response if client have not pass request id.
        Insert requestId //request id

## social Service

### What's New
---
* `DELETE` /social/v1/admin/namespaces/{namespace}/stats/{statCode}/tied Deletes tied stat

### What's Changed
---
`PATCH` /social/v1/admin/namespaces/{namespace}/stats/{statCode} Update stat  
    Parameters

        Insert body.defaultValue

# C# Server SDK v0.18.0

## gametelemetry Service

### What's Changed
---
`GET` /game-telemetry/v1/admin/namespaces/{namespace}/events Get Events  
    Parameters

        Modify endTime //End time of data to be queried. Default: Current time in UTC.
        Modify startTime //Start time of data to be queried. Default: Current time in UTC minus 1 day.

## iam Service

### What's Changed
---
`DELETE` /iam/v3/admin/inputValidations/{field} Admin Reset Input Validations  
    Parameters

        field Notes Name of the input validation field to reset: username, displayName, or password change into Name of the input validation field to reset: email, username, displayName, or password
        Modify field //Name of the input validation field to reset: email, username, displayName, or password
`GET` /iam/v3/admin/namespaces/{namespace}/users/search Search User  
    Parameters

        platformId Notes Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, stadia, nintendo, oculus, aws cognito, facebook, google, discord, twitch, or snapchat change into Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, stadia, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon
        Modify platformId //Platform Id that want to be searched, supported values: steam, steamopenid, psn, xbox, epicgames, stadia, nintendo, oculus, aws cognito, facebook, google, discord, twitch, snapchat or amazon

## matchmaking Service

### What's Changed
---
`POST` /matchmaking/namespaces/{namespace}/channels Create a channel  
    Parameters

        Insert body.rule_set.alliance.combination.role_flexing_enable
        Insert body.rule_set.alliance.combination.role_flexing_player
        Insert body.rule_set.alliance.combination.role_flexing_second
        Insert body.rule_set.alliance_flexing_rule.combination.role_flexing_enable
        Insert body.rule_set.alliance_flexing_rule.combination.role_flexing_player
        Insert body.rule_set.alliance_flexing_rule.combination.role_flexing_second
`GET` /matchmaking/namespaces/{namespace}/channels Get all channels  
    Return Type

        Insert data.ruleset.alliance.combination.role_flexing_enable
        Insert data.ruleset.alliance.combination.role_flexing_player
        Insert data.ruleset.alliance.combination.role_flexing_second
        Insert data.ruleset.alliance_flexing_rule.combination.role_flexing_enable
        Insert data.ruleset.alliance_flexing_rule.combination.role_flexing_player
        Insert data.ruleset.alliance_flexing_rule.combination.role_flexing_second
`POST` /matchmaking/namespaces/{namespace}/rebalance Rebalance Matchmaking based on MMR  
    Return Type

        Insert matching_allies.matching_parties.ticket_id
`POST` /matchmaking/namespaces/{namespace}/sessions Queue joinable session  
    Parameters

        Insert body.ticket_id
        Insert body.matching_allies.matching_parties.ticket_id
`GET` /matchmaking/namespaces/{namespace}/sessions/{matchID}/status Query joinable session status  
    Return Type

        Insert ticket_id
        Insert matching_allies.matching_parties.ticket_id
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk Bulk get sessions  
    Return Type

        Insert ticket_id
        Insert matching_allies.matching_parties.ticket_id
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/export Export channels  
    Return Type

        Insert ruleSet.alliance.combination.role_flexing_enable
        Insert ruleSet.alliance.combination.role_flexing_player
        Insert ruleSet.alliance.combination.role_flexing_second
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_enable
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_player
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_second
`PATCH` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName} Update a channel  
    Parameters

        Insert body.ruleSet.alliance.combination.role_flexing_enable
        Insert body.ruleSet.alliance.combination.role_flexing_player
        Insert body.ruleSet.alliance.combination.role_flexing_second
        Insert body.ruleSet.alliance_flexing_rule.combination.role_flexing_enable
        Insert body.ruleSet.alliance_flexing_rule.combination.role_flexing_player
        Insert body.ruleSet.alliance_flexing_rule.combination.role_flexing_second
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName} Get single channel  
    Return Type

        Insert ruleSet.alliance.combination.role_flexing_enable
        Insert ruleSet.alliance.combination.role_flexing_player
        Insert ruleSet.alliance.combination.role_flexing_second
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_enable
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_player
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_second
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties Get all party in a channel  
    Return Type

        Insert ticket_id
`GET` /matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions Get all channel sessions  
    Return Type

        Insert ticket_id
        Insert matching_allies.matching_parties.ticket_id
`GET` /matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed Get session history detailed  
    Return Type

        Insert matching_allies.matching_parties.ticket_id
`GET` /matchmaking/v1/public/namespaces/{namespace}/channels Get all channels  
    Return Type

        Insert ruleSet.alliance.combination.role_flexing_enable
        Insert ruleSet.alliance.combination.role_flexing_player
        Insert ruleSet.alliance.combination.role_flexing_second
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_enable
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_player
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_second
`GET` /matchmaking/v1/public/namespaces/{namespace}/channels/{channelName} Get single channel  
    Return Type

        Insert ruleSet.alliance.combination.role_flexing_enable
        Insert ruleSet.alliance.combination.role_flexing_player
        Insert ruleSet.alliance.combination.role_flexing_second
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_enable
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_player
        Insert ruleSet.alliance_flexing_rule.combination.role_flexing_second

## platform Service

### What's Changed
---
`GET` /platform/admin/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Parameters

        Add includeSubCategoryItem //default is false, only available when search by category path, it will return all of the items(includes sub category path) under this category path
`PUT` /platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/payment Pay with user wallet by currency code and client platform  
    Return Type

        Insert status //status
        Modify walletStatus
`GET` /platform/public/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Parameters

        Add includeSubCategoryItem //default is false, only available when search by category path, it will return all of the items(includes sub category path) under this category path
`GET` /platform/public/namespaces/{namespace}/users/me/wallets/{currencyCode} Get my wallet by currency code and namespace  
    Return Type

        Insert status //status
        Modify walletStatus
`GET` /platform/public/namespaces/{namespace}/users/{userId}/wallets/{currencyCode} Get a wallet by currency code  
    Return Type

        Insert status //status
        Modify walletStatus
`GET` /platform/v2/admin/namespaces/{namespace}/items/byCriteria Query items by criteria  
    Parameters

        Add includeSubCategoryItem //default is false, only available when search by category path, it will return all of the items(includes sub category path) under this category path
        Modify sortBy //default is name:asc,displayOrder:asc, allow values: [name, name:asc, name:desc, createdAt, createdAt:asc, createdAt:desc, updatedAt, updatedAt:asc, updatedAt:desc, displayOrder, displayOrder:asc, displayOrder:desc],and support sort group, eg: sortBy=name:asc,createdAt:desc. Make sure to always use more than one sort if the first sort is not an unique valuefor example, if you wish to sort by displayOrder, make sure to include other sort such as name or createdAt after the first sort, eg: displayOrder:asc,name:asc

## sessionbrowser Service

### What's New
---
* `GET` /sessionbrowser/admin/namespaces/{namespace}/sessions/history/search Search sessions
* `GET` /sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed Get session history detailed

### What's Changed
---
`GET` /sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game Get all active session for matchmaking game, this return only dedicated session type  
    Return Type

        Insert sessions.match.matching_allies.matching_parties.match_attributes
`GET` /sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID} Admin get specified session by session ID  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`POST` /sessionbrowser/namespaces/{namespace}/gamesession Register a new game session  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`GET` /sessionbrowser/namespaces/{namespace}/gamesession Query to available game session  
    Return Type

        Insert sessions.match.matching_allies.matching_parties.match_attributes
`GET` /sessionbrowser/namespaces/{namespace}/gamesession/bulk Query game sessions by comma separated user ids  
    Return Type

        Insert data.match.matching_allies.matching_parties.match_attributes
`GET` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID} Get specified session by session ID  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`PUT` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID} Update session  
    Parameters

        Delete body.game_current_player
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`DELETE` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID} Delete specified session by session ID  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`POST` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join Join specified session by session ID  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`DELETE` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds Only use for local DS entry, will error when calling non local DS entry  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes
`PUT` /sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/settings Update settings  
    Return Type

        Insert match.matching_allies.matching_parties.match_attributes

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