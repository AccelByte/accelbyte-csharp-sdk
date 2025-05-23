// Copyright (c) 2022-2025 AccelByte Inc. All Rights Reserved.
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
using AccelByte.Sdk.Tests.Integration;
using NuGet.Frameworks;
using System.Threading;
using System.Diagnostics;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class IAMTests : BaseServiceTests
    {
        public IAMTests() : base(true) { }

        protected int FindAndCheckResourceActionFromRole(AccelByteSDK sdk, string roleId, string resourceToCheck)
        {
            var permissions = sdk.Iam.OverrideRoleConfigV3.AdminGetRoleNamespacePermissionV3Op
                    .Execute(sdk.Namespace, roleId);
            if (permissions == null)
                throw new Exception("Role's permissions object is null");

            int resultAction = -1;
            foreach (var permission in permissions!.Permissions!)
            {
                if (permission.Resource! == resourceToCheck)
                {
                    resultAction = permission.Action!.Value;
                    break;
                }
            }

            return resultAction;
        }

        [Test]
        public void CreateUserV4Tests()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string user_name = ("csharpsdk_" + Helper.GenerateRandomId(8));
            string user_password = Helper.GenerateRandomPassword(10);
            string user_email = (user_name + "@dummy.com");
            string user_id = "";

            DisableRetry();

            #region Create a user (V3)
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
            #endregion
            Assert.IsNotNull(response);
            if (response != null)
            {
                Assert.AreEqual(user_email, response.EmailAddress);
                user_id = response.UserId!;
            }

            _Sdk.Iam.Users.AdminDeleteUserInformationV3Op
                .Execute(_Sdk.Namespace, user_id);

            ResetPolicy();
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
            string user_id = "";

            #region Create a user
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
            #endregion
            Assert.IsNotNull(cuResp);
            if (cuResp != null)
            {
                Assert.AreEqual(user_email, cuResp.EmailAddress);
                user_id = cuResp.UserId!;
            }

            #region Get user data by user id
            ModelUserResponseV3? gUser = _Sdk.Iam.Users.AdminGetUserByUserIdV3Op
                .Execute(_Sdk.Namespace, user_id);
            #endregion
            Assert.IsNotNull(gUser);
            Assert.AreEqual("CSharp Extend SDK Test", gUser!.DisplayName);

            #region Update a user
            ModelUserUpdateRequestV3 updateUser = new ModelUserUpdateRequestV3()
            {
                DateOfBirth = "1996-01-10"
            };

            ModelUserResponseV3? uuResp = _Sdk.Iam.UsersV4.AdminUpdateUserV4Op
                .Execute(updateUser, _Sdk.Namespace, user_id);
            #endregion
            Assert.IsNotNull(uuResp);
            if (uuResp != null)
                Assert.AreEqual("1996-01-10", uuResp.DateOfBirth?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));

            #region Delete a user
            _Sdk.Iam.Users.AdminDeleteUserInformationV3Op.Execute(_Sdk.Namespace, user_id);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                ModelUserResponseV3? gUser = _Sdk.Iam.Users.AdminGetUserByUserIdV3Op
                    .Execute(_Sdk.Namespace, user_id);
            });
        }

        [Test]
        public void RoleOverrideTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;

            string roleIdentityToUpdate = "USER";
            string resourceToCheck = "NAMESPACE:{namespace}:PROFILE";
            int actionToCheck = 7;
            int updatedActionToCheck = 2;
            int checkCount = 20;
            int checkInterval = 1000;

            DisableRetry();

            var roles = _Sdk.Iam.Roles.AdminGetRolesV4Op
                .SetAdminRole(false)
                .Execute();
            Assert.IsNotNull(roles);

            string userRoleId = "";
            foreach (var role in roles!.Data!)
            {
                if (role.RoleName!.ToUpper() == roleIdentityToUpdate)
                {
                    userRoleId = role.RoleId!;
                    break;
                }
            }

            Assert.AreNotEqual("", userRoleId);
            try
            {
                int oAction = FindAndCheckResourceActionFromRole(_Sdk, userRoleId, resourceToCheck);
                Assert.AreEqual(actionToCheck, oAction);

                //Do role override
                var updateResponse = _Sdk.Iam.OverrideRoleConfigV3.AdminUpdateRoleOverrideConfigV3Op
                    .Execute(new ModelRoleOverrideUpdateRequest()
                    {
                        Exclusions = [
                            new AccountcommonOverrideRolePermission()
                            {
                                Resource = resourceToCheck,
                                Actions = [1, 4]
                            }
                        ]
                    }, _Sdk.Namespace, roleIdentityToUpdate);
                Assert.IsNotNull(updateResponse);

                //Activate role override
                var activateResponse = _Sdk.Iam.OverrideRoleConfigV3.AdminChangeRoleOverrideConfigStatusV3Op
                    .Execute(new ModelRoleOverrideStatsUpdateRequest()
                    {
                        Active = true
                    }, _Sdk.Namespace, roleIdentityToUpdate);
                Assert.IsNotNull(activateResponse);
                if (activateResponse != null)
                    Assert.IsTrue(activateResponse.Active!);

                try
                {
                    bool uValid = false;
                    int currentCount = 0;
                    while (currentCount < checkCount)
                    {
                        Debug.WriteLine($"Checking updated permissions [{currentCount + 1}]");
                        int uAction = FindAndCheckResourceActionFromRole(_Sdk, userRoleId, resourceToCheck);
                        if (uAction == updatedActionToCheck)
                        {
                            uValid = true;
                            break;
                        }

                        currentCount++;
                        Thread.Sleep(checkInterval);
                    }

                    Assert.IsTrue(uValid);
                }
                finally
                {
                    //Deactivate role override
                    _Sdk.Iam.OverrideRoleConfigV3.AdminChangeRoleOverrideConfigStatusV3Op
                        .Execute(new ModelRoleOverrideStatsUpdateRequest()
                        {
                            Active = false
                        }, _Sdk.Namespace, roleIdentityToUpdate);
                }
            }
            finally
            {
                ResetPolicy();
            }
        }
    }
}
