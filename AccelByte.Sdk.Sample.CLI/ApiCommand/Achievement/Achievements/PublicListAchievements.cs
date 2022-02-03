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
    [SdkConsoleCommand("achievement","publiclistachievements")]
    public class PublicListAchievementsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Achievement"; } }

        public string OperationName{ get { return "PublicListAchievements"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        [SdkCommandArgument("sortBy")]
        public string? SortBy { get; set; }

        [SdkCommandArgument("language")]
        public string Language { get; set; }

        public PublicListAchievementsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Achievement.Wrapper.Achievements wrapper = new AccelByte.Sdk.Api.Achievement.Wrapper.Achievements(_SDK);

            PublicListAchievements operation = new PublicListAchievements(
                Namespace,                
                Limit,                
                Offset,                
                SortBy,                
                Language                
            );            

            AccelByte.Sdk.Api.Achievement.Model.ModelsPublicAchievementsResponse? response = wrapper.PublicListAchievements(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}