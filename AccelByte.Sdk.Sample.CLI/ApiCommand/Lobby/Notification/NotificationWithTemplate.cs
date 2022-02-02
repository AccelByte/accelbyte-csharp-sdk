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
    [SdkConsoleCommand("lobby","notificationwithtemplate")]
    public class NotificationWithTemplateCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "NotificationWithTemplate"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelNotificationWithTemplateRequest? Body { get; set; }
                
        public NotificationWithTemplateCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            NotificationWithTemplate operation = new NotificationWithTemplate(
                Namespace,                
                Body                
            );            

            wrapper.NotificationWithTemplate(operation);
            return String.Empty;
        }
    }
}