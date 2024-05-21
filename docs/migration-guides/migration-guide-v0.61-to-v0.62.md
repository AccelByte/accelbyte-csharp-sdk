<a name="v0.62.0"></a>
## [v0.62.0] - 2024-05-21

### BREAKING CHANGE

### Group

All operation(s) under `AccelByte.Sdk/Api/Group/Operation/Operations` have been removed.

### Leaderboard

- Model `AccelByte.Sdk.Api.Leaderboard.Model.V2Pagination` is renamed to `V2PaginationV2`
- Model `AccelByte.Sdk.Api.Leaderboard.Model.V2GetAllLeaderboardConfigsPublicResp`
    - field `Paging` type changed from `V2Pagination?` to `V2PaginationV2?`
- Model `AccelByte.Sdk.Api.Leaderboard.Model.V2GetPublicLeaderboardRankingResponse`
    - field `Paging` type changed from `V2Pagination?` to `V2PaginationV2?`

[v0.62.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.61.0...v0.62.0