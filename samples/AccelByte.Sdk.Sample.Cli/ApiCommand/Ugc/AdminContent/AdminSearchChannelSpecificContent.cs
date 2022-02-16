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
    [SdkConsoleCommand("ugc","adminsearchchannelspecificcontent")]
    public class AdminSearchChannelSpecificContentCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Ugc"; } }

        public string OperationName{ get { return "AdminSearchChannelSpecificContent"; } }

        [SdkCommandArgument("channelId")]
        public string ChannelId { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("creator")]
        public string? Creator { get; set; }

        [SdkCommandArgument("isofficial")]
        public string? Isofficial { get; set; }

        [SdkCommandArgument("limit")]
        public string? Limit { get; set; }

        [SdkCommandArgument("name")]
        public string? Name { get; set; }

        [SdkCommandArgument("offset")]
        public string? Offset { get; set; }

        [SdkCommandArgument("orderby")]
        public string? Orderby { get; set; }

        [SdkCommandArgument("sortby")]
        public string? Sortby { get; set; }

        [SdkCommandArgument("subtype")]
        public string? Subtype { get; set; }

        [SdkCommandArgument("tags")]
        public string? Tags { get; set; }

        [SdkCommandArgument("type")]
        public string? Type { get; set; }

        [SdkCommandArgument("userId")]
        public string? UserId { get; set; }

        public AdminSearchChannelSpecificContentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent wrapper = new AccelByte.Sdk.Api.Ugc.Wrapper.AdminContent(_SDK);

            AdminSearchChannelSpecificContent operation = new AdminSearchChannelSpecificContent(
                ChannelId,                
                Namespace,                
                Creator,                
                Isofficial,                
                Limit,                
                Name,                
                Offset,                
                Orderby,                
                Sortby,                
                Subtype,                
                Tags,                
                Type,                
                UserId                
            );            
            
            AccelByte.Sdk.Api.Ugc.Model.ModelsPaginatedContentDownloadResponse? response = wrapper.AdminSearchChannelSpecificContent(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}