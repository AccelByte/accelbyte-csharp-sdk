using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Legal.Wrapper;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Api.Legal.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Legal
{
    [SdkConsoleCommand("legal","publishpolicyversion")]
    public class PublishPolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "PublishPolicyVersion"; } }

        [SdkCommandArgument("policyVersionId")]
        public string PolicyVersionId { get; set; } = String.Empty;

        [SdkCommandArgument("shouldNotify")]
        public bool? ShouldNotify { get; set; }

        public PublishPolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.PolicyVersions(_SDK);

            PublishPolicyVersion operation = new PublishPolicyVersion(
                PolicyVersionId,                
                ShouldNotify                
            );            

            wrapper.PublishPolicyVersion(operation);
            return String.Empty;
        }
    }
}