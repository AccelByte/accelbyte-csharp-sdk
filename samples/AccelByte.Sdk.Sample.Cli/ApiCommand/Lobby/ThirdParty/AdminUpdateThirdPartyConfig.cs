// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("lobby","adminupdatethirdpartyconfig")]
    public class AdminUpdateThirdPartyConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminUpdateThirdPartyConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateConfigRequest Body { get; set; } = new ModelsUpdateConfigRequest();
                
        public AdminUpdateThirdPartyConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.ThirdParty wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.ThirdParty(_SDK);

            AdminUpdateThirdPartyConfig operation = new AdminUpdateThirdPartyConfig(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelsUpdateConfigResponse? response = wrapper.AdminUpdateThirdPartyConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}