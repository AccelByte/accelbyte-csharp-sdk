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
    [SdkConsoleCommand("matchmaking", "getmockticketsbytimestamp")]
    public class GetMockTicketsByTimestampCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Matchmaking"; } }

        public string OperationName { get { return "GetMockTicketsByTimestamp"; } }

        [SdkCommandArgument("channelName")]
        public string ChannelName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsQueryMockBy Body { get; set; } = new ModelsQueryMockBy();

        public GetMockTicketsByTimestampCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.MockMatchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.MockMatchmaking(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Matchmaking.Operation.GetMockTicketsByTimestamp.Builder;





            GetMockTicketsByTimestamp operation = opBuilder.Build(
                Body,
                ChannelName,
                Namespace
            );


            AccelByte.Sdk.Api.Matchmaking.Model.ModelsGetMockTicketsResponse? response = wrapper.GetMockTicketsByTimestamp(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}