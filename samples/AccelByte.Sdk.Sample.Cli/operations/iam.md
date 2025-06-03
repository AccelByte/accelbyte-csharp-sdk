## C# Extend SDK CLI Sample App Operation Index for Iam service.

### Operation AdminGetBansTypeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbanstypev3 \

```

### Operation AdminGetListBanReasonV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetlistbanreasonv3 \

```

### Operation AdminListClientAvailablePermissions
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistclientavailablepermissions \
    --excludePermissions <excludePermissions value - optional>
```

### Operation AdminUpdateAvailablePermissionsByModule
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateavailablepermissionsbymodule \
    --forceDelete <forceDelete value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteConfigPermissionsByGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteconfigpermissionsbygroup \
    --forceDelete <forceDelete value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListClientTemplates
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistclienttemplates \

```

### Operation AdminGetInputValidations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetinputvalidations \

```

### Operation AdminUpdateInputValidations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateinputvalidations \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminResetInputValidations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminresetinputvalidations \
    --field <field value>
```

### Operation ListAdminsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op listadminsv3 \
    --namespace <namespace value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --endDate <endDate value - optional> \
    --limit <limit value - optional> \
    --query <query value - optional> \
    --roleId <roleId value - optional> \
    --startDate <startDate value - optional>
```

### Operation AdminGetAgeRestrictionStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetagerestrictionstatusv3 \
    --namespace <namespace value>
```

### Operation AdminUpdateAgeRestrictionConfigV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateagerestrictionconfigv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetListCountryAgeRestrictionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetlistcountryagerestrictionv3 \
    --namespace <namespace value>
```

### Operation AdminUpdateCountryAgeRestrictionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdatecountryagerestrictionv3 \
    --countryCode <countryCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetBannedUsersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbannedusersv3 \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --banType <banType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminBanUserBulkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbanuserbulkv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUnbanUserBulkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminunbanuserbulkv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetBansTypeWithNamespaceV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbanstypewithnamespacev3 \
    --namespace <namespace value>
```

### Operation AdminGetClientsByNamespaceV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetclientsbynamespacev3 \
    --namespace <namespace value> \
    --clientId <clientId value - optional> \
    --clientName <clientName value - optional> \
    --clientType <clientType value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --skipLoginQueue <skipLoginQueue value - optional>
```

### Operation AdminBulkUpdateClientsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbulkupdateclientsv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCreateClientV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreateclientv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetClientsbyNamespacebyIDV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetclientsbynamespacebyidv3 \
    --clientId <clientId value> \
    --namespace <namespace value>
```

### Operation AdminDeleteClientV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteclientv3 \
    --clientId <clientId value> \
    --namespace <namespace value>
```

### Operation AdminUpdateClientV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateclientv3 \
    --clientId <clientId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateClientPermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateclientpermissionv3 \
    --clientId <clientId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddClientPermissionsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddclientpermissionsv3 \
    --clientId <clientId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteClientPermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteclientpermissionv3 \
    --action <action value> \
    --clientId <clientId value> \
    --namespace <namespace value> \
    --resource <resource value>
```

### Operation AdminGetConfigValueV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetconfigvaluev3 \
    --configKey <configKey value> \
    --namespace <namespace value>
```

### Operation AdminGetCountryListV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetcountrylistv3 \
    --namespace <namespace value> \
    --filterBlacklist <filterBlacklist value - optional>
```

### Operation AdminGetCountryBlacklistV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetcountryblacklistv3 \
    --namespace <namespace value>
```

### Operation AdminAddCountryBlacklistV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddcountryblacklistv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetLoginAllowlistV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetloginallowlistv3 \
    --namespace <namespace value>
```

### Operation AdminUpdateLoginAllowlistV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateloginallowlistv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveAllThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveallthirdpartyloginplatformcredentialv3 \
    --namespace <namespace value>
```

### Operation RetrieveAllActiveThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveallactivethirdpartyloginplatformcredentialv3 \
    --namespace <namespace value>
```

### Operation RetrieveAllSSOLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveallssologinplatformcredentialv3 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation RetrieveThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrievethirdpartyloginplatformcredentialv3 \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation AddThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op addthirdpartyloginplatformcredentialv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op deletethirdpartyloginplatformcredentialv3 \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation UpdateThirdPartyLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op updatethirdpartyloginplatformcredentialv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateThirdPartyLoginPlatformDomainV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op updatethirdpartyloginplatformdomainv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteThirdPartyLoginPlatformDomainV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op deletethirdpartyloginplatformdomainv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PartialUpdateThirdPartyLoginPlatformDomainV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op partialupdatethirdpartyloginplatformdomainv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrieveSSOLoginPlatformCredential
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrievessologinplatformcredential \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation AddSSOLoginPlatformCredential
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op addssologinplatformcredential \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteSSOLoginPlatformCredentialV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op deletessologinplatformcredentialv3 \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation UpdateSSOPlatformCredential
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op updatessoplatformcredential \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListUserIDByPlatformUserIDsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistuseridbyplatformuseridsv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --rawPID <rawPID value - optional> \
    --rawPUID <rawPUID value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserByPlatformUserIDV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserbyplatformuseridv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --platformUserId <platformUserId value> \
    --pidType <pidType value - optional>
