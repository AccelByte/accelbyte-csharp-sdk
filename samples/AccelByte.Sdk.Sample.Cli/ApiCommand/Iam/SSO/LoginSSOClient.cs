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
    [SdkConsoleCommand("iam","loginssoclient")]
    public class LoginSSOClientCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "LoginSSOClient"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("payload")]
        public string? Payload { get; set; }

        public LoginSSOClientCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSO wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSO(_SDK);

            LoginSSOClient operation = new LoginSSOClient(
                PlatformId,                
                Payload                
            );            
            
            wrapper.LoginSSOClient(operation);
            return String.Empty;
        }
    }
}