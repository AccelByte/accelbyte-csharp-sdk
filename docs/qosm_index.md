# Qosm Service Index

&nbsp;  

## Operations

### Admin Wrapper:  [Admin](../AccelByte.Sdk/Api/Qosm/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /qosm/admin/servers/{region} | DELETE | DeleteServer | [DeleteServer](../AccelByte.Sdk/Api/Qosm/Operation//DeleteServer.cs) |
| /qosm/admin/servers/{region}/alias | POST | SetServerAlias | [SetServerAlias](../AccelByte.Sdk/Api/Qosm/Operation//SetServerAlias.cs) |

### Public Wrapper:  [Public](../AccelByte.Sdk/Api/Qosm/Wrapper/Public.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /qosm/public/qos | GET | ListServer | [ListServer](../AccelByte.Sdk/Api/Qosm/Operation//ListServer.cs) |

### Server Wrapper:  [Server](../AccelByte.Sdk/Api/Qosm/Wrapper/Server.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /qosm/servers/heartbeat | POST | Heartbeat | [Heartbeat](../AccelByte.Sdk/Api/Qosm/Operation//Heartbeat.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| models.HeartbeatRequest | [ModelsHeartbeatRequest](../AccelByte.Sdk/Api/Qosm/Model/ModelsHeartbeatRequest.cs) |
| models.ListServerResponse | [ModelsListServerResponse](../AccelByte.Sdk/Api/Qosm/Model/ModelsListServerResponse.cs) |
| models.Server | [ModelsServer](../AccelByte.Sdk/Api/Qosm/Model/ModelsServer.cs) |
| models.SetAliasRequest | [ModelsSetAliasRequest](../AccelByte.Sdk/Api/Qosm/Model/ModelsSetAliasRequest.cs) |
| response.Error | [ResponseError](../AccelByte.Sdk/Api/Qosm/Model/ResponseError.cs) |
