using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Sessionbrowser.Wrapper;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Api.Sessionbrowser.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Sessionbrowser
{
    [SdkConsoleCommand("sessionbrowser","joinsession")]
    public class JoinSessionCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Sessionbrowser"; } }

        public string OperationName{ get { return "JoinSession"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("sessionID")]
        public string SessionID { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsJoinGameSessionRequest? Body { get; set; }
                
        public JoinSessionCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session wrapper = new AccelByte.Sdk.Api.Sessionbrowser.Wrapper.Session(_SDK);

            JoinSession operation = new JoinSession(
                Namespace,                
                SessionID,                
                Body                
            );            

            AccelByte.Sdk.Api.Sessionbrowser.Model.ModelsSessionResponse? response = wrapper.JoinSession(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}