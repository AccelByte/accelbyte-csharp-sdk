# Match2 Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Match2/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Match2/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfo.cs) |
| `/match2/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../AccelByte.Sdk/Api/Match2/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfoV1.cs) |
| `/match2/version` | GET | VersionCheckHandler | [VersionCheckHandler](../../AccelByte.Sdk/Api/Match2/Operation/Operations/VersionCheckHandler.cs) | [VersionCheckHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/VersionCheckHandler.cs) |

### Config Wrapper:  [Config](../../AccelByte.Sdk/Api/Match2/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/admin/config/log` | GET | AdminGetLogConfig | [AdminGetLogConfig](../../AccelByte.Sdk/Api/Match2/Operation/Config/AdminGetLogConfig.cs) | [AdminGetLogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Config/AdminGetLogConfig.cs) |
| `/match2/v1/admin/config/log` | PATCH | AdminPatchUpdateLogConfig | [AdminPatchUpdateLogConfig](../../AccelByte.Sdk/Api/Match2/Operation/Config/AdminPatchUpdateLogConfig.cs) | [AdminPatchUpdateLogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Config/AdminPatchUpdateLogConfig.cs) |
| `/match2/v1/config` | GET | AdminGetAllConfigV1 | [AdminGetAllConfigV1](../../AccelByte.Sdk/Api/Match2/Operation/Config/AdminGetAllConfigV1.cs) | [AdminGetAllConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Config/AdminGetAllConfigV1.cs) |
| `/match2/v1/config/namespaces/{namespace}` | GET | AdminGetConfigV1 | [AdminGetConfigV1](../../AccelByte.Sdk/Api/Match2/Operation/Config/AdminGetConfigV1.cs) | [AdminGetConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Config/AdminGetConfigV1.cs) |
| `/match2/v1/config/namespaces/{namespace}` | PATCH | AdminPatchConfigV1 | [AdminPatchConfigV1](../../AccelByte.Sdk/Api/Match2/Operation/Config/AdminPatchConfigV1.cs) | [AdminPatchConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Config/AdminPatchConfigV1.cs) |

### PlayFeatureFlag Wrapper:  [PlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Wrapper/PlayFeatureFlag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/admin/namespaces/{namespace}/playfeatureflag` | GET | AdminGetPlayFeatureFlag | [AdminGetPlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Operation/PlayFeatureFlag/AdminGetPlayFeatureFlag.cs) | [AdminGetPlayFeatureFlag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/PlayFeatureFlag/AdminGetPlayFeatureFlag.cs) |
| `/match2/v1/admin/namespaces/{namespace}/playfeatureflag` | POST | AdminUpsertPlayFeatureFlag | [AdminUpsertPlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Operation/PlayFeatureFlag/AdminUpsertPlayFeatureFlag.cs) | [AdminUpsertPlayFeatureFlag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/PlayFeatureFlag/AdminUpsertPlayFeatureFlag.cs) |
| `/match2/v1/admin/namespaces/{namespace}/playfeatureflag` | DELETE | AdminDeletePlayFeatureFlag | [AdminDeletePlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Operation/PlayFeatureFlag/AdminDeletePlayFeatureFlag.cs) | [AdminDeletePlayFeatureFlag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/PlayFeatureFlag/AdminDeletePlayFeatureFlag.cs) |

### Environment-Variables Wrapper:  [EnvironmentVariables](../../AccelByte.Sdk/Api/Match2/Wrapper/EnvironmentVariables.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/environment-variables` | GET | EnvironmentVariableList | [EnvironmentVariableList](../../AccelByte.Sdk/Api/Match2/Operation/EnvironmentVariables/EnvironmentVariableList.cs) | [EnvironmentVariableList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/EnvironmentVariables/EnvironmentVariableList.cs) |

