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
    [SdkConsoleCommand("iam", "adminquerythirdplatformlinkhistoryv3")]
    public class AdminQueryThirdPlatformLinkHistoryV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminQueryThirdPlatformLinkHistoryV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("platformUserId")]
        public string? PlatformUserId { get; set; }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public AdminQueryThirdPlatformLinkHistoryV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminQueryThirdPlatformLinkHistoryV3 operation = new AdminQueryThirdPlatformLinkHistoryV3(
                Namespace,
                Limit,
                Offset,
                PlatformUserId,
                PlatformId
            );

            AccelByte.Sdk.Api.Iam.Model.ModelLinkingHistoryResponseWithPaginationV3? response = wrapper.AdminQueryThirdPlatformLinkHistoryV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}