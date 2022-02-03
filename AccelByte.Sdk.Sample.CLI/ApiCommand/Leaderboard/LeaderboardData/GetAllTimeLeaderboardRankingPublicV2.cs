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
    [SdkConsoleCommand("leaderboard","getalltimeleaderboardrankingpublicv2")]
    public class GetAllTimeLeaderboardRankingPublicV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetAllTimeLeaderboardRankingPublicV2"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetAllTimeLeaderboardRankingPublicV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            GetAllTimeLeaderboardRankingPublicV2 operation = new GetAllTimeLeaderboardRankingPublicV2(
                LeaderboardCode,                
                Namespace,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Leaderboard.Model.V2GetPublicLeaderboardRankingResponse? response = wrapper.GetAllTimeLeaderboardRankingPublicV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}