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
    [SdkConsoleCommand("legal","updatelocalizedpolicyversion")]
    public class UpdateLocalizedPolicyVersionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Legal"; } }

        public string OperationName{ get { return "UpdateLocalizedPolicyVersion"; } }

        [SdkCommandArgument("localizedPolicyVersionId")]
        public string LocalizedPolicyVersionId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UpdateLocalizedPolicyVersionRequest? Body { get; set; }
                
        public UpdateLocalizedPolicyVersionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions wrapper = new AccelByte.Sdk.Api.Legal.Wrapper.LocalizedPolicyVersions(_SDK);

            UpdateLocalizedPolicyVersion operation = new UpdateLocalizedPolicyVersion(
                LocalizedPolicyVersionId,                
                Body                
            );            

            AccelByte.Sdk.Api.Legal.Model.UpdateLocalizedPolicyVersionResponse? response = wrapper.UpdateLocalizedPolicyVersion(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}