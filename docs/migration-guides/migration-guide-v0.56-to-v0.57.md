<a name="v0.57.0"></a>
## [v0.57.0] - 2024-03-26

### BREAKING CHANGE

### Challenge
- Operation `AccelByte.Sdk.Api.Challenge.Operation.PublicGetScheduledGoals`
    - response changed from `List<Model.ModelGoalResponse>?` to `ModelGetGoalsResponse?`

### Matchmaking
- Model `AccelByte.Sdk.Api.Matchmaking.Model.ModelsSortTicket`
    - field `SearchResult` type changed from `string?` to `ModelsSortTicketSearchResult?`
    - field `TicketQueue` type changed from `string?` to `ModelsSortTicketSearchResult?`
- Model `AccelByte.Sdk.Api.Matchmaking.Model.ModelsSortTicketRule`
    - field `SearchResult` type changed from `string?` to `ModelsSortTicketRuleSearchResult?`
    - field `TicketQueue` type changed from `string?` to `ModelsSortTicketRuleTicketQueue?`
- Model `AccelByte.Sdk.Api.Matchmaking.Model.ModelsUpdateRuleset`
    - field `TicketFlexingSelection ` type changed from `string?` to `ModelsUpdateRulesetTicketFlexingSelection`

[v0.57.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.56.0...v0.57.0