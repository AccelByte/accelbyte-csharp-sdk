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
    [SdkConsoleCommand("iam", "admingetrolesourcev3")]
    public class AdminGetRoleSourceV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetRoleSourceV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("identity")]
        public string Identity { get; set; } = String.Empty;

        public AdminGetRoleSourceV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OverrideRoleConfigV3 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OverrideRoleConfigV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetRoleSourceV3.Builder;





            AdminGetRoleSourceV3 operation = opBuilder.Build(
                Namespace,
                Identity
            );


            AccelByte.Sdk.Api.Iam.Model.ModelRoleOverrideSourceResponse? response = wrapper.AdminGetRoleSourceV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}