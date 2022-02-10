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
    [SdkConsoleCommand("leaderboard","deletebulkleaderboardconfigurationadminv1")]
    public class DeleteBulkLeaderboardConfigurationAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "DeleteBulkLeaderboardConfigurationAdminV1"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsDeleteBulkLeaderboardsReq Body { get; set; } = new ModelsDeleteBulkLeaderboardsReq();
                
        public DeleteBulkLeaderboardConfigurationAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardConfiguration(_SDK);

            DeleteBulkLeaderboardConfigurationAdminV1 operation = new DeleteBulkLeaderboardConfigurationAdminV1(
                Namespace,                
                Body                
            );            

            AccelByte.Sdk.Api.Leaderboard.Model.ModelsDeleteBulkLeaderboardsResp? response = wrapper.DeleteBulkLeaderboardConfigurationAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}