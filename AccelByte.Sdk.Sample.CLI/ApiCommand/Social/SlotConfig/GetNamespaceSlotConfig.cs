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
    [SdkConsoleCommand("social","getnamespaceslotconfig")]
    public class GetNamespaceSlotConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "GetNamespaceSlotConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetNamespaceSlotConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.SlotConfig wrapper = new AccelByte.Sdk.Api.Social.Wrapper.SlotConfig(_SDK);

            GetNamespaceSlotConfig operation = new GetNamespaceSlotConfig(
                Namespace                
            );            

            AccelByte.Sdk.Api.Social.Model.NamespaceSlotConfigInfo? response = wrapper.GetNamespaceSlotConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}