// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","retrievelocalizedpolicyversions")]
    public class RetrieveLocalizedPolicyVersionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveLocalizedPolicyVersions"; } }

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        public RetrieveLocalizedPolicyVersionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions(_SDK);

            RetrieveLocalizedPolicyVersions operation = new RetrieveLocalizedPolicyVersions(
                PolicyVersionId                
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.RetrieveLocalizedPolicyVersionResponse>? response = wrapper.RetrieveLocalizedPolicyVersions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}