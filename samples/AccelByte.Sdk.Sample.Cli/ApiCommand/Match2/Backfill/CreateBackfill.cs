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

using AccelByte.Sdk.Api.Match2.Wrapper;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Api.Match2.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Match2
{
    [SdkConsoleCommand("match2","createbackfill")]
    public class CreateBackfillCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Match2"; } }

        public string OperationName{ get { return "CreateBackfill"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ApiBackFillCreateRequest Body { get; set; } = new ApiBackFillCreateRequest();
                
        public CreateBackfillCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Match2.Wrapper.Backfill wrapper = new AccelByte.Sdk.Api.Match2.Wrapper.Backfill(_SDK);

            CreateBackfill operation = new CreateBackfill(
                Namespace,                
                Body                
            );            
            
            wrapper.CreateBackfill(operation);
            return String.Empty;
        }
    }
}