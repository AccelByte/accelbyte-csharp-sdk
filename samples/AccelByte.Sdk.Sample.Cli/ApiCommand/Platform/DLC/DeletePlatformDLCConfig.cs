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
    [SdkConsoleCommand("platform","deleteplatformdlcconfig")]
    public class DeletePlatformDLCConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "DeletePlatformDLCConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        public DeletePlatformDLCConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.DLC wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.DLC(_SDK);

            DeletePlatformDLCConfig operation = new DeletePlatformDLCConfig(
                Namespace                
            );            
            
            wrapper.DeletePlatformDLCConfig(operation);
            return String.Empty;
        }
    }
}