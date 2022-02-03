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
    [SdkConsoleCommand("group","deletegrouppredefinedrulepublicv1")]
    public class DeleteGroupPredefinedRulePublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "DeleteGroupPredefinedRulePublicV1"; } }

        [SdkCommandArgument("allowedAction")]
        public string AllowedAction { get; set; } = String.Empty;

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteGroupPredefinedRulePublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            DeleteGroupPredefinedRulePublicV1 operation = new DeleteGroupPredefinedRulePublicV1(
                AllowedAction,                
                GroupId,                
                Namespace                
            );            

            wrapper.DeleteGroupPredefinedRulePublicV1(operation);
            return String.Empty;
        }
    }
}