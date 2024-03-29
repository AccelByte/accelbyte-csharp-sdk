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
    [SdkConsoleCommand("platform", "querywallets")]
    public class QueryWalletsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "QueryWallets"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("currencyCode")]
        public string? CurrencyCode { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("origin")]
        public string? Origin { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryWalletsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Wallet wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Wallet(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.QueryWallets.Builder;

            if (CurrencyCode != null)
                opBuilder.SetCurrencyCode((string)CurrencyCode);
            if (Limit != null)
                opBuilder.SetLimit((int)Limit);
            if (Offset != null)
                opBuilder.SetOffset((int)Offset);
            if (Origin != null)
                opBuilder.SetOrigin(QueryWalletsOrigin.NewValue(Origin));
            if (UserId != null)
                opBuilder.SetUserId((string)UserId);




            QueryWallets operation = opBuilder.Build(
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Platform.Model.WalletPagingSlicedResult? response = wrapper.QueryWallets(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}