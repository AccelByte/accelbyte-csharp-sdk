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
    [SdkConsoleCommand("group","updatememberrolepublicv1")]
    public class UpdateMemberRolePublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "UpdateMemberRolePublicV1"; } }

        [SdkCommandArgument("memberRoleId")]
        public string MemberRoleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAssignRoleToMemberRequestV1 Body { get; set; } = new ModelsAssignRoleToMemberRequestV1();
                
        public UpdateMemberRolePublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupRoles wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupRoles(_SDK);

            UpdateMemberRolePublicV1 operation = new UpdateMemberRolePublicV1(
                MemberRoleId,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Group.Model.ModelsGetUserGroupInformationResponseV1? response = wrapper.UpdateMemberRolePublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}