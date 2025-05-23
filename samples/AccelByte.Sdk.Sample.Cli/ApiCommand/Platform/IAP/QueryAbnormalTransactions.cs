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
    [SdkConsoleCommand("platform", "queryabnormaltransactions")]
    public class QueryAbnormalTransactionsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryAbnormalTransactions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("orderId")]
        public string? OrderId { get; set; }

        [SdkCommandArgument("steamId")]
        public string? SteamId { get; set; }

        public QueryAbnormalTransactionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryAbnormalTransactions.Builder;

            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (OrderId != null)
                opBuilder.SetOrderId((string)OrderId);
            if (SteamId != null)
                opBuilder.SetSteamId((string)SteamId);




            QueryAbnormalTransactions operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Platform.Model.SteamAbnormalTransactionPagingSlicedResult? response = wrapper.QueryAbnormalTransactions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}