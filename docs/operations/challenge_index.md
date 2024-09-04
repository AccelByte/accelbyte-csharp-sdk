# Challenge Service Index

&nbsp;  

## Operations

### Challenge Configuration Wrapper:  [ChallengeConfiguration](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/admin/namespaces/{namespace}/challenges` | GET | AdminGetChallenges | [AdminGetChallenges](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminGetChallenges.cs) | [AdminGetChallenges](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminGetChallenges.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges` | POST | AdminCreateChallenge | [AdminCreateChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminCreateChallenge.cs) | [AdminCreateChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminCreateChallenge.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}` | GET | AdminGetChallenge | [AdminGetChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminGetChallenge.cs) | [AdminGetChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminGetChallenge.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}` | PUT | AdminUpdateChallenge | [AdminUpdateChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminUpdateChallenge.cs) | [AdminUpdateChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminUpdateChallenge.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}` | DELETE | AdminDeleteChallenge | [AdminDeleteChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminDeleteChallenge.cs) | [AdminDeleteChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminDeleteChallenge.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/periods` | GET | AdminGetPeriods | [AdminGetPeriods](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminGetPeriods.cs) | [AdminGetPeriods](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminGetPeriods.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/randomize` | POST | AdminRandomizeChallenge | [AdminRandomizeChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminRandomizeChallenge.cs) | [AdminRandomizeChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminRandomizeChallenge.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/tied` | DELETE | AdminDeleteTiedChallenge | [AdminDeleteTiedChallenge](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminDeleteTiedChallenge.cs) | [AdminDeleteTiedChallenge](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeConfiguration/AdminDeleteTiedChallenge.cs) |

### Goal Configuration Wrapper:  [GoalConfiguration](../../AccelByte.Sdk/Api/Challenge/Wrapper/GoalConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals` | GET | AdminGetGoals | [AdminGetGoals](../../AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminGetGoals.cs) | [AdminGetGoals](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/GoalConfiguration/AdminGetGoals.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals` | POST | AdminCreateGoal | [AdminCreateGoal](../../AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminCreateGoal.cs) | [AdminCreateGoal](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/GoalConfiguration/AdminCreateGoal.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals/{code}` | GET | AdminGetGoal | [AdminGetGoal](../../AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminGetGoal.cs) | [AdminGetGoal](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/GoalConfiguration/AdminGetGoal.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals/{code}` | PUT | AdminUpdateGoals | [AdminUpdateGoals](../../AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminUpdateGoals.cs) | [AdminUpdateGoals](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/GoalConfiguration/AdminUpdateGoals.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/goals/{code}` | DELETE | AdminDeleteGoal | [AdminDeleteGoal](../../AccelByte.Sdk/Api/Challenge/Operation/GoalConfiguration/AdminDeleteGoal.cs) | [AdminDeleteGoal](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/GoalConfiguration/AdminDeleteGoal.cs) |

### Plugins Wrapper:  [Plugins](../../AccelByte.Sdk/Api/Challenge/Wrapper/Plugins.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/admin/namespaces/{namespace}/plugins/assignment` | GET | AdminGetAssignmentPlugin | [AdminGetAssignmentPlugin](../../AccelByte.Sdk/Api/Challenge/Operation/Plugins/AdminGetAssignmentPlugin.cs) | [AdminGetAssignmentPlugin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/Plugins/AdminGetAssignmentPlugin.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/plugins/assignment` | PUT | AdminUpdateAssignmentPlugin | [AdminUpdateAssignmentPlugin](../../AccelByte.Sdk/Api/Challenge/Operation/Plugins/AdminUpdateAssignmentPlugin.cs) | [AdminUpdateAssignmentPlugin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/Plugins/AdminUpdateAssignmentPlugin.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/plugins/assignment` | POST | AdminCreateAssignmentPlugin | [AdminCreateAssignmentPlugin](../../AccelByte.Sdk/Api/Challenge/Operation/Plugins/AdminCreateAssignmentPlugin.cs) | [AdminCreateAssignmentPlugin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/Plugins/AdminCreateAssignmentPlugin.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/plugins/assignment` | DELETE | AdminDeleteAssignmentPlugin | [AdminDeleteAssignmentPlugin](../../AccelByte.Sdk/Api/Challenge/Operation/Plugins/AdminDeleteAssignmentPlugin.cs) | [AdminDeleteAssignmentPlugin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/Plugins/AdminDeleteAssignmentPlugin.cs) |

