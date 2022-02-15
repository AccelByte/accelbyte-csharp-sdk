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
    [SdkConsoleCommand("lobby","freeformnotification")]
    public class FreeFormNotificationCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "FreeFormNotification"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelFreeFormNotificationRequest Body { get; set; } = new ModelFreeFormNotificationRequest();
                
        public FreeFormNotificationCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            FreeFormNotification operation = new FreeFormNotification(
                Namespace,                
                Body                
            );            
            
            wrapper.FreeFormNotification(operation);
            return String.Empty;
        }
    }
}