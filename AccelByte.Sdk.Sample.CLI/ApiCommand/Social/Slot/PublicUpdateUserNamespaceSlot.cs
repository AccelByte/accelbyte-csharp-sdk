using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Social
{
    [SdkConsoleCommand("social","publicupdateusernamespaceslot")]
    public class PublicUpdateUserNamespaceSlotCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicUpdateUserNamespaceSlot"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slotId")]
        public string SlotId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("label")]
        public string? Label { get; set; }

        [SdkCommandArgument("tags")]
        public List<string>? Tags { get; set; }

        [SdkCommandArgument("checksum")]
        public string Checksum { get; set; } = String.Empty;
                    
        [SdkCommandArgument("customAttribute")]
        public string CustomAttribute { get; set; } = String.Empty;
                    
        [SdkCommandFile("file")]
        public Stream? File { get; set; }
                    
        public PublicUpdateUserNamespaceSlotCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

            PublicUpdateUserNamespaceSlot operation = new PublicUpdateUserNamespaceSlot(
                Namespace,                
                SlotId,                
                UserId,                
                Label,                
                Tags,                
                Checksum,                
                CustomAttribute,                
                File                
            );            

            AccelByte.Sdk.Api.Social.Model.SlotInfo? response = wrapper.PublicUpdateUserNamespaceSlot(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}