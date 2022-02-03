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
    [SdkConsoleCommand("basic","publicgetuserprofilepublicinfobyids")]
    public class PublicGetUserProfilePublicInfoByIdsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Basic"; } }

        public string OperationName{ get { return "PublicGetUserProfilePublicInfoByIds"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userIds")]
        public string UserIds { get; set; }

        public PublicGetUserProfilePublicInfoByIdsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Basic.Wrapper.UserProfile wrapper = new AccelByte.Sdk.Api.Basic.Wrapper.UserProfile(_SDK);

            PublicGetUserProfilePublicInfoByIds operation = new PublicGetUserProfilePublicInfoByIds(
                Namespace,                
                UserIds                
            );            

            List<AccelByte.Sdk.Api.Basic.Model.UserProfilePublicInfo>? response = wrapper.PublicGetUserProfilePublicInfoByIds(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}