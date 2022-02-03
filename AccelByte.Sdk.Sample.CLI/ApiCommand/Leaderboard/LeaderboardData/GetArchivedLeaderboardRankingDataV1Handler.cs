using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","getarchivedleaderboardrankingdatav1handler")]
    public class GetArchivedLeaderboardRankingDataV1HandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetArchivedLeaderboardRankingDataV1Handler"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slug")]
        public string? Slug { get; set; }

        [SdkCommandArgument("leaderboardCodes")]
        public string LeaderboardCodes { get; set; }

        public GetArchivedLeaderboardRankingDataV1HandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            GetArchivedLeaderboardRankingDataV1Handler operation = new GetArchivedLeaderboardRankingDataV1Handler(
                LeaderboardCode,                
                Namespace,                
                Slug,                
                LeaderboardCodes                
            );            

            List<AccelByte.Sdk.Api.Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>? response = wrapper.GetArchivedLeaderboardRankingDataV1Handler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}