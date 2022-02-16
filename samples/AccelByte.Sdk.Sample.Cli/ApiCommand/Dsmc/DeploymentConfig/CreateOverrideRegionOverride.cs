// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.IO;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Sample.Cli.Command;

using AccelByte.Sdk.Api.Dsmc.Wrapper;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Api.Dsmc.Operation;

namespace AccelByte.Sdk.Sample.Cli.ApiCommand.Dsmc
{
    [SdkConsoleCommand("dsmc","createoverrideregionoverride")]
    public class CreateOverrideRegionOverrideCommand: ISdkConsoleCommand
    {
        private AccelByteSDK _SDK;

        public string ServiceName{ get { return "Dsmc"; } }

        public string OperationName{ get { return "CreateOverrideRegionOverride"; } }

        [SdkCommandArgument("deployment")]
        public string Deployment { get; set; } = String.Empty;

        [SdkCommandArgument("namespace")]
        public string Namespace { get; set; } = String.Empty;

        [SdkCommandArgument("region")]
        public string Region { get; set; } = String.Empty;

        [SdkCommandArgument("version")]
        public string Version { get; set; } = String.Empty;

        [SdkCommandData("body")]
        public ModelsCreateRegionOverrideRequest Body { get; set; } = new ModelsCreateRegionOverrideRequest();
                
        public CreateOverrideRegionOverrideCommand(AccelByteSDK sdk)
        {
            _SDK = sdk;
        }

        public string Run()
        {
            AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig wrapper = new AccelByte.Sdk.Api.Dsmc.Wrapper.DeploymentConfig(_SDK);

            CreateOverrideRegionOverride operation = new CreateOverrideRegionOverride(
                Deployment,                
                Namespace,                
                Region,                
                Version,                
                Body                
            );            
            
            AccelByte.Sdk.Api.Dsmc.Model.ModelsDeploymentWithOverride? response = wrapper.CreateOverrideRegionOverride(operation);
            if (response == null)
                return "No response from server.";

            return SdkHelper.SerializeToJson(response);
        }
    }
}