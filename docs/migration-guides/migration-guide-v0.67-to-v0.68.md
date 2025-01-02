<a name="v0.68.0"></a>
## [v0.68.0] - 2025-01-02

### BREAKING CHANGE

### Challenge

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminGetChallenges`
    - `SortBy` param type changed from `string?` to `AdminGetChallengesSortBy?`.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeList/GetChallenges`
    - `SortBy` param type changed from `string?` to `GetChallengesSortBy?`.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminGetGoals`
    - `SortBy` param type changed from `string?` to `AdminGetGoalsSortBy?`.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/AdminGetUserRewards`
    - `SortBy` param type changed from `string?` to `AdminGetUserRewardsSortBy?`.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/PublicGetUserRewards`
    - `SortBy` param type changed from `string?` to `PublicGetUserRewardsSortBy?`.

### IAM

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Iam/Operation/LoginAllowlist/AdminUpdateLoginAllowlistV3`
    - response type changed from `ModelLoginAllowlistResponse?` to `void`.

[v0.68.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.67.0...v0.68.0