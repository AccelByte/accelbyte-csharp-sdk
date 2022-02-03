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
    [SdkConsoleCommand("eventlog","getregisteredeventsbyeventtypehandler")]
    public class GetRegisteredEventsByEventTypeHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetRegisteredEventsByEventTypeHandler"; } }

        [SdkCommandArgument("eventType")]
        public string EventType { get; set; } = String.Empty;

        public GetRegisteredEventsByEventTypeHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry(_SDK);

            GetRegisteredEventsByEventTypeHandler operation = new GetRegisteredEventsByEventTypeHandler(
                EventType                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventRegistry? response = wrapper.GetRegisteredEventsByEventTypeHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}