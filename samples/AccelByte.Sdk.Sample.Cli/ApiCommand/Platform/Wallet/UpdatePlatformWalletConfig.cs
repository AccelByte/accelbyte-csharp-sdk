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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform", "updateplatformwalletconfig")]
    public class UpdatePlatformWalletConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UpdatePlatformWalletConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platform")]
        public string Platform { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public PlatformWalletConfigUpdate Body { get; set; } = new PlatformWalletConfigUpdate();

        public UpdatePlatformWalletConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Wallet wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Wallet(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdatePlatformWalletConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((PlatformWalletConfigUpdate)Body);



            UpdatePlatformWalletConfig operation = opBuilder.Build(
                Namespace,
                Platform
            );


            AccelByte.Sdk.Api.Platform.Model.PlatformWalletConfigInfo? response = wrapper.UpdatePlatformWalletConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}