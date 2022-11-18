// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Achievement.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class AchievementTests : BaseServiceTests
    {
        public AchievementTests() : base(true) { }

        [Test]
        public void AchievementServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string achievement_code = "csharp-sdk-test";

            #region Create an achievement
            ModelsAchievementRequest newAchievement = new ModelsAchievementRequest()
            {
                AchievementCode = achievement_code,
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
            #endregion
            Assert.IsNotNull(cResp);
            Assert.AreEqual(cResp?.AchievementCode!, achievement_code);

            #region Updating achievement
            ModelsAchievementUpdateRequest updateAchievement = new ModelsAchievementUpdateRequest()
            {
                GoalValue = 2000.0
            };

            ModelsAchievementResponse? uResp = _Sdk.Achievement.Achievements.AdminUpdateAchievementOp
                .Execute(updateAchievement, achievement_code, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(uResp);
            Assert.AreEqual(uResp?.GoalValue!, 2000.0);

            #region Retrieve achievement by code
            ModelsAchievementResponse? rResp = _Sdk.Achievement.Achievements.AdminGetAchievementOp
                .Execute(achievement_code, _Sdk.Namespace);
            Assert.IsNotNull(rResp);
            #endregion
            Assert.AreEqual(rResp?.GoalValue!, 2000.0);
            Assert.AreEqual(rResp?.Name!["en"], "CSharp Server SDK Test");

            #region Get all achievements
            ModelsPaginatedAchievementResponse? gaResp = _Sdk.Achievement.Achievements.AdminListAchievementsOp
                .SetLimit(100)
                .SetOffset(0)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gaResp);
            Assert.Greater(gaResp?.Data?.Count, 0);

            #region Delete an achievement
            _Sdk.Achievement.Achievements.AdminDeleteAchievementOp.Execute(achievement_code, _Sdk.Namespace);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                ModelsAchievementResponse? dResp = _Sdk.Achievement.Achievements.AdminGetAchievementOp
                    .Execute("csharp-sdk-test", _Sdk.Namespace);
            });
        }
    }
}