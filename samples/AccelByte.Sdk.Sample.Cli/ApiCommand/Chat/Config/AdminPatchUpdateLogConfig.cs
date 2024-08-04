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

using AccelByte.Sdk.Api.Chat.Wrapper;
using AccelByte.Sdk.Api.Chat.Model;
using AccelByte.Sdk.Api.Chat.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Chat
{
    [SdkConsoleCommand("chat", "adminpatchupdatelogconfig")]
    public class AdminPatchUpdateLogConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Chat"; } }

        public string OperationName { get { return "AdminPatchUpdateLogConfig"; } }

        [SdkCommandData("body")]
        public LogconfigConfiguration Body { get; set; } = new LogconfigConfiguration();

        public AdminPatchUpdateLogConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Chat.Wrapper.Config wrapper = new AccelByte.Sdk.Api.Chat.Wrapper.Config(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Chat.Operation.AdminPatchUpdateLogConfig.Builder;





            AdminPatchUpdateLogConfig operation = opBuilder.Build(
                Body
            );


            AccelByte.Sdk.Api.Chat.Model.LogconfigConfiguration? response = wrapper.AdminPatchUpdateLogConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}