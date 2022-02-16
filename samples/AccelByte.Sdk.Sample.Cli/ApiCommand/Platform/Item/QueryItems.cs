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
    [SdkConsoleCommand("platform","queryitems")]
    public class QueryItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("appType")]
        public string? AppType { get; set; }

        [SdkCommandArgument("availableDate")]
        public string? AvailableDate { get; set; }

        [SdkCommandArgument("baseAppId")]
        public string? BaseAppId { get; set; }

        [SdkCommandArgument("categoryPath")]
        public string? CategoryPath { get; set; }

        [SdkCommandArgument("features")]
        public string? Features { get; set; }

        [SdkCommandArgument("itemType")]
        public string? ItemType { get; set; }

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

        [SdkCommandArgument("targetNamespace")]
        public string? TargetNamespace { get; set; }

        public QueryItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            QueryItems operation = new QueryItems(
                Namespace,                
                ActiveOnly,                
                AppType,                
                AvailableDate,                
                BaseAppId,                
                CategoryPath,                
                Features,                
                ItemType,                
                Limit,                
                Offset,                
                Region,                
                SortBy,                
                StoreId,                
                Tags,                
                TargetNamespace                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.FullItemPagingSlicedResult? response = wrapper.QueryItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}