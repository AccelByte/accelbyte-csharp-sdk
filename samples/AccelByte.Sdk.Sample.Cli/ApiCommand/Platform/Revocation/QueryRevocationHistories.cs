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
    [SdkConsoleCommand("platform","queryrevocationhistories")]
    public class QueryRevocationHistoriesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryRevocationHistories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endTime")]
        public string? EndTime { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("source")]
        public string? Source { get; set; }

        [SdkCommandArgument("startTime")]
        public string? StartTime { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("transactionId")]
        public string? TransactionId { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryRevocationHistoriesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Revocation wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Revocation(_SDK);

            QueryRevocationHistories operation = new QueryRevocationHistories(
                Namespace,                
                EndTime,                
                Limit,                
                Offset,                
                (Source is null ? null : QueryRevocationHistoriesSource.NewValue(Source)),                
                StartTime,                
                (Status is null ? null : QueryRevocationHistoriesStatus.NewValue(Status)),                
                TransactionId,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.RevocationHistoryPagingSlicedResult? response = wrapper.QueryRevocationHistories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}