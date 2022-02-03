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
    [SdkConsoleCommand("iam","updatethirdpartyloginplatformdomainv3")]
    public class UpdateThirdPartyLoginPlatformDomainV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "UpdateThirdPartyLoginPlatformDomainV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelPlatformDomainUpdateRequest? Body { get; set; }
                
        public UpdateThirdPartyLoginPlatformDomainV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.ThirdPartyCredential(_SDK);

            UpdateThirdPartyLoginPlatformDomainV3 operation = new UpdateThirdPartyLoginPlatformDomainV3(
                Namespace,                
                PlatformId,                
                Body                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelPlatformDomainResponse? response = wrapper.UpdateThirdPartyLoginPlatformDomainV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}