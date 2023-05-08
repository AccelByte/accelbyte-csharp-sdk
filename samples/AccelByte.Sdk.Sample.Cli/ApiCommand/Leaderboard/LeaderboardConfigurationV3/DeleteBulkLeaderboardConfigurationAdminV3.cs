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
    [SdkConsoleCommand("leaderboard", "deletebulkleaderboardconfigurationadminv3")]
    public class DeleteBulkLeaderboardConfigurationAdminV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "DeleteBulkLeaderboardConfigurationAdminV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsDeleteBulkLeaderboardsReq Body { get; set; } = new ModelsDeleteBulkLeaderboardsReq();

        public DeleteBulkLeaderboardConfigurationAdminV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfigurationV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.DeleteBulkLeaderboardConfigurationAdminV3.Builder;





            DeleteBulkLeaderboardConfigurationAdminV3 operation = opBuilder.Build(
                Body,
                Namespace
            );


            AccelByte.Sdk.Api.Leaderboard.Model.ModelsDeleteBulkLeaderboardsResp? response = wrapper.DeleteBulkLeaderboardConfigurationAdminV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}