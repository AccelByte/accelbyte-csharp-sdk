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
    [SdkConsoleCommand("csm", "unsubscribev2handler")]
    public class UnsubscribeV2HandlerCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "UnsubscribeV2Handler"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public UnsubscribeV2HandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.NotificationSubscription(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.UnsubscribeV2Handler.Builder;





            UnsubscribeV2Handler operation = opBuilder.Build(
                App,
                Namespace
            );


            wrapper.UnsubscribeV2Handler(operation);
            return String.Empty;
        }
    }
}