// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("leaderboard","getcurrentweekleaderboardrankingadminv1")]
    public class GetCurrentWeekLeaderboardRankingAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetCurrentWeekLeaderboardRankingAdminV1"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetCurrentWeekLeaderboardRankingAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            GetCurrentWeekLeaderboardRankingAdminV1 operation = new GetCurrentWeekLeaderboardRankingAdminV1(
                LeaderboardCode,                
                Namespace,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetLeaderboardRankingResp? response = wrapper.GetCurrentWeekLeaderboardRankingAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}