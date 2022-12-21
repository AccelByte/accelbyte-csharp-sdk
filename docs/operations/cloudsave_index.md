# Cloudsave Service Index

&nbsp;  

## Operations

### AdminConcurrentRecord Wrapper:  [AdminConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/concurrent/records/{key}` | PUT | AdminPutGameRecordConcurrentHandlerV1 | [AdminPutGameRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutGameRecordConcurrentHandlerV1.cs) | [AdminPutGameRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}` | PUT | AdminPutPlayerRecordConcurrentHandlerV1 | [AdminPutPlayerRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutPlayerRecordConcurrentHandlerV1.cs) | [AdminPutPlayerRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutPlayerRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public` | PUT | AdminPutPlayerPublicRecordConcurrentHandlerV1 | [AdminPutPlayerPublicRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminConcurrentRecord/AdminPutPlayerPublicRecordConcurrentHandlerV1.cs) | [AdminPutPlayerPublicRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminConcurrentRecord/AdminPutPlayerPublicRecordConcurrentHandlerV1.cs) |

### AdminGameRecord Wrapper:  [AdminGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/records` | GET | ListGameRecordsHandlerV1 | [ListGameRecordsHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/ListGameRecordsHandlerV1.cs) | [ListGameRecordsHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/ListGameRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | GET | AdminGetGameRecordHandlerV1 | [AdminGetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) | [AdminGetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | PUT | AdminPutGameRecordHandlerV1 | [AdminPutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) | [AdminPutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | POST | AdminPostGameRecordHandlerV1 | [AdminPostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) | [AdminPostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | DELETE | AdminDeleteGameRecordHandlerV1 | [AdminDeleteGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminDeleteGameRecordHandlerV1.cs) | [AdminDeleteGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminGameRecord/AdminDeleteGameRecordHandlerV1.cs) |

