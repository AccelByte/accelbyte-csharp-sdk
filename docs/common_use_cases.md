# Common Use Cases

## Achievement

Source: [AchievementTests.cs](../AccelByte.Sdk.Tests/Services/AchievementTests.cs)

### Create an achievement

```csharp
ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
{
    AchievementCode = achievement_code,
    DefaultLanguage = "en",
    Name = new Dictionary<string, string>()
    {
        {"en", achievement_name }
    },
    Description = new Dictionary<string, string>
    {
        {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
    },
    GoalValue = 1000.0,
    StatCode = achievement_code,
    Hidden = true,
    Incremental = false,
    LockedIcons = new List<ModelsIcon>()
    {
        new ModelsIcon()
        {
            Slug = "shield-locked",
            Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/50000f325ef841a6972a005779e20991.png"
        }
    },
    UnlockedIcons = new List<ModelsIcon>()
    {
        new ModelsIcon()
        {
            Slug = "shield-unlocked",
            Url = "https://cdn.demo.accelbyte.io/files/accelbyte/achievements/fe89fd07102f4057be202fbd3fdd9a21.png"
        }
    },
    Tags = new List<string>() { "sdk", "test", "csharp" }
};

ModelsAchievementResponse? cResp = _Sdk.Achievement.Achievements.AdminCreateNewAchievementOp
    .Execute(newAchievement, _Sdk.Namespace);
```

### Updating achievement

```csharp
ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
{
    GoalValue = 2000.0,
    DefaultLanguage = "en",
    Name = new Dictionary<string, string>()
    {
        {"en", achievement_name }
    },
    Description = new Dictionary<string, string>
    {
        {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
    }
};

ModelsAchievementResponse? uResp = _Sdk.Achievement.Achievements.AdminUpdateAchievementOp
    .Execute(updateAchievement, achievement_code, _Sdk.Namespace);
```

### Retrieve achievement by code

```csharp
ModelsAchievementResponse? rResp = _Sdk.Achievement.Achievements.AdminGetAchievementOp
    .Execute(achievement_code, _Sdk.Namespace);
Assert.IsNotNull(rResp);
```

### Get all achievements

```csharp
ModelsPaginatedAchievementResponse? gaResp = _Sdk.Achievement.Achievements.AdminListAchievementsOp
    .SetLimit(100)
    .SetOffset(0)
    .Execute(_Sdk.Namespace);
```

### Delete an achievement

```csharp
_Sdk.Achievement.Achievements.AdminDeleteAchievementOp.Execute(achievement_code, _Sdk.Namespace);
```
## Basic

Source: [BasicTests.cs](../AccelByte.Sdk.Tests/Services/BasicTests.cs)

### Create user's own profile info

```csharp
UserProfilePrivateCreate createProfile = new UserProfilePrivateCreate()
{
    FirstName = "Integration Test",
    LastName = "CSharp Server SDK",
    DateOfBirth = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
    Language = "en"
};

UserProfilePrivateInfo? cInfo = _Sdk.Basic.UserProfile.CreateMyProfileOp
    .SetBody(createProfile)
    .Execute(_Sdk.Namespace);
```

### Get user's own profile info

```csharp
UserProfilePrivateInfo? ownResp = _Sdk.Basic.UserProfile.GetMyProfileInfoOp
    .Execute(_Sdk.Namespace);
```

### Update user's own profile info

```csharp
UserProfileUpdate updateProfile = new UserProfileUpdate()
{
    TimeZone = "Asia/Jakarta"
};

UserProfilePrivateInfo? updResp = _Sdk.Basic.UserProfile.UpdateMyProfileOp
    .SetBody(updateProfile)
    .Execute(_Sdk.Namespace);
```

### Delete user's own profile info

```csharp
UserProfilePrivateInfo? delResp = _Sdk.Basic.UserProfile.DeleteUserProfileOp
    .Execute(_Sdk.Namespace, userId);
```
## Challenge

Source: [ChallengeTests.cs](../AccelByte.Sdk.Tests/Services/ChallengeTests.cs)

### Create a new challenge

```csharp
var newChallenge = _Sdk.Challenge.ChallengeConfiguration.AdminCreateChallengeOp
    .Execute(new ModelCreateChallengeRequest()
    {
        Code = challengeCode,
        Description = "",
        Name = challengeName,
        AssignmentRule = ModelCreateChallengeRequestAssignmentRule.FIXED,
        GoalsVisibility = ModelCreateChallengeRequestGoalsVisibility.SHOWALL,
        Rotation = ModelCreateChallengeRequestRotation.DAILY,
        StartDate = DateTime.Now.AddDays(1)
    }, _Sdk.Namespace);
```

### Get challenge

```csharp
var challengeData = _Sdk.Challenge.ChallengeConfiguration.AdminGetChallengeOp
    .Execute(challengeCode, _Sdk.Namespace);
```

### Update a challenge

```csharp
var updatedChallenge = _Sdk.Challenge.ChallengeConfiguration.AdminUpdateChallengeOp
    .Execute(new ModelUpdateChallengeRequest()
    {
        Name = $"{challengeName} UPDATED"
    }, challengeCode, _Sdk.Namespace);
```

### Create a goal

