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

using AccelByte.Sdk.Api.Group.Wrapper;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Api.Group.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Group
{
    [SdkConsoleCommand("group", "symbolhandler")]
    public class SymbolHandlerCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Group"; } }

        public string OperationName { get { return "SymbolHandler"; } }

        public SymbolHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Group.Wrapper.Operations wrapper = new AccelByte.Sdk.Api.Group.Wrapper.Operations(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Group.Operation.SymbolHandler.Builder;





            SymbolHandler operation = opBuilder.Build(
            );


            wrapper.SymbolHandler(operation);
            return String.Empty;
        }
    }
}