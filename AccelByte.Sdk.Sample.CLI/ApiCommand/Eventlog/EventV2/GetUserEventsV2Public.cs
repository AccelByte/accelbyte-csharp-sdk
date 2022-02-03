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
    [SdkConsoleCommand("eventlog","getusereventsv2public")]
    public class GetUserEventsV2PublicCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetUserEventsV2Public"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("eventName")]
        public string? EventName { get; set; }

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("pageSize")]
        public double? PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        public GetUserEventsV2PublicCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2 wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2(_SDK);

            GetUserEventsV2Public operation = new GetUserEventsV2Public(
                Namespace,                
                UserId,                
                EndDate,                
                EventName,                
                Offset,                
                PageSize,                
                StartDate                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponseV2? response = wrapper.GetUserEventsV2Public(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}