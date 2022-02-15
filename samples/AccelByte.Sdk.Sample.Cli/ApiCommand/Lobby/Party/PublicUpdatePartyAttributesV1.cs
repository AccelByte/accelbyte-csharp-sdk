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
    [SdkConsoleCommand("lobby","publicupdatepartyattributesv1")]
    public class PublicUpdatePartyAttributesV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Lobby"; } }

        public string OperationName{ get { return "PublicUpdatePartyAttributesV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("partyId")]
        public string PartyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsPartyPUTCustomAttributesRequest Body { get; set; } = new ModelsPartyPUTCustomAttributesRequest();
                
        public PublicUpdatePartyAttributesV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Lobby.Wrapper.Party wrapper = new AccelByte.Sdk.Api.Lobby.Wrapper.Party(_SDK);

            PublicUpdatePartyAttributesV1 operation = new PublicUpdatePartyAttributesV1(
                Namespace,                
                PartyId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Lobby.Model.ModelsPartyData? response = wrapper.PublicUpdatePartyAttributesV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}