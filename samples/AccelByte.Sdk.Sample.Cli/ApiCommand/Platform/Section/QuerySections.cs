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

using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Platform
{
    [SdkConsoleCommand("platform","querysections")]
    public class QuerySectionsCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Platform"; } }

        public string OperationName{ get { return "QuerySections"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("end")]
        public string? End { get; set; }

        [SdkCommandArgument("limit")]
        public int? Limit { get; set; }

        [SdkCommandArgument("offset")]
        public int? Offset { get; set; }

        [SdkCommandArgument("start")]
        public string? Start { get; set; }

        [SdkCommandArgument("storeId")]
        public string? StoreId { get; set; }

        [SdkCommandArgument("viewId")]
        public string? ViewId { get; set; }

        public QuerySectionsCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Section wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Section(_SDK);

            QuerySections operation = new QuerySections(
                Namespace,                
                End,                
                Limit,                
                Offset,                
                Start,                
                StoreId,                
                ViewId                
            );            
            
            AccelByte.Sdk.Api.Platform.Model.SectionPagingSlicedResult? response = wrapper.QuerySections(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}