using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Eventlog
{
    [SdkConsoleCommand("eventlog","unregistereventidhandler")]
    public class UnregisterEventIDHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "UnregisterEventIDHandler"; } }

        [SdkCommandArgument("eventId")]
        public string EventId { get; set; } = String.Empty;

        public UnregisterEventIDHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry(_SDK);

            UnregisterEventIDHandler operation = new UnregisterEventIDHandler(
                EventId                
            );            

            wrapper.UnregisterEventIDHandler(operation);
            return String.Empty;
        }
    }
}