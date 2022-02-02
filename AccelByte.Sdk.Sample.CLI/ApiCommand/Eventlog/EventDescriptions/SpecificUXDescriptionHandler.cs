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
    [SdkConsoleCommand("eventlog","specificuxdescriptionhandler")]
    public class SpecificUXDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "SpecificUXDescriptionHandler"; } }

        [SdkCommandArgument("ux")]
        public string? Ux { get; set; }

        public SpecificUXDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            SpecificUXDescriptionHandler operation = new SpecificUXDescriptionHandler(
                Ux                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleUX? response = wrapper.SpecificUXDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}