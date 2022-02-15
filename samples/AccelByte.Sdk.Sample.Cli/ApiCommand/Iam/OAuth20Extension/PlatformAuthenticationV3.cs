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
    [SdkConsoleCommand("iam","platformauthenticationv3")]
    public class PlatformAuthenticationV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformAuthenticationV3"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("error")]
        public string? Error { get; set; }

        [SdkCommandArgument("openidAssocHandle")]
        public string? OpenidAssocHandle { get; set; }

        [SdkCommandArgument("openidClaimedId")]
        public string? OpenidClaimedId { get; set; }

        [SdkCommandArgument("openidIdentity")]
        public string? OpenidIdentity { get; set; }

        [SdkCommandArgument("openidMode")]
        public string? OpenidMode { get; set; }

        [SdkCommandArgument("openidNs")]
        public string? OpenidNs { get; set; }

        [SdkCommandArgument("openidOpEndpoint")]
        public string? OpenidOpEndpoint { get; set; }

        [SdkCommandArgument("openidResponseNonce")]
        public string? OpenidResponseNonce { get; set; }

        [SdkCommandArgument("openidReturnTo")]
        public string? OpenidReturnTo { get; set; }

        [SdkCommandArgument("openidSig")]
        public string? OpenidSig { get; set; }

        [SdkCommandArgument("openidSigned")]
        public string? OpenidSigned { get; set; }

        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;

        public PlatformAuthenticationV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20Extension(_SDK);

            PlatformAuthenticationV3 operation = new PlatformAuthenticationV3(
                PlatformId,                
                Code,                
                Error,                
                OpenidAssocHandle,                
                OpenidClaimedId,                
                OpenidIdentity,                
                OpenidMode,                
                OpenidNs,                
                OpenidOpEndpoint,                
                OpenidResponseNonce,                
                OpenidReturnTo,                
                OpenidSig,                
                OpenidSigned,                
                State                
            );            
            
            string? response = wrapper.PlatformAuthenticationV3(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}