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
    [SdkConsoleCommand("sessionbrowser","getactivecustomgamesessions")]
    public class GetActiveCustomGameSessionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "GetActiveCustomGameSessions"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("serverRegion")]
        public string? ServerRegion { get; set; }

        [SdkCommandArgument("sessionId")]
        public string? SessionId { get; set; }

        public GetActiveCustomGameSessionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            GetActiveCustomGameSessions operation = new GetActiveCustomGameSessions(
                Namespace,                
                ServerRegion,                
                SessionId                
            );            

            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsActiveCustomGameResponse? response = wrapper.GetActiveCustomGameSessions(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}