// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Gametelemetry.Wrapper;
using AccelByte.Sdk.Api.Gametelemetry.Model;
using AccelByte.Sdk.Api.Gametelemetry.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Gametelemetry
{
    [SdkConsoleCommand("gametelemetry","admingeteventsgametelemetryv1admineventsget")]
    public class AdminGetEventsGameTelemetryV1AdminEventsGetCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "AdminGetEventsGameTelemetryV1AdminEventsGet"; } }

        [SdkCommandArgument("namespace_")]
        public string Namespace { get; set; } = String.Empty;

        public AdminGetEventsGameTelemetryV1AdminEventsGetCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations(_SDK);

            AdminGetEventsGameTelemetryV1AdminEventsGet operation = new AdminGetEventsGameTelemetryV1AdminEventsGet(
                Namespace                
            );            
            
            wrapper.AdminGetEventsGameTelemetryV1AdminEventsGet(operation);
            return String.Empty;
        }
    }
}