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
    [SdkConsoleCommand("lobby","admindeleteprofanityfilter")]
    public class AdminDeleteProfanityFilterCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "AdminDeleteProfanityFilter"; } }

        [SdkCommandArgument("list")]
        public string List { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsAdminDeleteProfanityFilterRequest Body { get; set; } = new ModelsAdminDeleteProfanityFilterRequest();
                
        public AdminDeleteProfanityFilterCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Profanity wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Profanity(_SDK);

            AdminDeleteProfanityFilter operation = new AdminDeleteProfanityFilter(
                List,                
                Namespace,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Lobby.Model.ModelsProfanityFilter>? response = wrapper.AdminDeleteProfanityFilter(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}