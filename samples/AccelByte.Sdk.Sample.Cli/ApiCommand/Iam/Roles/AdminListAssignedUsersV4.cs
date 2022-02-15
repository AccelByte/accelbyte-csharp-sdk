using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","adminlistassignedusersv4")]
    public class AdminListAssignedUsersV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminListAssignedUsersV4"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public AdminListAssignedUsersV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            AdminListAssignedUsersV4 operation = new AdminListAssignedUsersV4(
                RoleId,                
                After,                
                Before,                
                Limit                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelListAssignedUsersV4Response? response = wrapper.AdminListAssignedUsersV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}