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

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc", "runzombiecleanerrequesthandler")]
    public class RunZombieCleanerRequestHandlerCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "RunZombieCleanerRequestHandler"; } }

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsDeleteZombieRequest Body { get; set; } = new ModelsDeleteZombieRequest();

        public RunZombieCleanerRequestHandlerCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.Admin wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.Admin(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.RunZombieCleanerRequestHandler.Builder;





            RunZombieCleanerRequestHandler operation = opBuilder.Build(
                Body,
                Namespace
            );


            wrapper.RunZombieCleanerRequestHandler(operation);
            return String.Empty;
        }
    }
}