```csharp
var newGoal = _Sdk.Challenge.GoalConfiguration.AdminCreateGoalOp
    .Execute(new ModelCreateGoalRequest()
    {
        Code = goalCode,
        Name = goalName,
        Description = "",
        Schedule = new ModelGoalScheduleRequest()
        {
            StartTime = DateTime.Now.AddDays(1),
            Order = 1
        },
        RequirementGroups = new List<ModelRequirement>()
        {
        new ModelRequirement()
        {
            Operator = ModelRequirementOperator.AND,
            Predicates = new List<ModelPredicate>()
            {
                new ModelPredicate()
                {
                    ParameterType = ModelPredicateParameterType.USERACCOUNT,
                    ParameterName = "userAccountVerified",
                    Matcher = ModelPredicateMatcher.EQUAL,
                    TargetValue = 1
                }
            }
        }
        }
    }, challengeCode, _Sdk.Namespace);
```

### Delete a goal

```csharp
_Sdk.Challenge.GoalConfiguration.AdminDeleteGoalOp
    .Execute(challengeCode, goalCode, _Sdk.Namespace);
```

### Delete a challenge

```csharp
_Sdk.Challenge.ChallengeConfiguration.AdminDeleteChallengeOp
    .Execute(challengeCode, _Sdk.Namespace);
```
## Chat

Source: [ChatTests.cs](../AccelByte.Sdk.Tests/Services/ChatTests.cs)

### Register a new profanity word

```csharp
var createResult = _Sdk.Chat.Profanity.AdminProfanityCreateOp
    .Execute(new ModelsDictionaryInsertRequest()
    {
        Word = profanityWord,
        WordType = "PROFANITY"
    }, _Sdk.Namespace);
```

### Query profanity word

```csharp
var queryResults = _Sdk.Chat.Profanity.AdminProfanityQueryOp
    .SetIncludeChildren(false)
    .SetWordType("PROFANITY")
    .SetStartWith(profanityWord)
    .Execute(_Sdk.Namespace);
```

### Update profanity word

```csharp
var updateResult = _Sdk.Chat.Profanity.AdminProfanityUpdateOp
    .Execute(new ModelsDictionaryUpdateRequest()
    {
        WordType = "PROFANITY",
        Word = editProfanityWord
    }, word.Id!, _Sdk.Namespace);
```

### Delete profanity word

```csharp
_Sdk.Chat.Profanity.AdminProfanityDeleteOp
    .Execute(word.Id!, _Sdk.Namespace);
```

### Add chat inbox category

```csharp
var insertResult = _Sdk.Chat.Inbox.AdminAddInboxCategoryOp
    .Execute(new ModelsAddInboxCategoryRequest()
    {
        ExpiresIn = 3600000000,
        Name = inboxName

    }, _Sdk.Namespace);
```

### Get chat inbox categories

```csharp
var getResult = _Sdk.Chat.Inbox.AdminGetInboxCategoriesOp
    .Execute(_Sdk.Namespace);
```

### Update chat inbox category

```csharp
_Sdk.Chat.Inbox.AdminUpdateInboxCategoryOp
    .Execute(new ModelsUpdateInboxCategoryRequest()
    {
        ExpiresIn = 1800000000
    }, inboxName, _Sdk.Namespace);
```

### Delete chat inbox category

```csharp
_Sdk.Chat.Inbox.AdminDeleteInboxCategoryOp
    .Execute(inboxName, _Sdk.Namespace);
```
## CloudSave

Source: [CloudSaveTests.cs](../AccelByte.Sdk.Tests/Services/CloudSaveTests.cs)

### Create new game record

```csharp
ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "foo",
    FooValue = 4893
};

_Sdk.Cloudsave.PublicGameRecord.PostGameRecordHandlerV1Op
    .Execute(gameRecord, "foo_bar_record", _Sdk.Namespace);
```

### Get game record

```csharp
ModelsGameRecordResponse? gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace);
```

### Update game record

```csharp
ModelsGameRecordRequestForTest updateRecord = new ModelsGameRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "update",
    FooValue = 4893
};

_Sdk.Cloudsave.PublicGameRecord.PutGameRecordHandlerV1Op
    .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace);
```

### Delete game record

```csharp
_Sdk.Cloudsave.PublicGameRecord.DeleteGameRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace);
```

### Create new player record

```csharp
ModelsPlayerRecordRequestForTest playerRecord = new ModelsPlayerRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "foo",
    FooValue = 4893
};

_Sdk.Cloudsave.PublicPlayerRecord.PostPlayerRecordHandlerV1Op
    .Execute(playerRecord, "foo_bar_record", _Sdk.Namespace, userId);
```

### Get player record

```csharp
ModelsPlayerRecordResponse? gRecord = _Sdk.Cloudsave.PublicPlayerRecord.GetPlayerRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace, userId);
```

### Update player record

```csharp
ModelsPlayerRecordRequestForTest updateRecord = new ModelsPlayerRecordRequestForTest()
{
    Foo = "bar",
    FooBar = "update",
    FooValue = 4893
};

_Sdk.Cloudsave.PublicPlayerRecord.PutPlayerRecordHandlerV1Op
    .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace, userId);
```

### Delete player record

```csharp
_Sdk.Cloudsave.PublicPlayerRecord.DeletePlayerRecordHandlerV1Op
    .Execute("foo_bar_record", _Sdk.Namespace, userId);
```
## CSM

