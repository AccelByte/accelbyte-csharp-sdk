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
    [SdkConsoleCommand("achievement", "adminanonymizeuserachievement")]
    public class AdminAnonymizeUserAchievementCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Achievement"; } }

        public string OperationName { get { return "AdminAnonymizeUserAchievement"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public AdminAnonymizeUserAchievementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Anonymization wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Anonymization(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Achievement.Operation.AdminAnonymizeUserAchievement.Builder;





            AdminAnonymizeUserAchievement operation = opBuilder.Build(
                Namespace,
                UserId
            );


            wrapper.AdminAnonymizeUserAchievement(operation);
            return String.Empty;
        }
    }
}