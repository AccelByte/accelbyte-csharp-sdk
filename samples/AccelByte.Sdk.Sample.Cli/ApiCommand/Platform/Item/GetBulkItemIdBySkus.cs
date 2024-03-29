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
    [SdkConsoleCommand("platform", "getbulkitemidbyskus")]
    public class GetBulkItemIdBySkusCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "GetBulkItemIdBySkus"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sku")]
        public List<string>? Sku { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        public GetBulkItemIdBySkusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.GetBulkItemIdBySkus.Builder;

            if (Sku != null)
                opBuilder.SetSku((List<string>)Sku);
            if (StoreId != null)
                opBuilder.SetStoreId((string)StoreId);




            GetBulkItemIdBySkus operation = opBuilder.Build(
                Namespace
            );


            List<AccelByte.Sdk.Api.Platform.Model.ItemId>? response = wrapper.GetBulkItemIdBySkus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}