Source: [CsmTests.cs](../AccelByte.Sdk.Tests/Services/CsmTests.cs)

### Create an Extend app

```csharp
var createdApp = _Sdk.Csm.AppV2.CreateAppV2Op
    .Execute(new ApimodelCreateAppV2Request()
    {
        Description = "C# Extend SDK integration test app.",
        Scenario = "function-override"
    }, appName, _Sdk.Namespace);
```

### Get an Extend app

```csharp
var app = _Sdk.Csm.AppV2.GetAppV2Op
    .Execute(appName, _Sdk.Namespace);
```

### Create new env secret entry

```csharp
var newSecret = _Sdk.Csm.ConfigurationV2.SaveSecretV2Op
    .Execute(new ApimodelSaveSecretConfigurationV2Request()
    {
        ConfigName = envSecretKey,
        Description = "",
        Value = envSecretValue,
        Source = "plaintext",
    }, appName, _Sdk.Namespace);
```

### Get list of env secrets

```csharp
var getSecrets = _Sdk.Csm.ConfigurationV2.GetListOfSecretsV2Op
    .SetOffset(0)
    .SetLimit(500)
    .Execute(appName, _Sdk.Namespace);
```

### Update env secret

```csharp
var updateSecret = _Sdk.Csm.ConfigurationV2.UpdateSecretV2Op
    .Execute(new ApimodelUpdateSecretConfigurationV2Request()
    {
        Value = envSecretValueNew
    }, appName, secretId, _Sdk.Namespace);
```

### Delete env secret

```csharp
_Sdk.Csm.ConfigurationV2.DeleteSecretV2Op
    .Execute(appName, secretId, _Sdk.Namespace);
```

### Create new env variable entry

```csharp
var newVariable = _Sdk.Csm.ConfigurationV2.SaveVariableV2Op
    .Execute(new ApimodelSaveConfigurationV2Request()
    {
        ConfigName = envVariableKey,
        Description = "",
        Value = envVariableValue,
        Source = "plaintext"
    }, appName, _Sdk.Namespace);
```

### Get list of env variables

```csharp
var getVariables = _Sdk.Csm.ConfigurationV2.GetListOfVariablesV2Op
    .SetOffset(0)
    .SetLimit(500)
    .Execute(appName, _Sdk.Namespace);
```

### Update env variable

```csharp
var updateVariable = _Sdk.Csm.ConfigurationV2.UpdateVariableV2Op
    .Execute(new ApimodelUpdateConfigurationV2Request()
    {
        Value = envVariableValueNew
    }, appName, variableId, _Sdk.Namespace);
```

### Delete env variable

```csharp
_Sdk.Csm.ConfigurationV2.DeleteVariableV2Op
    .Execute(appName, variableId, _Sdk.Namespace);
```

### Delete an Extend app

```csharp
_Sdk.Csm.AppV2.DeleteAppV2Op
    .SetForced("true")
    .Execute(appName, _Sdk.Namespace);
```
## GameTelemetry

Source: [GameTelemetryTests.cs](../AccelByte.Sdk.Tests/Services/GameTelemetryTests.cs)

### Save game telemetry event

```csharp
_Sdk.Gametelemetry.GametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
    .Execute(new List<TelemetryBody>
    {
        new TelemetryBody
        {
            EventName = "CsharpEvent",
            EventNamespace = "test",
            Payload = new Dictionary<string, object>
            {
                {"foo", "bar"}
            }
        }
    });
```
## GDPR

Source: [GdprTests.cs](../AccelByte.Sdk.Tests/Services/GdprTests.cs)

### Save e-mail configuration

```csharp
_Sdk.Gdpr.Configuration.SaveAdminEmailConfigurationOp
    .Execute(new List<string>
    {
        firstEmailToTest
    }, _Sdk.Namespace);
```

### Get e-mail configuration

```csharp
List<string>? emails = _Sdk.Gdpr.Configuration.GetAdminEmailConfigurationOp
    .Execute(_Sdk.Namespace);
```

### Update e-mail configuration

```csharp
_Sdk.Gdpr.Configuration.UpdateAdminEmailConfigurationOp
    .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace);
```

### Delete e-mail configuration

```csharp
_Sdk.Gdpr.Configuration.DeleteAdminEmailConfigurationOp
    .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest });
```
## Group

Source: [GroupTests.cs](../AccelByte.Sdk.Tests/Services/GroupTests.cs)

### Create group configuration

```csharp
ModelsCreateGroupConfigurationRequestV1 gcRequest = new ModelsCreateGroupConfigurationRequestV1()
{
    ConfigurationCode = configuration_code,
    Description = "CSharp SDK Test Configuration Group",
    GroupMaxMember = 50,
    Name = "CSharp SDK Test Configuration Group",
    GroupAdminRoleId = defaultAdminRoleId,
    GroupMemberRoleId = defaultMemberRoleId
};

ModelsCreateGroupConfigurationResponseV1? gcResp = _Sdk.Group.Configuration.CreateGroupConfigurationAdminV1Op
    .Execute(gcRequest, _Sdk.Namespace);
```

### Create a group

