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
    [SdkConsoleCommand("platform","getcampaigndynamic")]
    public class GetCampaignDynamicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetCampaignDynamic"; } }

        [SdkCommandArgument("campaignId")]
        public string CampaignId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public GetCampaignDynamicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Campaign wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Campaign(_SDK);

            GetCampaignDynamic operation = new GetCampaignDynamic(
                CampaignId,                
                Namespace                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.CampaignDynamicInfo? response = wrapper.GetCampaignDynamic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}