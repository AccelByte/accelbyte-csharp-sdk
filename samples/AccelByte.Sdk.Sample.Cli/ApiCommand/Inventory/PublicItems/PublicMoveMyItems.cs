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
    [SdkConsoleCommand("inventory", "publicmovemyitems")]
    public class PublicMoveMyItemsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Inventory"; } }

        public string OperationName { get { return "PublicMoveMyItems"; } }

        [SdkCommandArgument("inventoryId")]
        public string InventoryId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsMoveItemsReq Body { get; set; } = new ApimodelsMoveItemsReq();

        public PublicMoveMyItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems wrapper = new AccelByte.Sdk.Api.Inventory.Wrapper.PublicItems(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Inventory.Operation.PublicMoveMyItems.Builder;





            PublicMoveMyItems operation = opBuilder.Build(
                Body,
                InventoryId,
                Namespace
            );


            AccelByte.Sdk.Api.Inventory.Model.ApimodelsMoveItemsResp? response = wrapper.PublicMoveMyItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}