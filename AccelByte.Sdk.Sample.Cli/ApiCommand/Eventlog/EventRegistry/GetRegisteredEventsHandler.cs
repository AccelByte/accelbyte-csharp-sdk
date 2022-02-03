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
    [SdkConsoleCommand("eventlog","getregisteredeventshandler")]
    public class GetRegisteredEventsHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetRegisteredEventsHandler"; } }

        public GetRegisteredEventsHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventRegistry(_SDK);

            GetRegisteredEventsHandler operation = new GetRegisteredEventsHandler(
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventRegistry? response = wrapper.GetRegisteredEventsHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}