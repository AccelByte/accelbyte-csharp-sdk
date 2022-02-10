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
    [SdkConsoleCommand("group","updatememberroleadminv1")]
    public class UpdateMemberRoleAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Group"; } }

        public string OperationName{ get { return "UpdateMemberRoleAdminV1"; } }

        [SdkCommandArgument("memberRoleId")]
        public string MemberRoleId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateMemberRoleRequestV1 Body { get; set; } = new ModelsUpdateMemberRoleRequestV1();
                
        public UpdateMemberRoleAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.GroupRoles wrapper = new AccelByte.Sdk.Api.Group.Wrapper.GroupRoles(_SDK);

            UpdateMemberRoleAdminV1 operation = new UpdateMemberRoleAdminV1(
                MemberRoleId,                
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Group.Model.ModelsUpdateMemberRoleResponseV1? response = wrapper.UpdateMemberRoleAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}