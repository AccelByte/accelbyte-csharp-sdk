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

using AccelByte.Sdk.Api.Ams.Wrapper;
using AccelByte.Sdk.Api.Ams.Model;
using AccelByte.Sdk.Api.Ams.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ams
{
    [SdkConsoleCommand("ams", "adminaccountlink")]
    public class AdminAccountLinkCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Ams"; } }

        public string OperationName { get { return "AdminAccountLink"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiAccountLinkRequest Body { get; set; } = new ApiAccountLinkRequest();

        public AdminAccountLinkCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ams.Wrapper.Account wrapper = new AccelByte.Sdk.Api.Ams.Wrapper.Account(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ams.Operation.AdminAccountLink.Builder;





            AdminAccountLink operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Ams.Model.ApiAccountLinkResponse? response = wrapper.AdminAccountLink(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}