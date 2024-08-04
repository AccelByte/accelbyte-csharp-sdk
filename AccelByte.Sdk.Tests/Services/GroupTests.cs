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
using AccelByte.Sdk.Core.Util;

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

            DisableRetry();

            string initialConfigCode = "initialConfigurationCode";
            string configuration_code = $"csExtendSdkConfigCode";
            string groupName = "CSharp Extend SDK Test Group";
            string defaultAdminRoleId = String.Empty;
            string defaultMemberRoleId = String.Empty;

            try
            {
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

            string group_id = "";
            try
            {
                try
                {
                    //Look if current user is joined in any group
                    //this is for fallback routine in case user is belong to any group before this test is executed.

                    var groupInfoResponse = _Sdk.Group.GroupMember.GetUserGroupInformationPublicV2Op
                       .SetOffset(0)
                       .SetLimit(10)
                       .Execute(_Sdk.Namespace);
                    if (groupInfoResponse != null && groupInfoResponse.Data != null)
                    {
                        foreach (var info in groupInfoResponse.Data)
                        {
                            _Sdk.Group.GroupMember.LeaveGroupPublicV2Op
                                .Execute(info.GroupId!, _Sdk.Namespace);
                        }
                    }
                }
                catch (Exception x)
                {
                    ModelErrorResponse? mer = System.Text.Json.JsonSerializer.Deserialize<ModelErrorResponse>(x.Message);
                    if (mer == null)
                        throw new Exception("Failed to parse error response. Payload was `" + x.Message + "`.");
                    if (mer.ErrorCode != 73034) //skip user does not belong to any group
                        throw new Exception(mer.ErrorMessage, x);
                }

                #region Create a group
                ModelsPublicCreateNewGroupRequestV1 createGroup = new ModelsPublicCreateNewGroupRequestV1()
                {
                    GroupName = groupName,
                    GroupType = "PUBLIC",
                    GroupDescription = "Yeah, anyone is welcome here.",
                    GroupMaxMember = 100,
                    GroupRegion = "us",
                    ConfigurationCode = configuration_code
                };

                ModelsGroupResponseV1? cGroup = _Sdk.Group.Group.CreateNewGroupPublicV1Op
                    .Execute(createGroup, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(cGroup);

                if (cGroup != null)
                {
                    Assert.AreEqual(groupName, cGroup.GroupName);
                    group_id = cGroup.GroupId!;
                }

                Wait();

                #region Get single group
                ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                    .Execute(group_id, _Sdk.Namespace);
                #endregion
                Assert.IsNotNull(gGroup);
                if (gGroup != null)
                    Assert.AreEqual(groupName, gGroup.GroupName);

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
            }
            finally
            {
                if (group_id != "")
                {
                    #region Delete a group
                    _Sdk.Group.Group.DeleteGroupPublicV1Op
                        .Execute(group_id, _Sdk.Namespace);
                    #endregion

                    Wait();

                    //Finally, recheck if the data is truly deleted.
                    HttpResponseException? hrx = Assert.Throws<HttpResponseException>(() =>
                    {
                        DisableRetry();
                        ModelsGroupResponseV1? gGroup = _Sdk.Group.Group.GetSingleGroupPublicV1Op
                            .Execute(group_id, _Sdk.Namespace);
                    });
                }

                #region Delete group configuration
                _Sdk.Group.Configuration.DeleteGroupConfigurationV1Op
                    .Execute(configuration_code, _Sdk.Namespace);
                #endregion
            }
        }
    }
}
