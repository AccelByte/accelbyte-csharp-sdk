## C# Extend SDK CLI Sample App Operation Index for Gdpr service.

### Operation AdminGetListDeletionDataRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetlistdeletiondatarequest \
    --namespace <namespace value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --requestDate <requestDate value - optional>
```

### Operation GetAdminEmailConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op getadminemailconfiguration \
    --namespace <namespace value>
```

### Operation UpdateAdminEmailConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op updateadminemailconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SaveAdminEmailConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op saveadminemailconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteAdminEmailConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op deleteadminemailconfiguration \
    --namespace <namespace value> \
    --emails <emails value>
```

### Operation AdminGetPlatformAccountClosureClients
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetplatformaccountclosureclients \
    --namespace <namespace value>
```

### Operation AdminValidateXboxBPCertFile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminvalidatexboxbpcertfile \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlatformAccountClosureClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetplatformaccountclosureclient \
    --namespace <namespace value> \
    --platform <platform value>
```

### Operation AdminUpdatePlatformAccountClosureClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminupdateplatformaccountclosureclient \
    --namespace <namespace value> \
    --platform <platform value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlatformAccountClosureClient
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admindeleteplatformaccountclosureclient \
    --namespace <namespace value> \
    --platform <platform value>
```

### Operation AdminMockPlatformAccountClosureData
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminmockplatformaccountclosuredata \
    --namespace <namespace value> \
    --platform <platform value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetListPersonalDataRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetlistpersonaldatarequest \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --requestDate <requestDate value - optional>
```

### Operation AdminGetServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetservicesconfiguration \
    --namespace <namespace value>
```

### Operation AdminUpdateServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminupdateservicesconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminResetServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminresetservicesconfiguration \
    --namespace <namespace value>
```

### Operation AdminGetPlatformAccountClosureServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetplatformaccountclosureservicesconfiguration \
    --namespace <namespace value>
```

### Operation AdminUpdatePlatformAccountClosureServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminupdateplatformaccountclosureservicesconfiguration \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminResetPlatformAccountClosureServicesConfiguration
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminresetplatformaccountclosureservicesconfiguration \
    --namespace <namespace value>
```

### Operation AdminGetUserPlatformAccountClosureHistories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetuserplatformaccountclosurehistories \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --platform <platform value - optional> \
    --userId <userId value - optional>
```

### Operation AdminGetUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetuseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminSubmitUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminsubmituseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminCancelUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admincanceluseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetUserPersonalDataRequests
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingetuserpersonaldatarequests \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminRequestDataRetrieval
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op adminrequestdataretrieval \
    --namespace <namespace value> \
    --userId <userId value> \
    --password <password value - optional>
```

### Operation AdminCancelUserPersonalDataRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admincanceluserpersonaldatarequest \
    --namespace <namespace value> \
    --requestDate <requestDate value> \
    --userId <userId value>
```

### Operation AdminGeneratePersonalDataURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op admingeneratepersonaldataurl \
    --namespace <namespace value> \
    --requestDate <requestDate value> \
    --userId <userId value> \
    --password <password value - optional>
```

### Operation PublicSubmitUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicsubmituseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value> \
    --languageTag <languageTag value - optional> \
    --password <password value>
```

### Operation PublicCancelUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publiccanceluseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicGetUserAccountDeletionStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicgetuseraccountdeletionstatus \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicGetUserPersonalDataRequests
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicgetuserpersonaldatarequests \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation PublicRequestDataRetrieval
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicrequestdataretrieval \
    --namespace <namespace value> \
    --userId <userId value> \
    --languageTag <languageTag value - optional> \
    --password <password value>
```

### Operation PublicCancelUserPersonalDataRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publiccanceluserpersonaldatarequest \
    --namespace <namespace value> \
    --requestDate <requestDate value> \
    --userId <userId value>
```

### Operation PublicGeneratePersonalDataURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicgeneratepersonaldataurl \
    --namespace <namespace value> \
    --requestDate <requestDate value> \
    --userId <userId value> \
    --password <password value>
```

### Operation PublicSubmitMyAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicsubmitmyaccountdeletionrequest \
    --platformId <platformId value> \
    --platformToken <platformToken value>
```

### Operation PublicCancelMyAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publiccancelmyaccountdeletionrequest \

```

### Operation PublicGetMyAccountDeletionStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op publicgetmyaccountdeletionstatus \

```

### Operation S2SGetListFinishedAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2sgetlistfinishedaccountdeletionrequest \
    --namespace <namespace value> \
    --end <end value> \
    --start <start value>
```

### Operation S2SGetListFinishedPersonalDataRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2sgetlistfinishedpersonaldatarequest \
    --namespace <namespace value> \
    --end <end value> \
    --start <start value>
```

### Operation S2SGetDataRequestByRequestID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2sgetdatarequestbyrequestid \
    --namespace <namespace value> \
    --requestId <requestId value>
```

### Operation S2SSubmitUserAccountDeletionRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2ssubmituseraccountdeletionrequest \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation S2SRequestDataRetrieval
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2srequestdataretrieval \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation S2SGeneratePersonalDataURL
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn gdpr \
    --op s2sgeneratepersonaldataurl \
    --namespace <namespace value> \
    --requestDate <requestDate value> \
    --userId <userId value>
```

