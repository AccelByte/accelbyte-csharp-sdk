// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Globalization;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Basic.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class BasicTests : BaseServiceTests
    {
        public BasicTests() : base(true) { }

        [Test]
        public void BasicServiceTests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            try
            {
                DisableRetry();

                //Get user's own profile info, will throw an exception if profile does not exists which is expected.
                UserProfilePrivateInfo? check = _Sdk.Basic.UserProfile.GetMyProfileInfoOp
                    .Execute(_Sdk.Namespace);

                if (check != null)
                {
                    //But if the profile do actually exists, just delete it.
                    UserProfilePrivateInfo? checkDel = _Sdk.Basic.UserProfile.DeleteUserProfileOp
                        .Execute(_Sdk.Namespace, check.UserId!);
                    Assert.IsNotNull(checkDel);
                }
            }
            catch (HttpResponseException x)
            {
                ErrorEntity? error =
                    System.Text.Json.JsonSerializer.Deserialize<ErrorEntity>(x.Message);
                if (error == null)
                    throw new Exception("Response is null");

                if (error.ErrorCode != 11440)
                    Assert.Fail("Unexpected error response from Basic::GetMyProfileInfoOp.");
            }

            #region Create user's own profile info
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
            #endregion
            Assert.IsNotNull(cInfo);
            Assert.AreEqual(cInfo?.FirstName, "Integration Test");

            #region Get user's own profile info
            UserProfilePrivateInfo? ownResp = _Sdk.Basic.UserProfile.GetMyProfileInfoOp
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(ownResp);
            Assert.AreEqual(ownResp?.LastName!, "CSharp Server SDK");
            string userId = ownResp?.UserId!;

            #region Update user's own profile info
            UserProfilePrivateUpdate updateProfile = new UserProfilePrivateUpdate()
            {
                TimeZone = "Asia/Jakarta"
            };

            UserProfilePrivateInfo? updResp = _Sdk.Basic.UserProfile.UpdateMyProfileOp
                .SetBody(updateProfile)
                .Execute(_Sdk.Namespace);
            #endregion
            Assert.IsNotNull(updResp);
            Assert.AreEqual(updResp?.TimeZone, "Asia/Jakarta");

            #region Delete user's own profile info
            UserProfilePrivateInfo? delResp = _Sdk.Basic.UserProfile.DeleteUserProfileOp
                .Execute(_Sdk.Namespace, userId);
            #endregion
            Assert.IsNotNull(delResp);
        }
    }
}
