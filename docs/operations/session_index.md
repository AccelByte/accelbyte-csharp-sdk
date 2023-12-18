# Session Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Session/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Session/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfo.cs) |
| `/session/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../AccelByte.Sdk/Api/Session/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Operations/GetHealthcheckInfoV1.cs) |

### DSMC Default Configuration Wrapper:  [DSMCDefaultConfiguration](../../AccelByte.Sdk/Api/Session/Wrapper/DSMCDefaultConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/dsconfigs/default` | GET | AdminGetDSMCConfigurationDefault | [AdminGetDSMCConfigurationDefault](../../AccelByte.Sdk/Api/Session/Operation/DSMCDefaultConfiguration/AdminGetDSMCConfigurationDefault.cs) | [AdminGetDSMCConfigurationDefault](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/DSMCDefaultConfiguration/AdminGetDSMCConfigurationDefault.cs) |

### Environment Variable Wrapper:  [EnvironmentVariable](../../AccelByte.Sdk/Api/Session/Wrapper/EnvironmentVariable.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/environment-variables` | GET | AdminListEnvironmentVariables | [AdminListEnvironmentVariables](../../AccelByte.Sdk/Api/Session/Operation/EnvironmentVariable/AdminListEnvironmentVariables.cs) | [AdminListEnvironmentVariables](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/EnvironmentVariable/AdminListEnvironmentVariables.cs) |

### Global Configuration Wrapper:  [GlobalConfiguration](../../AccelByte.Sdk/Api/Session/Wrapper/GlobalConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/global-configurations` | GET | AdminListGlobalConfiguration | [AdminListGlobalConfiguration](../../AccelByte.Sdk/Api/Session/Operation/GlobalConfiguration/AdminListGlobalConfiguration.cs) | [AdminListGlobalConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GlobalConfiguration/AdminListGlobalConfiguration.cs) |
| `/session/v1/admin/global-configurations` | PUT | AdminUpdateGlobalConfiguration | [AdminUpdateGlobalConfiguration](../../AccelByte.Sdk/Api/Session/Operation/GlobalConfiguration/AdminUpdateGlobalConfiguration.cs) | [AdminUpdateGlobalConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GlobalConfiguration/AdminUpdateGlobalConfiguration.cs) |
| `/session/v1/admin/global-configurations` | DELETE | AdminDeleteGlobalConfiguration | [AdminDeleteGlobalConfiguration](../../AccelByte.Sdk/Api/Session/Operation/GlobalConfiguration/AdminDeleteGlobalConfiguration.cs) | [AdminDeleteGlobalConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GlobalConfiguration/AdminDeleteGlobalConfiguration.cs) |

### Configuration Template Wrapper:  [ConfigurationTemplate](../../AccelByte.Sdk/Api/Session/Wrapper/ConfigurationTemplate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | GET | AdminGetConfigurationAlertV1 | [AdminGetConfigurationAlertV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetConfigurationAlertV1.cs) | [AdminGetConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | PUT | AdminUpdateConfigurationAlertV1 | [AdminUpdateConfigurationAlertV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationAlertV1.cs) | [AdminUpdateConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | POST | AdminCreateConfigurationAlertV1 | [AdminCreateConfigurationAlertV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminCreateConfigurationAlertV1.cs) | [AdminCreateConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/alerts-configuration` | DELETE | AdminDeleteConfigurationAlertV1 | [AdminDeleteConfigurationAlertV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminDeleteConfigurationAlertV1.cs) | [AdminDeleteConfigurationAlertV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminDeleteConfigurationAlertV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configuration` | POST | AdminCreateConfigurationTemplateV1 | [AdminCreateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) | [AdminCreateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations` | GET | AdminGetAllConfigurationTemplatesV1 | [AdminGetAllConfigurationTemplatesV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) | [AdminGetAllConfigurationTemplatesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetAllConfigurationTemplatesV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | GET | AdminGetConfigurationTemplateV1 | [AdminGetConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) | [AdminGetConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | PUT | AdminUpdateConfigurationTemplateV1 | [AdminUpdateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) | [AdminUpdateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | DELETE | AdminDeleteConfigurationTemplateV1 | [AdminDeleteConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) | [AdminDeleteConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminDeleteConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/dsconfigs` | GET | AdminGetDSMCConfiguration | [AdminGetDSMCConfiguration](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetDSMCConfiguration.cs) | [AdminGetDSMCConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetDSMCConfiguration.cs) |
| `/session/v1/admin/namespaces/{namespace}/dsconfigs/sync` | GET | AdminSyncDSMCConfiguration | [AdminSyncDSMCConfiguration](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminSyncDSMCConfiguration.cs) | [AdminSyncDSMCConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminSyncDSMCConfiguration.cs) |

