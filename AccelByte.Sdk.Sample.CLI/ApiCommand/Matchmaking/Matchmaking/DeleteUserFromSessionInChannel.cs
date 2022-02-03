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
    [SdkConsoleCommand("matchmaking","deleteuserfromsessioninchannel")]
    public class DeleteUserFromSessionInChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "DeleteUserFromSessionInChannel"; } }

        [SdkCommandArgument("channelName")]
        public string ChannelName { get; set; } = String.Empty;

        [SdkCommandArgument("matchID")]
        public string MatchID { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userID")]
        public string UserID { get; set; } = String.Empty;

        public DeleteUserFromSessionInChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            DeleteUserFromSessionInChannel operation = new DeleteUserFromSessionInChannel(
                ChannelName,                
                MatchID,                
                Namespace,                
                UserID                
            );            

            wrapper.DeleteUserFromSessionInChannel(operation);
            return String.Empty;
        }
    }
}