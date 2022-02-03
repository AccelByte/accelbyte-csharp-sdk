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
    [SdkConsoleCommand("iam","publicplatformlinkv3")]
    public class PublicPlatformLinkV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicPlatformLinkV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("redirectUri")]
        public string RedirectUri { get; set; } = String.Empty;
                    
        [SdkCommandArgument("ticket")]
        public string Ticket { get; set; } = String.Empty;
                    
        public PublicPlatformLinkV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            PublicPlatformLinkV3 operation = new PublicPlatformLinkV3(
                Namespace,                
                PlatformId,                
                RedirectUri,                
                Ticket                
            );            

            wrapper.PublicPlatformLinkV3(operation);
            return String.Empty;
        }
    }
}