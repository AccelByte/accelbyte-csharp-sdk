using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","updatethirdpartyloginplatformcredentialv3")]
    public class UpdateThirdPartyLoginPlatformCredentialV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "UpdateThirdPartyLoginPlatformCredentialV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelThirdPartyLoginPlatformCredentialRequest? Body { get; set; }
                
        public UpdateThirdPartyLoginPlatformCredentialV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential(_SDK);

            UpdateThirdPartyLoginPlatformCredentialV3 operation = new UpdateThirdPartyLoginPlatformCredentialV3(
                Namespace,                
                PlatformId,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelThirdPartyLoginPlatformCredentialResponse? response = wrapper.UpdateThirdPartyLoginPlatformCredentialV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}