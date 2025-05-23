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

using AccelByte.Sdk.Api.Sessionhistory.Wrapper;
using AccelByte.Sdk.Api.Sessionhistory.Model;
using AccelByte.Sdk.Api.Sessionhistory.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionhistory
{
    [SdkConsoleCommand("sessionhistory", "admingetenvconfig")]
    public class AdminGetEnvConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Sessionhistory"; } }

        public string OperationName { get { return "AdminGetEnvConfig"; } }

        public AdminGetEnvConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionhistory.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Sessionhistory.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Sessionhistory.Operation.AdminGetEnvConfig.Builder;





            AdminGetEnvConfig operation = opBuilder.Build(
            );


            AccelByte.Sdk.Api.Sessionhistory.Model.EnvconfigConfiguration? response = wrapper.AdminGetEnvConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}