using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dslogmanager
{
    [SdkConsoleCommand("dslogmanager","checkserverlogs")]
    public class CheckServerLogsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dslogmanager"; } }

        public string OperationName{ get { return "CheckServerLogs"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("podName")]
        public string PodName { get; set; } = String.Empty;

        public CheckServerLogsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.TerminatedServers(_SDK);

            CheckServerLogs operation = new CheckServerLogs(
                Namespace,                
                PodName                
            );            
            
            AccelByte.Sdk.Api.Dslogmanager.Model.ModelsLogFileStatus? response = wrapper.CheckServerLogs(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}