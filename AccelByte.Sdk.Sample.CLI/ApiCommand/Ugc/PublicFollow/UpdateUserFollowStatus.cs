using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc","updateuserfollowstatus")]
    public class UpdateUserFollowStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "UpdateUserFollowStatus"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsUserFollowRequest? Body { get; set; }
                
        public UpdateUserFollowStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicFollow wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicFollow(_SDK);

            UpdateUserFollowStatus operation = new UpdateUserFollowStatus(
                Namespace,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Ugc.Model.ModelsUserFollowResponse? response = wrapper.UpdateUserFollowStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}