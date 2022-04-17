# Gametelemetry Service Index

&nbsp;  

## Operations

### Gametelemetry Operations Wrapper:  [GametelemetryOperations](../AccelByte.Sdk/Api/Gametelemetry/Wrapper/GametelemetryOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/game-telemetry/v1/admin/events` | GET | AdminGetEventsGameTelemetryV1AdminEventsGet | [AdminGetEventsGameTelemetryV1AdminEventsGet](../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/AdminGetEventsGameTelemetryV1AdminEventsGet.cs) | [AdminGetEventsGameTelemetryV1AdminEventsGet](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/AdminGetEventsGameTelemetryV1AdminEventsGet.cs) |
| `/game-telemetry/v1/admin/telemetrynamespace` | GET | AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet | [AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet](../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet.cs) | [AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet.cs) |
| `/game-telemetry/v1/protected/events` | POST | ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) | [ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime` | GET | ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) | [ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.cs) |
| `/game-telemetry/v1/protected/steamIds/{steamId}/playtime/{playtime}` | PUT | ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../AccelByte.Sdk/Api/Gametelemetry/Operation/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) | [ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gametelemetry/GametelemetryOperations/ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `HTTPValidationError` | [HTTPValidationError](../AccelByte.Sdk/Api/Gametelemetry/Model/HTTPValidationError.cs) |
| `TelemetryBody` | [TelemetryBody](../AccelByte.Sdk/Api/Gametelemetry/Model/TelemetryBody.cs) |
| `ValidationError` | [ValidationError](../AccelByte.Sdk/Api/Gametelemetry/Model/ValidationError.cs) |
