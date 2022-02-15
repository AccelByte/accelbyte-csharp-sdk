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
    [SdkConsoleCommand("iam","admingetuserloginhistoriesv3")]
    public class AdminGetUserLoginHistoriesV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetUserLoginHistoriesV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("after")]
        public double? After { get; set; }

        [SdkCommandArgument("before")]
        public double? Before { get; set; }

        [SdkCommandArgument("limit")]
        public double? Limit { get; set; }

        public AdminGetUserLoginHistoriesV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminGetUserLoginHistoriesV3 operation = new AdminGetUserLoginHistoriesV3(
                Namespace,                
                UserId,                
                After,                
                Before,                
                Limit                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelLoginHistoriesResponse? response = wrapper.AdminGetUserLoginHistoriesV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}