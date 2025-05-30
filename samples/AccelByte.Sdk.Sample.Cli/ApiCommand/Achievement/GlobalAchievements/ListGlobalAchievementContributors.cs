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

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement", "listglobalachievementcontributors")]
    public class ListGlobalAchievementContributorsCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Achievement"; } }

        public string OperationName { get { return "ListGlobalAchievementContributors"; } }

        [SdkCommandArgument("achievementCode")]
        public string AchievementCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        public ListGlobalAchievementContributorsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.GlobalAchievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.GlobalAchievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.ListGlobalAchievementContributors.Builder;

            if (Limit != null)
                opBuilder.SetLimit((long)Limit);
            if (Offset != null)
                opBuilder.SetOffset((long)Offset);
            if (SortBy != null)
                opBuilder.SetSortBy(ListGlobalAchievementContributorsSortBy.NewValue(SortBy));




            ListGlobalAchievementContributors operation = opBuilder.Build(
                AchievementCode,
                Namespace
            );


            AccelByte.Sdk.Api.Achievement.Model.ModelsPaginatedContributorResponse? response = wrapper.ListGlobalAchievementContributors(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}