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
    [SdkConsoleCommand("matchmaking","updateplaytimeweight")]
    public class UpdatePlayTimeWeightCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "UpdatePlayTimeWeight"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdatePlayTimeWeightRequest Body { get; set; } = new ModelsUpdatePlayTimeWeightRequest();
                
        public UpdatePlayTimeWeightCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.SocialMatchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.SocialMatchmaking(_SDK);

            UpdatePlayTimeWeight operation = new UpdatePlayTimeWeight(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Matchmaking.Model.ModelsUpdatePlayerPlaytimeWeightResponse? response = wrapper.UpdatePlayTimeWeight(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}