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
    [SdkConsoleCommand("eventlog","agenttypedescriptionhandler")]
    public class AgentTypeDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "AgentTypeDescriptionHandler"; } }

        public AgentTypeDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            AgentTypeDescriptionHandler operation = new AgentTypeDescriptionHandler(
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleAgentType? response = wrapper.AgentTypeDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}