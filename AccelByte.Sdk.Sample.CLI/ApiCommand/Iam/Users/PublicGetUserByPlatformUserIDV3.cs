using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.CLI.Command;

using AccelByte.Sdk.Api.Iam.Wrapper;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Api.Iam.Operation;

namespace AccelByte.Sdk.Sample.CLI.ApiCommand.Iam
{
    [SdkConsoleCommand("iam","publicgetuserbyplatformuseridv3")]
    public class PublicGetUserByPlatformUserIDV3Command: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Iam"; } }

        public string OperationName{ get { return "PublicGetUserByPlatformUserIDV3"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("platformId")]
        public string PlatformId { get; set; } = String.Empty;

        [SdkCommandArgument("platformUserId")]
        public string PlatformUserId { get; set; } = String.Empty;

        public PublicGetUserByPlatformUserIDV3Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Iam.Wrapper.Users wrapper = new AccelByte.Sdk.Api.Iam.Wrapper.Users(_SDK);

            PublicGetUserByPlatformUserIDV3 operation = new PublicGetUserByPlatformUserIDV3(
                Namespace,                
                PlatformId,                
                PlatformUserId                
            );            

            AccelByte.Sdk.Api.Iam.Model.ModelUserResponseV3? response = wrapper.PublicGetUserByPlatformUserIDV3(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}