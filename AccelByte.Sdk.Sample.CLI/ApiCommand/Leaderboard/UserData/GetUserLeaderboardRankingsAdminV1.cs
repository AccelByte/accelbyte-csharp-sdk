using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Leaderboard.Wrapper;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Api.Leaderboard.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Leaderboard
{
    [SdkConsoleCommand("leaderboard","getuserleaderboardrankingsadminv1")]
    public class GetUserLeaderboardRankingsAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetUserLeaderboardRankingsAdminV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetUserLeaderboardRankingsAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.UserData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.UserData(_SDK);

            GetUserLeaderboardRankingsAdminV1 operation = new GetUserLeaderboardRankingsAdminV1(
                Namespace,                
                UserId,                
                Limit,                
                Offset                
            );            

            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetAllUserLeaderboardsResp? response = wrapper.GetUserLeaderboardRankingsAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}