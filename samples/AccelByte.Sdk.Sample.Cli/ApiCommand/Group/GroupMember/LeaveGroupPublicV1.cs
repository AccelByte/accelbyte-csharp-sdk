// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group","leavegrouppublicv1")]
    public class LeaveGroupPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "LeaveGroupPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public LeaveGroupPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupMember wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupMember(_SDK);

            LeaveGroupPublicV1 operation = new LeaveGroupPublicV1(
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsLeaveGroupResponseV1? response = wrapper.LeaveGroupPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}