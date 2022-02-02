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
    [SdkConsoleCommand("iam","retrieveallssologinplatformcredentialv3")]
    public class RetrieveAllSSOLoginPlatformCredentialV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "RetrieveAllSSOLoginPlatformCredentialV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        public RetrieveAllSSOLoginPlatformCredentialV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOCredential(_SDK);

            RetrieveAllSSOLoginPlatformCredentialV3 operation = new RetrieveAllSSOLoginPlatformCredentialV3(
                Namespace,                
                Limit,                
                Offset                
            );            

            List<AccelByte.Sdk.Api.Iam.Model.ModelSSOPlatformCredentialResponse>? response = wrapper.RetrieveAllSSOLoginPlatformCredentialV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}