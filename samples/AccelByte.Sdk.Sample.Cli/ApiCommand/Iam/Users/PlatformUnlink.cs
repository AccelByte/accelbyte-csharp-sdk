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
    [SdkConsoleCommand("iam", "platformunlink")]
    public class PlatformUnlinkCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PlatformUnlink"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("platform_namespace")]
        public string PlatformNamespace { get; set; } = String.Empty;

        public PlatformUnlinkCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PlatformUnlink.Builder;



            if (PlatformNamespace != null)
                opBuilder.SetPlatformNamespace((string)PlatformNamespace);


            PlatformUnlink operation = opBuilder.Build(
                Namespace,
                PlatformId,
                UserId
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            wrapper.PlatformUnlink(operation);
            return String.Empty;
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}