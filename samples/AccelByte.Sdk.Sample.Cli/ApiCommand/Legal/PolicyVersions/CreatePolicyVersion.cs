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
    [SdkConsoleCommand("legal","createpolicyversion")]
    public class CreatePolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "CreatePolicyVersion"; } }

        [SdkCommandArgument("policyId")]
        public string PolicyId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public CreatePolicyVersionRequest Body { get; set; } = new CreatePolicyVersionRequest();
                
        public CreatePolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions(_SDK);

            CreatePolicyVersion operation = new CreatePolicyVersion(
                PolicyId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Legal.Model.CreatePolicyVersionResponse? response = wrapper.CreatePolicyVersion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}