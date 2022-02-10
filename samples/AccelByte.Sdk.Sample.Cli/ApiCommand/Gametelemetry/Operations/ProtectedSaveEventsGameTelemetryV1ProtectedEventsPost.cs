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
    [SdkConsoleCommand("gametelemetry","protectedsaveeventsgametelemetryv1protectedeventspost")]
    public class ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Gametelemetry"; } }

        public string OperationName{ get { return "ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost"; } }

        [SdkCommandData("body")]
        public List<TelemetryBody> Body { get; set; } = new List<TelemetryBody>();
                
        public ProtectedSaveEventsGameTelemetryV1ProtectedEventsPostCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Gametelemetry.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Gametelemetry.Wrapper.Operations(_SDK);

            ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost operation = new ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(
                Body                
            );            

            wrapper.ProtectedSaveEventsGameTelemetryV1ProtectedEventsPost(operation);
            return String.Empty;
        }
    }
}