```csharp
ModelsPublicCreateNewGroupRequestV1 createGroup = new ModelsPublicCreateNewGroupRequestV1()
{
    GroupName = groupName,
    GroupType = "PUBLIC",
    GroupDescription = "Yeah, anyone is welcome here.",
    GroupMaxMember = 100,
    GroupRegion = "us",
    ConfigurationCode = configuration_code
};

ModelsGroupResponseV1? cGroup = _Sdk.Group.Group.CreateNewGroupPublicV1Op
    .Execute(createGroup, _Sdk.Namespace);
```

### Get single group

```csharp
ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
    .Execute(group_id, _Sdk.Namespace);
```

### Update a group

```csharp
ModelsUpdateGroupRequestV1 updateGroup = new ModelsUpdateGroupRequestV1()
{
    GroupDescription = "Updated description."
};

ModelsGroupResponseV1? uGroup = _Sdk.Group.Group.UpdateSingleGroupV1Op
    .Execute(updateGroup, group_id, _Sdk.Namespace);
```

### Delete a group

```csharp
_Sdk.Group.Group.DeleteGroupPublicV1Op
    .Execute(group_id, _Sdk.Namespace);
```

### Delete group configuration

```csharp
_Sdk.Group.Configuration.DeleteGroupConfigurationV1Op
    .Execute(configuration_code, _Sdk.Namespace);
```
## IAM

Source: [IAMTests.cs](../AccelByte.Sdk.Tests/Services/IAMTests.cs)

### Create a user (V3)

```csharp
AccountCreateUserRequestV4 newUser = new AccountCreateUserRequestV4()
{
    AuthType = "EMAILPASSWD",
    EmailAddress = user_email,
    Password = user_password,
    DisplayName = "CSharp Extend SDK Test",
    Username = user_name,
    Country = "ID",
    DateOfBirth = "1995-01-10",
    UniqueDisplayName = user_name
};

var response = _Sdk.Iam.UsersV4.AdminCreateUserV4Op
    .Execute(newUser, _Sdk.Namespace);
```

### Create a user

```csharp
AccountCreateTestUserRequestV4 newUser = new()
{
    Verified = true,
    AuthType = "EMAILPASSWD",
    EmailAddress = user_email,
    Password = user_password,
    DisplayName = "CSharp Extend SDK Test",
    Username = user_name,
    Country = "ID",
    DateOfBirth = "1995-01-10",
    UniqueDisplayName = user_name
};

AccountCreateUserResponseV4? cuResp = _Sdk.Iam.UsersV4.PublicCreateTestUserV4Op
    .Execute(newUser, _Sdk.Namespace);
```

### Get user data by user id

```csharp
ModelUserResponseV3? gUser = _Sdk.Iam.Users.AdminGetUserByUserIdV3Op
    .Execute(_Sdk.Namespace, user_id);
```

### Update a user

```csharp
ModelUserUpdateRequestV3 updateUser = new ModelUserUpdateRequestV3()
{
    DateOfBirth = "1996-01-10"
};

ModelUserResponseV3? uuResp = _Sdk.Iam.UsersV4.AdminUpdateUserV4Op
    .Execute(updateUser, _Sdk.Namespace, user_id);
```

### Delete a user

```csharp
_Sdk.Iam.Users.AdminDeleteUserInformationV3Op.Execute(_Sdk.Namespace, user_id);
```
## Inventory

Source: [InventoryTests.cs](../AccelByte.Sdk.Tests/Services/InventoryTests.cs)

### Create an inventory configuration

```csharp
ApimodelsCreateInventoryConfigurationReq cInventoryConfigBody = new ApimodelsCreateInventoryConfigurationReq()
{
    Code = codeInventory,
    Description = "testing",
    InitialMaxSlots = 3,
    MaxInstancesPerUser = 2,
    MaxUpgradeSlots = 5,
    Name = codeInventory
};

_ConfigInventory = _Sdk.Inventory.AdminInventoryConfigurations.AdminCreateInventoryConfigurationOp
    .Execute(cInventoryConfigBody, _Sdk.Namespace);
```

### Create an inventory

```csharp
string userId = _Sdk.Configuration.Credential!.UserId;
ApimodelsCreateInventoryReq cInventoryBody = new ApimodelsCreateInventoryReq()
{
    InventoryConfigurationCode = codeInventory,
    UserId = userId,
};

string inventoryId = "";
ApimodelsInventoryResp? cInventory = _Sdk.Inventory.AdminInventories.AdminCreateInventoryOp
    .Execute(cInventoryBody, _Sdk.Namespace);
```

### Get an inventory

```csharp
ApimodelsInventoryResp? gInventory = _Sdk.Inventory.AdminInventories.AdminGetInventoryOp
    .Execute(inventoryId, _Sdk.Namespace);
```

### Update an inventory

```csharp
var uInventoryBody = new ApimodelsUpdateInventoryReq()
{
    IncMaxSlots = 2,
};

ApimodelsInventoryResp? uInventory = _Sdk.Inventory.AdminInventories.AdminUpdateInventoryOp
    .Execute(uInventoryBody, inventoryId, _Sdk.Namespace);
```

### Delete an inventory

```csharp
var dInventoryBody = new ApimodelsDeleteInventoryReq()
{
    Message = "delete",
};
_Sdk.Inventory.AdminInventories.DeleteInventoryOp
    .Execute(dInventoryBody, inventoryId, _Sdk.Namespace);
```
## Leaderboard

