// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using NUnit.Framework;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using AccelByte.Sdk.Api.Group.Model;

using AccelByte.Sdk.Tests.Model;

namespace AccelByte.Sdk.Tests.Services
{
    [TestFixture(Category = "FluentIntegration")]
    [Explicit]
    public class GroupTests : BaseServiceTests
    {
        public GroupTests() : base(true) { }

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

            try
            {
                DisableRetry();
                ModelsGetGroupConfigurationResponseV1? gConfigCheck = _Sdk.Group.Configuration.GetGroupConfigurationAdminV1Op
                    .Execute(initialConfigCode, _Sdk.Namespace);
                if (gConfigCheck != null)
                {
                    //Initial config exists. Grab the role identifiers.
                    defaultAdminRoleId = gConfigCheck.GroupAdminRoleId!;
                    defaultMemberRoleId = gConfigCheck.GroupMemberRoleId!;
                }
                else
                    Assert.Fail("ModelsGetGroupConfigurationResponseV1 null");
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

                ModelsCreateGroupConfigurationResponseV1? iConfigResp = _Sdk.Group.Configuration.InitiateGroupConfigurationAdminV1Op
                    .Execute(_Sdk.Namespace);
                Assert.IsNotNull(iConfigResp);

                defaultAdminRoleId = iConfigResp!.GroupAdminRoleId!;
                defaultMemberRoleId = iConfigResp!.GroupMemberRoleId!;
            }

            try
            {
                DisableRetry();
                #region Create group configuration
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
                #endregion
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

            #region Create a group
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
            #endregion
            Assert.IsNotNull(cGroup);

            string group_id = String.Empty;
            if (cGroup != null)
            {
                Assert.AreEqual("CSharp SDK Test Group", cGroup.GroupName);
                group_id = cGroup.GroupId!;
            }

            #region Get single group
            ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                .Execute(group_id, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(gGroup);
            if (gGroup != null)
                Assert.AreEqual("CSharp SDK Test Group", gGroup.GroupName);

            #region Update a group
            ModelsUpdateGroupRequestV1 updateGroup = new ModelsUpdateGroupRequestV1()
            {
                GroupDescription = "Updated description."
            };

            ModelsGroupResponseV1? uGroup = _Sdk.Group.Group.UpdateSingleGroupV1Op
                .Execute(updateGroup, group_id, _Sdk.Namespace);
            #endregion
            Assert.IsNotNull(uGroup);
            if (uGroup != null)
                Assert.AreEqual("Updated description.", uGroup.GroupDescription);

            #region Delete a group
            _Sdk.Group.Group.DeleteGroupPublicV1Op
                .Execute(group_id, _Sdk.Namespace);
            #endregion

            //Finally, recheck if the data is truly deleted.
            HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
            {
                DisableRetry();
                ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                    .Execute(group_id, _Sdk.Namespace);
            });

            #region Delete group configuration
            _Sdk.Group.Configuration.DeleteGroupConfigurationV1Op
                .Execute(configuration_code, _Sdk.Namespace);
            #endregion
        }
    }
}