```

### Operation AdminGetProfileUpdateStrategyV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetprofileupdatestrategyv3 \
    --namespace <namespace value> \
    --field <field value - optional>
```

### Operation AdminUpdateProfileUpdateStrategyV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateprofileupdatestrategyv3 \
    --namespace <namespace value> \
    --field <field value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleOverrideConfigV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetroleoverrideconfigv3 \
    --namespace <namespace value> \
    --identity <identity value>
```

### Operation AdminUpdateRoleOverrideConfigV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateroleoverrideconfigv3 \
    --namespace <namespace value> \
    --identity <identity value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleSourceV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolesourcev3 \
    --namespace <namespace value> \
    --identity <identity value>
```

### Operation AdminChangeRoleOverrideConfigStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminchangeroleoverrideconfigstatusv3 \
    --namespace <namespace value> \
    --identity <identity value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleNamespacePermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolenamespacepermissionv3 \
    --namespace <namespace value> \
    --roleId <roleId value>
```

### Operation GetAdminUsersByRoleIdV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getadminusersbyroleidv3 \
    --namespace <namespace value> \
    --roleId <roleId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminQueryTagV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminquerytagv3 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tagName <tagName value - optional>
```

### Operation AdminCreateTagV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreatetagv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateTagV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdatetagv3 \
    --namespace <namespace value> \
    --tagId <tagId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteTagV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeletetagv3 \
    --namespace <namespace value> \
    --tagId <tagId value>
```

### Operation AdminGetUserByEmailAddressV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserbyemailaddressv3 \
    --namespace <namespace value> \
    --emailAddress <emailAddress value - optional>
```

### Operation AdminBulkUpdateUsersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbulkupdateusersv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetBulkUserBanV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbulkuserbanv3 \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --banType <banType value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListUserIDByUserIDsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistuseridbyuseridsv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkGetUsersPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbulkgetusersplatform \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCursorGetUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincursorgetuserv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminInviteUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admininviteuserv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminQueryThirdPlatformLinkHistoryV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminquerythirdplatformlinkhistoryv3 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platformUserId <platformUserId value - optional> \
    --platformId <platformId value>
```

### Operation AdminListUsersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistusersv3 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminSearchUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminsearchuserv3 \
    --namespace <namespace value> \
    --by <by value - optional> \
    --endDate <endDate value - optional> \
    --includeTotal <includeTotal value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platformBy <platformBy value - optional> \
    --platformId <platformId value - optional> \
    --query <query value - optional> \
    --roleIds <roleIds value - optional> \
    --selectedFields <selectedFields value - optional> \
    --skipLoginQueue <skipLoginQueue value - optional> \
    --startDate <startDate value - optional> \
    --tagIds <tagIds value - optional> \
    --testAccount <testAccount value - optional>
```

### Operation AdminGetBulkUserByEmailAddressV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbulkuserbyemailaddressv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserByUserIdV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserbyuseridv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserBanV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserbanv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminBanUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbanuserv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserBanSummaryV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserbansummaryv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserBanV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserbanv3 \
    --banId <banId value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSendVerificationCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminsendverificationcodev3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminVerifyAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminverifyaccountv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetUserVerificationCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getuserverificationcode \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetUserDeletionStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserdeletionstatusv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserDeletionStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserdeletionstatusv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListUserAllPlatformAccountsDistinctV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistuserallplatformaccountsdistinctv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpgradeHeadlessAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupgradeheadlessaccountv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteUserInformationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserinformationv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetUserLoginHistoriesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserloginhistoriesv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminResetPasswordV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminresetpasswordv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateUserPermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserpermissionv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddUserPermissionsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminadduserpermissionsv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteUserPermissionBulkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserpermissionbulkv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteUserPermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserpermissionv3 \
    --action <action value> \
    --namespace <namespace value> \
    --resource <resource value> \
    --userId <userId value>
```

### Operation AdminGetUserPlatformAccountsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserplatformaccountsv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional> \
    --platformId <platformId value - optional> \
    --targetNamespace <targetNamespace value - optional>
```

