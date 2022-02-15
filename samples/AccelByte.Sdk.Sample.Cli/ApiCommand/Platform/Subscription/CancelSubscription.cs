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
    [SdkConsoleCommand("platform","cancelsubscription")]
    public class CancelSubscriptionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "CancelSubscription"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("subscriptionId")]
        public string SubscriptionId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("force")]
        public bool? Force { get; set; }

        [SdkCommandData("body")]
        public CancelRequest Body { get; set; } = new CancelRequest();
                
        public CancelSubscriptionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            CancelSubscription operation = new CancelSubscription(
                Namespace,                
                SubscriptionId,                
                UserId,                
                Force,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.SubscriptionInfo? response = wrapper.CancelSubscription(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}