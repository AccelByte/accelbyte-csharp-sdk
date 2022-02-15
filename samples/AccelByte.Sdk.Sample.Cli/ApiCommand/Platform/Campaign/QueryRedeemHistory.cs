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
    [SdkConsoleCommand("platform","queryredeemhistory")]
    public class QueryRedeemHistoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryRedeemHistory"; } }

        [SdkCommandArgument("campaignId")]
        public string CampaignId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public QueryRedeemHistoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Campaign wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Campaign(_SDK);

            QueryRedeemHistory operation = new QueryRedeemHistory(
                CampaignId,                
                Namespace,                
                Code,                
                Limit,                
                Offset,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.RedeemHistoryPagingSlicedResult? response = wrapper.QueryRedeemHistory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}