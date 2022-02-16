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
    [SdkConsoleCommand("platform","getusersubscriptionactivities")]
    public class GetUserSubscriptionActivitiesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "GetUserSubscriptionActivities"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("excludeSystem")]
        public bool? ExcludeSystem { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("subscriptionId")]
        public string? SubscriptionId { get; set; }

        public GetUserSubscriptionActivitiesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Subscription wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Subscription(_SDK);

            GetUserSubscriptionActivities operation = new GetUserSubscriptionActivities(
                Namespace,                
                UserId,                
                ExcludeSystem,                
                Limit,                
                Offset,                
                SubscriptionId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.SubscriptionActivityPagingSlicedResult? response = wrapper.GetUserSubscriptionActivities(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}