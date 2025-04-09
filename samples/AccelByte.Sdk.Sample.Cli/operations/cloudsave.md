## C# Extend SDK CLI Sample App Operation Index for Cloudsave service.

### Operation AdminListAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminlistadmingamerecordv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation AdminBulkGetAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminbulkgetadmingamerecordv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetadmingamerecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminPutAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputadmingamerecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostadmingamerecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteAdminGameRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeleteadmingamerecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation DeleteAdminGameRecordTTLConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deleteadmingamerecordttlconfig \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminListGameBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminlistgamebinaryrecordsv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation AdminPostGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostgamebinaryrecordv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetgamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminPutGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputgamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeletegamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminPutGameBinaryRecorMetadataV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputgamebinaryrecormetadatav1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostGameBinaryPresignedURLV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostgamebinarypresignedurlv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGameBinaryRecordTTLConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deletegamebinaryrecordttlconfig \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminPutAdminGameRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputadmingamerecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPutGameRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputgamerecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getpluginconfig \
    --namespace <namespace value>
```

### Operation CreatePluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op createpluginconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deletepluginconfig \
    --namespace <namespace value>
```

### Operation UpdatePluginConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op updatepluginconfig \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListGameRecordsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op listgamerecordshandlerv1 \
    --namespace <namespace value> \
    --query <query value - optional> \
    --tags <tags value - optional> \
    --limit <limit value> \
    --offset <offset value>
```

### Operation AdminGetGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminPutGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeletegamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation DeleteGameRecordTTLConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deletegamerecordttlconfig \
    --key <key value> \
    --namespace <namespace value>
```

### Operation AdminListTagsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminlisttagshandlerv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminPostTagHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminposttaghandlerv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteTagHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeletetaghandlerv1 \
    --namespace <namespace value> \
    --tag <tag value>
```

### Operation BulkGetAdminPlayerRecordByUserIdsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetadminplayerrecordbyuseridsv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkGetPlayerRecordSizeHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetplayerrecordsizehandlerv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkPutPlayerRecordsByKeyHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminbulkputplayerrecordsbykeyhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkGetPlayerRecordsByUserIDsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminbulkgetplayerrecordsbyuseridshandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminListAdminUserRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminlistadminuserrecordsv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation AdminBulkGetAdminPlayerRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminbulkgetadminplayerrecordv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAdminPlayerRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetadminplayerrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPutAdminPlayerRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputadminplayerrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostPlayerAdminRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostplayeradminrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteAdminPlayerRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeleteadminplayerrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminListPlayerBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminlistplayerbinaryrecordsv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation AdminPostPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostplayerbinaryrecordv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPutPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeleteplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPutPlayerBinaryRecorMetadataV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerbinaryrecormetadatav1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostPlayerBinaryPresignedURLV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostplayerbinarypresignedurlv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPutAdminPlayerRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputadminplayerrecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --responseBody <responseBody value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPutPlayerRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerrecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --responseBody <responseBody value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPutPlayerPublicRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerpublicrecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --responseBody <responseBody value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRetrievePlayerRecords
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminretrieveplayerrecords \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation AdminPutPlayerRecordsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerrecordshandlerv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlayerRecordsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetplayerrecordshandlerv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPutPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeleteplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminPutPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminputplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminPostPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op adminpostplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeletePlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admindeleteplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetPlayerRecordSizeHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op admingetplayerrecordsizehandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation ListGameBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op listgamebinaryrecordsv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation PostGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postgamebinaryrecordv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkGetGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetgamebinaryrecordv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getgamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation PutGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putgamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGameBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deletegamebinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation PostGameBinaryPresignedURLV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postgamebinarypresignedurlv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PutGameRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putgamerecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGameRecordsBulk
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getgamerecordsbulk \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation PutGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PostGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postgamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteGameRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deletegamerecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation PublicListTagsHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op publiclisttagshandlerv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation BulkGetPlayerPublicBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetplayerpublicbinaryrecordsv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkGetPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListMyBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op listmybinaryrecordsv1 \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --query <query value - optional> \
    --tags <tags value - optional>
```

### Operation BulkGetMyBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetmybinaryrecordv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation RetrievePlayerRecords
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op retrieveplayerrecords \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation GetPlayerRecordsBulkHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getplayerrecordsbulkhandlerv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicDeletePlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op publicdeleteplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value>
```

### Operation PostPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postplayerbinaryrecordv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ListOtherPlayerPublicBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op listotherplayerpublicbinaryrecordsv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation BulkGetOtherPlayerPublicBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op bulkgetotherplayerpublicbinaryrecordsv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PutPlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePlayerBinaryRecordV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deleteplayerbinaryrecordv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PutPlayerBinaryRecorMetadataV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerbinaryrecormetadatav1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PostPlayerBinaryPresignedURLV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postplayerbinarypresignedurlv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlayerPublicBinaryRecordsV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getplayerpublicbinaryrecordsv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PutPlayerRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerrecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --responseBody <responseBody value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PutPlayerPublicRecordConcurrentHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerpublicrecordconcurrenthandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --responseBody <responseBody value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetOtherPlayerPublicRecordKeyHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getotherplayerpublicrecordkeyhandlerv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --tags <tags value - optional>
```

### Operation GetOtherPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getotherplayerpublicrecordhandlerv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PutPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PostPlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeletePlayerRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op deleteplayerrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation GetPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op getplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation PutPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op putplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PostPlayerPublicRecordHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn cloudsave \
    --op postplayerpublicrecordhandlerv1 \
    --key <key value> \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

