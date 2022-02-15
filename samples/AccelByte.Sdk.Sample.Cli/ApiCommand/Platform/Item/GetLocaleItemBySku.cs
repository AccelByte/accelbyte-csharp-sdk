using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","getlocaleitembysku")]
    public class GetLocaleItemBySkuCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetLocaleItemBySku"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("populateBundle")]
        public bool? PopulateBundle { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("sku")]
        public string Sku { get; set; } = String.Empty;

        public GetLocaleItemBySkuCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            GetLocaleItemBySku operation = new GetLocaleItemBySku(
                Namespace,                
                ActiveOnly,                
                Language,                
                PopulateBundle,                
                Region,                
                StoreId,                
                Sku                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.PopulatedItemInfo? response = wrapper.GetLocaleItemBySku(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}