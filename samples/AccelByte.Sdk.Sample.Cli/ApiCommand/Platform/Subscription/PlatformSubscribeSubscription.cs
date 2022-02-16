// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("platform","platformsubscribesubscription")]
    public class PlatformSubscribeSubscriptionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PlatformSubscribeSubscription"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PlatformSubscribeRequest Body { get; set; } = new PlatformSubscribeRequest();
                
        public PlatformSubscribeSubscriptionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            PlatformSubscribeSubscription operation = new PlatformSubscribeSubscription(
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.SubscriptionInfo? response = wrapper.PlatformSubscribeSubscription(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}