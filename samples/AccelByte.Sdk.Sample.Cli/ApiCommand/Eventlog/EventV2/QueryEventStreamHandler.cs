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
    [SdkConsoleCommand("eventlog","queryeventstreamhandler")]
    public class QueryEventStreamHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "QueryEventStreamHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("pageSize")]
        public double? PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandData("body")]
        public ModelsGenericQueryPayload Body { get; set; } = new ModelsGenericQueryPayload();
                
        public QueryEventStreamHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2 wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2(_SDK);

            QueryEventStreamHandler operation = new QueryEventStreamHandler(
                Namespace,                
                EndDate,                
                Offset,                
                PageSize,                
                StartDate,                
                Body                
            );            

            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponseV2? response = wrapper.QueryEventStreamHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}