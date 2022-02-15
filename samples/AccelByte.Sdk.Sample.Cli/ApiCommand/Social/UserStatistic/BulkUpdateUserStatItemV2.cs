using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","bulkupdateuserstatitemv2")]
    public class BulkUpdateUserStatItemV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "BulkUpdateUserStatItemV2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<BulkUserStatItemUpdate> Body { get; set; } = new List<BulkUserStatItemUpdate>();
                
        public BulkUpdateUserStatItemV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            BulkUpdateUserStatItemV2 operation = new BulkUpdateUserStatItemV2(
                Namespace,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Social.Model.BulkStatItemOperationResult>? response = wrapper.BulkUpdateUserStatItemV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}