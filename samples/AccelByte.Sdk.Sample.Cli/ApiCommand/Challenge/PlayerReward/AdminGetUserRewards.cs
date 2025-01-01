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

using AccelByte.Sdk.Api.Challenge.Wrapper;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Api.Challenge.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Challenge
{
    [SdkConsoleCommand("challenge", "admingetuserrewards")]
    public class AdminGetUserRewardsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Challenge"; } }

        public string OperationName { get { return "AdminGetUserRewards"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("challengeCode")]
        public string? ChallengeCode { get; set; }

        [SdkCommandArgument("goalProgressionId")]
        public string? GoalProgressionId { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("status")]
        public string? Status { get; set; }

        public AdminGetUserRewardsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward wrapper = new AccelByte.Sdk.Api.Challenge.Wrapper.PlayerReward(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Challenge.Operation.AdminGetUserRewards.Builder;

            if (ChallengeCode != null)
                opBuilder.SetChallengeCode((string)ChallengeCode);
            if (GoalProgressionId != null)
                opBuilder.SetGoalProgressionId((string)GoalProgressionId);
            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(AdminGetUserRewardsSortBy.NewValue(SortBy));
            if (Status != null)
                opBuilder.SetStatus(AdminGetUserRewardsStatus.NewValue(Status));




            AdminGetUserRewards operation = opBuilder.Build(
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Challenge.Model.ModelListUserRewardsResponse? response = wrapper.AdminGetUserRewards(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}