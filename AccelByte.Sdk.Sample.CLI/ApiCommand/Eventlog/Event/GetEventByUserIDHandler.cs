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
    [SdkConsoleCommand("eventlog","geteventbyuseridhandler")]
    public class GetEventByUserIDHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetEventByUserIDHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("endDate")]
        public string EndDate { get; set; }

        [SdkCommandArgument("pageSize")]
        public double PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string StartDate { get; set; }

        public GetEventByUserIDHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.Event wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.Event(_SDK);

            GetEventByUserIDHandler operation = new GetEventByUserIDHandler(
                Namespace,                
                UserId,                
                Offset,                
                EndDate,                
                PageSize,                
                StartDate                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponse? response = wrapper.GetEventByUserIDHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}