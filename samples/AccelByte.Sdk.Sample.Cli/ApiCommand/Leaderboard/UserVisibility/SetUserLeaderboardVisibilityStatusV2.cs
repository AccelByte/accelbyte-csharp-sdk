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
    [SdkConsoleCommand("leaderboard","setuserleaderboardvisibilitystatusv2")]
    public class SetUserLeaderboardVisibilityStatusV2Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "SetUserLeaderboardVisibilityStatusV2"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsSetUserVisibilityRequest Body { get; set; } = new ModelsSetUserVisibilityRequest();
                
        public SetUserLeaderboardVisibilityStatusV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibility wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.UserVisibility(_SDK);

            SetUserLeaderboardVisibilityStatusV2 operation = new SetUserLeaderboardVisibilityStatusV2(
                LeaderboardCode,                
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetUserVisibilityResponse? response = wrapper.SetUserLeaderboardVisibilityStatusV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}