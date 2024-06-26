# Gametelemetry Service Index

&nbsp;  

## Operations

### telemetry Wrapper:  [Telemetry](../../AccelByte.Sdk/Api/Gametelemetry/Wrapper/Telemetry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/game-telemetry/v1/admin/namespaces` | GET | GetNamespacesGameTelemetryV1AdminNamespacesGet | [GetNamespacesGameTelemetryV1AdminNamespacesGet](../../AccelByte.Sdk/Api/Gametelemetry/Operation/Telemetry/GetNamespacesGameTelemetryV1AdminNamespacesGet.cs) | [GetNamespacesGameTelemetryV1AdminNamespacesGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/Telemetry/GetNamespacesGameTelemetryV1AdminNamespacesGet.cs) |
| `/game-telemetry/v1/admin/namespaces/{namespace}/events` | GET | GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet | [GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet](../../AccelByte.Sdk/Api/Gametelemetry/Operation/Telemetry/GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.cs) | [GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/Telemetry/GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet.cs) |

### Gametelemetry Operations Wrapper:  [GametelemetryOperations](../../AccelByte.Sdk/Api/Gametelemetry/Wrapper/GametelemetryOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/game-telemetry/v1/protected/events` | POST | ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime` | GET | ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime/{playtime}` | PUT | ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) |


&nbsp;  

## Operations with Generic Response

### telemetry Wrapper:  [Telemetry](../../AccelByte.Sdk/Api/Gametelemetry/Wrapper/Telemetry.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Gametelemetry Operations Wrapper:  [GametelemetryOperations](../../AccelByte.Sdk/Api/Gametelemetry/Wrapper/GametelemetryOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `BaseErrorResponse` | [BaseErrorResponse](../../AccelByte.Sdk/Api/Gametelemetry/Model/BaseErrorResponse.cs) |
| `GetNamespaceEventResponse` | [GetNamespaceEventResponse](../../AccelByte.Sdk/Api/Gametelemetry/Model/GetNamespaceEventResponse.cs) |
| `HTTPValidationError` | [HTTPValidationError](../../AccelByte.Sdk/Api/Gametelemetry/Model/HTTPValidationError.cs) |
| `ListBaseResponse_str_` | [ListBaseResponseStr](../../AccelByte.Sdk/Api/Gametelemetry/Model/ListBaseResponseStr.cs) |
| `PagedResponse_GetNamespaceEventResponse_` | [PagedResponseGetNamespaceEventResponse](../../AccelByte.Sdk/Api/Gametelemetry/Model/PagedResponseGetNamespaceEventResponse.cs) |
| `Paging` | [Paging](../../AccelByte.Sdk/Api/Gametelemetry/Model/Paging.cs) |
| `PlayTimeResponse` | [PlayTimeResponse](../../AccelByte.Sdk/Api/Gametelemetry/Model/PlayTimeResponse.cs) |
| `TelemetryBody` | [TelemetryBody](../../AccelByte.Sdk/Api/Gametelemetry/Model/TelemetryBody.cs) |
| `ValidationError` | [ValidationError](../../AccelByte.Sdk/Api/Gametelemetry/Model/ValidationError.cs) |