### Certificate Wrapper:  [Certificate](../../AccelByte.Sdk/Api/Session/Wrapper/Certificate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/certificates/pfx/platforms/xbl` | PUT | HandleUploadXboxPFXCertificate | [HandleUploadXboxPFXCertificate](../../AccelByte.Sdk/Api/Session/Operation/Certificate/HandleUploadXboxPFXCertificate.cs) | [HandleUploadXboxPFXCertificate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Certificate/HandleUploadXboxPFXCertificate.cs) |

### Max Active Wrapper:  [MaxActive](../../AccelByte.Sdk/Api/Session/Wrapper/MaxActive.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}/memberactivesession/{userId}` | GET | AdminGetMemberActiveSession | [AdminGetMemberActiveSession](../../AccelByte.Sdk/Api/Session/Operation/MaxActive/AdminGetMemberActiveSession.cs) | [AdminGetMemberActiveSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/MaxActive/AdminGetMemberActiveSession.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}/reconcile` | POST | AdminReconcileMaxActiveSession | [AdminReconcileMaxActiveSession](../../AccelByte.Sdk/Api/Session/Operation/MaxActive/AdminReconcileMaxActiveSession.cs) | [AdminReconcileMaxActiveSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/MaxActive/AdminReconcileMaxActiveSession.cs) |

