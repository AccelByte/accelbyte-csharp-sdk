# Match2 Service Index

&nbsp;  

## Operations

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Match2/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/healthz` | GET | GetHealthcheckInfo | [GetHealthcheckInfo](../../AccelByte.Sdk/Api/Match2/Operation/Operations/GetHealthcheckInfo.cs) | [GetHealthcheckInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfo.cs) |
| `/match2/healthz` | GET | GetHealthcheckInfoV1 | [GetHealthcheckInfoV1](../../AccelByte.Sdk/Api/Match2/Operation/Operations/GetHealthcheckInfoV1.cs) | [GetHealthcheckInfoV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/GetHealthcheckInfoV1.cs) |
| `/match2/version` | GET | VersionCheckHandler | [VersionCheckHandler](../../AccelByte.Sdk/Api/Match2/Operation/Operations/VersionCheckHandler.cs) | [VersionCheckHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/Operations/VersionCheckHandler.cs) |

### Backfill Wrapper:  [Backfill](../../AccelByte.Sdk/Api/Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
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
| `/match2/v1/namespaces/{namespace}/match-functions/{name}` | DELETE | DeleteMatchFunction | [DeleteMatchFunction](../../AccelByte.Sdk/Api/Match2/Operation/MatchFunctions/DeleteMatchFunction.cs) | [DeleteMatchFunction](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchFunctions/DeleteMatchFunction.cs) |

### Match-Pools Wrapper:  [MatchPools](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchPools.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-pools` | GET | MatchPoolList | [MatchPoolList](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/MatchPoolList.cs) | [MatchPoolList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolList.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools` | POST | CreateMatchPool | [CreateMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/CreateMatchPool.cs) | [CreateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/CreateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | GET | MatchPoolDetails | [MatchPoolDetails](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/MatchPoolDetails.cs) | [MatchPoolDetails](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/MatchPoolDetails.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | PUT | UpdateMatchPool | [UpdateMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/UpdateMatchPool.cs) | [UpdateMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/UpdateMatchPool.cs) |
| `/match2/v1/namespaces/{namespace}/match-pools/{pool}` | DELETE | DeleteMatchPool | [DeleteMatchPool](../../AccelByte.Sdk/Api/Match2/Operation/MatchPools/DeleteMatchPool.cs) | [DeleteMatchPool](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchPools/DeleteMatchPool.cs) |

### Match-Tickets Wrapper:  [MatchTickets](../../AccelByte.Sdk/Api/Match2/Wrapper/MatchTickets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/match2/v1/namespaces/{namespace}/match-tickets` | POST | CreateMatchTicket | [CreateMatchTicket](../../AccelByte.Sdk/Api/Match2/Operation/MatchTickets/CreateMatchTicket.cs) | [CreateMatchTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Match2/MatchTickets/CreateMatchTicket.cs) |
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

### Backfill Wrapper:  [Backfill](../../AccelByte.Sdk/Api/Match2/Wrapper/Backfill.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

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
| `api.BackfillGetResponse` | [ApiBackfillGetResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiBackfillGetResponse.cs) |
| `api.BackfillProposalResponse` | [ApiBackfillProposalResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiBackfillProposalResponse.cs) |
| `api.ListMatchFunctionsResponse` | [ApiListMatchFunctionsResponse](../../AccelByte.Sdk/Api/Match2/Model/ApiListMatchFunctionsResponse.cs) |
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
| `api.Party` | [ApiParty](../../AccelByte.Sdk/Api/Match2/Model/ApiParty.cs) |
| `api.PlayerData` | [ApiPlayerData](../../AccelByte.Sdk/Api/Match2/Model/ApiPlayerData.cs) |
| `api.ProposedProposal` | [ApiProposedProposal](../../AccelByte.Sdk/Api/Match2/Model/ApiProposedProposal.cs) |
| `api.RuleSetPayload` | [ApiRuleSetPayload](../../AccelByte.Sdk/Api/Match2/Model/ApiRuleSetPayload.cs) |
| `api.Team` | [ApiTeam](../../AccelByte.Sdk/Api/Match2/Model/ApiTeam.cs) |
| `api.Ticket` | [ApiTicket](../../AccelByte.Sdk/Api/Match2/Model/ApiTicket.cs) |
| `api.backFillRejectRequest` | [ApiBackFillRejectRequest](../../AccelByte.Sdk/Api/Match2/Model/ApiBackFillRejectRequest.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Match2/Model/ModelsPagination.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Match2/Model/ResponseError.cs) |
