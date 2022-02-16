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
    [SdkConsoleCommand("lobby","updatenotificationtopicv1admin")]
    public class UpdateNotificationTopicV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "UpdateNotificationTopicV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("topicName")]
        public string TopicName { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelUpdateTopicRequest Body { get; set; } = new ModelUpdateTopicRequest();
                
        public UpdateNotificationTopicV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            UpdateNotificationTopicV1Admin operation = new UpdateNotificationTopicV1Admin(
                Namespace,                
                TopicName,                
                Body                
            );            
            
            wrapper.UpdateNotificationTopicV1Admin(operation);
            return String.Empty;
        }
    }
}