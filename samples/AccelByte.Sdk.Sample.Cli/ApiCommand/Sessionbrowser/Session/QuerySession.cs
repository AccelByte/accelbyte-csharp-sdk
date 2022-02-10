using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser","querysession")]
    public class QuerySessionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "QuerySession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("gameMode")]
        public string? GameMode { get; set; }

        [SdkCommandArgument("gameVersion")]
        public string? GameVersion { get; set; }

        [SdkCommandArgument("joinable")]
        public string? Joinable { get; set; }

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("matchExist")]
        public string? MatchExist { get; set; }

        [SdkCommandArgument("matchId")]
        public string? MatchId { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        [SdkCommandArgument("serverStatus")]
        public string? ServerStatus { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        [SdkCommandArgument("sessionType")]
        public string SessionType { get; set; } = String.Empty;

        public QuerySessionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            QuerySession operation = new QuerySession(
                Namespace,                
                GameMode,                
                GameVersion,                
                Joinable,                
                Limit,                
                MatchExist,                
                MatchId,                
                Offset,                
                ServerStatus,                
                UserId,                
                SessionType                
            );            

            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsSessionQueryResponse? response = wrapper.QuerySession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}