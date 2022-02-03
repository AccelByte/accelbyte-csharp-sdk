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
    [SdkConsoleCommand("lobby","publicgetpartydatav1")]
    public class PublicGetPartyDataV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "PublicGetPartyDataV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("partyId")]
        public string PartyId { get; set; } = String.Empty;

        public PublicGetPartyDataV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Party(_SDK);

            PublicGetPartyDataV1 operation = new PublicGetPartyDataV1(
                Namespace,                
                PartyId                
            );            

            AccelByte.Sdk.Api.Lobby.Model.ModelsPartyData? response = wrapper.PublicGetPartyDataV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}