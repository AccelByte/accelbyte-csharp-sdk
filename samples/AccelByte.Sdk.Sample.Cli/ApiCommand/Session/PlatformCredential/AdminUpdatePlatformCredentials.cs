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
    [SdkConsoleCommand("session", "adminupdateplatformcredentials")]
    public class AdminUpdatePlatformCredentialsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Session"; } }

        public string OperationName { get { return "AdminUpdatePlatformCredentials"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApimodelsPutPlatformCredentialsRequest Body { get; set; } = new ApimodelsPutPlatformCredentialsRequest();

        public AdminUpdatePlatformCredentialsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Session.Wrapper.PlatformCredential wrapper = new AccelByte.Sdk.Api.Session.Wrapper.PlatformCredential(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Session.Operation.AdminUpdatePlatformCredentials.Builder;





            AdminUpdatePlatformCredentials operation = opBuilder.Build(
                Body,
                Namespace
            );


            string? response = wrapper.AdminUpdatePlatformCredentials(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}