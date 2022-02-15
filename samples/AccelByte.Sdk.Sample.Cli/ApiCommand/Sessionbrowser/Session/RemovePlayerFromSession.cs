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
    [SdkConsoleCommand("sessionbrowser","removeplayerfromsession")]
    public class RemovePlayerFromSessionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "RemovePlayerFromSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionID")]
        public string SessionID { get; set; } = String.Empty;

        [SdkCommandArgument("userID")]
        public string UserID { get; set; } = String.Empty;

        public RemovePlayerFromSessionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            RemovePlayerFromSession operation = new RemovePlayerFromSession(
                Namespace,                
                SessionID,                
                UserID                
            );            
            
            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsAddPlayerResponse? response = wrapper.RemovePlayerFromSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}