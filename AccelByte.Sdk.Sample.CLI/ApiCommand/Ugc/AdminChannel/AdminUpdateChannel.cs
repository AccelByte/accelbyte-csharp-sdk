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
    [SdkConsoleCommand("ugc","adminupdatechannel")]
    public class AdminUpdateChannelCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminUpdateChannel"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsChannelRequest? Body { get; set; }
                
        public AdminUpdateChannelCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminChannel(_SDK);

            AdminUpdateChannel operation = new AdminUpdateChannel(
                ChannelId,                
                Namespace,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsChannelResponse? response = wrapper.AdminUpdateChannel(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}