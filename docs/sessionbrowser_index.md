# Sessionbrowser Service Index

&nbsp;  

## Operations

### Session Wrapper:  [Session](../AccelByte.Sdk/Api/Sessionbrowser/Wrapper/Session.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/count` | GET | GetTotalActiveSession | [GetTotalActiveSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetTotalActiveSession.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game` | GET | GetActiveCustomGameSessions | [GetActiveCustomGameSessions](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetActiveCustomGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/matchmaking-game` | GET | GetActiveMatchmakingGameSessions | [GetActiveMatchmakingGameSessions](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetActiveMatchmakingGameSessions.cs) |
| `/sessionbrowser/admin/namespaces/{namespace}/gamesession/{sessionID}` | GET | AdminGetSession | [AdminGetSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AdminGetSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | GET | QuerySession | [QuerySession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/QuerySession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession` | POST | CreateSession | [CreateSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/CreateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/bulk` | GET | GetSessionByUserIDs | [GetSessionByUserIDs](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetSessionByUserIDs.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | GET | GetSession | [GetSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | PUT | UpdateSession | [UpdateSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/UpdateSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}` | DELETE | DeleteSession | [DeleteSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/DeleteSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/join` | POST | JoinSession | [JoinSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/JoinSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/localds` | DELETE | DeleteSessionLocalDS | [DeleteSessionLocalDS](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/DeleteSessionLocalDS.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player` | POST | AddPlayerToSession | [AddPlayerToSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/AddPlayerToSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player/{userID}` | DELETE | RemovePlayerFromSession | [RemovePlayerFromSession](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/RemovePlayerFromSession.cs) |
| `/sessionbrowser/namespaces/{namespace}/recentplayer/{userID}` | GET | GetRecentPlayer | [GetRecentPlayer](../AccelByte.Sdk/Api/Sessionbrowser/Operation/Session/GetRecentPlayer.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.ActiveCustomGameResponse` | [ModelsActiveCustomGameResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsActiveCustomGameResponse.cs) |
| `models.ActiveMatchmakingGameResponse` | [ModelsActiveMatchmakingGameResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsActiveMatchmakingGameResponse.cs) |
| `models.AddPlayerRequest` | [ModelsAddPlayerRequest](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAddPlayerRequest.cs) |
| `models.AddPlayerResponse` | [ModelsAddPlayerResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAddPlayerResponse.cs) |
| `models.AdminSessionResponse` | [ModelsAdminSessionResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsAdminSessionResponse.cs) |
| `models.CountActiveSessionResponse` | [ModelsCountActiveSessionResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCountActiveSessionResponse.cs) |
| `models.CreateSessionRequest` | [ModelsCreateSessionRequest](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCreateSessionRequest.cs) |
| `models.CustomGameResponse` | [ModelsCustomGameResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsCustomGameResponse.cs) |
| `models.GameSession` | [ModelsGameSession](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGameSession.cs) |
| `models.GameSessionSetting` | [ModelsGameSessionSetting](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsGameSessionSetting.cs) |
| `models.JoinGameSessionRequest` | [ModelsJoinGameSessionRequest](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsJoinGameSessionRequest.cs) |
| `models.MatchMaking` | [ModelsMatchMaking](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchMaking.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsMatchingParty.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsPagingCursor.cs) |
| `models.PartyMember` | [ModelsPartyMember](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsPartyMember.cs) |
| `models.RecentPlayerHistory` | [ModelsRecentPlayerHistory](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsRecentPlayerHistory.cs) |
| `models.RecentPlayerQueryResponse` | [ModelsRecentPlayerQueryResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsRecentPlayerQueryResponse.cs) |
| `models.Server` | [ModelsServer](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsServer.cs) |
| `models.SessionByUserIDsResponse` | [ModelsSessionByUserIDsResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionByUserIDsResponse.cs) |
| `models.SessionQueryResponse` | [ModelsSessionQueryResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionQueryResponse.cs) |
| `models.SessionResponse` | [ModelsSessionResponse](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsSessionResponse.cs) |
| `models.StatusHistory` | [ModelsStatusHistory](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsStatusHistory.cs) |
| `models.UpdateSessionRequest` | [ModelsUpdateSessionRequest](../AccelByte.Sdk/Api/Sessionbrowser/Model/ModelsUpdateSessionRequest.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Sessionbrowser/Model/ResponseError.cs) |
| `restapi.ErrorResponseV2` | [RestapiErrorResponseV2](../AccelByte.Sdk/Api/Sessionbrowser/Model/RestapiErrorResponseV2.cs) |
