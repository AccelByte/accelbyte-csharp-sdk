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
    [SdkConsoleCommand("group","invitegrouppublicv1")]
    public class InviteGroupPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "InviteGroupPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public InviteGroupPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupMember wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupMember(_SDK);

            InviteGroupPublicV1 operation = new InviteGroupPublicV1(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsUserInvitationResponseV1? response = wrapper.InviteGroupPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}