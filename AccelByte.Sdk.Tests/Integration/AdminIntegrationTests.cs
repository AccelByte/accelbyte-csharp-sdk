// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Repository;
using AccelByte.Sdk.Core.Logging;
using AccelByte.Sdk.Core.Client;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;
using AccelByte.Sdk.Api.Achievement.Wrapper;

using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;
using AccelByte.Sdk.Api.Basic.Wrapper;

using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;
using AccelByte.Sdk.Api.Cloudsave.Wrapper;

using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Api.Dslogmanager.Wrapper;

using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;
using AccelByte.Sdk.Api.Eventlog.Wrapper;

using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;
using AccelByte.Sdk.Api.Gametelemetry.Wrapper;

using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;
using AccelByte.Sdk.Api.Leaderboard.Wrapper;

using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    [Explicit]
    public class AdminIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseInMemoryTokenRepository()
                .SetCredentialRepository(IntegrationTestCredentialRepository.Admin)
                .EnableLog()
                .Build();

            _Sdk.LoginUser();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        [Test]
        public void AchievementServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Achievements wAchievements = new Achievements(_Sdk);

            //Creating achievement
            ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
            {
                AchievementCode = "csharp-sdk-test",
                DefaultLanguage = "en",
                Name = new Dictionary<string, string>()
                {
                    {"en", "CSharp Server SDK Test" }
                },
                Description = new Dictionary<string, string>
                {
                    {"en", "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit..." }
                },
                GoalValue = 1000.0,
                StatCode = "csharp-sdk-test",
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

            ModelsAchievementResponse? cResp = wAchievements.AdminCreateNewAchievement(AdminCreateNewAchievement.Builder
                .Build(newAchievement, _Sdk.Namespace));
            Assert.IsNotNull(cResp);
            Assert.AreEqual(cResp?.AchievementCode!, "csharp-sdk-test");

            //Updating achievement
            ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
            {
                GoalValue = 2000.0
            };

            ModelsAchievementResponse? uResp = wAchievements.AdminUpdateAchievement(AdminUpdateAchievement.Builder
                .Build(updateAchievement, "csharp-sdk-test", _Sdk.Namespace));
            Assert.IsNotNull(uResp);
            Assert.AreEqual(uResp?.GoalValue!, 2000.0);

            //Retrieve achievement by code
            ModelsAchievementResponse? rResp = wAchievements.AdminGetAchievement(AdminGetAchievement.Builder
                .Build("csharp-sdk-test", _Sdk.Namespace));
            Assert.IsNotNull(rResp);
            Assert.AreEqual(rResp?.GoalValue!, 2000.0);
            Assert.AreEqual(rResp?.Name!["en"], "CSharp Server SDK Test");

            //Get all achievements
            ModelsPaginatedAchievementResponse? gaResp = wAchievements.AdminListAchievements(AdminListAchievements.Builder
                .SetLimit(100)
                .SetOffset(0)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(gaResp);
            Assert.Greater(gaResp?.Data?.Count, 0);

            //Delete achievement
            wAchievements.AdminDeleteAchievement(AdminDeleteAchievement.Builder
                .Build("csharp-sdk-test", _Sdk.Namespace));

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelsAchievementResponse? dResp = wAchievements.AdminGetAchievement(AdminGetAchievement.Builder
                    .Build("csharp-sdk-test", _Sdk.Namespace));
            });
        }

        [Test]
        public void BasicServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            UserProfile wProfile = new UserProfile(_Sdk);
            
            try
            {
                //Get user's own profile info, will throw an exception if profile does not exists which is expected.
                UserProfilePrivateInfo? check = wProfile.GetMyProfileInfo(GetMyProfileInfo.Builder
                    .Build(_Sdk.Namespace));

                if (check != null)
                {
                    //But if the profile do actually exists, just delete it.
                    UserProfilePrivateInfo? checkDel = wProfile.DeleteUserProfile(DeleteUserProfile.Builder
                        .Build(_Sdk.Namespace, check.UserId!));
                    Assert.IsNotNull(checkDel);
                }
            }
            catch (HttpResponseException x)
            {
                Api.Basic.Model.ErrorEntity? error =
                    System.Text.Json.JsonSerializer.Deserialize<Api.Basic.Model.ErrorEntity>(x.Message);
                if (error == null)
                    throw new Exception("Response is null");

                if (error.ErrorCode != 11440)
                    Assert.Fail("Unexpected error response from Basic::GetMyProfileInfoOp.");
            }


            //Create user's own profile info
            UserProfilePrivateCreate createProfile = new UserProfilePrivateCreate()
            {
                FirstName = "Integration Test",
                LastName = "CSharp Server SDK",
                DateOfBirth = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Language = "en"
            };

            UserProfilePrivateInfo? cInfo = wProfile.CreateMyProfile(CreateMyProfile.Builder
                .SetBody(createProfile)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(cInfo);
            Assert.AreEqual(cInfo?.FirstName, "Integration Test");

            //Get user's own profile info
            UserProfilePrivateInfo? ownResp = wProfile.GetMyProfileInfo(GetMyProfileInfo.Builder
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(ownResp);
            Assert.AreEqual(ownResp?.LastName!, "CSharp Server SDK");

            string userId = ownResp?.UserId!;

            //Update user's own profile info
            UserProfilePrivateUpdate updateProfile = new UserProfilePrivateUpdate()
            {
                TimeZone = "Asia/Jakarta"
            };
            UserProfilePrivateInfo? updResp = wProfile.UpdateMyProfile(UpdateMyProfile.Builder
                .SetBody(updateProfile)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(updResp);
            Assert.AreEqual(updResp?.TimeZone, "Asia/Jakarta");

            //Delete user's own profile info
            UserProfilePrivateInfo? delResp = wProfile.DeleteUserProfile(DeleteUserProfile.Builder
                .Build(_Sdk.Namespace, userId));
            Assert.IsNotNull(delResp);
        }

        [Test]
        public void CloudSaveServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            PublicGameRecord wPublicGameRecord = new PublicGameRecord(_Sdk);

            //Create new game record
            ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "foo",
                FooValue = 4893
            };

            wPublicGameRecord.PostGameRecordHandlerV1(PostGameRecordHandlerV1.Builder
                .Build(gameRecord, "foo_bar_record", _Sdk.Namespace));

            //Get game record
            ModelsGameRecordResponse? gRecord = wPublicGameRecord.GetGameRecordHandlerV1(GetGameRecordHandlerV1.Builder
                .Build("foo_bar_record", _Sdk.Namespace));
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            Dictionary<string, object> recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("foo", recValue["foo_bar"].ToString());

            //Update game record
            ModelsGameRecordRequestForTest updateRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "update",
                FooValue = 4893
            };

            wPublicGameRecord.PutGameRecordHandlerV1(PutGameRecordHandlerV1.Builder
                .Build(updateRecord, "foo_bar_record", _Sdk.Namespace));

            //re-check updated game record
            gRecord = wPublicGameRecord.GetGameRecordHandlerV1(GetGameRecordHandlerV1.Builder
                .Build("foo_bar_record", _Sdk.Namespace));
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo"));
            Assert.AreEqual("bar", recValue["foo"].ToString());

            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("update", recValue["foo_bar"].ToString());

            //Delete game record
            wPublicGameRecord.DeleteGameRecordHandlerV1(DeleteGameRecordHandlerV1.Builder
                .Build("foo_bar_record", _Sdk.Namespace));

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                gRecord = wPublicGameRecord.GetGameRecordHandlerV1(GetGameRecordHandlerV1.Builder
                    .Build("foo_bar_record", _Sdk.Namespace));
            });
        }

        [Test]
        public void DSLogManagerServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            TerminatedServers wTerminatedServers = new TerminatedServers(_Sdk);
            ModelsListTerminatedServersResponse? tsResp = wTerminatedServers.ListTerminatedServers(ListTerminatedServers.Builder
                .SetLimit(10)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(tsResp);
        }

        [Test]
        public void EventLogServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Api.Eventlog.Wrapper.EventV2 wEvent = new EventV2(_Sdk);

            ModelsGenericQueryPayload eQueryPayload = new ModelsGenericQueryPayload()
            {
                ClientId = _Sdk.Configuration.ConfigRepository.ClientId
            };

            ModelsEventResponseV2? eResp = wEvent.QueryEventStreamHandler(QueryEventStreamHandler.Builder
                .SetOffset(0)
                .SetPageSize(10)
                .Build(eQueryPayload, _Sdk.Namespace));
            Assert.IsNotNull(eResp);
            Assert.Greater(eResp!.Data!.Count, 0);

            try
            {
                eResp = wEvent.GetEventSpecificUserV2Handler(GetEventSpecificUserV2Handler.Builder
                .SetOffset(0)
                .SetPageSize(10)
                .Build(_Sdk.Namespace, _Sdk.Configuration.Credential!.UserId));
                Assert.IsNotNull(eResp);
                Assert.Greater(eResp!.Data!.Count, 0);
            }
            catch (Exception x)
            {
                ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                if (mer == null)
                    throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");
                if (mer.ErrorMessage != "data not found")
                    throw new Exception(mer.ErrorMessage, x);
            }
        }

        [Test]
        public void GameTelemetryServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string steamId = "76561199259217491";
            string playTime = "4";
            string accessToken = _Sdk.Configuration.TokenRepository.GetToken();

            Api.Gametelemetry.Wrapper.GametelemetryOperations wGametelemetryOperations = new Api.Gametelemetry.Wrapper.GametelemetryOperations(_Sdk);

            wGametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(
                Api.Gametelemetry.Operation.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost.Builder
                   .Build(new List<TelemetryBody>
                   {
                       new TelemetryBody
                       {
                           EventId = "csharpsdk",
                           EventName = "CsharpEvent",
                           EventNamespace = "test",
                           EventTimestamp = DateTime.Now,
                           Payload = new Dictionary<string, object>
                           {
                               {"foo", "bar"}
                           }
                       }
                   }, accessToken));

            try
            {
                wGametelemetryOperations
                    .ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut(
                        Api.Gametelemetry.Operation
                           .ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePut.Builder
                           .Build(playTime, steamId, accessToken));
            }
            catch (HttpResponseException e)
            {
                if (e.Message.ToLower().Contains("user not found"))
                {
                    Assert.Ignore("User not found.");
                }
            }

            Dictionary<string, object>? resGet = wGametelemetryOperations.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet(
                Api.Gametelemetry.Operation.ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGet.Builder
                   .Build(steamId, accessToken));

            Assert.IsNotNull(resGet);
            Assert.Contains("total_playtime", resGet);
            Assert.Equals(playTime, resGet!["total_playtime"]);
        }

        [Test]
        public void GDPRServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Api.Gdpr.Wrapper.DataRetrieval wGdprRetrieval = new Api.Gdpr.Wrapper.DataRetrieval(_Sdk);

            string firstEmailToTest = "dummy@example.com";
            string anotherEmailToTest = "anotheremail@dummy.com";

            wGdprRetrieval.SaveAdminEmailConfiguration(
                Api.Gdpr.Operation.SaveAdminEmailConfiguration.Builder
                .Build(new List<string>
                {
                    firstEmailToTest
                }, _Sdk.Namespace));

            List<string>? emails = wGdprRetrieval.GetAdminEmailConfiguration(
                Api.Gdpr.Operation.GetAdminEmailConfiguration.Builder
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(emails);

            wGdprRetrieval.UpdateAdminEmailConfiguration(
                Api.Gdpr.Operation.UpdateAdminEmailConfiguration.Builder
                .Build(new List<string>() { anotherEmailToTest }, _Sdk.Namespace));

            wGdprRetrieval.DeleteAdminEmailConfiguration(Api.Gdpr.Operation.DeleteAdminEmailConfiguration.Builder
                .Build(_Sdk.Namespace, new List<string>() { anotherEmailToTest }));
        }

        [Test]
        public void GroupServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string initialConfigCode = "initialConfigurationCode";
            string configuration_code = "csharpServerSdkConfigCode";
            string defaultAdminRoleId = String.Empty;
            string defaultMemberRoleId = String.Empty;

            Api.Group.Wrapper.Configuration wConfig = new Api.Group.Wrapper.Configuration(_Sdk);
            Api.Group.Wrapper.Group wGroup = new Api.Group.Wrapper.Group(_Sdk);
            
            try
            {
                Api.Group.Model.ModelsGetGroupConfigurationResponseV1? gConfigCheck = wConfig.GetGroupConfigurationAdminV1(
                    Api.Group.Operation.GetGroupConfigurationAdminV1.Builder
                    .Build(initialConfigCode, _Sdk.Namespace));

                //Initial config exists. Grab the role identifiers.
                defaultAdminRoleId = gConfigCheck!.GroupAdminRoleId!;
                defaultMemberRoleId = gConfigCheck!.GroupMemberRoleId!;
            }
            catch (Exception x)
            {
                ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                if (mer == null)
                    throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");

                if (mer.ErrorCode != 73131)
                    throw new Exception(mer.ErrorMessage, x);

                //It means no initial configuration yet. But we need it for the default role id and admin role id.
                //So we just have to initiate it.

                Api.Group.Model.ModelsCreateGroupConfigurationResponseV1? iConfigResp = wConfig.InitiateGroupConfigurationAdminV1(
                    Api.Group.Operation.InitiateGroupConfigurationAdminV1.Builder
                    .Build(_Sdk.Namespace));
                Assert.IsNotNull(iConfigResp);

                defaultAdminRoleId = iConfigResp!.GroupAdminRoleId!;
                defaultMemberRoleId = iConfigResp!.GroupMemberRoleId!;
            }

            //Create group configuration
            Api.Group.Model.ModelsCreateGroupConfigurationRequestV1 gcRequest = new Api.Group.Model.ModelsCreateGroupConfigurationRequestV1()
            {
                ConfigurationCode = configuration_code,
                Description = "CSharp SDK Test Configuration Group",
                GroupMaxMember = 50,
                Name = "CSharp SDK Test Configuration Group",
                GroupAdminRoleId = defaultAdminRoleId,
                GroupMemberRoleId = defaultMemberRoleId
            };

            try
            {
                Api.Group.Model.ModelsCreateGroupConfigurationResponseV1? gcResp = wConfig.CreateGroupConfigurationAdminV1(
                    Api.Group.Operation.CreateGroupConfigurationAdminV1.Builder
                    .Build(gcRequest, _Sdk.Namespace));
                Assert.IsNotNull(gcResp);
            }
            catch (Exception x)
            {
                ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                if (mer == null)
                    throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");
                if (mer.ErrorCode != 73130)
                    throw new Exception(mer.ErrorMessage, x);
            }

            //Create a group
            Api.Group.Model.ModelsPublicCreateNewGroupRequestV1 createGroup = new Api.Group.Model.ModelsPublicCreateNewGroupRequestV1()
            {
                GroupName = "CSharp SDK Test Group",
                GroupType = "PUBLIC",
                GroupDescription = "Yeah, anything is welcome here.",
                GroupMaxMember = 100,
                GroupRegion = "us",
                ConfigurationCode = configuration_code
            };

            Api.Group.Model.ModelsGroupResponseV1? cGroup = wGroup.CreateNewGroupPublicV1(Api.Group.Operation.CreateNewGroupPublicV1.Builder
                .Build(createGroup, _Sdk.Namespace));
            Assert.IsNotNull(cGroup);

            string group_id = String.Empty;
            if (cGroup != null)
            {
                Assert.AreEqual("CSharp SDK Test Group", cGroup.GroupName);
                group_id = cGroup.GroupId!;
            }

            //Get single group
            Api.Group.Model.ModelsGroupResponseV1? gGroup = wGroup.GetSingleGroupPublicV1(Api.Group.Operation.GetSingleGroupPublicV1.Builder
                .Build(group_id, _Sdk.Namespace));
            Assert.IsNotNull(gGroup);
            if (gGroup != null)
                Assert.AreEqual("CSharp SDK Test Group", gGroup.GroupName);

            //Update a group
            Api.Group.Model.ModelsUpdateGroupRequestV1 updateGroup = new Api.Group.Model.ModelsUpdateGroupRequestV1()
            {
                GroupDescription = "Updated description."
            };

            Api.Group.Model.ModelsGroupResponseV1? uGroup = wGroup.UpdateSingleGroupV1(Api.Group.Operation.UpdateSingleGroupV1.Builder
                .Build(updateGroup, group_id, _Sdk.Namespace));
            Assert.IsNotNull(uGroup);
            if (uGroup != null)
                Assert.AreEqual("Updated description.", uGroup.GroupDescription);

            //Delete a group
            wGroup.DeleteGroupPublicV1(Api.Group.Operation.DeleteGroupPublicV1.Builder
                .Build(group_id, _Sdk.Namespace));

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                Api.Group.Model.ModelsGroupResponseV1? gGroup = wGroup.GetSingleGroupPublicV1(Api.Group.Operation.GetSingleGroupPublicV1.Builder
                    .Build(group_id, _Sdk.Namespace));
            });

            //Delete group configuration
            wConfig.DeleteGroupConfigurationV1(
                Api.Group.Operation.DeleteGroupConfigurationV1.Builder
                .Build(configuration_code, _Sdk.Namespace));
        }

        [Test]
        public void IamServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string user_name = ("csharpsdk_" + Helper.GenerateRandomId(8));
            string user_password = Helper.GenerateRandomPassword(10);
            string user_email = (user_name + "@test.com");
            string user_id = String.Empty;

            Api.Iam.Wrapper.Users wIamUser = new Api.Iam.Wrapper.Users(_Sdk);
            Api.Iam.Wrapper.UsersV4 wIamUserV4 = new Api.Iam.Wrapper.UsersV4(_Sdk);

            //Create user
            Api.Iam.Model.AccountCreateUserRequestV4 newUser = new Api.Iam.Model.AccountCreateUserRequestV4()
            {
                AuthType = "EMAILPASSWD",
                EmailAddress = user_email,
                Password = user_password,
                DisplayName = "CSharp Server SDK Test",
                Username = user_name,
                Country = "ID",
                DateOfBirth = "1995-01-10"
            };

            Api.Iam.Model.AccountCreateUserResponseV4? cuResp = wIamUserV4.PublicCreateUserV4(
                Api.Iam.Operation.PublicCreateUserV4.Builder
                .Build(newUser, _Sdk.Namespace));
            Assert.IsNotNull(cuResp);
            if (cuResp != null)
            {
                Assert.AreEqual(user_email, cuResp.EmailAddress);
                user_id = cuResp.UserId!;
            }

            //Get the user
            Api.Iam.Model.ModelUserResponse? gUser = wIamUser.GetUserByUserID(
                Api.Iam.Operation.GetUserByUserID.Builder
                .Build(_Sdk.Namespace, user_id));
            Assert.IsNotNull(gUser);
            Assert.AreEqual("CSharp Server SDK Test", gUser!.DisplayName);

            //Update user
            Api.Iam.Model.ModelUserUpdateRequest updateUser = new Api.Iam.Model.ModelUserUpdateRequest()
            {
                DateOfBirth = "1996-01-10"
            };

            Api.Iam.Model.ModelUserResponse? uuResp = wIamUser.UpdateUser(
                Api.Iam.Operation.UpdateUser.Builder
                .Build(updateUser, _Sdk.Namespace, user_id));
            Assert.IsNotNull(uuResp);
            if (uuResp != null)
                Assert.AreEqual("1996-01-10", uuResp.DateOfBirth?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            //Delete user
            wIamUser.DeleteUser(
                Api.Iam.Operation.DeleteUser.Builder
                .Build(_Sdk.Namespace, user_id));

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                Api.Iam.Model.ModelUserResponse? gUser = wIamUser.GetUserByUserID(
                    Api.Iam.Operation.GetUserByUserID.Builder
                    .Build(_Sdk.Namespace, user_id));
            });
        }

        [Test]
        public void LeaderboardServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            LeaderboardConfiguration wLeaderboard = new LeaderboardConfiguration(_Sdk);
            string leaderboard_code = "csharpsdklbtest" + Guid.NewGuid().ToString().Substring(0, 6);
            string start_time = DateTime.Now.AddMonths(1).ToString("yyyy-MM-dd'T'HH:mm:ss.ffK");

            //Create a leaderboard
            ModelsLeaderboardConfigReq newLeaderboard = new ModelsLeaderboardConfigReq()
            {
                LeaderboardCode = leaderboard_code,
                Name = "CSharp SDK Leaderboard Test",
                StatCode = "1",
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

            ModelsLeaderboardConfigReq? cLeaderboard = wLeaderboard.CreateLeaderboardConfigurationAdminV1(CreateLeaderboardConfigurationAdminV1.Builder
                .Build(newLeaderboard, _Sdk.Namespace));
            Assert.IsNotNull(cLeaderboard);
            if (cLeaderboard != null)
                Assert.AreEqual("CSharp SDK Leaderboard Test", cLeaderboard.Name!);

            //Get a leaderboard
            ModelsGetLeaderboardConfigResp? gLeaderboard = wLeaderboard.GetLeaderboardConfigurationAdminV1(GetLeaderboardConfigurationAdminV1.Builder
                .Build(leaderboard_code, _Sdk.Namespace));
            Assert.IsNotNull(gLeaderboard);
            if (gLeaderboard != null)
                Assert.AreEqual("CSharp SDK Leaderboard Test", gLeaderboard.Name!);

            //Update a leaderboard
            ModelsUpdateLeaderboardConfigReq updateLeaderboard = new ModelsUpdateLeaderboardConfigReq()
            {
                Name = "CSharp SDK Leaderboard Test",
                StatCode = "1",
                StartTime = start_time,
                SeasonPeriod = 40
            };

            ModelsGetLeaderboardConfigResp? uLeaderboard = wLeaderboard.UpdateLeaderboardConfigurationAdminV1(UpdateLeaderboardConfigurationAdminV1.Builder
                .Build(updateLeaderboard, leaderboard_code, _Sdk.Namespace));
            Assert.IsNotNull(uLeaderboard);
            if (uLeaderboard != null)
                Assert.AreEqual(40, uLeaderboard.SeasonPeriod!);

            //Delete a leaderboard
            wLeaderboard.DeleteLeaderboardConfigurationAdminV1(DeleteLeaderboardConfigurationAdminV1.Builder
                .Build(leaderboard_code, _Sdk.Namespace));

            //Finally, recheck if the data is truly deleted.
            ModelsGetLeaderboardConfigResp? dcLeaderboard = wLeaderboard.GetLeaderboardConfigurationAdminV1(GetLeaderboardConfigurationAdminV1.Builder
                .Build(leaderboard_code, _Sdk.Namespace));
            Assert.IsNotNull(dcLeaderboard);
            Assert.IsTrue(dcLeaderboard!.IsDeleted!);
        }        

        [Test]
        public void PlatformServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Store wStore = new Store(_Sdk);
            string store_id = String.Empty;

            //Create a store
            StoreCreate createStore = new StoreCreate()
            {
                Title = "CSharp SDK Store Test",
                Description = "Description for CSharp Server SDK store service integration test.",
                DefaultLanguage = "en",
                DefaultRegion = "US",
                SupportedLanguages = new List<string>() { "en", "id" },
                SupportedRegions = new List<string>() { "US", "ID" }
            };

            StoreInfo? cStore = wStore.CreateStore(CreateStore.Builder
                .SetBody(createStore)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(cStore);
            if (cStore != null)
            {
                Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
                store_id = cStore.StoreId!;
            }

            //Get a store
            StoreInfo? gStore = wStore.GetStore(GetStore.Builder
                .Build(_Sdk.Namespace, store_id));
            Assert.IsNotNull(gStore);
            if (gStore != null)
                Assert.AreEqual("CSharp SDK Store Test", gStore.Title);

            //Update a store
            StoreUpdate updateStore = new StoreUpdate()
            {
                Description = "Updated description."
            };
            StoreInfo? cStoreUpdate = wStore.UpdateStore(UpdateStore.Builder
                .SetBody(updateStore)
                .Build(_Sdk.Namespace, store_id));
            Assert.IsNotNull(cStoreUpdate);
            if (cStoreUpdate != null)
                Assert.AreEqual("Updated description.", cStoreUpdate.Description);

            //Delete a store
            StoreInfo? dStore = wStore.DeleteStore(DeleteStore.Builder
                .Build(_Sdk.Namespace, store_id));
            Assert.IsNotNull(dStore);
        }

        [Test]
        public void SessionBrowserServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string usernameToTest = "dummy@example.com";
            if (_Sdk.Configuration.Credential != null)
                usernameToTest = _Sdk.Configuration.Credential.Username;
            string session_id = String.Empty;

            Api.Sessionbrowser.Wrapper.Session wSBSession = new Api.Sessionbrowser.Wrapper.Session(_Sdk);

            //Create a session
            Api.Sessionbrowser.Model.ModelsCreateSessionRequest createSession = new Api.Sessionbrowser.Model.ModelsCreateSessionRequest()
            {
                SessionType = "p2p",
                GameVersion = "0.3.0",
                Namespace = _Sdk.Namespace,
                Username = usernameToTest,
                GameSessionSetting = new Api.Sessionbrowser.Model.ModelsGameSessionSetting()
                {
                    Mode = "deathmatch",
                    AllowJoinInProgress = true,
                    MapName = "CSharp SDK Integration Test",
                    MaxPlayer = 100
                }
            };

            Api.Sessionbrowser.Model.ModelsSessionResponse? cResp = wSBSession.CreateSession(
                Api.Sessionbrowser.Operation.CreateSession.Builder
                .Build(createSession, _Sdk.Namespace));
            Assert.IsNotNull(cResp);
            if (cResp != null)
            {
                Assert.AreEqual(usernameToTest, cResp.Username!);
                session_id = cResp.SessionId!;
            }

            //Get a session
            Api.Sessionbrowser.Model.ModelsSessionResponse? gResp = wSBSession.GetSession(
                Api.Sessionbrowser.Operation.GetSession.Builder
                .Build(_Sdk.Namespace, session_id));
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("0.3.0", gResp.GameVersion!);

            //Update a session
            Api.Sessionbrowser.Model.ModelsUpdateSessionRequest updateSession = new Api.Sessionbrowser.Model.ModelsUpdateSessionRequest()
            {
                GameMaxPlayer = 150
            };
            Api.Sessionbrowser.Model.ModelsSessionResponse? uResp = wSBSession.UpdateSession(
                Api.Sessionbrowser.Operation.UpdateSession.Builder
                .Build(updateSession, _Sdk.Namespace, session_id));
            Assert.IsNotNull(uResp);
            if (uResp != null)
                Assert.AreEqual(150, uResp.GameSessionSetting!.MaxPlayer!);

            //Delete a session
            Api.Sessionbrowser.Model.ModelsSessionResponse? dResp = wSBSession.DeleteSession(
                Api.Sessionbrowser.Operation.DeleteSession.Builder
                .Build(_Sdk.Namespace, session_id));
            Assert.IsNotNull(uResp);
        }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string stat_code = "csharpserversdkteststat";

            Api.Social.Wrapper.StatConfiguration wStatConfig = new Api.Social.Wrapper.StatConfiguration(_Sdk);

            //Create a statistic
            Api.Social.Model.StatCreate createStat = new Api.Social.Model.StatCreate()
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

            Api.Social.Model.StatInfo? cStat = wStatConfig.CreateStat(
                Api.Social.Operation.CreateStat.Builder
                .SetBody(createStat)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", cStat.Name);

            //Get a statistic
            Api.Social.Model.StatInfo? gStat = wStatConfig.GetStat(
                Api.Social.Operation.GetStat.Builder
                .Build(_Sdk.Namespace, stat_code));
            Assert.IsNotNull(gStat);
            if (gStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", gStat.Name);

            //Update a statistic
            Api.Social.Model.StatUpdate updateStat = new Api.Social.Model.StatUpdate()
            {
                Description = "Updated description."
            };

            Api.Social.Model.StatInfo? uStat = wStatConfig.UpdateStat(
                Api.Social.Operation.UpdateStat.Builder
                .SetBody(updateStat)
                .Build(_Sdk.Namespace, stat_code));
            Assert.IsNotNull(uStat);
            if (uStat != null)
                Assert.AreEqual("Updated description.", uStat.Description);

            //Delete a statistic
            wStatConfig.DeleteStat(Api.Social.Operation.DeleteStat.Builder
                .Build(_Sdk.Namespace, stat_code));
        }

        [Test]
        public void UGCServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string tag_name = "csharp_server_sdk_test";
            string tag_name_u = "csharp_server_sdk_test_update";
            string tag_id = String.Empty;

            Api.Ugc.Wrapper.AdminTag wAdminTag = new Api.Ugc.Wrapper.AdminTag(_Sdk);

            //Create a tag
            Api.Ugc.Model.ModelsCreateTagRequest createTag = new Api.Ugc.Model.ModelsCreateTagRequest()
            {
                Tag = tag_name
            };
            Api.Ugc.Model.ModelsCreateTagResponse? cTag = wAdminTag.AdminCreateTag(
                Api.Ugc.Operation.AdminCreateTag.Builder
                .Build(createTag, _Sdk.Namespace));
            Assert.IsNotNull(cTag);
            if (cTag != null)
            {
                Assert.AreEqual(tag_name, cTag.Tag);
                tag_id = cTag.Id!;
            }

            //Get tags
            Api.Ugc.Model.ModelsPaginatedGetTagResponse? gTag = wAdminTag.AdminGetTag(
                Api.Ugc.Operation.AdminGetTag.Builder
                .SetOffset(0)
                .SetLimit(10)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(gTag);

            //Update a tag
            Api.Ugc.Model.ModelsCreateTagRequest updateTag = new Api.Ugc.Model.ModelsCreateTagRequest()
            {
                Tag = tag_name_u
            };
            Api.Ugc.Model.ModelsCreateTagResponse? uTag = wAdminTag.AdminUpdateTag(
                Api.Ugc.Operation.AdminUpdateTag.Builder
                .Build(updateTag, _Sdk.Namespace, tag_id));
            Assert.IsNotNull(uTag);
            if (uTag != null)
                Assert.AreEqual(tag_name_u, uTag.Tag);

            //Delete a tag
            wAdminTag.AdminDeleteTag(
                Api.Ugc.Operation.AdminDeleteTag.Builder
                .Build(_Sdk.Namespace, tag_id));
        }
    }
}