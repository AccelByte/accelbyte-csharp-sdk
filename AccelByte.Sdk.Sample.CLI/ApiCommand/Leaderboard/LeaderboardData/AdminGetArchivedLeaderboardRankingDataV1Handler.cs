using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","admingetarchivedleaderboardrankingdatav1handler")]
    public class AdminGetArchivedLeaderboardRankingDataV1HandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "AdminGetArchivedLeaderboardRankingDataV1Handler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("slug")]
        public string? Slug { get; set; }

        [SdkCommandArgument("leaderboardCodes")]
        public string LeaderboardCodes { get; set; }

        public AdminGetArchivedLeaderboardRankingDataV1HandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            AdminGetArchivedLeaderboardRankingDataV1Handler operation = new AdminGetArchivedLeaderboardRankingDataV1Handler(
                Namespace,                
                Slug,                
                LeaderboardCodes                
            );            

            List<AccelByte.Sdk.Api.Leaderboard.Model.ModelsArchiveLeaderboardSignedURLResponse>? response = wrapper.AdminGetArchivedLeaderboardRankingDataV1Handler(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}