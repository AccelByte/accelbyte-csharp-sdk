using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser","getactivematchmakinggamesessions")]
    public class GetActiveMatchmakingGameSessionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "GetActiveMatchmakingGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("matchId")]
        public string? MatchId { get; set; }

        [SdkCommandArgument("serverRegion")]
        public string? ServerRegion { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        public GetActiveMatchmakingGameSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            GetActiveMatchmakingGameSessions operation = new GetActiveMatchmakingGameSessions(
                Namespace,                
                MatchId,                
                ServerRegion,                
                SessionId                
            );            

            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsActiveMatchmakingGameResponse? response = wrapper.GetActiveMatchmakingGameSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}