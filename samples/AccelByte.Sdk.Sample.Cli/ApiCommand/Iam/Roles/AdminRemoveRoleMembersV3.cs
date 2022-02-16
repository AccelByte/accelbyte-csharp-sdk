// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("iam","adminremoverolemembersv3")]
    public class AdminRemoveRoleMembersV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminRemoveRoleMembersV3"; } }

        [SdkCommandArgument("roleId")]
        public string RoleId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelRoleMembersRequestV3 Body { get; set; } = new ModelRoleMembersRequestV3();
                
        public AdminRemoveRoleMembersV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            AdminRemoveRoleMembersV3 operation = new AdminRemoveRoleMembersV3(
                RoleId,                
                Body                
            );            
            
            wrapper.AdminRemoveRoleMembersV3(operation);
            return String.Empty;
        }
    }
}