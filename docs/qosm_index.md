# Qosm Service Index

&nbsp;  

## Operations

### Admin Wrapper:  [Admin](../AccelByte.Sdk/Api/Qosm/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/qosm/admin/namespaces/{namespace}/servers/{region}` | PATCH | UpdateServerConfig | [UpdateServerConfig](../AccelByte.Sdk/Api/Qosm/Operation/Admin/UpdateServerConfig.cs) | [UpdateServerConfig](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Admin/UpdateServerConfig.cs) |
| `/qosm/admin/servers/{region}` | DELETE | DeleteServer | [DeleteServer](../AccelByte.Sdk/Api/Qosm/Operation/Admin/DeleteServer.cs) | [DeleteServer](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Admin/DeleteServer.cs) |
| `/qosm/admin/servers/{region}/alias` | POST | SetServerAlias | [SetServerAlias](../AccelByte.Sdk/Api/Qosm/Operation/Admin/SetServerAlias.cs) | [SetServerAlias](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Admin/SetServerAlias.cs) |

### Public Wrapper:  [Public](../AccelByte.Sdk/Api/Qosm/Wrapper/Public.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/qosm/public/namespaces/{namespace}/qos` | GET | ListServerPerNamespace | [ListServerPerNamespace](../AccelByte.Sdk/Api/Qosm/Operation/Public/ListServerPerNamespace.cs) | [ListServerPerNamespace](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Public/ListServerPerNamespace.cs) |
| `/qosm/public/qos` | GET | ListServer | [ListServer](../AccelByte.Sdk/Api/Qosm/Operation/Public/ListServer.cs) | [ListServer](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Public/ListServer.cs) |

### Server Wrapper:  [Server](../AccelByte.Sdk/Api/Qosm/Wrapper/Server.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/qosm/servers/heartbeat` | POST | Heartbeat | [Heartbeat](../AccelByte.Sdk/Api/Qosm/Operation/Server/Heartbeat.cs) | [Heartbeat](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Qosm/Server/Heartbeat.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.HeartbeatRequest` | [ModelsHeartbeatRequest](../AccelByte.Sdk/Api/Qosm/Model/ModelsHeartbeatRequest.cs) |
| `models.ListServerResponse` | [ModelsListServerResponse](../AccelByte.Sdk/Api/Qosm/Model/ModelsListServerResponse.cs) |
| `models.Server` | [ModelsServer](../AccelByte.Sdk/Api/Qosm/Model/ModelsServer.cs) |
| `models.SetAliasRequest` | [ModelsSetAliasRequest](../AccelByte.Sdk/Api/Qosm/Model/ModelsSetAliasRequest.cs) |
| `models.UpdateServerRequest` | [ModelsUpdateServerRequest](../AccelByte.Sdk/Api/Qosm/Model/ModelsUpdateServerRequest.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Qosm/Model/ResponseError.cs) |
