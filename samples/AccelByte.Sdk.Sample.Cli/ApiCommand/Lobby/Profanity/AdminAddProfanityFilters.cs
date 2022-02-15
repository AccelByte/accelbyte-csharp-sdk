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
    [SdkConsoleCommand("lobby","adminaddprofanityfilters")]
    public class AdminAddProfanityFiltersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminAddProfanityFilters"; } }

        [SdkCommandArgument("list")]
        public string List { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminAddProfanityFiltersRequest Body { get; set; } = new ModelsAdminAddProfanityFiltersRequest();
                
        public AdminAddProfanityFiltersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            AdminAddProfanityFilters operation = new AdminAddProfanityFilters(
                List,                
                Namespace,                
                Body                
            );            
            
            wrapper.AdminAddProfanityFilters(operation);
            return String.Empty;
        }
    }
}