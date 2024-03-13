<a name="v0.56.0"></a>
## [v0.56.0] - 2024-03-13

### BREAKING CHANGE

### GameTelemetry
- Operation `AccelByte.Sdk.Api.Gametelemetry.Operation.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet`
    - response changed from `Dictionary<string, object>?` to `PlayTimeResponse?`
- Operation `AccelByte.Sdk.Api.Gametelemetry.Operation.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut`
    - response changed from `void` to `PlayTimeResponse?`
- Operation `AccelByte.Sdk.Api.Gametelemetry.Operation.GetEventsGameTelemetryV1AdminNamespacesNamespaceEventsGet`
    - response changed from `void` to `PagedResponseGetNamespaceEventResponse?`
- Operation `AccelByte.Sdk.Api.Gametelemetry.Operation.GetNamespacesGameTelemetryV1AdminNamespacesGet`
    - response changed from `void` to `ListBaseResponseStr?`

### Lobby
- WS Model `ChannelChatNotif`
    - Field `SentAt` type changed from `string?` to `DateTime?`
- WS Model `FriendsStatusResponse`
    - Field `LastSeenAt ` type changed from `List<string>?` to `List<DateTime>?`
- WS Model `MessageNotif`
    - Field `SentAt` type changed from `long?` to `DateTime?`
- WS Model `PartyChatNotif`
    - Field `ReceivedAt ` type changed from `long?` to `DateTime?`
- WS Model `PartyChatRequest`
    - Field `ReceivedAt ` type changed from `long?` to `DateTime?`
- WS Model `PartyDataUpdateNotif`
    - Field `UpdatedAt ` type changed from `long?` to `DateTime?`
- WS Model `PersonalChatNotif`
    - Field `ReceivedAt ` type changed from `long?` to `DateTime?`
- WS Model `PersonalChatRequest`
    - Field `ReceivedAt ` type changed from `long?` to `DateTime?`
- WS Model `UserStatusNotif`
    - Field `LastSeenAt ` type changed from `string?` to `DateTime?`

### Session
- Operation `AccelByte.Sdk.Api.Iam.Session.PublicGetRecentPlayer`
    - Optional parameter `UserId` is removed.    

[v0.56.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.55.0...v0.56.0