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
    [SdkConsoleCommand("seasonpass","getreward")]
    public class GetRewardCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "GetReward"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        public GetRewardCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Reward wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Reward(_SDK);

            GetReward operation = new GetReward(
                Code,                
                Namespace,                
                SeasonId                
            );            
            
            AccelByte.Sdk.Api.Seasonpass.Model.RewardInfo? response = wrapper.GetReward(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}