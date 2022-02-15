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
    [SdkConsoleCommand("iam","adminadduserrolev4")]
    public class AdminAddUserRoleV4Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminAddUserRoleV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelAddUserRoleV4Request Body { get; set; } = new ModelAddUserRoleV4Request();
                
        public AdminAddUserRoleV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            AdminAddUserRoleV4 operation = new AdminAddUserRoleV4(
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelListUserRolesV4Response? response = wrapper.AdminAddUserRoleV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}