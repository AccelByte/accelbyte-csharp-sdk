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
    [SdkConsoleCommand("lobby","sendmultipleusersfreeformnotificationv1admin")]
    public class SendMultipleUsersFreeformNotificationV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "SendMultipleUsersFreeformNotificationV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelBulkUsersFreeFormNotificationRequestV1 Body { get; set; } = new ModelBulkUsersFreeFormNotificationRequestV1();
                
        public SendMultipleUsersFreeformNotificationV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            SendMultipleUsersFreeformNotificationV1Admin operation = new SendMultipleUsersFreeformNotificationV1Admin(
                Namespace,                
                Body                
            );            

            wrapper.SendMultipleUsersFreeformNotificationV1Admin(operation);
            return String.Empty;
        }
    }
}