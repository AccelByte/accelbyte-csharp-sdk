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
    [SdkConsoleCommand("social","deleteuserstatitems2")]
    public class DeleteUserStatItems2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "DeleteUserStatItems2"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("statCode")]
        public string StatCode { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("additionalKey")]
        public string? AdditionalKey { get; set; }

        public DeleteUserStatItems2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.UserStatistic wrapper = new AccelByte.Sdk.Api.Social.Wrapper.UserStatistic(_SDK);

            DeleteUserStatItems2 operation = new DeleteUserStatItems2(
                Namespace,                
                StatCode,                
                UserId,                
                AdditionalKey                
            );            
            
            wrapper.DeleteUserStatItems2(operation);
            return String.Empty;
        }
    }
}