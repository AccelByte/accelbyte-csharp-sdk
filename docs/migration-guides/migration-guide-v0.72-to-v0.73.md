<a name="v0.73.0"></a>
## [0.73.0] - 2025-07-16

### REMOVED SERVICE APIS
DSartifact, DSLogManager, DSMC, and QOSM APIs have been removed in this release.

### BREAKING CHANGE

### platform

- Operation `AccelByte.Sdk/Api/Platform/Operation/Store/ImportStoreByCSV`
    - These required parameters now optional.
        - `category`
        - `display`
        - `item`
        - `notes`
        - `section`

### session

- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsConfigurationTemplateResponse`
    - field `Joinability` type changed from `string?` to `ApimodelsConfigurationTemplateResponseJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsConfigurationTemplateResponseType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsCreateConfigurationTemplateRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsCreateConfigurationTemplateRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsCreateConfigurationTemplateRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsCreateGameSessionRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsCreateGameSessionRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsCreateGameSessionRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsCreatePartyRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsCreatePartyRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsCreatePartyRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsDSInformationResponse`
    - field `Status` type changed from `string?` to `ApimodelsDSInformationResponseStatus?`.
    - field `StatusV2` type changed from `string?` to `ApimodelsDSInformationResponseStatusV2?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsPublicConfiguration`
    - field `Joinability` type changed from `string?` to `ApimodelsPublicConfigurationJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsPublicConfigurationType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsUpdateConfigurationTemplateRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsUpdateConfigurationTemplateRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsUpdateConfigurationTemplateRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsUpdateGameSessionRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsUpdateGameSessionRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsUpdateGameSessionRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsUpdatePartyRequest`
    - field `Joinability` type changed from `string?` to `ApimodelsUpdatePartyRequestJoinability?`.
    - field `Type` type changed from `string?` to `ApimodelsUpdatePartyRequestType?`.
- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsUserResponse`
    - field `Status` type changed from `string?` to `ApimodelsUserResponseStatus?`.
    - field `StatusV2` type changed from `string?` to `ApimodelsUserResponseStatusV2?`.


- Operation `AccelByte.Sdk/Api/Session/Operation/GameSession/AdminQueryGameSessions`
    - `Joinability` param type changed from `string?` to `AdminQueryGameSessionsJoinability?`.
    - `Status` param type changed from `string?` to `AdminQueryGameSessionsStatus?`.
    - `StatusV2` param type changed from `string?` to `AdminQueryGameSessionsStatusV2?`.
- Operation `AccelByte.Sdk/Api/Session/Operation/GameSession/AdminQueryParties`
    - `Joinability` param type changed from `string?` to `AdminQueryPartiesJoinability?`.
    - `MemberStatus` param type changed from `string?` to `AdminQueryPartiesMemberStatus?`.