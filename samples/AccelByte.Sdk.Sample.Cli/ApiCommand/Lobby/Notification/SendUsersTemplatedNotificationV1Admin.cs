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
    [SdkConsoleCommand("lobby","senduserstemplatednotificationv1admin")]
    public class SendUsersTemplatedNotificationV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "SendUsersTemplatedNotificationV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelNotificationWithTemplateRequestV1 Body { get; set; } = new ModelNotificationWithTemplateRequestV1();
                
        public SendUsersTemplatedNotificationV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            SendUsersTemplatedNotificationV1Admin operation = new SendUsersTemplatedNotificationV1Admin(
                Namespace,                
                Body                
            );            

            wrapper.SendUsersTemplatedNotificationV1Admin(operation);
            return String.Empty;
        }
    }
}