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
    [SdkConsoleCommand("platform","publicqueryitems")]
    public class PublicQueryItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicQueryItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("appType")]
        public string? AppType { get; set; }

        [SdkCommandArgument("baseAppId")]
        public string? BaseAppId { get; set; }

        [SdkCommandArgument("categoryPath")]
        public string? CategoryPath { get; set; }

        [SdkCommandArgument("features")]
        public string? Features { get; set; }

        [SdkCommandArgument("itemType")]
        public string? ItemType { get; set; }

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("tags")]
        public string? Tags { get; set; }

        public PublicQueryItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            PublicQueryItems operation = new PublicQueryItems(
                Namespace,                
                AppType,                
                BaseAppId,                
                CategoryPath,                
                Features,                
                ItemType,                
                Language,                
                Limit,                
                Offset,                
                Region,                
                SortBy,                
                StoreId,                
                Tags                
            );            

            AccelByte.Sdk.Api.Platform.Model.ItemPagingSlicedResult? response = wrapper.PublicQueryItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}