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
    [SdkConsoleCommand("platform","publicgetcategory")]
    public class PublicGetCategoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicGetCategory"; } }

        [SdkCommandArgument("categoryPath")]
        public string CategoryPath { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public PublicGetCategoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Category wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Category(_SDK);

            PublicGetCategory operation = new PublicGetCategory(
                CategoryPath,                
                Namespace,                
                Language,                
                StoreId                
            );            

            AccelByte.Sdk.Api.Platform.Model.CategoryInfo? response = wrapper.PublicGetCategory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}