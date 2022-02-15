using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Basic.Wrapper;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Api.Basic.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Basic
{
    [SdkConsoleCommand("basic","publicupdateuserprofilestatus")]
    public class PublicUpdateUserProfileStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "PublicUpdateUserProfileStatus"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public UserProfileStatusUpdate Body { get; set; } = new UserProfileStatusUpdate();
                
        public PublicUpdateUserProfileStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserProfile wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserProfile(_SDK);

            PublicUpdateUserProfileStatus operation = new PublicUpdateUserProfileStatus(
                Namespace,                
                UserId,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Basic.Model.UserProfileInfo? response = wrapper.PublicUpdateUserProfileStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}