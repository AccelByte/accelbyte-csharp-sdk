// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Iam
{
    [SdkConsoleCommand("iam", "adminunbanuserbulkv3")]
    public class AdminUnbanUserBulkV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminUnbanUserBulkV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelBulkUnbanCreateRequestV3 Body { get; set; } = new ModelBulkUnbanCreateRequestV3();

        public AdminUnbanUserBulkV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Bans wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Bans(_SDK);

            AdminUnbanUserBulkV3 operation = new AdminUnbanUserBulkV3(
                Namespace,
                Body
            );

            AccelByte.Sdk.Api.Iam.Model.ModelListBulkUserBanResponseV3? response = wrapper.AdminUnbanUserBulkV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}