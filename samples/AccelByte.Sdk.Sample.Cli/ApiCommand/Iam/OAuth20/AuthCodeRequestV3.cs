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
    [SdkConsoleCommand("iam","authcoderequestv3")]
    public class AuthCodeRequestV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "AuthCodeRequestV3"; } }

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("clientId")]
        public string? ClientId { get; set; }

        [SdkCommandArgument("redirectUri")]
        public string? RedirectUri { get; set; }

        [SdkCommandArgument("requestId")]
        public string RequestId { get; set; } = String.Empty;

        public AuthCodeRequestV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.OAuth20 wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.OAuth20(_SDK);

            AuthCodeRequestV3 operation = new AuthCodeRequestV3(
                PlatformId,                
                ClientId,                
                RedirectUri,                
                RequestId                
            );            

            string? response = wrapper.AuthCodeRequestV3(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}