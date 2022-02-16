// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","publicsearchitems")]
    public class PublicSearchItemsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "PublicSearchItems"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("region")]
        public string? Region { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("keyword")]
        public string Keyword { get; set; } = String.Empty;

        [SdkCommandArgument("language")]
        public string Language { get; set; } = String.Empty;

        public PublicSearchItemsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            PublicSearchItems operation = new PublicSearchItems(
                Namespace,                
                Limit,                
                Offset,                
                Region,                
                StoreId,                
                Keyword,                
                Language                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.ItemPagingSlicedResult? response = wrapper.PublicSearchItems(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}