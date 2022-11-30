# Sessionbrowser Service Index

&nbsp;  

## Operations

### Session Wrapper:  [Session](../../AccelByte.Sdk/Api/Sessionbrowser/Wrapper/Session.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/count` | GET | GetTotalActiveSession | [GetTotalActiveSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetTotalActiveSession.cs) | [GetTotalActiveSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetTotalActiveSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game` | GET | GetActiveCustomGameSessions | [GetActiveCustomGameSessions](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetActiveCustomGameSessions.cs) | [GetActiveCustomGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetActiveCustomGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game` | GET | GetActiveMatchmakingGameSessions | [GetActiveMatchmakingGameSessions](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetActiveMatchmakingGameSessions.cs) | [GetActiveMatchmakingGameSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetActiveMatchmakingGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID}` | GET | AdminGetSession | [AdminGetSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AdminGetSession.cs) | [AdminGetSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminGetSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID}` | DELETE | AdminDeleteSession | [AdminDeleteSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AdminDeleteSession.cs) | [AdminDeleteSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminDeleteSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/sessions/history/search` | GET | AdminSearchSessionsV2 | [AdminSearchSessionsV2](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AdminSearchSessionsV2.cs) | [AdminSearchSessionsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AdminSearchSessionsV2.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed` | GET | GetSessionHistoryDetailed | [GetSessionHistoryDetailed](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetSessionHistoryDetailed.cs) | [GetSessionHistoryDetailed](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSessionHistoryDetailed.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | GET | QuerySession | [QuerySession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/QuerySession.cs) | [QuerySession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/QuerySession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | POST | CreateSession | [CreateSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/CreateSession.cs) | [CreateSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/CreateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/bulk` | GET | GetSessionByUserIDs | [GetSessionByUserIDs](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetSessionByUserIDs.cs) | [GetSessionByUserIDs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSessionByUserIDs.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | GET | GetSession | [GetSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetSession.cs) | [GetSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | PUT | UpdateSession | [UpdateSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/UpdateSession.cs) | [UpdateSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/UpdateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | DELETE | DeleteSession | [DeleteSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/DeleteSession.cs) | [DeleteSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/DeleteSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join` | POST | JoinSession | [JoinSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/JoinSession.cs) | [JoinSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/JoinSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds` | DELETE | DeleteSessionLocalDS | [DeleteSessionLocalDS](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/DeleteSessionLocalDS.cs) | [DeleteSessionLocalDS](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/DeleteSessionLocalDS.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player` | POST | AddPlayerToSession | [AddPlayerToSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AddPlayerToSession.cs) | [AddPlayerToSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/AddPlayerToSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player/{userID}` | DELETE | RemovePlayerFromSession | [RemovePlayerFromSession](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/RemovePlayerFromSession.cs) | [RemovePlayerFromSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/RemovePlayerFromSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/settings` | PUT | UpdateSettings | [UpdateSettings](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/UpdateSettings.cs) | [UpdateSettings](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/UpdateSettings.cs) |
| `/sessionbrowser/namespaces/{namespace}/recentplayer/{userID}` | GET | GetRecentPlayer | [GetRecentPlayer](../../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetRecentPlayer.cs) | [GetRecentPlayer](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionbrowser/Session/GetRecentPlayer.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.ActiveCustomGameResponse` | [ModelsActiveCustomGameResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsActiveCustomGameResponse.cs) |
| `models.ActiveMatchmakingGameResponse` | [ModelsActiveMatchmakingGameResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsActiveMatchmakingGameResponse.cs) |
| `models.AddPlayerRequest` | [ModelsAddPlayerRequest](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAddPlayerRequest.cs) |
| `models.AddPlayerResponse` | [ModelsAddPlayerResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAddPlayerResponse.cs) |
| `models.AdminSessionResponse` | [ModelsAdminSessionResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAdminSessionResponse.cs) |
| `models.CountActiveSessionResponse` | [ModelsCountActiveSessionResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCountActiveSessionResponse.cs) |
| `models.CreateSessionRequest` | [ModelsCreateSessionRequest](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCreateSessionRequest.cs) |
| `models.CustomGameResponse` | [ModelsCustomGameResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCustomGameResponse.cs) |
| `models.GameSession` | [ModelsGameSession](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGameSession.cs) |
| `models.GameSessionSetting` | [ModelsGameSessionSetting](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGameSessionSetting.cs) |
| `models.GetSessionHistoryDetailedResponseItem` | [ModelsGetSessionHistoryDetailedResponseItem](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGetSessionHistoryDetailedResponseItem.cs) |
| `models.GetSessionHistorySearchResponseItemV2` | [ModelsGetSessionHistorySearchResponseItemV2](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGetSessionHistorySearchResponseItemV2.cs) |
| `models.GetSessionHistorySearchResponseV2` | [ModelsGetSessionHistorySearchResponseV2](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGetSessionHistorySearchResponseV2.cs) |
| `models.JoinGameSessionRequest` | [ModelsJoinGameSessionRequest](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsJoinGameSessionRequest.cs) |
| `models.MatchAttributes` | [ModelsMatchAttributes](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchAttributes.cs) |
| `models.MatchMaking` | [ModelsMatchMaking](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchMaking.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchingParty.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsPagination.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsPagingCursor.cs) |
| `models.PartyMember` | [ModelsPartyMember](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsPartyMember.cs) |
| `models.RecentPlayerHistory` | [ModelsRecentPlayerHistory](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsRecentPlayerHistory.cs) |
| `models.RecentPlayerQueryResponse` | [ModelsRecentPlayerQueryResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsRecentPlayerQueryResponse.cs) |
| `models.Server` | [ModelsServer](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsServer.cs) |
| `models.SessionByUserIDsResponse` | [ModelsSessionByUserIDsResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionByUserIDsResponse.cs) |
| `models.SessionQueryResponse` | [ModelsSessionQueryResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionQueryResponse.cs) |
| `models.SessionResponse` | [ModelsSessionResponse](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionResponse.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsStatusHistory.cs) |
| `models.UpdateSessionRequest` | [ModelsUpdateSessionRequest](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsUpdateSessionRequest.cs) |
| `models.UpdateSettingsRequest` | [ModelsUpdateSettingsRequest](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsUpdateSettingsRequest.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Sessionbrowser/Model/ResponseError.cs) |
| `restapi.ErrorResponseV2` | [RestapiErrorResponseV2](../../AccelByte.Sdk/Api/Sessionbrowser/Model/RestapiErrorResponseV2.cs) |
| `restapi.ErrorV1` | [RestapiErrorV1](../../AccelByte.Sdk/Api/Sessionbrowser/Model/RestapiErrorV1.cs) |
