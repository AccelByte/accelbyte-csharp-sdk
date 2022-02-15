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
    [SdkConsoleCommand("social","bulkupdateuserstatitem")]
    public class BulkUpdateUserStatItemCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "BulkUpdateUserStatItem"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        [SdkCommandData("body")]
        public List<BulkStatItemUpdate> Body { get; set; } = new List<BulkStatItemUpdate>();
                
        public BulkUpdateUserStatItemCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            BulkUpdateUserStatItem operation = new BulkUpdateUserStatItem(
                Namespace,                
                UserId,                
                AdditionalKey,                
                Body                
            );            
            
            List<AccelByte.Sdk.Api.Social.Model.BulkStatItemOperationResult>? response = wrapper.BulkUpdateUserStatItem(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}