Source: [LeaderboardTests.cs](../AccelByte.Sdk.Tests/Services/LeaderboardTests.cs)

### Create a leaderboard

```csharp
ModelsLeaderboardConfigReq newLeaderboard = new ModelsLeaderboardConfigReq()
{
    LeaderboardCode = leaderboard_code,
    Name = "CSharp SDK Leaderboard Test",
    StatCode = stat_code,
    SeasonPeriod = 36,
    Descending = false,
    StartTime = start_time,
    Daily = new ModelsDailyConfig()
    {
        ResetTime = "00:00:00"
    },
    Weekly = new ModelsWeeklyConfig()
    {
        ResetDay = 0,
        ResetTime = "00:00:00"
    },
    Monthly = new ModelsMonthlyConfig()
    {
        ResetDate = 1,
        ResetTime = "00:00:00"
    }
};

ModelsLeaderboardConfigReq? cLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.CreateLeaderboardConfigurationAdminV1Op
    .Execute(newLeaderboard, _Sdk.Namespace);
```

### Get a leaderboard

```csharp
ModelsGetLeaderboardConfigResp? gLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
    .Execute(leaderboard_code, _Sdk.Namespace);
```

### Update a leaderboard

```csharp
ModelsUpdateLeaderboardConfigReq updateLeaderboard = new ModelsUpdateLeaderboardConfigReq()
{
    Name = "CSharp SDK Leaderboard Test",
    StatCode = stat_code,
    StartTime = start_time,
    SeasonPeriod = 40
};

ModelsGetLeaderboardConfigResp? uLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.UpdateLeaderboardConfigurationAdminV1Op
    .Execute(updateLeaderboard, leaderboard_code, _Sdk.Namespace);
```

### Delete a leaderboard

```csharp
_Sdk.Leaderboard.LeaderboardConfiguration.DeleteLeaderboardConfigurationAdminV1Op
    .Execute(leaderboard_code, _Sdk.Namespace);
```
## Legal

Source: [LegalTests.cs](../AccelByte.Sdk.Tests/Services/LegalTests.cs)

### Get all legal policies

```csharp
List<RetrieveBasePolicyResponse>? bPolicies = _Sdk.Legal.BaseLegalPolicies.RetrieveAllLegalPoliciesOp.Execute();
```

### Create a policy for marketing preference.

```csharp
CreateBasePolicyRequest createPolicy = new CreateBasePolicyRequest()
{
    TypeId = marketingPrefPolicyTypeId,
    BasePolicyName = basePolicyName,
    Description = "Testing CSharp Server SDK legal endpoints.",
    Namespace = _Sdk.Namespace,
    Tags = new List<string>() { "csharp", "server_sdk", "test" },
    AffectedCountries = new List<string>() { "ID" },
    AffectedClientIds = new List<string>()
};

CreateBasePolicyResponse? bPolResp = _Sdk.Legal.BaseLegalPolicies.CreatePolicyOp
    .SetBody(createPolicy)
    .Execute();
```

### Get single policy by policy id

```csharp
List<RetrievePolicyVersionResponse>? polVers = _Sdk.Legal.PolicyVersions.RetrieveSinglePolicyVersionOp
    .Execute(targetPolicyId);
```

### Create policy version

```csharp
CreatePolicyVersionResponse? polVerResp = _Sdk.Legal.PolicyVersions.CreatePolicyVersionOp
    .SetBody(policyVersion)
    .Execute(targetPolicyId);
```

### Accepting an aggrement policy

```csharp
List<AcceptAgreementRequest> aggreementRequests = new List<AcceptAgreementRequest>()
{
    new AcceptAgreementRequest()
    {
        LocalizedPolicyVersionId = targetLocalizedPolicyId,
        PolicyVersionId = targetPolicyVersionId,
        PolicyId = targetPolicyId,
        IsAccepted = true,
        IsNeedToSendEventMarketing = false
    }
};

string userId = _Sdk.Configuration.Credential!.UserId;
_Sdk.Legal.Agreement.ChangePreferenceConsentOp
    .SetBody(aggreementRequests)
    .Execute(_Sdk.Namespace, userId);
```

### Get aggrements

```csharp
List<RetrieveAcceptedAgreementResponse>? aggrs = _Sdk.Legal.Agreement.RetrieveAgreementsPublicOp
    .Execute();
```
## Lobby

Source: [LobbyTests.cs](../AccelByte.Sdk.Tests/Services/LobbyTests.cs)

### Send free form notification

```csharp
ModelFreeFormNotificationRequest notifBody = new ModelFreeFormNotificationRequest()
{
    Topic = "csharp_sdk_test",
    Message = "This is integration test for CSharp Server SDK."
};

_Sdk.Lobby.Admin.FreeFormNotificationOp
    .Execute(notifBody, _Sdk.Namespace);
```
## LoginQueue

Source: [LoginQueueTests.cs](../AccelByte.Sdk.Tests/Services/LoginQueueTests.cs)

### Get configuration

```csharp
var config = _Sdk.Loginqueue.AdminV1.AdminGetConfigurationOp
    .Execute(_Sdk.Namespace);
```

### Update configuration

```csharp
var configUpdate = _Sdk.Loginqueue.AdminV1.AdminUpdateConfigurationOp
    .Execute(new ApimodelsConfigurationRequest()
    {
        MaxLoginRate = updateMaxLoginRate
    }, _Sdk.Namespace);
```
## MatchmakingV2

