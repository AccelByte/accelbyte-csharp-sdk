// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
        public string EndDate { get; set; } = String.Empty;

        [SdkCommandArgument("pageSize")]
        public double PageSize { get; set; } = 0.0;

        [SdkCommandArgument("startDate")]
        public string StartDate { get; set; } = String.Empty;

        public GetEventByEventTypeHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.Event wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.Event(_SDK);

            #pragma warning disable ab_deprecated_operation
            GetEventByEventTypeHandler operation = new GetEventByEventTypeHandler(
                EventType,                
                Namespace,                
                Offset,                
                EndDate,                
                PageSize,                
                StartDate                
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponse? response = wrapper.GetEventByEventTypeHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}