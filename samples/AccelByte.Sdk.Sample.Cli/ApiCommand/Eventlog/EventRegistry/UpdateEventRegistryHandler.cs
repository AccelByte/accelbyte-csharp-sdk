using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Eventlog.Wrapper;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Api.Eventlog.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Eventlog
{
    [SdkConsoleCommand("eventlog","updateeventregistryhandler")]
    public class UpdateEventRegistryHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "UpdateEventRegistryHandler"; } }

        [SdkCommandArgument("eventId")]
        public string EventId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsEventRegistry Body { get; set; } = new ModelsEventRegistry();
                
        public UpdateEventRegistryHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry(_SDK);

            #pragma warning disable ab_deprecated_operation
            UpdateEventRegistryHandler operation = new UpdateEventRegistryHandler(
                EventId,                
                Body                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            wrapper.UpdateEventRegistryHandler(operation);
            return String.Empty;
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}