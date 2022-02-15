using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","admincreatechannel")]
    public class AdminCreateChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminCreateChannel"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsChannelRequest Body { get; set; } = new ModelsChannelRequest();
                
        public AdminCreateChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel(_SDK);

            AdminCreateChannel operation = new AdminCreateChannel(
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsChannelResponse? response = wrapper.AdminCreateChannel(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}