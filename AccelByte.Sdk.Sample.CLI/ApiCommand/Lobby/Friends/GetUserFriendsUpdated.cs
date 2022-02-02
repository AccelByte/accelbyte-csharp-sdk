using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","getuserfriendsupdated")]
    public class GetUserFriendsUpdatedCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "GetUserFriendsUpdated"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public GetUserFriendsUpdatedCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Friends wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Friends(_SDK);

            GetUserFriendsUpdated operation = new GetUserFriendsUpdated(
                Namespace,                
                Limit,                
                Offset                
            );            

            List<AccelByte.Sdk.Api.Lobby.Model.ModelGetUserFriendsResponse>? response = wrapper.GetUserFriendsUpdated(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}