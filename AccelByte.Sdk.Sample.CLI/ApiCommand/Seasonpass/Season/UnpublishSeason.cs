using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Seasonpass.Wrapper;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Api.Seasonpass.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Seasonpass
{
    [SdkConsoleCommand("seasonpass","unpublishseason")]
    public class UnpublishSeasonCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Seasonpass"; } }

        public string OperationName{ get { return "UnpublishSeason"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("seasonId")]
        public string SeasonId { get; set; } = String.Empty;

        [SdkCommandArgument("force")]
        public bool? Force { get; set; }

        public UnpublishSeasonCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Seasonpass.Wrapper.Season wrapper = new AccelByte.Sdk.Api.Seasonpass.Wrapper.Season(_SDK);

            UnpublishSeason operation = new UnpublishSeason(
                Namespace,                
                SeasonId,                
                Force                
            );            

            AccelByte.Sdk.Api.Seasonpass.Model.SeasonInfo? response = wrapper.UnpublishSeason(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}