### Game Session Wrapper:  [GameSession](../../AccelByte.Sdk/Api/Session/Wrapper/GameSession.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/gamesessions` | GET | AdminQueryGameSessions | [AdminQueryGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminQueryGameSessions.cs) | [AdminQueryGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminQueryGameSessions.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions` | POST | AdminQueryGameSessionsByAttributes | [AdminQueryGameSessionsByAttributes](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminQueryGameSessionsByAttributes.cs) | [AdminQueryGameSessionsByAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminQueryGameSessionsByAttributes.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/bulk` | DELETE | AdminDeleteBulkGameSessions | [AdminDeleteBulkGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminDeleteBulkGameSessions.cs) | [AdminDeleteBulkGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminDeleteBulkGameSessions.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/ds` | PUT | AdminSetDSReady | [AdminSetDSReady](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminSetDSReady.cs) | [AdminSetDSReady](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminSetDSReady.cs) |
| `/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType}` | PUT | AdminUpdateGameSessionMember | [AdminUpdateGameSessionMember](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AdminUpdateGameSessionMember.cs) | [AdminUpdateGameSessionMember](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AdminUpdateGameSessionMember.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesession` | POST | CreateGameSession | [CreateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/CreateGameSession.cs) | [CreateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/CreateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions` | POST | PublicQueryGameSessionsByAttributes | [PublicQueryGameSessionsByAttributes](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicQueryGameSessionsByAttributes.cs) | [PublicQueryGameSessionsByAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryGameSessionsByAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/join/code` | POST | PublicSessionJoinCode | [PublicSessionJoinCode](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicSessionJoinCode.cs) | [PublicSessionJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicSessionJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}` | GET | GetGameSessionByPodName | [GetGameSessionByPodName](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSessionByPodName.cs) | [GetGameSessionByPodName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSessionByPodName.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSession | [GetGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSession.cs) | [GetGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PUT | UpdateGameSession | [UpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/UpdateGameSession.cs) | [UpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | DELETE | DeleteGameSession | [DeleteGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/DeleteGameSession.cs) | [DeleteGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/DeleteGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PATCH | PatchUpdateGameSession | [PatchUpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PatchUpdateGameSession.cs) | [PatchUpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PatchUpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/backfill` | PUT | UpdateGameSessionBackfillTicketID | [UpdateGameSessionBackfillTicketID](../../AccelByte.Sdk/Api/Session/Operation/GameSession/UpdateGameSessionBackfillTicketID.cs) | [UpdateGameSessionBackfillTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSessionBackfillTicketID.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | POST | GameSessionGenerateCode | [GameSessionGenerateCode](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GameSessionGenerateCode.cs) | [GameSessionGenerateCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GameSessionGenerateCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | DELETE | PublicRevokeGameSessionCode | [PublicRevokeGameSessionCode](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicRevokeGameSessionCode.cs) | [PublicRevokeGameSessionCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicRevokeGameSessionCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/invite` | POST | PublicGameSessionInvite | [PublicGameSessionInvite](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicGameSessionInvite.cs) | [PublicGameSessionInvite](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join` | POST | JoinGameSession | [JoinGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/JoinGameSession.cs) | [JoinGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/JoinGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leader` | POST | PublicPromoteGameSessionLeader | [PublicPromoteGameSessionLeader](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicPromoteGameSessionLeader.cs) | [PublicPromoteGameSessionLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicPromoteGameSessionLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leave` | DELETE | LeaveGameSession | [LeaveGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/LeaveGameSession.cs) | [LeaveGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/LeaveGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/reject` | DELETE | PublicGameSessionReject | [PublicGameSessionReject](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicGameSessionReject.cs) | [PublicGameSessionReject](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicGameSessionReject.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/secret` | GET | GetSessionServerSecret | [GetSessionServerSecret](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetSessionServerSecret.cs) | [GetSessionServerSecret](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetSessionServerSecret.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/teams` | POST | AppendTeamGameSession | [AppendTeamGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AppendTeamGameSession.cs) | [AppendTeamGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AppendTeamGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/gamesessions` | GET | PublicQueryMyGameSessions | [PublicQueryMyGameSessions](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicQueryMyGameSessions.cs) | [PublicQueryMyGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicQueryMyGameSessions.cs) |

### Party Wrapper:  [Party](../../AccelByte.Sdk/Api/Session/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/parties` | GET | AdminQueryParties | [AdminQueryParties](../../AccelByte.Sdk/Api/Session/Operation/Party/AdminQueryParties.cs) | [AdminQueryParties](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/AdminQueryParties.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/users/me/join/code` | POST | PublicPartyJoinCode | [PublicPartyJoinCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoinCode.cs) | [PublicPartyJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetParty | [PublicGetParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGetParty.cs) | [PublicGetParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGetParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PUT | PublicUpdateParty | [PublicUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicUpdateParty.cs) | [PublicUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PATCH | PublicPatchUpdateParty | [PublicPatchUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPatchUpdateParty.cs) | [PublicPatchUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPatchUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | POST | PublicGeneratePartyCode | [PublicGeneratePartyCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGeneratePartyCode.cs) | [PublicGeneratePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGeneratePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | DELETE | PublicRevokePartyCode | [PublicRevokePartyCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicRevokePartyCode.cs) | [PublicRevokePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicRevokePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/invite` | POST | PublicPartyInvite | [PublicPartyInvite](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyInvite.cs) | [PublicPartyInvite](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyInvite.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader` | POST | PublicPromotePartyLeader | [PublicPromotePartyLeader](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPromotePartyLeader.cs) | [PublicPromotePartyLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPromotePartyLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join` | POST | PublicPartyJoin | [PublicPartyJoin](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoin.cs) | [PublicPartyJoin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoin.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/leave` | DELETE | PublicPartyLeave | [PublicPartyLeave](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyLeave.cs) | [PublicPartyLeave](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyLeave.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/reject` | DELETE | PublicPartyReject | [PublicPartyReject](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyReject.cs) | [PublicPartyReject](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyReject.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/{userId}/kick` | DELETE | PublicPartyKick | [PublicPartyKick](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyKick.cs) | [PublicPartyKick](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyKick.cs) |
| `/session/v1/public/namespaces/{namespace}/party` | POST | PublicCreateParty | [PublicCreateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicCreateParty.cs) | [PublicCreateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicCreateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/parties` | GET | PublicQueryMyParties | [PublicQueryMyParties](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicQueryMyParties.cs) | [PublicQueryMyParties](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicQueryMyParties.cs) |

### Platform Credential Wrapper:  [PlatformCredential](../../AccelByte.Sdk/Api/Session/Wrapper/PlatformCredential.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | GET | AdminGetPlatformCredentials | [AdminGetPlatformCredentials](../../AccelByte.Sdk/Api/Session/Operation/PlatformCredential/AdminGetPlatformCredentials.cs) | [AdminGetPlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminGetPlatformCredentials.cs) |
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | PUT | AdminUpdatePlatformCredentials | [AdminUpdatePlatformCredentials](../../AccelByte.Sdk/Api/Session/Operation/PlatformCredential/AdminUpdatePlatformCredentials.cs) | [AdminUpdatePlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminUpdatePlatformCredentials.cs) |
| `/session/v1/admin/namespaces/{namespace}/platform-credentials` | DELETE | AdminDeletePlatformCredentials | [AdminDeletePlatformCredentials](../../AccelByte.Sdk/Api/Session/Operation/PlatformCredential/AdminDeletePlatformCredentials.cs) | [AdminDeletePlatformCredentials](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/PlatformCredential/AdminDeletePlatformCredentials.cs) |

### Session Storage Wrapper:  [SessionStorage](../../AccelByte.Sdk/Api/Session/Wrapper/SessionStorage.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage` | GET | AdminReadSessionStorage | [AdminReadSessionStorage](../../AccelByte.Sdk/Api/Session/Operation/SessionStorage/AdminReadSessionStorage.cs) | [AdminReadSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminReadSessionStorage.cs) |
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage` | DELETE | AdminDeleteUserSessionStorage | [AdminDeleteUserSessionStorage](../../AccelByte.Sdk/Api/Session/Operation/SessionStorage/AdminDeleteUserSessionStorage.cs) | [AdminDeleteUserSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminDeleteUserSessionStorage.cs) |
| `/session/v1/admin/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}` | GET | AdminReadUserSessionStorage | [AdminReadUserSessionStorage](../../AccelByte.Sdk/Api/Session/Operation/SessionStorage/AdminReadUserSessionStorage.cs) | [AdminReadUserSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/AdminReadUserSessionStorage.cs) |
| `/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/leader` | PATCH | PublicUpdateInsertSessionStorageLeader | [PublicUpdateInsertSessionStorageLeader](../../AccelByte.Sdk/Api/Session/Operation/SessionStorage/PublicUpdateInsertSessionStorageLeader.cs) | [PublicUpdateInsertSessionStorageLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/PublicUpdateInsertSessionStorageLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/sessions/{sessionId}/storage/users/{userId}` | PATCH | PublicUpdateInsertSessionStorage | [PublicUpdateInsertSessionStorage](../../AccelByte.Sdk/Api/Session/Operation/SessionStorage/PublicUpdateInsertSessionStorage.cs) | [PublicUpdateInsertSessionStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/SessionStorage/PublicUpdateInsertSessionStorage.cs) |

### Player Wrapper:  [Player](../../AccelByte.Sdk/Api/Session/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/users/attributes` | GET | AdminQueryPlayerAttributes | [AdminQueryPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/AdminQueryPlayerAttributes.cs) | [AdminQueryPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminQueryPlayerAttributes.cs) |
| `/session/v1/admin/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetPlayerAttributes | [AdminGetPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/AdminGetPlayerAttributes.cs) | [AdminGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/bulk/platform` | POST | PublicGetBulkPlayerCurrentPlatform | [PublicGetBulkPlayerCurrentPlatform](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicGetBulkPlayerCurrentPlatform.cs) | [PublicGetBulkPlayerCurrentPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetBulkPlayerCurrentPlatform.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | GET | PublicGetPlayerAttributes | [PublicGetPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicGetPlayerAttributes.cs) | [PublicGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | POST | PublicStorePlayerAttributes | [PublicStorePlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicStorePlayerAttributes.cs) | [PublicStorePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicStorePlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | DELETE | PublicDeletePlayerAttributes | [PublicDeletePlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicDeletePlayerAttributes.cs) | [PublicDeletePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicDeletePlayerAttributes.cs) |

### Recent Player Wrapper:  [RecentPlayer](../../AccelByte.Sdk/Api/Session/Wrapper/RecentPlayer.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/public/namespaces/{namespace}/recent-player/{userId}` | GET | PublicGetRecentPlayer | [PublicGetRecentPlayer](../../AccelByte.Sdk/Api/Session/Operation/RecentPlayer/PublicGetRecentPlayer.cs) | [PublicGetRecentPlayer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/RecentPlayer/PublicGetRecentPlayer.cs) |


&nbsp;  

## Operations with Generic Response

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Session/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### DSMC Default Configuration Wrapper:  [DSMCDefaultConfiguration](../../AccelByte.Sdk/Api/Session/Wrapper/DSMCDefaultConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Environment Variable Wrapper:  [EnvironmentVariable](../../AccelByte.Sdk/Api/Session/Wrapper/EnvironmentVariable.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Global Configuration Wrapper:  [GlobalConfiguration](../../AccelByte.Sdk/Api/Session/Wrapper/GlobalConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration Template Wrapper:  [ConfigurationTemplate](../../AccelByte.Sdk/Api/Session/Wrapper/ConfigurationTemplate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/configuration` | POST | AdminCreateConfigurationTemplateV1 | [AdminCreateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) | [AdminCreateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminCreateConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | GET | AdminGetConfigurationTemplateV1 | [AdminGetConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) | [AdminGetConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminGetConfigurationTemplateV1.cs) |
| `/session/v1/admin/namespaces/{namespace}/configurations/{name}` | PUT | AdminUpdateConfigurationTemplateV1 | [AdminUpdateConfigurationTemplateV1](../../AccelByte.Sdk/Api/Session/Operation/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) | [AdminUpdateConfigurationTemplateV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/ConfigurationTemplate/AdminUpdateConfigurationTemplateV1.cs) |

### Certificate Wrapper:  [Certificate](../../AccelByte.Sdk/Api/Session/Wrapper/Certificate.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Max Active Wrapper:  [MaxActive](../../AccelByte.Sdk/Api/Session/Wrapper/MaxActive.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Game Session Wrapper:  [GameSession](../../AccelByte.Sdk/Api/Session/Wrapper/GameSession.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/public/namespaces/{namespace}/gamesession` | POST | CreateGameSession | [CreateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/CreateGameSession.cs) | [CreateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/CreateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/join/code` | POST | PublicSessionJoinCode | [PublicSessionJoinCode](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicSessionJoinCode.cs) | [PublicSessionJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicSessionJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/servers/{podName}` | GET | GetGameSessionByPodName | [GetGameSessionByPodName](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSessionByPodName.cs) | [GetGameSessionByPodName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSessionByPodName.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSession | [GetGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GetGameSession.cs) | [GetGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GetGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PUT | UpdateGameSession | [UpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/UpdateGameSession.cs) | [UpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}` | PATCH | PatchUpdateGameSession | [PatchUpdateGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PatchUpdateGameSession.cs) | [PatchUpdateGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PatchUpdateGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/backfill` | PUT | UpdateGameSessionBackfillTicketID | [UpdateGameSessionBackfillTicketID](../../AccelByte.Sdk/Api/Session/Operation/GameSession/UpdateGameSessionBackfillTicketID.cs) | [UpdateGameSessionBackfillTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/UpdateGameSessionBackfillTicketID.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/code` | POST | GameSessionGenerateCode | [GameSessionGenerateCode](../../AccelByte.Sdk/Api/Session/Operation/GameSession/GameSessionGenerateCode.cs) | [GameSessionGenerateCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/GameSessionGenerateCode.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/join` | POST | JoinGameSession | [JoinGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/JoinGameSession.cs) | [JoinGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/JoinGameSession.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/leader` | POST | PublicPromoteGameSessionLeader | [PublicPromoteGameSessionLeader](../../AccelByte.Sdk/Api/Session/Operation/GameSession/PublicPromoteGameSessionLeader.cs) | [PublicPromoteGameSessionLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/PublicPromoteGameSessionLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/teams` | POST | AppendTeamGameSession | [AppendTeamGameSession](../../AccelByte.Sdk/Api/Session/Operation/GameSession/AppendTeamGameSession.cs) | [AppendTeamGameSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/GameSession/AppendTeamGameSession.cs) |

### Party Wrapper:  [Party](../../AccelByte.Sdk/Api/Session/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/public/namespaces/{namespace}/parties/users/me/join/code` | POST | PublicPartyJoinCode | [PublicPartyJoinCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoinCode.cs) | [PublicPartyJoinCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoinCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetParty | [PublicGetParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGetParty.cs) | [PublicGetParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGetParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PUT | PublicUpdateParty | [PublicUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicUpdateParty.cs) | [PublicUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}` | PATCH | PublicPatchUpdateParty | [PublicPatchUpdateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPatchUpdateParty.cs) | [PublicPatchUpdateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPatchUpdateParty.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/code` | POST | PublicGeneratePartyCode | [PublicGeneratePartyCode](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicGeneratePartyCode.cs) | [PublicGeneratePartyCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicGeneratePartyCode.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/leader` | POST | PublicPromotePartyLeader | [PublicPromotePartyLeader](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPromotePartyLeader.cs) | [PublicPromotePartyLeader](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPromotePartyLeader.cs) |
| `/session/v1/public/namespaces/{namespace}/parties/{partyId}/users/me/join` | POST | PublicPartyJoin | [PublicPartyJoin](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicPartyJoin.cs) | [PublicPartyJoin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicPartyJoin.cs) |
| `/session/v1/public/namespaces/{namespace}/party` | POST | PublicCreateParty | [PublicCreateParty](../../AccelByte.Sdk/Api/Session/Operation/Party/PublicCreateParty.cs) | [PublicCreateParty](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Party/PublicCreateParty.cs) |

### Platform Credential Wrapper:  [PlatformCredential](../../AccelByte.Sdk/Api/Session/Wrapper/PlatformCredential.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Session Storage Wrapper:  [SessionStorage](../../AccelByte.Sdk/Api/Session/Wrapper/SessionStorage.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Player Wrapper:  [Player](../../AccelByte.Sdk/Api/Session/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/session/v1/admin/namespaces/{namespace}/users/attributes` | GET | AdminQueryPlayerAttributes | [AdminQueryPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/AdminQueryPlayerAttributes.cs) | [AdminQueryPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminQueryPlayerAttributes.cs) |
| `/session/v1/admin/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetPlayerAttributes | [AdminGetPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/AdminGetPlayerAttributes.cs) | [AdminGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/AdminGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | GET | PublicGetPlayerAttributes | [PublicGetPlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicGetPlayerAttributes.cs) | [PublicGetPlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicGetPlayerAttributes.cs) |
| `/session/v1/public/namespaces/{namespace}/users/me/attributes` | POST | PublicStorePlayerAttributes | [PublicStorePlayerAttributes](../../AccelByte.Sdk/Api/Session/Operation/Player/PublicStorePlayerAttributes.cs) | [PublicStorePlayerAttributes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Session/Player/PublicStorePlayerAttributes.cs) |

### Recent Player Wrapper:  [RecentPlayer](../../AccelByte.Sdk/Api/Session/Wrapper/RecentPlayer.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodels.AppendTeamGameSessionRequest` | [ApimodelsAppendTeamGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsAppendTeamGameSessionRequest.cs) |
| `apimodels.ConfigAlertRequestCreate` | [ApimodelsConfigAlertRequestCreate](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigAlertRequestCreate.cs) |
| `apimodels.ConfigAlertResponse` | [ApimodelsConfigAlertResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigAlertResponse.cs) |
| `apimodels.ConfigurationTemplateResponse` | [ApimodelsConfigurationTemplateResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigurationTemplateResponse.cs) |
| `apimodels.ConfigurationTemplatesResponse` | [ApimodelsConfigurationTemplatesResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsConfigurationTemplatesResponse.cs) |
| `apimodels.CreateConfigurationTemplateRequest` | [ApimodelsCreateConfigurationTemplateRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreateConfigurationTemplateRequest.cs) |
| `apimodels.CreateGameSessionRequest` | [ApimodelsCreateGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreateGameSessionRequest.cs) |
| `apimodels.CreatePartyRequest` | [ApimodelsCreatePartyRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsCreatePartyRequest.cs) |
| `apimodels.DSInformationResponse` | [ApimodelsDSInformationResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsDSInformationResponse.cs) |
| `apimodels.DeleteBulkGameSessionRequest` | [ApimodelsDeleteBulkGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsDeleteBulkGameSessionRequest.cs) |
| `apimodels.DeleteBulkGameSessionsAPIResponse` | [ApimodelsDeleteBulkGameSessionsAPIResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsDeleteBulkGameSessionsAPIResponse.cs) |
| `apimodels.EnvironmentVariableListResponse` | [ApimodelsEnvironmentVariableListResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsEnvironmentVariableListResponse.cs) |
| `apimodels.EnvironmentVariableResponse` | [ApimodelsEnvironmentVariableResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsEnvironmentVariableResponse.cs) |
| `apimodels.GameSessionQueryResponse` | [ApimodelsGameSessionQueryResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsGameSessionQueryResponse.cs) |
| `apimodels.GameSessionResponse` | [ApimodelsGameSessionResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsGameSessionResponse.cs) |
| `apimodels.GlobalConfigurationResponse` | [ApimodelsGlobalConfigurationResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsGlobalConfigurationResponse.cs) |
| `apimodels.JoinByCodeRequest` | [ApimodelsJoinByCodeRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsJoinByCodeRequest.cs) |
| `apimodels.KickResponse` | [ApimodelsKickResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsKickResponse.cs) |
| `apimodels.Pagination` | [ApimodelsPagination](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPagination.cs) |
| `apimodels.PartyQueryResponse` | [ApimodelsPartyQueryResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPartyQueryResponse.cs) |
| `apimodels.PartySessionResponse` | [ApimodelsPartySessionResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPartySessionResponse.cs) |
| `apimodels.PlayerAttributesRequestBody` | [ApimodelsPlayerAttributesRequestBody](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPlayerAttributesRequestBody.cs) |
| `apimodels.PlayerAttributesResponseBody` | [ApimodelsPlayerAttributesResponseBody](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPlayerAttributesResponseBody.cs) |
| `apimodels.PlayerPlatform` | [ApimodelsPlayerPlatform](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPlayerPlatform.cs) |
| `apimodels.PlayersCurrentPlatformRequest` | [ApimodelsPlayersCurrentPlatformRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPlayersCurrentPlatformRequest.cs) |
| `apimodels.PlayersCurrentPlatformResponse` | [ApimodelsPlayersCurrentPlatformResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPlayersCurrentPlatformResponse.cs) |
| `apimodels.PromoteLeaderRequest` | [ApimodelsPromoteLeaderRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPromoteLeaderRequest.cs) |
| `apimodels.PublicConfiguration` | [ApimodelsPublicConfiguration](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPublicConfiguration.cs) |
| `apimodels.PutGlobalConfigurationRequest` | [ApimodelsPutGlobalConfigurationRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPutGlobalConfigurationRequest.cs) |
| `apimodels.PutPlatformCredentialsRequest` | [ApimodelsPutPlatformCredentialsRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsPutPlatformCredentialsRequest.cs) |
| `apimodels.RequestMember` | [ApimodelsRequestMember](../../AccelByte.Sdk/Api/Session/Model/ApimodelsRequestMember.cs) |
| `apimodels.ResponseDeleteBulkGameSessions` | [ApimodelsResponseDeleteBulkGameSessions](../../AccelByte.Sdk/Api/Session/Model/ApimodelsResponseDeleteBulkGameSessions.cs) |
| `apimodels.ServerSecret` | [ApimodelsServerSecret](../../AccelByte.Sdk/Api/Session/Model/ApimodelsServerSecret.cs) |
| `apimodels.SessionInviteRequest` | [ApimodelsSessionInviteRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsSessionInviteRequest.cs) |
| `apimodels.SessionInviteResponse` | [ApimodelsSessionInviteResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsSessionInviteResponse.cs) |
| `apimodels.SetDSReadyRequest` | [ApimodelsSetDSReadyRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsSetDSReadyRequest.cs) |
| `apimodels.UpdateConfigurationTemplateRequest` | [ApimodelsUpdateConfigurationTemplateRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateConfigurationTemplateRequest.cs) |
| `apimodels.UpdateGameSessionBackfillRequest` | [ApimodelsUpdateGameSessionBackfillRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGameSessionBackfillRequest.cs) |
| `apimodels.UpdateGameSessionMemberStatusResponse` | [ApimodelsUpdateGameSessionMemberStatusResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGameSessionMemberStatusResponse.cs) |
| `apimodels.UpdateGameSessionRequest` | [ApimodelsUpdateGameSessionRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdateGameSessionRequest.cs) |
| `apimodels.UpdatePartyRequest` | [ApimodelsUpdatePartyRequest](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUpdatePartyRequest.cs) |
| `apimodels.UserResponse` | [ApimodelsUserResponse](../../AccelByte.Sdk/Api/Session/Model/ApimodelsUserResponse.cs) |
| `models.DSMConfigRecord` | [ModelsDSMConfigRecord](../../AccelByte.Sdk/Api/Session/Model/ModelsDSMConfigRecord.cs) |
| `models.DefaultDSMCConfig` | [ModelsDefaultDSMCConfig](../../AccelByte.Sdk/Api/Session/Model/ModelsDefaultDSMCConfig.cs) |
| `models.GameServer` | [ModelsGameServer](../../AccelByte.Sdk/Api/Session/Model/ModelsGameServer.cs) |
| `models.MemberActiveSession` | [ModelsMemberActiveSession](../../AccelByte.Sdk/Api/Session/Model/ModelsMemberActiveSession.cs) |
| `models.NativeSessionSetting` | [ModelsNativeSessionSetting](../../AccelByte.Sdk/Api/Session/Model/ModelsNativeSessionSetting.cs) |
| `models.PSNAppServerCredentials` | [ModelsPSNAppServerCredentials](../../AccelByte.Sdk/Api/Session/Model/ModelsPSNAppServerCredentials.cs) |
| `models.PartyMembers` | [ModelsPartyMembers](../../AccelByte.Sdk/Api/Session/Model/ModelsPartyMembers.cs) |
| `models.PlatformCredentials` | [ModelsPlatformCredentials](../../AccelByte.Sdk/Api/Session/Model/ModelsPlatformCredentials.cs) |
| `models.PortConfigurationAMS` | [ModelsPortConfigurationAMS](../../AccelByte.Sdk/Api/Session/Model/ModelsPortConfigurationAMS.cs) |
| `models.RecentPlayerQueryResponse` | [ModelsRecentPlayerQueryResponse](../../AccelByte.Sdk/Api/Session/Model/ModelsRecentPlayerQueryResponse.cs) |
| `models.RequestReconcileMaxActiveSession` | [ModelsRequestReconcileMaxActiveSession](../../AccelByte.Sdk/Api/Session/Model/ModelsRequestReconcileMaxActiveSession.cs) |
| `models.Team` | [ModelsTeam](../../AccelByte.Sdk/Api/Session/Model/ModelsTeam.cs) |
| `models.UserInfo` | [ModelsUserInfo](../../AccelByte.Sdk/Api/Session/Model/ModelsUserInfo.cs) |
| `models.UserPlatformInfo` | [ModelsUserPlatformInfo](../../AccelByte.Sdk/Api/Session/Model/ModelsUserPlatformInfo.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Session/Model/ResponseError.cs) |
