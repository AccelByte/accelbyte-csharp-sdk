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
    [SdkConsoleCommand("group","kickgroupmemberpublicv1")]
    public class KickGroupMemberPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "KickGroupMemberPublicV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public KickGroupMemberPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupMember wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupMember(_SDK);

            KickGroupMemberPublicV1 operation = new KickGroupMemberPublicV1(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsKickGroupMemberResponseV1? response = wrapper.KickGroupMemberPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}