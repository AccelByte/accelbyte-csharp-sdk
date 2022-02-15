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
    [SdkConsoleCommand("legal","retrievelatestpoliciespublic")]
    public class RetrieveLatestPoliciesPublicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveLatestPoliciesPublic"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("alwaysIncludeDefault")]
        public bool? AlwaysIncludeDefault { get; set; }

        [SdkCommandArgument("defaultOnEmpty")]
        public bool? DefaultOnEmpty { get; set; }

        [SdkCommandArgument("policyType")]
        public string? PolicyType { get; set; }

        [SdkCommandArgument("tags")]
        public string? Tags { get; set; }

        public RetrieveLatestPoliciesPublicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.Policies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.Policies(_SDK);

            RetrieveLatestPoliciesPublic operation = new RetrieveLatestPoliciesPublic(
                Namespace,                
                AlwaysIncludeDefault,                
                DefaultOnEmpty,                
                PolicyType,                
                Tags                
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.RetrievePolicyPublicResponse>? response = wrapper.RetrieveLatestPoliciesPublic(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}