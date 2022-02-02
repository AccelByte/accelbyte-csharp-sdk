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
    [SdkConsoleCommand("eventlog","specificeventleveldescriptionhandler")]
    public class SpecificEventLevelDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "SpecificEventLevelDescriptionHandler"; } }

        [SdkCommandArgument("eventLevels")]
        public string? EventLevels { get; set; }

        public SpecificEventLevelDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            SpecificEventLevelDescriptionHandler operation = new SpecificEventLevelDescriptionHandler(
                EventLevels                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleEventLevel? response = wrapper.SpecificEventLevelDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}