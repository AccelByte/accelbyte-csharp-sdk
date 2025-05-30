# Cloudsave Service Index

&nbsp;  

## Operations

### AdminRecord Wrapper:  [AdminRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords` | GET | AdminListAdminGameRecordV1 | [AdminListAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminListAdminGameRecordV1.cs) | [AdminListAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminListAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/bulk` | POST | AdminBulkGetAdminGameRecordV1 | [AdminBulkGetAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminBulkGetAdminGameRecordV1.cs) | [AdminBulkGetAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminBulkGetAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | GET | AdminGetAdminGameRecordV1 | [AdminGetAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminGetAdminGameRecordV1.cs) | [AdminGetAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminGetAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | PUT | AdminPutAdminGameRecordV1 | [AdminPutAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPutAdminGameRecordV1.cs) | [AdminPutAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPutAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | POST | AdminPostAdminGameRecordV1 | [AdminPostAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPostAdminGameRecordV1.cs) | [AdminPostAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPostAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | DELETE | AdminDeleteAdminGameRecordV1 | [AdminDeleteAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminDeleteAdminGameRecordV1.cs) | [AdminDeleteAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminDeleteAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/adminrecords/{key}/bulk` | POST | BulkGetAdminPlayerRecordByUserIdsV1 | [BulkGetAdminPlayerRecordByUserIdsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/BulkGetAdminPlayerRecordByUserIdsV1.cs) | [BulkGetAdminPlayerRecordByUserIdsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/BulkGetAdminPlayerRecordByUserIdsV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords` | GET | AdminListAdminUserRecordsV1 | [AdminListAdminUserRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminListAdminUserRecordsV1.cs) | [AdminListAdminUserRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminListAdminUserRecordsV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/bulk` | POST | AdminBulkGetAdminPlayerRecordV1 | [AdminBulkGetAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminBulkGetAdminPlayerRecordV1.cs) | [AdminBulkGetAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminBulkGetAdminPlayerRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | GET | AdminGetAdminPlayerRecordV1 | [AdminGetAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminGetAdminPlayerRecordV1.cs) | [AdminGetAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminGetAdminPlayerRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | PUT | AdminPutAdminPlayerRecordV1 | [AdminPutAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPutAdminPlayerRecordV1.cs) | [AdminPutAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPutAdminPlayerRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | POST | AdminPostPlayerAdminRecordV1 | [AdminPostPlayerAdminRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPostPlayerAdminRecordV1.cs) | [AdminPostPlayerAdminRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPostPlayerAdminRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | DELETE | AdminDeleteAdminPlayerRecordV1 | [AdminDeleteAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminDeleteAdminPlayerRecordV1.cs) | [AdminDeleteAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminDeleteAdminPlayerRecordV1.cs) |

### TTLConfig Wrapper:  [TTLConfig](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/TTLConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}/ttl` | DELETE | DeleteAdminGameRecordTTLConfig | [DeleteAdminGameRecordTTLConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/TTLConfig/DeleteAdminGameRecordTTLConfig.cs) | [DeleteAdminGameRecordTTLConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/TTLConfig/DeleteAdminGameRecordTTLConfig.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}/ttl` | DELETE | DeleteGameBinaryRecordTTLConfig | [DeleteGameBinaryRecordTTLConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/TTLConfig/DeleteGameBinaryRecordTTLConfig.cs) | [DeleteGameBinaryRecordTTLConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/TTLConfig/DeleteGameBinaryRecordTTLConfig.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}/ttl` | DELETE | DeleteGameRecordTTLConfig | [DeleteGameRecordTTLConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/TTLConfig/DeleteGameRecordTTLConfig.cs) | [DeleteGameRecordTTLConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/TTLConfig/DeleteGameRecordTTLConfig.cs) |

