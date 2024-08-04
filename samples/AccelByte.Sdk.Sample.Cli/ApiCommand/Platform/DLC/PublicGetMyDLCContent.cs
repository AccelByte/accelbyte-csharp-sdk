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
    [SdkConsoleCommand("platform", "publicgetmydlccontent")]
    public class PublicGetMyDLCContentCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Platform"; } }

        public string OperationName { get { return "PublicGetMyDLCContent"; } }

        [SdkCommandArgument("includeAllNamespaces")]
        public bool? IncludeAllNamespaces { get; set; }

        [SdkCommandArgument("type")]
        public string Type { get; set; } = String.Empty;

        public PublicGetMyDLCContentCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Platform.Wrapper.DLC wrapper = new AccelByte.Sdk.Api.Platform.Wrapper.DLC(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Platform.Operation.PublicGetMyDLCContent.Builder;

            if (IncludeAllNamespaces != null)
                opBuilder.SetIncludeAllNamespaces((bool)IncludeAllNamespaces);




            PublicGetMyDLCContent operation = opBuilder.Build(
                Type
            );


            AccelByte.Sdk.Api.Platform.Model.SimpleUserDLCRewardContentsResponse? response = wrapper.PublicGetMyDLCContent(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}