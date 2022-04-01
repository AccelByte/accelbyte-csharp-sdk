# Cloudsave Service Index

&nbsp;  

## Operations

### AdminGameRecord Wrapper:  [AdminGameRecord](../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminGameRecord.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/records` | GET | ListGameRecordsHandlerV1 | [ListGameRecordsHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/ListGameRecordsHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | GET | AdminGetGameRecordHandlerV1 | [AdminGetGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminGetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | PUT | AdminPutGameRecordHandlerV1 | [AdminPutGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | POST | AdminPostGameRecordHandlerV1 | [AdminPostGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminPostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/records/{key}` | DELETE | AdminDeleteGameRecordHandlerV1 | [AdminDeleteGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminGameRecord/AdminDeleteGameRecordHandlerV1.cs) |

### AdminPlayerRecord Wrapper:  [AdminPlayerRecord](../AccelByte.Sdk/Api/Cloudsave/Wrapper/AdminPlayerRecord.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/cloudsave/v1/admin/namespaces/{namespace}/users/records` | GET | ListPlayerRecordHandlerV1 | [ListPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/ListPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records` | GET | AdminRetrievePlayerRecords | [AdminRetrievePlayerRecords](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminRetrievePlayerRecords.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | GET | AdminGetPlayerRecordHandlerV1 | [AdminGetPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | AdminPutPlayerRecordHandlerV1 | [AdminPutPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | POST | AdminPostPlayerRecordHandlerV1 | [AdminPostPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | AdminDeletePlayerRecordHandlerV1 | [AdminDeletePlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | AdminGetPlayerPublicRecordHandlerV1 | [AdminGetPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | AdminPutPlayerPublicRecordHandlerV1 | [AdminPutPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | AdminPostPlayerPublicRecordHandlerV1 | [AdminPostPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminPostPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/records/{key}/public` | DELETE | AdminDeletePlayerPublicRecordHandlerV1 | [AdminDeletePlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/AdminPlayerRecord/AdminDeletePlayerPublicRecordHandlerV1.cs) |

### ConcurrentRecord Wrapper:  [ConcurrentRecord](../AccelByte.Sdk/Api/Cloudsave/Wrapper/ConcurrentRecord.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/concurrent/records/{key}` | PUT | PutGameRecordConcurrentHandlerV1 | [PutGameRecordConcurrentHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutGameRecordConcurrentHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/concurrent/records/{key}/public` | PUT | PutPlayerPublicRecordConcurrentHandlerV1 | [PutPlayerPublicRecordConcurrentHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/ConcurrentRecord/PutPlayerPublicRecordConcurrentHandlerV1.cs) |

### PublicGameRecord Wrapper:  [PublicGameRecord](../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicGameRecord.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | GET | GetGameRecordHandlerV1 | [GetGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/GetGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | PUT | PutGameRecordHandlerV1 | [PutGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PutGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | POST | PostGameRecordHandlerV1 | [PostGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/PostGameRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/records/{key}` | DELETE | DeleteGameRecordHandlerV1 | [DeleteGameRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicGameRecord/DeleteGameRecordHandlerV1.cs) |

### PublicPlayerRecord Wrapper:  [PublicPlayerRecord](../AccelByte.Sdk/Api/Cloudsave/Wrapper/PublicPlayerRecord.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/cloudsave/v1/namespaces/{namespace}/users/bulk/records/{key}/public` | POST | BulkGetPlayerPublicRecordHandlerV1 | [BulkGetPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/BulkGetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/me/records/{key}/public` | DELETE | PublicDeletePlayerPublicRecordHandlerV1 | [PublicDeletePlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PublicDeletePlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | GET | GetPlayerRecordHandlerV1 | [GetPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | PUT | PutPlayerRecordHandlerV1 | [PutPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | POST | PostPlayerRecordHandlerV1 | [PostPlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}` | DELETE | DeletePlayerRecordHandlerV1 | [DeletePlayerRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/DeletePlayerRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | GET | GetPlayerPublicRecordHandlerV1 | [GetPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/GetPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | PUT | PutPlayerPublicRecordHandlerV1 | [PutPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PutPlayerPublicRecordHandlerV1.cs) |
| `/cloudsave/v1/namespaces/{namespace}/users/{userId}/records/{key}/public` | POST | PostPlayerPublicRecordHandlerV1 | [PostPlayerPublicRecordHandlerV1](../AccelByte.Sdk/Api/Cloudsave/Operation/PublicPlayerRecord/PostPlayerPublicRecordHandlerV1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.BulkGetPlayerRecordResponse` | [ModelsBulkGetPlayerRecordResponse](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkGetPlayerRecordResponse.cs) |
| `models.BulkUserIDsRequest` | [ModelsBulkUserIDsRequest](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsBulkUserIDsRequest.cs) |
| `models.ConcurrentRecordRequest` | [ModelsConcurrentRecordRequest](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsConcurrentRecordRequest.cs) |
| `models.GameRecordRequest` | [ModelsGameRecordRequest](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordRequest.cs) |
| `models.GameRecordResponse` | [ModelsGameRecordResponse](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsGameRecordResponse.cs) |
| `models.ListGameRecordKeysResponse` | [ModelsListGameRecordKeysResponse](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListGameRecordKeysResponse.cs) |
| `models.ListPlayerRecordKeysResponse` | [ModelsListPlayerRecordKeysResponse](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsListPlayerRecordKeysResponse.cs) |
| `models.Pagination` | [ModelsPagination](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPagination.cs) |
| `models.PlayerRecordKeyInfo` | [ModelsPlayerRecordKeyInfo](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordKeyInfo.cs) |
| `models.PlayerRecordRequest` | [ModelsPlayerRecordRequest](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordRequest.cs) |
| `models.PlayerRecordResponse` | [ModelsPlayerRecordResponse](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsPlayerRecordResponse.cs) |
| `models.ResponseError` | [ModelsResponseError](../AccelByte.Sdk/Api/Cloudsave/Model/ModelsResponseError.cs) |