Source: [MatchV2Tests.cs](../AccelByte.Sdk.Tests/Services/MatchV2Tests.cs)

### Create a match rule set

```csharp
ApiRuleSetPayload cRuleSetBody = new ApiRuleSetPayload()
{
    Name = rulesetName,
    Data = JsonSerializer.Deserialize<Dictionary<string, object>>(@"
        {
            ""alliance"": {
                ""min_number"": 2,
                ""max_number"": 10,
                ""player_min_number"": 2,
                ""player_max_number"": 4
            },
            ""matchingRules"": [
                {
                ""attribute"": """",
                ""criteria"": ""distance"",
                ""reference"": """"
                }
            ],
            ""flexingRules"": [
                {
                ""duration"": 600,
                ""attribute"": """",
                ""criteria"": ""distance"",
                ""reference"": """"
                }
            ],
            ""match_options"": {
                ""options"": [
                {
                    ""name"": ""myopt"",
                    ""type"": ""any""
                }
                ]
            },
            ""alliance_flexing_rule"": [
                {
                ""duration"": 600,
                ""min_number"": 1,
                ""max_number"": 2,
                ""player_min_number"": 1,
                ""player_max_number"": 2
                }
            ]
        }
    ")
};

_Sdk.Match2.RuleSets.CreateRuleSetOp
    .Execute(cRuleSetBody, _Sdk.Namespace);
```

### Create a match pool

```csharp
ApiMatchPool createPoolBody = new ApiMatchPool()
{
    Name = poolName,
    MatchFunction = "basic",
    SessionTemplate = cfgTemplateName,
    BackfillTicketExpirationSeconds = 600,
    RuleSet = rulesetName,
    TicketExpirationSeconds = 600
};

_Sdk.Match2.MatchPools.CreateMatchPoolOp
    .Execute(createPoolBody, _Sdk.Namespace);
```

### List match pools

```csharp
ApiListMatchPoolsResponse? poolList = _Sdk.Match2.MatchPools.MatchPoolListOp
    .Execute(_Sdk.Namespace);
```

### Get match pool detail

```csharp
ApiMatchPool? matchPool = _Sdk.Match2.MatchPools.MatchPoolDetailsOp
    .Execute(_Sdk.Namespace, poolName);
```

### User create a match ticket

```csharp
ApiMatchTicketRequest ticketRequest = new ApiMatchTicketRequest()
{
    MatchPool = poolName,
    SessionID = partyId
};

ApiMatchTicketResponse? nTicketResponse = sdk.Match2.MatchTickets.CreateMatchTicketOp
    .Execute(ticketRequest, sdk.Namespace);
```

### User delete a match ticket

```csharp
sdk.Match2.MatchTickets.DeleteMatchTicketOp
    .Execute(sdk.Namespace, ticketId);
```

### Delete a match pool

```csharp
_Sdk.Match2.MatchPools.DeleteMatchPoolOp
    .Execute(_Sdk.Namespace, poolName);
```

### Delete a match rule set

```csharp
_Sdk.Match2.RuleSets.DeleteRuleSetOp
    .Execute(_Sdk.Namespace, rulesetName);
```

### List match functions

```csharp
ApiListMatchFunctionsResponse? response = _Sdk.Match2.MatchFunctions.MatchFunctionListOp
    .Execute(_Sdk.Namespace);
```
## Platform

Source: [PlatformTests.cs](../AccelByte.Sdk.Tests/Services/PlatformTests.cs)

### Create a store

```csharp
StoreCreate createStore = new StoreCreate()
{
    Title = "CSharp SDK Store Test",
    Description = "Description for CSharp Server SDK store service integration test.",
    DefaultLanguage = "en",
    DefaultRegion = "US",
    SupportedLanguages = new List<string>() { "en", "id" },
    SupportedRegions = new List<string>() { "US", "ID" }
};

StoreInfo? cStore = _Sdk.Platform.Store.CreateStoreOp
    .Execute(createStore, _Sdk.Namespace);
```

### Get a store

```csharp
StoreInfo? gStore = _Sdk.Platform.Store.GetStoreOp
    .Execute(_Sdk.Namespace, store_id);
```

### Update a store

```csharp
StoreUpdate updateStore = new StoreUpdate()
{
    Description = "Updated description."
};
StoreInfo? cStoreUpdate = _Sdk.Platform.Store.UpdateStoreOp
    .Execute(updateStore, _Sdk.Namespace, store_id);
```

### Delete a store

```csharp
StoreInfo? dStore = _Sdk.Platform.Store.DeleteStoreOp
    .Execute(_Sdk.Namespace, store_id);
```

### Export a store

```csharp
ExportStoreRequest xRequest = new ExportStoreRequest();
Stream? stream = _Sdk.Platform.Store.ExportStore1Op
    .SetBody(xRequest)
    .Execute(_Sdk.Namespace, store_id);
```

### Import store

```csharp
ImportStoreResult? result = _Sdk.Platform.Store.ImportStore1Op
    .SetFile(uploadStream)
    .SetStoreId(store_id)
    .Execute(_Sdk.Namespace);
```
## Reporting

Source: [ReportingTests.cs](../AccelByte.Sdk.Tests/Services/ReportingTests.cs)