### Backfill Wrapper:  [Backfill](../../AccelByte.Sdk/Api/Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/backfill` | GET | AdminQueryBackfill | [AdminQueryBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/AdminQueryBackfill.cs) | [AdminQueryBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/AdminQueryBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill` | POST | CreateBackfill | [CreateBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/CreateBackfill.cs) | [CreateBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/CreateBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/proposal` | GET | GetBackfillProposal | [GetBackfillProposal](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/GetBackfillProposal.cs) | [GetBackfillProposal](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/GetBackfillProposal.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}` | GET | GetBackfill | [GetBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/GetBackfill.cs) | [GetBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/GetBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}` | DELETE | DeleteBackfill | [DeleteBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/DeleteBackfill.cs) | [DeleteBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/DeleteBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/accept` | PUT | AcceptBackfill | [AcceptBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/AcceptBackfill.cs) | [AcceptBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/AcceptBackfill.cs) |
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/reject` | PUT | RejectBackfill | [RejectBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/RejectBackfill.cs) | [RejectBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/RejectBackfill.cs) |

### Match-Functions Wrapper:  [MatchFunctions](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchFunctions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-functions` | GET | MatchFunctionList | [MatchFunctionList](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/MatchFunctionList.cs) | [MatchFunctionList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/MatchFunctionList.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions` | POST | CreateMatchFunction | [CreateMatchFunction](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/CreateMatchFunction.cs) | [CreateMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/CreateMatchFunction.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | GET | MatchFunctionGet | [MatchFunctionGet](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/MatchFunctionGet.cs) | [MatchFunctionGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/MatchFunctionGet.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | PUT | UpdateMatchFunction | [UpdateMatchFunction](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/UpdateMatchFunction.cs) | [UpdateMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/UpdateMatchFunction.cs) |
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | DELETE | DeleteMatchFunction | [DeleteMatchFunction](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/DeleteMatchFunction.cs) | [DeleteMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/DeleteMatchFunction.cs) |

### Match-Pools Wrapper:  [MatchPools](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchPools.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-pools` | GET | MatchPoolList | [MatchPoolList](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/MatchPoolList.cs) | [MatchPoolList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolList.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools` | POST | CreateMatchPool | [CreateMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/CreateMatchPool.cs) | [CreateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/CreateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | GET | MatchPoolDetails | [MatchPoolDetails](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/MatchPoolDetails.cs) | [MatchPoolDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolDetails.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | PUT | UpdateMatchPool | [UpdateMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/UpdateMatchPool.cs) | [UpdateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/UpdateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | DELETE | DeleteMatchPool | [DeleteMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/DeleteMatchPool.cs) | [DeleteMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/DeleteMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics` | GET | MatchPoolMetric | [MatchPoolMetric](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/MatchPoolMetric.cs) | [MatchPoolMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolMetric.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics/external-failure` | POST | PostMatchErrorMetric | [PostMatchErrorMetric](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/PostMatchErrorMetric.cs) | [PostMatchErrorMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/PostMatchErrorMetric.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics/player` | GET | GetPlayerMetric | [GetPlayerMetric](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/GetPlayerMetric.cs) | [GetPlayerMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/GetPlayerMetric.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}/tickets` | GET | AdminGetMatchPoolTickets | [AdminGetMatchPoolTickets](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/AdminGetMatchPoolTickets.cs) | [AdminGetMatchPoolTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/AdminGetMatchPoolTickets.cs) |
| `/match2/v1/public/namespaces/{namespace}/match-pools/{pool}/metrics/player` | GET | PublicGetPlayerMetric | [PublicGetPlayerMetric](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/PublicGetPlayerMetric.cs) | [PublicGetPlayerMetric](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/PublicGetPlayerMetric.cs) |

### Match-Tickets Wrapper:  [MatchTickets](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-tickets` | POST | CreateMatchTicket | [CreateMatchTicket](../../AccelByte.Sdk/Api/Match2/Operation/MatchTickets/CreateMatchTicket.cs) | [CreateMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/CreateMatchTicket.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/me` | GET | GetMyMatchTickets | [GetMyMatchTickets](../../AccelByte.Sdk/Api/Match2/Operation/MatchTickets/GetMyMatchTickets.cs) | [GetMyMatchTickets](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/GetMyMatchTickets.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}` | GET | MatchTicketDetails | [MatchTicketDetails](../../AccelByte.Sdk/Api/Match2/Operation/MatchTickets/MatchTicketDetails.cs) | [MatchTicketDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/MatchTicketDetails.cs) |
| `/match2/v1/namespaces/{namespace}/match-tickets/{ticketid}` | DELETE | DeleteMatchTicket | [DeleteMatchTicket](../../AccelByte.Sdk/Api/Match2/Operation/MatchTickets/DeleteMatchTicket.cs) | [DeleteMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/DeleteMatchTicket.cs) |

### Rule-Sets Wrapper:  [RuleSets](../../AccelByte.Sdk/Api/Match2/Wrapper/RuleSets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/rulesets` | GET | RuleSetList | [RuleSetList](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/RuleSetList.cs) | [RuleSetList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetList.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets` | POST | CreateRuleSet | [CreateRuleSet](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/CreateRuleSet.cs) | [CreateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/CreateRuleSet.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | GET | RuleSetDetails | [RuleSetDetails](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/RuleSetDetails.cs) | [RuleSetDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetDetails.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | PUT | UpdateRuleSet | [UpdateRuleSet](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/UpdateRuleSet.cs) | [UpdateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/UpdateRuleSet.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | DELETE | DeleteRuleSet | [DeleteRuleSet](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/DeleteRuleSet.cs) | [DeleteRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/DeleteRuleSet.cs) |


&nbsp;  

## Operations with Generic Response

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Match2/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Config Wrapper:  [Config](../../AccelByte.Sdk/Api/Match2/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### PlayFeatureFlag Wrapper:  [PlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Wrapper/PlayFeatureFlag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Environment-Variables Wrapper:  [EnvironmentVariables](../../AccelByte.Sdk/Api/Match2/Wrapper/EnvironmentVariables.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Backfill Wrapper:  [Backfill](../../AccelByte.Sdk/Api/Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/accept` | PUT | AcceptBackfill | [AcceptBackfill](../../AccelByte.Sdk/Api/Match2/Operation/Backfill/AcceptBackfill.cs) | [AcceptBackfill](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Backfill/AcceptBackfill.cs) |

### Match-Functions Wrapper:  [MatchFunctions](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchFunctions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Match-Pools Wrapper:  [MatchPools](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchPools.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Match-Tickets Wrapper:  [MatchTickets](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Rule-Sets Wrapper:  [RuleSets](../../AccelByte.Sdk/Api/Match2/Wrapper/RuleSets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | GET | RuleSetDetails | [RuleSetDetails](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/RuleSetDetails.cs) | [RuleSetDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/RuleSetDetails.cs) |
| `/match2/v1/namespaces/{namespace}/rulesets/{ruleset}` | PUT | UpdateRuleSet | [UpdateRuleSet](../../AccelByte.Sdk/Api/Match2/Operation/RuleSets/UpdateRuleSet.cs) | [UpdateRuleSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/RuleSets/UpdateRuleSet.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `api.BackFillAcceptRequest` | [ApiBackFillAcceptRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiBackFillAcceptRequest.cs) |
| `api.BackFillCreateRequest` | [ApiBackFillCreateRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiBackFillCreateRequest.cs) |
| `api.BackfillCreateResponse` | [ApiBackfillCreateResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiBackfillCreateResponse.cs) |
| `api.BackfillGetResponse` | [ApiBackfillGetResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiBackfillGetResponse.cs) |
| `api.BackfillProposalResponse` | [ApiBackfillProposalResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiBackfillProposalResponse.cs) |
| `api.ExternalFailureMetricRecord` | [ApiExternalFailureMetricRecord](../../AccelByte.Sdk/Api/Match2/Model/ApiExternalFailureMetricRecord.cs) |
| `api.ListBackfillQueryResponse` | [ApiListBackfillQueryResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListBackfillQueryResponse.cs) |
| `api.ListEnvironmentVariablesResponse` | [ApiListEnvironmentVariablesResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListEnvironmentVariablesResponse.cs) |
| `api.ListMatchFunctionsResponse` | [ApiListMatchFunctionsResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListMatchFunctionsResponse.cs) |
| `api.ListMatchPoolTicketsResponse` | [ApiListMatchPoolTicketsResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListMatchPoolTicketsResponse.cs) |
| `api.ListMatchPoolsResponse` | [ApiListMatchPoolsResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListMatchPoolsResponse.cs) |
| `api.ListRuleSetsResponse` | [ApiListRuleSetsResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListRuleSetsResponse.cs) |
| `api.Match` | [ApiMatch](../../AccelByte.Sdk/Api/Match2/Model/ApiMatch.cs) |
| `api.MatchFunctionConfig` | [ApiMatchFunctionConfig](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchFunctionConfig.cs) |
| `api.MatchFunctionOverride` | [ApiMatchFunctionOverride](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchFunctionOverride.cs) |
| `api.MatchFunctionRequest` | [ApiMatchFunctionRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchFunctionRequest.cs) |
| `api.MatchPool` | [ApiMatchPool](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchPool.cs) |
| `api.MatchPoolConfig` | [ApiMatchPoolConfig](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchPoolConfig.cs) |
| `api.MatchRuleSetNameData` | [ApiMatchRuleSetNameData](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchRuleSetNameData.cs) |
| `api.MatchTicketRequest` | [ApiMatchTicketRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchTicketRequest.cs) |
| `api.MatchTicketResponse` | [ApiMatchTicketResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchTicketResponse.cs) |
| `api.MatchTicketStatus` | [ApiMatchTicketStatus](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchTicketStatus.cs) |
| `api.MatchTicketStatuses` | [ApiMatchTicketStatuses](../../AccelByte.Sdk/Api/Match2/Model/ApiMatchTicketStatuses.cs) |
| `api.NamespaceConfigList` | [ApiNamespaceConfigList](../../AccelByte.Sdk/Api/Match2/Model/ApiNamespaceConfigList.cs) |
| `api.Party` | [ApiParty](../../AccelByte.Sdk/Api/Match2/Model/ApiParty.cs) |
| `api.PatchNamespaceConfigRequest` | [ApiPatchNamespaceConfigRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiPatchNamespaceConfigRequest.cs) |
| `api.PlayerData` | [ApiPlayerData](../../AccelByte.Sdk/Api/Match2/Model/ApiPlayerData.cs) |
| `api.PlayerMetricRecord` | [ApiPlayerMetricRecord](../../AccelByte.Sdk/Api/Match2/Model/ApiPlayerMetricRecord.cs) |
| `api.ProposedProposal` | [ApiProposedProposal](../../AccelByte.Sdk/Api/Match2/Model/ApiProposedProposal.cs) |
| `api.RuleSetPayload` | [ApiRuleSetPayload](../../AccelByte.Sdk/Api/Match2/Model/ApiRuleSetPayload.cs) |
| `api.Team` | [ApiTeam](../../AccelByte.Sdk/Api/Match2/Model/ApiTeam.cs) |
| `api.Ticket` | [ApiTicket](../../AccelByte.Sdk/Api/Match2/Model/ApiTicket.cs) |
| `api.TicketMetricResultRecord` | [ApiTicketMetricResultRecord](../../AccelByte.Sdk/Api/Match2/Model/ApiTicketMetricResultRecord.cs) |
| `api.backFillRejectRequest` | [ApiBackFillRejectRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiBackFillRejectRequest.cs) |
| `config.EnvironmentVariable` | [ConfigEnvironmentVariable](../../AccelByte.Sdk/Api/Match2/Model/ConfigEnvironmentVariable.cs) |
| `configmodels.NamespaceConfig` | [ConfigmodelsNamespaceConfig](../../AccelByte.Sdk/Api/Match2/Model/ConfigmodelsNamespaceConfig.cs) |
| `logconfig.Configuration` | [LogconfigConfiguration](../../AccelByte.Sdk/Api/Match2/Model/LogconfigConfiguration.cs) |
| `matchmaker.MatchTicketRecord` | [MatchmakerMatchTicketRecord](../../AccelByte.Sdk/Api/Match2/Model/MatchmakerMatchTicketRecord.cs) |
| `matchmaker.Party` | [MatchmakerParty](../../AccelByte.Sdk/Api/Match2/Model/MatchmakerParty.cs) |
| `matchmaker.ProposedProposal` | [MatchmakerProposedProposal](../../AccelByte.Sdk/Api/Match2/Model/MatchmakerProposedProposal.cs) |
| `matchmaker.Team` | [MatchmakerTeam](../../AccelByte.Sdk/Api/Match2/Model/MatchmakerTeam.cs) |
| `matchmaker.Ticket` | [MatchmakerTicket](../../AccelByte.Sdk/Api/Match2/Model/MatchmakerTicket.cs) |
| `models.Configuration` | [ModelsConfiguration](../../AccelByte.Sdk/Api/Match2/Model/ModelsConfiguration.cs) |
| `models.DSInformation` | [ModelsDSInformation](../../AccelByte.Sdk/Api/Match2/Model/ModelsDSInformation.cs) |
| `models.GameSession` | [ModelsGameSession](../../AccelByte.Sdk/Api/Match2/Model/ModelsGameSession.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Match2/Model/ModelsPagination.cs) |
| `models.PlayFeatureFlag` | [ModelsPlayFeatureFlag](../../AccelByte.Sdk/Api/Match2/Model/ModelsPlayFeatureFlag.cs) |
| `models.Server` | [ModelsServer](../../AccelByte.Sdk/Api/Match2/Model/ModelsServer.cs) |
| `models.User` | [ModelsUser](../../AccelByte.Sdk/Api/Match2/Model/ModelsUser.cs) |
| `player.PlayerData` | [PlayerPlayerData](../../AccelByte.Sdk/Api/Match2/Model/PlayerPlayerData.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Match2/Model/ResponseError.cs) |
