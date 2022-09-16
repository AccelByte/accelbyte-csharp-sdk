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

using AccelByte.Sdk.Api.Iam.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class IAMTests : BaseServiceTests
    {
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

            #region Create a user
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
            #endregion
            Assert.IsNotNull(cuResp);
            if (cuResp != null)
            {
                Assert.AreEqual(user_email, cuResp.EmailAddress);
                user_id = cuResp.UserId!;
            }

            #region Get user data by user id
            ModelUserResponse? gUser = _Sdk.Iam.Users.GetUserByUserIDOp
                .Execute(_Sdk.Namespace, user_id);
            #endregion
            Assert.IsNotNull(gUser);
            Assert.AreEqual("CSharp Server SDK Test", gUser!.DisplayName);

            #region Update a user
            ModelUserUpdateRequest updateUser = new ModelUserUpdateRequest()
            {
                DateOfBirth = "1996-01-10"
            };

            ModelUserResponse? uuResp = _Sdk.Iam.Users.UpdateUserOp
                .Execute(updateUser, _Sdk.Namespace, user_id);
            #endregion
            Assert.IsNotNull(uuResp);
            if (uuResp != null)
                Assert.AreEqual("1996-01-10", uuResp.DateOfBirth?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            #region Delete a user
            _Sdk.Iam.Users.DeleteUserOp.Execute(_Sdk.Namespace, user_id);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                ModelUserResponse? gUser = _Sdk.Iam.Users.GetUserByUserIDOp
                    .Execute(_Sdk.Namespace, user_id);
            });
        }
    }
}
