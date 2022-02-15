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
    [SdkConsoleCommand("platform","getchildcategories")]
    public class GetChildCategoriesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetChildCategories"; } }

        [SdkCommandArgument("categoryPath")]
        public string CategoryPath { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public GetChildCategoriesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Category wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Category(_SDK);

            GetChildCategories operation = new GetChildCategories(
                CategoryPath,                
                Namespace,                
                StoreId                
            );            
            
            List<AccelByte.Sdk.Api.Platform.Model.FullCategoryInfo>? response = wrapper.GetChildCategories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}