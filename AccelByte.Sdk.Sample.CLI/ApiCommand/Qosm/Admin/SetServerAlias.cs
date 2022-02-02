using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Qosm.Wrapper;
using AccelByte.Sdk.Api.Qosm.Model;
using AccelByte.Sdk.Api.Qosm.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Qosm
{
    [SdkConsoleCommand("qosm","setserveralias")]
    public class SetServerAliasCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Qosm"; } }

        public string OperationName{ get { return "SetServerAlias"; } }

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsSetAliasRequest? Body { get; set; }
                
        public SetServerAliasCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Qosm.Wrapper.Admin wrapper = new AccelByte.Sdk.Api.Qosm.Wrapper.Admin(_SDK);

            SetServerAlias operation = new SetServerAlias(
                Region,                
                Body                
            );            

            wrapper.SetServerAlias(operation);
            return String.Empty;
        }
    }
}