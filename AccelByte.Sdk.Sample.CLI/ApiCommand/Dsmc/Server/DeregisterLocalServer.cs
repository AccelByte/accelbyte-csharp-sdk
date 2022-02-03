using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","deregisterlocalserver")]
    public class DeregisterLocalServerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "DeregisterLocalServer"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsDeregisterLocalServerRequest? Body { get; set; }
                
        public DeregisterLocalServerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Server wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Server(_SDK);

            DeregisterLocalServer operation = new DeregisterLocalServer(
                Namespace,                
                Body                
            );            

            wrapper.DeregisterLocalServer(operation);
            return String.Empty;
        }
    }
}