### AdminPlayerRecord Wrapper:  [AdminPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/users/bulk/records/size` | POST | BulkGetPlayerRecordSizeHandlerV1 | [BulkGetPlayerRecordSizeHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/BulkGetPlayerRecordSizeHandlerV1.cs) | [BulkGetPlayerRecordSizeHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/BulkGetPlayerRecordSizeHandlerV1.cs) |
| [DEPRECATED] `/cloudsave/v1/admin/namespaces/{namespace}/users/records` | GET | ListPlayerRecordHandlerV1 | [ListPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/ListPlayerRecordHandlerV1.cs) | [ListPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/ListPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records` | GET | AdminRetrievePlayerRecords | [AdminRetrievePlayerRecords](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminRetrievePlayerRecords.cs) | [AdminRetrievePlayerRecords](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminRetrievePlayerRecords.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | GET | AdminGetPlayerRecordHandlerV1 | [AdminGetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) | [AdminGetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | AdminPutPlayerRecordHandlerV1 | [AdminPutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) | [AdminPutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | POST | AdminPostPlayerRecordHandlerV1 | [AdminPostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) | [AdminPostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | AdminDeletePlayerRecordHandlerV1 | [AdminDeletePlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerRecordHandlerV1.cs) | [AdminDeletePlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminDeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | AdminGetPlayerPublicRecordHandlerV1 | [AdminGetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) | [AdminGetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | AdminPutPlayerPublicRecordHandlerV1 | [AdminPutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) | [AdminPutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | AdminPostPlayerPublicRecordHandlerV1 | [AdminPostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) | [AdminPostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | DELETE | AdminDeletePlayerPublicRecordHandlerV1 | [AdminDeletePlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerPublicRecordHandlerV1.cs) | [AdminDeletePlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminDeletePlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/size` | GET | AdminGetPlayerRecordSizeHandlerV1 | [AdminGetPlayerRecordSizeHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordSizeHandlerV1.cs) | [AdminGetPlayerRecordSizeHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/AdminPlayerRecord/AdminGetPlayerRecordSizeHandlerV1.cs) |

### ConcurrentRecord Wrapper:  [ConcurrentRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/ConcurrentRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/concurrent/records/{key}` | PUT | PutGameRecordConcurrentHandlerV1 | [PutGameRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutGameRecordConcurrentHandlerV1.cs) | [PutGameRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}` | PUT | PutPlayerRecordConcurrentHandlerV1 | [PutPlayerRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutPlayerRecordConcurrentHandlerV1.cs) | [PutPlayerRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutPlayerRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public` | PUT | PutPlayerPublicRecordConcurrentHandlerV1 | [PutPlayerPublicRecordConcurrentHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutPlayerPublicRecordConcurrentHandlerV1.cs) | [PutPlayerPublicRecordConcurrentHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/ConcurrentRecord/PutPlayerPublicRecordConcurrentHandlerV1.cs) |

### PublicGameRecord Wrapper:  [PublicGameRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | GET | GetGameRecordHandlerV1 | [GetGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/GetGameRecordHandlerV1.cs) | [GetGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/GetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | PUT | PutGameRecordHandlerV1 | [PutGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PutGameRecordHandlerV1.cs) | [PutGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | POST | PostGameRecordHandlerV1 | [PostGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PostGameRecordHandlerV1.cs) | [PostGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/PostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | DELETE | DeleteGameRecordHandlerV1 | [DeleteGameRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/DeleteGameRecordHandlerV1.cs) | [DeleteGameRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicGameRecord/DeleteGameRecordHandlerV1.cs) |

### PublicPlayerRecord Wrapper:  [PublicPlayerRecord](../../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerRecord.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/users/bulk/records/{key}/public` | POST | BulkGetPlayerPublicRecordHandlerV1 | [BulkGetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/BulkGetPlayerPublicRecordHandlerV1.cs) | [BulkGetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/BulkGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public` | DELETE | PublicDeletePlayerPublicRecordHandlerV1 | [PublicDeletePlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PublicDeletePlayerPublicRecordHandlerV1.cs) | [PublicDeletePlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PublicDeletePlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | GET | GetPlayerRecordHandlerV1 | [GetPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) | [GetPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | PutPlayerRecordHandlerV1 | [PutPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) | [PutPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | POST | PostPlayerRecordHandlerV1 | [PostPlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) | [PostPlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | DeletePlayerRecordHandlerV1 | [DeletePlayerRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/DeletePlayerRecordHandlerV1.cs) | [DeletePlayerRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/DeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | GetPlayerPublicRecordHandlerV1 | [GetPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) | [GetPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | PutPlayerPublicRecordHandlerV1 | [PutPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) | [PutPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | PostPlayerPublicRecordHandlerV1 | [PostPlayerPublicRecordHandlerV1](../../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) | [PostPlayerPublicRecordHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Cloudsave/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AdminConcurrentRecordRequest` | [ModelsAdminConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsAdminConcurrentRecordRequest.cs) |
| `models.BulkGetPlayerRecordResponse` | [ModelsBulkGetPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordResponse.cs) |
| `models.BulkGetPlayerRecordSizeResponse` | [ModelsBulkGetPlayerRecordSizeResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordSizeResponse.cs) |
| `models.BulkUserIDsRequest` | [ModelsBulkUserIDsRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUserIDsRequest.cs) |
| `models.BulkUserKeyRequest` | [ModelsBulkUserKeyRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUserKeyRequest.cs) |
| `models.ConcurrentRecordRequest` | [ModelsConcurrentRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsConcurrentRecordRequest.cs) |
| `models.GameRecordRequest` | [ModelsGameRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordRequest.cs) |
| `models.GameRecordResponse` | [ModelsGameRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordResponse.cs) |
| `models.ListGameRecordKeysResponse` | [ModelsListGameRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListGameRecordKeysResponse.cs) |
| `models.ListPlayerRecordKeysResponse` | [ModelsListPlayerRecordKeysResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListPlayerRecordKeysResponse.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPagination.cs) |
| `models.PlayerRecordKeyInfo` | [ModelsPlayerRecordKeyInfo](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordKeyInfo.cs) |
| `models.PlayerRecordRequest` | [ModelsPlayerRecordRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordRequest.cs) |
| `models.PlayerRecordResponse` | [ModelsPlayerRecordResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordResponse.cs) |
| `models.PlayerRecordSizeResponse` | [ModelsPlayerRecordSizeResponse](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordSizeResponse.cs) |
| `models.ResponseError` | [ModelsResponseError](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsResponseError.cs) |
| `models.UserKeyRequest` | [ModelsUserKeyRequest](../../AccelByte.Sdk/Api/Cloudsave/Model/ModelsUserKeyRequest.cs) |
