// Copyright (c) 2022-2026 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Tests.Integration;
using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class SocialTests : BaseServiceTests
    {
        public SocialTests() : base(true, IntegrationTestConfigRepository.Statistics) { }

        [Test]
        public void SocialServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string stat_code = $"csharpsdktest-{Helper.GenerateRandomAlphabet(6)}";

            #region Create a stat
            StatCreate createStat = new StatCreate()
            {
                Name = "CSharp Extend SDK Test Stat",
                Description = "CSharp extend sdk integration test.",
                StatCode = stat_code,
                SetBy = "SERVER",
                Minimum = 0.0,
                Maximum = 100.0,
                DefaultValue = 50.0,
                IncrementOnly = true,
                SetAsGlobal = false,
                Tags = new List<string>() { "csharp", "extend_sdk", "test" }
            };

            StatInfo? cStat = _Sdk.Social.StatConfiguration.CreateStatOp
                .Execute(createStat, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(cStat);
            if (cStat != null)
                Assert.AreEqual("CSharp Extend SDK Test Stat", cStat.Name);

            #region Get a stat
            StatInfo? gStat = _Sdk.Social.StatConfiguration.GetStatOp
                .Execute(_Sdk.Namespace, stat_code);
            #endregion
            Assert.IsNotNull(gStat);
            if (gStat != null)
                Assert.AreEqual("CSharp Extend SDK Test Stat", gStat.Name);

            #region Update a stat
            StatUpdate updateStat = new StatUpdate()
            {
                Description = "Updated description."
            };

            StatInfo? uStat = _Sdk.Social.StatConfiguration.UpdateStatOp
                .Execute(updateStat, _Sdk.Namespace, stat_code);
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
    public class SocialTestsWithOAuthClient : BaseServiceTests
    {
        public SocialTestsWithOAuthClient() : base(false, IntegrationTestConfigRepository.Statistics) { }

        [Test]
        public void OAuthClientTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            ExistingTestPlayer testPlayer = new ExistingTestPlayer("AB_PLAYER1", true);
            string user_id = testPlayer.UserId;

            string stat_code = $"csharpsdktest-fixstat";

            try
            {
                StatInfo? gStat = _Sdk.Social.StatConfiguration.GetStatOp
                    .Execute(_Sdk.Namespace, stat_code);
            }
            catch (HttpResponseException x)
            {
                ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                if (mer == null)
                    throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");

                if (mer.ErrorCode != 12241)
                    throw new Exception(mer.ErrorMessage, x);

                //If stat does not exists, create it.
                StatCreate createStat = new StatCreate()
                {
                    Name = "CSharp Extend SDK Fixed Test Stat",
                    Description = "CSharp extend sdk integration test.",
                    StatCode = stat_code,
                    SetBy = "SERVER",
                    Minimum = 0.0,
                    Maximum = 100.0,
                    DefaultValue = 50.0,
                    IncrementOnly = true,
                    SetAsGlobal = false,
                    Tags = new List<string>() { "csharp", "extend_sdk", "test" }
                };

                StatInfo? cStat = _Sdk.Social.StatConfiguration.CreateStatOp
                    .Execute(createStat, _Sdk.Namespace);
                Assert.IsNotNull(cStat);
            }

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
                .Execute(new StatItemInc()
                {
                    Inc = 5
                }, _Sdk.Namespace, stat_code, user_id);
            Assert.IsNotNull(incResult);

            _Sdk.Social.UserStatistic.DeleteUserStatItemsOp
                .Execute(_Sdk.Namespace, stat_code, user_id);

            testPlayer.Logout();
        }
    }
}
