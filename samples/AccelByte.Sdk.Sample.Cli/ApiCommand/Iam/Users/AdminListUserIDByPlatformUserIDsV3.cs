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
    [SdkConsoleCommand("iam", "adminlistuseridbyplatformuseridsv3")]
    public class AdminListUserIDByPlatformUserIDsV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminListUserIDByPlatformUserIDsV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("rawPID")]
        public bool? RawPID { get; set; }

        [SdkCommandData("body")]
        public ModelPlatformUserIDRequest Body { get; set; } = new ModelPlatformUserIDRequest();

        public AdminListUserIDByPlatformUserIDsV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminListUserIDByPlatformUserIDsV3.Builder;

            if (RawPID != null)
                opBuilder.SetRawPID((bool)RawPID);




            AdminListUserIDByPlatformUserIDsV3 operation = opBuilder.Build(
                Body,
                Namespace,
                PlatformId
            );


            AccelByte.Sdk.Api.Iam.Model.AccountcommonUserPlatforms? response = wrapper.AdminListUserIDByPlatformUserIDsV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}