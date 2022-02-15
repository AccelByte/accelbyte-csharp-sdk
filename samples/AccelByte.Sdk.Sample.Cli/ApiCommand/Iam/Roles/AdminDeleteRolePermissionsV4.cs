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
    [SdkConsoleCommand("iam","admindeleterolepermissionsv4")]
    public class AdminDeleteRolePermissionsV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminDeleteRolePermissionsV4"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<string> Body { get; set; } = new List<string>();
                
        public AdminDeleteRolePermissionsV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            AdminDeleteRolePermissionsV4 operation = new AdminDeleteRolePermissionsV4(
                RoleId,                
                Body                
            );            
            
            wrapper.AdminDeleteRolePermissionsV4(operation);
            return String.Empty;
        }
    }
}