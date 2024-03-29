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
    [SdkConsoleCommand("achievement", "publicunlockachievement")]
    public class PublicUnlockAchievementCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Achievement"; } }

        public string OperationName { get { return "PublicUnlockAchievement"; } }

        [SdkCommandArgument("achievementCode")]
        public string AchievementCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public PublicUnlockAchievementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.UserAchievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.UserAchievements(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.PublicUnlockAchievement.Builder;





            PublicUnlockAchievement operation = opBuilder.Build(
                AchievementCode,
                Namespace,
                UserId
            );


            wrapper.PublicUnlockAchievement(operation);
            return String.Empty;
        }
    }
}