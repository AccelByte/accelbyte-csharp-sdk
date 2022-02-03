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
    [SdkConsoleCommand("iam","retrieveallactivethirdpartyloginplatformcredentialpublicv3")]
    public class RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential(_SDK);

            RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3 operation = new RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(
                Namespace                
            );            

            List<AccelByte.Sdk.Api.Iam.Model.ModelPublicThirdPartyPlatformInfo>? response = wrapper.RetrieveAllActiveThirdPartyLoginPlatformCredentialPublicV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}