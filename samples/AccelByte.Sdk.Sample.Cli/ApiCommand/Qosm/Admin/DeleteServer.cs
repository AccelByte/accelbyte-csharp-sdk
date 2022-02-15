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
    [SdkConsoleCommand("qosm","deleteserver")]
    public class DeleteServerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "DeleteServer"; } }

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        public DeleteServerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Admin wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Admin(_SDK);

            DeleteServer operation = new DeleteServer(
                Region                
            );            
            
            wrapper.DeleteServer(operation);
            return String.Empty;
        }
    }
}