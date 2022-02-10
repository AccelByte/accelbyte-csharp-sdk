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
    [SdkConsoleCommand("lobby","adminverifymessageprofanityresponse")]
    public class AdminVerifyMessageProfanityResponseCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminVerifyMessageProfanityResponse"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminVerifyMessageProfanityRequest Body { get; set; } = new ModelsAdminVerifyMessageProfanityRequest();
                
        public AdminVerifyMessageProfanityResponseCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            AdminVerifyMessageProfanityResponse operation = new AdminVerifyMessageProfanityResponse(
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Lobby.Model.ModelsAdminVerifyMessageProfanityResponse? response = wrapper.AdminVerifyMessageProfanityResponse(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}