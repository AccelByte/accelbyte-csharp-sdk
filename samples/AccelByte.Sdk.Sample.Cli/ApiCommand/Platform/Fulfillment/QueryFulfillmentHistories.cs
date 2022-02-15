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
    [SdkConsoleCommand("platform","queryfulfillmenthistories")]
    public class QueryFulfillmentHistoriesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryFulfillmentHistories"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryFulfillmentHistoriesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Fulfillment wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Fulfillment(_SDK);

            QueryFulfillmentHistories operation = new QueryFulfillmentHistories(
                Namespace,                
                Limit,                
                Offset,                
                Status,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.FulfillmentHistoryPagingSlicedResult? response = wrapper.QueryFulfillmentHistories(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}