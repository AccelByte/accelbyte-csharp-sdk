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

using AccelByte.Sdk.Api.Session.Wrapper;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Api.Session.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Session
{
    [SdkConsoleCommand("session", "admincreateconfigurationalertv1")]
    public class AdminCreateConfigurationAlertV1Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminCreateConfigurationAlertV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsConfigAlertRequestCreate Body { get; set; } = new ApimodelsConfigAlertRequestCreate();

        public AdminCreateConfigurationAlertV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate wrapper = new AccelByte.Sdk.Api.Session.Wrapper.ConfigurationTemplate(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminCreateConfigurationAlertV1.Builder;





            AdminCreateConfigurationAlertV1 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Session.Model.ApimodelsConfigAlertResponse? response = wrapper.AdminCreateConfigurationAlertV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}