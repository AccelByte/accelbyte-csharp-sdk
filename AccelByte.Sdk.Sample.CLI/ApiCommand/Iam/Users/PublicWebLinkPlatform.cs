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
    [SdkConsoleCommand("iam","publicweblinkplatform")]
    public class PublicWebLinkPlatformCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicWebLinkPlatform"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("clientId")]
        public string? ClientId { get; set; }

        [SdkCommandArgument("redirectUri")]
        public string? RedirectUri { get; set; }

        public PublicWebLinkPlatformCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            PublicWebLinkPlatform operation = new PublicWebLinkPlatform(
                Namespace,                
                PlatformId,                
                ClientId,                
                RedirectUri                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelWebLinkingResponse? response = wrapper.PublicWebLinkPlatform(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}