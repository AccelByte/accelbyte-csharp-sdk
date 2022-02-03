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
    [SdkConsoleCommand("platform","querycodes")]
    public class QueryCodesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QueryCodes"; } }

        [SdkCommandArgument("campaignId")]
        public string CampaignId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("activeOnly")]
        public bool? ActiveOnly { get; set; }

        [SdkCommandArgument("batchNo")]
        public int? BatchNo { get; set; }

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        public QueryCodesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Campaign wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Campaign(_SDK);

            QueryCodes operation = new QueryCodes(
                CampaignId,                
                Namespace,                
                ActiveOnly,                
                BatchNo,                
                Code,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Platform.Model.CodeInfoPagingSlicedResult? response = wrapper.QueryCodes(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}