### Operation AdminListAllDistinctPlatformAccountsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistalldistinctplatformaccountsv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --status <status value - optional>
```

### Operation AdminGetListJusticePlatformAccounts
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetlistjusticeplatformaccounts \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetUserMapping
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetusermapping \
    --namespace <namespace value> \
    --targetNamespace <targetNamespace value> \
    --userId <userId value>
```

### Operation AdminCreateJusticeUser
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreatejusticeuser \
    --namespace <namespace value> \
    --targetNamespace <targetNamespace value> \
    --userId <userId value>
```

### Operation AdminLinkPlatformAccount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlinkplatformaccount \
    --namespace <namespace value> \
    --userId <userId value> \
    --skipConflict <skipConflict value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserLinkHistoriesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserlinkhistoriesv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --platformId <platformId value>
```

### Operation AdminPlatformUnlinkAllV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminplatformunlinkallv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value>
```

### Operation AdminPlatformLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminplatformlinkv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value> \
    --ticket <ticket value>
```

### Operation AdminDeleteUserLinkingRestrictionByPlatformIDV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserlinkingrestrictionbyplatformidv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value>
```

### Operation AdminGetThirdPartyPlatformTokenLinkStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetthirdpartyplatformtokenlinkstatusv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value> \
    --platformToken <platformToken value>
```

### Operation AdminGetUserSinglePlatformAccount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetusersingleplatformaccount \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value> \
    --crossNamespace <crossNamespace value - optional>
```

### Operation AdminDeleteUserRolesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserrolesv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSaveUserRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminsaveuserrolev3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddUserRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminadduserrolev3 \
    --namespace <namespace value> \
    --roleId <roleId value> \
    --userId <userId value>
```

### Operation AdminDeleteUserRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleteuserrolev3 \
    --namespace <namespace value> \
    --roleId <roleId value> \
    --userId <userId value>
```

### Operation AdminGetUserStateByUserIdV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserstatebyuseridv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserstatusv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminTrustlyUpdateUserIdentity
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admintrustlyupdateuseridentity \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminVerifyUserWithoutVerificationCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminverifyuserwithoutverificationcodev3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateClientSecretV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateclientsecretv3 \
    --clientId <clientId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCheckThirdPartyLoginPlatformAvailabilityV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincheckthirdpartyloginplatformavailabilityv3 \
    --platformId <platformId value>
```

### Operation AdminGetRolesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolesv3 \
    --after <after value - optional> \
    --before <before value - optional> \
    --isWildcard <isWildcard value - optional> \
    --limit <limit value - optional>
```

### Operation AdminCreateRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreaterolev3 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolev3 \
    --roleId <roleId value>
```

### Operation AdminDeleteRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleterolev3 \
    --roleId <roleId value>
```

### Operation AdminUpdateRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdaterolev3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleAdminStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetroleadminstatusv3 \
    --roleId <roleId value>
```

### Operation AdminUpdateAdminRoleStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateadminrolestatusv3 \
    --roleId <roleId value>
```

### Operation AdminRemoveRoleAdminV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminremoveroleadminv3 \
    --roleId <roleId value>
```

### Operation AdminGetRoleManagersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolemanagersv3 \
    --roleId <roleId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminAddRoleManagersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddrolemanagersv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRemoveRoleManagersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminremoverolemanagersv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleMembersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolemembersv3 \
    --roleId <roleId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminAddRoleMembersV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddrolemembersv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateRolePermissionsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdaterolepermissionsv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddRolePermissionsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddrolepermissionsv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteRolePermissionsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleterolepermissionsv3 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteRolePermissionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleterolepermissionv3 \
    --action <action value> \
    --resource <resource value> \
    --roleId <roleId value>
```

### Operation AdminGetMyUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetmyuserv3 \

```

### Operation UserAuthenticationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op userauthenticationv3 \
    --client_id <client_id value - optional> \
    --extend_exp <extend_exp value - optional> \
    --redirect_uri <redirect_uri value - optional> \
    --password <password value> \
    --request_id <request_id value> \
    --user_name <user_name value>
```

### Operation AuthenticationWithPlatformLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op authenticationwithplatformlinkv3 \
    --extend_exp <extend_exp value - optional> \
    --client_id <client_id value> \
    --linkingToken <linkingToken value> \
    --password <password value> \
    --username <username value>
```

### Operation AuthenticateAndLinkForwardV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op authenticateandlinkforwardv3 \
    --extend_exp <extend_exp value - optional> \
    --client_id <client_id value> \
    --linkingToken <linkingToken value> \
    --password <password value> \
    --username <username value>
```

### Operation PublicGetSystemConfigV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetsystemconfigv3 \

```

### Operation GenerateTokenByNewHeadlessAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op generatetokenbynewheadlessaccountv3 \
    --additionalData <additionalData value - optional> \
    --extend_exp <extend_exp value - optional> \
    --linkingToken <linkingToken value>
