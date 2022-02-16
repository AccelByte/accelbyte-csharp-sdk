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
    [SdkConsoleCommand("iam","deletethirdpartyloginplatformdomainv3")]
    public class DeleteThirdPartyLoginPlatformDomainV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "DeleteThirdPartyLoginPlatformDomainV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelPlatformDomainDeleteRequest Body { get; set; } = new ModelPlatformDomainDeleteRequest();
                
        public DeleteThirdPartyLoginPlatformDomainV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential(_SDK);

            DeleteThirdPartyLoginPlatformDomainV3 operation = new DeleteThirdPartyLoginPlatformDomainV3(
                Namespace,                
                PlatformId,                
                Body                
            );            
            
            wrapper.DeleteThirdPartyLoginPlatformDomainV3(operation);
            return String.Empty;
        }
    }
}