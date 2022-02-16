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
    [SdkConsoleCommand("iam","admingetrolesv3")]
    public class AdminGetRolesV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminGetRolesV3"; } }

        [SdkCommandArgument("after")]
        public string? After { get; set; }

        [SdkCommandArgument("before")]
        public string? Before { get; set; }

        [SdkCommandArgument("isWildcard")]
        public bool? IsWildcard { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        public AdminGetRolesV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Roles wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Roles(_SDK);

            AdminGetRolesV3 operation = new AdminGetRolesV3(
                After,                
                Before,                
                IsWildcard,                
                Limit                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelRoleResponseWithManagersAndPaginationV3? response = wrapper.AdminGetRolesV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}