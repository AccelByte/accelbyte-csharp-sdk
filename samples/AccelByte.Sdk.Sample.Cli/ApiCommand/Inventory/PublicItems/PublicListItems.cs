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

using AccelByte.Sdk.Api.Inventory.Wrapper;
using AccelByte.Sdk.Api.Inventory.Model;
using AccelByte.Sdk.Api.Inventory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Inventory
{
    [SdkConsoleCommand("inventory", "publiclistitems")]
    public class PublicListItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "PublicListItems"; } }

        [SdkCommandArgument("inventoryId")]
        public string InventoryId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("qtyGte")]
        public long? QtyGte { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("sourceItemId")]
        public string? SourceItemId { get; set; }

        [SdkCommandArgument("tags")]
        public string? Tags { get; set; }

        public PublicListItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.PublicListItems.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (QtyGte != null)
                opBuilder.SetQtyGte((long)QtyGte);
            if (SortBy != null)
                opBuilder.SetSortBy(PublicListItemsSortBy.NewValue(SortBy));
            if (SourceItemId != null)
                opBuilder.SetSourceItemId((string)SourceItemId);
            if (Tags != null)
                opBuilder.SetTags((string)Tags);




            PublicListItems operation = opBuilder.Build(
                InventoryId,
                Namespace
            );


            AccelByte.Sdk.Api.Inventory.Model.ApimodelsListItemResp? response = wrapper.PublicListItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}