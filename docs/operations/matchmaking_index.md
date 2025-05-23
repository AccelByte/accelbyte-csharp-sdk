# Matchmaking Service Index

&nbsp;  

## Operations

### Matchmaking Operations Wrapper:  [MatchmakingOperations](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/MatchmakingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Matchmaking/Operation/MatchmakingOperations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/GetHealthcheckInfo.cs) |
| `/matchmaking/healthz` | GET | HandlerV3Healthz | [HandlerV3Healthz](../../AccelByte.Sdk/Api/Matchmaking/Operation/MatchmakingOperations/HandlerV3Healthz.cs) | [HandlerV3Healthz](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/HandlerV3Healthz.cs) |
| [DEPRECATED] `/matchmaking/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Matchmaking/Operation/MatchmakingOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/PublicGetMessages.cs) |
| `/matchmaking/version` | GET | VersionCheckHandler | [VersionCheckHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/MatchmakingOperations/VersionCheckHandler.cs) | [VersionCheckHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MatchmakingOperations/VersionCheckHandler.cs) |

### Matchmaking Wrapper:  [Matchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/Matchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/channels` | GET | GetAllChannelsHandler | [GetAllChannelsHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllChannelsHandler.cs) | [GetAllChannelsHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllChannelsHandler.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/channels` | POST | CreateChannelHandler | [CreateChannelHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/CreateChannelHandler.cs) | [CreateChannelHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/CreateChannelHandler.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/channels/{channelName}/metrics` | GET | GetMatchPoolMetric | [GetMatchPoolMetric](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetMatchPoolMetric.cs) | [GetMatchPoolMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetMatchPoolMetric.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/channels/{channel}` | DELETE | DeleteChannelHandler | [DeleteChannelHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteChannelHandler.cs) | [DeleteChannelHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteChannelHandler.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/matchresult` | POST | StoreMatchResults | [StoreMatchResults](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/StoreMatchResults.cs) | [StoreMatchResults](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/StoreMatchResults.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/rebalance` | POST | Rebalance | [Rebalance](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/Rebalance.cs) | [Rebalance](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/Rebalance.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/sessions` | POST | QueueSessionHandler | [QueueSessionHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/QueueSessionHandler.cs) | [QueueSessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QueueSessionHandler.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/sessions/dequeue` | POST | DequeueSessionHandler | [DequeueSessionHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DequeueSessionHandler.cs) | [DequeueSessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DequeueSessionHandler.cs) |
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/sessions/{matchID}/status` | GET | QuerySessionHandler | [QuerySessionHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/QuerySessionHandler.cs) | [QuerySessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QuerySessionHandler.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties` | GET | GetAllPartyInAllChannel | [GetAllPartyInAllChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInAllChannel.cs) | [GetAllPartyInAllChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInAllChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk` | GET | BulkGetSessions | [BulkGetSessions](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/BulkGetSessions.cs) | [BulkGetSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/BulkGetSessions.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/export` | GET | ExportChannels | [ExportChannels](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/ExportChannels.cs) | [ExportChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/ExportChannels.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/import` | POST | ImportChannels | [ImportChannels](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/ImportChannels.cs) | [ImportChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/ImportChannels.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | GET | GetSingleMatchmakingChannel | [GetSingleMatchmakingChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetSingleMatchmakingChannel.cs) | [GetSingleMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetSingleMatchmakingChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}` | PATCH | UpdateMatchmakingChannel | [UpdateMatchmakingChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/UpdateMatchmakingChannel.cs) | [UpdateMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/UpdateMatchmakingChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties` | GET | GetAllPartyInChannel | [GetAllPartyInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInChannel.cs) | [GetAllPartyInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions` | GET | GetAllSessionsInChannel | [GetAllSessionsInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllSessionsInChannel.cs) | [GetAllSessionsInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllSessionsInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | POST | AddUserIntoSessionInChannel | [AddUserIntoSessionInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/AddUserIntoSessionInChannel.cs) | [AddUserIntoSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/AddUserIntoSessionInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}` | DELETE | DeleteSessionInChannel | [DeleteSessionInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteSessionInChannel.cs) | [DeleteSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteSessionInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}/users/{userID}` | DELETE | DeleteUserFromSessionInChannel | [DeleteUserFromSessionInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/DeleteUserFromSessionInChannel.cs) | [DeleteUserFromSessionInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/DeleteUserFromSessionInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/stats` | GET | GetStatData | [GetStatData](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetStatData.cs) | [GetStatData](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetStatData.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessions | [SearchSessions](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/SearchSessions.cs) | [SearchSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/SearchSessions.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed` | GET | GetSessionHistoryDetailed | [GetSessionHistoryDetailed](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetSessionHistoryDetailed.cs) | [GetSessionHistoryDetailed](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetSessionHistoryDetailed.cs) |
| [DEPRECATED] `/matchmaking/v1/public/namespaces/{namespace}/channels` | GET | PublicGetAllMatchmakingChannel | [PublicGetAllMatchmakingChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/PublicGetAllMatchmakingChannel.cs) | [PublicGetAllMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/PublicGetAllMatchmakingChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/public/namespaces/{namespace}/channels/{channelName}` | GET | PublicGetSingleMatchmakingChannel | [PublicGetSingleMatchmakingChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/PublicGetSingleMatchmakingChannel.cs) | [PublicGetSingleMatchmakingChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/PublicGetSingleMatchmakingChannel.cs) |
| [DEPRECATED] `/matchmaking/v2/admin/namespaces/{namespace}/sessions/history/search` | GET | SearchSessionsV2 | [SearchSessionsV2](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/SearchSessionsV2.cs) | [SearchSessionsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/SearchSessionsV2.cs) |

### Social Matchmaking Wrapper:  [SocialMatchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/SocialMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/matchmaking/social/playtime/namespaces/{namespace}/weight` | PATCH | UpdatePlayTimeWeight | [UpdatePlayTimeWeight](../../AccelByte.Sdk/Api/Matchmaking/Operation/SocialMatchmaking/UpdatePlayTimeWeight.cs) | [UpdatePlayTimeWeight](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/SocialMatchmaking/UpdatePlayTimeWeight.cs) |

### Mock Matchmaking Wrapper:  [MockMatchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/MockMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks` | DELETE | CleanAllMocks | [CleanAllMocks](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/CleanAllMocks.cs) | [CleanAllMocks](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CleanAllMocks.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/matches` | GET | GetAllMockMatches | [GetAllMockMatches](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/GetAllMockMatches.cs) | [GetAllMockMatches](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetAllMockMatches.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/matches` | POST | GetMockMatchesByTimestamp | [GetMockMatchesByTimestamp](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/GetMockMatchesByTimestamp.cs) | [GetMockMatchesByTimestamp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetMockMatchesByTimestamp.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | GET | GetAllMockTickets | [GetAllMockTickets](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/GetAllMockTickets.cs) | [GetAllMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetAllMockTickets.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | POST | CreateMockTickets | [CreateMockTickets](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/CreateMockTickets.cs) | [CreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CreateMockTickets.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/bulk` | POST | BulkCreateMockTickets | [BulkCreateMockTickets](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/BulkCreateMockTickets.cs) | [BulkCreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/BulkCreateMockTickets.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/query` | POST | GetMockTicketsByTimestamp | [GetMockTicketsByTimestamp](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/GetMockTicketsByTimestamp.cs) | [GetMockTicketsByTimestamp](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/GetMockTicketsByTimestamp.cs) |


&nbsp;  

## Operations with Generic Response

### Matchmaking Operations Wrapper:  [MatchmakingOperations](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/MatchmakingOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Matchmaking Wrapper:  [Matchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/Matchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/matchmaking/namespaces/{namespace}/sessions/{matchID}/status` | GET | QuerySessionHandler | [QuerySessionHandler](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/QuerySessionHandler.cs) | [QuerySessionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/QuerySessionHandler.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/parties` | GET | GetAllPartyInAllChannel | [GetAllPartyInAllChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInAllChannel.cs) | [GetAllPartyInAllChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInAllChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/all/sessions/bulk` | GET | BulkGetSessions | [BulkGetSessions](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/BulkGetSessions.cs) | [BulkGetSessions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/BulkGetSessions.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/parties` | GET | GetAllPartyInChannel | [GetAllPartyInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllPartyInChannel.cs) | [GetAllPartyInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllPartyInChannel.cs) |
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions` | GET | GetAllSessionsInChannel | [GetAllSessionsInChannel](../../AccelByte.Sdk/Api/Matchmaking/Operation/Matchmaking/GetAllSessionsInChannel.cs) | [GetAllSessionsInChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/Matchmaking/GetAllSessionsInChannel.cs) |

### Social Matchmaking Wrapper:  [SocialMatchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/SocialMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Mock Matchmaking Wrapper:  [MockMatchmaking](../../AccelByte.Sdk/Api/Matchmaking/Wrapper/MockMatchmaking.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets` | POST | CreateMockTickets | [CreateMockTickets](../../AccelByte.Sdk/Api/Matchmaking/Operation/MockMatchmaking/CreateMockTickets.cs) | [CreateMockTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Matchmaking/MockMatchmaking/CreateMockTickets.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Matchmaking/Model/LogAppMessageDeclaration.cs) |
| `models.AllianceFlexingRule` | [ModelsAllianceFlexingRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceFlexingRule.cs) |
| `models.AllianceRule` | [ModelsAllianceRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceRule.cs) |
| `models.AllianceRuleV1` | [ModelsAllianceRuleV1](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsAllianceRuleV1.cs) |
| `models.BucketMMRRule` | [ModelsBucketMMRRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsBucketMMRRule.cs) |
| `models.Channel` | [ModelsChannel](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannel.cs) |
| `models.ChannelRequest` | [ModelsChannelRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannelRequest.cs) |
| `models.ChannelV1` | [ModelsChannelV1](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsChannelV1.cs) |
| `models.Combination` | [ModelsCombination](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsCombination.cs) |
| `models.CreateChannelResponse` | [ModelsCreateChannelResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsCreateChannelResponse.cs) |
| `models.CreateMockTicket` | [ModelsCreateMockTicket](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsCreateMockTicket.cs) |
| `models.DequeueRequest` | [ModelsDequeueRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsDequeueRequest.cs) |
| `models.FlexingRule` | [ModelsFlexingRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsFlexingRule.cs) |
| `models.GetChannelsResponse` | [ModelsGetChannelsResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsGetChannelsResponse.cs) |
| `models.GetMockMatchesResponse` | [ModelsGetMockMatchesResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsGetMockMatchesResponse.cs) |
| `models.GetMockTicketsResponse` | [ModelsGetMockTicketsResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsGetMockTicketsResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsImportConfigResponse.cs) |
| `models.MatchAddUserIntoSessionRequest` | [ModelsMatchAddUserIntoSessionRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchAddUserIntoSessionRequest.cs) |
| `models.MatchOption` | [ModelsMatchOption](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchOption.cs) |
| `models.MatchOptionRule` | [ModelsMatchOptionRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchOptionRule.cs) |
| `models.MatchResultRequest` | [ModelsMatchResultRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchResultRequest.cs) |
| `models.MatchResultResponse` | [ModelsMatchResultResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchResultResponse.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingParty.cs) |
| `models.MatchingRule` | [ModelsMatchingRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchingRule.cs) |
| `models.MatchmakingResult` | [ModelsMatchmakingResult](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMatchmakingResult.cs) |
| `models.MockMatch` | [ModelsMockMatch](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMockMatch.cs) |
| `models.MockTicket` | [ModelsMockTicket](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsMockTicket.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPagination.cs) |
| `models.PartyMember` | [ModelsPartyMember](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPartyMember.cs) |
| `models.PlayerResultRequest` | [ModelsPlayerResultRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPlayerResultRequest.cs) |
| `models.PlayerResultResponse` | [ModelsPlayerResultResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsPlayerResultResponse.cs) |
| `models.QueryMockBy` | [ModelsQueryMockBy](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsQueryMockBy.cs) |
| `models.RebalanceRequest` | [ModelsRebalanceRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRebalanceRequest.cs) |
| `models.RebalanceResponse` | [ModelsRebalanceResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRebalanceResponse.cs) |
| `models.Region` | [ModelsRegion](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRegion.cs) |
| `models.ResultAttributeRequest` | [ModelsResultAttributeRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsResultAttributeRequest.cs) |
| `models.ResultAttributeResponse` | [ModelsResultAttributeResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsResultAttributeResponse.cs) |
| `models.Role` | [ModelsRole](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRole.cs) |
| `models.RuleSet` | [ModelsRuleSet](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRuleSet.cs) |
| `models.RuleSetV1` | [ModelsRuleSetV1](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsRuleSetV1.cs) |
| `models.SelectionRule` | [ModelsSelectionRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsSelectionRule.cs) |
| `models.SortTicket` | [ModelsSortTicket](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsSortTicket.cs) |
| `models.SortTicketRule` | [ModelsSortTicketRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsSortTicketRule.cs) |
| `models.StatResumeResponse` | [ModelsStatResumeResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsStatResumeResponse.cs) |
| `models.SubGameMode` | [ModelsSubGameMode](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsSubGameMode.cs) |
| `models.TicketMetricResultRecord` | [ModelsTicketMetricResultRecord](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsTicketMetricResultRecord.cs) |
| `models.UpdateAllianceRule` | [ModelsUpdateAllianceRule](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateAllianceRule.cs) |
| `models.UpdateChannelRequest` | [ModelsUpdateChannelRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateChannelRequest.cs) |
| `models.UpdatePlayTimeWeightRequest` | [ModelsUpdatePlayTimeWeightRequest](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdatePlayTimeWeightRequest.cs) |
| `models.UpdatePlayerPlaytimeWeightResponse` | [ModelsUpdatePlayerPlaytimeWeightResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdatePlayerPlaytimeWeightResponse.cs) |
| `models.UpdateRuleset` | [ModelsUpdateRuleset](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateRuleset.cs) |
| `models.UpdateRuleset.sub_game_modes` | [ModelsUpdateRulesetSubGameModes](../../AccelByte.Sdk/Api/Matchmaking/Model/ModelsUpdateRulesetSubGameModes.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Matchmaking/Model/ResponseError.cs) |
| `response.ErrorV1` | [ResponseErrorV1](../../AccelByte.Sdk/Api/Matchmaking/Model/ResponseErrorV1.cs) |
| `service.GetSessionHistoryDetailedResponseItem` | [ServiceGetSessionHistoryDetailedResponseItem](../../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistoryDetailedResponseItem.cs) |
| `service.GetSessionHistorySearchResponse` | [ServiceGetSessionHistorySearchResponse](../../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponse.cs) |
| `service.GetSessionHistorySearchResponseItem` | [ServiceGetSessionHistorySearchResponseItem](../../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseItem.cs) |
| `service.GetSessionHistorySearchResponseItemV2` | [ServiceGetSessionHistorySearchResponseItemV2](../../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseItemV2.cs) |
| `service.GetSessionHistorySearchResponseV2` | [ServiceGetSessionHistorySearchResponseV2](../../AccelByte.Sdk/Api/Matchmaking/Model/ServiceGetSessionHistorySearchResponseV2.cs) |
