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
    [SdkConsoleCommand("eventlog","getpublicedithistory")]
    public class GetPublicEditHistoryCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "GetPublicEditHistory"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("endDate")]
        public string? EndDate { get; set; }

        [SdkCommandArgument("offset")]
        public double? Offset { get; set; }

        [SdkCommandArgument("pageSize")]
        public double? PageSize { get; set; }

        [SdkCommandArgument("startDate")]
        public string? StartDate { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        public GetPublicEditHistoryCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2 wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventV2(_SDK);

            GetPublicEditHistory operation = new GetPublicEditHistory(
                Namespace,                
                UserId,                
                EndDate,                
                Offset,                
                PageSize,                
                StartDate,                
                Type                
            );            
            
            AccelByte.Sdk.Api.Eventlog.Model.ModelsEventResponseV2? response = wrapper.GetPublicEditHistory(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}