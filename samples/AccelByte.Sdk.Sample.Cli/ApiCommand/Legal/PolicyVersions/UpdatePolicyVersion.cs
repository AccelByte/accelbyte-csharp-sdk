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
    [SdkConsoleCommand("legal","updatepolicyversion")]
    public class UpdatePolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "UpdatePolicyVersion"; } }

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdatePolicyVersionRequest Body { get; set; } = new UpdatePolicyVersionRequest();
                
        public UpdatePolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions(_SDK);

            UpdatePolicyVersion operation = new UpdatePolicyVersion(
                PolicyVersionId,                
                Body                
            );            

            AccelByte.Sdk.Api.Legal.Model.UpdatePolicyVersionResponse? response = wrapper.UpdatePolicyVersion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}