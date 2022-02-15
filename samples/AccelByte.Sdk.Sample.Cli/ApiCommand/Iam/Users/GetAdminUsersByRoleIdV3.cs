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
    [SdkConsoleCommand("iam","getadminusersbyroleidv3")]
    public class GetAdminUsersByRoleIdV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "GetAdminUsersByRoleIdV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public long? After { get; set; }

        [SdkCommandArgument("before")]
        public long? Before { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public GetAdminUsersByRoleIdV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            GetAdminUsersByRoleIdV3 operation = new GetAdminUsersByRoleIdV3(
                Namespace,                
                RoleId,                
                After,                
                Before,                
                Limit                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelGetUsersResponseWithPaginationV3? response = wrapper.GetAdminUsersByRoleIdV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}