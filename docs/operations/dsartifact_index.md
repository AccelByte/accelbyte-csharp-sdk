# Dsartifact Service Index

&nbsp;  

## Operations

### Artifact Upload Process Queue Wrapper:  [ArtifactUploadProcessQueue](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/ArtifactUploadProcessQueue.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsartifact/artifacts/nodes/ipaddresses` | GET | ListNodesIPAddress | [ListNodesIPAddress](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/ListNodesIPAddress.cs) | [ListNodesIPAddress](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/ListNodesIPAddress.cs) |
| `/dsartifact/artifacts/nodes/ipaddresses` | DELETE | DeleteNodeByID | [DeleteNodeByID](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/DeleteNodeByID.cs) | [DeleteNodeByID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/DeleteNodeByID.cs) |
| `/dsartifact/artifacts/queues` | GET | ListQueue | [ListQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/ListQueue.cs) | [ListQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/ListQueue.cs) |
| `/dsartifact/artifacts/queues/active` | GET | GetActiveQueue | [GetActiveQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/GetActiveQueue.cs) | [GetActiveQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/GetActiveQueue.cs) |
| `/dsartifact/artifacts/queues/active` | PUT | SetActiveQueue | [SetActiveQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/SetActiveQueue.cs) | [SetActiveQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/SetActiveQueue.cs) |
| `/dsartifact/artifacts/queues/active` | DELETE | DeleteActiveQueue | [DeleteActiveQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/DeleteActiveQueue.cs) | [DeleteActiveQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/DeleteActiveQueue.cs) |
| `/dsartifact/artifacts/queues/failed` | PUT | ReportFailedUpload | [ReportFailedUpload](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/ReportFailedUpload.cs) | [ReportFailedUpload](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/ReportFailedUpload.cs) |
| `/dsartifact/namespaces/{namespace}/artifacts/queues` | DELETE | DeleteQueue | [DeleteQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/DeleteQueue.cs) | [DeleteQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/DeleteQueue.cs) |
| `/dsartifact/namespaces/{namespace}/artifacts/queues/active/all` | GET | ListAllActiveQueue | [ListAllActiveQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/ListAllActiveQueue.cs) | [ListAllActiveQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/ListAllActiveQueue.cs) |
| `/dsartifact/namespaces/{namespace}/artifacts/queues/all` | GET | ListAllQueue | [ListAllQueue](../../AccelByte.Sdk/Api/Dsartifact/Operation/ArtifactUploadProcessQueue/ListAllQueue.cs) | [ListAllQueue](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/ArtifactUploadProcessQueue/ListAllQueue.cs) |

### Terminated Servers Wrapper:  [TerminatedServers](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsartifact/namespaces/{namespace}/servers/search` | GET | ListTerminatedServersWithNamespace | [ListTerminatedServersWithNamespace](../../AccelByte.Sdk/Api/Dsartifact/Operation/TerminatedServers/ListTerminatedServersWithNamespace.cs) | [ListTerminatedServersWithNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/TerminatedServers/ListTerminatedServersWithNamespace.cs) |

### Download Server Artifact Wrapper:  [DownloadServerArtifact](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/DownloadServerArtifact.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsartifact/namespaces/{namespace}/servers/{podName}/artifacts/download` | GET | DownloadServerArtifacts | [DownloadServerArtifacts](../../AccelByte.Sdk/Api/Dsartifact/Operation/DownloadServerArtifact/DownloadServerArtifacts.cs) | [DownloadServerArtifacts](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/DownloadServerArtifact/DownloadServerArtifacts.cs) |
| `/dsartifact/namespaces/{namespace}/servers/{podName}/artifacts/exists` | GET | CheckServerArtifact | [CheckServerArtifact](../../AccelByte.Sdk/Api/Dsartifact/Operation/DownloadServerArtifact/CheckServerArtifact.cs) | [CheckServerArtifact](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/DownloadServerArtifact/CheckServerArtifact.cs) |

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsartifact/servers/search` | GET | ListTerminatedServers | [ListTerminatedServers](../../AccelByte.Sdk/Api/Dsartifact/Operation/AllTerminatedServers/ListTerminatedServers.cs) | [ListTerminatedServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/AllTerminatedServers/ListTerminatedServers.cs) |

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/dsartifact/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Dsartifact/Operation/Operations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Dsartifact/Operations/PublicGetMessages.cs) |


&nbsp;  

## Operations with Generic Response

### Artifact Upload Process Queue Wrapper:  [ArtifactUploadProcessQueue](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/ArtifactUploadProcessQueue.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Terminated Servers Wrapper:  [TerminatedServers](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/TerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Download Server Artifact Wrapper:  [DownloadServerArtifact](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/DownloadServerArtifact.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### All Terminated Servers Wrapper:  [AllTerminatedServers](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/AllTerminatedServers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Dsartifact/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Dsartifact/Model/LogAppMessageDeclaration.cs) |
| `models.AllQueueResult` | [ModelsAllQueueResult](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsAllQueueResult.cs) |
| `models.ArtifactFileStatus` | [ModelsArtifactFileStatus](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsArtifactFileStatus.cs) |
| `models.ListAllQueueResponse` | [ModelsListAllQueueResponse](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsListAllQueueResponse.cs) |
| `models.ListNodesIPAddress` | [ModelsListNodesIPAddress](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsListNodesIPAddress.cs) |
| `models.ListQueueResponse` | [ModelsListQueueResponse](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsListQueueResponse.cs) |
| `models.ListTerminatedServersResponse` | [ModelsListTerminatedServersResponse](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsListTerminatedServersResponse.cs) |
| `models.MatchResult` | [ModelsMatchResult](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsMatchResult.cs) |
| `models.NotifPayloadServerStatusChange` | [ModelsNotifPayloadServerStatusChange](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsNotifPayloadServerStatusChange.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsPagingCursor.cs) |
| `models.Queue` | [ModelsQueue](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsQueue.cs) |
| `models.QueueResult` | [ModelsQueueResult](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsQueueResult.cs) |
| `models.RequestMatchMember` | [ModelsRequestMatchMember](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsRequestMatchMember.cs) |
| `models.RequestMatchParty` | [ModelsRequestMatchParty](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsRequestMatchParty.cs) |
| `models.RequestMatchingAlly` | [ModelsRequestMatchingAlly](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsRequestMatchingAlly.cs) |
| `models.Server` | [ModelsServer](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsServer.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../AccelByte.Sdk/Api/Dsartifact/Model/ModelsStatusHistory.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Dsartifact/Model/ResponseError.cs) |
