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
    [SdkConsoleCommand("leaderboard","createarchivedleaderboardrankingdatav1handler")]
    public class CreateArchivedLeaderboardRankingDataV1HandlerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "CreateArchivedLeaderboardRankingDataV1Handler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsArchiveLeaderboardReq Body { get; set; } = new ModelsArchiveLeaderboardReq();
                
        public CreateArchivedLeaderboardRankingDataV1HandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            CreateArchivedLeaderboardRankingDataV1Handler operation = new CreateArchivedLeaderboardRankingDataV1Handler(
                Namespace,                
                Body                
            );            
            
            wrapper.CreateArchivedLeaderboardRankingDataV1Handler(operation);
            return String.Empty;
        }
    }
}