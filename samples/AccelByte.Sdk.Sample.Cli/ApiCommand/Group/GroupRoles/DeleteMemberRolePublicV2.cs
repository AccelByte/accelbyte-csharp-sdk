// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group", "deletememberrolepublicv2")]
    public class DeleteMemberRolePublicV2Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "DeleteMemberRolePublicV2"; } }

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("memberRoleId")]
        public string MemberRoleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsRemoveRoleFromMemberRequestV1 Body { get; set; } = new ModelsRemoveRoleFromMemberRequestV1();

        public DeleteMemberRolePublicV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupRoles wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupRoles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.DeleteMemberRolePublicV2.Builder;





            DeleteMemberRolePublicV2 operation = opBuilder.Build(
                Body,
                GroupId,
                MemberRoleId,
                Namespace
            );


            wrapper.DeleteMemberRolePublicV2(operation);
            return String.Empty;
        }
    }
}