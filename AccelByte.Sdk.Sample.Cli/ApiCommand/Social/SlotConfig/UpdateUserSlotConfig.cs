using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social","updateuserslotconfig")]
    public class UpdateUserSlotConfigCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "UpdateUserSlotConfig"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public SlotConfigUpdate? Body { get; set; }
                
        public UpdateUserSlotConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.SlotConfig wrapper = new AccelByte.Sdk.Api.Social.Wrapper.SlotConfig(_SDK);

            UpdateUserSlotConfig operation = new UpdateUserSlotConfig(
                Namespace,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Social.Model.UserSlotConfigInfo? response = wrapper.UpdateUserSlotConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}