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

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "admingetusersbydevicev4")]
    public class AdminGetUsersByDeviceV4Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetUsersByDeviceV4"; } }

        [SdkCommandArgument("deviceId")]
        public string DeviceId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetUsersByDeviceV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.DevicesV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetUsersByDeviceV4.Builder;





            AdminGetUsersByDeviceV4 operation = opBuilder.Build(
                DeviceId,
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelDeviceUsersResponseV4? response = wrapper.AdminGetUsersByDeviceV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}