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
    [SdkConsoleCommand("eventlog","geteventbyeventtypehandler")]
    public class GetEventByEventTypeHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetEventByEventTypeHandler"; } }

        [SdkCommandArgument("eventType")]
        public double EventType { get; set; } = 0;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("endDate")]
        public string EndDate { get; set; }

        [SdkCommandArgument("pageSize")]
        public double PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string StartDate { get; set; }

        public GetEventByEventTypeHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.Event wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.Event(_SDK);

            GetEventByEventTypeHandler operation = new GetEventByEventTypeHandler(
                EventType,                
                Namespace,                
                Offset,                
                EndDate,                
                PageSize,                
                StartDate                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponse? response = wrapper.GetEventByEventTypeHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}