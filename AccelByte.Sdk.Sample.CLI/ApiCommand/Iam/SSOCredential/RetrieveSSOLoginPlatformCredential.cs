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
    [SdkConsoleCommand("iam","retrievessologinplatformcredential")]
    public class RetrieveSSOLoginPlatformCredentialCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "RetrieveSSOLoginPlatformCredential"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        public RetrieveSSOLoginPlatformCredentialCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential(_SDK);

            RetrieveSSOLoginPlatformCredential operation = new RetrieveSSOLoginPlatformCredential(
                Namespace,                
                PlatformId                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelSSOPlatformCredentialResponse? response = wrapper.RetrieveSSOLoginPlatformCredential(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}