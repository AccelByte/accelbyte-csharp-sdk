using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","publicupdateusernamespaceslotmetadata")]
    public class PublicUpdateUserNamespaceSlotMetadataCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicUpdateUserNamespaceSlotMetadata"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slotId")]
        public string SlotId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SlotMetadataUpdate? Body { get; set; }
                
        public PublicUpdateUserNamespaceSlotMetadataCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

            PublicUpdateUserNamespaceSlotMetadata operation = new PublicUpdateUserNamespaceSlotMetadata(
                Namespace,                
                SlotId,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Social.Model.SlotInfo? response = wrapper.PublicUpdateUserNamespaceSlotMetadata(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}