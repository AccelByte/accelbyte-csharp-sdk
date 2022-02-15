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
    [SdkConsoleCommand("platform","publicgetdescendantcategories")]
    public class PublicGetDescendantCategoriesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetDescendantCategories"; } }

        [SdkCommandArgument("categoryPath")]
        public string CategoryPath { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public PublicGetDescendantCategoriesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Category wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Category(_SDK);

            PublicGetDescendantCategories operation = new PublicGetDescendantCategories(
                CategoryPath,                
                Namespace,                
                Language,                
                StoreId                
            );            
            
            List<AccelByte.Sdk.Api.Platform.Model.CategoryInfo>? response = wrapper.PublicGetDescendantCategories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}