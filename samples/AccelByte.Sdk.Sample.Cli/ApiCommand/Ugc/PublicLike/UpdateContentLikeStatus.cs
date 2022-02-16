// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

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
    [SdkConsoleCommand("ugc","updatecontentlikestatus")]
    public class UpdateContentLikeStatusCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "UpdateContentLikeStatus"; } }

        [SdkCommandArgument("contentId")]
        public string ContentId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsContentLikeRequest Body { get; set; } = new ModelsContentLikeRequest();
                
        public UpdateContentLikeStatusCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.PublicLike wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.PublicLike(_SDK);

            UpdateContentLikeStatus operation = new UpdateContentLikeStatus(
                ContentId,                
                Namespace,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsContentLikeResponse? response = wrapper.UpdateContentLikeStatus(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}