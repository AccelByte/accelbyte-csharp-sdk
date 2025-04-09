## C# Extend SDK CLI Sample App Operation Index for Basic service.

### Operation GetNamespaces
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getnamespaces \
    --activeOnly <activeOnly value - optional>
```

### Operation CreateNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op createnamespace \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getnamespace \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional>
```

### Operation DeleteNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op deletenamespace \
    --namespace <namespace value>
```

### Operation UpdateNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatenamespace \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetChildNamespaces
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getchildnamespaces \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional>
```

### Operation CreateConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op createconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getconfig \
    --configKey <configKey value> \
    --namespace <namespace value>
```

### Operation DeleteConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op deleteconfig \
    --configKey <configKey value> \
    --namespace <namespace value>
```

### Operation UpdateConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updateconfig \
    --configKey <configKey value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetNamespaceContext
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getnamespacecontext \
    --namespace <namespace value>
```

### Operation GeneratedUploadUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op generateduploadurl \
    --folder <folder value> \
    --namespace <namespace value> \
    --fileType <fileType value>
```

### Operation GetGameNamespaces
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getgamenamespaces \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional>
```

### Operation GetCountryGroups
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getcountrygroups \
    --namespace <namespace value> \
    --groupCode <groupCode value - optional>
```

### Operation AddCountryGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op addcountrygroup \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateCountryGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatecountrygroup \
    --countryGroupCode <countryGroupCode value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteCountryGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op deletecountrygroup \
    --countryGroupCode <countryGroupCode value> \
    --namespace <namespace value>
```

### Operation GetLanguages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getlanguages \
    --namespace <namespace value>
```

### Operation GetTimeZones
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op gettimezones \
    --namespace <namespace value>
```

### Operation GetUserProfileInfoByPublicId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getuserprofileinfobypublicid \
    --namespace <namespace value> \
    --publicId <publicId value>
```

### Operation AdminGetUserProfilePublicInfoByIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op admingetuserprofilepublicinfobyids \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetNamespacePublisher
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getnamespacepublisher \
    --namespace <namespace value>
```

### Operation GetPublisherConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getpublisherconfig \
    --configKey <configKey value> \
    --namespace <namespace value>
```

### Operation ChangeNamespaceStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op changenamespacestatus \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AnonymizeUserProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op anonymizeuserprofile \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GeneratedUserUploadContentUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op generateduseruploadcontenturl \
    --namespace <namespace value> \
    --userId <userId value> \
    --category <category value - optional> \
    --fileType <fileType value>
```

### Operation GetUserProfileInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getuserprofileinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateUserProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updateuserprofile \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteUserProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op deleteuserprofile \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetCustomAttributesInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getcustomattributesinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdateCustomAttributesPartially
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatecustomattributespartially \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPrivateCustomAttributesInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getprivatecustomattributesinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation UpdatePrivateCustomAttributesPartially
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updateprivatecustomattributespartially \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UpdateUserProfileStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updateuserprofilestatus \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetTime
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgettime \

```

### Operation PublicGetNamespaces
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetnamespaces \
    --activeOnly <activeOnly value - optional>
```

### Operation GetNamespace1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getnamespace1 \
    --namespace <namespace value>
```

### Operation PublicGeneratedUploadUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgenerateduploadurl \
    --folder <folder value> \
    --namespace <namespace value> \
    --fileType <fileType value>
```

### Operation PublicGetLanguages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetlanguages \
    --namespace <namespace value>
```

### Operation PublicGetTimeZones
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgettimezones \
    --namespace <namespace value>
```

### Operation PublicGetUserProfilePublicInfoByIds
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetuserprofilepublicinfobyids \
    --namespace <namespace value> \
    --userIds <userIds value>
```

### Operation PublicBulkGetUserProfilePublicInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicbulkgetuserprofilepublicinfo \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserProfileInfoByPublicId
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetuserprofileinfobypublicid \
    --namespace <namespace value> \
    --publicId <publicId value>
```

### Operation PublicGetNamespacePublisher
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetnamespacepublisher \
    --namespace <namespace value>
```

### Operation GetMyProfileInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getmyprofileinfo \
    --namespace <namespace value>
```

### Operation UpdateMyProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatemyprofile \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation CreateMyProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op createmyprofile \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetMyPrivateCustomAttributesInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getmyprivatecustomattributesinfo \
    --namespace <namespace value>
```

### Operation UpdateMyPrivateCustomAttributesPartially
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatemyprivatecustomattributespartially \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetMyZipCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op getmyzipcode \
    --namespace <namespace value>
```

### Operation UpdateMyZipCode
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op updatemyzipcode \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGeneratedUserUploadContentUrl
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgenerateduseruploadcontenturl \
    --namespace <namespace value> \
    --userId <userId value> \
    --category <category value - optional> \
    --fileType <fileType value>
```

### Operation PublicGetUserProfileInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetuserprofileinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicUpdateUserProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicupdateuserprofile \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicCreateUserProfile
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publiccreateuserprofile \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetCustomAttributesInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetcustomattributesinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicUpdateCustomAttributesPartially
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicupdatecustomattributespartially \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetUserProfilePublicInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicgetuserprofilepublicinfo \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PublicUpdateUserProfileStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn basic \
    --op publicupdateuserprofilestatus \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

