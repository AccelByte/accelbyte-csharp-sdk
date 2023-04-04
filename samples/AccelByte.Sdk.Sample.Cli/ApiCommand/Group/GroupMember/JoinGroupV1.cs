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
    [SdkConsoleCommand("group", "joingroupv1")]
    public class JoinGroupV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "JoinGroupV1"; } }

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public JoinGroupV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupMember wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupMember(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.JoinGroupV1.Builder;





            JoinGroupV1 operation = opBuilder.Build(
                GroupId,
                Namespace
            );


            AccelByte.Sdk.Api.Group.Model.ModelsJoinGroupResponseV1? response = wrapper.JoinGroupV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}