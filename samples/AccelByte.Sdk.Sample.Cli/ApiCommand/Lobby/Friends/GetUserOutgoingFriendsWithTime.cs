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

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby", "getuseroutgoingfriendswithtime")]
    public class GetUserOutgoingFriendsWithTimeCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "GetUserOutgoingFriendsWithTime"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetUserOutgoingFriendsWithTimeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Friends wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Friends(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.GetUserOutgoingFriendsWithTime.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            GetUserOutgoingFriendsWithTime operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Lobby.Model.ModelLoadOutgoingFriendsWithTimeResponse>? response = wrapper.GetUserOutgoingFriendsWithTime(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}