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
    [SdkConsoleCommand("dsmc", "deletecreatingservercountqueue")]
    public class DeleteCreatingServerCountQueueCommand : ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName { get { return "Dsmc"; } }

        public string OperationName { get { return "DeleteCreatingServerCountQueue"; } }

        [SdkCommandArgument("deployment")]
        public string Deployment { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("version")]
        public string Version { get; set; } = String.Empty;

        public DeleteCreatingServerCountQueueCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig(_SDK);

            var opBuilder = AccelByte.Sdk.Api.Dsmc.Operation.DeleteCreatingServerCountQueue.Builder;





            DeleteCreatingServerCountQueue operation = opBuilder.Build(
                Deployment,
                Namespace,
                Version
            );


            wrapper.DeleteCreatingServerCountQueue(operation);
            return String.Empty;
        }
    }
}