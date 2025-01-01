// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Csm.Wrapper;
using AccelByte.Sdk.Api.Csm.Model;
using AccelByte.Sdk.Api.Csm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Csm
{
    [SdkConsoleCommand("csm", "deletesubscriptionappnotificationv2")]
    public class DeleteSubscriptionAppNotificationV2Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "DeleteSubscriptionAppNotificationV2"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("subscriptionId")]
        public string SubscriptionId { get; set; } = String.Empty;

        public DeleteSubscriptionAppNotificationV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.DeleteSubscriptionAppNotificationV2.Builder;





            DeleteSubscriptionAppNotificationV2 operation = opBuilder.Build(
                App,
                Namespace,
                SubscriptionId
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            wrapper.DeleteSubscriptionAppNotificationV2(operation);
            return String.Empty;
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}