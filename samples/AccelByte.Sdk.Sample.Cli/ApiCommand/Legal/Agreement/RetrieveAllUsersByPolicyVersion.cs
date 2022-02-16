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
    [SdkConsoleCommand("legal","retrieveallusersbypolicyversion")]
    public class RetrieveAllUsersByPolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveAllUsersByPolicyVersion"; } }

        [SdkCommandArgument("keyword")]
        public string? Keyword { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        public RetrieveAllUsersByPolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Agreement wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Agreement(_SDK);

            RetrieveAllUsersByPolicyVersion operation = new RetrieveAllUsersByPolicyVersion(
                Keyword,                
                Limit,                
                Offset,                
                PolicyVersionId                
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.PagedRetrieveUserAcceptedAgreementResponse>? response = wrapper.RetrieveAllUsersByPolicyVersion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}