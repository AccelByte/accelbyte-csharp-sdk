# Session Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Session/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Session/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfo.cs) |
| `/session/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../AccelByte.Sdk/Api/Session/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfoV1.cs) |

### Configuration Template Wrapper:  [ConfigurationTemplate](../../AccelByte.Sdk/Api/Session/Wrapper/ConfigurationTemplate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/configuration` | POST | AdminCreateConfigurationTemplateV1 | [AdminCreateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) | [AdminCreateConfigurationTemplateV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations` | GET | AdminGetAllConfigurationTemplatesV1 | [AdminGetAllConfigurationTemplatesV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) | [AdminGetAllConfigurationTemplatesV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | GET | AdminGetConfigurationTemplateV1 | [AdminGetConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) | [AdminGetConfigurationTemplateV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | PUT | AdminUpdateConfigurationTemplateV1 | [AdminUpdateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) | [AdminUpdateConfigurationTemplateV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | DELETE | AdminDeleteConfigurationTemplateV1 | [AdminDeleteConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) | [AdminDeleteConfigurationTemplateV1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) |

### Game Session Wrapper:  [GameSession](../../AccelByte.Sdk/Api/Session/Wrapper/GameSession.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/gamesessions` | GET | AdminQueryGameSessions | [AdminQueryGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminQueryGameSessions.cs) | [AdminQueryGameSessions](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminQueryGameSessions.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType}` | PUT | AdminUpdateGameSessionMember | [AdminUpdateGameSessionMember](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminUpdateGameSessionMember.cs) | [AdminUpdateGameSessionMember](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminUpdateGameSessionMember.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesession` | POST | CreateGameSession | [CreateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/CreateGameSession.cs) | [CreateGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/CreateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions` | POST | PublicQueryGameSessions | [PublicQueryGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicQueryGameSessions.cs) | [PublicQueryGameSessions](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryGameSessions.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}` | GET | GetGameSessionByPodName | [GetGameSessionByPodName](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSessionByPodName.cs) | [GetGameSessionByPodName](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSessionByPodName.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSession | [GetGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSession.cs) | [GetGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PUT | UpdateGameSession | [UpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/UpdateGameSession.cs) | [UpdateGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | DELETE | DeleteGameSession | [DeleteGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/DeleteGameSession.cs) | [DeleteGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/DeleteGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PATCH | PatchUpdateGameSession | [PatchUpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PatchUpdateGameSession.cs) | [PatchUpdateGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PatchUpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/invite` | POST | PublicGameSessionInvite | [PublicGameSessionInvite](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicGameSessionInvite.cs) | [PublicGameSessionInvite](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join` | POST | JoinGameSession | [JoinGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/JoinGameSession.cs) | [JoinGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/JoinGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leave` | DELETE | LeaveGameSession | [LeaveGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/LeaveGameSession.cs) | [LeaveGameSession](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/LeaveGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/reject` | DELETE | PublicGameSessionReject | [PublicGameSessionReject](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicGameSessionReject.cs) | [PublicGameSessionReject](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionReject.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/gamesessions` | GET | PublicQueryMyGameSessions | [PublicQueryMyGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicQueryMyGameSessions.cs) | [PublicQueryMyGameSessions](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryMyGameSessions.cs) |

### Party Wrapper:  [Party](../../AccelByte.Sdk/Api/Session/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/parties` | GET | AdminQueryParties | [AdminQueryParties](../../AccelByte.Sdk/Api/Session/Operation/Party/AdminQueryParties.cs) | [AdminQueryParties](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/AdminQueryParties.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/users/me/join/code` | POST | PublicPartyJoinCode | [PublicPartyJoinCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoinCode.cs) | [PublicPartyJoinCode](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetParty | [PublicGetParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGetParty.cs) | [PublicGetParty](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGetParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PUT | PublicUpdateParty | [PublicUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicUpdateParty.cs) | [PublicUpdateParty](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PATCH | PublicPatchUpdateParty | [PublicPatchUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPatchUpdateParty.cs) | [PublicPatchUpdateParty](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPatchUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | POST | PublicGeneratePartyCode | [PublicGeneratePartyCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGeneratePartyCode.cs) | [PublicGeneratePartyCode](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGeneratePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | DELETE | PublicRevokePartyCode | [PublicRevokePartyCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicRevokePartyCode.cs) | [PublicRevokePartyCode](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicRevokePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/invite` | POST | PublicPartyInvite | [PublicPartyInvite](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyInvite.cs) | [PublicPartyInvite](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader` | POST | PublicPromotePartyLeader | [PublicPromotePartyLeader](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPromotePartyLeader.cs) | [PublicPromotePartyLeader](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPromotePartyLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join` | POST | PublicPartyJoin | [PublicPartyJoin](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoin.cs) | [PublicPartyJoin](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoin.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/leave` | DELETE | PublicPartyLeave | [PublicPartyLeave](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyLeave.cs) | [PublicPartyLeave](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyLeave.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/reject` | DELETE | PublicPartyReject | [PublicPartyReject](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyReject.cs) | [PublicPartyReject](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyReject.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/{userId}/kick` | DELETE | PublicPartyKick | [PublicPartyKick](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyKick.cs) | [PublicPartyKick](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyKick.cs) |
| `/session/v1/public/namespaces/{namespace}/party` | POST | PublicCreateParty | [PublicCreateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicCreateParty.cs) | [PublicCreateParty](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicCreateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/parties` | GET | PublicQueryMyParties | [PublicQueryMyParties](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicQueryMyParties.cs) | [PublicQueryMyParties](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicQueryMyParties.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodels.ConfigurationTemplateResponse` | [ApimodelsConfigurationTemplateResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigurationTemplateResponse.cs) |
| `apimodels.ConfigurationTemplatesResponse` | [ApimodelsConfigurationTemplatesResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigurationTemplatesResponse.cs) |
| `apimodels.CreateConfigurationTemplateRequest` | [ApimodelsCreateConfigurationTemplateRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreateConfigurationTemplateRequest.cs) |
| `apimodels.CreateGameSessionRequest` | [ApimodelsCreateGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreateGameSessionRequest.cs) |
| `apimodels.CreatePartyRequest` | [ApimodelsCreatePartyRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreatePartyRequest.cs) |
| `apimodels.DSInformationResponse` | [ApimodelsDSInformationResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsDSInformationResponse.cs) |
| `apimodels.GameSessionQueryResponse` | [ApimodelsGameSessionQueryResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsGameSessionQueryResponse.cs) |
| `apimodels.GameSessionResponse` | [ApimodelsGameSessionResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsGameSessionResponse.cs) |
| `apimodels.JoinByCodeRequest` | [ApimodelsJoinByCodeRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsJoinByCodeRequest.cs) |
| `apimodels.KickResponse` | [ApimodelsKickResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsKickResponse.cs) |
| `apimodels.Pagination` | [ApimodelsPagination](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPagination.cs) |
| `apimodels.PartyQueryResponse` | [ApimodelsPartyQueryResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPartyQueryResponse.cs) |
| `apimodels.PartySessionResponse` | [ApimodelsPartySessionResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPartySessionResponse.cs) |
| `apimodels.PromoteLeaderRequest` | [ApimodelsPromoteLeaderRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPromoteLeaderRequest.cs) |
| `apimodels.PublicConfiguration` | [ApimodelsPublicConfiguration](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPublicConfiguration.cs) |
| `apimodels.RequestMember` | [ApimodelsRequestMember](../../AccelByte.Sdk/Api/Session/Model/ApimodelsRequestMember.cs) |
| `apimodels.SessionInviteRequest` | [ApimodelsSessionInviteRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsSessionInviteRequest.cs) |
| `apimodels.UpdateConfigurationTemplateRequest` | [ApimodelsUpdateConfigurationTemplateRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateConfigurationTemplateRequest.cs) |
| `apimodels.UpdateGameSessionMemberStatusResponse` | [ApimodelsUpdateGameSessionMemberStatusResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGameSessionMemberStatusResponse.cs) |
| `apimodels.UpdateGameSessionRequest` | [ApimodelsUpdateGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGameSessionRequest.cs) |
| `apimodels.UpdatePartyRequest` | [ApimodelsUpdatePartyRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdatePartyRequest.cs) |
| `apimodels.UserResponse` | [ApimodelsUserResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUserResponse.cs) |
| `models.GameServer` | [ModelsGameServer](../../AccelByte.Sdk/Api/Session/Model/ModelsGameServer.cs) |
| `models.Team` | [ModelsTeam](../../AccelByte.Sdk/Api/Session/Model/ModelsTeam.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Session/Model/ResponseError.cs) |
