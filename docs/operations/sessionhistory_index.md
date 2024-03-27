# Sessionhistory Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Sessionhistory/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/Operations/GetHealthcheckInfo.cs) |
| `/sessionhistory/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../AccelByte.Sdk/Api/Sessionhistory/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/Operations/GetHealthcheckInfoV1.cs) |

### Game Session Detail Wrapper:  [GameSessionDetail](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/GameSessionDetail.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/sessionhistory/v1/admin/namespaces/{namespace}/gamesessions` | GET | AdminQueryGameSessionDetail | [AdminQueryGameSessionDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminQueryGameSessionDetail.cs) | [AdminQueryGameSessionDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminQueryGameSessionDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}` | GET | GetGameSessionDetail | [GetGameSessionDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/GetGameSessionDetail.cs) | [GetGameSessionDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/GetGameSessionDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking` | GET | AdminQueryMatchmakingDetail | [AdminQueryMatchmakingDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminQueryMatchmakingDetail.cs) | [AdminQueryMatchmakingDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminQueryMatchmakingDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking/session/{sessionId}` | GET | AdminGetMatchmakingDetailBySessionID | [AdminGetMatchmakingDetailBySessionID](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminGetMatchmakingDetailBySessionID.cs) | [AdminGetMatchmakingDetailBySessionID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminGetMatchmakingDetailBySessionID.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/matchmaking/ticket/{ticketId}` | GET | AdminGetMatchmakingDetailByTicketID | [AdminGetMatchmakingDetailByTicketID](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminGetMatchmakingDetailByTicketID.cs) | [AdminGetMatchmakingDetailByTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminGetMatchmakingDetailByTicketID.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/parties` | GET | AdminQueryPartyDetail | [AdminQueryPartyDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminQueryPartyDetail.cs) | [AdminQueryPartyDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminQueryPartyDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/parties/{sessionId}` | GET | GetPartyDetail | [GetPartyDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/GetPartyDetail.cs) | [GetPartyDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/GetPartyDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/tickets` | GET | AdminQueryTicketDetail | [AdminQueryTicketDetail](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminQueryTicketDetail.cs) | [AdminQueryTicketDetail](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminQueryTicketDetail.cs) |
| `/sessionhistory/v1/admin/namespaces/{namespace}/tickets/{ticketId}` | GET | AdminTicketDetailGetByTicketID | [AdminTicketDetailGetByTicketID](../../AccelByte.Sdk/Api/Sessionhistory/Operation/GameSessionDetail/AdminTicketDetailGetByTicketID.cs) | [AdminTicketDetailGetByTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/GameSessionDetail/AdminTicketDetailGetByTicketID.cs) |

### XRay Wrapper:  [XRay](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/XRay.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}` | GET | QueryXrayMatchPool | [QueryXrayMatchPool](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryXrayMatchPool.cs) | [QueryXrayMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryXrayMatchPool.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}/pods/{podName}/ticks` | GET | QueryDetailTickMatchPool | [QueryDetailTickMatchPool](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryDetailTickMatchPool.cs) | [QueryDetailTickMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryDetailTickMatchPool.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}/pods/{podName}/ticks/{tickId}/matches` | GET | QueryDetailTickMatchPoolMatches | [QueryDetailTickMatchPoolMatches](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryDetailTickMatchPoolMatches.cs) | [QueryDetailTickMatchPoolMatches](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryDetailTickMatchPoolMatches.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/match-pools/{poolName}/pods/{podName}/ticks/{tickId}/tickets` | GET | QueryDetailTickMatchPoolTicket | [QueryDetailTickMatchPoolTicket](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryDetailTickMatchPoolTicket.cs) | [QueryDetailTickMatchPoolTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryDetailTickMatchPoolTicket.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/matches/{matchId}/histories` | GET | QueryMatchHistories | [QueryMatchHistories](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryMatchHistories.cs) | [QueryMatchHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryMatchHistories.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/matches/{matchId}/ticket-histories` | GET | QueryMatchTicketHistories | [QueryMatchTicketHistories](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryMatchTicketHistories.cs) | [QueryMatchTicketHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryMatchTicketHistories.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/matches/{matchId}/tickets` | GET | QueryXrayMatch | [QueryXrayMatch](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryXrayMatch.cs) | [QueryXrayMatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryXrayMatch.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/acquiring-ds` | GET | QueryAcquiringDS | [QueryAcquiringDS](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryAcquiringDS.cs) | [QueryAcquiringDS](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryAcquiringDS.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/acquiring-ds-wait-time-avg` | GET | QueryAcquiringDSWaitTimeAvg | [QueryAcquiringDSWaitTimeAvg](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryAcquiringDSWaitTimeAvg.cs) | [QueryAcquiringDSWaitTimeAvg](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryAcquiringDSWaitTimeAvg.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/match-length-duration-avg` | GET | QueryMatchLengthDurationpAvg | [QueryMatchLengthDurationpAvg](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryMatchLengthDurationpAvg.cs) | [QueryMatchLengthDurationpAvg](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryMatchLengthDurationpAvg.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/match-length-duration-p99` | GET | QueryMatchLengthDurationp99 | [QueryMatchLengthDurationp99](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryMatchLengthDurationp99.cs) | [QueryMatchLengthDurationp99](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryMatchLengthDurationp99.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-active-session` | GET | QueryTotalActiveSession | [QueryTotalActiveSession](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalActiveSession.cs) | [QueryTotalActiveSession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalActiveSession.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-match` | GET | QueryTotalMatchmakingMatch | [QueryTotalMatchmakingMatch](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalMatchmakingMatch.cs) | [QueryTotalMatchmakingMatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalMatchmakingMatch.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-player-persession-avg` | GET | QueryTotalPlayerPersession | [QueryTotalPlayerPersession](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalPlayerPersession.cs) | [QueryTotalPlayerPersession](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalPlayerPersession.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-canceled` | GET | QueryTotalMatchmakingCanceled | [QueryTotalMatchmakingCanceled](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalMatchmakingCanceled.cs) | [QueryTotalMatchmakingCanceled](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalMatchmakingCanceled.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-created` | GET | QueryTotalMatchmakingCreated | [QueryTotalMatchmakingCreated](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalMatchmakingCreated.cs) | [QueryTotalMatchmakingCreated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalMatchmakingCreated.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-expired` | GET | QueryTotalMatchmakingExpired | [QueryTotalMatchmakingExpired](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalMatchmakingExpired.cs) | [QueryTotalMatchmakingExpired](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalMatchmakingExpired.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/metrics/total-ticket-match` | GET | QueryTotalMatchmakingMatchTicket | [QueryTotalMatchmakingMatchTicket](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryTotalMatchmakingMatchTicket.cs) | [QueryTotalMatchmakingMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryTotalMatchmakingMatchTicket.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/tickets/{ticketId}` | GET | QueryXrayTimelineByTicketID | [QueryXrayTimelineByTicketID](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryXrayTimelineByTicketID.cs) | [QueryXrayTimelineByTicketID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryXrayTimelineByTicketID.cs) |
| `/sessionhistory/v2/admin/namespaces/{namespace}/xray/users/{userId}/tickets` | GET | QueryXrayTimelineByUserID | [QueryXrayTimelineByUserID](../../AccelByte.Sdk/Api/Sessionhistory/Operation/XRay/QueryXrayTimelineByUserID.cs) | [QueryXrayTimelineByUserID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Sessionhistory/XRay/QueryXrayTimelineByUserID.cs) |


&nbsp;  

## Operations with Generic Response

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Game Session Detail Wrapper:  [GameSessionDetail](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/GameSessionDetail.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### XRay Wrapper:  [XRay](../../AccelByte.Sdk/Api/Sessionhistory/Wrapper/XRay.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodels.AcquiringDS` | [ApimodelsAcquiringDS](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsAcquiringDS.cs) |
| `apimodels.AcquiringDsWaitTime` | [ApimodelsAcquiringDsWaitTime](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsAcquiringDsWaitTime.cs) |
| `apimodels.CanceledMatchmakingTicket` | [ApimodelsCanceledMatchmakingTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsCanceledMatchmakingTicket.cs) |
| `apimodels.CreatedMatchmakingTicket` | [ApimodelsCreatedMatchmakingTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsCreatedMatchmakingTicket.cs) |
| `apimodels.EventMatchHistory` | [ApimodelsEventMatchHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsEventMatchHistory.cs) |
| `apimodels.ExpiredMatchmakingTicket` | [ApimodelsExpiredMatchmakingTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsExpiredMatchmakingTicket.cs) |
| `apimodels.GameSessionDetail` | [ApimodelsGameSessionDetail](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsGameSessionDetail.cs) |
| `apimodels.GameSessionDetailQueryResponse` | [ApimodelsGameSessionDetailQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsGameSessionDetailQueryResponse.cs) |
| `apimodels.History` | [ApimodelsHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsHistory.cs) |
| `apimodels.MatchLengthDuration` | [ApimodelsMatchLengthDuration](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchLengthDuration.cs) |
| `apimodels.MatchMatchmaking` | [ApimodelsMatchMatchmaking](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchMatchmaking.cs) |
| `apimodels.MatchMatchmakingTicket` | [ApimodelsMatchMatchmakingTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchMatchmakingTicket.cs) |
| `apimodels.MatchmakingDetail` | [ApimodelsMatchmakingDetail](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchmakingDetail.cs) |
| `apimodels.MatchmakingDetailQueryResponse` | [ApimodelsMatchmakingDetailQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchmakingDetailQueryResponse.cs) |
| `apimodels.MatchmakingHistory` | [ApimodelsMatchmakingHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsMatchmakingHistory.cs) |
| `apimodels.Pagination` | [ApimodelsPagination](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsPagination.cs) |
| `apimodels.PartyDetail` | [ApimodelsPartyDetail](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsPartyDetail.cs) |
| `apimodels.PartyDetailQueryResponse` | [ApimodelsPartyDetailQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsPartyDetailQueryResponse.cs) |
| `apimodels.PartyHistory` | [ApimodelsPartyHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsPartyHistory.cs) |
| `apimodels.TicketDetailQueryResponse` | [ApimodelsTicketDetailQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsTicketDetailQueryResponse.cs) |
| `apimodels.TicketObservabilityDetail` | [ApimodelsTicketObservabilityDetail](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsTicketObservabilityDetail.cs) |
| `apimodels.TicketObservabilityHistory` | [ApimodelsTicketObservabilityHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsTicketObservabilityHistory.cs) |
| `apimodels.TotalActiveSession` | [ApimodelsTotalActiveSession](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsTotalActiveSession.cs) |
| `apimodels.TotalPlayerPersession` | [ApimodelsTotalPlayerPersession](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsTotalPlayerPersession.cs) |
| `apimodels.XRayAcquiringDsQueryResponse` | [ApimodelsXRayAcquiringDsQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayAcquiringDsQueryResponse.cs) |
| `apimodels.XRayAcquiringDsWaitTimeQueryResponse` | [ApimodelsXRayAcquiringDsWaitTimeQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayAcquiringDsWaitTimeQueryResponse.cs) |
| `apimodels.XRayCanceledMatchmakingTicketQueryResponse` | [ApimodelsXRayCanceledMatchmakingTicketQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayCanceledMatchmakingTicketQueryResponse.cs) |
| `apimodels.XRayCreatedMatchmakingTicketQueryResponse` | [ApimodelsXRayCreatedMatchmakingTicketQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayCreatedMatchmakingTicketQueryResponse.cs) |
| `apimodels.XRayExpiredMatchmakingTicketQueryResponse` | [ApimodelsXRayExpiredMatchmakingTicketQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayExpiredMatchmakingTicketQueryResponse.cs) |
| `apimodels.XRayMatchHistorQueryResponse` | [ApimodelsXRayMatchHistorQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchHistorQueryResponse.cs) |
| `apimodels.XRayMatchLengthDurationQueryResponse` | [ApimodelsXRayMatchLengthDurationQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchLengthDurationQueryResponse.cs) |
| `apimodels.XRayMatchMatchmakingQueryResponse` | [ApimodelsXRayMatchMatchmakingQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchMatchmakingQueryResponse.cs) |
| `apimodels.XRayMatchMatchmakingTicketQueryResponse` | [ApimodelsXRayMatchMatchmakingTicketQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchMatchmakingTicketQueryResponse.cs) |
| `apimodels.XRayMatchPoolPodTickMatchResponse` | [ApimodelsXRayMatchPoolPodTickMatchResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolPodTickMatchResponse.cs) |
| `apimodels.XRayMatchPoolPodTickQueryResponse` | [ApimodelsXRayMatchPoolPodTickQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolPodTickQueryResponse.cs) |
| `apimodels.XRayMatchPoolPodTickResult` | [ApimodelsXRayMatchPoolPodTickResult](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolPodTickResult.cs) |
| `apimodels.XRayMatchPoolPodTickTicketResponse` | [ApimodelsXRayMatchPoolPodTickTicketResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolPodTickTicketResponse.cs) |
| `apimodels.XRayMatchPoolQueryResponse` | [ApimodelsXRayMatchPoolQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolQueryResponse.cs) |
| `apimodels.XRayMatchPoolResult` | [ApimodelsXRayMatchPoolResult](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchPoolResult.cs) |
| `apimodels.XRayMatchTicketHistory` | [ApimodelsXRayMatchTicketHistory](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchTicketHistory.cs) |
| `apimodels.XRayMatchTicketHistoryQueryResponse` | [ApimodelsXRayMatchTicketHistoryQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchTicketHistoryQueryResponse.cs) |
| `apimodels.XRayMatchesQueryResponse` | [ApimodelsXRayMatchesQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayMatchesQueryResponse.cs) |
| `apimodels.XRayTicketMatchesResult` | [ApimodelsXRayTicketMatchesResult](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayTicketMatchesResult.cs) |
| `apimodels.XRayTicketQueryResponse` | [ApimodelsXRayTicketQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayTicketQueryResponse.cs) |
| `apimodels.XRayTicketResult` | [ApimodelsXRayTicketResult](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayTicketResult.cs) |
| `apimodels.XRayTotalActiveSessionQueryResponse` | [ApimodelsXRayTotalActiveSessionQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayTotalActiveSessionQueryResponse.cs) |
| `apimodels.XRayTotalPlayerPersessionAVGQueryResponse` | [ApimodelsXRayTotalPlayerPersessionAVGQueryResponse](../../AccelByte.Sdk/Api/Sessionhistory/Model/ApimodelsXRayTotalPlayerPersessionAVGQueryResponse.cs) |
| `models.AllianceRule` | [ModelsAllianceRule](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsAllianceRule.cs) |
| `models.BackfillProposal` | [ModelsBackfillProposal](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsBackfillProposal.cs) |
| `models.BackfillTicket` | [ModelsBackfillTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsBackfillTicket.cs) |
| `models.DSInformation` | [ModelsDSInformation](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsDSInformation.cs) |
| `models.GameServer` | [ModelsGameServer](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsGameServer.cs) |
| `models.GameSession` | [ModelsGameSession](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsGameSession.cs) |
| `models.GameSessionTeam` | [ModelsGameSessionTeam](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsGameSessionTeam.cs) |
| `models.Match` | [ModelsMatch](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsMatch.cs) |
| `models.MatchingAlly` | [ModelsMatchingAlly](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsMatchingAlly.cs) |
| `models.MatchingParty` | [ModelsMatchingParty](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsMatchingParty.cs) |
| `models.MatchingRule` | [ModelsMatchingRule](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsMatchingRule.cs) |
| `models.MatchmakingResult` | [ModelsMatchmakingResult](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsMatchmakingResult.cs) |
| `models.Party` | [ModelsParty](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsParty.cs) |
| `models.PartyMember` | [ModelsPartyMember](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsPartyMember.cs) |
| `models.PartyMembers` | [ModelsPartyMembers](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsPartyMembers.cs) |
| `models.PartyTeam` | [ModelsPartyTeam](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsPartyTeam.cs) |
| `models.PlayerData` | [ModelsPlayerData](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsPlayerData.cs) |
| `models.ProposedProposal` | [ModelsProposedProposal](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsProposedProposal.cs) |
| `models.SessionConfig` | [ModelsSessionConfig](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsSessionConfig.cs) |
| `models.SessionConfiguration` | [ModelsSessionConfiguration](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsSessionConfiguration.cs) |
| `models.Team` | [ModelsTeam](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsTeam.cs) |
| `models.Ticket` | [ModelsTicket](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsTicket.cs) |
| `models.TicketData` | [ModelsTicketData](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsTicketData.cs) |
| `models.TicketObservability` | [ModelsTicketObservability](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsTicketObservability.cs) |
| `models.TicketStatus` | [ModelsTicketStatus](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsTicketStatus.cs) |
| `models.User` | [ModelsUser](../../AccelByte.Sdk/Api/Sessionhistory/Model/ModelsUser.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Sessionhistory/Model/ResponseError.cs) |
