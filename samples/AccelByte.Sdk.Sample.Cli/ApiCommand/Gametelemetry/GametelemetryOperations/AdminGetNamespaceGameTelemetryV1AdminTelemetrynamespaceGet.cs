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
    [SdkConsoleCommand("gametelemetry","admingetnamespacegametelemetryv1admintelemetrynamespaceget")]
    public class AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet"; } }

        public AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGetCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.GametelemetryOperations(_SDK);

            AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet operation = new AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(
            );            
            
            wrapper.AdminGetNamespaceGameTelemetryV1AdminTelemetrynamespaceGet(operation);
            return String.Empty;
        }
    }
}