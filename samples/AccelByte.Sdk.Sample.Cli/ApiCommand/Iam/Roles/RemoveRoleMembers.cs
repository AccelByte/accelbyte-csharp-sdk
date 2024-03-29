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
    [SdkConsoleCommand("iam", "removerolemembers")]
    public class RemoveRoleMembersCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "RemoveRoleMembers"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelRoleMembersRequest Body { get; set; } = new ModelRoleMembersRequest();

        public RemoveRoleMembersCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

#pragma warning disable ab_deprecated_operation
            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.RemoveRoleMembers.Builder;





            RemoveRoleMembers operation = opBuilder.Build(
                Body,
                RoleId
            );

#pragma warning restore ab_deprecated_operation

#pragma warning disable ab_deprecated_operation_wrapper
            wrapper.RemoveRoleMembers(operation);
            return String.Empty;
#pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}