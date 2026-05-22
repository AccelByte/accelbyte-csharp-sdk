<a name="v0.80.0"></a>
## [0.80.0] - 2026-05-22

### BREAKING CHANGES

#### Challenge

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminDeleteTiedChallenge`
    - Constructor signature changed: a new parameter `string? safeDelete` has been added.
    - Before: `new AdminDeleteTiedChallenge(string challengeCode, string namespace_)`
    - After: `new AdminDeleteTiedChallenge(string challengeCode, string namespace_, string? safeDelete)`
    - Callers that construct this operation directly must add the new parameter (pass `null` to preserve previous behavior).

#### IAM

The following model(s) has been updated.
- Model `AccelByte.Sdk/Api/Iam/Model/ClientmodelClientCreationV3Request`
    - Property `ParentNamespace` has been removed.

#### Platform

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetQRCode`
    - Response type changed from `Platform.Model.BinarySchema?` to `byte[]?`.
    - The corresponding wrapper methods `PaymentStation.PublicGetQRCode` / `PublicGetQRCodeAsync` and the `Execute` / `ExecuteAsync` extensions now return `byte[]?`.
- Operation `AccelByte.Sdk/Api/Platform/Operation/Wallet/CheckBalance`
    - Response type changed from `void` to `Platform.Model.CheckBalanceResponse?`.
    - The corresponding wrapper methods `Wallet.CheckBalance` / `CheckBalanceAsync` and the `Execute` / `ExecuteAsync` extensions now return `Platform.Model.CheckBalanceResponse?`.

The following model(s) has been removed.
- Model `AccelByte.Sdk/Api/Platform/Model/BinarySchema` has been removed. Callers should use `byte[]` (see `PublicGetQRCode` above).

#### Session

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Session/Operation/GameSession/JoinGameSession`
    - Constructor signature changed: a new required parameter `Model.ApimodelsJoinSessionRequest body` has been added.
    - Before: `new JoinGameSession(string namespace_, string sessionId)`
    - After: `new JoinGameSession(string namespace_, string sessionId, Model.ApimodelsJoinSessionRequest body)`
    - Callers that construct this operation directly must supply the new body parameter.
- Operation `AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoin`
    - Constructor signature changed: a new required parameter `Model.ApimodelsJoinSessionRequest body` has been added.
    - Before: `new PublicPartyJoin(string namespace_, string partyId)`
    - After: `new PublicPartyJoin(string namespace_, string partyId, Model.ApimodelsJoinSessionRequest body)`
    - Callers that construct this operation directly must supply the new body parameter.

The following model(s) has been updated.
- Model `AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGamesessionDSInformationRequest`
    - Property `Status` type changed from `string?` to `ApimodelsUpdateGamesessionDSInformationRequestStatus?` (a string enum). String literals continue to work via implicit conversion, but explicitly typed references must be updated.
