using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","updatereward")]
    public class UpdateRewardCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateReward"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("rewardId")]
        public string RewardId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RewardUpdate Body { get; set; } = new RewardUpdate();
                
        public UpdateRewardCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Reward wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Reward(_SDK);

            UpdateReward operation = new UpdateReward(
                Namespace,                
                RewardId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.RewardInfo? response = wrapper.UpdateReward(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}