```

### Operation RequestOneTimeLinkingCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op requestonetimelinkingcodev3 \
    --redirectUri <redirectUri value - optional> \
    --state <state value - optional> \
    --platformId <platformId value>
```

### Operation ValidateOneTimeLinkingCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op validateonetimelinkingcodev3 \
    --oneTimeLinkCode <oneTimeLinkCode value>
```

### Operation RequestTokenByOneTimeLinkCodeResponseV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op requesttokenbyonetimelinkcoderesponsev3 \
    --additionalData <additionalData value - optional> \
    --isTransient <isTransient value - optional> \
    --client_id <client_id value> \
    --oneTimeLinkCode <oneTimeLinkCode value>
```

### Operation GetCountryLocationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getcountrylocationv3 \

```

### Operation Logout
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op logout \

```

### Operation RequestTokenExchangeCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op requesttokenexchangecodev3 \
    --namespace <namespace value> \
    --codeChallenge <codeChallenge value - optional> \
    --codeChallengeMethod <codeChallengeMethod value - optional> \
    --client_id <client_id value>
```

### Operation AdminRetrieveUserThirdPartyPlatformTokenV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminretrieveuserthirdpartyplatformtokenv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value> \
    --platformUserId <platformUserId value - optional>
```

### Operation RevokeUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op revokeuserv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --includeGameNamespace <includeGameNamespace value - optional>
```

### Operation AuthorizeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op authorizev3 \
    --blockedPlatformId <blockedPlatformId value - optional> \
    --codeChallenge <codeChallenge value - optional> \
    --codeChallengeMethod <codeChallengeMethod value - optional> \
    --createHeadless <createHeadless value - optional> \
    --loginWebBased <loginWebBased value - optional> \
    --nonce <nonce value - optional> \
    --oneTimeLinkCode <oneTimeLinkCode value - optional> \
    --redirectUri <redirectUri value - optional> \
    --scope <scope value - optional> \
    --state <state value - optional> \
    --targetAuthPage <targetAuthPage value - optional> \
    --useRedirectUriAsLoginUrlWhenLocked <useRedirectUriAsLoginUrlWhenLocked value - optional> \
    --clientId <clientId value> \
    --responseType <responseType value>
```

### Operation TokenIntrospectionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op tokenintrospectionv3 \
    --token <token value>
```

### Operation GetJWKSV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getjwksv3 \

```

### Operation SendMFAAuthenticationCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op sendmfaauthenticationcode \
    --clientId <clientId value> \
    --factor <factor value> \
    --mfaToken <mfaToken value>
```

### Operation Change2faMethod
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op change2famethod \
    --factor <factor value> \
    --mfaToken <mfaToken value>
```

### Operation Verify2faCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op verify2facode \
    --code <code value> \
    --factor <factor value> \
    --mfaToken <mfaToken value> \
    --rememberDevice <rememberDevice value>
```

### Operation Verify2faCodeForward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op verify2facodeforward \
    --defaultFactor <defaultFactor value - optional> \
    --factors <factors value - optional> \
    --rememberDevice <rememberDevice value - optional> \
    --clientId <clientId value> \
    --code <code value> \
    --factor <factor value> \
    --mfaToken <mfaToken value>
```

### Operation RetrieveUserThirdPartyPlatformTokenV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveuserthirdpartyplatformtokenv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --userId <userId value>
```

### Operation AuthCodeRequestV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op authcoderequestv3 \
    --platformId <platformId value> \
    --clientId <clientId value - optional> \
    --redirectUri <redirectUri value - optional> \
    --requestId <requestId value>
```

### Operation PlatformTokenGrantV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op platformtokengrantv3 \
    --platformId <platformId value> \
    --additionalData <additionalData value - optional> \
    --client_id <client_id value - optional> \
    --createHeadless <createHeadless value - optional> \
    --device_id <device_id value - optional> \
    --macAddress <macAddress value - optional> \
    --platform_token <platform_token value - optional> \
    --serviceLabel <serviceLabel value - optional> \
    --skipSetCookie <skipSetCookie value - optional>
```

### Operation GetRevocationListV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getrevocationlistv3 \

```

### Operation TokenRevocationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op tokenrevocationv3 \
    --token <token value>
```

### Operation SimultaneousLoginV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op simultaneousloginv3 \
    --simultaneousPlatform <simultaneousPlatform value - optional> \
    --simultaneousTicket <simultaneousTicket value - optional> \
    --nativePlatform <nativePlatform value> \
    --nativePlatformTicket <nativePlatformTicket value>
```

