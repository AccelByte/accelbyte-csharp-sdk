// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Core.Util;

using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Ugc.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class FAdminIntegrationTests : BaseIntegrationTest
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

            ModelsAchievementResponse? cResp = _Sdk.Achievement.Achievements.AdminCreateNewAchievementOp
                .Execute(newAchievement, _Sdk.Namespace);
            Assert.IsNotNull(cResp);
            Assert.AreEqual(cResp?.AchievementCode!, "csharp-sdk-test");

            //Updating achievement
            ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
            {
                GoalValue = 2000.0
            };

            ModelsAchievementResponse? uResp = _Sdk.Achievement.Achievements.AdminUpdateAchievementOp
                .Execute(updateAchievement, "csharp-sdk-test", _Sdk.Namespace);
            Assert.IsNotNull(uResp);
            Assert.AreEqual(uResp?.GoalValue!, 2000.0);

            //Retrieve achievement by code
            ModelsAchievementResponse? rResp = _Sdk.Achievement.Achievements.AdminGetAchievementOp
                .Execute("csharp-sdk-test", _Sdk.Namespace);
            Assert.IsNotNull(rResp);
            Assert.AreEqual(rResp?.GoalValue!, 2000.0);
            Assert.AreEqual(rResp?.Name!["en"], "CSharp Server SDK Test");

            //Get all achievements
            ModelsPaginatedAchievementResponse? gaResp = _Sdk.Achievement.Achievements.AdminListAchievementsOp
                .SetLimit(100)
                .SetOffset(0)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(gaResp);
            Assert.Greater(gaResp?.Data?.Count, 0);

            //Delete achievement
            _Sdk.Achievement.Achievements.AdminDeleteAchievementOp.Execute("csharp-sdk-test", _Sdk.Namespace);

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelsAchievementResponse? dResp = _Sdk.Achievement.Achievements.AdminGetAchievementOp
                    .Execute("csharp-sdk-test", _Sdk.Namespace);
            });
        }

        [Test]
        public void BasicServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            //Create user's own profile info
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
            Assert.IsNotNull(cInfo);
            Assert.AreEqual(cInfo?.FirstName, "Integration Test");

            //Get user's own profile info
            UserProfilePrivateInfo? ownResp = _Sdk.Basic.UserProfile.GetMyProfileInfoOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(ownResp);
            Assert.AreEqual(ownResp?.LastName!, "CSharp Server SDK");

            string userId = ownResp?.UserId!;

            //Update user's own profile info
            UserProfilePrivateUpdate updateProfile = new UserProfilePrivateUpdate()
            {
                TimeZone = "Asia/Jakarta"
            };

            UserProfilePrivateInfo? updResp = _Sdk.Basic.UserProfile.UpdateMyProfileOp
                .SetBody(updateProfile)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(updResp);
            Assert.AreEqual(updResp?.TimeZone, "Asia/Jakarta");

            //Delete user's own profile info
            UserProfilePrivateInfo? delResp = _Sdk.Basic.UserProfile.DeleteUserProfileOp
                .Execute(_Sdk.Namespace, userId);
            Assert.IsNotNull(delResp);
        }

        [Test]
        public void CloudSaveServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            //Create new game record
            ModelsGameRecordRequestForTest gameRecord = new ModelsGameRecordRequestForTest()
            {
                Foo = "bar",
                FooBar = "foo",
                FooValue = 4893
            };

            _Sdk.Cloudsave.PublicGameRecord.PostGameRecordHandlerV1Op
                .Execute(gameRecord, "foo_bar_record", _Sdk.Namespace);

            //Get game record
            ModelsGameRecordResponse? gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);
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

            _Sdk.Cloudsave.PublicGameRecord.PutGameRecordHandlerV1Op
                .Execute(updateRecord, "foo_bar_record", _Sdk.Namespace);

            //re-check updated game record
            gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);
            Assert.IsNotNull(gRecord);
            Assert.IsNotNull(gRecord!.Value);

            recValue = gRecord.Value!;
            Assert.IsTrue(recValue.ContainsKey("foo"));
            Assert.AreEqual("bar", recValue["foo"].ToString());

            Assert.IsTrue(recValue.ContainsKey("foo_bar"));
            Assert.AreEqual("update", recValue["foo_bar"].ToString());

            //Delete game record
            _Sdk.Cloudsave.PublicGameRecord.DeleteGameRecordHandlerV1Op
                .Execute("foo_bar_record", _Sdk.Namespace);

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                gRecord = _Sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
                    .Execute("foo_bar_record", _Sdk.Namespace);
            });
        }

        [Test]
        public void DSLogManagerServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            Api.Dslogmanager.Model.ModelsListTerminatedServersResponse? tsResp = _Sdk.Dslogmanager.TerminatedServers.ListTerminatedServersOp
                .SetLimit(10)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(tsResp);
        }

        [Test]
        public void EventLogServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ModelsGenericQueryPayload eQueryPayload = new ModelsGenericQueryPayload()
            {
                ClientId = _Sdk.Configuration.ConfigRepository.ClientId
            };

            ModelsEventResponseV2? eResp = _Sdk.Eventlog.EventV2.QueryEventStreamHandlerOp
                .SetOffset(0)
                .SetPageSize(10)
                .Execute(eQueryPayload, _Sdk.Namespace);
            Assert.IsNotNull(eResp);
            Assert.Greater(eResp!.Data!.Count, 0);

            try
            {
                eResp = _Sdk.Eventlog.EventV2.GetEventSpecificUserV2HandlerOp
                    .SetOffset(0)
                    .SetPageSize(10)
                    .Execute(_Sdk.Namespace, _Sdk.Configuration.Credential!.UserId);
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
        public void GametelemetryServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string steamId = "76561199259217491";
            string playTime = "4";
            string accessToken = _Sdk.Configuration.TokenRepository.GetToken();
            
            _Sdk.Gametelemetry.GametelemetryOperations.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostOp
                .Execute(new List<TelemetryBody>
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
                }, accessToken);
            
            _Sdk.Gametelemetry.GametelemetryOperations.ProtectedUpdatePlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimePlaytimePutOp
                .Execute(playTime, steamId, accessToken);

            Dictionary<string, object>? resGet = _Sdk.Gametelemetry.GametelemetryOperations
                                                     .ProtectedGetPlaytimeGameTelemetryV1ProtectedSteamIdsSteamIdPlaytimeGetOp
                                                     .Execute(steamId, accessToken);

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

            string firstEmailToTest = "dummy@example.com";
            string anotherEmailToTest = "anotheremail@dummy.com";

            _Sdk.Gdpr.DataRetrieval.SaveAdminEmailConfigurationOp
                .Execute(new List<string>
                {
                    firstEmailToTest
                }, _Sdk.Namespace);

            List<string>? emails = _Sdk.Gdpr.DataRetrieval.GetAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(emails);

            _Sdk.Gdpr.DataRetrieval.UpdateAdminEmailConfigurationOp
                .Execute(new List<string>() { anotherEmailToTest }, _Sdk.Namespace);

            _Sdk.Gdpr.DataRetrieval.DeleteAdminEmailConfigurationOp
                .Execute(_Sdk.Namespace, new List<string>() { anotherEmailToTest });
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

            //Api.Group.Wrapper.Configuration wConfig = new Api.Group.Wrapper.Configuration(_Sdk);
            //Api.Group.Wrapper.Group wGroup = new Api.Group.Wrapper.Group(_Sdk);

            try
            {
                ModelsGetGroupConfigurationResponseV1? gConfigCheck = _Sdk.Group.Configuration.GetGroupConfigurationAdminV1Op
                    .Execute(initialConfigCode, _Sdk.Namespace);

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

                Api.Group.Model.ModelsCreateGroupConfigurationResponseV1? iConfigResp = _Sdk.Group.Configuration.InitiateGroupConfigurationAdminV1Op
                    .Execute(_Sdk.Namespace);
                Assert.IsNotNull(iConfigResp);

                defaultAdminRoleId = iConfigResp!.GroupAdminRoleId!;
                defaultMemberRoleId = iConfigResp!.GroupMemberRoleId!;
            }

            //Create group configuration
            ModelsCreateGroupConfigurationRequestV1 gcRequest = new ModelsCreateGroupConfigurationRequestV1()
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
                ModelsCreateGroupConfigurationResponseV1? gcResp = _Sdk.Group.Configuration.CreateGroupConfigurationAdminV1Op
                    .Execute(gcRequest, _Sdk.Namespace);
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
            ModelsPublicCreateNewGroupRequestV1 createGroup = new ModelsPublicCreateNewGroupRequestV1()
            {
                GroupName = "CSharp SDK Test Group",
                GroupType = "PUBLIC",
                GroupDescription = "Yeah, anything is welcome here.",
                GroupMaxMember = 100,
                GroupRegion = "us",
                ConfigurationCode = configuration_code
            };

            ModelsGroupResponseV1? cGroup = _Sdk.Group.Group.CreateNewGroupPublicV1Op
                .Execute(createGroup, _Sdk.Namespace);
            Assert.IsNotNull(cGroup);

            string group_id = String.Empty;
            if (cGroup != null)
            {
                Assert.AreEqual("CSharp SDK Test Group", cGroup.GroupName);
                group_id = cGroup.GroupId!;
            }

            //Get single group
            ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                .Execute(group_id, _Sdk.Namespace);
            Assert.IsNotNull(gGroup);
            if (gGroup != null)
                Assert.AreEqual("CSharp SDK Test Group", gGroup.GroupName);

            //Update a group
            ModelsUpdateGroupRequestV1 updateGroup = new ModelsUpdateGroupRequestV1()
            {
                GroupDescription = "Updated description."
            };

            ModelsGroupResponseV1? uGroup = _Sdk.Group.Group.UpdateSingleGroupV1Op
                .Execute(updateGroup, group_id, _Sdk.Namespace);
            Assert.IsNotNull(uGroup);
            if (uGroup != null)
                Assert.AreEqual("Updated description.", uGroup.GroupDescription);

            //Delete a group
            _Sdk.Group.Group.DeleteGroupPublicV1Op
                .Execute(group_id, _Sdk.Namespace);

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                    .Execute(group_id, _Sdk.Namespace);
            });

            //Delete group configuration
            _Sdk.Group.Configuration.DeleteGroupConfigurationV1Op
                .Execute(configuration_code, _Sdk.Namespace);
        }
        
        [Test]
        public void IamServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string user_name = ("csharpsdk_" + Helper.GenerateRandomId(8));
            string user_password = Helper.GenerateRandomPassword(10);
            string user_email = (user_name + "@dummy.com");
            string user_id = String.Empty;

            //Create user
            AccountCreateUserRequestV4 newUser = new AccountCreateUserRequestV4()
            {
                AuthType = "EMAILPASSWD",
                EmailAddress = user_email,
                Password = user_password,
                DisplayName = "CSharp Server SDK Test",
                Username = user_name,
                Country = "ID",
                DateOfBirth = "1995-01-10"
            };

            AccountCreateUserResponseV4? cuResp = _Sdk.Iam.UsersV4.PublicCreateUserV4Op
                .Execute(newUser, _Sdk.Namespace);
            Assert.IsNotNull(cuResp);
            if (cuResp != null)
            {
                Assert.AreEqual(user_email, cuResp.EmailAddress);
                user_id = cuResp.UserId!;
            }

            //Get the user
            ModelUserResponse? gUser = _Sdk.Iam.Users.GetUserByUserIDOp
                .Execute(_Sdk.Namespace, user_id);
            Assert.IsNotNull(gUser);
            Assert.AreEqual("CSharp Server SDK Test", gUser!.DisplayName);

            //Update user
            ModelUserUpdateRequest updateUser = new ModelUserUpdateRequest()
            {
                DateOfBirth = "1996-01-10"
            };

            ModelUserResponse? uuResp = _Sdk.Iam.Users.UpdateUserOp
                .Execute(updateUser, _Sdk.Namespace, user_id);
            Assert.IsNotNull(uuResp);
            if (uuResp != null)
                Assert.AreEqual("1996-01-10", uuResp.DateOfBirth?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            //Delete user
            _Sdk.Iam.Users.DeleteUserOp.Execute(_Sdk.Namespace, user_id);

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                ModelUserResponse? gUser = _Sdk.Iam.Users.GetUserByUserIDOp
                    .Execute(_Sdk.Namespace, user_id);
            });
        }
        
        [Test]
        public void LeaderboardServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

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

            ModelsLeaderboardConfigReq? cLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.CreateLeaderboardConfigurationAdminV1Op
                .Execute(newLeaderboard, _Sdk.Namespace);
            Assert.IsNotNull(cLeaderboard);
            if (cLeaderboard != null)
                Assert.AreEqual("CSharp SDK Leaderboard Test", cLeaderboard.Name!);

            //Get a leaderboard
            ModelsGetLeaderboardConfigResp? gLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);
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

            ModelsGetLeaderboardConfigResp? uLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.UpdateLeaderboardConfigurationAdminV1Op
                .Execute(updateLeaderboard, leaderboard_code, _Sdk.Namespace);
            Assert.IsNotNull(uLeaderboard);
            if (uLeaderboard != null)
                Assert.AreEqual(40, uLeaderboard.SeasonPeriod!);

            //Delete a leaderboard
            _Sdk.Leaderboard.LeaderboardConfiguration.DeleteLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);

            //Finally, recheck if the data is truly deleted.
            ModelsGetLeaderboardConfigResp? dcLeaderboard = _Sdk.Leaderboard.LeaderboardConfiguration.GetLeaderboardConfigurationAdminV1Op
                .Execute(leaderboard_code, _Sdk.Namespace);
            Assert.IsNotNull(dcLeaderboard);
            Assert.IsTrue(dcLeaderboard!.IsDeleted!);
        }

        [Test]
        public void PlatformServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

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

            StoreInfo? cStore = _Sdk.Platform.Store.CreateStoreOp
                .SetBody(createStore)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(cStore);
            if (cStore != null)
            {
                Assert.AreEqual("CSharp SDK Store Test", cStore.Title);
                store_id = cStore.StoreId!;
            }

            //Get a store
            StoreInfo? gStore = _Sdk.Platform.Store.GetStoreOp
                .Execute(_Sdk.Namespace, store_id);
            Assert.IsNotNull(gStore);
            if (gStore != null)
                Assert.AreEqual("CSharp SDK Store Test", gStore.Title);

            //Update a store
            StoreUpdate updateStore = new StoreUpdate()
            {
                Description = "Updated description."
            };
            StoreInfo? cStoreUpdate = _Sdk.Platform.Store.UpdateStoreOp
                .SetBody(updateStore)
                .Execute(_Sdk.Namespace, store_id);
            Assert.IsNotNull(cStoreUpdate);
            if (cStoreUpdate != null)
                Assert.AreEqual("Updated description.", cStoreUpdate.Description);

            //Delete a store
            StoreInfo? dStore = _Sdk.Platform.Store.DeleteStoreOp
                .Execute(_Sdk.Namespace, store_id);
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

            //Create a session
            ModelsCreateSessionRequest createSession = new ModelsCreateSessionRequest()
            {
                SessionType = "p2p",
                GameVersion = "0.3.0",
                Namespace = _Sdk.Namespace,
                Username = usernameToTest,
                GameSessionSetting = new ModelsGameSessionSetting()
                {
                    Mode = "deathmatch",
                    AllowJoinInProgress = true,
                    MapName = "CSharp SDK Integration Test",
                    MaxPlayer = 100
                }
            };

            ModelsSessionResponse? cResp = _Sdk.Sessionbrowser.Session.CreateSessionOp
                .Execute(createSession, _Sdk.Namespace);
            Assert.IsNotNull(cResp);
            if (cResp != null)
            {
                Assert.AreEqual(usernameToTest, cResp.Username!);
                session_id = cResp.SessionId!;
            }

            //Get a session
            ModelsSessionResponse? gResp = _Sdk.Sessionbrowser.Session.GetSessionOp
                .Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(gResp);
            if (gResp != null)
                Assert.AreEqual("0.3.0", gResp.GameVersion!);

            //Update a session
            ModelsUpdateSessionRequest updateSession = new ModelsUpdateSessionRequest()
            {
                GameMaxPlayer = 150
            };
            ModelsSessionResponse? uResp = _Sdk.Sessionbrowser.Session.UpdateSessionOp
                .Execute(updateSession, _Sdk.Namespace, session_id);
            Assert.IsNotNull(uResp);
            if (uResp != null)
                Assert.AreEqual(150, uResp.GameSessionSetting!.MaxPlayer!);

            //Delete a session
            ModelsSessionResponse? dResp = _Sdk.Sessionbrowser.Session.DeleteSessionOp
                .Execute(_Sdk.Namespace, session_id);
            Assert.IsNotNull(uResp);
        }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string stat_code = "csharpserversdkteststat";

            //Create a statistic
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
                .SetBody(createStat)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", cStat.Name);

            //Get a statistic
            StatInfo? gStat = _Sdk.Social.StatConfiguration.GetStatOp
                .Execute(_Sdk.Namespace, stat_code);
            Assert.IsNotNull(gStat);
            if (gStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", gStat.Name);

            //Update a statistic
            StatUpdate updateStat = new StatUpdate()
            {
                Description = "Updated description."
            };

            StatInfo? uStat = _Sdk.Social.StatConfiguration.UpdateStatOp
                .SetBody(updateStat)
                .Execute(_Sdk.Namespace, stat_code);
            Assert.IsNotNull(uStat);
            if (uStat != null)
                Assert.AreEqual("Updated description.", uStat.Description);

            //Delete a statistic
            _Sdk.Social.StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code);
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

            //Create a tag
            ModelsCreateTagRequest createTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name
            };
            ModelsCreateTagResponse? cTag = _Sdk.Ugc.AdminTag.AdminCreateTagOp
                .Execute(createTag, _Sdk.Namespace);
            Assert.IsNotNull(cTag);
            if (cTag != null)
            {
                Assert.AreEqual(tag_name, cTag.Tag);
                tag_id = cTag.Id!;
            }

            //Get tags
            ModelsPaginatedGetTagResponse? gTag = _Sdk.Ugc.AdminTag.AdminGetTagOp
                .SetOffset(0)
                .SetLimit(10)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(gTag);

            //Update a tag
            ModelsCreateTagRequest updateTag = new ModelsCreateTagRequest()
            {
                Tag = tag_name_u
            };
            ModelsCreateTagResponse? uTag = _Sdk.Ugc.AdminTag.AdminUpdateTagOp
                .Execute(updateTag, _Sdk.Namespace, tag_id);
            Assert.IsNotNull(uTag);
            if (uTag != null)
                Assert.AreEqual(tag_name_u, uTag.Tag);

            //Delete a tag
            _Sdk.Ugc.AdminTag.AdminDeleteTagOp
                .Execute(_Sdk.Namespace, tag_id);
        }
    }
}