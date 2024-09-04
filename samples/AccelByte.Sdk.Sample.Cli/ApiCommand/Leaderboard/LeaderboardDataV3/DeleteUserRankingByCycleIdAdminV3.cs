// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard", "deleteuserrankingbycycleidadminv3")]
    public class DeleteUserRankingByCycleIdAdminV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "DeleteUserRankingByCycleIdAdminV3"; } }

        [SdkCommandArgument("cycleId")]
        public string CycleId { get; set; } = String.Empty;

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public DeleteUserRankingByCycleIdAdminV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardDataV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.DeleteUserRankingByCycleIdAdminV3.Builder;





            DeleteUserRankingByCycleIdAdminV3 operation = opBuilder.Build(
                CycleId,
                LeaderboardCode,
                Namespace,
                UserId
            );


            wrapper.DeleteUserRankingByCycleIdAdminV3(operation);
            return String.Empty;
        }
    }
}