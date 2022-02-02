using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Social
{
    [SdkConsoleCommand("social","publicgetusergameprofiles")]
    public class PublicGetUserGameProfilesCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicGetUserGameProfiles"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userIds")]
        public List<string> UserIds { get; set; }

        public PublicGetUserGameProfilesCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.GameProfile wrapper = new AccelByte.Sdk.Api.Social.Wrapper.GameProfile(_SDK);

            PublicGetUserGameProfiles operation = new PublicGetUserGameProfiles(
                Namespace,                
                UserIds                
            );            

            List<AccelByte.Sdk.Api.Social.Model.UserGameProfiles>? response = wrapper.PublicGetUserGameProfiles(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}