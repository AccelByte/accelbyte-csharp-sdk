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
    [SdkConsoleCommand("iam", "publicenablemybackupcodesv4")]
    public class PublicEnableMyBackupCodesV4Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PublicEnableMyBackupCodesV4"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public PublicEnableMyBackupCodesV4Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.UsersV4 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.UsersV4(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicEnableMyBackupCodesV4.Builder;





            PublicEnableMyBackupCodesV4 operation = opBuilder.Build(
                Namespace
            );


            AccelByte.Sdk.Api.Iam.Model.ModelBackupCodesResponseV4? response = wrapper.PublicEnableMyBackupCodesV4(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}