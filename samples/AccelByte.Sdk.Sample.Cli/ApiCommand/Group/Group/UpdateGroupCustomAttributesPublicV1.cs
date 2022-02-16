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
    [SdkConsoleCommand("group","updategroupcustomattributespublicv1")]
    public class UpdateGroupCustomAttributesPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "UpdateGroupCustomAttributesPublicV1"; } }

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateGroupCustomAttributesRequestV1 Body { get; set; } = new ModelsUpdateGroupCustomAttributesRequestV1();
                
        public UpdateGroupCustomAttributesPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            UpdateGroupCustomAttributesPublicV1 operation = new UpdateGroupCustomAttributesPublicV1(
                GroupId,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGroupResponseV1? response = wrapper.UpdateGroupCustomAttributesPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}