### Create a Reason

```csharp
Api.Reporting.Model.RestapiCreateReasonRequest createReason = new Api.Reporting.Model.RestapiCreateReasonRequest()
{
    Description = title,
    GroupIds = new List<string>(),
    Title = title,
};

Api.Reporting.Model.RestapiAdminReasonResponse? cReason = wAdminReasons.CreateReason(
    Api.Reporting.Operation.CreateReason.Builder
    .Build(
        createReason,
        _Sdk.Namespace
    ));
Assert.IsNotNull(cReason);
if (cReason != null)
{
    Assert.IsNotNull(cReason.Id);
    if (cReason.Id != null)
        reasonId = cReason.Id;

    Assert.AreEqual(title, cReason.Title);
}
```

### Get single Reason

```csharp
Api.Reporting.Model.RestapiAdminReasonResponse? cReason2 = wAdminReasons.AdminGetReason(
    Api.Reporting.Operation.AdminGetReason.Builder
    .Build(_Sdk.Namespace, reasonId));
Assert.IsNotNull(cReason2);
if (cReason2 != null)
{
    Assert.IsNotNull(cReason2.Id);
    Assert.AreEqual(title, cReason2.Title);
}
```

### Delete a Reporting

```csharp
wAdminReasons.DeleteReason(
    Api.Reporting.Operation.DeleteReason.Builder
    .Build(_Sdk.Namespace, reasonId));
```
## SeasonPass

Source: [SeasonPassTests.cs](../AccelByte.Sdk.Tests/Services/SeasonPassTests.cs)

### Create a store

```csharp
StoreCreate createStore = new StoreCreate()
{
    Title = "CSharp SDK Store Test",
    Description = "Description for CSharp Server SDK store service integration test.",
    DefaultLanguage = "en",
    DefaultRegion = "US",
    SupportedLanguages = new List<string>() { "en", "id" },
    SupportedRegions = new List<string>() { "US", "ID" }
};

StoreInfo? cStore = _Sdk.Platform.Store.CreateStoreOp
    .Execute(createStore, _Sdk.Namespace);
```

### Create a season

```csharp
Dictionary<string, Api.Seasonpass.Model.Localization> sLocalizations = new Dictionary<string, Api.Seasonpass.Model.Localization>()
{
    {"en", new Api.Seasonpass.Model.Localization()
        {
            Title = "English",
            Description = "English"
        }}
};

SeasonCreate cSeasonBody = new SeasonCreate()
{
    Name = nameSeason,
    Start = startTime,
    End = endTime,
    DefaultRequiredExp = 3,
    DraftStoreId = defaultDraftStoreId,
    TierItemId = defaultTierItemId,
    Localizations = sLocalizations
};

SeasonInfo? cSeason = _Sdk.Seasonpass.Season.CreateSeasonOp
    .SetBody(cSeasonBody)
    .Execute(_Sdk.Namespace);
```

### Get a season

```csharp
SeasonInfo? gSeason = _Sdk.Seasonpass.Season.GetSeasonOp
    .Execute(_Sdk.Namespace, cSeasonId);
```

### Update a season

```csharp
SeasonUpdate uSeasonBody = new SeasonUpdate()
{
    Name = "CSharpServerSDKTestSeasonUpdate",
    Start = startTime,
    End = endTime,
    DefaultRequiredExp = 3,
    DraftStoreId = defaultDraftStoreId,
    TierItemId = defaultTierItemId,
    Localizations = sLocalizations
};

SeasonInfo? uSeason = _Sdk.Seasonpass.Season.UpdateSeasonOp
    .SetBody(uSeasonBody)
    .Execute(_Sdk.Namespace, cSeasonId);
```
## Session

Source: [SessionTests.cs](../AccelByte.Sdk.Tests/Services/SessionTests.cs)

### Create session configuration template

```csharp
ApimodelsCreateConfigurationTemplateRequest cTemplateBody = new ApimodelsCreateConfigurationTemplateRequest()
{
    Name = cfgTemplateName,
    Type = ApimodelsCreateConfigurationTemplateRequestType.P2P,
    MinPlayers = 2,
    MaxPlayers = 2,
    InviteTimeout = 60,
    InactiveTimeout = 60,
    Joinability = ApimodelsCreateConfigurationTemplateRequestJoinability.OPEN,
    ClientVersion = "1.0.0",
    RequestedRegions = new List<string>()
    {
        "us-west-2"
    }
};

_Sdk.Session.ConfigurationTemplate.AdminCreateConfigurationTemplateV1Op
    .Execute(cTemplateBody, _Sdk.Namespace);

ApimodelsConfigurationTemplateResponse? cfgTemplate = _Sdk.Session.ConfigurationTemplate.AdminGetConfigurationTemplateV1Op
    .Execute(cfgTemplateName, _Sdk.Namespace);
```

### Update session configuration template

```csharp
ApimodelsUpdateConfigurationTemplateRequest uTemplateBody = new ApimodelsUpdateConfigurationTemplateRequest()
{
    Name = cfgTemplateName,
    Type = ApimodelsUpdateConfigurationTemplateRequestType.P2P,
    Joinability = ApimodelsUpdateConfigurationTemplateRequestJoinability.OPEN,
    MaxPlayers = 4
};

ApimodelsConfigurationTemplateResponse? uptTemplate = _Sdk.Session.ConfigurationTemplate.AdminUpdateConfigurationTemplateV1Op
    .Execute(uTemplateBody, cfgTemplateName, _Sdk.Namespace);
```