### Operation TokenGrantV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op tokengrantv3 \
    --Auth-Trust-Id <Auth-Trust-Id value - optional> \
        
    --device_id <device_id value - optional> \
        
    --additionalData <additionalData value - optional> \
    --client_id <client_id value - optional> \
    --client_secret <client_secret value - optional> \
    --code <code value - optional> \
    --code_verifier <code_verifier value - optional> \
    --extendNamespace <extendNamespace value - optional> \
    --extend_exp <extend_exp value - optional> \
    --password <password value - optional> \
    --redirect_uri <redirect_uri value - optional> \
    --refresh_token <refresh_token value - optional> \
    --scope <scope value - optional> \
    --username <username value - optional> \
    --grant_type <grant_type value>
```

### Operation VerifyTokenV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op verifytokenv3 \
    --token <token value>
```

### Operation PlatformAuthenticationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op platformauthenticationv3 \
    --platformId <platformId value> \
    --code <code value - optional> \
    --error <error value - optional> \
    --openidAssocHandle <openidAssocHandle value - optional> \
    --openidClaimedId <openidClaimedId value - optional> \
    --openidIdentity <openidIdentity value - optional> \
    --openidMode <openidMode value - optional> \
    --openidNs <openidNs value - optional> \
    --openidOpEndpoint <openidOpEndpoint value - optional> \
    --openidResponseNonce <openidResponseNonce value - optional> \
    --openidReturnTo <openidReturnTo value - optional> \
    --openidSig <openidSig value - optional> \
    --openidSigned <openidSigned value - optional> \
    --state <state value>
```

### Operation PlatformTokenRefreshV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op platformtokenrefreshv3 \
    --platformId <platformId value> \
    --platform_token <platform_token value>
```

### Operation PublicGetInputValidations
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetinputvalidations \
    --defaultOnEmpty <defaultOnEmpty value - optional> \
    --languageCode <languageCode value - optional>
```

### Operation PublicGetInputValidationByField
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetinputvalidationbyfield \
    --field <field value>
```

### Operation PublicGetCountryAgeRestrictionV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetcountryagerestrictionv3 \
    --countryCode <countryCode value> \
    --namespace <namespace value>
```

### Operation PublicGetConfigValueV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetconfigvaluev3 \
    --configKey <configKey value> \
    --namespace <namespace value>
```

### Operation PublicGetCountryListV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetcountrylistv3 \
    --namespace <namespace value>
```

### Operation RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveallactivethirdpartyloginplatformcredentialpublicv3 \
    --namespace <namespace value>
```

### Operation RetrieveActiveOIDCClientsPublicV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op retrieveactiveoidcclientspublicv3 \
    --namespace <namespace value> \
    --clientId <clientId value>
```

### Operation PublicGetProfileUpdateStrategyV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetprofileupdatestrategyv3 \
    --namespace <namespace value> \
    --field <field value - optional>
```

### Operation PublicGetAsyncStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetasyncstatus \
    --namespace <namespace value> \
    --requestId <requestId value>
```

### Operation PublicSearchUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsearchuserv3 \
    --namespace <namespace value> \
    --by <by value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platformBy <platformBy value - optional> \
    --platformId <platformId value - optional> \
    --query <query value - optional>
```

### Operation PublicCreateUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiccreateuserv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CheckUserAvailability
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op checkuseravailability \
    --namespace <namespace value> \
    --field <field value> \
    --query <query value>
```

### Operation PublicSendRegistrationCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsendregistrationcode \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicVerifyRegistrationCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicverifyregistrationcode \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicForgotPasswordV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicforgotpasswordv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicValidateUserInput
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicvalidateuserinput \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAdminInvitationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op getadmininvitationv3 \
    --invitationId <invitationId value> \
    --namespace <namespace value>
```

### Operation CreateUserFromInvitationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op createuserfrominvitationv3 \
    --invitationId <invitationId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op updateuserv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicPartialUpdateUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicpartialupdateuserv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicSendVerificationCodeV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsendverificationcodev3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUserVerificationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicuserverificationv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpgradeHeadlessAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupgradeheadlessaccountv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicVerifyHeadlessAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicverifyheadlessaccountv3 \
    --namespace <namespace value> \
    --needVerificationCode <needVerificationCode value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdatePasswordV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupdatepasswordv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCreateJusticeUser
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiccreatejusticeuser \
    --namespace <namespace value> \
    --targetNamespace <targetNamespace value>
```

### Operation PublicPlatformLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicplatformlinkv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --redirectUri <redirectUri value - optional> \
    --ticket <ticket value>
```

### Operation PublicPlatformUnlinkAllV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicplatformunlinkallv3 \
    --namespace <namespace value> \
    --platformId <platformId value>
```

### Operation PublicForcePlatformLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicforceplatformlinkv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --ticket <ticket value>
```

### Operation PublicWebLinkPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicweblinkplatform \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --clientId <clientId value - optional> \
    --redirectUri <redirectUri value - optional>
