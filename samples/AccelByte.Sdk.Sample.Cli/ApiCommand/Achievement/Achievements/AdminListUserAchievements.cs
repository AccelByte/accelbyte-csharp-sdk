using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Achievement.Wrapper;
using AccelByte.Sdk.Api.Achievement.Model;
using AccelByte.Sdk.Api.Achievement.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Achievement
{
    [SdkConsoleCommand("achievement","adminlistuserachievements")]
    public class AdminListUserAchievementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Achievement"; } }

        public string OperationName{ get { return "AdminListUserAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("preferUnlocked")]
        public bool? PreferUnlocked { get; set; }

        public AdminListUserAchievementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Achievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Achievements(_SDK);

            AdminListUserAchievements operation = new AdminListUserAchievements(
                Namespace,                
                UserId,                
                Limit,                
                Offset,                
                PreferUnlocked                
            );            
            
            AccelByte.Sdk.Api.Achievement.Model.ModelsPaginatedUserAchievementResponse? response = wrapper.AdminListUserAchievements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}