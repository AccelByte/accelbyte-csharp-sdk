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
    [SdkConsoleCommand("iam", "admingetrolenamespacepermissionv3")]
    public class AdminGetRoleNamespacePermissionV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "AdminGetRoleNamespacePermissionV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        public AdminGetRoleNamespacePermissionV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OverrideRoleConfigV3 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OverrideRoleConfigV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.AdminGetRoleNamespacePermissionV3.Builder;





            AdminGetRoleNamespacePermissionV3 operation = opBuilder.Build(
                Namespace,
                RoleId
            );


            AccelByte.Sdk.Api.Iam.Model.ModelRolePermissionResponseV3? response = wrapper.AdminGetRoleNamespacePermissionV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}