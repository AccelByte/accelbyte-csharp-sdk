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
    [SdkConsoleCommand("leaderboard","updateuserpointadminv1")]
    public class UpdateUserPointAdminV1Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Leaderboard"; } }

        public string OperationName{ get { return "UpdateUserPointAdminV1"; } }

        [SdkCommandArgument("leaderboardCode")]
        public string LeaderboardCode { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUpdateUserPointAdminV1Request Body { get; set; } = new ModelsUpdateUserPointAdminV1Request();
                
        public UpdateUserPointAdminV1Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData wrapper = new AccelByte.Sdk.Api.Leaderboard.Wrapper.LeaderboardData(_SDK);

            UpdateUserPointAdminV1 operation = new UpdateUserPointAdminV1(
                LeaderboardCode,                
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Leaderboard.Model.ModelsUpdateUserPointAdminV1Response? response = wrapper.UpdateUserPointAdminV1(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}