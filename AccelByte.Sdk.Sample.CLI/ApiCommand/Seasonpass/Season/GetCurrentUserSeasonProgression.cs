using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","getcurrentuserseasonprogression")]
    public class GetCurrentUserSeasonProgressionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "GetCurrentUserSeasonProgression"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public GetCurrentUserSeasonProgressionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            GetCurrentUserSeasonProgression operation = new GetCurrentUserSeasonProgression(
                Namespace,                
                UserId                
            );            

            AccelByte.Sdk.Api.Seasonpass.Model.UserSeasonSummary? response = wrapper.GetCurrentUserSeasonProgression(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}