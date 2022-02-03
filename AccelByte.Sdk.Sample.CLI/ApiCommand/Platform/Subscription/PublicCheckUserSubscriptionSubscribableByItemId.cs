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
    [SdkConsoleCommand("platform","publiccheckusersubscriptionsubscribablebyitemid")]
    public class PublicCheckUserSubscriptionSubscribableByItemIdCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicCheckUserSubscriptionSubscribableByItemId"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("itemId")]
        public string ItemId { get; set; }

        public PublicCheckUserSubscriptionSubscribableByItemIdCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            PublicCheckUserSubscriptionSubscribableByItemId operation = new PublicCheckUserSubscriptionSubscribableByItemId(
                Namespace,                
                UserId,                
                ItemId                
            );            

            AccelByte.Sdk.Api.Platform.Model.Subscribable? response = wrapper.PublicCheckUserSubscriptionSubscribableByItemId(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}