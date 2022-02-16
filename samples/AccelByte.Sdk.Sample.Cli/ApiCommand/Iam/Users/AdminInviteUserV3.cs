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
    [SdkConsoleCommand("iam","admininviteuserv3")]
    public class AdminInviteUserV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AdminInviteUserV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelInviteUserRequestV3 Body { get; set; } = new ModelInviteUserRequestV3();
                
        public AdminInviteUserV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            AdminInviteUserV3 operation = new AdminInviteUserV3(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelInviteUserResponseV3? response = wrapper.AdminInviteUserV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}