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
    [SdkConsoleCommand("social","publicupdateattribute")]
    public class PublicUpdateAttributeCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Social"; } }

        public string OperationName{ get { return "PublicUpdateAttribute"; } }

        [SdkCommandArgument("attributeName")]
        public string AttributeName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("profileId")]
        public string ProfileId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public AccelByte.Sdk.Api.Social.Model.Attribute? Body { get; set; }
                
        public PublicUpdateAttributeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.GameProfile wrapper = new AccelByte.Sdk.Api.Social.Wrapper.GameProfile(_SDK);

            PublicUpdateAttribute operation = new PublicUpdateAttribute(
                AttributeName,                
                Namespace,                
                ProfileId,                
                UserId,                
                Body                
            );            

            AccelByte.Sdk.Api.Social.Model.GameProfileInfo? response = wrapper.PublicUpdateAttribute(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}