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

using AccelByte.Sdk.Api.Ugc.Wrapper;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Api.Ugc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Ugc
{
    [SdkConsoleCommand("ugc", "publicgeneratecontentuploadurlv2")]
    public class PublicGenerateContentUploadURLV2Command : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Ugc"; } }

        public string OperationName { get { return "PublicGenerateContentUploadURLV2"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("userId")]
        public string UserId { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsGenerateContentUploadURLRequest Body { get; set; } = new ModelsGenerateContentUploadURLRequest();

        public PublicGenerateContentUploadURLV2Command(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2 wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicContentV2(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Ugc.Operation.PublicGenerateContentUploadURLV2.Builder;





            PublicGenerateContentUploadURLV2 operation = opBuilder.Build(
                Body,
                ChannelId,
                ContentId,
                Namespace,
                UserId
            );


            AccelByte.Sdk.Api.Ugc.Model.ModelsGenerateContentUploadURLResponse? response = wrapper.PublicGenerateContentUploadURLV2(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}