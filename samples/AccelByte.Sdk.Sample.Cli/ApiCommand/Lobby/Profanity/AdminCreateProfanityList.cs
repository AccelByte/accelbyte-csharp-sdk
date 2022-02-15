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
    [SdkConsoleCommand("lobby","admincreateprofanitylist")]
    public class AdminCreateProfanityListCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminCreateProfanityList"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminCreateProfanityListRequest Body { get; set; } = new ModelsAdminCreateProfanityListRequest();
                
        public AdminCreateProfanityListCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            AdminCreateProfanityList operation = new AdminCreateProfanityList(
                Namespace,                
                Body                
            );            
            
            wrapper.AdminCreateProfanityList(operation);
            return String.Empty;
        }
    }
}