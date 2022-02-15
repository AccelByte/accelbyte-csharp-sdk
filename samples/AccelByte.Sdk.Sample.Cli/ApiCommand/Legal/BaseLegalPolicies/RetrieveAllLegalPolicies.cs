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
    [SdkConsoleCommand("legal","retrievealllegalpolicies")]
    public class RetrieveAllLegalPoliciesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "RetrieveAllLegalPolicies"; } }

        public RetrieveAllLegalPoliciesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.BaseLegalPolicies(_SDK);

            RetrieveAllLegalPolicies operation = new RetrieveAllLegalPolicies(
            );            
            
            List<AccelByte.Sdk.Api.Legal.Model.RetrieveBasePolicyResponse>? response = wrapper.RetrieveAllLegalPolicies(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}