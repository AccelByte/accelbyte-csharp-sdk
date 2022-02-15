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
    [SdkConsoleCommand("leaderboard","getcurrentseasonleaderboardrankingpublicv1")]
    public class GetCurrentSeasonLeaderboardRankingPublicV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetCurrentSeasonLeaderboardRankingPublicV1"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetCurrentSeasonLeaderboardRankingPublicV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            GetCurrentSeasonLeaderboardRankingPublicV1 operation = new GetCurrentSeasonLeaderboardRankingPublicV1(
                LeaderboardCode,                
                Namespace,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetLeaderboardRankingResp? response = wrapper.GetCurrentSeasonLeaderboardRankingPublicV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}