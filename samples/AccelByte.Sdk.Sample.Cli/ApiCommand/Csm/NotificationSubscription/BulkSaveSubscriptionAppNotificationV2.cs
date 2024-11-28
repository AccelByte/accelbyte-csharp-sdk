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
    [SdkConsoleCommand("csm","bulksavesubscriptionappnotificationv2")]
    public class BulkSaveSubscriptionAppNotificationV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Csm"; } }

        public string OperationName{ get { return "BulkSaveSubscriptionAppNotificationV2"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelBulkSubscribeRequest Body { get; set; } = new ApimodelBulkSubscribeRequest();
                
        public BulkSaveSubscriptionAppNotificationV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.BulkSaveSubscriptionAppNotificationV2.Builder;





            BulkSaveSubscriptionAppNotificationV2 operation = opBuilder.Build(
                Body,
                App,
                Namespace
            );

            
            AccelByte.Sdk.Api.Csm.Model.ApimodelGetNotificationSubscriberListResponse? response = wrapper.BulkSaveSubscriptionAppNotificationV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}