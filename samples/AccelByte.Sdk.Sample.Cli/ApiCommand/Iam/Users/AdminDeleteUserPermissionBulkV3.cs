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
    [SdkConsoleCommand("iam","admindeleteuserpermissionbulkv3")]
    public class AdminDeleteUserPermissionBulkV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminDeleteUserPermissionBulkV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<ModelPermissionDeleteRequest> Body { get; set; } = new List<ModelPermissionDeleteRequest>();
                
        public AdminDeleteUserPermissionBulkV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminDeleteUserPermissionBulkV3 operation = new AdminDeleteUserPermissionBulkV3(
                Namespace,                
                UserId,                
                Body                
            );            

            wrapper.AdminDeleteUserPermissionBulkV3(operation);
            return String.Empty;
        }
    }
}