```

### Operation PublicWebLinkPlatformEstablish
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicweblinkplatformestablish \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --code <code value - optional> \
    --state <state value>
```

### Operation PublicProcessWebLinkPlatformV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicprocessweblinkplatformv3 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --code <code value - optional> \
    --state <state value>
```

### Operation PublicGetUsersPlatformInfosV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetusersplatforminfosv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ResetPasswordV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op resetpasswordv3 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserBanHistoryV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserbanhistoryv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --activeOnly <activeOnly value - optional> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation PublicListUserAllPlatformAccountsDistinctV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiclistuserallplatformaccountsdistinctv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicGetUserInformationV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserinformationv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicGetUserLoginHistoriesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserloginhistoriesv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation PublicGetUserPlatformAccountsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserplatformaccountsv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional> \
    --platformId <platformId value - optional>
```

### Operation PublicListJusticePlatformAccountsV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiclistjusticeplatformaccountsv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicLinkPlatformAccount
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiclinkplatformaccount \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicForceLinkPlatformWithProgression
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicforcelinkplatformwithprogression \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetPublisherUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetpublisheruserv3 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicValidateUserByUserIDAndPasswordV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicvalidateuserbyuseridandpasswordv3 \
    --namespace <namespace value> \
    --userId <userId value> \
    --password <password value>
```

### Operation PublicGetRolesV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetrolesv3 \
    --after <after value - optional> \
    --before <before value - optional> \
    --isWildcard <isWildcard value - optional> \
    --limit <limit value - optional>
```

### Operation PublicGetRoleV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetrolev3 \
    --roleId <roleId value>
```

### Operation PublicForgotPasswordWithoutNamespaceV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicforgotpasswordwithoutnamespacev3 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetMyUserV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetmyuserv3 \
    --includeAllPlatforms <includeAllPlatforms value - optional>
```

### Operation PublicSendCodeForwardV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsendcodeforwardv3 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetLinkHeadlessAccountToMyAccountConflictV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetlinkheadlessaccounttomyaccountconflictv3 \
    --oneTimeLinkCode <oneTimeLinkCode value>
```

### Operation LinkHeadlessAccountToMyAccountV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op linkheadlessaccounttomyaccountv3 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetMyRedirectionAfterLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetmyredirectionafterlinkv3 \
    --oneTimeLinkCode <oneTimeLinkCode value>
```

### Operation PublicGetMyProfileAllowUpdateStatusV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetmyprofileallowupdatestatusv3 \

```

### Operation PublicSendVerificationLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsendverificationlinkv3 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetOpenidUserInfoV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetopeniduserinfov3 \

```

### Operation PublicVerifyUserByLinkV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicverifyuserbylinkv3 \
    --code <code value - optional>
```

### Operation PlatformAuthenticateSAMLV3Handler
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op platformauthenticatesamlv3handler \
    --platformId <platformId value> \
    --code <code value - optional> \
    --error <error value - optional> \
    --state <state value>
```

### Operation LoginSSOClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op loginssoclient \
    --platformId <platformId value> \
    --payload <payload value - optional>
```

### Operation LogoutSSOClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op logoutssoclient \
    --platformId <platformId value>
```

### Operation RequestTargetTokenResponseV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op requesttargettokenresponsev3 \
    --additionalData <additionalData value - optional> \
    --code <code value>
```

### Operation UpgradeAndAuthenticateForwardV3
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op upgradeandauthenticateforwardv3 \
    --client_id <client_id value> \
    --upgrade_success_token <upgrade_success_token value>
```

### Operation AdminListInvitationHistoriesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistinvitationhistoriesv4 \
    --limit <limit value - optional> \
    --namespace_ <namespace_ value - optional> \
    --offset <offset value - optional>
```

### Operation AdminGetDevicesByUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetdevicesbyuserv4 \
    --namespace <namespace value> \
    --userId <userId value - optional>
```

### Operation AdminGetBannedDevicesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbanneddevicesv4 \
    --namespace <namespace value> \
    --deviceType <deviceType value - optional> \
    --endDate <endDate value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startDate <startDate value - optional>
```

### Operation AdminGetUserDeviceBansV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetuserdevicebansv4 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminBanDeviceV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbandevicev4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetDeviceBanV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetdevicebanv4 \
    --banId <banId value> \
    --namespace <namespace value>
```

### Operation AdminUpdateDeviceBanV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdatedevicebanv4 \
    --banId <banId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGenerateReportV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingeneratereportv4 \
    --namespace <namespace value> \
    --endDate <endDate value - optional> \
    --startDate <startDate value - optional> \
    --deviceType <deviceType value>
```

### Operation AdminGetDeviceTypesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetdevicetypesv4 \
    --namespace <namespace value>
```

