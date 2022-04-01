# Matchmaking Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../AccelByte.Sdk/Api/Matchmaking/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../AccelByte.Sdk/Api/Matchmaking/Operation/Operations/GetHealthcheckInfo.cs) |
| `/matchmaking/healthz` | GET | HandlerV3Healthz | [HandlerV3Healthz](../AccelByte.Sdk/Api/Matchmaking/Operation/Operations/HandlerV3Healthz.cs) |
| `/matchmaking/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../AccelByte.Sdk/Api/Matchmaking/Operation/Operations/PublicGetMessages.cs) |
| `/matchmaking/version` | GET | VersionCheckHandler | [VersionCheckHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Operations/VersionCheckHandler.cs) |

### Matchmaking Wrapper:  [Matchmaking](../AccelByte.Sdk/Api/Matchmaking/Wrapper/Matchmaking.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/matchmaking/namespaces/{namespace}/channels` | GET | GetAllChannelsHandler | [GetAllChannelsHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllChannelsHandler.cs) |
| `/matchmaking/namespaces/{namespace}/channels` | POST | CreateChannelHandler | [CreateChannelHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/CreateChannelHandler.cs) |
| `/matchmaking/namespaces/{namespace}/channels/{channel}` | DELETE | DeleteChannelHandler | [DeleteChannelHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteChannelHandler.cs) |
| `/matchmaking/namespaces/{namespace}/matchresult` | POST | StoreMatchResults | [StoreMatchResults](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/StoreMatchResults.cs) |
| `/matchmaking/namespaces/{namespace}/sessions` | POST | QueueSessionHandler | [QueueSessionHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/QueueSessionHandler.cs) |
| `/matchmaking/namespaces/{namespace}/sessions/dequeue` | POST | DequeueSessionHandler | [DequeueSessionHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DequeueSessionHandler.cs) |
| `/matchmaking/namespaces/{namespace}/sessions/{matchID}/status` | GET | QuerySessionHandler | [QuerySessionHandler](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/QuerySessionHandler.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties` | GET | GetAllPartyInAllChannel | [GetAllPartyInAllChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInAllChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk` | GET | BulkGetSessions | [BulkGetSessions](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/BulkGetSessions.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/export` | GET | ExportChannels | [ExportChannels](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/ExportChannels.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/import` | POST | ImportChannels | [ImportChannels](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/ImportChannels.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | GET | GetSingleMatchmakingChannel | [GetSingleMatchmakingChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetSingleMatchmakingChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | PATCH | UpdateMatchmakingChannel | [UpdateMatchmakingChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/UpdateMatchmakingChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties` | GET | GetAllPartyInChannel | [GetAllPartyInChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions` | GET | GetAllSessionsInChannel | [GetAllSessionsInChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllSessionsInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | POST | AddUserIntoSessionInChannel | [AddUserIntoSessionInChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/AddUserIntoSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | DELETE | DeleteSessionInChannel | [DeleteSessionInChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}/users/{userID}` | DELETE | DeleteUserFromSessionInChannel | [DeleteUserFromSessionInChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteUserFromSessionInChannel.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessions | [SearchSessions](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/SearchSessions.cs) |
| `/matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed` | GET | GetSessionHistoryDetailed | [GetSessionHistoryDetailed](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetSessionHistoryDetailed.cs) |
| `/matchmaking/v1/public/namespaces/{namespace}/channels` | GET | PublicGetAllMatchmakingChannel | [PublicGetAllMatchmakingChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/PublicGetAllMatchmakingChannel.cs) |
| `/matchmaking/v1/public/namespaces/{namespace}/channels/{channelName}` | GET | PublicGetSingleMatchmakingChannel | [PublicGetSingleMatchmakingChannel](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/PublicGetSingleMatchmakingChannel.cs) |
| `/matchmaking/v2/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessionsV2 | [SearchSessionsV2](../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/SearchSessionsV2.cs) |

### Social Matchmaking Wrapper:  [SocialMatchmaking](../AccelByte.Sdk/Api/Matchmaking/Wrapper/SocialMatchmaking.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/matchmaking/social/playtime/namespaces/{namespace}/weight` | PATCH | UpdatePlayTimeWeight | [UpdatePlayTimeWeight](../AccelByte.Sdk/Api/Matchmaking/Operation/SocialMatchmaking/UpdatePlayTimeWeight.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../AccelByte.Sdk/Api/Matchmaking/Model/LogAppMessageDeclaration.cs) |
| `models.AllianceFlexingRule` | [ModelsAllianceFlexingRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceFlexingRule.cs) |
| `models.AllianceRule` | [ModelsAllianceRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceRule.cs) |
| `models.AllianceRuleV1` | [ModelsAllianceRuleV1](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceRuleV1.cs) |
| `models.Channel` | [ModelsChannel](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannel.cs) |
| `models.ChannelRequest` | [ModelsChannelRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannelRequest.cs) |
| `models.ChannelV1` | [ModelsChannelV1](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannelV1.cs) |
| `models.CreateChannelResponse` | [ModelsCreateChannelResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsCreateChannelResponse.cs) |
| `models.DequeueRequest` | [ModelsDequeueRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsDequeueRequest.cs) |
| `models.FlexingRule` | [ModelsFlexingRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsFlexingRule.cs) |
| `models.GetChannelsResponse` | [ModelsGetChannelsResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsGetChannelsResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsImportConfigResponse.cs) |
| `models.MatchAddUserIntoSessionRequest` | [ModelsMatchAddUserIntoSessionRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchAddUserIntoSessionRequest.cs) |
| `models.MatchOption` | [ModelsMatchOption](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchOption.cs) |
| `models.MatchOptionRule` | [ModelsMatchOptionRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchOptionRule.cs) |
| `models.MatchResultRequest` | [ModelsMatchResultRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchResultRequest.cs) |
| `models.MatchResultResponse` | [ModelsMatchResultResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchResultResponse.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingParty.cs) |
| `models.MatchingRule` | [ModelsMatchingRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingRule.cs) |
| `models.MatchmakingResult` | [ModelsMatchmakingResult](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchmakingResult.cs) |
| `models.Pagination` | [ModelsPagination](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPagination.cs) |
| `models.PartyMember` | [ModelsPartyMember](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPartyMember.cs) |
| `models.PlayerResultRequest` | [ModelsPlayerResultRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPlayerResultRequest.cs) |
| `models.PlayerResultResponse` | [ModelsPlayerResultResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPlayerResultResponse.cs) |
| `models.ResultAttributeRequest` | [ModelsResultAttributeRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsResultAttributeRequest.cs) |
| `models.ResultAttributeResponse` | [ModelsResultAttributeResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsResultAttributeResponse.cs) |
| `models.RuleSet` | [ModelsRuleSet](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRuleSet.cs) |
| `models.RuleSetV1` | [ModelsRuleSetV1](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRuleSetV1.cs) |
| `models.SubGameMode` | [ModelsSubGameMode](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsSubGameMode.cs) |
| `models.UpdateAllianceRule` | [ModelsUpdateAllianceRule](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateAllianceRule.cs) |
| `models.UpdateChannelRequest` | [ModelsUpdateChannelRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateChannelRequest.cs) |
| `models.UpdatePlayTimeWeightRequest` | [ModelsUpdatePlayTimeWeightRequest](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdatePlayTimeWeightRequest.cs) |
| `models.UpdatePlayerPlaytimeWeightResponse` | [ModelsUpdatePlayerPlaytimeWeightResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdatePlayerPlaytimeWeightResponse.cs) |
| `models.UpdateRuleset` | [ModelsUpdateRuleset](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateRuleset.cs) |
| `models.UpdateRuleset.sub_game_modes` | [ModelsUpdateRulesetSubGameModes](../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateRulesetSubGameModes.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Matchmaking/Model/ResponseError.cs) |
| `response.ErrorV1` | [ResponseErrorV1](../AccelByte.Sdk/Api/Matchmaking/Model/ResponseErrorV1.cs) |
| `service.GetSessionHistoryDetailedResponseItem` | [ServiceGetSessionHistoryDetailedResponseItem](../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistoryDetailedResponseItem.cs) |
| `service.GetSessionHistorySearchResponse` | [ServiceGetSessionHistorySearchResponse](../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponse.cs) |
| `service.GetSessionHistorySearchResponseItem` | [ServiceGetSessionHistorySearchResponseItem](../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseItem.cs) |
| `service.GetSessionHistorySearchResponseItemV2` | [ServiceGetSessionHistorySearchResponseItemV2](../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseItemV2.cs) |
| `service.GetSessionHistorySearchResponseV2` | [ServiceGetSessionHistorySearchResponseV2](../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseV2.cs) |
