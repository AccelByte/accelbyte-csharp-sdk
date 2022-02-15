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
    [SdkConsoleCommand("sessionbrowser","getrecentplayer")]
    public class GetRecentPlayerCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "GetRecentPlayer"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userID")]
        public string UserID { get; set; } = String.Empty;

        public GetRecentPlayerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            GetRecentPlayer operation = new GetRecentPlayer(
                Namespace,                
                UserID                
            );            
            
            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsRecentPlayerQueryResponse? response = wrapper.GetRecentPlayer(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}