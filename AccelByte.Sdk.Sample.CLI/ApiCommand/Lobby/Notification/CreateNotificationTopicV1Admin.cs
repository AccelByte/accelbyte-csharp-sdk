using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Lobby.Wrapper;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Lobby
{
    [SdkConsoleCommand("lobby","createnotificationtopicv1admin")]
    public class CreateNotificationTopicV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "CreateNotificationTopicV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelCreateTopicRequestV1? Body { get; set; }
                
        public CreateNotificationTopicV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            CreateNotificationTopicV1Admin operation = new CreateNotificationTopicV1Admin(
                Namespace,                
                Body                
            );            

            wrapper.CreateNotificationTopicV1Admin(operation);
            return String.Empty;
        }
    }
}