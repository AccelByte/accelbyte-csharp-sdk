// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","updatexbluserachievement")]
    public class UpdateXblUserAchievementCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "UpdateXblUserAchievement"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ADTOObjectForUpdateXboxAchievementCompletePercentageAPI Body { get; set; } = new ADTOObjectForUpdateXboxAchievementCompletePercentageAPI();
                
        public UpdateXblUserAchievementCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.AchievementPlatform wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.AchievementPlatform(_SDK);

            UpdateXblUserAchievement operation = new UpdateXblUserAchievement(
                Namespace,                
                UserId,                
                Body                
            );            
            
            wrapper.UpdateXblUserAchievement(operation);
            return String.Empty;
        }
    }
}