### Delete session configuration template

```csharp
_Sdk.Session.ConfigurationTemplate.AdminDeleteConfigurationTemplateV1Op
    .Execute(cfgTemplateName, _Sdk.Namespace);
```

### Create a game session

```csharp
ApimodelsCreateGameSessionRequest newGSRequest = new ApimodelsCreateGameSessionRequest()
{
    ConfigurationName = cfgTemplateName,
};

ApimodelsGameSessionResponse? newGSResponse = sdk.Session.GameSession.CreateGameSessionOp
    .Execute(newGSRequest, sdk.Namespace);
```

### Join a game session

```csharp
ApimodelsGameSessionResponse? p2GsJoin = sdk.Session.GameSession.JoinGameSessionOp
    .Execute(sdk.Namespace, gameSessionId);
```

### Leave a game session

```csharp
sdk.Session.GameSession.LeaveGameSessionOp
    .Execute(sdk.Namespace, gameSessionId);
```

### Delete a game session

```csharp
sdk.Session.GameSession.DeleteGameSessionOp
    .Execute(sdk.Namespace, gameSessionId);
```

### Query game sessions

```csharp
var response = _Sdk.Session.GameSession.PublicQueryGameSessionsByAttributesOp
    .Execute(new Dictionary<string, object>() { }, _Sdk.Namespace);
```

### User create a party

```csharp
ApimodelsCreatePartyRequest partyRequest = new ApimodelsCreatePartyRequest()
{
    ConfigurationName = cfgTemplateName,
    Members = new List<ApimodelsRequestMember>()
    {
        new ApimodelsRequestMember()
        {
            ID = player.UserId
        }
    }
};

ApimodelsPartySessionResponse? partyResponse = sdk.Session.Party.PublicCreatePartyOp
    .Execute(partyRequest, sdk.Namespace);
```

### User join a party with code

```csharp
ApimodelsJoinByCodeRequest joinRequest = new ApimodelsJoinByCodeRequest()
{
    Code = joinCode
};

ApimodelsPartySessionResponse? joinResponse = sdk.Session.Party.PublicPartyJoinCodeOp
    .Execute(joinRequest, sdk.Namespace);
```

### Get party detail

```csharp
ApimodelsPartySessionResponse? partyData = _Sdk.Session.Party.PublicGetPartyOp
    .Execute(_Sdk.Namespace, partyId);
```

### User leave a party

```csharp
sdk.Session.Party.PublicPartyLeaveOp
    .Execute(sdk.Namespace, partyId);
```
## Social

Source: [SocialTests.cs](../AccelByte.Sdk.Tests/Services/SocialTests.cs)

### Create a stat

```csharp
StatCreate createStat = new StatCreate()
{
    Name = "CSharp Server SDK Test Stat",
    Description = "CSharp server sdk integration test.",
    StatCode = stat_code,
    SetBy = "SERVER",
    Minimum = 0.0,
    Maximum = 100.0,
    DefaultValue = 50.0,
    IncrementOnly = true,
    SetAsGlobal = false,
    Tags = new List<string>() { "csharp", "server_sdk", "test" }
};

StatInfo? cStat = _Sdk.Social.StatConfiguration.CreateStatOp
    .Execute(createStat, _Sdk.Namespace);
```

### Get a stat

```csharp
StatInfo? gStat = _Sdk.Social.StatConfiguration.GetStatOp
    .Execute(_Sdk.Namespace, stat_code);
```

### Update a stat

```csharp
StatUpdate updateStat = new StatUpdate()
{
    Description = "Updated description."
};

StatInfo? uStat = _Sdk.Social.StatConfiguration.UpdateStatOp
    .Execute(updateStat, _Sdk.Namespace, stat_code);
```

### Delete a stat

```csharp
_Sdk.Social.StatConfiguration.DeleteStatOp
    .Execute(_Sdk.Namespace, stat_code);
```
## UGC

Source: [UgcTests.cs](../AccelByte.Sdk.Tests/Services/UgcTests.cs)

### Create a tag

```csharp
ModelsCreateTagRequest createTag = new ModelsCreateTagRequest()
{
    Tag = tag_name
};
ModelsCreateTagResponse? cTag = _Sdk.Ugc.AdminTag.AdminCreateTagOp
    .Execute(createTag, _Sdk.Namespace);
```

### Get tags

```csharp
ModelsPaginatedGetTagResponse? gTag = _Sdk.Ugc.AdminTag.AdminGetTagOp
    .SetOffset(0)
    .SetLimit(10)
    .Execute(_Sdk.Namespace);
```

### Update a tag

```csharp
ModelsCreateTagRequest updateTag = new ModelsCreateTagRequest()
{
    Tag = tag_name_u
};
ModelsCreateTagResponse? uTag = _Sdk.Ugc.AdminTag.AdminUpdateTagOp
    .Execute(updateTag, _Sdk.Namespace, tag_id);
```

### Delete a tag

```csharp
_Sdk.Ugc.AdminTag.AdminDeleteTagOp
    .Execute(_Sdk.Namespace, tag_id);
```

