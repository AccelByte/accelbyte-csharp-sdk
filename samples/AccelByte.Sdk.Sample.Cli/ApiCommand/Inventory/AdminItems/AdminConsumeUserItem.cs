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
    [SdkConsoleCommand("inventory", "adminconsumeuseritem")]
    public class AdminConsumeUserItemCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "AdminConsumeUserItem"; } }

        [SdkCommandArgument("inventoryId")]
        public string InventoryId { get; set; } = String.Empty;

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsConsumeItemReq Body { get; set; } = new ApimodelsConsumeItemReq();

        public AdminConsumeUserItemCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.AdminItems wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.AdminItems(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.AdminConsumeUserItem.Builder;





            AdminConsumeUserItem operation = opBuilder.Build(
                Body,
                InventoryId,
                ItemId,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Inventory.Model.ApimodelsItemResp? response = wrapper.AdminConsumeUserItem(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}