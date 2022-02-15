using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","usergetfriendshipstatus")]
    public class UserGetFriendshipStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "UserGetFriendshipStatus"; } }

        [SdkCommandArgument("friendId")]
        public string FriendId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public UserGetFriendshipStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Friends wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Friends(_SDK);

            UserGetFriendshipStatus operation = new UserGetFriendshipStatus(
                FriendId,                
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelUserGetFriendshipStatusResponse? response = wrapper.UserGetFriendshipStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}