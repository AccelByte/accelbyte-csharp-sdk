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
    [SdkConsoleCommand("matchmaking","queuesessionhandler")]
    public class QueueSessionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "QueueSessionHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsMatchmakingResult Body { get; set; } = new ModelsMatchmakingResult();
                
        public QueueSessionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            QueueSessionHandler operation = new QueueSessionHandler(
                Namespace,                
                Body                
            );            
            
            wrapper.QueueSessionHandler(operation);
            return String.Empty;
        }
    }
}