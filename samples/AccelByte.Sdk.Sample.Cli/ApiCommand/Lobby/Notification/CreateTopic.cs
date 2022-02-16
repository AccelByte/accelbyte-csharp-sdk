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
    [SdkConsoleCommand("lobby","createtopic")]
    public class CreateTopicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "CreateTopic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelCreateTopicRequest Body { get; set; } = new ModelCreateTopicRequest();
                
        public CreateTopicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            CreateTopic operation = new CreateTopic(
                Namespace,                
                Body                
            );            
            
            wrapper.CreateTopic(operation);
            return String.Empty;
        }
    }
}