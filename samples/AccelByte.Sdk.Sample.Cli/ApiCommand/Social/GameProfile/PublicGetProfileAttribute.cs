// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.


using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Social.Wrapper;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Social
{
    [SdkConsoleCommand("social", "publicgetprofileattribute")]
    public class PublicGetProfileAttributeCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Social"; } }

        public string OperationName { get { return "PublicGetProfileAttribute"; } }

        [SdkCommandArgument("attributeName")]
        public string AttributeName { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("profileId")]
        public string ProfileId { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        public PublicGetProfileAttributeCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Social.Wrapper.GameProfile wrapper = new AccelByte.Sdk.Api.Social.Wrapper.GameProfile(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Social.Operation.PublicGetProfileAttribute.Builder;





            PublicGetProfileAttribute operation = opBuilder.Build(
                AttributeName,
                Namespace,
                ProfileId,
                UserId
            );


            AccelByte.Sdk.Api.Social.Model.Attribute? response = wrapper.PublicGetProfileAttribute(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}