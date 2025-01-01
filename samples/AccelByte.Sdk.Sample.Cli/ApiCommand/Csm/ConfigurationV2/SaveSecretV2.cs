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
    [SdkConsoleCommand("csm", "savesecretv2")]
    public class SaveSecretV2Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Csm"; } }

        public string OperationName { get { return "SaveSecretV2"; } }

        [SdkCommandArgument("app")]
        public string App { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelSaveConfigurationV2Request Body { get; set; } = new ApimodelSaveConfigurationV2Request();

        public SaveSecretV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Csm.Wrapper.ConfigurationV2 wrapper = new AccelByte.Sdk.Api.Csm.Wrapper.ConfigurationV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Csm.Operation.SaveSecretV2.Builder;





            SaveSecretV2 operation = opBuilder.Build(
                Body,
                App,
                Namespace
            );


            AccelByte.Sdk.Api.Csm.Model.ApimodelSaveConfigurationV2Response? response = wrapper.SaveSecretV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}