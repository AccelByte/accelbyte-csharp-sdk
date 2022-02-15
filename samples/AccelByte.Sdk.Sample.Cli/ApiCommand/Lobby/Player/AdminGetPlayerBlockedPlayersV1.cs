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
    [SdkConsoleCommand("lobby","admingetplayerblockedplayersv1")]
    public class AdminGetPlayerBlockedPlayersV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminGetPlayerBlockedPlayersV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminGetPlayerBlockedPlayersV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Player wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Player(_SDK);

            AdminGetPlayerBlockedPlayersV1 operation = new AdminGetPlayerBlockedPlayersV1(
                Namespace,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelsGetAllPlayerBlockedUsersResponse? response = wrapper.AdminGetPlayerBlockedPlayersV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}