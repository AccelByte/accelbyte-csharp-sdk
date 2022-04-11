# Dslogmanager Service Index

&nbsp;  

## Operations

### Terminated Servers Wrapper:  [TerminatedServers](../AccelByte.Sdk/Api/Dslogmanager/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/dslogmanager/namespaces/{namespace}/servers/search` | GET | ListTerminatedServers | [ListTerminatedServers](../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/ListTerminatedServers.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/download` | GET | DownloadServerLogs | [DownloadServerLogs](../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/DownloadServerLogs.cs) |
| `/dslogmanager/namespaces/{namespace}/servers/{podName}/logs/exists` | GET | CheckServerLogs | [CheckServerLogs](../AccelByte.Sdk/Api/Dslogmanager/Operation/TerminatedServers/CheckServerLogs.cs) |

### All Terminated Servers Wrapper:  [AllTerminatedServers](../AccelByte.Sdk/Api/Dslogmanager/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/dslogmanager/servers/logs/download` | POST | BatchDownloadServerLogs | [BatchDownloadServerLogs](../AccelByte.Sdk/Api/Dslogmanager/Operation/AllTerminatedServers/BatchDownloadServerLogs.cs) |
| `/dslogmanager/servers/search` | GET | ListAllTerminatedServers | [ListAllTerminatedServers](../AccelByte.Sdk/Api/Dslogmanager/Operation/AllTerminatedServers/ListAllTerminatedServers.cs) |

### Dslogmanager Operations Wrapper:  [DslogmanagerOperations](../AccelByte.Sdk/Api/Dslogmanager/Wrapper/DslogmanagerOperations.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/dslogmanager/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../AccelByte.Sdk/Api/Dslogmanager/Operation/DslogmanagerOperations/PublicGetMessages.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../AccelByte.Sdk/Api/Dslogmanager/Model/LogAppMessageDeclaration.cs) |
| `models.BatchDownloadLogsRequest` | [ModelsBatchDownloadLogsRequest](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsBatchDownloadLogsRequest.cs) |
| `models.DownloadLogsRequest` | [ModelsDownloadLogsRequest](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsDownloadLogsRequest.cs) |
| `models.ListTerminatedServersResponse` | [ModelsListTerminatedServersResponse](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsListTerminatedServersResponse.cs) |
| `models.LogFileStatus` | [ModelsLogFileStatus](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsLogFileStatus.cs) |
| `models.MatchResult` | [ModelsMatchResult](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsMatchResult.cs) |
| `models.NotifPayloadServerStatusChange` | [ModelsNotifPayloadServerStatusChange](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsNotifPayloadServerStatusChange.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsPagingCursor.cs) |
| `models.RequestMatchMember` | [ModelsRequestMatchMember](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchMember.cs) |
| `models.RequestMatchParty` | [ModelsRequestMatchParty](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchParty.cs) |
| `models.RequestMatchingAlly` | [ModelsRequestMatchingAlly](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsRequestMatchingAlly.cs) |
| `models.Server` | [ModelsServer](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsServer.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../AccelByte.Sdk/Api/Dslogmanager/Model/ModelsStatusHistory.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Dslogmanager/Model/ResponseError.cs) |