### Operation AdminGetDeviceBansV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetdevicebansv4 \
    --deviceId <deviceId value> \
    --namespace <namespace value>
```

### Operation AdminUnbanDeviceV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminunbandevicev4 \
    --deviceId <deviceId value> \
    --namespace <namespace value>
```

### Operation AdminGetUsersByDeviceV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetusersbydevicev4 \
    --deviceId <deviceId value> \
    --namespace <namespace value>
```

### Operation AdminGetNamespaceInvitationHistoryV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetnamespaceinvitationhistoryv4 \
    --namespace <namespace value>
```

### Operation AdminGetNamespaceUserInvitationHistoryV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetnamespaceuserinvitationhistoryv4 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateTestUsersV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreatetestusersv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminCreateUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreateuserv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkUpdateUserAccountTypeV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbulkupdateuseraccounttypev4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkCheckValidUserIDV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminbulkcheckvaliduseridv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserv4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateUserEmailAddressV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuseremailaddressv4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDisableUserMFAV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindisableusermfav4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetUserMFAStatusV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetusermfastatusv4 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminListUserRolesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistuserrolesv4 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminUpdateUserRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdateuserrolev4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddUserRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminadduserrolev4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRemoveUserRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminremoveuserrolev4 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRolesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolesv4 \
    --adminRole <adminRole value - optional> \
    --isWildcard <isWildcard value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminCreateRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admincreaterolev4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetrolev4 \
    --roleId <roleId value>
```

### Operation AdminDeleteRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleterolev4 \
    --roleId <roleId value>
```

### Operation AdminUpdateRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdaterolev4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateRolePermissionsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdaterolepermissionsv4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddRolePermissionsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminaddrolepermissionsv4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteRolePermissionsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindeleterolepermissionsv4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListAssignedUsersV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminlistassignedusersv4 \
    --roleId <roleId value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation AdminAssignUserToRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminassignusertorolev4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRevokeUserFromRoleV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminrevokeuserfromrolev4 \
    --roleId <roleId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminInviteUserNewV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admininviteusernewv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUpdateMyUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminupdatemyuserv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDisableMyAuthenticatorV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindisablemyauthenticatorv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminEnableMyAuthenticatorV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminenablemyauthenticatorv4 \
    --code <code value>
```

### Operation AdminGenerateMyAuthenticatorKeyV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingeneratemyauthenticatorkeyv4 \

```

### Operation AdminDisableMyBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindisablemybackupcodesv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetbackupcodesv4 \
    --languageTag <languageTag value - optional>
```

### Operation AdminGenerateBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingeneratebackupcodesv4 \
    --languageTag <languageTag value - optional>
```

### Operation AdminEnableBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminenablebackupcodesv4 \
    --languageTag <languageTag value - optional>
```

### Operation AdminChallengeMyMFAV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminchallengemymfav4 \
    --code <code value - optional> \
    --factor <factor value - optional>
```

### Operation AdminSendMyMFAEmailCodeV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminsendmymfaemailcodev4 \
    --action <action value - optional> \
    --languageTag <languageTag value - optional>
```

### Operation AdminDisableMyEmailV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admindisablemyemailv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminEnableMyEmailV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminenablemyemailv4 \
    --code <code value>
```

### Operation AdminGetMyEnabledFactorsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetmyenabledfactorsv4 \

```

### Operation AdminMakeFactorMyDefaultV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op adminmakefactormydefaultv4 \
    --factor <factor value>
```

### Operation AdminGetMyOwnMFAStatusV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op admingetmyownmfastatusv4 \

```

### Operation AuthenticationWithPlatformLinkV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op authenticationwithplatformlinkv4 \
    --extend_exp <extend_exp value - optional> \
    --client_id <client_id value> \
    --linkingToken <linkingToken value> \
    --password <password value> \
    --username <username value>
```

### Operation GenerateTokenByNewHeadlessAccountV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op generatetokenbynewheadlessaccountv4 \
    --additionalData <additionalData value - optional> \
    --extend_exp <extend_exp value - optional> \
    --linkingToken <linkingToken value>
```

### Operation Verify2faCodeV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op verify2facodev4 \
    --code <code value> \
    --factor <factor value> \
    --mfaToken <mfaToken value> \
    --rememberDevice <rememberDevice value>
```

### Operation PlatformTokenGrantV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op platformtokengrantv4 \
    --platformId <platformId value> \
    --codeChallenge <codeChallenge value - optional> \
    --codeChallengeMethod <codeChallengeMethod value - optional> \
    --additionalData <additionalData value - optional> \
    --client_id <client_id value - optional> \
    --createHeadless <createHeadless value - optional> \
    --device_id <device_id value - optional> \
    --macAddress <macAddress value - optional> \
    --platform_token <platform_token value - optional> \
    --serviceLabel <serviceLabel value - optional> \
    --skipSetCookie <skipSetCookie value - optional>