### Challenge Progression Wrapper:  [ChallengeProgression](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeProgression.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/admin/namespaces/{namespace}/progress/evaluate` | POST | AdminEvaluateProgress | [AdminEvaluateProgress](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/AdminEvaluateProgress.cs) | [AdminEvaluateProgress](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeProgression/AdminEvaluateProgress.cs) |
| `/challenge/v1/public/namespaces/{namespace}/users/me/progress/evaluate` | POST | EvaluateMyProgress | [EvaluateMyProgress](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/EvaluateMyProgress.cs) | [EvaluateMyProgress](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeProgression/EvaluateMyProgress.cs) |
| `/challenge/v1/public/namespaces/{namespace}/users/me/progress/{challengeCode}` | GET | PublicGetUserProgression | [PublicGetUserProgression](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/PublicGetUserProgression.cs) | [PublicGetUserProgression](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeProgression/PublicGetUserProgression.cs) |
| `/challenge/v1/public/namespaces/{namespace}/users/me/progress/{challengeCode}/index/{index}` | GET | PublicGetPastUserProgression | [PublicGetPastUserProgression](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeProgression/PublicGetPastUserProgression.cs) | [PublicGetPastUserProgression](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeProgression/PublicGetPastUserProgression.cs) |

### Player Reward Wrapper:  [PlayerReward](../../AccelByte.Sdk/Api/Challenge/Wrapper/PlayerReward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/admin/namespaces/{namespace}/users/rewards/claim` | POST | AdminClaimUsersRewards | [AdminClaimUsersRewards](../../AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/AdminClaimUsersRewards.cs) | [AdminClaimUsersRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/PlayerReward/AdminClaimUsersRewards.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/users/{userId}/rewards` | GET | AdminGetUserRewards | [AdminGetUserRewards](../../AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/AdminGetUserRewards.cs) | [AdminGetUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/PlayerReward/AdminGetUserRewards.cs) |
| `/challenge/v1/admin/namespaces/{namespace}/users/{userId}/rewards/claim` | POST | AdminClaimUserRewards | [AdminClaimUserRewards](../../AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/AdminClaimUserRewards.cs) | [AdminClaimUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/PlayerReward/AdminClaimUserRewards.cs) |
| `/challenge/v1/public/namespaces/{namespace}/users/me/rewards` | GET | PublicGetUserRewards | [PublicGetUserRewards](../../AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/PublicGetUserRewards.cs) | [PublicGetUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/PlayerReward/PublicGetUserRewards.cs) |
| `/challenge/v1/public/namespaces/{namespace}/users/me/rewards/claim` | POST | PublicClaimUserRewards | [PublicClaimUserRewards](../../AccelByte.Sdk/Api/Challenge/Operation/PlayerReward/PublicClaimUserRewards.cs) | [PublicClaimUserRewards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/PlayerReward/PublicClaimUserRewards.cs) |

### Challenge List Wrapper:  [ChallengeList](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeList.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/challenge/v1/public/namespaces/{namespace}/challenges` | GET | GetChallenges | [GetChallenges](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeList/GetChallenges.cs) | [GetChallenges](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeList/GetChallenges.cs) |
| `/challenge/v1/public/namespaces/{namespace}/challenges/{challengeCode}/goals` | GET | PublicGetScheduledGoals | [PublicGetScheduledGoals](../../AccelByte.Sdk/Api/Challenge/Operation/ChallengeList/PublicGetScheduledGoals.cs) | [PublicGetScheduledGoals](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Challenge/ChallengeList/PublicGetScheduledGoals.cs) |


&nbsp;  

## Operations with Generic Response