### AdminGameBinaryRecord Wrapper:  [AdminGameBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries` | GET | AdminListGameBinaryRecordsV1 | [AdminListGameBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminListGameBinaryRecordsV1.cs) | [AdminListGameBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminListGameBinaryRecordsV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries` | POST | AdminPostGameBinaryRecordV1 | [AdminPostGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminPostGameBinaryRecordV1.cs) | [AdminPostGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminPostGameBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}` | GET | AdminGetGameBinaryRecordV1 | [AdminGetGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminGetGameBinaryRecordV1.cs) | [AdminGetGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminGetGameBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}` | PUT | AdminPutGameBinaryRecordV1 | [AdminPutGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminPutGameBinaryRecordV1.cs) | [AdminPutGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminPutGameBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}` | DELETE | AdminDeleteGameBinaryRecordV1 | [AdminDeleteGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminDeleteGameBinaryRecordV1.cs) | [AdminDeleteGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminDeleteGameBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}/metadata` | PUT | AdminPutGameBinaryRecorMetadataV1 | [AdminPutGameBinaryRecorMetadataV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminPutGameBinaryRecorMetadataV1.cs) | [AdminPutGameBinaryRecorMetadataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminPutGameBinaryRecorMetadataV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/binaries/{key}/presigned` | POST | AdminPostGameBinaryPresignedURLV1 | [AdminPostGameBinaryPresignedURLV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameBinaryRecord/AdminPostGameBinaryPresignedURLV1.cs) | [AdminPostGameBinaryPresignedURLV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameBinaryRecord/AdminPostGameBinaryPresignedURLV1.cs) |

### AdminConcurrentRecord Wrapper:  [AdminConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/concurrent/adminrecords/{key}` | PUT | AdminPutAdminGameRecordConcurrentHandlerV1 | [AdminPutAdminGameRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutAdminGameRecordConcurrentHandlerV1.cs) | [AdminPutAdminGameRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutAdminGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/concurrent/records/{key}` | PUT | AdminPutGameRecordConcurrentHandlerV1 | [AdminPutGameRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutGameRecordConcurrentHandlerV1.cs) | [AdminPutGameRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/adminrecords/{key}` | PUT | AdminPutAdminPlayerRecordConcurrentHandlerV1 | [AdminPutAdminPlayerRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutAdminPlayerRecordConcurrentHandlerV1.cs) | [AdminPutAdminPlayerRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutAdminPlayerRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}` | PUT | AdminPutPlayerRecordConcurrentHandlerV1 | [AdminPutPlayerRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutPlayerRecordConcurrentHandlerV1.cs) | [AdminPutPlayerRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutPlayerRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public` | PUT | AdminPutPlayerPublicRecordConcurrentHandlerV1 | [AdminPutPlayerPublicRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutPlayerPublicRecordConcurrentHandlerV1.cs) | [AdminPutPlayerPublicRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutPlayerPublicRecordConcurrentHandlerV1.cs) |

### PluginConfig Wrapper:  [PluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/plugins` | GET | GetPluginConfig | [GetPluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/PluginConfig/GetPluginConfig.cs) | [GetPluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PluginConfig/GetPluginConfig.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/plugins` | POST | CreatePluginConfig | [CreatePluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/PluginConfig/CreatePluginConfig.cs) | [CreatePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PluginConfig/CreatePluginConfig.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/plugins` | DELETE | DeletePluginConfig | [DeletePluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/PluginConfig/DeletePluginConfig.cs) | [DeletePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PluginConfig/DeletePluginConfig.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/plugins` | PATCH | UpdatePluginConfig | [UpdatePluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Operation/PluginConfig/UpdatePluginConfig.cs) | [UpdatePluginConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PluginConfig/UpdatePluginConfig.cs) |

### AdminGameRecord Wrapper:  [AdminGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/records` | GET | ListGameRecordsHandlerV1 | [ListGameRecordsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/ListGameRecordsHandlerV1.cs) | [ListGameRecordsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/ListGameRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | GET | AdminGetGameRecordHandlerV1 | [AdminGetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) | [AdminGetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | PUT | AdminPutGameRecordHandlerV1 | [AdminPutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) | [AdminPutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | POST | AdminPostGameRecordHandlerV1 | [AdminPostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) | [AdminPostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | DELETE | AdminDeleteGameRecordHandlerV1 | [AdminDeleteGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminDeleteGameRecordHandlerV1.cs) | [AdminDeleteGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminDeleteGameRecordHandlerV1.cs) |

### AdminTags Wrapper:  [AdminTags](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/tags` | GET | AdminListTagsHandlerV1 | [AdminListTagsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminTags/AdminListTagsHandlerV1.cs) | [AdminListTagsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminTags/AdminListTagsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/tags` | POST | AdminPostTagHandlerV1 | [AdminPostTagHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminTags/AdminPostTagHandlerV1.cs) | [AdminPostTagHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminTags/AdminPostTagHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/tags/{tag}` | DELETE | AdminDeleteTagHandlerV1 | [AdminDeleteTagHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminTags/AdminDeleteTagHandlerV1.cs) | [AdminDeleteTagHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminTags/AdminDeleteTagHandlerV1.cs) |

