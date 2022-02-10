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
    [SdkConsoleCommand("iam","platformauthenticatesamlv3handler")]
    public class PlatformAuthenticateSAMLV3HandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PlatformAuthenticateSAMLV3Handler"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("code")]
        public string? Code { get; set; }

        [SdkCommandArgument("error")]
        public string? Error { get; set; }

        [SdkCommandArgument("state")]
        public string State { get; set; } = String.Empty;

        public PlatformAuthenticateSAMLV3HandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.SSOSAML20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.SSOSAML20(_SDK);

            PlatformAuthenticateSAMLV3Handler operation = new PlatformAuthenticateSAMLV3Handler(
                PlatformId,                
                Code,                
                Error,                
                State                
            );            

            string? response = wrapper.PlatformAuthenticateSAMLV3Handler(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}