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
    [SdkConsoleCommand("group","getusergroupinformationpublicv1")]
    public class GetUserGroupInformationPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "GetUserGroupInformationPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetUserGroupInformationPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupMember wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupMember(_SDK);

            GetUserGroupInformationPublicV1 operation = new GetUserGroupInformationPublicV1(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGetUserGroupInformationResponseV1? response = wrapper.GetUserGroupInformationPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}