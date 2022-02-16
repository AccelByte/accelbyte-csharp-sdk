// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("platform","publicbulkgetitems")]
    public class PublicBulkGetItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicBulkGetItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string? Language { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("itemIds")]
        public string ItemIds { get; set; } = String.Empty;

        public PublicBulkGetItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            PublicBulkGetItems operation = new PublicBulkGetItems(
                Namespace,                
                Language,                
                Region,                
                StoreId,                
                ItemIds                
            );            
            
            List<AccelByte.Sdk.Api.Platform.Model.ItemInfo>? response = wrapper.PublicBulkGetItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}