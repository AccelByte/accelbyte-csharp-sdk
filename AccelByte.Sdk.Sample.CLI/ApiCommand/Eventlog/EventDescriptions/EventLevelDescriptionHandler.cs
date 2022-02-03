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
    [SdkConsoleCommand("eventlog","eventleveldescriptionhandler")]
    public class EventLevelDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "EventLevelDescriptionHandler"; } }

        public EventLevelDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            EventLevelDescriptionHandler operation = new EventLevelDescriptionHandler(
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleEventLevel? response = wrapper.EventLevelDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}