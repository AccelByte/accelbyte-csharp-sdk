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
    [SdkConsoleCommand("platform", "updateservicepluginconfig")]
    public class UpdateServicePluginConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "UpdateServicePluginConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ServicePluginConfigUpdate Body { get; set; } = new ServicePluginConfigUpdate();

        public UpdateServicePluginConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.ServicePluginConfig(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.UpdateServicePluginConfig.Builder;


            if (Body != null)
                opBuilder.SetBody((AccelByte.Sdk.Api.Platform.Model.ServicePluginConfigUpdate)Body);



            UpdateServicePluginConfig operation = opBuilder.Build(
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Platform.Model.ServicePluginConfigInfo? response = wrapper.UpdateServicePluginConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}