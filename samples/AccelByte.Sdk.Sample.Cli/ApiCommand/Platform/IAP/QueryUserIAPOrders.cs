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
    [SdkConsoleCommand("platform","queryuseriaporders")]
    public class QueryUserIAPOrdersCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryUserIAPOrders"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("endTime")]
        public string? EndTime { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("productId")]
        public string? ProductId { get; set; }

        [SdkCommandArgument("startTime")]
        public string? StartTime { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        public QueryUserIAPOrdersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            QueryUserIAPOrders operation = new QueryUserIAPOrders(
                Namespace,                
                UserId,                
                EndTime,                
                Limit,                
                Offset,                
                ProductId,                
                StartTime,                
                Status,                
                Type                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.IAPOrderPagingSlicedResult? response = wrapper.QueryUserIAPOrders(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}