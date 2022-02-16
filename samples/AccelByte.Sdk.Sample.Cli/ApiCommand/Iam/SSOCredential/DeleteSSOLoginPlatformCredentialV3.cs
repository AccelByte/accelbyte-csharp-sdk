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
    [SdkConsoleCommand("iam","deletessologinplatformcredentialv3")]
    public class DeleteSSOLoginPlatformCredentialV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "DeleteSSOLoginPlatformCredentialV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public DeleteSSOLoginPlatformCredentialV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential(_SDK);

            DeleteSSOLoginPlatformCredentialV3 operation = new DeleteSSOLoginPlatformCredentialV3(
                Namespace,                
                PlatformId                
            );            
            
            wrapper.DeleteSSOLoginPlatformCredentialV3(operation);
            return String.Empty;
        }
    }
}