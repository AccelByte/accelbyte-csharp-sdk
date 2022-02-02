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
    [SdkConsoleCommand("iam","publicweblinkplatformestablish")]
    public class PublicWebLinkPlatformEstablishCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicWebLinkPlatformEstablish"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("state")]
        public string State { get; set; }

        public PublicWebLinkPlatformEstablishCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            PublicWebLinkPlatformEstablish operation = new PublicWebLinkPlatformEstablish(
                Namespace,                
                PlatformId,                
                State                
            );            

            string? response = wrapper.PublicWebLinkPlatformEstablish(operation);
            if (response == null)
                return "No response from server.";
            return response!;            
        }
    }
}