### Challenge Configuration Wrapper:  [ChallengeConfiguration](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Goal Configuration Wrapper:  [GoalConfiguration](../../AccelByte.Sdk/Api/Challenge/Wrapper/GoalConfiguration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Plugins Wrapper:  [Plugins](../../AccelByte.Sdk/Api/Challenge/Wrapper/Plugins.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Challenge Progression Wrapper:  [ChallengeProgression](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeProgression.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Player Reward Wrapper:  [PlayerReward](../../AccelByte.Sdk/Api/Challenge/Wrapper/PlayerReward.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Challenge List Wrapper:  [ChallengeList](../../AccelByte.Sdk/Api/Challenge/Wrapper/ChallengeList.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `iam.ErrorResponse` | [IamErrorResponse](../../AccelByte.Sdk/Api/Challenge/Model/IamErrorResponse.cs) |
| `iam.Permission` | [IamPermission](../../AccelByte.Sdk/Api/Challenge/Model/IamPermission.cs) |
| `model.ChallengeResponse` | [ModelChallengeResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelChallengeResponse.cs) |
| `model.ClaimUserRewardsReq` | [ModelClaimUserRewardsReq](../../AccelByte.Sdk/Api/Challenge/Model/ModelClaimUserRewardsReq.cs) |
| `model.ClaimUsersRewardsRequest` | [ModelClaimUsersRewardsRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelClaimUsersRewardsRequest.cs) |
| `model.ClaimUsersRewardsResponse` | [ModelClaimUsersRewardsResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelClaimUsersRewardsResponse.cs) |
| `model.CreateChallengeRequest` | [ModelCreateChallengeRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelCreateChallengeRequest.cs) |
| `model.CreateGoalRequest` | [ModelCreateGoalRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelCreateGoalRequest.cs) |
| `model.EvaluatePlayerProgressionRequest` | [ModelEvaluatePlayerProgressionRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelEvaluatePlayerProgressionRequest.cs) |
| `model.GetGoalsResponse` | [ModelGetGoalsResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelGetGoalsResponse.cs) |
| `model.GoalMeta` | [ModelGoalMeta](../../AccelByte.Sdk/Api/Challenge/Model/ModelGoalMeta.cs) |
| `model.GoalOrder` | [ModelGoalOrder](../../AccelByte.Sdk/Api/Challenge/Model/ModelGoalOrder.cs) |
| `model.GoalProgressionResponse` | [ModelGoalProgressionResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelGoalProgressionResponse.cs) |
| `model.GoalResponse` | [ModelGoalResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelGoalResponse.cs) |
| `model.GoalSchedule` | [ModelGoalSchedule](../../AccelByte.Sdk/Api/Challenge/Model/ModelGoalSchedule.cs) |
| `model.ListChallengeResponse` | [ModelListChallengeResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelListChallengeResponse.cs) |
| `model.ListPeriodsResponse` | [ModelListPeriodsResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelListPeriodsResponse.cs) |
| `model.ListUserRewardsResponse` | [ModelListUserRewardsResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelListUserRewardsResponse.cs) |
| `model.Pagination` | [ModelPagination](../../AccelByte.Sdk/Api/Challenge/Model/ModelPagination.cs) |
| `model.PluginAsignmentAppConfig` | [ModelPluginAsignmentAppConfig](../../AccelByte.Sdk/Api/Challenge/Model/ModelPluginAsignmentAppConfig.cs) |
| `model.PluginAssignmentCustomConfig` | [ModelPluginAssignmentCustomConfig](../../AccelByte.Sdk/Api/Challenge/Model/ModelPluginAssignmentCustomConfig.cs) |
| `model.PluginAssignmentRequest` | [ModelPluginAssignmentRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelPluginAssignmentRequest.cs) |
| `model.PluginAssignmentResponse` | [ModelPluginAssignmentResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelPluginAssignmentResponse.cs) |
| `model.Predicate` | [ModelPredicate](../../AccelByte.Sdk/Api/Challenge/Model/ModelPredicate.cs) |
| `model.Requirement` | [ModelRequirement](../../AccelByte.Sdk/Api/Challenge/Model/ModelRequirement.cs) |
| `model.RequirementProgressionResponse` | [ModelRequirementProgressionResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelRequirementProgressionResponse.cs) |
| `model.ResetConfig` | [ModelResetConfig](../../AccelByte.Sdk/Api/Challenge/Model/ModelResetConfig.cs) |
| `model.Reward` | [ModelReward](../../AccelByte.Sdk/Api/Challenge/Model/ModelReward.cs) |
| `model.Schedule` | [ModelSchedule](../../AccelByte.Sdk/Api/Challenge/Model/ModelSchedule.cs) |
| `model.UpdateChallengeRequest` | [ModelUpdateChallengeRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelUpdateChallengeRequest.cs) |
| `model.UpdateGoalRequest` | [ModelUpdateGoalRequest](../../AccelByte.Sdk/Api/Challenge/Model/ModelUpdateGoalRequest.cs) |
| `model.UserProgressionPeriodResponseMeta` | [ModelUserProgressionPeriodResponseMeta](../../AccelByte.Sdk/Api/Challenge/Model/ModelUserProgressionPeriodResponseMeta.cs) |
| `model.UserProgressionResponse` | [ModelUserProgressionResponse](../../AccelByte.Sdk/Api/Challenge/Model/ModelUserProgressionResponse.cs) |
| `model.UserProgressionResponseMeta` | [ModelUserProgressionResponseMeta](../../AccelByte.Sdk/Api/Challenge/Model/ModelUserProgressionResponseMeta.cs) |
| `model.UserReward` | [ModelUserReward](../../AccelByte.Sdk/Api/Challenge/Model/ModelUserReward.cs) |
| `models.Period` | [ModelsPeriod](../../AccelByte.Sdk/Api/Challenge/Model/ModelsPeriod.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Challenge/Model/ResponseError.cs) |
