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
    [SdkConsoleCommand("lobby","getuserincomingfriends")]
    public class GetUserIncomingFriendsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "GetUserIncomingFriends"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetUserIncomingFriendsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Friends wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Friends(_SDK);

            GetUserIncomingFriends operation = new GetUserIncomingFriends(
                Namespace                
            );            
            
            List<AccelByte.Sdk.Api.Lobby.Model.ModelGetUserIncomingFriendsResponse>? response = wrapper.GetUserIncomingFriends(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}