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
    [SdkConsoleCommand("lobby", "adminlistfriendsoffriends")]
    public class AdminListFriendsOfFriendsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Lobby"; } }

        public string OperationName { get { return "AdminListFriendsOfFriends"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("friendId")]
        public string? FriendId { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("nopaging")]
        public bool? Nopaging { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public AdminListFriendsOfFriendsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Friends wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Friends(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Lobby.Operation.AdminListFriendsOfFriends.Builder;

            if (FriendId != null)
                opBuilder.SetFriendId((string)FriendId);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Nopaging != null)
                opBuilder.SetNopaging((bool)Nopaging);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);




            AdminListFriendsOfFriends operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Lobby.Model.ModelFriendshipConnectionResponse? response = wrapper.AdminListFriendsOfFriends(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}