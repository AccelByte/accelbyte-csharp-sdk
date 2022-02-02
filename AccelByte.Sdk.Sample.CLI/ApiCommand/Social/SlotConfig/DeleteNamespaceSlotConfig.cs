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
    [SdkConsoleCommand("social","deletenamespaceslotconfig")]
    public class DeleteNamespaceSlotConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "DeleteNamespaceSlotConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeleteNamespaceSlotConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.SlotConfig wrapper = new AccelByte.Sdk.Api.Social.Wrapper.SlotConfig(_SDK);

            DeleteNamespaceSlotConfig operation = new DeleteNamespaceSlotConfig(
                Namespace                
            );            

            wrapper.DeleteNamespaceSlotConfig(operation);
            return String.Empty;
        }
    }
}