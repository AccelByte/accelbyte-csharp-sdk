// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("seasonpass","updatereward")]
    public class UpdateRewardCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "UpdateReward"; } }

        [SdkCommandArgument("code")]
        public string Code { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public RewardUpdate Body { get; set; } = new RewardUpdate();
                
        public UpdateRewardCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Reward wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Reward(_SDK);

            UpdateReward operation = new UpdateReward(
                Code,                
                Namespace,                
                SeasonId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Seasonpass.Model.RewardInfo? response = wrapper.UpdateReward(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}