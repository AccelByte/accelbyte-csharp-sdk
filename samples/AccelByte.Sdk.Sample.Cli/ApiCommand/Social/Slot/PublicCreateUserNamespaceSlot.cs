// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("social","publiccreateusernamespaceslot")]
    public class PublicCreateUserNamespaceSlotCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicCreateUserNamespaceSlot"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

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
                    
        public PublicCreateUserNamespaceSlotCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.Slot wrapper = new AccelByte.Sdk.Api.Social.Wrapper.Slot(_SDK);

            PublicCreateUserNamespaceSlot operation = new PublicCreateUserNamespaceSlot(
                Namespace,                
                UserId,                
                Label,                
                Tags,                
                Checksum,                
                CustomAttribute,                
                File                
            );            
            
            wrapper.PublicCreateUserNamespaceSlot(operation);
            return String.Empty;
        }
    }
}