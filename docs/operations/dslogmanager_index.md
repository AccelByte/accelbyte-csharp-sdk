# Dslogmanager Service Index

&nbsp;  

## Operations

### Admin Wrapper:  [Admin](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/admin/namespaces/{namespace}/servers/{podName}/logs` | GET | GetServerLogs | [GetServerLogs](../../AccelByte.Sdk/Api/Dslogmanager/Operation/Admin/GetServerLogs.cs) | [GetServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/Admin/GetServerLogs.cs) |

### Terminated Servers Wrapper:  [TerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/namespaces/{namespace}/servers/search` | GET | ListTerminatedServers | [ListTerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/ListTerminatedServers.cs) | [ListTerminatedServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/ListTerminatedServers.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/download` | GET | DownloadServerLogs | [DownloadServerLogs](../../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/DownloadServerLogs.cs) | [DownloadServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/DownloadServerLogs.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists` | GET | CheckServerLogs | [CheckServerLogs](../../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/CheckServerLogs.cs) | [CheckServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/TerminatedServers/CheckServerLogs.cs) |

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/servers/logs/download` | POST | BatchDownloadServerLogs | [BatchDownloadServerLogs](../../AccelByte.Sdk/Api/Dslogmanager/Operation/AllTerminatedServers/BatchDownloadServerLogs.cs) | [BatchDownloadServerLogs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/AllTerminatedServers/BatchDownloadServerLogs.cs) |
| `/dslogmanager/servers/metadata` | POST | ListMetadataServers | [ListMetadataServers](../../AccelByte.Sdk/Api/Dslogmanager/Operation/AllTerminatedServers/ListMetadataServers.cs) | [ListMetadataServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/AllTerminatedServers/ListMetadataServers.cs) |
| `/dslogmanager/servers/search` | GET | ListAllTerminatedServers | [ListAllTerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Operation/AllTerminatedServers/ListAllTerminatedServers.cs) | [ListAllTerminatedServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/AllTerminatedServers/ListAllTerminatedServers.cs) |

### Dslogmanager Operations Wrapper:  [DslogmanagerOperations](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/DslogmanagerOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dslogmanager/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Dslogmanager/Operation/DslogmanagerOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dslogmanager/DslogmanagerOperations/PublicGetMessages.cs) |


&nbsp;  

## Operations with Generic Response

### Admin Wrapper:  [Admin](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Terminated Servers Wrapper:  [TerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Dslogmanager Operations Wrapper:  [DslogmanagerOperations](../../AccelByte.Sdk/Api/Dslogmanager/Wrapper/DslogmanagerOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Dslogmanager/Model/LogAppMessageDeclaration.cs) |
| `models.AllocationEvent` | [ModelsAllocationEvent](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsAllocationEvent.cs) |
| `models.BatchDownloadLogsRequest` | [ModelsBatchDownloadLogsRequest](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsBatchDownloadLogsRequest.cs) |
| `models.DownloadLogsRequest` | [ModelsDownloadLogsRequest](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsDownloadLogsRequest.cs) |
| `models.ListTerminatedServersResponse` | [ModelsListTerminatedServersResponse](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsListTerminatedServersResponse.cs) |
| `models.LogFileStatus` | [ModelsLogFileStatus](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsLogFileStatus.cs) |
| `models.MatchResult` | [ModelsMatchResult](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsMatchResult.cs) |
| `models.MetadataServersRequest` | [ModelsMetadataServersRequest](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsMetadataServersRequest.cs) |
| `models.NotifPayloadServerStatusChangeResponse` | [ModelsNotifPayloadServerStatusChangeResponse](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsNotifPayloadServerStatusChangeResponse.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsPagingCursor.cs) |
| `models.RequestMatchMember` | [ModelsRequestMatchMember](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchMember.cs) |
| `models.RequestMatchParty` | [ModelsRequestMatchParty](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchParty.cs) |
| `models.RequestMatchingAlly` | [ModelsRequestMatchingAlly](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchingAlly.cs) |
| `models.ServerLogs` | [ModelsServerLogs](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsServerLogs.cs) |
| `models.ServerResponse` | [ModelsServerResponse](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsServerResponse.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsStatusHistory.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Dslogmanager/Model/ResponseError.cs) |
