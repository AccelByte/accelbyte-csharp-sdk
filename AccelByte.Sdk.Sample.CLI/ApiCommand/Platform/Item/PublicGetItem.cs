using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicgetitem")]
    public class PublicGetItemCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetItem"; } }

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("populateBundle")]
        public bool? PopulateBundle { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public PublicGetItemCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            PublicGetItem operation = new PublicGetItem(
                ItemId,                
                Namespace,                
                Language,                
                PopulateBundle,                
                Region,                
                StoreId                
            );            

            AccelByte.Sdk.Api.Platform.Model.PopulatedItemInfo? response = wrapper.PublicGetItem(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}