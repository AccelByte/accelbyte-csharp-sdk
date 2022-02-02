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
    [SdkConsoleCommand("matchmaking","bulkgetsessions")]
    public class BulkGetSessionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "BulkGetSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("matchIDs")]
        public string? MatchIDs { get; set; }

        public BulkGetSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            BulkGetSessions operation = new BulkGetSessions(
                Namespace,                
                MatchIDs                
            );            

            List<AccelByte.Sdk.Api.Matchmaking.Model.ModelsMatchmakingResult>? response = wrapper.BulkGetSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}