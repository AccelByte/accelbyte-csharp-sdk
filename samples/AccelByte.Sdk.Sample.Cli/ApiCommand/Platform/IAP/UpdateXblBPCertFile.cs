using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","updatexblbpcertfile")]
    public class UpdateXblBPCertFileCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateXblBPCertFile"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandFile("file")]
        public Stream? File { get; set; }
                    
        [SdkCommandArgument("password")]
        public string Password { get; set; } = String.Empty;
                    
        public UpdateXblBPCertFileCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.IAP wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.IAP(_SDK);

            UpdateXblBPCertFile operation = new UpdateXblBPCertFile(
                Namespace,                
                File,                
                Password                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.XblIAPConfigInfo? response = wrapper.UpdateXblBPCertFile(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}