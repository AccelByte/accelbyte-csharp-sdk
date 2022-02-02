using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Dslogmanager.Wrapper;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Dslogmanager
{
    [SdkConsoleCommand("dslogmanager","batchdownloadserverlogs")]
    public class BatchDownloadServerLogsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dslogmanager"; } }

        public string OperationName{ get { return "BatchDownloadServerLogs"; } }

        [SdkCommandData("body")]
        public ModelsBatchDownloadLogsRequest? Body { get; set; }
                
        public BatchDownloadServerLogsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers wrapper = new AccelByte.Sdk.Api.Dslogmanager.Wrapper.AllTerminatedServers(_SDK);

            BatchDownloadServerLogs operation = new BatchDownloadServerLogs(
                Body                
            );            

            wrapper.BatchDownloadServerLogs(operation);
            return String.Empty;
        }
    }
}