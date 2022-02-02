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
    [SdkConsoleCommand("lobby","sendpartytemplatednotificationv1admin")]
    public class SendPartyTemplatedNotificationV1AdminCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "SendPartyTemplatedNotificationV1Admin"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("partyId")]
        public string PartyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelNotificationWithTemplateRequestV1? Body { get; set; }
                
        public SendPartyTemplatedNotificationV1AdminCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Notification wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Notification(_SDK);

            SendPartyTemplatedNotificationV1Admin operation = new SendPartyTemplatedNotificationV1Admin(
                Namespace,                
                PartyId,                
                Body                
            );            

            wrapper.SendPartyTemplatedNotificationV1Admin(operation);
            return String.Empty;
        }
    }
}