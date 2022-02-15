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
    [SdkConsoleCommand("leaderboard","getleaderboardconfigurationsadminv1")]
    public class GetLeaderboardConfigurationsAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "GetLeaderboardConfigurationsAdminV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("isArchived")]
        public bool? IsArchived { get; set; }

        [SdkCommandArgument("isDeleted")]
        public bool? IsDeleted { get; set; }

        [SdkCommandArgument("limit")]
        public long? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public long? Offset { get; set; }

        public GetLeaderboardConfigurationsAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration(_SDK);

            GetLeaderboardConfigurationsAdminV1 operation = new GetLeaderboardConfigurationsAdminV1(
                Namespace,                
                IsArchived,                
                IsDeleted,                
                Limit,                
                Offset                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsGetAllLeaderboardConfigsResp? response = wrapper.GetLeaderboardConfigurationsAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}