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
    [SdkConsoleCommand("iam","adminsearchusersv2")]
    public class AdminSearchUsersV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminSearchUsersV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("displayName")]
        public string? DisplayName { get; set; }

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("loginId")]
        public string? LoginId { get; set; }

        [SdkCommandArgument("platformUserId")]
        public string? PlatformUserId { get; set; }

        [SdkCommandArgument("roleId")]
        public string? RoleId { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public AdminSearchUsersV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminSearchUsersV2 operation = new AdminSearchUsersV2(
                Namespace,                
                After,                
                Before,                
                DisplayName,                
                Limit,                
                LoginId,                
                PlatformUserId,                
                RoleId,                
                UserId,                
                PlatformId                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelSearchUsersByPlatformIDResponse? response = wrapper.AdminSearchUsersV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}