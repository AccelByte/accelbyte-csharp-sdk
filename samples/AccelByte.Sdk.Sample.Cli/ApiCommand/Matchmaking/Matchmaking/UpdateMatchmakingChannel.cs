// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking", "updatematchmakingchannel")]
    public class UpdateMatchmakingChannelCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Matchmaking"; } }

        public string OperationName { get { return "UpdateMatchmakingChannel"; } }

        [SdkCommandArgument("channelName")]
        public string ChannelName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateChannelRequest Body { get; set; } = new ModelsUpdateChannelRequest();

        public UpdateMatchmakingChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.UpdateMatchmakingChannel.Builder;





            UpdateMatchmakingChannel operation = opBuilder.Build(
                Body,
                ChannelName,
                Namespace
            );


            wrapper.UpdateMatchmakingChannel(operation);
            return String.Empty;
        }
    }
}