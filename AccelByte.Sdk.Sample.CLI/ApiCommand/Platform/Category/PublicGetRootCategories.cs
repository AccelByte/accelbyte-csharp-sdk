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
    [SdkConsoleCommand("platform","publicgetrootcategories")]
    public class PublicGetRootCategoriesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetRootCategories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public PublicGetRootCategoriesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Category wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Category(_SDK);

            PublicGetRootCategories operation = new PublicGetRootCategories(
                Namespace,                
                Language,                
                StoreId                
            );            

            List<AccelByte.Sdk.Api.Platform.Model.CategoryInfo>? response = wrapper.PublicGetRootCategories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}