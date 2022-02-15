using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Matchmaking.Wrapper;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Matchmaking
{
    [SdkConsoleCommand("matchmaking","searchsessions")]
    public class SearchSessionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Matchmaking"; } }

        public string OperationName{ get { return "SearchSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("channel")]
        public string? Channel { get; set; }

        [SdkCommandArgument("deleted")]
        public bool? Deleted { get; set; }

        [SdkCommandArgument("matchID")]
        public string? MatchID { get; set; }

        [SdkCommandArgument("partyID")]
        public string? PartyID { get; set; }

        [SdkCommandArgument("userID")]
        public string? UserID { get; set; }

        [SdkCommandArgument("limit")]
        public double Limit { get; set; } = 0.0;

        [SdkCommandArgument("offset")]
        public double Offset { get; set; } = 0.0;

        public SearchSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking wrapper = new AccelByte.Sdk.Api.Matchmaking.Wrapper.Matchmaking(_SDK);

            SearchSessions operation = new SearchSessions(
                Namespace,                
                Channel,                
                Deleted,                
                MatchID,                
                PartyID,                
                UserID,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Matchmaking.Model.ServiceGetSessionHistorySearchResponse? response = wrapper.SearchSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}