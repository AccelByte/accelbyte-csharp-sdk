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
    [SdkConsoleCommand("csm", "updatevariablev1")]
    public class UpdateVariableV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "UpdateVariableV1"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("configId")]
        public string ConfigId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public GeneratedUpdateConfigurationV1Request Body { get; set; } = new GeneratedUpdateConfigurationV1Request();

        public UpdateVariableV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.Configuration wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.Configuration(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.UpdateVariableV1.Builder;





            UpdateVariableV1 operation = opBuilder.Build(
                Body,
                App,
                ConfigId,
                Namespace
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Csm.Model.GeneratedUpdateConfigurationV1Response? response = wrapper.UpdateVariableV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}