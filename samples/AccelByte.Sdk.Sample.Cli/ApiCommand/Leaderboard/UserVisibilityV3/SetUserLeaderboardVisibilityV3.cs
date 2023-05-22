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
    [SdkConsoleCommand("leaderboard", "setuserleaderboardvisibilityv3")]
    public class SetUserLeaderboardVisibilityV3Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Leaderboard"; } }

        public string OperationName { get { return "SetUserLeaderboardVisibilityV3"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsSetUserVisibilityRequest Body { get; set; } = new ModelsSetUserVisibilityRequest();

        public SetUserLeaderboardVisibilityV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibilityV3 wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibilityV3(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Leaderboard.Operation.SetUserLeaderboardVisibilityV3.Builder;





            SetUserLeaderboardVisibilityV3 operation = opBuilder.Build(
                Body,
                LeaderboardCode,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetUserVisibilityResponse? response = wrapper.SetUserLeaderboardVisibilityV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}