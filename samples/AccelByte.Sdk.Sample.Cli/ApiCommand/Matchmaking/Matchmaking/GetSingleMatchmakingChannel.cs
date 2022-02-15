using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking","getsinglematchmakingchannel")]
    public class GetSingleMatchmakingChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "GetSingleMatchmakingChannel"; } }

        [SdkCommandArgument("channelName")]
        public string ChannelName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetSingleMatchmakingChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            GetSingleMatchmakingChannel operation = new GetSingleMatchmakingChannel(
                ChannelName,                
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Matchmaking.Model.ModelsChannelV1? response = wrapper.GetSingleMatchmakingChannel(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}