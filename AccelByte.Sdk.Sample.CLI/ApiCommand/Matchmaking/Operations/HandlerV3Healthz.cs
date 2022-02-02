using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking","handlerv3healthz")]
    public class HandlerV3HealthzCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "HandlerV3Healthz"; } }

        public HandlerV3HealthzCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Operations(_SDK);

            HandlerV3Healthz operation = new HandlerV3Healthz(
            );            

            wrapper.HandlerV3Healthz(operation);
            return String.Empty;
        }
    }
}