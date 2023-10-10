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
    [SdkConsoleCommand("inventory", "adminbulkupdatemyitems")]
    public class AdminBulkUpdateMyItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "AdminBulkUpdateMyItems"; } }

        [SdkCommandArgument("inventoryId")]
        public string InventoryId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<ApimodelsAdminUpdateItemReq> Body { get; set; } = new List<ApimodelsAdminUpdateItemReq>();

        public AdminBulkUpdateMyItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminItems wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminItems(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminBulkUpdateMyItems.Builder;





            AdminBulkUpdateMyItems operation = opBuilder.Build(
                Body,
                InventoryId,
                Namespace,
                UserId
            );


            List<AccelByte.Sdk.Api.Inventory.Model.ApimodelsUpdateItemResp>? response = wrapper.AdminBulkUpdateMyItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}