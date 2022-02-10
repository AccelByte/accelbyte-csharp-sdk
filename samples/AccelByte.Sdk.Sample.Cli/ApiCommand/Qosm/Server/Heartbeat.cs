using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Qosm
{
    [SdkConsoleCommand("qosm","heartbeat")]
    public class HeartbeatCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "Heartbeat"; } }

        [SdkCommandData("body")]
        public ModelsHeartbeatRequest Body { get; set; } = new ModelsHeartbeatRequest();
                
        public HeartbeatCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Server wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Server(_SDK);

            Heartbeat operation = new Heartbeat(
                Body                
            );            

            wrapper.Heartbeat(operation);
            return String.Empty;
        }
    }
}