using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","querysubscriptions")]
    public class QuerySubscriptionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QuerySubscriptions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("chargeStatus")]
        public string? ChargeStatus { get; set; }

        [SdkCommandArgument("itemId")]
        public string? ItemId { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("sku")]
        public string? Sku { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        [SdkCommandArgument("subscribedBy")]
        public string? SubscribedBy { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QuerySubscriptionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            QuerySubscriptions operation = new QuerySubscriptions(
                Namespace,                
                ChargeStatus,                
                ItemId,                
                Limit,                
                Offset,                
                Sku,                
                Status,                
                SubscribedBy,                
                UserId                
            );            

            AccelByte.Sdk.Api.Platform.Model.SubscriptionPagingSlicedResult? response = wrapper.QuerySubscriptions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}