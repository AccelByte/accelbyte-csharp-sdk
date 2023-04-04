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
    [SdkConsoleCommand("platform", "searchitemtypeconfig")]
    public class SearchItemTypeConfigCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "SearchItemTypeConfig"; } }

        [SdkCommandArgument("clazz")]
        public string? Clazz { get; set; }

        [SdkCommandArgument("itemType")]
        public string ItemType { get; set; } = String.Empty;

        public SearchItemTypeConfigCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.Item wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.Item(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.SearchItemTypeConfig.Builder;

            if (Clazz != null)
                opBuilder.SetClazz((string)Clazz);




            SearchItemTypeConfig operation = opBuilder.Build(
                ItemType
            );


            AccelByte.Sdk.Api.Platform.Model.ItemTypeConfigInfo? response = wrapper.SearchItemTypeConfig(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}