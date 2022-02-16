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
    [SdkConsoleCommand("iam","getuserbyplatformuserid")]
    public class GetUserByPlatformUserIDCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "GetUserByPlatformUserID"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformID")]
        public string PlatformID { get; set; } = String.Empty;

        [SdkCommandArgument("platformUserID")]
        public string PlatformUserID { get; set; } = String.Empty;

        public GetUserByPlatformUserIDCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            GetUserByPlatformUserID operation = new GetUserByPlatformUserID(
                Namespace,                
                PlatformID,                
                PlatformUserID                
            );            
            
            AccelByte.Sdk.Api.Iam.Model.ModelPublicUserResponse? response = wrapper.GetUserByPlatformUserID(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}