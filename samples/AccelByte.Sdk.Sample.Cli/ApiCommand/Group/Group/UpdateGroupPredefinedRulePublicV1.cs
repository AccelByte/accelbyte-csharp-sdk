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
    [SdkConsoleCommand("group","updategrouppredefinedrulepublicv1")]
    public class UpdateGroupPredefinedRulePublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "UpdateGroupPredefinedRulePublicV1"; } }

        [SdkCommandArgument("allowedAction")]
        public string AllowedAction { get; set; } = String.Empty;

        [SdkCommandArgument("groupId")]
        public string GroupId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateGroupPredefinedRuleRequestV1 Body { get; set; } = new ModelsUpdateGroupPredefinedRuleRequestV1();
                
        public UpdateGroupPredefinedRulePublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Group wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Group(_SDK);

            UpdateGroupPredefinedRulePublicV1 operation = new UpdateGroupPredefinedRulePublicV1(
                AllowedAction,                
                GroupId,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGroupResponseV1? response = wrapper.UpdateGroupPredefinedRulePublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}