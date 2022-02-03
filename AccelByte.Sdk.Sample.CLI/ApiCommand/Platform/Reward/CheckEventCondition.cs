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
    [SdkConsoleCommand("platform","checkeventcondition")]
    public class CheckEventConditionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CheckEventCondition"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("rewardId")]
        public string RewardId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public EventPayload? Body { get; set; }
                
        public CheckEventConditionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Reward wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Reward(_SDK);

            CheckEventCondition operation = new CheckEventCondition(
                Namespace,                
                RewardId,                
                Body                
            );            

            AccelByte.Sdk.Api.Platform.Model.ConditionMatchResult? response = wrapper.CheckEventCondition(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}