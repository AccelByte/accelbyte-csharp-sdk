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
    [SdkConsoleCommand("eventlog","eventiddescriptionhandler")]
    public class EventIDDescriptionHandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Eventlog"; } }

        public string OperationName{ get { return "EventIDDescriptionHandler"; } }

        public EventIDDescriptionHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions wrapper = new AccelByte.Sdk.Api.Eventlog.Wrapper.EventDescriptions(_SDK);

            #pragma warning disable ab_deprecated_operation
            EventIDDescriptionHandler operation = new EventIDDescriptionHandler(
            );            
            #pragma warning restore ab_deprecated_operation
            
            #pragma warning disable ab_deprecated_operation_wrapper
            AccelByte.Sdk.Api.Eventlog.Model.ModelsMultipleEventID? response = wrapper.EventIDDescriptionHandler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
            #pragma warning restore ab_deprecated_operation_wrapper
        }
    }
}