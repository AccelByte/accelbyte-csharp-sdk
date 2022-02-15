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
    [SdkConsoleCommand("iam","admingetrolev4")]
    public class AdminGetRoleV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetRoleV4"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        public AdminGetRoleV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            AdminGetRoleV4 operation = new AdminGetRoleV4(
                RoleId                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelRoleV4Response? response = wrapper.AdminGetRoleV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}