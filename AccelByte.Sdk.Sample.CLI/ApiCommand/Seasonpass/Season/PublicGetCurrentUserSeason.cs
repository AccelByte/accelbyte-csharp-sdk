using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","publicgetcurrentuserseason")]
    public class PublicGetCurrentUserSeasonCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "PublicGetCurrentUserSeason"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public PublicGetCurrentUserSeasonCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            PublicGetCurrentUserSeason operation = new PublicGetCurrentUserSeason(
                Namespace,                
                UserId                
            );            

            AccelByte.Sdk.Api.Seasonpass.Model.ClaimableUserSeasonInfo? response = wrapper.PublicGetCurrentUserSeason(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}