### AdminPlayerRecord Wrapper:  [AdminPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/users/bulk/records/size` | POST | BulkGetPlayerRecordSizeHandlerV1 | [BulkGetPlayerRecordSizeHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/BulkGetPlayerRecordSizeHandlerV1.cs) | [BulkGetPlayerRecordSizeHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/BulkGetPlayerRecordSizeHandlerV1.cs) |
| [DEPRECATED] `/cloudsave/v1/admin/namespaces/{namespace}/users/records` | GET | ListPlayerRecordHandlerV1 | [ListPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/ListPlayerRecordHandlerV1.cs) | [ListPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/ListPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/records/{key}/bulk` | PUT | AdminBulkPutPlayerRecordsByKeyHandlerV1 | [AdminBulkPutPlayerRecordsByKeyHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminBulkPutPlayerRecordsByKeyHandlerV1.cs) | [AdminBulkPutPlayerRecordsByKeyHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminBulkPutPlayerRecordsByKeyHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/records/{key}/bulk` | POST | AdminBulkGetPlayerRecordsByUserIDsHandlerV1 | [AdminBulkGetPlayerRecordsByUserIDsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminBulkGetPlayerRecordsByUserIDsHandlerV1.cs) | [AdminBulkGetPlayerRecordsByUserIDsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminBulkGetPlayerRecordsByUserIDsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records` | GET | AdminRetrievePlayerRecords | [AdminRetrievePlayerRecords](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminRetrievePlayerRecords.cs) | [AdminRetrievePlayerRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminRetrievePlayerRecords.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk` | PUT | AdminPutPlayerRecordsHandlerV1 | [AdminPutPlayerRecordsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordsHandlerV1.cs) | [AdminPutPlayerRecordsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk` | POST | AdminGetPlayerRecordsHandlerV1 | [AdminGetPlayerRecordsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordsHandlerV1.cs) | [AdminGetPlayerRecordsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | GET | AdminGetPlayerRecordHandlerV1 | [AdminGetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) | [AdminGetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | AdminPutPlayerRecordHandlerV1 | [AdminPutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) | [AdminPutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | POST | AdminPostPlayerRecordHandlerV1 | [AdminPostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) | [AdminPostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | AdminDeletePlayerRecordHandlerV1 | [AdminDeletePlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerRecordHandlerV1.cs) | [AdminDeletePlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminDeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | AdminGetPlayerPublicRecordHandlerV1 | [AdminGetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) | [AdminGetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | AdminPutPlayerPublicRecordHandlerV1 | [AdminPutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) | [AdminPutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | AdminPostPlayerPublicRecordHandlerV1 | [AdminPostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) | [AdminPostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | DELETE | AdminDeletePlayerPublicRecordHandlerV1 | [AdminDeletePlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerPublicRecordHandlerV1.cs) | [AdminDeletePlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminDeletePlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/size` | GET | AdminGetPlayerRecordSizeHandlerV1 | [AdminGetPlayerRecordSizeHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordSizeHandlerV1.cs) | [AdminGetPlayerRecordSizeHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordSizeHandlerV1.cs) |

### AdminPlayerBinaryRecord Wrapper:  [AdminPlayerBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries` | GET | AdminListPlayerBinaryRecordsV1 | [AdminListPlayerBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminListPlayerBinaryRecordsV1.cs) | [AdminListPlayerBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminListPlayerBinaryRecordsV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries` | POST | AdminPostPlayerBinaryRecordV1 | [AdminPostPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminPostPlayerBinaryRecordV1.cs) | [AdminPostPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminPostPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}` | GET | AdminGetPlayerBinaryRecordV1 | [AdminGetPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminGetPlayerBinaryRecordV1.cs) | [AdminGetPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminGetPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}` | PUT | AdminPutPlayerBinaryRecordV1 | [AdminPutPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminPutPlayerBinaryRecordV1.cs) | [AdminPutPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminPutPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}` | DELETE | AdminDeletePlayerBinaryRecordV1 | [AdminDeletePlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminDeletePlayerBinaryRecordV1.cs) | [AdminDeletePlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminDeletePlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}/metadata` | PUT | AdminPutPlayerBinaryRecorMetadataV1 | [AdminPutPlayerBinaryRecorMetadataV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminPutPlayerBinaryRecorMetadataV1.cs) | [AdminPutPlayerBinaryRecorMetadataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminPutPlayerBinaryRecorMetadataV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/binaries/{key}/presigned` | POST | AdminPostPlayerBinaryPresignedURLV1 | [AdminPostPlayerBinaryPresignedURLV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerBinaryRecord/AdminPostPlayerBinaryPresignedURLV1.cs) | [AdminPostPlayerBinaryPresignedURLV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerBinaryRecord/AdminPostPlayerBinaryPresignedURLV1.cs) |

### PublicGameBinaryRecord Wrapper:  [PublicGameBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/binaries` | GET | ListGameBinaryRecordsV1 | [ListGameBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/ListGameBinaryRecordsV1.cs) | [ListGameBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/ListGameBinaryRecordsV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries` | POST | PostGameBinaryRecordV1 | [PostGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/PostGameBinaryRecordV1.cs) | [PostGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/PostGameBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries/bulk` | POST | BulkGetGameBinaryRecordV1 | [BulkGetGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/BulkGetGameBinaryRecordV1.cs) | [BulkGetGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/BulkGetGameBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries/{key}` | GET | GetGameBinaryRecordV1 | [GetGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/GetGameBinaryRecordV1.cs) | [GetGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/GetGameBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries/{key}` | PUT | PutGameBinaryRecordV1 | [PutGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/PutGameBinaryRecordV1.cs) | [PutGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/PutGameBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries/{key}` | DELETE | DeleteGameBinaryRecordV1 | [DeleteGameBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/DeleteGameBinaryRecordV1.cs) | [DeleteGameBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/DeleteGameBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/binaries/{key}/presigned` | POST | PostGameBinaryPresignedURLV1 | [PostGameBinaryPresignedURLV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameBinaryRecord/PostGameBinaryPresignedURLV1.cs) | [PostGameBinaryPresignedURLV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameBinaryRecord/PostGameBinaryPresignedURLV1.cs) |

### ConcurrentRecord Wrapper:  [ConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/ConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/concurrent/records/{key}` | PUT | PutGameRecordConcurrentHandlerV1 | [PutGameRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutGameRecordConcurrentHandlerV1.cs) | [PutGameRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}` | PUT | PutPlayerRecordConcurrentHandlerV1 | [PutPlayerRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutPlayerRecordConcurrentHandlerV1.cs) | [PutPlayerRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutPlayerRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public` | PUT | PutPlayerPublicRecordConcurrentHandlerV1 | [PutPlayerPublicRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutPlayerPublicRecordConcurrentHandlerV1.cs) | [PutPlayerPublicRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutPlayerPublicRecordConcurrentHandlerV1.cs) |

### PublicGameRecord Wrapper:  [PublicGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/records/bulk` | POST | GetGameRecordsBulk | [GetGameRecordsBulk](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/GetGameRecordsBulk.cs) | [GetGameRecordsBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/GetGameRecordsBulk.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | GET | GetGameRecordHandlerV1 | [GetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/GetGameRecordHandlerV1.cs) | [GetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/GetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | PUT | PutGameRecordHandlerV1 | [PutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PutGameRecordHandlerV1.cs) | [PutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | POST | PostGameRecordHandlerV1 | [PostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PostGameRecordHandlerV1.cs) | [PostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | DELETE | DeleteGameRecordHandlerV1 | [DeleteGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/DeleteGameRecordHandlerV1.cs) | [DeleteGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/DeleteGameRecordHandlerV1.cs) |

### PublicTags Wrapper:  [PublicTags](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/tags` | GET | PublicListTagsHandlerV1 | [PublicListTagsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicTags/PublicListTagsHandlerV1.cs) | [PublicListTagsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicTags/PublicListTagsHandlerV1.cs) |

### PublicPlayerBinaryRecord Wrapper:  [PublicPlayerBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/users/bulk/binaries/{key}/public` | POST | BulkGetPlayerPublicBinaryRecordsV1 | [BulkGetPlayerPublicBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/BulkGetPlayerPublicBinaryRecordsV1.cs) | [BulkGetPlayerPublicBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/BulkGetPlayerPublicBinaryRecordsV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/binaries` | GET | ListMyBinaryRecordsV1 | [ListMyBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/ListMyBinaryRecordsV1.cs) | [ListMyBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/ListMyBinaryRecordsV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/binaries/bulk` | POST | BulkGetMyBinaryRecordV1 | [BulkGetMyBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/BulkGetMyBinaryRecordV1.cs) | [BulkGetMyBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/BulkGetMyBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries` | POST | PostPlayerBinaryRecordV1 | [PostPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/PostPlayerBinaryRecordV1.cs) | [PostPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/PostPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/public` | GET | ListOtherPlayerPublicBinaryRecordsV1 | [ListOtherPlayerPublicBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/ListOtherPlayerPublicBinaryRecordsV1.cs) | [ListOtherPlayerPublicBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/ListOtherPlayerPublicBinaryRecordsV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/public/bulk` | POST | BulkGetOtherPlayerPublicBinaryRecordsV1 | [BulkGetOtherPlayerPublicBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/BulkGetOtherPlayerPublicBinaryRecordsV1.cs) | [BulkGetOtherPlayerPublicBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/BulkGetOtherPlayerPublicBinaryRecordsV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}` | GET | GetPlayerBinaryRecordV1 | [GetPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/GetPlayerBinaryRecordV1.cs) | [GetPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/GetPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}` | PUT | PutPlayerBinaryRecordV1 | [PutPlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/PutPlayerBinaryRecordV1.cs) | [PutPlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/PutPlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}` | DELETE | DeletePlayerBinaryRecordV1 | [DeletePlayerBinaryRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/DeletePlayerBinaryRecordV1.cs) | [DeletePlayerBinaryRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/DeletePlayerBinaryRecordV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}/metadata` | PUT | PutPlayerBinaryRecorMetadataV1 | [PutPlayerBinaryRecorMetadataV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/PutPlayerBinaryRecorMetadataV1.cs) | [PutPlayerBinaryRecorMetadataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/PutPlayerBinaryRecorMetadataV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}/presigned` | POST | PostPlayerBinaryPresignedURLV1 | [PostPlayerBinaryPresignedURLV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/PostPlayerBinaryPresignedURLV1.cs) | [PostPlayerBinaryPresignedURLV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/PostPlayerBinaryPresignedURLV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/binaries/{key}/public` | GET | GetPlayerPublicBinaryRecordsV1 | [GetPlayerPublicBinaryRecordsV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerBinaryRecord/GetPlayerPublicBinaryRecordsV1.cs) | [GetPlayerPublicBinaryRecordsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerBinaryRecord/GetPlayerPublicBinaryRecordsV1.cs) |

### PublicPlayerRecord Wrapper:  [PublicPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/users/bulk/records/{key}/public` | POST | BulkGetPlayerPublicRecordHandlerV1 | [BulkGetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/BulkGetPlayerPublicRecordHandlerV1.cs) | [BulkGetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/BulkGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/records` | GET | RetrievePlayerRecords | [RetrievePlayerRecords](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/RetrievePlayerRecords.cs) | [RetrievePlayerRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/RetrievePlayerRecords.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/records/bulk` | POST | GetPlayerRecordsBulkHandlerV1 | [GetPlayerRecordsBulkHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerRecordsBulkHandlerV1.cs) | [GetPlayerRecordsBulkHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerRecordsBulkHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public` | DELETE | PublicDeletePlayerPublicRecordHandlerV1 | [PublicDeletePlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PublicDeletePlayerPublicRecordHandlerV1.cs) | [PublicDeletePlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PublicDeletePlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/public` | GET | GetOtherPlayerPublicRecordKeyHandlerV1 | [GetOtherPlayerPublicRecordKeyHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetOtherPlayerPublicRecordKeyHandlerV1.cs) | [GetOtherPlayerPublicRecordKeyHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetOtherPlayerPublicRecordKeyHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/public/bulk` | POST | GetOtherPlayerPublicRecordHandlerV1 | [GetOtherPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetOtherPlayerPublicRecordHandlerV1.cs) | [GetOtherPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetOtherPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | GET | GetPlayerRecordHandlerV1 | [GetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) | [GetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | PutPlayerRecordHandlerV1 | [PutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) | [PutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | POST | PostPlayerRecordHandlerV1 | [PostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) | [PostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | DeletePlayerRecordHandlerV1 | [DeletePlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/DeletePlayerRecordHandlerV1.cs) | [DeletePlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/DeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | GetPlayerPublicRecordHandlerV1 | [GetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) | [GetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | PutPlayerPublicRecordHandlerV1 | [PutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) | [PutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | PostPlayerPublicRecordHandlerV1 | [PostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) | [PostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) |


&nbsp;  

## Operations with Generic Response

### AdminRecord Wrapper:  [AdminRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | GET | AdminGetAdminGameRecordV1 | [AdminGetAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminGetAdminGameRecordV1.cs) | [AdminGetAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminGetAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | PUT | AdminPutAdminGameRecordV1 | [AdminPutAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPutAdminGameRecordV1.cs) | [AdminPutAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPutAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/adminrecords/{key}` | POST | AdminPostAdminGameRecordV1 | [AdminPostAdminGameRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPostAdminGameRecordV1.cs) | [AdminPostAdminGameRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPostAdminGameRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | GET | AdminGetAdminPlayerRecordV1 | [AdminGetAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminGetAdminPlayerRecordV1.cs) | [AdminGetAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminGetAdminPlayerRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | PUT | AdminPutAdminPlayerRecordV1 | [AdminPutAdminPlayerRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPutAdminPlayerRecordV1.cs) | [AdminPutAdminPlayerRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPutAdminPlayerRecordV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords/{key}` | POST | AdminPostPlayerAdminRecordV1 | [AdminPostPlayerAdminRecordV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminRecord/AdminPostPlayerAdminRecordV1.cs) | [AdminPostPlayerAdminRecordV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminRecord/AdminPostPlayerAdminRecordV1.cs) |

### TTLConfig Wrapper:  [TTLConfig](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/TTLConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AdminGameBinaryRecord Wrapper:  [AdminGameBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AdminConcurrentRecord Wrapper:  [AdminConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PluginConfig Wrapper:  [PluginConfig](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PluginConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AdminGameRecord Wrapper:  [AdminGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | GET | AdminGetGameRecordHandlerV1 | [AdminGetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) | [AdminGetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | PUT | AdminPutGameRecordHandlerV1 | [AdminPutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) | [AdminPutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | POST | AdminPostGameRecordHandlerV1 | [AdminPostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) | [AdminPostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) |

### AdminTags Wrapper:  [AdminTags](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AdminPlayerRecord Wrapper:  [AdminPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/users/records/{key}/bulk` | PUT | AdminBulkPutPlayerRecordsByKeyHandlerV1 | [AdminBulkPutPlayerRecordsByKeyHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminBulkPutPlayerRecordsByKeyHandlerV1.cs) | [AdminBulkPutPlayerRecordsByKeyHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminBulkPutPlayerRecordsByKeyHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/bulk` | PUT | AdminPutPlayerRecordsHandlerV1 | [AdminPutPlayerRecordsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordsHandlerV1.cs) | [AdminPutPlayerRecordsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | GET | AdminGetPlayerRecordHandlerV1 | [AdminGetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) | [AdminGetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | AdminPutPlayerRecordHandlerV1 | [AdminPutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) | [AdminPutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | POST | AdminPostPlayerRecordHandlerV1 | [AdminPostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) | [AdminPostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | AdminGetPlayerPublicRecordHandlerV1 | [AdminGetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) | [AdminGetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | AdminPutPlayerPublicRecordHandlerV1 | [AdminPutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) | [AdminPutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | AdminPostPlayerPublicRecordHandlerV1 | [AdminPostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) | [AdminPostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) |

### AdminPlayerBinaryRecord Wrapper:  [AdminPlayerBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PublicGameBinaryRecord Wrapper:  [PublicGameBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### ConcurrentRecord Wrapper:  [ConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/ConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PublicGameRecord Wrapper:  [PublicGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | GET | GetGameRecordHandlerV1 | [GetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/GetGameRecordHandlerV1.cs) | [GetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/GetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | PUT | PutGameRecordHandlerV1 | [PutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PutGameRecordHandlerV1.cs) | [PutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | POST | PostGameRecordHandlerV1 | [PostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PostGameRecordHandlerV1.cs) | [PostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PostGameRecordHandlerV1.cs) |

### PublicTags Wrapper:  [PublicTags](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicTags.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PublicPlayerBinaryRecord Wrapper:  [PublicPlayerBinaryRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerBinaryRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PublicPlayerRecord Wrapper:  [PublicPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | GET | GetPlayerRecordHandlerV1 | [GetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) | [GetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | PutPlayerRecordHandlerV1 | [PutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) | [PutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | POST | PostPlayerRecordHandlerV1 | [PostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) | [PostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | GetPlayerPublicRecordHandlerV1 | [GetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) | [GetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | PutPlayerPublicRecordHandlerV1 | [PutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) | [PutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | PostPlayerPublicRecordHandlerV1 | [PostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) | [PostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AdminConcurrentRecordRequest` | [ModelsAdminConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminConcurrentRecordRequest.cs) |
| `models.AdminGameConcurrentRecordRequest` | [ModelsAdminGameConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminGameConcurrentRecordRequest.cs) |
| `models.AdminGameRecordRequest` | [ModelsAdminGameRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminGameRecordRequest.cs) |
| `models.AdminGameRecordResponse` | [ModelsAdminGameRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminGameRecordResponse.cs) |
| `models.AdminPlayerConcurrentRecordRequest` | [ModelsAdminPlayerConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminPlayerConcurrentRecordRequest.cs) |
| `models.AdminPlayerRecordKeyInfo` | [ModelsAdminPlayerRecordKeyInfo](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminPlayerRecordKeyInfo.cs) |
| `models.AdminPlayerRecordRequest` | [ModelsAdminPlayerRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminPlayerRecordRequest.cs) |
| `models.AdminPlayerRecordResponse` | [ModelsAdminPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminPlayerRecordResponse.cs) |
| `models.AppConfig` | [ModelsAppConfig](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAppConfig.cs) |
| `models.BinaryInfoResponse` | [ModelsBinaryInfoResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBinaryInfoResponse.cs) |
| `models.BinaryRecordRequest` | [ModelsBinaryRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBinaryRecordRequest.cs) |
| `models.BulkGetAdminGameRecordRequest` | [ModelsBulkGetAdminGameRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetAdminGameRecordRequest.cs) |
| `models.BulkGetAdminGameRecordResponse` | [ModelsBulkGetAdminGameRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetAdminGameRecordResponse.cs) |
| `models.BulkGetAdminPlayerRecordRequest` | [ModelsBulkGetAdminPlayerRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetAdminPlayerRecordRequest.cs) |
| `models.BulkGetAdminPlayerRecordResponse` | [ModelsBulkGetAdminPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetAdminPlayerRecordResponse.cs) |
| `models.BulkGetGameBinaryRecordResponse` | [ModelsBulkGetGameBinaryRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetGameBinaryRecordResponse.cs) |
| `models.BulkGetGameRecordRequest` | [ModelsBulkGetGameRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetGameRecordRequest.cs) |
| `models.BulkGetGameRecordResponse` | [ModelsBulkGetGameRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetGameRecordResponse.cs) |
| `models.BulkGetPlayerBinaryRecordResponse` | [ModelsBulkGetPlayerBinaryRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerBinaryRecordResponse.cs) |
| `models.BulkGetPlayerRecordResponse` | [ModelsBulkGetPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordResponse.cs) |
| `models.BulkGetPlayerRecordSizeResponse` | [ModelsBulkGetPlayerRecordSizeResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordSizeResponse.cs) |
| `models.BulkGetPlayerRecordsRequest` | [ModelsBulkGetPlayerRecordsRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordsRequest.cs) |
| `models.BulkUpdatePlayerRecordByKeyRequestDetail` | [ModelsBulkUpdatePlayerRecordByKeyRequestDetail](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordByKeyRequestDetail.cs) |
| `models.BulkUpdatePlayerRecordByKeyResponse` | [ModelsBulkUpdatePlayerRecordByKeyResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordByKeyResponse.cs) |
| `models.BulkUpdatePlayerRecordRequestDetail` | [ModelsBulkUpdatePlayerRecordRequestDetail](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordRequestDetail.cs) |
| `models.BulkUpdatePlayerRecordResponse` | [ModelsBulkUpdatePlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordResponse.cs) |
| `models.BulkUpdatePlayerRecordsByKeyRequest` | [ModelsBulkUpdatePlayerRecordsByKeyRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordsByKeyRequest.cs) |
| `models.BulkUpdatePlayerRecordsRequest` | [ModelsBulkUpdatePlayerRecordsRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUpdatePlayerRecordsRequest.cs) |
| `models.BulkUserIDsRequest` | [ModelsBulkUserIDsRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUserIDsRequest.cs) |
| `models.BulkUserKeyRequest` | [ModelsBulkUserKeyRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUserKeyRequest.cs) |
| `models.ConcurrentRecordRequest` | [ModelsConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsConcurrentRecordRequest.cs) |
| `models.CustomConfig` | [ModelsCustomConfig](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsCustomConfig.cs) |
| `models.CustomFunction` | [ModelsCustomFunction](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsCustomFunction.cs) |
| `models.GameBinaryRecordAdminResponse` | [ModelsGameBinaryRecordAdminResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameBinaryRecordAdminResponse.cs) |
| `models.GameBinaryRecordCreate` | [ModelsGameBinaryRecordCreate](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameBinaryRecordCreate.cs) |
| `models.GameBinaryRecordMetadataRequest` | [ModelsGameBinaryRecordMetadataRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameBinaryRecordMetadataRequest.cs) |
| `models.GameBinaryRecordResponse` | [ModelsGameBinaryRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameBinaryRecordResponse.cs) |
| `models.GameRecordAdminResponse` | [ModelsGameRecordAdminResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordAdminResponse.cs) |
| `models.GameRecordRequest` | [ModelsGameRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordRequest.cs) |
| `models.GameRecordResponse` | [ModelsGameRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordResponse.cs) |
| `models.ListAdminGameRecordKeysResponse` | [ModelsListAdminGameRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListAdminGameRecordKeysResponse.cs) |
| `models.ListAdminPlayerRecordKeysResponse` | [ModelsListAdminPlayerRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListAdminPlayerRecordKeysResponse.cs) |
| `models.ListGameBinaryRecordsAdminResponse` | [ModelsListGameBinaryRecordsAdminResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListGameBinaryRecordsAdminResponse.cs) |
| `models.ListGameBinaryRecordsResponse` | [ModelsListGameBinaryRecordsResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListGameBinaryRecordsResponse.cs) |
| `models.ListGameRecordKeysResponse` | [ModelsListGameRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListGameRecordKeysResponse.cs) |
| `models.ListPlayerBinaryRecordsResponse` | [ModelsListPlayerBinaryRecordsResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListPlayerBinaryRecordsResponse.cs) |
| `models.ListPlayerRecordKeysResponse` | [ModelsListPlayerRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListPlayerRecordKeysResponse.cs) |
| `models.ListTagsResponse` | [ModelsListTagsResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListTagsResponse.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPagination.cs) |
| `models.PlayerBinaryRecordCreate` | [ModelsPlayerBinaryRecordCreate](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerBinaryRecordCreate.cs) |
| `models.PlayerBinaryRecordMetadataPublicRequest` | [ModelsPlayerBinaryRecordMetadataPublicRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerBinaryRecordMetadataPublicRequest.cs) |
| `models.PlayerBinaryRecordMetadataRequest` | [ModelsPlayerBinaryRecordMetadataRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerBinaryRecordMetadataRequest.cs) |
| `models.PlayerBinaryRecordResponse` | [ModelsPlayerBinaryRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerBinaryRecordResponse.cs) |
| `models.PlayerRecordConcurrentUpdateResponse` | [ModelsPlayerRecordConcurrentUpdateResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordConcurrentUpdateResponse.cs) |
| `models.PlayerRecordKeyInfo` | [ModelsPlayerRecordKeyInfo](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordKeyInfo.cs) |
| `models.PlayerRecordRequest` | [ModelsPlayerRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordRequest.cs) |
| `models.PlayerRecordResponse` | [ModelsPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordResponse.cs) |
| `models.PlayerRecordSizeResponse` | [ModelsPlayerRecordSizeResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordSizeResponse.cs) |
| `models.PluginRequest` | [ModelsPluginRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPluginRequest.cs) |
| `models.PluginResponse` | [ModelsPluginResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPluginResponse.cs) |
| `models.PublicGameBinaryRecordCreate` | [ModelsPublicGameBinaryRecordCreate](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPublicGameBinaryRecordCreate.cs) |
| `models.PublicPlayerBinaryRecordCreate` | [ModelsPublicPlayerBinaryRecordCreate](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPublicPlayerBinaryRecordCreate.cs) |
| `models.ResponseError` | [ModelsResponseError](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsResponseError.cs) |
| `models.TTLConfigDTO` | [ModelsTTLConfigDTO](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsTTLConfigDTO.cs) |
| `models.TagInfo` | [ModelsTagInfo](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsTagInfo.cs) |
| `models.TagRequest` | [ModelsTagRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsTagRequest.cs) |
| `models.UploadBinaryRecordRequest` | [ModelsUploadBinaryRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsUploadBinaryRecordRequest.cs) |
| `models.UploadBinaryRecordResponse` | [ModelsUploadBinaryRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsUploadBinaryRecordResponse.cs) |
| `models.UserKeyRequest` | [ModelsUserKeyRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsUserKeyRequest.cs) |
