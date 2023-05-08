// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "publicqueryitems")]
    public class PublicQueryItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "PublicQueryItems"; } }

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

        [SdkCommandArgument("includeSubCategoryItem")]
        public bool? IncludeSubCategoryItem { get; set; }

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
        public List<string>? SortBy { get; set; }

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

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicQueryItems.Builder;

            if (AppType != null)
                opBuilder.SetAppType(PublicQueryItemsAppType.NewValue(AppType));
            if (BaseAppId != null)
                opBuilder.SetBaseAppId((string)BaseAppId);
            if (CategoryPath != null)
                opBuilder.SetCategoryPath((string)CategoryPath);
            if (Features != null)
                opBuilder.SetFeatures((string)Features);
            if (IncludeSubCategoryItem != null)
                opBuilder.SetIncludeSubCategoryItem((bool)IncludeSubCategoryItem);
            if (ItemType != null)
                opBuilder.SetItemType(PublicQueryItemsItemType.NewValue(ItemType));
            if (Language != null)
                opBuilder.SetLanguage((string)Language);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Region != null)
                opBuilder.SetRegion((string)Region);
            if (SortBy != null)
                opBuilder.SetSortBy(PublicQueryItemsSortBy.NewValue(SortBy));
            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);
            if (Tags != null)
                opBuilder.SetTags((string)Tags);




            PublicQueryItems operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.ItemPagingSlicedResult? response = wrapper.PublicQueryItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}