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

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","createlocalizedpolicyversion1")]
    public class CreateLocalizedPolicyVersion1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "CreateLocalizedPolicyVersion1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public CreateLocalizedPolicyVersionRequest Body { get; set; } = new CreateLocalizedPolicyVersionRequest();
                
        public CreateLocalizedPolicyVersion1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersionsWithNamespace(_SDK);

            CreateLocalizedPolicyVersion1 operation = new CreateLocalizedPolicyVersion1(
                Namespace,                
                PolicyVersionId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Legal.Model.CreateLocalizedPolicyVersionResponse? response = wrapper.CreateLocalizedPolicyVersion1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}