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
    [SdkConsoleCommand("platform","querychanges")]
    public class QueryChangesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryChanges"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("storeId")]
        public string StoreId { get; set; } = String.Empty;

        [SdkCommandArgument("action")]
        public string? Action { get; set; }

        [SdkCommandArgument("itemType")]
        public string? ItemType { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("updatedAtEnd")]
        public string? UpdatedAtEnd { get; set; }

        [SdkCommandArgument("updatedAtStart")]
        public string? UpdatedAtStart { get; set; }

        public QueryChangesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.CatalogChanges(_SDK);

            QueryChanges operation = new QueryChanges(
                Namespace,                
                StoreId,                
                Action,                
                ItemType,                
                Limit,                
                Offset,                
                SortBy,                
                Status,                
                Type,                
                UpdatedAtEnd,                
                UpdatedAtStart                
            );            
            
            List<AccelByte.Sdk.Api.Platform.Model.CatalogChangePagingSlicedResult>? response = wrapper.QueryChanges(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}