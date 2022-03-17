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

using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Api.Social.Wrapper;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Integration
{
    [TestFixture(Category = "Integration")]
    [Explicit]
    public class ClientIntegrationTests : BaseIntegrationTest
    {
        [OneTimeSetUp]
        public void Startup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .SetConfigRepository(IntegrationTestConfigRepository.Admin)
                .UseInMemoryTokenRepository()
                .EnableLog()
                .Build();
            _Sdk.LoginClient();
        }

        [OneTimeTearDown]
        public void End()
        {
            _Sdk?.Logout();
        }

        [Test]        
        public void SocialServiceUserStatTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string? user_login_id = Environment.GetEnvironmentVariable("AB_ADMIN_USERNAME");
            if (user_login_id == null)
                throw new Exception("This test requires the value of AB_ADMIN_USERNAME env var. Please specify one.");
            string stat_code = "cs-server-sdk-test";

            StatConfiguration wStatConfig = new StatConfiguration(_Sdk);
            UserStatistic wUserStat = new UserStatistic(_Sdk);

            Api.Iam.Wrapper.Users wUsers = new Api.Iam.Wrapper.Users(_Sdk);
            Api.Iam.Model.ModelPublicUserResponse? uResp = wUsers.GetUserByLoginID(
                Api.Iam.Operation.GetUserByLoginID.Builder
                .SetLoginId(user_login_id)
                .Build(_Sdk.Namespace));
            Assert.IsNotNull(uResp);
            string user_id = uResp!.UserId!;    

            wUserStat.CreateUserStatItem(CreateUserStatItem.Builder
                .Build(_Sdk.Namespace, stat_code, user_id));

            UserStatItemPagingSlicedResult? gsResult = wUserStat.GetUserStatItems(GetUserStatItems.Builder
                .SetLimit(10)
                .SetOffset(0)
                .SetStatCodes(stat_code)
                .Build(_Sdk.Namespace, user_id));
            Assert.IsNotNull(gsResult);
            if (gsResult != null)
                Assert.Greater(gsResult.Data!.Count, 0);

            StatItemIncResult? incResult = wUserStat.IncUserStatItemValue(IncUserStatItemValue.Builder
                .SetBody(new StatItemInc()
                {
                    Inc = 5
                })
                .Build(_Sdk.Namespace, stat_code, user_id));
            Assert.IsNotNull(incResult);

            wUserStat.DeleteUserStatItems(DeleteUserStatItems.Builder
                .Build(_Sdk.Namespace, stat_code, user_id));
        }
    }
}