```

### Operation SimultaneousLoginV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op simultaneousloginv4 \
    --codeChallenge <codeChallenge value - optional> \
    --codeChallengeMethod <codeChallengeMethod value - optional> \
    --simultaneousPlatform <simultaneousPlatform value - optional> \
    --simultaneousTicket <simultaneousTicket value - optional> \
    --nativePlatform <nativePlatform value> \
    --nativePlatformTicket <nativePlatformTicket value>
```

### Operation TokenGrantV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op tokengrantv4 \
    --Auth-Trust-Id <Auth-Trust-Id value - optional> \
        
    --device_id <device_id value - optional> \
        
    --codeChallenge <codeChallenge value - optional> \
    --codeChallengeMethod <codeChallengeMethod value - optional> \
    --additionalData <additionalData value - optional> \
    --client_id <client_id value - optional> \
    --client_secret <client_secret value - optional> \
    --code <code value - optional> \
    --code_verifier <code_verifier value - optional> \
    --extendNamespace <extendNamespace value - optional> \
    --extend_exp <extend_exp value - optional> \
    --login_queue_ticket <login_queue_ticket value - optional> \
    --password <password value - optional> \
    --redirect_uri <redirect_uri value - optional> \
    --refresh_token <refresh_token value - optional> \
    --scope <scope value - optional> \
    --username <username value - optional> \
    --grant_type <grant_type value>
```

### Operation RequestTargetTokenResponseV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op requesttargettokenresponsev4 \
    --additionalData <additionalData value - optional> \
    --code <code value>
```

### Operation PublicListUserIDByPlatformUserIDsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiclistuseridbyplatformuseridsv4 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --rawPUID <rawPUID value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserByPlatformUserIDV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserbyplatformuseridv4 \
    --namespace <namespace value> \
    --platformId <platformId value> \
    --platformUserId <platformUserId value>
```

### Operation PublicCreateTestUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiccreatetestuserv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCreateUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publiccreateuserv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateUserFromInvitationV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op createuserfrominvitationv4 \
    --invitationId <invitationId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupdateuserv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpdateUserEmailAddressV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupdateuseremailaddressv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpgradeHeadlessAccountWithVerificationCodeV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupgradeheadlessaccountwithverificationcodev4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpgradeHeadlessAccountV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupgradeheadlessaccountv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDisableMyAuthenticatorV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicdisablemyauthenticatorv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicEnableMyAuthenticatorV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicenablemyauthenticatorv4 \
    --namespace <namespace value> \
    --code <code value>
```

### Operation PublicGenerateMyAuthenticatorKeyV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgeneratemyauthenticatorkeyv4 \
    --namespace <namespace value>
```

### Operation PublicDisableMyBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicdisablemybackupcodesv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetbackupcodesv4 \
    --namespace <namespace value> \
    --languageTag <languageTag value - optional>
```

### Operation PublicGenerateBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgeneratebackupcodesv4 \
    --namespace <namespace value> \
    --languageTag <languageTag value - optional>
```

### Operation PublicEnableBackupCodesV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicenablebackupcodesv4 \
    --namespace <namespace value> \
    --languageTag <languageTag value - optional>
```

### Operation PublicChallengeMyMFAV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicchallengemymfav4 \
    --namespace <namespace value> \
    --code <code value - optional> \
    --factor <factor value - optional>
```

### Operation PublicRemoveTrustedDeviceV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicremovetrusteddevicev4 \
    --Cookie <Cookie value - optional> \
        
    --namespace <namespace value> \
    --device_token <device_token value>
```

### Operation PublicSendMyMFAEmailCodeV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicsendmymfaemailcodev4 \
    --namespace <namespace value> \
    --action <action value - optional> \
    --languageTag <languageTag value - optional>
```

### Operation PublicDisableMyEmailV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicdisablemyemailv4 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicEnableMyEmailV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicenablemyemailv4 \
    --namespace <namespace value> \
    --code <code value>
```

### Operation PublicGetMyEnabledFactorsV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetmyenabledfactorsv4 \
    --namespace <namespace value>
```

### Operation PublicMakeFactorMyDefaultV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicmakefactormydefaultv4 \
    --namespace <namespace value> \
    --factor <factor value>
```

### Operation PublicGetMyOwnMFAStatusV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetmyownmfastatusv4 \
    --namespace <namespace value>
```

### Operation PublicGetUserPublicInfoByUserIdV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicgetuserpublicinfobyuseridv4 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicInviteUserV4
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicinviteuserv4 \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUpgradeHeadlessWithCodeV4Forward
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn iam \
    --op publicupgradeheadlesswithcodev4forward \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

