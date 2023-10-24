// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Social.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SocialTests : BaseServiceTests
    {
        public SocialTests() : base(true) { }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string stat_code = "csharpserversdkteststat";

            #region Create a stat
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
            #endregion
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", cStat.Name);

            #region Get a stat
            StatInfo? gStat = _Sdk.Social.StatConfiguration.GetStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
            Assert.IsNotNull(gStat);
            if (gStat != null)
                Assert.AreEqual("CSharp Server SDK Test Stat", gStat.Name);

            #region Update a stat
            StatUpdate updateStat = new StatUpdate()
            {
                Description = "Updated description."
            };

            StatInfo? uStat = _Sdk.Social.StatConfiguration.UpdateStatOp
                .SetBody(updateStat)
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
            Assert.IsNotNull(uStat);
            if (uStat != null)
                Assert.AreEqual("Updated description.", uStat.Description);

            #region Delete a stat
            _Sdk.Social.StatConfiguration.DeleteStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
        }
    }

    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SocialTestsWithOAuthClient: BaseServiceTests
    {
        public SocialTestsWithOAuthClient() : base(false) { }

        [Test]
        public void OAuthClientTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string? user_login_id = Environment.GetEnvironmentVariable("AB_USERNAME");
            if (user_login_id == null)
                throw new Exception("This test requires the value of AB_USERNAME env var. Please specify one.");

            user_login_id = UnQuote(user_login_id);
            string stat_code = "cs-server-sdk-test";

            var searchResp = _Sdk.Iam.Users.AdminSearchUserV3Op
                .SetQuery(user_login_id)
                .Execute(_Sdk.Namespace);
            Assert.IsNotNull(searchResp);

            string user_id = searchResp!.Data![0].UserId!;

            _Sdk.Social.UserStatistic.CreateUserStatItemOp
                .Execute(_Sdk.Namespace, stat_code, user_id);

            var gsResult = _Sdk.Social.UserStatistic.GetUserStatItemsOp
                .SetLimit(10)
                .SetOffset(0)
                .SetStatCodes(stat_code)
                .Execute(_Sdk.Namespace, user_id);
            Assert.IsNotNull(gsResult);
            if (gsResult != null)
                Assert.Greater(gsResult.Data!.Count, 0);

            var incResult = _Sdk.Social.UserStatistic.IncUserStatItemValueOp
                .SetBody(new StatItemInc()
                {
                    Inc = 5
                })
                .Execute(_Sdk.Namespace, stat_code, user_id);
            Assert.IsNotNull(incResult);

            _Sdk.Social.UserStatistic.DeleteUserStatItemsOp
                .Execute(_Sdk.Namespace, stat_code, user_id);
        }
    }
}
