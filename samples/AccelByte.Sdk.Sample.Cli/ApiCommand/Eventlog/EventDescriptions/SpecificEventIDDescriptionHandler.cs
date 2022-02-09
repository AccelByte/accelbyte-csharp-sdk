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
    [SdkConsoleCommand("eventlog","specificeventiddescriptionhandler")]
    public class SpecificEventIDDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "SpecificEventIDDescriptionHandler"; } }

        [SdkCommandArgument("eventIds")]
        public string? EventIds { get; set; }

        public SpecificEventIDDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            SpecificEventIDDescriptionHandler operation = new SpecificEventIDDescriptionHandler(
                EventIds                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleEventID? response = wrapper.SpecificEventIDDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}