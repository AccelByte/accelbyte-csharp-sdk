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
    [SdkConsoleCommand("social","bulkresetuserstatitem3")]
    public class BulkResetUserStatItem3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "BulkResetUserStatItem3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public List<BulkStatItemReset>? Body { get; set; }
                
        public BulkResetUserStatItem3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            BulkResetUserStatItem3 operation = new BulkResetUserStatItem3(
                Namespace,                
                UserId,                
                Body                
            );            

            List<AccelByte.Sdk.Api.Social.Model.BulkStatItemOperationResult>? response = wrapper.BulkResetUserStatItem3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}