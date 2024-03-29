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
    [SdkConsoleCommand("iam", "publicgetrolev3")]
    public class PublicGetRoleV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Iam"; } }

        public string OperationName { get { return "PublicGetRoleV3"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        public PublicGetRoleV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Iam.Operation.PublicGetRoleV3.Builder;





            PublicGetRoleV3 operation = opBuilder.Build(
                RoleId
            );


            AccelByte.Sdk.Api.Iam.Model.ModelRoleResponse? response = wrapper.PublicGetRoleV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}